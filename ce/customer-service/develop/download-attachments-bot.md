---
title: Download file attachments from an Azure bot
description: Learn how to download attachments from an Azure bot in the Microsoft Teams channel.
ms.date: 06/06/2024
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---
# Download file attachments from an Azure bot


Follow these steps to download attachments from an Azure bot in Omnichannel.

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

## Manage file attachments

> [!NOTE]
> The information in this section is applicable to Government Community Cloud (GCC) only.

This section describes how to manage file attachments in the Omnichannel bot service messaging platform.

First, let's quickly review file attachment formats in the Omnichannel bot service channel.

### File attachment formats

When file attachments are sent from Omnichannel for Customer Service to the Azure bot on the Omnichannel bot service channel, the information required to download the files is passed in the `amsReferences` and `amsMetadata` fields of the `Activity.ChannelData` property.

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

Attachment information is passed in the Omnichannel bot service channel, and can be accessed in bot code, as shown in the following example.

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

```

### Related information

[Card support by channel](/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0#card-support-by-channel&preserve-view=true)  
[Support for live chat and asynchronous channels](../administer/card-support-in-channels.md)  
[Migration changes for new omnichannel messaging platform](../administer/migrate-acs.md)  

[!INCLUDE [footer-include](../../includes/footer-banner.md)]