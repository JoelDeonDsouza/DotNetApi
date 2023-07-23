using DotnetApi.Contracts.API;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers;

[ApiController]
public class DotNetController : ControllerBase
{
    // /! post request /
    [HttpPost("/dotnet")]
    public IActionResult CreateApi(CreateRequest request)
    {
        return Ok(request);
    }
    // /! Get request /
    [HttpGet("/dotnet/{id:guid}")]
    public IActionResult GetApi(Guid id)
    {
        return Ok(id);
    }
    // /! Put request /
    [HttpPut("/dotnet/{id:guid}")]
    public IActionResult UpsertApi(Guid id, UpsertRequest request)
    {
        return Ok(request);
    }
    // /! Delete request /
    [HttpDelete("/dotnet/{id:guid}")]
    public IActionResult DeleteApi(Guid id)
    {
        return Ok(id);
    }
}