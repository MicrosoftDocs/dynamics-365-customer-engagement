---
title: "getContextProvider (Omni-channel Engagement Hub JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/19/2019
ms.service: 
ms.topic: article
ms.assetid: 1C92A31B-70DF-4CE7-9C7A-BE398F34C6F6
ms.custom: 
---

# getContextProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[getContextProvider-description](../includes/getContextProvider-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();`

## Parameters

None

## Return Value

Returns the currently set custom context provider, if any. If there is no registered custom context provider, then it returns null.

<!--## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Gets the currently set context provider, if any.
               let contextProvider = Microsoft.Omnichannel.LiveChatWidget.SDK.getContextProvider();
});
```

-->

## See also

[JavaScript API reference for Live chat SDK](../../omni-channel-reference.md)