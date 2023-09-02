using BackEnd.Services.Interfaces;
using System.Text.RegularExpressions;

namespace BackEnd.Services.Service;

public class ValidationService : IValidationService
{
    private static ValidationService? _instance;

    private ValidationService()
    {
    }

    public static ValidationService GetInstance()
    {
        _instance ??= new ValidationService();
        return _instance;
    }

    public string? CheckUsername(string username)
    {
        bool hasStartLowercase = Regex.IsMatch(username, "^[a-z]");
        bool hasValidCharacters = Regex.IsMatch(username, "^[a-z0-9-_.]*$");
        bool isValidMinLength = username.Length >= 4;
        bool isValidMaxLength = username.Length <= 25;
        bool noConsecutiveSpecialChars = !Regex.IsMatch(username, "[-_.]{2,}");
        bool noEndingSpecialChar = !Regex.IsMatch(username, "[-_.]$");
        bool noDigitFollowedBySpecialChar = !Regex.IsMatch(username, "\\d[-_.]");
        bool noSpecialCharFollowedByDigit = !Regex.IsMatch(username, "[-_.]\\d");

        if (!isValidMinLength)
            return "Username must be at least 4 characters long.";
        if (!isValidMaxLength)
            return "Username length can't exceed 25 characters.";
        if (!hasStartLowercase)
            return "Username must start with a lowercase letter.";
        if (!hasValidCharacters)
            return "Username can only contain lowercase letters, digits, hyphens, underscores, or periods.";
        if (!noConsecutiveSpecialChars)
            return "Username cannot have consecutive hyphens, underscores, or periods.";
        if (!noDigitFollowedBySpecialChar)
            return "Username cannot have a digit followed immediately by a hyphen, underscore, or period.";
        if (!noSpecialCharFollowedByDigit)
            return "Username cannot have a hyphen, underscore, or period followed immediately by a digit.";
        if (!noEndingSpecialChar)
            return "Username cannot end with a hyphen, underscore, or period.";

        return null;
    }

    public bool CheckEmailAddress(string emailAddress)
    {
        var pattern = @"^[a-zA-Z]{4,}[a-zA-Z0-9]*(\.[a-zA-Z0-9]{4,})*@[a-zA-Z0-9]{4,}\.[a-zA-Z]{2,}[a-zA-Z]*$";

        return Regex.IsMatch(emailAddress, pattern);
    }

    public string? CheckPassword(string password)
    {

        bool hasLowercase = Regex.IsMatch(password, "[a-z]");
        bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
        bool hasDigit = Regex.IsMatch(password, "\\d");
        bool hasSpecialChar = Regex.IsMatch(password, "[@$!%*#?&^_+\\-=\\[\\]{}()|:;<>,.?/]");
        bool isValidMinLength = password.Length >= 8;
        bool isValidMaxLength = password.Length <= 20;

        if (!isValidMinLength)
            return "Password must be at least 8 characters long.";
        if (!hasLowercase)
            return "Password must contain at least one lowercase letter.";
        if (!hasUppercase)
            return "Password must contain at least one uppercase letter.";
        if (!hasDigit)
            return "Password must contain at least one digit.";
        if (!hasSpecialChar)
            return "Password must contain at least one special character.";
        if (!isValidMaxLength)
            return "Password length can't exceed 20 characters.";

        return null;
    }

    public bool CheckName(ref string name)
    {
        AdjustName(ref name);

        var pattern = "^(?=.{2,40}$)[A-Za-z]+('[A-Za-z]+)*$";
        return Regex.IsMatch(name, pattern);
    }

    public bool CheckLastName(ref string lastName)
    {
        AdjustLastName(ref lastName);

        return Regex.IsMatch(lastName, "^[A-Za-z\\s-]*$") && Regex.IsMatch(lastName, "^(?!.*(--|\\s\\s))[A-Za-z\\s-]*$");
    }

    private void AdjustName(ref string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            name = name.Trim();
            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }   
    }

    private void AdjustLastName(ref string lastName)
    {
        var names = lastName.Split();
       
        if (names.Length == 1)
        {
            AdjustName(ref lastName);
            return;
        }
        else if (names.Length > 1)
        {
            lastName = "";
            for (var i = 0; i < names.Length; i++)
            {
                AdjustName(ref names[i]);
                lastName += names[i];
                lastName += " ";
            }
            lastName = lastName.Trim();
        }
    }

    public string? CheckGenreName(string genreName)
    {
        bool hasOnlyLettersAndWhitespaces = Regex.IsMatch(genreName, "^[A-Za-z\\s-]*$");
        bool noConsecutiveWhitespaces = Regex.IsMatch(genreName, "^(?!.*(--|\\s\\s))[A-Za-z\\s-]*$");

        if (string.IsNullOrWhiteSpace(genreName))
            return "Genre name can't be null";
        if (!hasOnlyLettersAndWhitespaces)
            return "Genre can contain only letters, dash and whitespace";
        if (genreName.Length < 2)
            return "Genre can't be one letter";
        if (!noConsecutiveWhitespaces)
            return "Consecutive whitespaces or dashes are not allowed!";
        if (!char.IsAsciiLetter(genreName[^1]))
            return "Genre name should end with a letter.";

        return null;
    }
}