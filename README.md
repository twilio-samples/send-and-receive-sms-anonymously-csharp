## About

This app shows how to build a an SMS relay to and from your phone using a Twilio number. Since the other party only sees your Twilio number, this effectively allows you to mask your phone number for privacy purposes.

## Set up


### Requirements

- [dotnet](https://dotnet.microsoft.com/)
- A Twilio account - [sign up](https://www.twilio.com/try-twilio)



### Local development

After the above requirements have been met:

1. Clone this repository and `cd` into it

```bash
git clone git@github.com:twilio-samples/sms-anonymous-csharp
cd sms-anonymous-csharp
```

2. Add necessary nuget packages. 

```bash
dotnet add package Twilio
dotnet add package Twilio.AspNet.Core
dotnet add package Twilio.TwiML.Messaging
```

3. Add your Phone Number

In the file `SmsController.cs` look for the variable `myNumber` and replace the placeholder with the number you wish to forward the SMS messages to.

4. Build to install the dependencies

```bash
dotnet build
```

5. Run the application

```bash
dotnet run
```

6. Use ngrok or other tunneling service to expose your application to the internet

You will need to use ngrok or another tunneling service to allow Twilio to reach your running application. Use the following command, replacing the port number that's shown here with the port that your application is running on.

```bash
ngrock http http://localhost:5213
```

6. Set your ngrok endpoint as a Webhook in the Twilio console. Remember to append /sms to the ngrok URL.


## Resources

- The CodeExchange repository can be found [here](https://github.com/twilio-labs/code-exchange/).


## Disclaimer

No warranty expressed or implied. Software is as is.

[twilio]: https://www.twilio.com
