using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// Provides an adapter that enables the use of an IMegaSmsCorpClient instance through the ISmsClient interface.
    /// </summary>
    /// <remarks>This adapter allows integration with MegaSmsCorp's SMS sending functionality in systems that
    /// expect an ISmsClient implementation. Use this class to bridge between different SMS client abstractions without
    /// modifying existing code that depends on ISmsClient.</remarks>
    public class MegaSmsClientAdapter : ISmsClient
    {
        private readonly IMegaSmsCorpClient _adapteeMegaSmsCorpClient;

        public MegaSmsClientAdapter(IMegaSmsCorpClient adapteeMegaSmsCorpClient)
        {
            _adapteeMegaSmsCorpClient = adapteeMegaSmsCorpClient;
        }

        public void SendMessage(string message, string recipient)
        {
            // Adapt the SendMessage method to call the DispatchMessage method of the MegaSmsCorp client.
            _adapteeMegaSmsCorpClient.DispatchMessage(recipient, message);
        }
    }
}
