---
title: "getAgentAvailability (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes information about getAgentAvailability method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 04/01/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# getAgentAvailability

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[getAgentAvailability-description](../includes/getAgentAvailability-description.md)]

> [!NOTE]
> Listen for the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();`

## Parameters

None

## Return value

None

## Example

```JavaScript
window.addEventListener("lcw:getAgentAvailability", function handlegetAgentAvailabilityEvent(){
               // Closes an existing chat
               Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();
});
```

### See also

[startChat](startChat.md)<br />
[setContextProvider](setContextProvider.md)<br />
[Live chat SDK reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
