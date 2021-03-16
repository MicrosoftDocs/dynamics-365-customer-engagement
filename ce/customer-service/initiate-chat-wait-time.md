---
title: "Initiate a chat | Microsoft Docs"
description: "Read how you can start a chat using the startChat API"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 07/15/2019
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Initiate a chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Follow these steps to start a chat:

1. Listen to the **lcw:ready** event raised by a live chat to start using the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
2. Once the **lcw:ready** event is raised, call the [startChat](developer/reference/methods/startChat.md) method to initiate a chat.

> [!NOTE]
> To use a custom chat button instead of the out-of-the-box chat button, add the attribute `data-hide-chat-button` in the Widget snippet and set its value to `true`. Invoke the [startChat](developer/reference/methods/startChat.md) method on click of the custom UI component to start chat.
>
> **Sample widget code snippet to hide chat button**
>
> `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`  

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

The sample code given below shows how you can start a chat after the customer has been waiting for 5 minutes.

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
    // Open chat widget proactively after customer has been waiting for 5 minutes
    setTimeout(function startProactiveChat() {
        Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
    }, 300000);
});
```
### See also

[startChat](developer/reference/methods/startChat.md)<br />
[JavaScript API reference for Live chat SDK](developer/omnichannel-reference.md)<br />
[Customize chat widget](customize-chat-widget.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]