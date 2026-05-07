namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Provides user-related operations such as creating new users.
    /// </summary>
    internal class UserService : IUserService
    {
        /// <summary>
        /// Creates a new user with the specified first and last names.
        /// </summary>
        /// <param name="name">The first name of the user to create. Cannot be null or empty.</param>
        /// <param name="surname">The last name of the user to create. Cannot be null or empty.</param>
        public void Create(string name, string surname)
        {
            // Emulate user creation.
        }
    }
}
