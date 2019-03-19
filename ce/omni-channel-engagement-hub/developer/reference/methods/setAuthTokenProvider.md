---
title: "setAuthTokenProvider (Omni-channel Engagement Hub JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/03/2019
ms.service: 
ms.topic: article
ms.assetid: 8CC62024-BBE4-481B-88A8-1DBC8B47F353
ms.custom: 
---
# setAuthTokenProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[setAuthTokenProvider-description](../includes/setAuthTokenProvider-description.md)]

The authentication-token provider function, when called with a callback function as a parameter, invokes the callback function with a valid JSON Web Token (JWT) string as the argument.<br />This method raises an error if the value of the `authTokenProvider` parameter is not a function.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(authTokenProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| authTokenProvider | Function | Function that acts as an authentication-token provider |

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Sets the auth-token provider
               // Throws error if authTokenProvider is not a function
               Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(function authTokenProvider(callback){
               callback("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c");
               });
});

```
## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|2|Auth token provider method execution failed|
|3|Auth token provider didn't provide any token|
|4|Auth token provider provided invalid token|

## See also

[JavaScript API reference for live chat SDK](../../omni-channel-reference.md)