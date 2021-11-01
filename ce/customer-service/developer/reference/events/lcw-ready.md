---
title: "lcw:ready | MicrosoftDocs"
description: lcw ready event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# lcw:ready event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[lcw-ready-description](../includes/lcw-ready-description.md)]

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Handle livechat ready event
               // SDK methods are ready for use now
});

```  

### See also

[lcw:startChat](lcw-startChat.md)   
[lcw:closeChat](lcw-closeChat.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onClose.md)  
[lcw:onMinimize](lcw-onMinimize.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:onMessageSent](lcw-onMessageSent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)] 
