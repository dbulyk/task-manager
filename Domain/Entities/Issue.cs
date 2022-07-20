namespace Domain.Entities;

public class Issue : BaseEntity
{
    public string Description { get; set; }
    public Status Status { get; set; }
    public string AuthorId { get; set; } 
    public string ExecutorId { get; set; }
}