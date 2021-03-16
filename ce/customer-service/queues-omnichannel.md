---
title: Work with queues in Omnichannel for Customer Service | MicrosoftDocs
description: See how you can create and manage queues in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Work with queues in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

In Omnichannel for Customer Service, queues are used for collecting and distributing workload among agents. Workload includes conversations, such as Chat or SMS. Agents are added as members to the queues and the workload is distributed among these agents.

## How conversations are routed to queues

Queues in Omnichannel for Customer Service are proxies for skills or domains. You can create separate queues for each line of business, such as billing, investment, and products. When a customer query is raised for any of the areas, it is routed to the corresponding designated queue. You can also set up customer support availability matrix by using a combination of queues, operating hour schedules, and routing rules.

In an enterprise scenario, you can have various supervisors to handle different issues, and therefore, different types of queues are required to handle the various scenarios. Accordingly, routing rules are set up based on the complexity of issues that need to be handled.

To simplify the routing experience for administrators and supervisors, queues are categorised based on the channel types as follows:

- **Messaging:** To route all messaging conversations pertaining to the Live Chat, SMS, and social channels.
- **Entity records:** To route cases pertaining to entity records.

The queue types help ensure issues to be routed correctly and help avoid cross-queue assignments. When you configure work streams and routing rule items, the queues that will be available for selection will be based on the channel type for the work stream. For example, for routing rules for a Live Chat work stream, only messaging type queues will be shown for selection. Similarly, in a conversation transfer scenario, you can transfer a chat conversation only to a messaging queue and a case to an entity queue.

You can assign priority to queues. A lower value indicates higher priority and a higher value indicates lower priority. All conversations in a queue take the priority that is defined for the queue; higher priority conversations are allocated first. For example, if two chat conversations are waiting in two queues that have priority defined as 1 and 2 respectively, the chat conversation with priority value 1 will be allocated to an agent first.

## Create a queue for the messaging channel in Omnichannel admin center

In this section, we cover information on how to create a queue for the messaging channel.

1. In the left pane, select **Queues**, and then do the following steps:

    1. On the **Queues** page, select **New**.
    2. On the Create a queue dialog box, enter the following:
       - **Name:** A name for the queue.
       - **Type:** Select Messaging.
       - **Group number:** A number to organize the queue. 
    3. Select **Create**. The queue that you created is displayed.
        > ![Queue in Omnichannel admin center](../customer-service/media/queue-summary-ur.png "Queue in Omnichannel admin center")

2. Select **Add users**, and in the flyout menu, select the users that should be part of the queue, and select **Add**. The users are added to the queue.
3. In **Assignment method**, you can use the default option highest capacity. You can select **See more** to change the assignment method to round robin or create a custom assignment method. For more information about custom assignment method, see [Create custom assignment method]()


## Create a queue in Omnichannel Administration

**To Saurabh: I do not see these default queues in Omnicahnnel admin center app**

Out of the box, the following default queues are available in Omnichannel for Customer Service:

- **Default entity queue:** The queue that is available for routing entity records.
- **Default messaging queue:** The queue that is available for routing all messaging conversations pertaining to the Live Chat, SMS, and social channels.

The default queues can't be edited or deleted. All Omnichannel for Customer Service users are members of the default queues. Therefore, the membership of these default queues also can't be changed.

  > [!NOTE]
  > When no custom queues or routing rules are defined, all conversations are directed to one of the out-of-the-box default queue based on the work item type.

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
    > ![omnichannel queue](media/oc-create-queue.png)

5. In the **Users (Agents)** section, select **Add Existing User** to add existing agents to the queue.
6. On the **Lookup Records** flyout menu, select the agents to add, and then select **Add**.

    > [!TIP]
    > To select users from other views, you can change the view by selecting **Change View**.

### See also

[Understand and create workstreams](work-streams-introduction.md)  
[Understand unified routing and work distribution](unified-routing-work-distribution.md)  
[Create operating hours](create-operating-hours.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]