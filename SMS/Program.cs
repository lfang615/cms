using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
            
            TwilioClient.Init(accountSid, authToken);

            //var message = MessageResource.Create(
            //    body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
            //    from: new Twilio.Types.PhoneNumber("+3197010254964"),
            //    to: new Twilio.Types.PhoneNumber("+17738146679")
            //);

            //Console.WriteLine(message.Sid);
        }
    }
}
