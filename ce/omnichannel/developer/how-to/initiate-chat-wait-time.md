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

1. Listen to the **lcw:ready** event raised by a live chat to start using the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
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

Consider a scenario where the customer is on your portal page, and you want to initiate chat once the customer has spent some time on the page. You can programmatically open the chat widget once the specified time has elapsed.

### See also

[startChat](../reference/methods/startChat.md)<br />
[JavaScript API reference for Live chat SDK](../omnichannel-reference.md)