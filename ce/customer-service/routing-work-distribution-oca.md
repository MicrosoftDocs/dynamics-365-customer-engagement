---
title: "Routing and assignment in Omnichannel Administration | MicrosoftDocs"
description: "Learn about how routing and work assignment to agents can be configured in the Omnichannel Administration app."
ms.date: 05/12/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Routing and assignment in Omnichannel Administration

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> - Support for the Omnichannel Administration app ended on April 30, 2022. The app will be removed in July 2023. We recommend that you use the Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Omnichannel Administration app is deprecated and will be removed in July 2023](../customer-service/deprecations-customer-service.md#omnichannel-administration-app-is-deprecated-and-will-be-removed-in-july-2023).
> - We recommend that you upgrade to the latest version of Omnichannel for Customer Service and use unified routing. For more information, see [Overview of unified routing](overview-unified-routing.md). With the upgrade, you can also use the Customer Service admin center app. For more information, see [Customer Service admin center](cs-admin-center.md).

Routing and work assignment ensures that conversations from all the channels are routed to agents efficiently.

Advantages of routing and work assignment are as follows:

- Automate work assignments across channels.
- Set up work assignments for the best available agents based on their capacity and presence.
- Analyze and manage agent productivity across channels.

Routing and work assignment is a two-step process:

1. Routing dispatches conversations into the right queues.
2. Work assignment allocates the conversations in a queue to agents in real time, based on capacity and presence.

## Overview of routing system

A customer initiates a conversation from the portal, and the conversation reaches the Omnichannel system. Now, based on the routing rules condition defined in the routing system, it starts routing the conversation to the appropriate queues.

The routing rules condition is based on the channel, CRM, and customer context that you, as an administrator, define in the Omnichannel Administration app.

When the conversation reaches to the queues, the work assignment system assigns the conversation based on triggers that are explained in the following sections.

## Overview of work assignment system

> [!IMPORTANT]
>
> If you've upgraded your Omnichannel for Customer Service environment to 2021 release wave 1, your queues will start using unified routing services for assignment. By default, all existing queues will use the "highest capacity" assignment method for work assignment. You can change the assignment method to round robin or a custom assignment method according to your need. More information: [Set up assignment methods in Customer Service](assignment-methods.md).

The work assignment system assigns the conversation (work item) to an agent based on the following triggers:

- Work item available trigger
- Agent available trigger

### Work item available trigger

When a conversation is present in a queue, the work assignment system searches for the best available agent based on the capacity and presence if there are no other conversations present in the queue.

If there are other conversations present in the queues, then the conversation will be added to the end of the queue and will be assigned to the agents after other conversations are assigned.

### Agent available trigger

The work assignment system assigns one of the existing conversations that is in the queues when an agent is available.

An agent is available in the following scenarios:

- When an agent signs in to the Omnichannel for Customer Service app.
- When an agent presence status changes from one state to another, such as **Away** to **Available**, **Away** to **Busy**, and  **Away** to **DND**. An agent is also available depending on the allowed presence that is configured for the work stream.
- When an agent capacity changes due to the closure of a conversation or assignment of a conversation.
- The agent affinity is set to yes for a work stream.

Whenever agents are available, the work assignment system always retrieves the oldest conversations (longer duration) that is present in the highest priority queue and assigns the conversation to the agent who satisfies the capacity condition.

## Scenario walk-through of routing and work assignment

The following section outlines a scenario to understand unified routing and work assignment and how conversations are assigned to agents.

A customer initiates a conversation (chat) regarding **Billing**. Now, routing and work assignment help route the conversation to the **Billing** queue, and assign the conversation to an agent who is a member of the queue with the required presence and capacity. This is shown in the following illustration.

> [!div class=mx-imgBorder]
> ![Routing and work assignment scenario.](media/oc-scenario.png)

Let us see the steps involved in the scenario walk-through.

- When a chat conversation originates from the customer, the system identifies the channel, and the routing and work assignment configuration details are applied. These configuration details are defined in the workstreams. Learn more, see [Understand and create work streams](create-workstreams-oca.md).

    In this walk-through, the system identifies the work stream as **Product & Billing live chat** and applies the configuration details of the  work stream to the incoming conversation. In this work-stream, the conversation requires a capacity of **50 units**. This implies that when the system assigns this conversation to an agent, the system blocks 50 units of agent’s capacity.

- Next, the routing and work assignment logic starts. With the help of context variables, **Routing rules** identify that the conversation belongs to the **Billing** queue, and the system routes to the **Billing** queue.

- As the conversation reaches the Billing queue, the system  allocates the conversation to one of the agents of the Billing queue, who satisfy the following criteria:

    - Capacity is **50 units** or more.
    - Presence status is **Available**.

As **Bert** has the required capacity and presence, the system  assigns the conversation to **Bert**. After Bert starts working on the conversation,  the presence changes to **Busy** and the remaining capacity is updated to **30 units**.

### Adjusting an agent's capacity based on conversation allocation

Agent capacity is specified by the administrator in the User settings. See [Manage users](users-user-profiles.md) to learn how to set agent capacity.
An agent's capacity is adjusted by the system when a conversation is allocated, and the following actions occur:

- The conversation is added to the agent's **My Items** list.
- The agent's presence status changes to **Busy** or **Busy DND**.
- The agent's utilized capacity increases.
- The agent's available capacity decreases.

### Adjusting an agent's capacity based on closure of allocated conversation

When an agent has finished working on a conversation, the system adds the capacity back to the agent's availability, and the following actions occur:

- The conversation is removed from the agent's **My Items** list.
- The agent's presence status changes to **Available**.
- The agent's utilized capacity decreases.
- The agent's available capacity increases to the extent of free capacity.

If conversations are waiting to be assigned, they are allocated as soon as the agent becomes available.

To effectively route and distribute work to agents, admins can set up the following items in Omnichannel for Customer Service:

- [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md)
- [Manage users in Omnichannel for Customer Service](users-user-profiles.md)
- [Understand and create work streams](create-workstreams-oca.md)
- [Configure a chat channel](set-up-chat-widget.md)
- [Configure an SMS channel](configure-sms-channel.md)
- [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)
- [Automatically identify customers using pre-chat responses](record-identification-rule.md)
- [Create and manage routing rules](routing-rules.md)
- [Configure and manage custom presence](presence-custom-presence.md)

### See also

[Omnichannel for Customer Service for administrators](omnichannel-administrator.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
