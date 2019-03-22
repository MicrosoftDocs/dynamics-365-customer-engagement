---
title: "getAuthTokenProvider (Omni-channel Engagement Hub JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 03/19/2019
ms.service: 
ms.topic: article
ms.assetid: 3C116485-476B-4E43-AF67-0BB5258BCA2C
ms.custom: 
---
# removeAuthTokenProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[removeAuthTokenProvider-description](../includes/removeAuthTokenProvider-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.

This SDK is applicable only if authentication is enabled for the widget. To enable authentication for your widget, see [Create chat authentication settings](../../../administrator/create-chat-auth-settings.md).

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.removeAuthTokenProvider();`

## Parameters

None

## Return Value

None

<!--## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Removes the currently set auth-token provider, if any.
               Microsoft.Omnichannel.LiveChatWidget.SDK.removeAuthTokenProvider();
});
```-->
## See also

[JavaScript API reference for Live chat SDK](../../omni-channel-reference.md)