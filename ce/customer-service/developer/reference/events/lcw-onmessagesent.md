---
title: "lcw:onMessageSent | MicrosoftDocs"
description: lcw onMessageSent event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# lcw:onMessageSent event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a new message is sent by the customer engaged on the chat widget. You can use this event to create custom experiences around when users send a message. For example, this event can be used to detect user activity and engagement on the chat widget. 

## Example

```javascript
window.addEventListener("lcw:onMessageSent", function handleWidgetMessageSentEvent(){ // Handle the live chat widget message sent event }); 
```

### See also

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onClose.md)  
[lcw:closeChat](lcw-closeChat.md)  
[lcw:startChat](lcw-startChat.md)   
[lcw:onMinimize](lcw-onMinimize.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
