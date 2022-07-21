using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services;

public class StatusService : IStatusService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<StatusService> _logger;

    public StatusService(ApplicationDbContext context, ILogger<StatusService> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<Status?> GetStatus(int id)
    {
        var status = await _context.Statuses.FirstOrDefaultAsync(status => status.Id == id);
        
        _logger.LogInformation("Запрошен статус c id == {Id}", id);
        return status;
    }

    public async Task<List<Status>> GetStatuses()
    {
        var statuses = await _context.Statuses.ToListAsync();
        
        _logger.LogInformation("Запрошен список всех статусов");
        return statuses;
    }

    public async Task<Status> CreateStatus(Status status)
    {
        _context.Statuses.Add(status);
        await _context.SaveChangesAsync();
        
        _logger.LogInformation("Создан статус с id {Id}", status.Id);
        return status;
    }

    public Task<Status> UpdateStatus(int id, Status status)
    {
        throw new NotImplementedException();
    }
    
    public async Task<bool> DeleteStatus(int id)
    {
        var status = await _context.Statuses.FirstOrDefaultAsync(status => status.Id == id);

        if (status == null)
        {
            _logger.LogInformation("Не удалось удалить статус. Причина: не найден статус с id {Id}", id);
            return false;
        }

        _context.Statuses.Remove(status);
        await _context.SaveChangesAsync();
        
        _logger.LogInformation("Создана статус с id {Id}", status.Id);
        return true;
    }
}