---
title: "Use direct callback to manage overflowing queues"
description: "Learn how to use direct callback in the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/15/2022
ms.topic: article
---

# Use direct callback (preview)

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Direct callback enables customers to request a callback as soon as an agent is available. Direct callback helps provide better customer experience by avoiding waiting in queue.

When a customer calls a personal phone number, the conversation will be directly assigned to the agent associated with the phone number.

If the agent doesn't pick up the call, a system message will be played, and the conversation will end. If overflow of calls is configured, the customer is presented with the option to end the call and receive a callback.

## Prerequisites for direct callback

The following prerequisites must be met:

- The agent must have a phone number assigned on the **Omnichannel** tab of the user configuration page.
- Direct inbound calling must be configured.

## Use direct callback to manage overflow of voice calls

The customer disconnects the call after acknowledging the message that their call will be returned by the agent when the queue is in one of the following conditions:

- Exceeds a defined number of calls that are waiting in the queue
- Exceeds the estimated wait time

For information on how to configure the conditions and actions, see [Manage overflow of work items in queues](manage-overflow.md).

You can also configure overflow override in the route-to-queue rule of a workstream.

## How direct callback works?

The direct callback is triggered by the queue overflow conditions where the corresponding action is direct callback.

1. An automated message is presented to the customer that asks if the customer prefers a callback by the agent over waiting in the queue. The automated message repeats after every 30 seconds until one of the following actions takes place:
  
   - The customer selects the option
   - Ends the call
   - The customer position in queue reaches the callback threshold that's configured.

1. If the customer acknowledges the callback option by pressing 1, a second message is played for the customer that acknowledges the customer choice and lets the customer know about receiving a callback.

1. The call ends for the customer but the work item remains in the queue.

1. When the work item reaches the position 1, a voice callback is initiated automatically. This callback is of the type preview dialing, in which the agent gets to review the customer record information before the call is dialed.

1. The agent receives a notification. After the agent accepts the call notification, the call is made to the customer.

### See also

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  
[Manage overflow of work items in queues](manage-overflow.md)  
[Use voicemail](voice-channel-voicemail.md)  



[!INCLUDE[footer-include](../includes/footer-banner.md)]
