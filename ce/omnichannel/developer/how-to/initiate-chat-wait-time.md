---
title: "Initiate a chat | Microsoft Docs"
description: ""
keywords: ""
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 43DCA23E-19AE-4D5F-B679-65A82B2B7FCB
author: susikka
ms.author: susikka
manager: shujoshi
---
# Initiate a chat

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

<!--note from editor:  specify what the user is waiting for--customer support, specifically?  -->

Follow these steps to start a chat:

1. Listen to the **lcw:ready** event raised by a live chat to start using the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.
2. Once the **lcw:ready** event is raised, call the [startChat](../reference/methods/startChat.md) method to initiate a chat.

## Sample code

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat SDK ready event
	// SDK methods are ready for use now
	// Initiate a chat using startChat SDK
	Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
	// Handle LiveChat error event
	console.log(errorEvent);
});
```

Consider a scenario, a customer is using your portal for some time, and you want to open the chat widget after specified amount of time. You can set up a rule such that the chat widget opens programmatically after a specified amount of time.

For example, Bert Hair is on Constoso.com website (portal), and you've set up a rule such that chat widget should open after 1 minute. As Bert Hair is on the portal for more than a minute, the chat widget opens programmatically. 

### See also

[startChat](../reference/methods/startChat.md)<br />
[JavaScript API reference for Live chat SDK](../omnichannel-reference.md)