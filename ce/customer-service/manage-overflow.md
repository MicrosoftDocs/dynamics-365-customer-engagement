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

When a new work item gets routed with unified routing, the system tries to find the best-suited agent to work on the work item. Sometimes all the eligible agents are tied up at maximum capacity. In scenarios like these, if businesses want to reroute unassigned work items using some relaxed criteria, you can configure overflow conditions. You can also send notifications to the customer about their waiting state or when their query will be resolved. You can configure handling of work items that can come in the form of calls, conversations, cases, emails, or tasks.

With overflow management, you can address the following scenarios:

- When an incoming work item exceeds a defined number of conversations or calls that can wait in the queue
- Calls and conversations are received during the after hours of the call center operations
- The wait time is very high for customers and you want to reduce it

When both the conditions are defined, when one of them is met, the overflow actions configured at the workstream level will be run.

## Prerequisites

For call overflow to work correctly, the following prerequisites must be met:

- Agents should be configured for the voice queues.
- To transfer calls to an external phone number, phone numbers should be available.

## Configure overflow conditions for

**To configure overflow**

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
       

    1. In the site map, select **Queues** in **Customer support**.
    
    2. On the **Queues** page, select **Manage** for **Advanced queues**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Queues** in **General settings**.

1. Select the voice queue for which you want to configure call overflow.

1. In **Overflow conditions**, select **Set overflow conditions**. The **Overflow conditions** panel appears.

1. In **Work item limit**, enter a number to denote the maximum number of calls that can be in waiting before overflow is reached. For example, if you enter 5 as the value, then five calls should be waiting in the queue for the sixth call to trigger call overflow.

1. If an operating hour record is configured for the queue, the toggle for **Out of operation hours**, is set to **On** by default and can't be edited. The call overflow is triggered when a call reaches the queue during the after hours of the call center operations. If no operating hour record is configured, the toggle will be set to **Off** and in the disabled mode. In such a case, the call center is considered to be available round the clock.

To remove the overflow setting, you'll need to set the work item limit to zero and remove the operating hour record on the queue if configured.

## Define operation hours

Perform the steps in [Create and manage operating hours](create-operating-hours.md) to configure operating hours for the voice queues.

If operation hours are not configured, the queues will be available round the clock.

## Configure overflow action in the voice workstream

Configure the action to be performed when call overflow is triggered. The following options are available to handle overflow actions for a voice workstream:

 -	**Default**: The work item remains in the queue to be routed to the next available agent.
 -	**End call**: The call ends if no agent is available to take the call. For example, an operating hour is configured, and the overflow action was triggered on account of it.
 -	**Transfer to external number**: The call is routed to a specified number if the work item must be handled on priority.

More information: [Configure routing rules for the voice workstream](voice-channel-route-queues.md#configure-routing-rules-for-the-voice-workstream)

## Configuration considerations

Some configuration considerations are discussed in this section.

### Edit automated messages for end call overflow action

If you have set **End the call** as an overflow action, an automated message will be delivered to the customer to notify them that the conversation will end. You can edit the message that the customer will hear.

**To edit the automated message**

1. In the Omnichannel admin center site map, go to **Customer settings** in **Advanced settings**, and select **Automated messages**.
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
