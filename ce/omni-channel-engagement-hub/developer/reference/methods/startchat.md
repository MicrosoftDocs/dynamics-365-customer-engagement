---
title: "startChat (JavaScript API reference) for Omni-channel Engagement Hub in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/03/2019
ms.service: 
ms.topic: article
ms.assetid: 92BEB77B-CB6C-436A-8585-2EF581945649
ms.custom: 
---
# startChat (Omni-channel Engagement Hub JavaScript API reference)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[startchat-description](../includes/startChat-description.md)]

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();`

## Parameters

None

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Opens an existing chat, if any. Else initiates a new chat
               Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});
```
