// Code sample for ASP.NET Core on .NET Core
// From command prompt, run:
// dotnet add package Twilio.AspNet.Core

using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;
using Twilio;
using Twilio.Rest.Messaging.V1;
using TwilioSms.Models;
using Microsoft.AspNetCore.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;
using System.ComponentModel.DataAnnotations;


namespace TwilioSms.Controllers
{
public class SmsController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            var response = new MessagingResponse();
            var message = new Message();
            var myNumber = "YOUR_PHONE_NUMBER";

            if (incomingMessage.From == myNumber)
            {
                //this is me responding to a message
                var incomingString = incomingMessage.Body;
                string[] splitMsg = incomingString.Split(":");

                if (splitMsg.Length < 2){
                        message.To = myNumber;
                        message.Body("You need to specify a recipient number and a ':' before the message. For example, '+12223334444: message.'");
                }
                else{
                message.Body(splitMsg[1]);
                message.To = splitMsg[0];

                }

            }
            else
            {
            message.Body(incomingMessage.Body);
            message.To = myNumber;

            }
            response.Append(message);
            return TwiML(response);

        }



    }
}

