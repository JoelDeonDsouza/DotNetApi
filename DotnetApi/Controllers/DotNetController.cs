using DotnetApi.Contracts.API;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DotNetController : ControllerBase
{
    // /! post request /
    [HttpPost()]
    public IActionResult CreateApi(CreateRequest request)
    {
        return Ok(request);
    }
    // /! Get request /
    [HttpGet("{id:guid}")]
    public IActionResult GetApi(Guid id)
    {
        return Ok(id);
    }
    // /! Put request /
    [HttpPut("{id:guid}")]
    public IActionResult UpsertApi(Guid id, UpsertRequest request)
    {
        return Ok(request);
    }
    // /! Delete request /
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteApi(Guid id)
    {
        return Ok(id);
    }
}