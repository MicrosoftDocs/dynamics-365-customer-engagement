---
title: "setBotAuthTokenProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information such as syntax and parameter for the setBotAuthTokenProvider method in Omnichannel for Customer Service JavaScript API reference."
ms.date: 11/02/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
---
# setBotAuthTokenProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

The bot authentication token provider function, when called with a callback function as a parameter, returns the `botAuthUrl`to send the token to the bot and invokes the callback function to set the sign-in card visibility.


## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setBotAuthTokenProvider(authTokenProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| authTokenProvider | Function |Function which when invoked with a callback function as parameter, returns the `botAuthUrl` to send the token to the bot and invokes the callback function to set the sign-in card visibility. |

## Return value

Bot authentication URL.

## Example

[!INCLUDE[setBotAuthTokenProvider-code-sample](../includes/setBotAuthTokenProvider-code-sample.md)]


### See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)  
[Pass authentication token to bot during single sign-on in live chat](../../../pass-auth-token-sso-live-chat.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
