namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Represents an in-memory cache implementation for storing and retrieving objects during the application's
    /// lifetime.
    /// </summary>
    /// <remarks>This class provides a mechanism for temporarily storing data in memory to improve application
    /// performance by reducing the need to repeatedly compute or retrieve data. It implements the IMemoryCache
    /// interface, allowing for integration with dependency injection and consistent cache management across the
    /// application.</remarks>
    internal class MemoryCache : IMemoryCache
    {
    }
}
