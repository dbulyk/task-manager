using Application.Interfaces;
using WebUI.Services;

namespace WebUI;

public static class ConfigureServices
{
    public static IServiceCollection AddWebUiServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddSingleton<ICurrentUserService, CurrentUserService>();

        services.AddHttpContextAccessor();
        
        services.AddControllersWithViews();
        services.AddRazorPages();

        return services;
    }
}