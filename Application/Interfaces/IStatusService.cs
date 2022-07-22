using Domain.Entities;

namespace Application.Interfaces;

public interface IStatusService
{
    public Task<Status?> GetStatus(int id);
    public Task<List<Status>> GetStatuses();
    public Task<Status> CreateStatus(Status status);
    public Task<Status?> UpdateStatus(int id, Status status);
    public Task<bool> DeleteStatus(int id);
}