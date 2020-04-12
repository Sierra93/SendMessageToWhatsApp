using System;
using WhatsAppApi;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TestSendWhatsApp {
    class Program {
        static void Main(string[] args) {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC55de8cba556cb38987c3b1e470a6b3d9";
            const string authToken = "68e4eaa6f9caa73d124530d29c68e881";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                body: "test 1",
                to: new Twilio.Types.PhoneNumber("whatsapp:+79856838046")
            );
            Console.WriteLine(message.Sid);
            Console.ReadKey();
        }
    }
}
