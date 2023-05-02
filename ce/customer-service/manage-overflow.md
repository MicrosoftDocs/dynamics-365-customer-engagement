---
title: Manage overflow of work items in queues
description: Learn how to manage overflow of work items in queues enabled for unified routing in Customer Service.
author: neeranelli
ms.author: nenellim
ms.date: 05/02/2023
ms.topic: how-to
ms.custom: bap-template
---

# Manage overflow of work items in queues

When a new work item gets routed with unified routing, the system tries to find the best-suited agent to work on the work item. Sometimes all eligible agents are at maximum capacity. In scenarios like these, you can configure overflow conditions to handle the surge and unassigned work items to ensure customer satisfaction. You can also send notifications to the customer about their waiting state or when their query will be resolved.

For work items, such as calls, conversations, and cases, you can address the following scenarios:

- When an incoming work item exceeds a defined number of conversations or calls that can wait in the queue.
- Calls and conversations are received during non-business hours of the call center.
- The wait time is high for customers and you want to reduce it.

If you don't configure overflow, by default, the work item will stay in the queue until it gets routed based on the routing rules configured for the workstream.

## How queue overflow is evaluated

The overflow conditions and actions are run only if the route-to-queues rule is configured. The overflow evaluation takes place before a work item is routed to a queue and after the route-to-queues rules are evaluated. Any manual actions like agent transfer or supervisor assign won't trigger overflow actions.

The following factors are considered during the overflow evaluation:

- If multiple queues match in the route-to-queues rules, the system routes the work item to the first queue that's not overflowing.

- If all matched queues are overflowing, one of the following actions takes place:

  - The system routes to the queue that's operational and the overflow action is triggered.
  - If none of the queues are operational, the system routes the work item to the queue that will be operational at the earliest and the overflow action is triggered.

- If the matched queue is overflowing due to multiple conditions:

  The system evaluates the action that's defined for the operating hours condition first, followed by the other conditions in the order they've been defined.

- If a work item is routed to a fallback queue because of errors or no route-to-queue rule has matched the requirement, the overflow settings for the fallback queue aren't considered and work item is assigned to the queue.

- If a bot is configured for the workstream, the overflow settings are evaluated only after the bot escalates the conversation to human agents.

- If multiple bot escalations happen before the conversation is escalated to a human agent, the overflow settings are evaluated and triggered after the first bot escalation.

When you add an operating hour record to a queue, the system assigns a default overflow condition as **Out of operation hours**, and its action as **Assign to queue anyway**. You can't edit the condition but can set another action for it.

The channel-specific operating hour setting that's configured in the workstream doesn't affect the overflow settings.

The following table lists the condition and action pairs available for different channel types.

| Channel | Condition | Action|
|---------|-----------|-------|
| Voice | <ul><li> Out of operating hours</li><li>Work item limit exceeds</li><li>Average wait time</li></ul> | <ul><li>Assign to queue anyway</li><li> Direct callback</li><li>End call</li><li>Transfer to a different queue</li><li>Transfer to an external number</li><li>Voicemail </li></ul> |
| Live chat and other messaging channels | <ul><li> Out of operating hours</li><li>Work item limit exceeds</li></ul> | <ul><li>End conversation</li><li>Transfer to a different queue</li><li>Assign to queue anyway</li></ul> |
| Record | <ul><li> Out of operating hours</li></ul> | <ul><li>Assign to queue anyway</li><li>Transfer to a different queue</li></ul> |

## Prerequisites

For overflow to work correctly, the following prerequisites must be met:

- Agents should be configured for the queues.
- To transfer calls to an external phone number, phone numbers should be available.

## Configure overflow conditions

Go to the Customer Service admin center app and perform the following steps:

1. In the site map, select **Queues** in **Customer support**.

1. On the **Queues** page, select **Manage** for **Advanced queues**.

1. Select the queue for which you want to manage overflow.

1. In **Overflow handling**, select **Add condition-action pair**. The **Overflow handling** dialog displays the options to configure conditions and actions.

1. Select **Add condition-action pair**. The **Condition** and **Action** fields are displayed.

1. For the record, messaging, and voice queues, you can set the **Out of operation hours** condition and one of the following actions:

    - **Assign to queue anyway**: The work item is routed to the queue although it's in the overflow state.
    - **Transfer to a different queue**: Select a queue in the dropdown list.

   For the **Out of operation hours** condition, the following extra actions are available for the messaging and voice queues:

     - **End call**: For voice queues only. An automated voice message is presented to the caller and the call ends.
     - **End conversation**: For messaging queues only. The conversation is routed to the queue and ended.
     - **Transfer to a different queue**: Select a queue from the dropdown list that appears. The work item is transferred to the selected queue.
     - **Transfer to an external number**: For voice queues only. Enter the number to which the call must be transferred.
     - **Voicemail**: For voice queues only. Customers can choose to leave a voicemail that the agents will receive to act upon.

1. For the messaging and voice queues, you can set the following extra conditions and actions:

    - **Work item limit exceeds**: Enter a value between 1 and 100 to denote the maximum number of work items that can be in the open state before overflow is reached. For example, if you enter 2 as the value, then two items should be open in the queue for the third item to trigger one of the following actions:

        - **Direct callback**: For voice queues only. Customers can choose to receive callback from agents that's presented to them by the automated message. The work item stays in the open state and is routed to the next available agent to call back the customer.
        - **End call**
        - **End conversation**
        - **Transfer to a different queue**
        - **Transfer to an external number**
        - **Voicemail**

    - **Average wait time**: This condition is available for voice queues only. Enter a value between 30 seconds and 60 minutes to denote the wait time. At runtime, if the predicted wait time for the queue is more than what you have configured, the system triggers one of the following overflow actions for the work item instead of adding it to the overflowing queue:

        - **Direct callback**
        - **End call**
        - **Transfer to a different queue**
        - **Transfer to an external number**
        - **Voicemail**

        > [!NOTE]
        > The average wait time is calculated for a queue by taking the average of the wait times for the previous 48 hours and a minimum of 50 conversations in the queue. <br>For example, if a customer calls on a Thursday at 5:00 PM, the wait time is calculated by taking the average wait time of all the calls from 5:00 PM, Tuesday that denotes the previous 48 hours, provided 50 or more calls are in queue. If the number of calls is less than 50, the "Average wait time" overflow condition isn't evaluated because it doesn't meet the criteria to calculate the wait time.

        :::image type="content" source="media/overflow-condition-action.png" alt-text="A screenshot of the condition and action pairs configured for the queue.":::

## Configure overflow override

In certain cases, you might not want an overflow action to be run for specific types of work items or for priority customers. For example, a priority customer raises an issue and the queue to which it's routed could be overflowing as "end call" or "keep waiting in queue". This action might not meet the service-level agreement (SLA) that you have with your customer. To handle such a scenario, you might want to configure override conditions for those queues in the route-to-queue rules at the workstream level.

1. In the Customer Service admin center, go to the required workstream and select the route-to-queue rule in which the queue is configured.

1. In the **Route to queues** area, select the **More commands** ellipses next to **Add queue**.

   :::image type="content" source="media/queue-overflow-override.png" alt-text="Configure override conditions for queues in the route-to-queue rule.":::

1. Select **Add queue overflow override**.

1. Perform the steps to add condition and action pairs and set the action for each condition that you define as listed in the **Configure overflow actions** section in this article.

## View diagnostics for overflow

Whenever a work item is handled by the overflow action instead of being assigned to an agent, you can view its status in the **Route to queue** stage of the diagnostic page.

:::image type="content" source="media/overflow-diagnostics.png" alt-text="View the diagnostic status of the overflow action triggered for the work item.":::

### Edit automated messages for end call overflow action

If you have set **End call** as an overflow action for the voice queue, an automated message will be delivered to the customer to let them know that the conversation will end. You can edit the message that the customer will hear.

1. In the Customer Service admin center site map, go to **Customer settings** in **Customer support**, and select **Automated messages**.
2. Find the automated message for the **Voice** channel where the message trigger is "Voice call ended".
3. Edit the value in the **Localized text** column as needed.

> [!div class="mx-imgBorder"]
> ![Out-of-the-box automated messages.](./media/voice-channel-overflow-end-call-message.png "Out-of-the-box automated messages.")

More information: [Customize automated messages](configure-automated-message.md#customize-automated-messages-at-the-channel-level)

### See also

[Configure voicemail](voice-channel-voicemail.md)  
[Configure direct callback](voice-channel-direct-callback.md)  
[Create and manage queues](queues-omnichannel.md)  
[Configure percentage-based routing](configure-route-to-queue-rules.md#percentage-based-allocation-of-work-to-queues)  
[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
