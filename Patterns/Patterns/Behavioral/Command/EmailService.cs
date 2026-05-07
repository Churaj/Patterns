namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Provides email-related services such as sending welcome letters to users.
    /// </summary>
    internal class EmailService : IEmailService
    {
        /// <summary>
        /// Sends a welcome letter to the specified email address.
        /// </summary>
        /// <param name="email">The email address of the recipient. Cannot be null or empty.</param>
        public void SendWelcomeLetter(string email)
        {
            // Emulate sending a welcome letter.
        }
    }
}
