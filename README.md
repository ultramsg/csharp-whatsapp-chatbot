# [Ultramsg.com](https://ultramsg.com/?utm_source=github&utm_medium=csharp&utm_campaign=chatbot) csharp-whatsapp-chatbot

Demo WhatsApp API ChatBot using Ultramsg API with c#.



by [Ultramsg.com](https://ultramsg.com/?utm_source=github&utm_medium=csharp&utm_campaign=chatbot)

# Dependencies

for local development purposes, a tunneling service is required. This example uses ngrok , You can download ngrok from [here](https://ngrok.com/download).

# Set the instance ID and token
Set the instance ID and token in appsettings.json file.

# run project 
```
dotnet watch
```
# Start ngrok 
Run ngrok For Windows :

```
ngrok http https://localhost:6000
```
Run ngrok For mac :
```
./ngrok http https://localhost:6000
```


# Set Webhook URL 

Go to your ultramsg account for set Webhook URL after copying the ngrok url and add **/api/** Route like this : 

```
https://61-44-136-9.ngrok.io/api/
```
and enable this option "Webhook on Received" .

![Alt text](https://blog.ultramsg.com/wp-content/uploads/2022/09/ultramsg-whatsapp-api-webhook.png "Webhook")


# receive WhatsApp messages and command processing
Congratulations.. Now you can try sending to WhatsApp number and testing the chatbot.

This is all you need to receive and read messages from users, and then respond to them.
You can develop the list and add more complex commands such as querying from Database and updating records in the database ..etc.

# Support
Use **Issues** to contact me