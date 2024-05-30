---
title: Download file attachments from an Azure bot
description: Learn how to download attachments from an Azure bot in the Microsoft Teams channel.
ms.date: 03/09/2023
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.custom: bap-template
---
# Download file attachments from an Azure bot

[!INCLUDE [cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Follow these steps to download attachments from an Azure bot in the Microsoft Teams channel.

1. [Get the token for your bot](/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0&preserve-view=true) using your bot's Microsoft App ID and client secret.

1. Get the `attachmentId` from the attachment URL.

   For example, if the URL is `https://us-api.asm.skype.com/v1/objects/0-eus-d1-5360689c55c308cb4e3b51722e46b801/`, then the `attachmentId` is `0-eus-d1-5360689c55c308cb4e3b51722e46b801`.

1. Insert the `attachmentId` in a `RequestUri` variable and then use  `RequestUri` in a `GET` request, like this:

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

[Card support by channel](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel&preserve-view=true)  
[Support for live chat and asynchronous channels](../administer/card-support-in-channels.md)  
[Migration changes for new omnichannel messaging platform](../administer/migrate-acs.md)  

[!INCLUDE [footer-include](../../includes/footer-banner.md)]
