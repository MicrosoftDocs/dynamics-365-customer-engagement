---
title: lcw:closeChat 
description: lcw closeChat event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: reference
ms.date: 03/18/2025
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:closeChat event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a chat is closed.

## Example

```javascript
window.addEventListener("lcw:closeChat", function handleLivechatClosedEvent(){
// Handle the live chat closed event
});
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:startChat](lcw-startchat.md)
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   

[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
