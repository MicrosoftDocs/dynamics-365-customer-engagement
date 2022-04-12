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

Follow these steps to download attachments from your Azure bot.

1. Get the token for your bot. You can do so by providing your bot's Microsoft AppId and Client Secret. More information: [Connector authentication](/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0)

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

## Attachment format on the Azure Bot Service channel  

When file attachments are sent to the Azure bot from Omnichannel for Customer Service, the information required to download the files is available in the `amsReferences` and `amsMetadata` fields of the `Activity.ChannelData` property.
    > [!div class="mx-imgBorder"]
    > ![Attachment format on Azure Bot Service channel.](./media/attachment-format-acs-channel.png "Attachment format on Azure Bot Service channel.")

The attachment information on the Azure Bot Service channel is not passed in the `Activity.Attachments` field, as is done on the Microsoft Teams chat channel. So, the Teams chat channel-specific logic should not be removed from the existing bot but kept together with the new Azure Bot Service channel-specific logic to ensure smooth migration between the two chat channels.

## Attachment format on the Microsoft Teams channel

When file attachment is sent from Omnichannel to Bot on Teams chat channel, it is passed in the `Activity.Attachments` property. The content type of that attachment is “application/vnd.microsoft.teams.file.download.info”.

    > [!div class="mx-imgBorder"]
    > ![Attachment format on Microsoft Teams channel.](./media/attachment-format-teams-channel.png "Attachment format on Microsoft Teams channel.")


### See also

[Card support by channel - Bot Framework SDK Documentation](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  
[Enable file attachments](enable-file-attachments.md)  
[Download file attachments from your Power Virtual Agents bot](download-attachments-PVA-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
