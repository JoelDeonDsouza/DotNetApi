namespace DotnetApi.Contracts.API;
public record CreateRequest(
   string Name,
   string Description,
   DateTime StartDateTime,
   DateTime EndDateTime
);