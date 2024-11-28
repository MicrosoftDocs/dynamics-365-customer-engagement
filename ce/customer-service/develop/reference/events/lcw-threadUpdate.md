---
title: "lcw:threadUpdate | MicrosoftDocs"
description: lcw threadUpdate event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# lcw:threadUpdate event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised by live chat when an agent ends a conversation.

Listen for the `lcw:threadUpdate` event, and call the [closeChat](../methods/closeChat.md) method to end the conversation from the client side. You can listen for this event by adding your own event listener on the window object.

## Example

```JavaScript
window.addEventListener("lcw:threadUpdate", function handleLivechatThreadUpdateEvent(){
        // Handle the live chat threadUpdate event, for example:
        // End the conversation using the closeChat method
        Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
});
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:closeChat](lcw-closechat.md)  
[lcw:ready](lcw-ready.md)   
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:startChat](lcw-startchat.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md) 


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)] 
