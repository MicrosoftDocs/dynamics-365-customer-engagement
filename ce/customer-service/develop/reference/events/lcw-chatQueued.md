---
title: "lcw:chatQueued | MicrosoftDocs"
description: lcw chatQueued event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
---
# lcw:chatQueued event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised when the chat conversation is created and started. 

## Example

```javascript
window.addEventListener("lcw:chatQueued", function handleLivechatQueuedEvent(){
    // Handle livechat queued event
});
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
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
