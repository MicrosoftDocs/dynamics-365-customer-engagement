---
title: "Download file attachments from Azure bot| Microsoft Docs"
description: "This article includes reference information about downloading attachments from your Azure bot."
ms.date: 04/29/2022
ms.topic: reference
author: lalexms
ms.author: laalexan
manager: shujoshi
---
# Download file attachments from Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Follow these steps to download attachments from your Azure bot via the Microsoft Teams channel.

1. Get the token for your bot by providing your bot's Microsoft App ID and client secret. More information: [Connector authentication](/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0&preserve-view=true)

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

## Manage file attachments during migration

This section describes how you must manage file attachments received by your Azure bot when you migrate your omnichannel implementations from the Microsoft Teams channel to the new messaging platform. 

Before you begin, let's quickly learn about file attachment formats in the Teams bot service channel and the Omnichannel bot service channel.

### File attachment formats

When file attachments are sent from Omnichannel for Customer Service to an Azure bot on the Teams bot service channel, the attachment format is passed in the `Activity.Attachments` property. The content type of that attachment is “application/vnd.microsoft.teams.file.download.info”.

**Teams bot service channel**

```json
{
   "attachments":[
      {
         "contentType":" text/html",
         "contentUrl":null,
         "content ":{
            "name":null,
            "thumbnailUrl":null
         }
      },
      {
         "contentType":"application/vnd.microsoft.teams.file.download.info",
         "contentUrl":"https://us-api.asm.skype.com/v1/objects/0-wus-d8-111 a550dfI 6e947f250519ffc242763d/",
         "content":{
            "downloadUrl":"https://us-api.asm.skype.com/v1/objects/0-wus-d8-111 a550dfI 6e947f250519ffc242763d/",
            "uniqueld":"0-wus-d8-111 a550dfI 6e947f250519ffc242763d",
            "fileType":"png "
         },
         "name":"bot.png",
         "thumbnailUrl":null
      }
   ]
}
```

However, when file attachments are sent from Omnichannel for Customer Service to the Azure bot on the Omnichannel bot service channel, the information required to download the files is passed in the `amsReferences` and `amsMetadata` fields of the `Activity.ChannelData` property.

**Omnichannel bot service channel**

```json
{
   "recipient":{
      "id":"8:acs:5ecf37b1-11 Oc-414g-ab33-804ffd6b4a33_eooe0010-7c57-1ceb-nec-113aOdOOb272",
      "name":"Omnichannel-test-bot",
      "aadObjectId":null,
      "role":null
   },
   "attachments ":null,
   "channelData":{
      "tags":"Channelld-lcw,FromCustomer",
      "deliveryMode":"bridged",
      "fromUserId":"8:acs:5ecf37b1-110c-4149-ab33-804ffd6b4a33_00000010-61 b9-ab1 d-3dfe-9c3aOd009ea4",
      "amsReferences":[
         "0-wus-d6-20e7797d208fab388cc11b09674d166"
      ],
      "amsMetadata":[
         {
            "contentType":"image/png",
            "fileName":"SurnmerTime.png"
         }
      ],
      "sourceChannelId":"omnichannel"
   }
}
```
### How to manage file attachments in your Azure bot code

In the new channel, the attachment information is not passed in the `Activity.Attachments` field, as is done on the Teams bot service channel. So, to ensure smooth migration between the two chat channels, the Teams channel-specific logic should be retained in the bot code together with the Omnichannel bot service channel-specific logic, as shown in the following sample code.

```csharp
// 1. Retrieve Attachment ID from ChannelData["amsReferences"]
if (turnContext.Activity.ChannelData != null &&
    turnContext.Activity.ChannelData is JObject incomingRequestChannelData &&
    incomingRequestChannelData.TryGetValue("amsReferences", out JToken amsReferencesArray))
{
    string attachmentId = JsonConvert.DeserializeObject<string[]>(amsReferencesArray.ToString()).FirstOrDefault();

    // 2. Build HTTP request for specified attachment ID.
    string requestUri = $"https://botapi.skype.com/amer/v3/attachments/{attachmentId}/views/original";
    var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);

    // 3. Acquire authentication token and add it to request headers
    var token = await new MicrosoftAppCredentials("botAppId", "botAppSecret").GetTokenAsync();
    var authorization = new AuthenticationHeaderValue("bearer", token);
    httpRequest.Headers.Add("Authorization", authorization.ToString());

    // 4. Add Azure Communication Services Bot ID to request header. This is required to achieve good download performance.
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

        // 2. Build HTTP request for specified attachment ID.
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
[Migration changes for new omnichannel messaging platform](migrate-acs.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
