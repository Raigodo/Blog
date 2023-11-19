using System.Text.RegularExpressions;

namespace Blog.Application.Validators.Extensions;

public static class PasswordValidationExtensions
{
    public static bool IsValidPassword(this string password)
    {
        // Define the regular expressions for uppercase, lowercase, digit, and special symbol
        Regex uppercaseRegex = new Regex(@"[A-Z]");
        Regex lowercaseRegex = new Regex(@"[a-z]");
        Regex digitRegex = new Regex(@"[0-9]");
        Regex specialSymbolRegex = new Regex(@"[\W_]");

        // Check if the password contains at least one uppercase letter, one lowercase letter, one digit, and one special symbol
        bool hasUppercase = uppercaseRegex.IsMatch(password);
        bool hasLowercase = lowercaseRegex.IsMatch(password);
        bool hasDigit = digitRegex.IsMatch(password);
        bool hasSpecialSymbol = specialSymbolRegex.IsMatch(password);

        // Return true if all criteria are met
        return hasUppercase && hasLowercase && hasDigit && hasSpecialSymbol;
    }
}
