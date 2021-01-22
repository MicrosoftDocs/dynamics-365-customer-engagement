---
title: "Download attachments from your Azure bot| Microsoft Docs"
description: "Read about the various cards and attachments supported by various channels."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 07/21/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Download attachments from your Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Follow these steps to download attachments from your Azure bot.

1. Get the token for your bot. You can do so by providing your bot's Microsoft AppId and Client Secret. More information: [Connector authentication](https://docs.microsoft.com/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0)

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

### See also

[Card support by channel](https://docs.microsoft.com/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel)<br />
[Asynchronous channel support](asynchronous-channels.md)
