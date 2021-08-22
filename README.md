# Twilio SMS Demo

This app demonstrates Twilio's features to:
- [Send SMS Messages](https://www.twilio.com/docs/sms/tutorials/).
- [Track the delivery status of messages](https://www.twilio.com/docs/sms/tutorials/how-to-confirm-delivery).

It also demonstrates:
- Phone number validation using [libphonenumber-csharp](https://github.com/twcclegg/libphonenumber-csharp).
- Real-time delivery status monitoring without manually refreshing the browser.
- Using selected UI components from the [Blazorise component library](https://github.com/Megabit/Blazorise).

I've chosen [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) as the UI framework for two main reasons:
- We can build an interactive web UI using C# instead of JavaScript. No more juggling of different programming languages and frameworks in the same app.
- Share client-side logic with back-end controllers, libraries and events.

## Getting started

This app uses [dotnet 5](https://dotnet.microsoft.com/download/dotnet/5.0).

1. Clone the solution
2. From your [Twilio's dashboard](https://console.twilio.com/), grab your Account SID, Auth Token and Phone Number.
3. Take note of your status callback webhook address as described [here](https://www.twilio.com/docs/sms/tutorials/.confirm-delivery-csharp-aspnet-mvc#receive-status-events-in-your-web-application).
4. Create a [dotnet app secret](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets) file on your computer at `%APPDATA%\Microsoft\UserSecrets\b20d99e4-8fb7-484d-869e-3d13c84bba2d\secrets.json` in the following format:
```json
   {
      "AccountSID": "xxxxxxxxxxxxxxxxxxxxxx",
      "AuthToken": "xxxxxxxxxxxxxxxxxxxxxxx",
      "FromNumber": "+xxxxxxxxxxxxxxx",
      "StatusCallBack": "https://<yoursite>/api/messagestatus"
   }
```
5. Open the dotnet CLR. From the solution's root folder, run the command: `dotnet run --project TwilioSMSDemo/TwilioSMSDemo.csproj`.

