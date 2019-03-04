---
title: "Walkthrough: Initiate a chat when a user has been waiting for some time | Microsoft Docs"
description: ""
keywords: ""
ms.date: 03/04/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 43DCA23E-19AE-4D5F-B679-65A82B2B7FCB
author: susikka
ms.author: susikka
manager: shujoshi
---
# Walkthrough: Initiate a chat when the user has been waiting

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

<!--note from editor:  specify what the user is waiting for--customer support, specifically?  -->

You might want to set up a rule that a chat widget will programmatically open after a user has been waiting on a website for a certain amount of time. Consider a situation in which a user of the website of Contoso Ltd. has been waiting for one minute.

Follow these steps to programmatically start a chat after an user has been waiting for one minute:

1. Listen on the **lcw:ready** event raised by a live chat to start using the live chat SDK methods.
2. Once the **lcw:ready** event is raised, wait for one minute using the **window.setTimeout()** method, and then call the [startChat](../reference/methods/startChat.md) to open the chat widget.

## Sample code

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat SDK ready event
	// SDK methods are ready for use now
	// Starting a chat proactively after 1 minute of user being on the page
	window.setTimeout(Microsoft.Omnichannel.LiveChatWidget.SDK.startChat, 60000);
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
	// Handle LiveChat error event
	console.log(errorEvent);
});
```

### See also

[JavaScript API reference](../omni-channel-reference.md)
