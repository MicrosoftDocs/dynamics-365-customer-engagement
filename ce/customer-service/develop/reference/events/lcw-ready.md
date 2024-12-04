---
title: "lcw:ready | MicrosoftDocs"
description: lcw ready event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
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

### Related information

[lcw:startChat](lcw-startchat.md)   
[lcw:closeChat](lcw-closechat.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK reference](../../omnichannel-reference.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)] 
