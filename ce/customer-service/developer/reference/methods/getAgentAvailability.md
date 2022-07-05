---
title: "getAgentAvailability (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes reference information about getAgentAvailability method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 04/04/2021
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
> - This method can be called multiple times from the client side when customer input changes. The client side cache is refreshed every 2 minutes or when the customer context parameters change.
> - This method is supported for authenticated chat only.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();`

## Parameters

None

## Return value

| Name                     |   Type      |     Description            |
|----                      |----         |----------------------------|
|`queueId`                 | String      |  The target queue where the request will be routed​ based on routing rule configuration and input data (value of entity and context which are part of routing rule are provided). The method returns the default queue id if the routing rules aren't configured or queues based on configured rules can't be identified. |
|`isQueueAvailable`  | Boolean     | Indicates whether the queue is within operating hours.  |
|`nextTransitionTime`           | DateTime    | The time (UTC) when the queue will be available next if it is outside operating hours or the time (UTC) when the queue is available.|
|`positionInQueue`         | Number      | The position in queue for a customer waiting behind other customers in the same queue​. |
| `isAgentAvailable`       | Boolean     | Indicates whether agents in the queue are currently available to take requests based on configured routing and assignment rules for workstream. |
| `averageWaitTime`        | Number      | Average wait time in minutes for customers in the target queue based on past 48-hour data.|


### Set the context and register the event

You must set the context and register the `getAgentAvailability` event in the lcw:ready event listener call,  `Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();`.  For more information, see: 

- [setContextProvider](setcontextprovider.md)
- [Send authentication token](send-auth-token-starting-chat.md)

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Sets the context and register event
               // Gets the agent availability
               Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();
});
window.addEventListener("lcw:getAgentAvailability", function handlegetAgentAvailabilityEvent()
{
         // handles the lcw:getAgentAvailability event response 
        // add action which you want  to take on event lcw:getAgentAvailability response
}); 
```

### See also

[startChat](startChat.md)  
[setContextProvider](setContextProvider.md)  
[Live chat SDK reference](../../omnichannel-reference.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
