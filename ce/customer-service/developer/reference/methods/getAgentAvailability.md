---
title: "getAgentAvailability (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes reference information about getAgentAvailability method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 04/01/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# getAgentAvailability

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[getAgentAvailability-description](../includes/getAgentAvailability-description.md)]

> [!NOTE]
> - Listen for the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
> - The API can be called multiple times from the client side when customer input changes.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();`

## Parameters

None

## Return value

| Name                     |   Type      |     Description            |
|----                      |----         |----------------------------|
|`queueId`                 | String      |  The target queue where the request will be routed​ based on routing rule configuration and input data (value of entity and context which are part of routing rule) are provided.   |
|`isWithinOperatingHours`  | Boolean  | Boolean value for whether the queue is within operating hours.  |
|`availableNext`           |    DateTime  | The time (UTC) until when the queue will be available next if queue is outside operating hours​.|
|`availableUntil`          |    DateTime   | The time (UTC) until when the queue will be available.  |
|`positionInQueue`         |   Number  | The position in queue for the customer behind other customers waiting in the same queue​. |
| `isAgentAvailable`       |  Boolean  | If agents within the queue are currently available to take requests based on configured routing and assignment rules for workstream​. |
| `averageWaitTime`        | Number    | Average wait time in minutes for customers in the target queue based on past 48-hour data.|

## Example

```JavaScript
window.addEventListener("lcw:getAgentAvailability", function handlegetAgentAvailabilityEvent(){
               // Gets the agent availability
               Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();
});
```

### See also

[startChat](startChat.md)  
[setContextProvider](setContextProvider.md)  
[Live chat SDK reference](../../omnichannel-reference.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
