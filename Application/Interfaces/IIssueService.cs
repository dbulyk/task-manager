using Domain.Entities;

namespace Application.Interfaces;

public interface IIssueService
{
    public Task<Issue?> GetIssue(int id);
    public Task<List<Issue>> GetIssues();
    public Task<Issue> CreateIssue(Issue issue);
    public Task<Issue?> UpdateIssue(int id, Issue issue);
    public Task<bool> DeleteIssue(int id);
}