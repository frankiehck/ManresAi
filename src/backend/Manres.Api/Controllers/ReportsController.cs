using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Manres.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly ManresDbContext _db;

    public ReportsController(ManresDbContext db)
    {
        _db = db;
    }

    [HttpGet("summary")]
    public async Task<IActionResult> GetSummary()
    {
        var items = new List<object>();

        foreach (var entity in _db.Model.GetEntityTypes().OrderBy(e => e.GetTableName()))
        {
            var table = entity.GetTableName() ?? entity.ClrType.Name;
            var count = await _db.Set(entity.ClrType).AsNoTracking().CountAsync();
            items.Add(new
            {
                table,
                count,
                columns = entity.GetProperties().Count(),
                primaryKey = entity.FindPrimaryKey()?.Properties.Select(p => p.Name).ToArray() ?? Array.Empty<string>()
            });
        }

        return Ok(items);
    }

    [HttpGet("table/{entity}/csv")]
    public async Task<IActionResult> ExportTableCsv(string entity, [FromQuery] int take = 1000)
    {
        var entityType = _db.Model.GetEntityTypes().FirstOrDefault(e =>
            string.Equals(e.GetTableName(), entity, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(e.ClrType.Name, entity, StringComparison.OrdinalIgnoreCase));

        if (entityType == null)
        {
            return NotFound($"Unknown entity '{entity}'.");
        }

        take = Math.Clamp(take, 1, 5000);
        var rows = await _db.Set(entityType.ClrType).AsNoTracking().Take(take).ToListAsync();
        var props = entityType.ClrType.GetProperties().OrderBy(p => p.Name).ToArray();

        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", props.Select(p => Escape(p.Name))));

        foreach (var row in rows)
        {
            sb.AppendLine(string.Join(",", props.Select(p => Escape(p.GetValue(row)?.ToString() ?? string.Empty))));
        }

        var bytes = Encoding.UTF8.GetBytes(sb.ToString());
        return File(bytes, "text/csv", $"{(entityType.GetTableName() ?? entity)}.csv");
    }

    private static string Escape(string value)
    {
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
        {
            return '"' + value.Replace("\"", "\"\"") + '"';
        }

        return value;
    }
}
