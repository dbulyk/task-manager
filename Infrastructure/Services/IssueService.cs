using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services;

public class IssueService : IIssueService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<IssueService> _logger;

    public IssueService(ApplicationDbContext context, ILogger<IssueService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<Issue?> GetIssue(int id)
    {
        var issue = await _context.Issues.FirstOrDefaultAsync(issue => issue.Id == id);
        
        _logger.LogInformation("Запрошена задача c id {Id}", id);
        return issue;
    }

    public async Task<List<Issue>> GetIssues()
    {
        var issues = await _context.Issues.ToListAsync();
        
        _logger.LogInformation("Запрошен список всех задач");
        return issues;
    }

    public async Task<Issue> CreateIssue(Issue issue)
    {
        _context.Issues.Add(issue);
        await _context.SaveChangesAsync();
        
        _logger.LogInformation("Создана задача с id {Id}", issue.Id);
        return issue;
    }

    public async Task<Issue?> UpdateIssue(int id, Issue issue)
    {
        var existingIssue = await _context.Issues.FirstOrDefaultAsync(i => i.Id == id);
        if (existingIssue == null) return null;

        //TODO посмотреть как правильно апдейтить сущности
        existingIssue.Description = issue.Description;
        existingIssue.Status = issue.Status;
        existingIssue.ExecutorId = issue.ExecutorId;
        existingIssue.Name = issue.Name;

        await _context.SaveChangesAsync();
        return existingIssue;
    }

    public async Task<bool> DeleteIssue(int id)
    {
        var issue = await _context.Issues.FirstOrDefaultAsync(issue => issue.Id == id);

        if (issue == null)
        {
            _logger.LogInformation("Не удалось удалить задачу. Причина: не найдена задача с id {Id}", id);
            return false;
        }

        _context.Issues.Remove(issue);
        await _context.SaveChangesAsync();
        
        _logger.LogInformation("Задача с id {Id} успешно удалена", id);
        return true;
    }
}