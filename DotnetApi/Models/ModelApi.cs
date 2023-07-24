namespace DotNetApi.Models;

public class ModelApi
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }

    public ModelApi(Guid id, string name, string description, DateTime startDateTime, DateTime endDateTime)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
    }
}