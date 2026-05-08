using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Adapter
{
    internal class SmsControllerEmulator : ISmsControllerEmulator
    {
        private readonly ISmsClient _smsClient;

        public SmsControllerEmulator(ISmsClient smsClient)
        {
            _smsClient = smsClient;
        }

        public void DoSomethingWithSms()
        {
            _smsClient.SendMessage("hi", "email@email.com");
        }
    }
}
