---
title: "Download attachments from your Azure bot| Microsoft Docs"
description: "Read about the various cards and attachments supported by various channels."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/21/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Download attachments from your Azure bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic mentions the steps that you need to follow to download attachments from your Azure bot.

1. Get the token for your bot. You can do so by providing your bot’s Microsoft AppId and Client Secret. More information: [Connector Authentication](https://docs.microsoft.com/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0)

2. Fetch the `attachmentId` from the attachment content URL. For example, the `attachmentId` in this URL `https://us-api.asm.skype.com/v1/objects/0-eus-d1-5360689c55c308cb4e3b51722e46b801/` is `0-eus-d1-5360689c55c308cb4e3b51722e46b801`. 

3.	Use the `attachmentId` in the `RequestUri` variable. Then, call the `GET` request using the `HttpRequestMessage` method, as shown in the sample code below.

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
[Asynchronous channel support](../administrator/asynchronous-channels)