namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Defines methods for sending SMS messages using the MegaSmsCorp service.
    /// </summary>
    public interface IMegaSmsCorpClient
    {
        void DispatchMessage(string recipient, string message);
    }
}