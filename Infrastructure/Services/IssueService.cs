using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services;

public class IssueService : IIssueService
{
    public Task<Issue?> GetIssue(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Issue>> GetIssues()
    {
        throw new NotImplementedException();
    }

    public Task<Issue?> CreateIssue(Issue issue)
    {
        throw new NotImplementedException();
    }

    public Task<Issue?> UpdateIssue(int id, Issue issue)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteIssue(int id)
    {
        throw new NotImplementedException();
    }
}