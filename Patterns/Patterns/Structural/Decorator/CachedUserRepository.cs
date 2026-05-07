namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Provides a user repository decorator that adds in-memory caching to user data retrieval operations.
    /// </summary>
    /// <remarks>Use this class to improve performance by reducing redundant access to the underlying user
    /// repository. CachedUserRepository stores user data in an in-memory cache, which can decrease latency and lower
    /// the load on the data source. This class is intended for scenarios where user data does not change frequently and
    /// caching is beneficial. Thread safety and cache expiration policies depend on the provided IMemoryCache
    /// implementation.</remarks>
    internal class CachedUserRepository : UserRepositoryDecorator
    {
        private readonly IMemoryCache _memoryCache;

        /// <summary>
        /// Initializes a new instance of the CachedUserRepository class that decorates an existing user repository with
        /// in-memory caching capabilities.
        /// </summary>
        /// <remarks>This constructor enables caching for user repository operations by combining the
        /// specified repository with an in-memory cache. Caching can improve performance by reducing repeated data
        /// retrievals from the underlying repository.</remarks>
        /// <param name="innerUserRepository">The underlying user repository to be wrapped and extended with caching functionality. Cannot be null.</param>
        /// <param name="memoryCache">The memory cache instance used to store and retrieve cached user data. Cannot be null.</param>
        public CachedUserRepository(IUserRepository innerUserRepository, IMemoryCache memoryCache) : base(innerUserRepository)
        {
            _memoryCache = memoryCache;
        }

        public override string GetUserName()
        {
            // In a real implementation, this method would check the cache for the username before retrieving it from the underlying repository.
            return base.GetUserName() + " some cache test metadata";
        }
    }
}
