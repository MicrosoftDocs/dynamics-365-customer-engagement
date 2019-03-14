---
title: "Walkthrough: Manage custom context | Microsoft Docs"
description: ""
keywords: ""
ms.date: 03/14/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: D0FFD442-120E-48C5-BC04-0740956B4228
author: susikka
ms.author: susikka
manager: shujoshi
---
# Walkthrough: Manage custom context

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

When a user initiates a chat, you can pass the custom context to Omni-channel Engagement Hub, which helps decide which agent or queue to route the chat to.

Follow these steps to send context when starting a chat:

<!--note from editor: In Step 1, are the "live chat SDK methods" the same thing as the methods under "JavaScript API Reference" in this developer guide? If so, make that connection clear.   -->

1. Listen on the **lcw:ready** event raised by a live chat before calling the live chat SDK methods.
2. Once the **lcw:ready** event is raised, register a context provider with live chat using the [setContextProvider](../reference/methods/setContextProvider.md) method.

## Sample code

```JavaScript
function contextProvider(){
	return {
			'contextKey1': 'contextValue1', // string value
			'contextKey2': 12.34, // number value
			'contextKey3': true // boolean value
	};
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat Ready event
	// SDK methods are ready for use now
	// Setting context provider to be used for the chat
	// The context provided by context provider can be used for routing the chat to a particular agent or queue
	Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
	// Handle LiveChat SDK error event
	console.log(errorEvent);
});
```
> [!div class="nextstepaction"]
> [Next topic: Send authentication token when starting a chat](send-auth-token-starting-chat.md)

### See also

[JavaScript API reference](../omni-channel-reference.md)
