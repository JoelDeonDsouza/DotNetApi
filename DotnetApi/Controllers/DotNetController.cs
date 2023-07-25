using DotnetApi.Contracts.API;
using DotNetApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DotNetController : ControllerBase
{
    // /! post request /
    [HttpPost]
    public IActionResult CreateApi(CreateRequest request)
    {
        var modelApi = new ModelApi(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime
            );
        var response = new ModelApiResponse(
            modelApi.Id,
            modelApi.Name,
            modelApi.Description,
            modelApi.StartDateTime,
            modelApi.EndDateTime
        );
        return CreatedAtAction(actionName: nameof(GetApi), routeValues: new { id = modelApi.Id }, response);
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

    private class ModelApiResponse
    {
        private Guid id;
        private string name;
        private string description;
        private DateTime startDateTime;
        private DateTime endDateTime;

        public ModelApiResponse(Guid id, string name, string description, DateTime startDateTime, DateTime endDateTime)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
        }
    }
}