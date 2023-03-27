---
title: "lcw:closeChat | MicrosoftDocs"
description: lcw closeChat event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
manager: shujoshi
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

### See also

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:startChat](lcw-startchat.md)
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onClose.md)  
[lcw:onMinimize](lcw-onMinimize.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:onMessageSent](lcw-onMessageSent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   

[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
