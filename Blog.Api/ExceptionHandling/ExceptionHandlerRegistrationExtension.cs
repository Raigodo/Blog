namespace Blog.Api.ExceptionHandling;

public static class ExceptionHandlerRegistrationExtension
{
    public static WebApplication UseExceptionMiddleware(this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
        return app;
    }
}
