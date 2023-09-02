namespace BackEnd.Models.Constants;

public class MessageConstants
{
    public const string UserToken = "{{User}}";
    public const string LibraryNameToken = "{{LibraryName}}";
    public const string LibraryName = "LuminaLib";


    public const string WelcomeReaderSubject = "Welcome to {{LibraryName}} - Your Literary Adventure Begins!";
    public const string WelcomeReaderBody = "Dear {{User}},\r\n\r\n" +
        "Welcome to {{LibraryName}}! We are absolutely thrilled to have you join our community of passionate readers and" +
        " lifelong learners. 📚🌟\r\n\r\n" +
        "As a new member of {{LibraryName}}, you now have access to a world of knowledge, imagination, and discovery. " +
        "Whether you're here to explore classic literature, dive into the latest bestsellers, or uncover hidden gems in " +
        "our collection, we're here to support your literary journey every step of the way.\r\n\r\n" +
        "Warmest regards,\r\nThe {{LibraryName}} Team";
}