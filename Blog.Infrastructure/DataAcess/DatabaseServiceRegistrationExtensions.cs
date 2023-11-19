using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.User;
using Blog.Infrastructure.DataAcess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Infrastructure.DataAcess;

public static class DatabaseServiceRegistrationExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ICommentRepository, CommentRepository>();
        services.AddTransient<IPostRepository, PostRepository>();
        services.AddTransient<IParticipantRepository, ParticipantRepository>();
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddIdentityCore<UserEntity>()
            .AddEntityFrameworkStores<ApplicationDbContext>();
        return services;
    }
}
