---
title: "Start a chat | MicrosoftDocs"
description: "Understand how to start a chat using the startChat API. Also included are code snippets to start a chat and hide the chat button."
ms.date: 07/15/2019
ms.topic: reference
author: neeranelli
ms.author: nenellim
---
# Start a chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Follow these steps to start a chat:

1. Listen to the **lcw:ready** event raised by a live chat to start using the [live chat SDK methods](developer/omnichannel-reference.md). The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
2. After the **lcw:ready** event is raised, call the [startChat](developer/reference/methods/startChat.md) method to start a chat.

   To authenticate a customer when you start a chat, see [Send authentication token](send-auth-token-starting-chat.md).

   To start a chat proactively depending on various customer scenarios in your organization, see [Start a chat proactively](start-proactive-chat.md).

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

Consider a scenario where the customer is on your portal page, and you want to start a chat after the customer has spent some time on the page. You can programmatically open the chat widget after the specified time has elapsed.

The following sample code shows how you can start a chat after the customer has been waiting for 5 minutes:

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
    // Open chat widget proactively after customer has been waiting for 5 minutes
    setTimeout(function startProactiveChat() {
        Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
    }, 300000);
});
```

## Use custom chat button

To use a custom chat button instead of the out-of-the-box chat button, add the attribute `data-hide-chat-button` in the widget snippet and set its value to `true`. Invoke the [startChat](developer/reference/methods/startChat.md) method on click of the custom UI component to start the chat.

### Sample code snippet to hide the standard chat button

`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`  

### See also

[startChat](developer/reference/methods/startChat.md)  
[JavaScript API reference for Live Chat SDK](developer/omnichannel-reference.md)  
[Customize chat widget](customize-chat-widget.md)  
[Start a chat proactively](start-proactive-chat.md)    

[!INCLUDE[footer-include](../includes/footer-banner.md)]
