---
title: "lcw:getAgentAvailability | MicrosoftDocs"
description: "Live chat widget getAgentAvailability event (Omnichannel for Customer Service JavaScript API reference)."
ms.topic: reference
ms.date: 03/18/2025
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:getAgentAvailability event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised when the [`getAgentAvailability`](../methods/getAgentAvailability.md) method returns a successful response.

## Example

```javascript
window.addEventListener("lcw:getAgentAvailability", function handlegetAgentAvailabilityEvent(){
    // Handle getAgentAvailability event 
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
[Live chat SDK reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
