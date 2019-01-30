---
title: Understand how unified routing and work distribution works | MicrosoftDocs
description: See this scenario to understand how unified routing and work distribution works
keywords: Unified routing and work distribution works
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: c0a1d153-e907-4bd7-bab6-09e270ed8833
ms.custom: 
---
# See how unified routing and work distribution works

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Refer the following scenario to understand how the routing and work distribution mechanism works.

## Step 1: Configure the basics

Configure the following entities in the Omni-channel Engagement Hub. Once configured, the app is ready to route and distribute conversations to agents.


|Entity   |Value   |
|---------|---------|
|Omni-channel users </br> *Name - Presence : Capacity*     |  Gilda – Busy : 70 units </br> Bert – Available : 80 units </br> Samuel – Available : 20 units</br> Jill – DND : 30 units</br> Shana – Busy : 20 units </br> John – DND : 80 units |
|Work stream      |  Live chat        |
|Capacity     |   50 units        |
|Work distribution mode     | Push       |
|Omni-channel routing rules      |  If *category* = **Billing**, assign to **Billing** queue </br>  If *category* = **Product**, assign to **Product** queue |
|  Omni-channel queues & members     |   Billing Queue = Gilda, Bert, Samuel </br> Product Queue = Jill, Shana, John |
|    |         |

## Step 2: Process the chat conversation

A chat conversation originates from the customer.

- As all incoming conversations are marked with a unique work stream name, the associated work stream is identified as **Live chat**.
- During run time evaluation, the properties of the work stream are imparted to the incoming chat. So, now the chat also carries a capacity of **50 units**. </br> This also implies that this chat, when assigned to an agent, will block 50 units of agent’s capacity.

## Step 3: Apply routing and work distribution rules

At this point, routing and work distribution mechanism kicks in.

 - With the help of context variables (*category* in the above table), **routing rules** determine that the chat belongs to the **Billing** queue. </br> </br> The chat is routed it to the **Billing** queue. 

- As the chat reaches the Billing queue, work distribution rules are applied, and the conversation is allocated to one of the agents of the Billing queue, who satisfy the following criteria:

    - Has the required capacity of **50 units**
    - Presence should be **Available**

In this case, **Bert** has the required capacity and presence so the chat is assigned to **Bert**. As Bert starts working on the chat conversation,  his presence changes to **Busy** and his capacity is updated to **30 units**.

> [!div class=mx-imgBorder]
> ![Routing and work distribution scenario](../../omni-channel-engagement-hub/media/oc-scenario.png)

## Automated work distribution

If a conversation remains in an omni-channel queue for longer, it becomes available for automated work distribution:

- All conversations that belong to an omni-channel queue take the priority of the queue. So, conversations that are a part of Priority-1 queues are distributed before conversations that are a part of Priority-2 queues. 
- Conversations are queued according to their age.
- As soon as agents become available and have enough capacity to take on the workload, the conversations are allocated to them. </br>
- Agents work on the conversations and take one of the following actions:
    - Transfer the conversation to another queue or agent. This action often occurs because customers selected incorrect interactive voice response (IVR) options or answered questions on the pre-chat survey incorrectly.
    - Move the conversation to **Waiting for Customer Input** or other internal tasks that the agent can't act on. When the customer responds, the conversation will be moved from the **Waiting** state to the **Open** state.
    - Resolve the conversation and move it to the **Closed** state.

### Adjusting an agent's capacity based on conversation allocation

When an agent accepts a conversation, his or her capacity is reduced. Here are the actions that occur:

- The conversation is added to the agent's **My Items** list.
- The agent's presence status might change to **Busy** or **Busy DND**, depending on the total capacity that is used.
- The agent's utilized capacity increases.
- The agent's available capacity decreases.

### Adjusting an agent's capacity based on closure of allocated conversation

When an agent has finished working on a conversation, the capacity should be added back to the agent's availability. Here are the actions that occur:

- The conversation is removed from the agent's **My Items** list.
- The agent's presence status might change to **Busy** or **Available**, depending on the total capacity that is used.
- The agent's utilized capacity decreases.
- The agent's available capacity increases to the extent of his or her free capacity.
- If any conversations that are waiting in the queue can be assigned to the agent, they are allocated as soon as the agent becomes available.

## See also

[Understand unified routing and work distribution](unified-routing-work-distribution.md)
