using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Application;

public static class ServiceRegisrationExtensions
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<IValidatorAssemblyMarker>();
        return services;
    }
}
