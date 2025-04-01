---
title: lcw:onMinimize
description: lcw onMinimize event (Omnichannel for Customer Service JavaScript API reference).
ms.topic: reference
ms.date: 03/18/2025
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:onMinimize event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget minimizes the widget. You can use this event to create custom experiences around this activity. For example, if you implemented a custom button, you can update your button to reflect that the chat is minimized.

## Example

```javascript
window.addEventListener("lcw:onMinimize", function handleWidgetMinimizeEvent(){ // Handle the live chat widget minimize event }); 
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:startChat](lcw-startchat.md)   
[lcw:closeChat](lcw-closechat.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
