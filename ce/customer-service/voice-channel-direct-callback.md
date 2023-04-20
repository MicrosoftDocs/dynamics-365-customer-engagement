---
title: "Configure direct callback to manage overflowing queues"
description: "Learn how to configure and use direct callback in the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 02/02/2023
ms.topic: how-to
ms.custom: bap-template
---

# Configure direct callback

Direct callback enables customers to request a callback as soon as an agent is available instead of waiting on the call. You can configure the direct callback option at the queue level by using the overflow action "direct callback" for a specific queue condition. After the call reaches the number one position in the queue, the direct callback work item is assigned to the next available agent through a notification just like any regular work item that's waiting in queue. Except that the notification identifies the work item as a callback versus a regular inbound call.  After the agent accepts the work item, a callback to the customer who requested a direct callback is automatically initiated and connected to the agent. In summary, direct callback helps provide better customer experiences by avoiding waiting in queue and helps administrators staff queues more efficiently to handle peak volume periods.

## Prerequisites for direct callback

The following prerequisites must be met:

- Voice queues and workstreams must be created. More information: [Set up inbound calling](voice-channel-inbound-calling.md)
- Agents must be configured for the queues. More information: [Create queues and add users](queues-omnichannel.md)
- Unified routing must be enabled. More information: [Provision unified routing](provision-unified-routing.md)

## Configure direct callback to manage overflow of voice calls

The customer disconnects the call after acknowledging the message for the direct callback offer. Direct callback can be the action when the queue is in one of the following conditions:

- Exceeds a defined number of calls that are waiting in the queue
- Exceeds the estimated wait time

Direct callback uses two automated messages that are available by default and can be customized:  

- The initial message offers the callback option to the customer as follows: "Current wait times are longer than expected. If you would like a call back, please press 1 or continue to wait for the next available agent."
- The second message confirms the callback selection when the customer presses 1 and notifies the customer that the call will end. The message played to the customer is, as follows: "You have requested a callback. We will call you back as soon as an agent is available. Goodbye!"

For more information, go to [Configure automated messages](configure-automated-message.md). For information on how to configure the conditions and actions, go to [Manage overflow of work items in queues](manage-overflow.md).

You can also configure overflow override in the route-to-queue rule of a workstream.

## How direct callback works

The direct callback is triggered by the queue overflow conditions where the corresponding action is direct callback.

1. An automated message is presented to the customer that asks if the customer prefers a callback by the agent over waiting in the queue. The automated message repeats after every 30 seconds until one of the following actions takes place:
  
   - The customer selects the option
   - Ends the call
   - The customer is connected to an agent
  
1. If the customer acknowledges the callback option by pressing 1, a second message is played for the customer that acknowledges the customer choice and lets the customer know about receiving a callback.
1. The call ends for the customer but the work item remains in the queue.
1. When the work item reaches the position 1, a voice callback is initiated automatically.
1. The callback is of the type preview dialing, in which the agent has to accept the callback using a callback-specific notification before the call is dialed.

## Next steps

[Manage overflow of work items in queues](manage-overflow.md)  

### See also

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  
[Configure voicemail](voice-channel-voicemail.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
