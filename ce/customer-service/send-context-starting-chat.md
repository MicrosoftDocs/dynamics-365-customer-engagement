---
title: "Manage custom context | MicrosoftDocs"
description: "Learn how you can send custom context to a chat session that can help decide the queue to which you must route the the chat."
ms.date: 10/20/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Manage custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

When a customer starts a chat from the portal, you can pass custom context to Omnichannel for Customer Service. This custom context can be used to display information on the user interface and to create routing rules that eventually determine the queue to which you must route the chats.

The custom context is a collection of key or value pairs. Only primitive values are allowed for any key. The keys of custom context must correspond to context variables that are created for the associated workstream in Omnichannel for Customer Service. If no context variables have been created under live workstream with a matching logical name, variables are created at run time assuming the type as String. The custom context provider would be invoked by the live chat widget when a new chat is started. Because the values are case sensitive, use exact match to pass them to the context variables. More information: [Context variables](context-variables-for-bot.md)

Follow these steps to send custom context when you start a chat:

1. Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
2. After the **lcw:ready** event is raised, register a custom context provider with live chat using the [setContextProvider](developer/reference/methods/setContextProvider.md) method.
3. [Start the chat](initiate-chat-wait-time.md) using the [startChat](developer/reference/methods/startChat.md) SDK method.

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

To display the context variables in the Conversation Summary Control of conversations, see [Display custom context](display-custom-context.md).

### Parse JSON to use custom context variables

Use the following schema to parse the JSON to use custom context variables.

```JavaScript
Schema
{
            "type": "object",
             "properties": {
                    "isDisplayable": {
                        " description": " Context variable should display in agent UI or not",
                        "type": "boolean"
                    },
                    "Value": {
                         " description": " Context variable value pass through bot , this can be string Boolean or number",
                        "type": "string or Boolean or Number"
                    }
                },
                "required": [ "isDisplayable", "Value" ]            
        }

```

An example for the `isDisplayable` variable is as follows:
`{\"isDisplayable\":\"true\"," +"\"Value\":\"context variable value as string\"}`

The `Value` mentioned in the example can be String, Number, or Boolean.

### See also

[setContextProvider](developer/reference/methods/setContextProvider.md)  
[getContextProvider](developer/reference/methods/getContextProvider.md)  
[removeContextProvider](developer/reference/methods/removeContextProvider.md)  
[JavaScript API reference](developer/omnichannel-reference.md)  
[Configure context variables for a bot](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
