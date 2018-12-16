---
title: "Work with queues in Omni-channel Engagement Hub"
description: 
keywords: ""
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

Omni-channel queues are used to collect conversations or customer queries and distribute them to different groups of agents or teams. You can achieve optimum distribution in the many ways, like:

- Creating multiple queues for same issue type. For example, for investment issue, you can create queues for experienced agents and new agents, so that specific customer queries are directed to experienced agents and generic or simpler queries are directed to new agents.

- Queues created for different issue types. For example, you can create separate queues for different issue types like billing, investments etc.

    ![omni-channel queues](../media/oc-queues.png) 

Given below are some key characteristics of omni-channel queues:

-   You can assign priority to queues. In that case, all conversations in that queue will carry the same priority and will be serviced accordingly.

-   All omni-channel queues are private. Only the members of the queues can view and work on the respective conversations.

-   A queue can have agents having different work streams assigned to them.

-   Supervisors can view the work assignment and track work progress in the Queues Dashboard.

-   For each org, there is a default omni-channel queue. An admin user cannot delete the default queue. All omni-channel users are by default members of this queue. Hence, the membership of this queue cannot be altered. Default queue carries the highest priority.

     **Note**: When no queues or routing rules are defined, all the conversations are collected in the Default queue. All omni-channel users are the members of the Default queue.

Omni-channel queues provide flexibility for the organizations to define queues as per their business priorities. Both single channel as well as blended agent queues are supported. Hence, omni-channel queues can be used for:

-   Collecting conversations for a product or an issue type originating from multiple channels

-   Distributing conversation originating from a single channel into different issue types based on customer inputs like pre-chat answers or IVR responses. Also, organizations can model Customer Type as context variables and chose to route the conversations to different queues.

## Create a new omni-channel queue
Follow these steps to create a new omni-channel queue:

1. In the Omni-channel site map, select **Work Distribution Management > Omni-channel Queues**. </br>
The **Active Omni-channel Queue** view is displayed. 

2.	Select **New** in the command bar to create a new omni-channel queue.

3.	In the **General Information** section of the **Summary** tab, provide the following information:
    - **Name**. Name of the queue.
    - **Priority**. Assign a priority to determine how quickly a conversation is picked from the queue.

4.	Select **Save** to save the queue. </br>
The **Users (Agents)** section is displayed for the new queue.

5.	In the **Users (Agents)** section, add an existing agent to the queue by selecting **Add Existing User**.  </br>

    Select the agents you want to add from the **Lookup Records** flyout menu and select **Add**. 
    You can change the view and select users from other views by selecting **Change View**.

All active queues can be seen in the **Omni-channel Queues** view. 

To activate a queue so that the conversations can be routed to it, select a queue record from the **Omni-channel Queues** view and select **Activate** from the command bar.

You can also deactivate a queue if you do not want conversations to be routed to it. 



