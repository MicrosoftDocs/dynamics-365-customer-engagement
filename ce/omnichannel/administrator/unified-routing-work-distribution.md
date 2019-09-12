---
title: Understand unified routing and work distribution | MicrosoftDocs
description: Understand about unified routing and work distribution in Omnichannel for Customer Service
keywords: Omnichannel for Customer Service; Unified routing and work distribution
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: dcb07f11-106d-4368-87e9-015da0999f06
ms.custom: 
---

# Understand unified routing and work distribution

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Unified routing and work distribution ensures that conversations from all the channels are routed to agents efficiently.

Advantages of unified routing and work distribution are as follows:

- Automate work assignment across channels.
- Set up work assignment to best available agents based on their capacity and presence.
- Analyze  and manage agents productivity across channels.

Unified routing and work distribution is a two-step process:

1. Routing dispatches conversations into the right Omnichannel queues.
2. Work distribution allocates the conversations in a queue to agents in real time, based on capacity and presence.

## Scenario walk-through of unified routing and work distribution 

Refer the following scenario to understand how unified routing and work distribution works and how conversations are assigned to agents.

A customer initiates a conversation (chat) regarding **Billing**. Now, unified routing and work distribution help route the conversation to the **Billing** queue, and assign the conversation to an agent who is a member of the queue with the required presence and capacity. This is shown in the following illustration.

> [!div class=mx-imgBorder]
> ![Routing and work distribution scenario](../media/oc-scenario.png)

Let us see the steps involved in the scenario walk-through. 

- When a chat conversation originates from the customer, the system identifies the channel, and the routing and work distribution configuration details are applied. These configuration details are defined in the workstreams. Learn more, see [Understand and create work streams](../administrator/work-streams-introduction.md).

    In this walk-through, the system identifies the work stream as **Product & Billing live chat** and applies the configuration details of the  work stream to the incoming conversation. In this work-stream, the conversation requires a capacity of **50 units**. This implies that when the system assigns this conversation to an agent, the system blocks 50 units of agent’s capacity.

- Next, the routing and work distribution logic starts. With the help of context variables, **Routing rules** identify that the conversation belongs to the **Billing** queue, and the system routes to the **Billing** queue. 

- As the conversation reaches the Billing queue, the system  allocates the conversation to one of the agents of the Billing queue, who satisfy the following criteria:

    - Capacity is **50 units** or more.
    - Presence status is **Available**.

As **Bert** has the required capacity and presence, the system  assigns the conversation to **Bert**. Once Bert starts working on the conversation,  the presence changes to **Busy** and the remaining capacity is updated to **30 units**.

### Adjusting an agent's capacity based on conversation allocation

An agent's capacity is adjusted when a conversation is allocated. Here are the actions that occur:

- The conversation is added to the agent's **My Items** list.
- The agent's presence status changes to **Busy** or **Busy DND**.
- The agent's utilized capacity increases.
- The agent's available capacity decreases.

### Adjusting an agent's capacity based on closure of allocated conversation

When an agent has finished working on a conversation, the capacity should be added back to the agent's availability. Here are the actions that occur:

- The conversation is removed from the agent's **My Items** list.
- The agent's presence status changes to **Available**.
- The agent's utilized capacity decreases.
- The agent's available capacity increases to the extent of free capacity.

If conversations are waiting to be assigned, they are allocated as soon as the agent becomes available.

To effectively route and distribute work to agents, admins can set up the following items in Omnichannel for Customer Service:

- [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md)
- [Manage users in Omnichannel for Customer Service](users-user-profiles.md)
- [Understand and create work streams](work-streams-introduction.md)
- [Configure a chat channel](set-up-chat-widget.md)
- [Configure an SMS channel](configure-sms-channel.md)
- [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)
- [Automatically identify customers using pre-chat responses](record-identification-rule.md)
- [Create and manage routing rules](routing-rules.md)
- [Configure and manage custom presence](presence-custom-presence.md)

###  See also

[Omnichannel for Customer Service for administrators](omnichannel-administrator.md)


