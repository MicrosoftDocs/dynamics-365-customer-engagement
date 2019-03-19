---
title: "Manage custom context | Microsoft Docs"
description: "Read how you can send custom context to a chat session which can help decide which queue to route the chat to."
keywords: ""
ms.date: 03/19/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: D0FFD442-120E-48C5-BC04-0740956B4228
author: susikka
ms.author: susikka
manager: shujoshi
---
# Manage custom context

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

When a user initiates a chat, you can pass custom context to Omni-channel Engagement Hub. This custom context can be used in routing rules which eventually determine which queue to route the chat to.

> [!IMPORTANT]
> The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> The keys of custom context must correspond to context variables that are created for the associated work stream in Omni-channel Engagement Hub.
> The custom context provider would be invoked by live chat widget when starting a new chat.

Follow these steps to send custom context when starting a chat:

<!--note from editor: In Step 1, are the "live chat SDK methods" the same thing as the methods under "JavaScript API Reference" in this developer guide? If so, make that connection clear.   -->

1. Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
2. Once the **lcw:ready** event is raised, register a custom context provider with live chat using the [setContextProvider](../reference/methods/setContextProvider.md) method.
3. Use [startChat](../reference/methods/startChat.md) SDK to initiate a chat.

## Sample code

```JavaScript
function contextProvider(){
	// Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'.
	return {
			'contextKey1': 'contextValue1', // string value
			'contextKey2': 12.34, // number value
			'contextKey3': true // boolean value
	};
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat Ready event
	// SDK methods are ready for use now
	// Setting custom context provider to be used for the chat
	// The custom context provided by custom context provider can be used for routing the chat to a particular queue
	Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);
	// Starting a new chat
	Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
	// Handle LiveChat SDK error event
	console.log(errorEvent);
});
```
> [!div class="nextstepaction"]
> [Next topic: Send authentication token](send-auth-token-starting-chat.md)

### See also

[setContextProvider](../reference/methods/setContextProvider.md)<br />
[getContextProvider](../reference/methods/getContextProvider.md)<br />
[removeContextProvider](../reference/methods/removeContextProvider.md)<br />
[JavaScript API reference](../omni-channel-reference.md)