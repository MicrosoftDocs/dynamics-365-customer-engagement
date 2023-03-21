---
title: "lcw:onClose | MicrosoftDocs"
description: lcw onClose event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# lcw:onClose event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget has closed the widget. You can use this event to create custom experiences around closure of the chat widget.

When an agent ends a conversation, a call can be made to closeChat() in order to end the conversation on the client side. This event is raised when the closeChat() SDK method is called.

## Example

```javascript
window.addEventListener("lcw:onClose", function handleWidgetCloseEvent(){ // Handle the live chat widget close event }); 
```

### See also
[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:closeChat](lcw-closeChat.md)  
[lcw:startChat](lcw-startChat.md)   
[lcw:onMinimize](lcw-onMinimize.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:onMessageSent](lcw-onMessageSent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
