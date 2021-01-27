---
title: "lcw onMaximize | MicrosoftDocs"
description: lcw onMaximize (Omnichannel for Customer Service JavaScript API reference)
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.topic: article
ms.reviewer: nenellim
ms.service: dynamics-365-customerservice
---
# lcw:onMaximize (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget maximizes the widget. You can use this event to create custom experiences around this activity. For example, if you have implemented a custom button, you can update your button to reflect that the chat is currently launched and ongoing. 

## Example

```javascript
window.addEventListener("lcw:onMaximize", function handleWidgetMaximizeEvent(){ // Handle the live chat widget maximize event }); 
```

### See also

[lcw:onMinimize](lcw-onminimize.md)<br />
[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
