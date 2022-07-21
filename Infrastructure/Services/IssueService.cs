using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services;

public class IssueService : IIssueService
{
    public Task<Task?> GetIssue(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Task>> GetIssues()
    {
        throw new NotImplementedException();
    }

    public Task<Task?> CreateIssue(Issue issue)
    {
        throw new NotImplementedException();
    }

    public Task<Task?> UpdateIssue(int id, Issue issue)
    {
        throw new NotImplementedException();
    }
}