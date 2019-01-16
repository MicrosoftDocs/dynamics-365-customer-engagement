---
title: Work with queues in Omni-channel Engagement Hub
description: See how you can create and manage queues in Omni-channel Engagement Hub
keywords: Queues; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 8c1b6127-a00c-4783-8740-52bd63e52eb1
ms.custom: 
---

# Work with queues in Omni-channel Engagement Hub

Omni-channel queues are used to collect conversations or customer queries, and distribute them to different groups of agents or teams. You can achieve optimum distribution in the many ways. Here are some examples:

- Create multiple queues for the same issue type. For example, for investment issues, you can create separate queues for experienced agents and new agents. Specific customer queries can then be directed to experienced agents, and generic or simpler queries can be directed to new agents.
- Create queues for different issue types. For example, you can create separate queues for billing issues, investment issues, and so on.

    ![Omni-channel queues](../media/oc-queues.png)

Here are some of the main characteristics of omni-channel queues:

- You can assign priority to queues. All conversations in the same queue then have the same priority and will be serviced accordingly.
- All omni-channel queues are private. Only the members of a queue can view and work on the conversations in that queue.
- Agents can have different work streams assigned to them in a queue.
- Supervisors can view the work assignments and track work progress on the **Queues** dashboard.
- There is a default omni-channel queue for each organization. Admin users can't delete the default queue. By default, all omni-channel users are members of this queue. Therefore, the membership of this queue can't be changed. The default queue has the highest priority.

    > [!NOTE]
    > When no queues or routing rules are defined, all conversations are collected in the default queue.

Omni-channel queues give organizations the flexibility to define queues that meet their business priorities. Both single-channel and blended agent queues are supported. Therefore, omni-channel queues can be used for these purposes:

- Collecting conversations that are for a specific product or issue type, but that originate from multiple channels.
- Distributing conversations that originate from a single channel to different issue types, based on customer inputs such as answers to a pre-chat survey or information that is gathered through interactive voice response (IVR). Organizations can also model **Customer Type** as context variables and route the conversations to different queues.

## Create a new omni-channel queue

Follow these steps to create a new omni-channel queue.

1. In the omni-channel site map, select **Work Distribution Management \> Omni-channel Queues**.

    The **Active Omni-channel Queue** view is shown.

2. On the command bar, select **New** to create an omni-channel queue.
3. On the **Summary** tab, in the **General Information** section, provide the following information:

    - **Name**: Enter a name for the queue.
    - **Priority**: Assign a priority to define how quickly a conversation should be picked from the queue.

4. Select **Save** to save the new queue.

    The **Users (Agents)** section is shown for the queue.

5. In the **Users (Agents)** section, select **Add Existing User** to add existing agents to the queue.
6. On the **Lookup Records** flyout menu, select the agents to add, and then select **Add**.

    > [!TIP]
    > To select users from other views, you can change the view by selecting **Change View**.

![omni-channel queue](../media/oc-new-queue.PNG)

You can view all active queues in the **Omni-channel Queues** view.

To activate a queue so that conversations can be routed to it, select the queue record in the **Omni-channel Queues** view, and then select **Activate** on the command bar.

You can also inactivate a queue if you don't want conversations to be routed to it.

### See also

[Create and manage work streams](work-streams.md)

[Understand unified routing and work distribution](unified-routing-work-distribution.md)