---
title: "lcw onClose | MicrosoftDocs"
description: lcw onClose (Omnichannel for Customer Service JavaScript API reference)
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.topic: article
ms.reviewer: nenellim
ms.service: dynamics-365-customerservice
---
# lcw:onClose (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget has closed the widget. You can use this event to create custom experiences around closure of the chat widget.

When an agent ends a conversation, a call can be made to closeChat() in order to end the conversation on the client side. This event is raised when the closeChat() SDK method is called.

## Example

```javascript
window.addEventListener("lcw:onClose", function handleWidgetCloseEvent(){ // Handle the live chat widget close event }); 
```

### See also

[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
