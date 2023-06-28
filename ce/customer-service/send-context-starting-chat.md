---
title: "Send custom context | MicrosoftDocs"
description: "Learn how you can send custom context to a chat session that can help decide the queue to which you must route the chat."
ms.date: 01/20/2022
ms.topic: reference
author: neeranelli
ms.author: nenellim
---
# Send custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The custom context is a collection of key or value pairs. Only primitive values are allowed for any key. The keys must correspond to context variables that are created for the associated workstream. If no context variables have been created under live workstream with a matching logical name, variables are created at runtime assuming the type as String. The custom context provider would be invoked by the live chat widget when a new chat is started. Because the values are case-sensitive, use exact match to pass them to the context variables. More information: [Considerations for context variables](manage-context-variables.md#considerations)

> [!IMPORTANT]
>
> - The [setContextProvider](developer/reference/methods/setContextProvider.md) is supported only for unauthenticated chat. For authenticated chat, you must use the JSON Web Token (JWT). More information: [Send authentication tokens](send-auth-token-starting-chat.md)
> - You can pass only 100 custom context variables during each chat session.

When a customer starts a chat from the portal, you can pass custom context to Omnichannel for Customer Service. This custom context can be used to [display information on the user interface](display-custom-context.md) and to create routing rules that eventually determine the queue to which you must route the chats.

Follow these steps to send custom context when you start a chat:

1. The live chat SDK methods should be invoked after the [lcw:ready event](developer/reference/events/lcw-ready.md) event is raised. You can listen for this event by adding your own event listener on the window object.
2. After the `lcw:ready` event is raised, register a custom context provider with live chat using the [setContextProvider](developer/reference/methods/setContextProvider.md) method.
3. [Start the chat](initiate-chat-wait-time.md) using the [startChat](developer/reference/methods/startChat.md) method.

## Sample code

```JavaScript
function contextProvider(){
	//Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string               
	return {
			'contextKey1': 'contextValue1', // string value
			'contextKey2': 12.34, // number value
			'contextKey3': true // boolean value
	};
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat Ready event
	// SDK methods are ready for use now
	// Setting custom context provider to be used with Chat for Dynamics 365
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

For information about how to display the context variables, see [Display custom context](display-custom-context.md).


### See also

[setContextProvider](developer/reference/methods/setContextProvider.md)  
[getContextProvider](developer/reference/methods/getContextProvider.md)  
[removeContextProvider](developer/reference/methods/removeContextProvider.md)  
[Live chat SDK JavaScript API reference](developer/omnichannel-reference.md)  
[Configure context variables for a bot](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
