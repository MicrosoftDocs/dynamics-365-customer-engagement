---
title: "Migration changes for new omnichannel messaging platform | MicrosoftDocs"
description: "Use this article to understand the changes you'll need to make to your omnichannel implementations to successfully migrate to the new omnichannel messaging platform."
ms.date: 04/22/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Migration changes for new omnichannel messaging platform

We'll be rolling out a new messaging platform in phases over the next few months. As part of this migration, we're releasing a new bot service channel to extend the existing bot integration capabilities of the messaging channels.

To successfully migrate to the new messaging platform, you must make the following changes to your omnichannel implementations:

- If you have network policies in your organization, be sure to update your system requirements to include a new set of domains that'll be used by the new platform. More information: [Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)

- If you're using the Omnichannel Chat SDK to customize the live chat widget for mobile apps, download the latest version of the chat SDK package. You'll need Omnichannel Chat SDK 1.0.0 to ensure that your widget works in the new platform. More information: [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation)

- If you're integrating an Azure bot, then you must connect and register your bot with the new channel. More information: [Integrate Azure bot](configure-bot.md). If you're using a Power Virtual Agents bot or Azure Health Bot, then these changes will be automatically applied, and you don't need to take any action.

- If you're a bot author or developer, then you must download the latest middleware NuGet package. More information: [Enable bot context NuGet package](enable-bot-context.md#install-the-bot-sdk-in-your-project)

- If you've enabled the option to download file attachments in chat conversations, then as a bot author or developer, you must program your Azure bot for processing and downloading the file attachments properly in the new channel. More information: [Manage file attachments during migration](#manage-file-attachments-during-migration)  

> [!Note]
> These changes won't impact your existing omnichannel experience. We'll work with you to help you navigate and test the changes to ensure a smooth transition.

## Manage file attachments during migration

This section describes how you must manage file attachments received by your Azure bot when you migrate your omnichannel implementations from the Microsoft Teams channel to the new messaging platform. 

Before you begin, let's quickly learn about the file attachment formats in the Teams channel and the bot service channel.

### File attachment formats

When file attachments are sent from Omnichannel for Customer Service to an Azure bot on the Teams chat channel, the attachment format is passed in the `Activity.Attachments` property. The content type of that attachment is “application/vnd.microsoft.teams.file.download.info”.

  > [!div class="mx-imgBorder"]
  > ![Attachment format on Microsoft Teams channel.](./media/attachment-format-teams-channel.png "Attachment format on Microsoft Teams channel.")

However, when file attachments are sent from Omnichannel for Customer Service to the Azure bot on the bot service channel, the information required to download the files is passed in the `amsReferences` and `amsMetadata` fields of the `Activity.ChannelData` property.
  > [!div class="mx-imgBorder"]
  > ![Attachment format on bot service channel.](./media/attachment-format-acs-channel.png "Attachment format on bot service channel.")

### How to manage file attachments in your Azure bot code

In the new channel, the attachment information is not passed in the `Activity.Attachments` field, as is done on the Microsoft Teams chat channel. So, to ensure smooth migration between the two chat channels, the Teams channel-specific logic should be retained in the bot code together with the new bot service channel-specific logic, as shown in the following sample code.

```csharp
// 1. Retrieve Attachment ID from ChannelData["amsReferences"]
if (turnContext.Activity.ChannelData != null &&
    turnContext.Activity.ChannelData is JObject incomingRequestChannelData &&
    incomingRequestChannelData.TryGetValue("amsReferences", out JToken amsReferencesArray))
{
    string attachmentId = JsonConvert.DeserializeObject<string[]>(amsReferencesArray.ToString()).FirstOrDefault();

    // 2. Build HTTP request for specified attachment Id.
    string requestUri = $"https://botapi.skype.com/amer/v3/attachments/{attachmentId}/views/original";
    var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);

    // 3. Acquire authentication token and add it to request headers
    var token = await new MicrosoftAppCredentials("botAppId", "botAppSecret").GetTokenAsync();
    var authorization = new AuthenticationHeaderValue("bearer", token);
    httpRequest.Headers.Add("Authorization", authorization.ToString());

    // 4. Add ACS Bot Id to request header. This is required to achieve good download performance.
    httpRequest.Headers.Add("BotAcsId", turnContext.Activity.Recipient.Id);

    // 5. Use HttpClient to execute the request and download attachment
    var response = await client.SendAsync(httpRequest);
    
    // 6. Save HTTP response stream to the file
    var responseContentStream = await response.Content.ReadAsStreamAsync();
    using (FileStream fileCreateStream = new FileStream("file path", FileMode.Create))
    {
        fileCreateStream.CopyTo(responseContentStream);
    }
}
else if (turnContext.Activity.Attachments != null)
{
    // 1. Retrieve Teams attachment
    var teamsAttachment = turnContext.Activity.Attachments.FirstOrDefault(attachment => attachment.ContentType.Equals("application/vnd.microsoft.teams.file.download.info", StringComparison.OrdinalIgnoreCase));

    if (teamsAttachment != null)
    {
        // 1. Retrieve Teams Attachment ID from Content[“uniqueId”] field
        string attachmentId = (teamsAttachment.Content as JObject).GetValue("uniqueId").ToString();

        // 2. Build HTTP request for specified attachment Id.
        string requestUri = $"https://botapi.skype.com/amer/v3/attachments/{attachmentId}/views/original";
        var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);

        // 3. Acquire authentication token and add it to request headers
        var token = await new MicrosoftAppCredentials("botAppId", "botAppSecret").GetTokenAsync();
        var authorization = new AuthenticationHeaderValue("bearer", token);

        httpRequest.Headers.Add("Authorization", authorization.ToString());

        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.SendAsync(httpRequest);
    }
}
```
### See also

[Introduction to Omnichannel for Customer Service](introduction-omnichannel.md)  
[Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[Integrate an Azure bot](configure-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
