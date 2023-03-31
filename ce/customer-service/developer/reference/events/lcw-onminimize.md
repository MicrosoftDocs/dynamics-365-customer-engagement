---
title: "lcw:onMinimize | MicrosoftDocs"
description: lcw onMinimize event (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
ms.date: 11/10/2021
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.reviewer: nenellim
---
# lcw:onMinimize event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget minimizes the widget. You can use this event to create custom experiences around this activity. For example, if you have implemented a custom button, you can update your button to reflect that the chat has been minimized.

## Example

```javascript
window.addEventListener("lcw:onMinimize", function handleWidgetMinimizeEvent(){ // Handle the live chat widget minimize event }); 
```

### See also

[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onClose.md)  
[lcw:startChat](lcw-startChat.md)   
[lcw:closeChat](lcw-closeChat.md)  
[lcw:onMaximize](lcw-onMaximize.md)  
[lcw:onMessageReceived](lcw-onMessageReceived.md)  
[lcw:onMessageSent](lcw-onMessageSent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
