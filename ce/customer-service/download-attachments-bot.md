---
title: "Download file attachments from your Azure bot| MicrosoftDocs"
description: "This topic includes reference information about downloading file attachments from your Azure bot in Omnichannel for Customer Service."
ms.date: 04/13/2022
ms.topic: reference
author: lalexms
ms.author: laalexan
manager: shujoshi
---
# Download file attachments from your Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

If you've deployed your Azure bot in Omnichannel for Customer Service and have enabled customers to send attachments such as pictures or documents to the bot over a chat session, then follow these steps to download file attachments from your Azure bot.

1. Get the token for your Azure bot. You can do so by providing your bot's Microsoft App ID and Client secret. More information: [Connector authentication](/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0&preserve-view=true)

2. Fetch the `attachmentId` from the attachment content URL. For example, the `attachmentId` in this URL `https://us-api.asm.skype.com/v1/objects/0-eus-d1-5360689c55c308cb4e3b51722e46b801/` is `0-eus-d1-5360689c55c308cb4e3b51722e46b801`. 

3. Use the `attachmentId` in the `RequestUri` variable. Then, call the `GET` request by using the `HttpRequestMessage` method, as shown in the following sample code.

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

[Migration changes for new omnichannel messaging platform](migrate-acs.md)  
[Enable file attachments](enable-file-attachments.md)  
[Process file attachments during migration](process-file-attachments-during-migration.md)  
[Download file attachments from your Power Virtual Agents bot](download-attachments-PVA-bot.md)  
[Card support by channel - Bot Framework SDK Documentation](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel&preserve-view=true)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
