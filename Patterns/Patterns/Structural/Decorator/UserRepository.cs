namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Provides methods for accessing and managing user information from a data source.
    /// </summary>
    internal class UserRepository : IUserRepository
    {
        public string GetUserName()
        {
            // In a real implementation, this method would retrieve user information from a database or other data source.
            return "test user";
        }
    }
}
