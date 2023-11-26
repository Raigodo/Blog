using Blog.Api.ExceptionHandling;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;
using Blog.Infrastructure.DataAcess;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace Blog.Api;

public static class ServiceRegistrationExtensions
{
    public static WebApplication UseExceptionMiddleware(this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
        return app;
    }

    public static IServiceCollection AddCookieAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/api/authentication/login";
                options.Cookie.Name = options.LoginPath;
            });
        return services;
    }

    public static IServiceCollection AddApplicationIdentity(this IServiceCollection services)
    {
        services.AddIdentityCore<UserEntity>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;

            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 3;
            options.Password.RequiredUniqueChars = 0;

            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            options.User.AllowedUserNameCharacters =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            options.User.RequireUniqueEmail = false;
        })
        .AddRoles<IdentityRole<UserId>>()
        .AddEntityFrameworkStores<ApplicationDbContext>();
        return services;
    }
}
