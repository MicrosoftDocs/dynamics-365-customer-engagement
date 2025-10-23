---
title: getAgentAvailability (JavaScript API reference) for Omnichannel for Customer Service
description: Includes reference information about getAgentAvailability method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference.
ms.date: 04/04/2025
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# getAgentAvailability

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[getAgentAvailability-description](../includes/getAgentAvailability-description.md)]

> [!NOTE]
> - Listen for the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods can be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
> - This method can be called multiple times from the client side when customer input changes. The client side cache is refreshed every 2 minutes or when the customer context parameters change.
> - This method can be called 100 times per minute per organization only. If you exceed the limit, you see the http 429 response status code indicating that you sent too many requests in a specified amount of time.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();`

## Parameters

None

## Return value

| Name                     |   Type      |     Description            |
|----                      |----         |----------------------------|
|`queueId`                 | String      |  The target queue where the request is routed​ based on routing rule configuration and input data (value of entity and context which are part of routing rule are provided).   |
|`isQueueAvailable`  | Boolean     | Displays:<br> - TRUE if the queue is within operating hours.<br> - FALSE if the queue is outside operating hours.   |
|`StartTimeOfNextOperatingHour`           | DateTime    | The start time (UTC) of operating hours for the queue if it's outside operating hours​. During operating hours, a value of 01-01-0001 is returned.|
|`EndTimeOfNextOperatingHour`          | DateTime    | The time (UTC) when operating hours end for the queue if it's outside operating hours. During operating hours, a value of 01-01-0001 is returned.|
| `nexttransitiontime`        | DateTime      | The time (UTC) when the queue is operational again if it's outside operating hours. The time when the queue isn't operational is displayed during operating hours.|
|`positionInQueue`         | Number      | The position in queue for a customer waiting behind other customers in the same queue​. |
| `isAgentAvailable`       | Boolean     | Displays: <br> - TRUE if agents in the queue are currently available to take requests based on configured routing and assignment rules for workstream. The API also returns true if a bot is attached to the workstream or a queue. We recommend that this API be not used when a bot is present. <br> - FALSE if agents aren't available to take requests. |
| `averageWaitTime`        | Number      | Average wait time in minutes for customers in the target queue based on past 48-hour data.|

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Gets the agent availability
               Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability();
});
```


### Pass custom context values for the function to make sure context is received

This method performs an internal call to the setContextProvider function and then calls getAgentAvailability synchronously, to make sure that the context is set before continuing. Because of the async nature of the functions when they are used separately, the context might not be ready when the consulting agent is available.

> [!NOTE]
> You don't need to call the setContextProvider method before calling getAgentAvailability.

Here's a sample code that shows how to use the `setContextProvider` method.

```JavaScript
// To set the custom context, pass the custom context object as input parameter to agent availability

    // provider as part of the logic, so there is no need to set custom context before this call.

    Microsoft.Omnichannel.LiveChatWidget.SDK.getAgentAvailability({

        customContext : {

                'jwtToken': {'value':'token','isDisplayable':true},

                'Email': {'value':'test@test.com','isDisplayable':true},

                'client': {'value':'true','isDisplayable':true},

                'Emailing': {'value':'true','isDisplayable':true}

        }

    }

    );
```


### Related information

[startChat](startchat.md)  
[setContextProvider](setContextProvider.md)  
[Live chat SDK reference](../../omnichannel-reference.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
