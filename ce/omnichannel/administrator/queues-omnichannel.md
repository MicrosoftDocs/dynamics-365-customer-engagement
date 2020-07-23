---
title: Work with queues in Omnichannel for Customer Service | MicrosoftDocs
description: See how you can create and manage queues in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Work with queues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Introduction

Omnichannel queues are used to collect and distribute workload among agents. Workload includes conversations, such as Chat or SMS. Agents are added as queue members to the queues and the workload is distributed among these agents.

Omnichannel queues are proxies for skills or domains. For example, you can create separate queues for billing issues, investment issues, products, and so on. When a customer query comes for these issue types, it is routed to its designated queue. You can also set up customer support availability matrix by using a combination of queues, operating hour schedules, and routing rules.
    
> [!div class=mx-imgBorder]
> ![Omnichannel queues](../media/oc-queues.png)

You can assign priority to queues. All conversations in a queue take the priority of the queue and higher priority conversations are allocated first. For example, if there are two chat conversations coming from two queues with priorities assigned as Priority 1 and Priority 2 respectively, chat conversation with Priority 1 will be allocated to an agent first.

## Default queue

There is a default Omnichannel queue for each organization. Admins can't delete the default queue. By default, all Omnichannel users are members of the default queue. Therefore, the membership of this queue can't be changed.

  > [!NOTE]
  > When no queues or routing rules are defined, all conversations are directed to the **Default** queue.

## Create a queue

Follow these steps to create an Omnichannel queue.

1. In the Omnichannel Administration site map, go to **Queues & Users** > **Queues**. The **Omnichannel queues** view is displayed.
2. On the command bar, select **New**.
3. On the **Summary** tab, in the **General Information** section, provide the following information:

    - **Name**: Enter a name for the queue.
    - **Priority**: Assign a priority to define how quickly a conversation should be picked from the queue.
    - **Owner:** Search and select an owner for the queue if you do not want to use the default owner.
    - **Operating Hours:** Search and select an operating hour schedule that you want to specify for the queue.

4. Select **Save**. The **Users (Agents)** section is displayed.

    > [!div class=mx-imgBorder]
    > ![omnichannel queue](../media/oc-create-new-queue.PNG)

5. In the **Users (Agents)** section, select **Add Existing User** to add existing agents to the queue.
6. On the **Lookup Records** flyout menu, select the agents to add, and then select **Add**.

    > [!TIP]
    > To select users from other views, you can change the view by selecting **Change View**.

### See also

[Understand and create work streams](work-streams-introduction.md)  
[Understand unified routing and work distribution](unified-routing-work-distribution.md)  
[Create operating hours](create-operating-hours.md)  
