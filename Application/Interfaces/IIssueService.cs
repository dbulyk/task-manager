using Domain.Entities;

namespace Application.Interfaces;

public interface IIssueService
{
    public Task<Task?> GetIssue(int id);
    public Task<List<Task>> GetIssues();
    public Task<Task?> CreateIssue(Issue issue);
    public Task<Task?> UpdateIssue(int id, Issue issue);
}