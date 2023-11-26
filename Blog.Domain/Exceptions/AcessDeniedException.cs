namespace Blog.Domain.Exceptions;

public class AcessDeniedException : Exception
{
    public AcessDeniedException(string message)
        : base(message)
    {
    }

    public AcessDeniedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
