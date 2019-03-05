---
title: "getAuthTokenProvider (JavaScript API reference) for Omni-channel Engagement Hub in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/03/2019
ms.service: 
ms.topic: article
ms.assetid: BD4EF6FC-E38B-491C-AA23-C4D8EA961EB4
ms.custom: 
---

# getAuthTokenProvider (Omni-channel Engagement Hub JavaScript API reference)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[getAuthTokenProvider-description](../includes/getAuthTokenProvider-description.md)]

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAuthTokenProvider();`

## Parameters

None

## Return Value

<!--note from editor: change "auth-token" to "authentication-token"   -->

Returns the currently set authentication-token provider, if any.

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Gets the currently set auth-token provider, if any.
               let authTokenProvider = Microsoft.Omnichannel.LiveChatWidget.SDK.getAuthTokenProvider();
});
```
