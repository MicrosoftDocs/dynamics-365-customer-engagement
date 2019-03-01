---
title: "Walkthrough: Initiate a chat when user has been waiting for some time | Microsoft Docs"
description: ""
keywords: ""
ms.date: 03/01/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 43DCA23E-19AE-4D5F-B679-65A82B2B7FCB
author: susikka
ms.author: susikka
manager: shujoshi
---
# Walkthrough: Initiate a chat when user has been waiting for some time

Consider the situation that a user on the website of Contoso Ltd. has been waiting for 1 minute, and developer wants to setup a rule that chat widget will programmatically open after a user has been waiting for a certain time, which in our example is 1 minute.

Follow the given steps to programmatically commence a chat after user has been waiting for 1 minute:

1. Listen on the **lcw:ready** event raised by live chat to start using the LiveChat SDK methods.
2. Once the **lcw:ready** event is raised, wait for 1 minute using the **window.setTimeout()** method and then call the [startChat](../reference/methods/startChat.md) to open the chat widget.

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

## See also

[JavaScript API reference](../omni-channel-reference.md)