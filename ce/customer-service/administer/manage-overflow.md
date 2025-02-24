---
title: Handle queue overflow
description: Learn how to set up overflow conditions and actions for your Dynamics 365 Customer Service voice, chat, and messaging channels when there are more items in the queue than your team can handle.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 02/04/2025
ms.topic: how-to
ms.custom:
 - bap-template
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:02/21/2024
---

# Handle queue overflow

When a new work item arrives, unified routing in Dynamics 365 Customer Service directs it to the customer service representative (service representative or representative) who's best suited to work on it. But what happens if all the service representatives who could work on it are already at maximum capacity? And how do you handle work items that arrive when your call center is closed? Overflow handling in Customer Service helps you manage both surge conditions and after-hours calls.

A queue's overflow handling options can trigger actions either before or after a work item is queued.

[Before](#handle-overflow-before-a-work-item-is-queued):

- An incoming call or conversation exceeds the number of work items defined for the queue.
- A work item comes in outside of business hours.

[After](#handle-overflow-when-a-work-item-is-queued):

- Customers are waiting in the queue longer than the time defined for the queue.

If you don't set up overflow handling, then by default, the work item is added to the queue and the customer waits to be connected to a service representative. You can send notifications to the customer, for example, about their place in the queue or when their query will be resolved.

## Prerequisites

- [Unified routing is configured](./set-up-routing-process.md) and [you've set up queues and added representatives](./queues-omnichannel.md) to them.
- If you plan to transfer calls to an external number, external phone numbers with outbound calling are available.
- If you plan to trigger overflow handling before work items are queued, you've [configured route-to-queue rules](./configure-route-to-queue-rules.md) in the workstream.

## Handle overflow before a work item is queued

Unified routing checks for overflow conditions after evaluating the route-to-queue rules and before directing a work item to a queue. If an overflow action transfers the work item to another queue, or a supervisor assigns the work item to a service representative or transfers it to another, the work item is assigned to the representative or the queue without any further overflow checks.

The system considers the following factors when it checks for overflow conditions before a work item is queued:

- If multiple queues match the route-to-queue rules, the system routes the work item to the first one that's not overflowing.

- If all matched queues are overflowing, then:

  - If a queue is operational, the system routes the work item to it and triggers the overflow action.
  - If none of the queues are operational, the system routes the work item to the queue that will be operational earliest and triggers the overflow action.
  
- If percentage-based routing is configured, the overflow conditions are evaluated after percentage-based routing matches a queue.

- If the matched queue is overflowing due to multiple conditions, the system triggers the action that's defined for the operating hours condition first, followed by the other conditions in the order they're defined.

- If a work item is routed to a fallback queue because of errors or no route-to-queue rule matches the requirement, the system ignores the overflow settings for the fallback queue and assigns the work item to it.

- If an AI agent is configured for the workstream, the system checks for overflow conditions only after the AI agent escalates the conversation to a service representative. If multiple escalations happen, the system checks for overflow conditions and triggers an action after the first one.

When you add an operating hour record to a queue, the system assigns a default overflow condition **Out of operation hours** with the action **Assign to queue anyway**. You can't edit the condition, but you can set a different action for it.

The channel-specific operating hour setting that's configured in the workstream doesn't affect the overflow settings.

The following table lists the conditions and actions that are available for each channel type.

| Channel | Condition | Action |
|---------|-----------|-------|
| Voice | <ul><li>Out of operating hours</li><li>Work item limit exceeds</li><li>Average wait time</li></ul> | <ul><li>Assign to queue anyway</li><li>Direct callback</li><li>End call</li><li>Transfer to a different queue</li><li>Transfer to an external number</li><li>Voicemail</li></ul> |
| Live chat and other messaging channels | <ul><li>Out of operating hours</li><li>Work item limit exceeds</li></ul> | <ul><li>End conversation</li><li>Transfer to a different queue</li><li>Assign to queue anyway</li></ul> |
| Record | <ul><li>Out of operating hours</li></ul> | <ul><li>Assign to queue anyway</li><li>Transfer to a different queue</li></ul> |

### Configure overflow conditions for before a work item is queued

1. In the Customer Service admin center site map, select **Customer support** > **Queues**.

1. Select **Advanced queues**, and then select the queue you want to manage overflow for.

1. Under **Overflow handling**, select **Add condition-action pair**.

1. In the **Overflow handling** page, in **Before work items are queued**, select **Add condition-action pair**.

1. In the **Condition** dropdown list, select the condition that you want to set for the queue. The available conditions depend on the channel type.

1. In the **Action** dropdown list, select the action that you want to trigger when the condition is met.

1. Enter as many condition-action pairs as you need for the queue, and then select **Save and close**.

    :::image type="content" source="../media/overflow-condition-action.png" alt-text="A screenshot of overflow condition and action pairs configured for a queue.":::

- For the record, messaging, and voice queues, you can select the **Out of operation hours** condition and one of the following actions:

  - **Assign to queue anyway**: The work item is directed to the queue even though it's overflowing.
  - **Transfer to a different queue**: The work item is transferred to the queue that you select in the dropdown list.
  
- For the messaging and voice queues, you can also select the following actions for the **Out of operation hours** condition:

  - **End call**: For voice queues only. An automated voice message plays and the call ends.
  - **End conversation**: For messaging queues only. The conversation is routed to the queue and ended.
  - **Transfer to an external number**: For voice queues only. The work item is transferred to the phone number that you enter.
  - **Voicemail**: For voice queues only. The customer can choose to leave a voicemail.
  
- For the messaging and voice queues, you can also select the following conditions and actions:

  - **Work item limit exceeds**: Enter a number between 1 and 100 to indicate how many open work items can be in the queue before it overflows. For example, if you enter *2*, then if the queue contains two open work items, the arrival of a third item triggers one of the following actions:
  
    - **Direct callback**: For voice queues only. The customer can choose to have the representative call them back. The work item stays open and is routed to the next available representative for callback.
    - **End call**
    - **End conversation**
    - **Transfer to a different queue**
    - **Transfer to an external number**
    - **Voicemail**

  - **Average wait time**: For voice queues only. Enter a number and select a unit of time between 30 seconds and 60 minutes to indicate how long the predicted wait time can be before the queue overflows. For example, if you enter *10 Minutes*, then if a customer calls and the predicted wait time is 15 minutes, the system triggers one of the following actions:
  
    - **Direct callback**
    - **End call**
    - **Transfer to a different queue**
    - **Transfer to an external number**
    - **Voicemail**

    The average wait time for a queue is calculated by taking the average wait time of at least 50 conversations in the queue during the previous 48 hours. If the number of conversations in the previous 48 hours is less than 50, the **Average wait time** overflow condition isn't evaluated.

### Configure rule-specific overflow conditions for before a work item is queued

Sometimes you might not want an overflow action to run for specific types of work items or for priority customers. Let's say that a priority customer calls, the queue to which they're routed is overflowing, and the queue is set to end the call or keep the customer waiting. Either action might violate the service-level agreement that you have with your customer. In this scenario, you might want to configure rule-specific overflow conditions for the queue in the workstream's route-to-queue rules.

1. In the Customer Service admin center site map, select **Customer support** > **Workstreams**.

1. Select the workstream, and then select the route-to-queue rule in which the queue is configured.

1. Under **Route to queues**, select the queue in the dropdown list, and then select **More commands** (**&vellip;**) > **Handle rule-specific overflows**.

    :::image type="content" source="../media/queue-overflow-override.png" alt-text="Screenshot of the Edit route to queue rule page showing where to find the Handle rule-specific overflow option.":::

1. [Select overflow condition-action pairs](#configure-overflow-conditions-for-before-a-work-item-is-queued).

### View diagnostics for overflow handling

When a work item is handled by an overflow action instead of being assigned to a representative, you can view its status in **Routing diagnostics** > **Route to queue**.

:::image type="content" source="../media/overflow-diagnostics.png" alt-text="Screenshot of routing diagnostics for a work item that triggered an overflow action.":::

## Handle overflow when a work item is queued

When a work item is in a queue and the wait is long, the system can reroute it to another queue that has representatives available.

1. In the site map of Customer Service admin center, select **Customer support** > **Queues**.

1. Select **Advanced queues**, and then select the queue you want to manage overflow for.

1. In **Overflow handling**, select **Edit**.

1. In **When work items are queued**, select **Add condition-action pair**.

1. Select the **Waiting time in queue exceeds** condition.

1. Enter a number and select a unit of time to indicate how long the predicted wait time can be before the queue overflows. If more than 20 work items overflow in a minute, the work items are addressed in batches. Those queues that have a lower wait time are addressed first. If all queues are configured with the same wait time, then overflow handling takes place in a round robin manner.

1. [Select overflow condition-action pairs for queued work items](#overflow-condition-and-actions-when-work-items-are-queued).

1. Select **Save and close**.

### Overflow condition and actions when work items are queued

The conditions and actions available for the channels are as follows.

| Channel | Condition | Action |
|---------|-----------|-------|
|Record|Waiting time in queue exceeds|Transfer to a different queue|

### Things to keep in mind

You can configure the following wait time for the records channel:

- Records channel: 3 minutes to 2 days

The "wait time in queue" condition is evaluated in any of the following scenarios:
- Work item is routed to a queue via the route to queue rules.
- Work item is transferred by a representative or supervisor to the queue.
- Work item overflows from another queue.

If a queued work item is moved to another queue because of long wait times, and the new queue also has overflow handling, the system checks for overflow conditions again. If the wait time is too high in the new queue as well, it triggers the overflow action.

## Edit automated messages for overflow actions

If you set **End call** or **End conversation** as an overflow action, you can edit the automated message that informs the customer that no representatives are available.

1. In the Customer Service admin center site map, select **Customer support** > **Customer settings**.

1. Select **Automated messages**.

1. Find the automated message for the channel where the message trigger is **End conversation due to overflow**.

1. Edit the value of the **Localized text** column as needed.

  :::image type="content" source="../media/voice-channel-overflow-end-call-message.png" alt-text="Screenshot of the list of automated messages.":::

[Learn more about customizing automated messages](configure-automated-message.md#customize-automated-messages-at-the-channel-level).

### Related information

- [Configure voicemail](voice-channel-voicemail.md)
- [Configure direct callback](voice-channel-direct-callback.md)
- [Create and manage queues](queues-omnichannel.md)
- [Configure percentage-based routing](configure-route-to-queue-rules.md#percentage-based-allocation-of-work-to-queues)
- [Overview of voice channel](voice-channel.md)
- [Overview of unified routing](overview-unified-routing.md)
- [Configure routing for the voice channel](voice-channel-inbound-calling.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
