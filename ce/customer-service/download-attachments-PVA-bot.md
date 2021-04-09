---
title: "Download attachments from your Power Virtual Agents bot| Microsoft Docs"
description: "Read about the various cards and attachments supported by various channels."
author: meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 04/09/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
---

# Download attachments from Power Virtual Agents bot in Omnichannel

If you have deployed your Power Virtual Agents bot in Omnichannel for Customer Service and need to enable customers to send attachments such as pictures or documents to the bot, you can access those files from your Azure Bot Framework Skill. 

In the Azure Bot Framework Skill you can process the uploaded image and perform the desired actions. 

For more information on enabling file attachments in Azure Bot Framework Skill, see [Configure file attachment capability](configure-file-attachment.md)

## Prerequisites

- Provide the Power Virtual Agents bot token to the Azure Bot Framework Skill. You can do so by providing the Microsoft AppId, Client Secret and using the parent PVA bot's AppId. For more information, see [Connector authentication](https://docs.microsoft.com/azure/bot-service/rest-api/bot-framework-rest-connector-authentication?view=azure-bot-service-4.0).

- Fetch the required contentURL from the attachment of the Bot framework activity.

- Use the `httpRequestMessage` method to call the `GET` request.

``` csharp
// Parent PVA bot's AppId 

            string oAuthScope = JwtTokenValidation.GetAppIdFromClaims(claimsIdentity.Claims); 

 

            MicrosoftAppCredentials microsoftAppCredentials = new MicrosoftAppCredentials( 

                appId: _microsoftAppCredentials.MicrosoftAppId, 

                password: _microsoftAppCredentials.MicrosoftAppPassword, 

                customHttpClient: _httpClient(), 

                logger: _logger, 

                oAuthScope: oAuthScope); 

 

           return await microsoftAppCredentials.GetTokenAsync(); 

        } 

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


 