namespace Blog.Application.Validators.Extensions;

public static class GuidValidationExtensions
{
    public static bool IsValidGuid(this string stringValue, out Guid parsedGuid)
    {
        return Guid.TryParse(stringValue, out parsedGuid);
    }

    public static bool IsValidGuid(this string stringValue)
    {
        return Guid.TryParse(stringValue, out _);
    }
}