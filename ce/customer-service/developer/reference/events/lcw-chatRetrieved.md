---
title: "lcw:chatRetrieved | MicrosoftDocs"
description: lcw chatRetrieved event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
---
# lcw:chatRetrieved event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised when an ongoing chat conversation is retrieved from cache after a page reload or is opened on another tab.

## Example

```javascript
window.addEventListener("lcw:chatRetrieved", function handleLivechatRetrievedEvent(){
    // Handle livechat retrieved event 
});
```

### See also

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onClose.md)  
[lcw:ready](lcw-ready.md)  
[lcw:closeChat](lcw-closeChat.md)  
[lcw:onMinimize](lcw-onMinimize.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:onMessageSent](lcw-onMessageSent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
