namespace Patterns.Structural.Decorator
{
    /// <summary>
    /// Represents a contract for a memory-based cache that allows storing and retrieving objects in memory.
    /// </summary>
    /// <remarks>Implementations of this interface provide mechanisms for temporarily storing data in memory
    /// to improve application performance by reducing the need to recompute or refetch data. Typical usage scenarios
    /// include caching frequently accessed data or results of expensive operations.</remarks>
    internal interface IMemoryCache
    {
    }
}
