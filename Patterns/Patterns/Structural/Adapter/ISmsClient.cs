namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Defines the contract for sending SMS messages to recipients.
    /// </summary>
    /// <remarks>Implementations of this interface are responsible for delivering SMS messages to the
    /// specified recipients. The behavior, delivery guarantees, and supported message formats may vary depending on the
    /// implementation.</remarks>
    public interface ISmsClient
    {
        void SendMessage(string message, string recipient);
    }
}