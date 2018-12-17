---
title: "Understand how routing and work distribution works"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: c0a1d153-e907-4bd7-bab6-09e270ed8833
ms.custom: 
---
# Understand how routing & work distribution works

The complete working of routing and work distribution mechanism can be explained with the help of the following scenario:

- As an administrator, configure the following in the omni-channel system.

| Entity                     | Value                                              |
|----------------------------|----------------------------------------------------|
| Work stream and capacity   | Chat from Support Portal with capacity of 50 units |
| Channel         | Chat                                               |
| Work distribution mode     | Push                                               |
| Omni-channel routing rules | -   If category = Billing, assign to Billing Queue </br>                                         -   If category = Product, assign to Product Queue  |
| Omni-channel queues        | -   Billing Queue = Members: Gilda, Bert </br> -   Product Queue = Members: Jill, Shana            |
| Users and user profiles    | Agents - Gilda, Bert, Jill, Shana                  |
| Presence status            | Available or Busy                                  |

- All incoming conversations are marked with a unique work stream name and inherit the properties defined in that work stream during runtime evaluation.

  In the scenario, if a chat request comes with a work stream name **Chat from Support Portal** associated with it, it will inherit the properties of the defined work stream.

- Now, routing and work distribution mechanism comes in. It is a two-step process:

    - The routing rule evaluates the incoming conversation and decides on the destination as an **Omni-channel queue**.

        **Note**: Incoming conversation comes with contextual data (a combination of context variables and related entity records). Routing rules are written on these context variables.

        So, in the above property definition, **Category** is a context variable and if the incoming conversation has category **Billing** then the conversation is routed to **Billing Queue** in real-time.

    - Once the conversation reaches the omni-channel queue, work distribution rules come in and the conversation is allocated to one of the agents.

      The conversation is assigned to the agent who satisfies the following conditions:

         ![scenario conditions](../../omni-channel-engagement-hub/media/oc-scenario-1.png)

        So, in the above property definition,

         - Both Gilda and Bert are members of the **Billing Queue**.

         - They both are associated with **Chat from Support Portal** work stream.

         - But Bert is available with required capacity and Gilda is Away.

        Hence, the conversation gets assigned to Bert.

        ![scenario-work](../../omni-channel-engagement-hub/media/oc-scenario-2.png)

-   There are more rules that play a part in the conversation assignment, like:

    - **Agent Affinity**. If the conversation is coming for re-assignment after some follow-ups, it is allocated to the agent(s) who have worked on it in the past.

    -   Agent with the most available capacity will be allocated the conversation first.

    -   If there are more than one agent who qualify for the conversation and have the same capacity, conversation will be allocated to the agent who has been idle at that capacity for the maximum time.

So, in the above scenario, both Gilda and Bert qualify for the incoming conversation because:

-   They are the members of the **Billing Queue**.

-   They are associated with the work stream **Chat from Support Portal.**

-   This time they both have their presence status as **Available.**

**Note**: Agent affinity doesn’t apply in this case as the conversation is coming for the first time.

-   Assuming that **X** is Gilda’s available capacity and **Y** is Bert’s available capacity, the conversation is assigned as per the following evaluation:

|                      | X&gt;Y                            | Y&gt;X                            | X=Y                                                                                       |
|----------------------|-----------------------------------|-----------------------------------|-------------------------------------------------------------------------------------------|
| Gilda’s Capacity (X) | 100 units                         | 50 units                          | 50 units (for 1 hour)                                                                     |
| Bert’s Capacity (Y)  | 50 units                          | 100 units                         | 50 units (for 2 hours)                                                                    |
| Condition Evaluation | Gilda has more capacity than Bert | Bert has more capacity than Gilda | Bert and Gilda both have equal capacity i.e. 50 units </br> But Bert is available for 2 hours and Gilda is available for 1 hour                        |
| **Result**               | Conversation gets assigned to Gilda  | Conversation gets assigned to Bert   | Conversation gets assigned to Bert because he has been idle for a longer duration than Gilda |

## Automated work distribution

If a conversation remains in an omni-channel queue with any agent, it becomes available for automated work distribution:

-   Conversations with priority 1 queues are distributed before priority 2 queues. All items that belong to an omni channel queue are of equal priority.

-   Conversations are queued according to their age.

-   As soon as the agents become available and they have enough capacity to take up the work, they start getting the items allocated to them.

-   Agents work on the conversation and take either of the following actions:


    -   Transfer the conversation to another queue or agent. This happens often because customers may select incorrect IVR options or Pre-chat questions.
    
    -   Move the item to Waiting for Customer Input or other internal tasks that are not actionable by the agent. conversation will move from Waiting state to Open state when the customer responds.
    
    -   Resolve the conversation in consideration and move it to Closed state.


### Adjusting the capacity of the agent based on a conversation allocation

When the agent accepts the conversation, the capacity reduces. Also:

-   The conversation is added to the agent’s My Items list.

-   Agent’s presence status may change to Busy/DND depending on total capacity utilized.

-   Utilized capacity increases.

-   Available capacity decreases.

### Adjusting the capacity of the agent based on closure of active conversations

When the agent finishes working on the conversation, the capacity should be added back to agent’s availability. Also:

-   The conversation is removed from the agent’s My Items list.

-   Agent’s presence status may change to Busy/Available depending on total capacity utilized.

-   Utilized capacity decreases. Available capacity increases to the extent of free capacity.

 - If there are conversations waiting in the queue that can be assigned to the agent, they are allocated as soon as the agent becomes available.

### See also

[Understand unified routing and work distribution](unified-routing-work-distribution.md)