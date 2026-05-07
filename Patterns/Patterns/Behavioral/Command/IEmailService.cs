namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Defines a service for sending welcome letters to users via email.
    /// </summary>
    internal interface IEmailService
    {
        /// <summary>
        /// Sends a welcome letter to the specified email address.
        /// </summary>
        /// <param name="email">The email address of the recipient. Cannot be null or empty.</param>
        void SendWelcomeLetter(string email);
    }
}
