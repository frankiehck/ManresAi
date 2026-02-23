using Manres.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Manres.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrudController : ControllerBase
{
    private readonly DynamicCrudService _crud;

    public CrudController(DynamicCrudService crud)
    {
        _crud = crud;
    }

    [HttpGet("{entity}")]
    public async Task<IActionResult> List(string entity, [FromQuery] int skip = 0, [FromQuery] int take = 100)
    {
        var result = await _crud.ListAsync(entity, skip, take);
        return result.Success ? Ok(result.Payload) : BadRequest(result.Error);
    }

    [HttpGet("{entity}/{id}")]
    public async Task<IActionResult> Get(string entity, string id)
    {
        var result = await _crud.GetByIdAsync(entity, id);
        if (!result.Success)
        {
            return result.NotFound ? NotFound(result.Error) : BadRequest(result.Error);
        }

        return Ok(result.Payload);
    }

    [HttpPost("{entity}")]
    public async Task<IActionResult> Create(string entity, [FromBody] JsonElement body)
    {
        var result = await _crud.CreateAsync(entity, body);
        return result.Success ? Created($"/api/crud/{entity}", result.Payload) : BadRequest(result.Error);
    }

    [HttpPut("{entity}/{id}")]
    public async Task<IActionResult> Update(string entity, string id, [FromBody] JsonElement body)
    {
        var result = await _crud.UpdateAsync(entity, id, body);
        if (!result.Success)
        {
            return result.NotFound ? NotFound(result.Error) : BadRequest(result.Error);
        }

        return Ok(result.Payload);
    }

    [HttpDelete("{entity}/{id}")]
    public async Task<IActionResult> Delete(string entity, string id)
    {
        var result = await _crud.DeleteAsync(entity, id);
        if (!result.Success)
        {
            return result.NotFound ? NotFound(result.Error) : BadRequest(result.Error);
        }

        return NoContent();
    }
}
