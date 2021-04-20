---
title: "closeChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: 
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 07/09/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---
# closeChat

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This method ends the conversation between the agent and the customer. Any browser cache related to the conversation is also deleted.

> [!NOTE]
> Listen for the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();`

## Parameters

None

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Closes an existing chat
               Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
});
```

### See also

[startChat](startChat.md)<br />
[setContextProvider](setContextProvider.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]