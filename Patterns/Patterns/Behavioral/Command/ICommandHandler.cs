namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Defines a handler for processing commands of a specified type.
    /// </summary>
    /// <typeparam name="T">The type of command to handle.</typeparam>
    internal interface ICommandHandler<in T>
    {
        /// <summary>
        /// Handles the specified command of type T.
        /// </summary>
        /// <param name="command">The command to be processed. Cannot be null.</param>
        void Handle(T command);
    }
}