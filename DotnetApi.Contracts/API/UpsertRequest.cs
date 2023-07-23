namespace DotnetApi.Contracts.API;
public record UpsertRequest(
   string Name,
   string Description,
   DateTime StartDateTime,
   DateTime EndDateTime
);