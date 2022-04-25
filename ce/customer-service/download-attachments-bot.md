---
title: "Download attachments from your Azure bot| Microsoft Docs"
description: "Read about the various cards and attachments supported by various channels."
ms.date: 04/26/2022
ms.topic: reference
author: lalexms
ms.author: laalexan
manager: shujoshi
---
# Download attachments from your Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Follow these steps to download attachments from your Azure bot.

1. Get the token for your bot. You can do so by providing your bot's Microsoft AppId and Client Secret. More information: [Connector authentication](/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0)

2. Fetch the `attachmentId` from the attachment content URL. For example, the `attachmentId` in this URL `https://us-api.asm.skype.com/v1/objects/0-eus-d1-5360689c55c308cb4e3b51722e46b801/` is `0-eus-d1-5360689c55c308cb4e3b51722e46b801`. 

3.	Use the `attachmentId` in the `RequestUri` variable. Then, call the `GET` request by using the `HttpRequestMessage` method, as shown in the following sample code.

```csharp
string requestUri = $"https://botapi.skype.com/amer/v3/attachments/{attachmentId}/views/original";
var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);
 
var authorization = new AuthenticationHeaderValue("bearer", <add the botToken here>);
var requestHeaders = new Dictionary<string, string>()
  {
     { "Authorization", authorization.ToString() }
  };

foreach (var header in requestHeaders)
  {
      httpRequest.Headers.Add(header.Key, header.Value);
  }

HttpResponseMessage response = await client.SendAsync(httpRequest);
```

>[!Important]
> If you're migrating your omnichannel implementations from the Microsoft Teams channel to the new messaging platform, then you must program your Azure bot for processing and downloading the file attachments properly in the new channel. More information: [Manage file attachments during migration](migrate-acs.md#manage-file-attachments-during-migration) 

### See also

[Card support by channel](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel&preserve-view=true)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
