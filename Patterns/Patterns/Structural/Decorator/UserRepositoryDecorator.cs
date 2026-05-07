namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Adds base behavior for user repository decorators. This class implements the IUserRepository interface and holds a reference to an inner IUserRepository instance.
    /// It delegates the GetUserName method call to the inner repository, allowing derived classes to override and add additional behavior as needed.
    /// </summary>
    internal abstract class UserRepositoryDecorator : IUserRepository
    {
        protected readonly IUserRepository _innerUserRepository;

        protected UserRepositoryDecorator(IUserRepository innerUserRepository)
        {
            _innerUserRepository = innerUserRepository;
        }

        public virtual string GetUserName()
        {
            return _innerUserRepository.GetUserName();
        }
    }
}
