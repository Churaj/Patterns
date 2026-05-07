namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Handles the execution of the CreateUserCommand.
    /// </summary>
    /// <remarks>This handler coordinates user creation and notification by invoking the associated services.
    /// It is intended for use within command processing pipelines where user onboarding is required.</remarks>
    internal class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        /// <summary>
        /// Initializes a new instance of the CreateUserCommandHandler class with the specified user and email services.
        /// </summary>
        /// <param name="userService">The user service used to manage user-related operations. Cannot be null.</param>
        /// <param name="emailService">The email service used to send notifications or confirmations. Cannot be null.</param>
        public CreateUserCommandHandler(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        /// <summary>
        /// Handles the creation of a new user and sends a welcome email.
        /// </summary>
        /// <param name="command">The command containing the user's name, surname, and email address. Cannot be null.</param>
        public void Handle(CreateUserCommand command)
        {
            _userService.Create(command.Name, command.Surname);
            _emailService.SendWelcomeLetter(command.Email);
        }
    }
}
