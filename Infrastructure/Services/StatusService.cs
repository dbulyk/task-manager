using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services;

public class StatusService : IStatusService
{
    public Task<Status?> GetStatus(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Status>> GetStatuses()
    {
        throw new NotImplementedException();
    }

    public Task<Status> CreateStatus(Status status)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteStatus(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Status?> UpdateStatus(int id, Status status)
    {
        throw new NotImplementedException();
    }
}