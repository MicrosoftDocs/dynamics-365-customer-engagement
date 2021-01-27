---
title: "lcw startChat | MicrosoftDocs"
description: 
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.topic: article
---
# lcw:startChat (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a chat is started.

Lcw:startChat is raised when the related startChat() SDK method is called.

When a customer starts a chat, a call is made to the startChat() SDK method. This event is then raised when the startChat() SDK method is called.

## Example

```javascript
window.addEventListener("lcw:startChat", function handleLivechatStartedEvent(){
    // Handle the live chat started event
});
```

### See also

[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
