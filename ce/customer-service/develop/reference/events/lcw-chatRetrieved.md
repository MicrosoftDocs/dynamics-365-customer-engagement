---
title: lcw:chatRetrieved 
description: lcw chatRetrieved event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: reference
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:chatRetrieved event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]


This event occurs when the system retrieves an ongoing chat conversation from cache after a page reload or opens it on another tab.

## Example

```javascript
window.addEventListener("lcw:chatRetrieved", function handleLivechatRetrievedEvent(){
    // Handle livechat retrieved event 
});
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:ready](lcw-ready.md)  
[lcw:closeChat](lcw-closechat.md)  
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
