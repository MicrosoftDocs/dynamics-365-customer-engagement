---
title: "lcw onClose | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.topic: article
---
# lcw:closeChat (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget has completely closed the widget. You can use this event to create custom experiences around closure of the chat widget. 

## Example

```javascript
window.addEventListener("lcw:onClose", function handleWidgetCloseEvent(){ // Handle the live chat widget close event }); 
```

### See also

[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
