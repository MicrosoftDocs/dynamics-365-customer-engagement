---
title: "removeContextProvider (Omni-channel Engagement Hub JavaScript API reference)| MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/19/2019
ms.service: 
ms.topic: article
ms.assetid: C1EBAEC6-42D4-4D8F-9FFC-89DA2AD50B2B
ms.custom: 
---
# removeContextProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[removeContextProvider-description](../includes/removeContextProvider-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();`

## Parameters

None

## Return Value

None
<!--
## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Removes the currently set custom context provider if any
               Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();
});

```
-->
## See also

[JavaScript API reference for live chat SDK](../../omni-channel-reference.md)