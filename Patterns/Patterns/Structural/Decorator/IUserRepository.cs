namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Defines a contract for retrieving user information from a data source.
    /// </summary>
    internal interface IUserRepository
    {
        public string GetUserName();
    }
}
