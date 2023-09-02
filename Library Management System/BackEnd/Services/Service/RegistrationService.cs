using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class RegistrationService : IRegistrationService
{
    private static RegistrationService? _instance;
    private readonly IValidationService _validatorService;
    private readonly IUserService _userService;
    private readonly IUserCredentialsService _userCredentialsService;
    private readonly IMessageTemplatesService _messageTemplatesService;
    private readonly IEmailService _emailService;

    private RegistrationService(IValidationService validatorService, 
        IUserService userService, IUserCredentialsService userCredentials, 
        IMessageTemplatesService messageTemplatesService, IEmailService emailService)
    {
        _validatorService = validatorService;
        _userService = userService;
        _userCredentialsService = userCredentials;
        _messageTemplatesService = messageTemplatesService;
        _emailService = emailService;

        EnsureAdminExists();
    }

    public static RegistrationService GetInstance(IValidationService validatorService, 
        IUserService userService, IUserCredentialsService userCredentials, 
        IMessageTemplatesService messageTemplatesService, IEmailService emailService)
    {
        _instance ??= new RegistrationService(validatorService, userService, userCredentials,
            messageTemplatesService, emailService);
        return _instance;
    }

    public (User UserInfo, UserCredentials UserCredentials)? RegisterUser(string name, string lastName, 
        string email, string username, string password, RoleOfUser userRole, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (ValidateUserInfo(ref name, ref lastName, email, username, password) is string validationError)
        {
            errorMessage = validationError;
            return null;
        }

        if (_userCredentialsService.CredentialExists(email, username) is string credentialError)
        {
            errorMessage = credentialError;
            return null;
        }

        var user = _userService.AddUser(name, lastName, userRole);
        var credentials = _userCredentialsService.AddCredential(email, username, password, user.Id);
        SendWelcomingEmail(user, credentials);

        return (user, credentials);
    }

    public (User UserInfo, UserCredentials UserCredentials)? SignIn(string username, string password)
    {
        var userCredentials = _userCredentialsService.FindUser(username);
        if (userCredentials == null) return null;
        if (userCredentials.Password != password)  return null;

        var user = _userService.FindUser(userCredentials.UserId);
        if (user == null) return null;

        return (user, userCredentials);
    }

    private string? ValidateUserInfo(ref string name, ref string lastName, string email, string username, string password)
    {
        if (!_validatorService.CheckName(ref name))
            return "Input valid Name, please...";
        if (!_validatorService.CheckName(ref lastName))
            return "Input valid Last Name, please...";
        if (!_validatorService.CheckEmailAddress(email))
            return "Input valid Email Address, please...";
        if (_validatorService.CheckUsername(username) is string usernameError)
            return usernameError;
        if (_validatorService.CheckPassword(password) is string PasswordError)
            return PasswordError;

        return null;
    }

    private void SendWelcomingEmail(User user, UserCredentials userCredentials)
    {
        var emailSubject = string.Empty;
        var emailBody = string.Empty;

        emailSubject = _messageTemplatesService.WelcomeReaderSubject(user.FullName);
        emailBody = _messageTemplatesService.WelcomeReaderBody(user.FullName);

        _emailService.SendEmailAsync(emailSubject, emailBody, userCredentials.Email);
    }

    private void EnsureAdminExists()
    {
        if (_userService.LibrarianExists())
            return;

        var defaultAdmin = _userService.AddUser("Admin", "Admin", RoleOfUser.Librarian);
        var defaultAdminCredentials = _userCredentialsService
                                .AddCredential("", "Admin", "Admin", defaultAdmin.Id);
    }
}