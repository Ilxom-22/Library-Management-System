using BackEnd.DataLayer.Context;
using BackEnd.Services.Service;

namespace FrontEnd
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dataContext = new AppDataContext();
            var validationService = ValidationService.GetInstance();
            var userService = new UserService(dataContext);
            var userCredentialsService = new UserCredentialsService(dataContext);
            var messageTemplateService = new MessageTemplatesService();
            var emailService = new EmailService();
            var authorService = new AuthorService(dataContext, validationService);
            var bookGenreRelation = new BookAndGenreRelationService(dataContext);
            var genreService = new GenreService(dataContext, validationService, bookGenreRelation);
            var ratingService = new RatingService(dataContext);
            var bookService = new BookService(dataContext, authorService, genreService, bookGenreRelation, ratingService);
            var borrowBookService = new BorrowBookService(dataContext, bookService, userService, userCredentialsService);

            var registrationService = RegistrationService.GetInstance(validationService,
                userService, userCredentialsService, messageTemplateService, emailService);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationWindow(registrationService, authorService, genreService, bookService, userService, borrowBookService, userCredentialsService));
        }
    }
}