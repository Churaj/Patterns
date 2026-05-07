namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Provides an emulator for API controller actions that process user creation commands. Intended for use in
    /// scenarios where a real API controller is not available, such as testing or simulation environments.
    /// </summary>
    /// <remarks>This class simulates the behavior of an API controller by accepting user creation commands
    /// and delegating their handling to the specified command handler. It is useful for testing command processing
    /// logic without requiring a full web API infrastructure.</remarks>
    internal class ApiControllerEmulator
    {
        private readonly ICommandHandler<CreateUserCommand> _commandHandler;

        /// <summary>
        /// Initializes a new instance of the ApiControllerEmulator class with the specified command handler.
        /// </summary>
        /// <param name="commandHandler">The command handler used to process CreateUserCommand requests. Cannot be null.</param>
        public ApiControllerEmulator(ICommandHandler<CreateUserCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        /// <summary>
        /// Controller action emulation. In real life, this method would be an action of an API controller,
        /// and the command would be created from the request body.
        /// </summary>
        /// <param name="command"></param>
        public void CreateUser(CreateUserCommand command)
        {
            _commandHandler.Handle(command);
        }
    }
}
