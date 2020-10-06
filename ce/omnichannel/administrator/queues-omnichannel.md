---
title: Work with queues in Omnichannel for Customer Service | MicrosoftDocs
description: See how you can create and manage queues in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: 
  "dynamics-365-customerservice"
ms.topic: article
---

# Work with queues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Introduction

Omnichannel queues are used to collect and distribute workload among agents. Workload includes conversations, such as Chat or SMS. Agents are added as members to the queues and the workload is distributed among these agents.

## How conversations are routed to queues

Queues in Omnichannel for Customer Service are proxies for skills or domains. You can create separate queues for each line of business, such as billing, investment, and products. When a customer query is raised for any of the areas, it is routed to the corresponding designated queue. You can also set up customer support availability matrix by using a combination of queues, operating hour schedules, and routing rules.

To simplify the routing experience for administrators, queues are categorised into the following types:

- **Messaging:** To route conversations pertaining to the live chat and social channels.
- **Entity records:** To route cases pertaining to entity records.

When you configure work streams and routing rule items, the queues that will be available for selection will be based on the applicable queue type. For example, if you are configuring a work stream for the WhatsApp channel, the queues that will be available for selection will be those that are of the messaging type. Similarly, in a conversation transfer scenario, you can transfer a chat conversation only to a messaging queue and a case to an entity queue.

You can assign priority to queues. All conversations in a queue take the priority that is defined for the queue; higher priority conversations are allocated first. For example, if there are two chat conversations coming from two queues with priorities assigned as Priority 1 and Priority 2 respectively, chat conversation with Priority 1 will be allocated to an agent first.

  > [!IMPORTANT]
  > In an upgraded environment, the existing queues will be defaulted to the messaging type. Therefore, to seamlessly handle entity conversations in a transfer scenario, make sure that you have created queues of entity records type.

## Default queues

Out of the box, the following default queues are available in Omnichannel for Customer Service:

- **Default entity queue:** The queue that is available for routing entity records.
- **Default messaging queue:** The queue that is available for routing conversations pertaining to the Live Chat and social channels.

The default queues can't be edited or deleted. All Omnichannel for Customer Service users are members of the default queues. Therefore, the membership of these default queues also can't be changed.

  > [!NOTE]
  > When no custom queues or routing rules are defined, all conversations are directed to one of the out-of-the-box default queues.

## Create a queue

Perform the following steps to create a queue in Omnichannel for Customer Service:

1. In the Omnichannel Administration site map, go to **Queues & Users** > **Queues**. The **Omnichannel queues** view is displayed.
2. On the command bar, select **New**.
3. On the **Summary** tab, in the **General Information** section, provide the following information:

    - **Name**: Enter a name for the queue.
    - **Priority**: Assign a priority to define how quickly a conversation should be picked from the queue.
    - **Queue type:** Select either **Messaging** or **Entity**. You can't edit the queue type after you save the queue.
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
