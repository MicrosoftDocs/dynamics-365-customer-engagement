---
title: "Manage overflow | MicrosoftDocs"
description: "Learn how to manage overflow of work items in Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/01/2022
ms.topic: article

---

# Manage overflow of work items in queues

When a new work item gets routed with unified routing, the system tries to find the best-suited agent to work on the work item. Sometimes all the eligible agents are tied up at maximum capacity. In scenarios like these, you can configure overflow conditions to handle the surge and unassigned work items and ensure customer satisfaction. You can also send notifications to the customer about their waiting state or when their query will be resolved.

For work items, such as calls, conversations, and cases, you can address the following scenarios:

- When an incoming work item exceeds a defined number of conversations or calls that can wait in the queue
- Calls and conversations are received during the after hours of the call center operations
- The wait time is very high for customers and you want to reduce it

If you don't configure overflow, by default, the work item will remain in queue till it get's routed based on the routing rules configured for the workstream.

After you've configured overflow of work items, in situations where all queues are overflowing, priority is given to those queues that satisfy the "out of operating hours" condition.

The following table lists the condition and action pairs available for different channel types.

| Channel | Condition | Action|
|---------|-----------|-------|
| Voice | <ul><li> Out of operating hours</li><li>Work item limit exceeds</li><li>Estimated wait time exceeds</li></ul> | <ul><li> Direct callback (preview)</li><li>End call</li><li>Transfer to a different queue</li><li>Transfer to an external number</li><li>Voicemail (preview)</li> </ul> |
| Live chat and other messaging channels | <ul><li> Out of operating hours</li><li>Work item limit exceeds</li></ul> | <ul><li>End conversation</li><li>Transfer to a different queue</li><li>Assign to queue anyway</li></ul> |
| Record | <ul><li> Out of operating hours</li></ul> | <ul><li>Assign to queue anyway</li><li>Transfer to a different queue</li></ul> |

> [!NOTE]
> The direct callback and voicemail features are in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

## Prerequisites

For overflow to work correctly, the following prerequisites must be met:

- Agents should be configured for the queues.
- To transfer calls to an external phone number, phone numbers should be available.

## Configure overflow conditions

1. In Dynamics 365, go to the Customer Service admin center app, and perform the following steps:

1. In the site map, select **Queues** in **Customer support**.

1. On the **Queues** page, select **Manage** for **Advanced queues**.

1. Select the queue for which you want to configure call overflow.

1. In **Overflow conditions**, select **Set overflow conditions**. The **Overflow management** dialog displays the options to configure conditions and actions.

    1. For the record queue, you can set the **Out of operation hours** condition and one of the following actions:
        - **Assign to queue anyway**: Work item stays in the queue.
        - **Transfer to a different queue**: Select a queue in the dropdown list.

    1. For the messaging and voice queues, you can set the following additional conditions and actions:

        - **Work item limit exceeds**: Enter a value to denote the maximum number of work items that can be in the waiting state before overflow is reached. For example, if you enter 2 as the value, then two items should be waiting in the queue for the third item to trigger one of the following actions:
            - **Direct callback (preview)**: For voice calls only. Customers can opt to receive callback from agents that's presented to them by the automated message. The work item remains in open state and is routed to the next available agent to call back the customer.
            - **End call**: For voice calls only. An automated voice message is presented to the caller and the call ends.
            - **End conversation**:
            - **Transfer to a different queue**: Select a queue from the dropdown list that appears.
            - **Transfer to an external number**: Enter the number to which the call must be transferred.
            - **Voicemail (preview)**

        - **Estimated wait time exceeds**: This condition is available for the voice queues only. Enter a value to denote the wait time after which one of the following overflow actions will be triggered:
            - **Direct callback (preview)**
            - **End call**
            - **Transfer to a different queue**
            - **Transfer to an external number**
            - **Voicemail (preview)**

        :::image type="content" source="media/overflow-condition-action-voice-queue.png" alt-text="A screenshot of the condition and action pairs configured for the voice queue.":::

1. To remove the overflow setting, delete the condition and action pairs that you've configured for the queue.

### Configure overflow override

If you have configured overflow action to be end call or keep waiting in queue, and you want priority customers to be handled differently, you can configure override condition and action pairs for the queues to which your priority customers will be directed. You can configure override in the route-to-queue rules at the workstream level.

1. In Customer Service admin center, go to the required workstream, and select the route-to-queue rule in which the queue is configured.

1. In the **Route to queues** area, select the **More commands** ellipses next to **Add queue**, and select **Add queue overflow override**.

1. Perform the steps to add condition and action pairs and set the action for each condition that you define as listed in the **Configure overflow actions** section.

## Define operation hours

Perform the steps in [Create and manage operating hours](create-operating-hours.md) to configure operating hours for the queues.

If operation hours are not configured, the queues will be available round the clock.

## View diagnostics for overflow

Whenever a work item is handled by the overflow action instead of being assigned to an agent, you can view its status in the **Route to queue** stage of the diagnostic page.

:::image type="content" source="media/overflow-diagnostics.png" alt-text="View the diagnostic status of the overflow action triggered for the work item.":::

## Configuration considerations

Some configuration considerations are discussed in this section.

### Edit automated messages for end call overflow action

If you have set **End call** as an overflow action for the voice queue, an automated message will be delivered to the customer to notify them that the conversation will end. You can edit the message that the customer will hear.

1. In the Customer Service admin center site map, go to **Customer settings** in **Customer support**, and select **Automated messages**.
2. Find the automated message for the **Voice** channel where the message trigger is "Voice call ended".
3. Edit the value in the **Localized text** column as needed.

> [!div class="mx-imgBorder"]
> ![Out-of-the-box automated messages.](./media/voice-channel-overflow-end-call-message.png "Out-of-the-box automated messages.")

More information: [Customize automated messages](configure-automated-message.md#customize-automated-messages-at-the-channel-level)

### See also

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
