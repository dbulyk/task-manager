using Domain.ValueObjects;

namespace Domain.Entities;

public class Issue : BaseEntity
{
    public string Description { get; set; }
    public Status IssueStatus { get; set; }
    public string AuthorId { get; set; } 
    public string ExecutorId { get; set; }
    public Colour Colour { get; set; } = Colour.White;
}