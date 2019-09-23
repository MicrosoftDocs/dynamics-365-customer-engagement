---
title: "startProactiveChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 09/23/2019
ms.service: 
ms.topic: article
ms.assetid: 2BD1ECAD-6E5A-4BD9-BD82-67B335B98D88
ms.custom: 
---
# startChat

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[startproactivechat-description](../includes/startChat-description.md)]

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat();`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| showPrechat | Boolean | Boolean flag to indicate whether prechat is shown if configured for the widget. |
| notificationUIConfig | Object | Allows you to pass UI configurations for proactive chat notification. This object lets you customize the notification, including the message to be displayed. |

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(false, {message: "Hi! How are you doing today? Do you wish to start a chat?"}) },10000);
});
```
## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)