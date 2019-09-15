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

## Overview of routing system

A customer initiates a conversation from the portal, and the conversation reaches the Omnichannel system. Now, based on the routing rules condition defined in the routing system, it starts routing the conversation to the appropriate queues. 

The routing rules condition is based on the channel, CRM, and customer context that you, as an administrator, define in the Omnichannel Administration app.

When the conversation reaches to the queues, the work distribution system distributes the conversation based on certain triggers. To learn more, see [Overview of work distribution system](unified-routing-work-distribution.md#overview-of-work-distribution-system)

## Overview of work distribution system

The work distribution system distributes/assigns the conversation (work item) to an agent based on the following triggers:

- Work item available trigger
- Agent available trigger

> [!div class=mx-imgBorder]
> ![Routing and work distribution scenario](../media/unified-routing-work-distribution.png)

### Work item available trigger

When a conversation is present in a queue, the work distribution system takes a course of action based on the following scenarios:

    | Priority | Scenario | Work distribution system action |
    |---------------|-----------------|---------------------------------------|
    | 1 | No conversation in waiting in the queue | Assigns the conversation to an agent based on the capacity and presence status. |
    | 2 | No agent is available | Moves the conversation to the waiting state. |
    | 3 | One or more agent is available | Assigns the conversation agent with the highest available capacity. |
    | 4 | One or more agent is available with same capacity | Assigns the conversation to an agent has a lesser number of active sessions for the current workstream. |
    | 5 | One or more agent is available with same capacity and number of active sessions | Assigns the conversation to an agent who is waiting for a longer duration for a conversation. |
    | 6 | One or more agent is available | Assigns the conversation to an agent who disconnected this conversation. |
    | 7 | One or more agent is available | Assigns the conversation to an agent who rejected, transferred, or timed out the conversation. |

Also, if the Presence status rejects the conversation assignment while blocking the capacity, the work distribution system tries to assign the conversation to another agent.

### Agent available trigger

The Presence status entity in Omnichannel sends the agent available trigger whenever there is a change in the presence status of an agent. The presence status can change in the following scenarios:

 - When an agent signs in to the Omnichannel for Customer Service app.
 - When an agent presence status changes from one state to another such as **Away** to **Available**, **Away** to **Busy**, and  **Away** to **DND**.
 - When an agent capacity changes due to the closure of a conversation or assignment of a conversation.

After the Presence status sends the agent available trigger to the work distribution system, it searches for the best available agent to assign the conversation.

To assign a conversation, the work distribution system retrieves conversations with a query from the queues to which user (agent) is added. Theses conversations are retrieved based on the defined work stream capacity and queue priority. 

   - If the retrieved conversations are less than ten, then the work distribution system considers all the conversations as a high priority and searches for agents to assign the conversations.
   - If retrieved conversations are more than ten, then the work distribution system considers the conversation in the **Waiting** state longer duration with priority and searches for agents to agents to assign the conversation. 

> [!Note]
> If an agent has rejected, transferred, timed out a conversation, then those conversations are filtered while assigning to the agent.

For the agent available trigger, the work distribution system always retrieves the oldest conversations (longer duration) in the **Waiting** state and assigns the conversation to an agent by blocking the capacity of the agent. When the assignment is successful, the work distribution system sends a message (agent assigned) to the routing system. 

If the assignment fails, then the work distribution system moves the conversation to the **Waiting** state.

If the conversation times out, then the work distribution system tries five times to block the capacity of the agent. If it isn't successful, then it moves the conversation to the **Waiting** state.

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


