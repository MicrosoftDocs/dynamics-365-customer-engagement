---
title: "Download attachments from your Power Virtual Agents bot| Microsoft Docs"
description: "Read how to download attachments from a Power Virtual Agents bot in Omnichannel for Customer Service."
ms.date: 04/09/2021
ms.topic: reference
author: meghanalanka
ms.author: v-mlanka
manager: shujoshi
---

# Download attachments from Power Virtual Agents bot in Omnichannel

If you've deployed your Power Virtual Agents bot in Omnichannel for Customer Service and need to enable customers to send attachments such as pictures or documents to the bot, you can access those files from your Azure Bot Framework Skill. For more information, see [Extend your bot using Bot Framework Skills](/power-virtual-agents/configuration-add-skills).

In the Azure Bot Framework Skill, you can process the uploaded file and perform the desired actions. 

For more information on enabling file attachments for your bot, see [Configure file attachment capability](configure-file-attachment.md)

## Prerequisites

Provide the Power Virtual Agents bot token to the Azure Bot Framework Skill. You can do so by providing the Microsoft AppId, Client Secret, and using the parent Power Virtual Agent bot's AppId.


``` csharp
// Parent Power Virtual Agent bot's AppId 

            string oAuthScope = JwtTokenValidation.GetAppIdFromClaims(claimsIdentity.Claims); 

 

            MicrosoftAppCredentials microsoftAppCredentials = new MicrosoftAppCredentials( 

                appId: _microsoftAppCredentials.MicrosoftAppId, 

                password: _microsoftAppCredentials.MicrosoftAppPassword, 

                customHttpClient: _httpClient(), 

                logger: _logger, 

                oAuthScope: oAuthScope); 

 

           return await microsoftAppCredentials.GetTokenAsync(); 

        } 
Fetch the required contentURL from the attachment of the Bot framework activity and then use the `httpRequestMessage` method to call the `GET` request.
```

``` csharp

string requestUri = activity.Attachments[i].ContentUrl; 

 

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


 
