---
title: "lcw threadUpdate | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/16/2020
ms.topic: article
---
# lcw:threadUpdate (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised by live chat when an agent ends a conversation. It indicates that agent has ended the conversation.

Listen to `lcw:threadUpdate` event and call [closeChat](../methods/closeChat.md) method to end conversation from client side. You can listen for this event by adding your own event listener on the window object.

## Example

```JavaScript
window.addEventListener("lcw:threadUpdate", function handleLivechatThreadUpdateEvent(){
        // Handle livechat threadUpdate event, e.g.:
        // End the conversation using closeChat method
        Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
});
```
### See also

[lcw:error](lcw-error.md)<br />
[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)