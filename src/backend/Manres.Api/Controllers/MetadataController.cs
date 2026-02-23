using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Manres.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MetadataController : ControllerBase
{
    private readonly ManresDbContext _db;

    public MetadataController(ManresDbContext db)
    {
        _db = db;
    }

    [HttpGet("tables")]
    public IActionResult GetTables()
    {
        var tables = _db.Model.GetEntityTypes()
            .OrderBy(e => e.GetTableName())
            .Select(e => new
            {
                table = e.GetTableName(),
                model = e.ClrType.Name,
                primaryKey = e.FindPrimaryKey()?.Properties.Select(p => p.Name).ToArray() ?? Array.Empty<string>(),
                columns = e.GetProperties().Select(p => new
                {
                    property = p.Name,
                    column = p.GetColumnName(StoreObjectIdentifier.Table(e.GetTableName()!, null)),
                    type = p.ClrType.Name,
                    nullable = p.IsNullable
                })
            });

        return Ok(tables);
    }
}
