---
title: lcw:onMessageSent 
description: lcw onMessageSent event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: reference
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:onMessageSent event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget sends a new message. You can use this event to create custom experiences around when users send a message. For example, this event can be used to detect user activity and engagement on the chat widget. 

## Example

```javascript
window.addEventListener("lcw:onMessageSent", function handleWidgetMessageSentEvent(){ // Handle the live chat widget message sent event }); 
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:closeChat](lcw-closechat.md)  
[lcw:startChat](lcw-startchat.md)   
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
