---
title: "lcw:error | MicrosoftDocs"
description: "Includes information about lcw:error event (Omnichannel for Customer Service JavaScript API reference)."
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# lcw:error event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[lcw-error-description](../includes/lcw-error-description.md)]

## Example

The sample code given below shows how the errorEvent is caught and how the error details are obtained.

```JavaScript
window.addEventListener("lcw:error", function (errorEvent) {
    let errorDetail = errorEvent.detail; // Object containing details about the error event
    let errorCode = errorEvent.detail.errorCode; // Error code corresponding to the error event
    let errorDescription = errorEvent.detail.errorDescription; // Description of the error
});
```

### Related information

[lcw:ready](lcw-ready.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:closeChat](lcw-closechat.md)  
[lcw:startChat](lcw-startchat.md)   
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageReceived](lcw-onmessagereceived.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   

[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
