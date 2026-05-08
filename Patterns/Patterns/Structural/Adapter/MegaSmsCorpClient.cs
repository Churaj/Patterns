namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Adaptee class representing the MegaSmsCorp client, which has a different interface than the one expected by the client code.
    /// This class will be adapted to work with the client code through an adapter.
    /// </summary>
    public class MegaSmsCorpClient : IMegaSmsCorpClient
    {
        public void DispatchMessage(string recipient, string message)
        {
            // Simulate sending a message through the MegaSmsCorp client.
        }
    }
}
