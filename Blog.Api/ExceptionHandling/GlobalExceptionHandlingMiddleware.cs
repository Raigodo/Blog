using Blog.Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace Blog.Api.ExceptionHandling;

public class GlobalExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (AcessDeniedException ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.Forbidden);
        }
        catch (ConflictException ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.Conflict);
        }
        catch (NotFoundException ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.NotFound);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.InternalServerError);
        }
    }


    private async Task HandleExceptionAsync(HttpContext context, Exception ex, HttpStatusCode statusCode)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        var error = new Error
        {
            StatusCode = context.Response.StatusCode.ToString(),
            Message = ex.Message,
        };

        await context.Response.WriteAsync(JsonSerializer.Serialize(error));
    }
}