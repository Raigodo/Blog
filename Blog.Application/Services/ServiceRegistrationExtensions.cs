using Blog.Application.Services.Account;
using Blog.Application.Services.Features;
using Blog.Application.Services.Profile;
using Blog.Application.Services.Security;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Application.Services;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<CommentingService>();
        services.AddScoped<NotiffierService>();
        services.AddScoped<PostCreatorService>();
        services.AddScoped<PostViewerService>();
        services.AddScoped<ProfileCustomizationService>();
        services.AddScoped<ProfileViewerService>();
        services.AddScoped<UserActivityViewerService>();
        services.AddScoped<AccountRecoveryService>();
        services.AddScoped<AuthenticationService>();
        return services;
    }
}
