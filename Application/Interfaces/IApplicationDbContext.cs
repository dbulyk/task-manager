using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Status> Statuses { get; }
    DbSet<Issue> Issues { get; }
}