namespace Patterns.Behavioral.Command
{
    /// <summary>
    /// Defines methods for creating and managing user accounts.
    /// </summary>
    internal interface IUserService
    {
        /// <summary>
        /// Creates a new entity using the specified name and surname.
        /// </summary>
        /// <param name="name">The first name to assign to the new entity. Cannot be null or empty.</param>
        /// <param name="surname">The surname to assign to the new entity. Cannot be null or empty.</param>
        void Create(string name, string surname);
    }
}
