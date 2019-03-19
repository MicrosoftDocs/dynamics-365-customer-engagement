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
ms.assetid: BD4EF6FC-E38B-491C-AA23-C4D8EA961EB4
ms.custom: 
---

# getAuthTokenProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[getAuthTokenProvider-description](../includes/getAuthTokenProvider-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.

This SDK is applicable only if authentication is enabled for the widget. To enable authentication for your widget, see [Create chat authentication settings](../../../administrator/create-chat-auth-settings.md).

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAuthTokenProvider();`

## Parameters

None

## Return Value

<!--note from editor: change "auth-token" to "authentication-token"   -->

Returns the currently set authentication token provider, if any. If there is no registered authentication token provider, then it returns null.
<!--
## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Gets the currently set auth-token provider, if any.
               let authTokenProvider = Microsoft.Omnichannel.LiveChatWidget.SDK.getAuthTokenProvider();
});
```-->
## See also

[JavaScript API reference for Live chat SDK](../../omni-channel-reference.md)