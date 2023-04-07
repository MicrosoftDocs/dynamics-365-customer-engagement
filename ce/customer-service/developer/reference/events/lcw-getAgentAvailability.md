---
title: "lcw:getAgentAvailability | MicrosoftDocs"
description: "Live chat widget getAgentAvailability event (Omnichannel for Customer Service JavaScript API reference)."
ms.topic: reference
ms.date: 04/04/2022
author: gandhamm
ms.author: mgandham
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
[Live chat SDK reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
