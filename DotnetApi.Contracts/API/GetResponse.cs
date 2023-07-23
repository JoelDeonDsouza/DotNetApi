namespace DotnetApi.Contracts.API;
public record GetResponse(
   Guid Id,
   string Name,
   string Description,
   DateTime StartDateTime,
   DateTime EndDateTime
);