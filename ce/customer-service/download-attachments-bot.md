---
title: "Download attachments from Azure bot| Microsoft Docs"
description: "This topic includes reference information about downloading attachments from your Azure bot."
ms.date: 04/26/2022
ms.topic: reference
author: lalexms
ms.author: laalexan
manager: shujoshi
---
# Download attachments from Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

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

## Manage file attachments during migration

This section describes how you must manage file attachments received by your Azure bot when you migrate your omnichannel implementations from the Microsoft Teams channel to the new messaging platform. 

Before you begin, let's quickly learn about file attachment formats in the Teams channel and the bot service channel.

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

[Card support by channel](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel&preserve-view=true)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
