---
title: "getQueueAvailability (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes information about getQueueAvailability method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 03/15/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# getQueueAvailability

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[getQueueAvailability-description](../includes/getQueueAvailability-description.md)]

> [!NOTE]
> Listen for the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getQueueAvailability();`

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
