namespace Application.Interfaces;

public interface IIdentityService
{
    Task<string> GetUserNameAsync(string userId);

    Task<bool> IsInRoleAsync(string userId, string role);

    Task<bool> AuthorizeAsync(string userId, string policyName);

    Task<string> CreateUserAsync(string email, string password);

    Task<bool> DeleteUserAsync(string userId);
}