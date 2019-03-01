---
title: "setAuthTokenProvider (JavaScript API reference) for Omni-channel Engagement Hub in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 01/10/2019
ms.service: 
ms.topic: article
ms.assetid: 8CC62024-BBE4-481B-88A8-1DBC8B47F353
ms.custom: 
---
# setAuthTokenProvider (Omni-channel Engagement Hub JavaScript API reference)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[setAuthTokenProvider-description](../includes/setAuthTokenProvider-description.md)]

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(authTokenProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| authTokenProvider | Function | Function which would act as `auth-token` provider |

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