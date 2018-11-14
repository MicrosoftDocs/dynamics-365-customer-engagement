---
title: "Understand how�routing and work distribution works"
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

-   As an administrator, configure the following in the omni-channel system.

| Entity                     | Value                                              |
|----------------------------|----------------------------------------------------|
| Work stream and capacity   | Chat from Support Portal with capacity of 50 units |
| Engagement Channel         | Chat                                               |
| Work distribution mode     | Push                                               |
| Omni-channel routing rules | -   If category = Billing, assign to Billing Queue 
                                                      
  -   If category = Product, assign to Product Queue  |
| Omni-channel queues        | -   Billing Queue = Members: Gilda, Bert           
                                                      
  -   Product Queue = Members: Jill, Shana            |
| Users and user profiles    | Agents - Gilda, Bert, Jill, Shana                  |
| Presence status            | Available or Busy                                  |

-   All incoming work items are marked with a unique work stream name and inherit the properties defined in that work stream during runtime evaluation.

    In the scenario, if a chat request comes with a work stream name **Chat from Support Portal** associated with it**,** it will inherit the properties of the defined work stream.

-   Routing and work distribution mechanism comes in. It is a two-step process:

    -   The routing rule evaluates the incoming work item and decides on the destination as an *Omni-channel queue.*

**Note**: Incoming work item comes with contextual data (a combination of context variables and related entity records). Routing rules are written on these context variables.

So, in the above property definition, *Category* is a context variable and if the incoming work item has category*Billing* then the work item is routed to*Billing Queue* in real-time.

-   Once the work item reaches the omni-channel queue, work distribution rules come in and the work item is allocated to one of the agents.

The work item is assigned to the agent who satisfies the following conditions:

So, in the above property definition,

-   Gilda and Bert are members of the *Billing Queue.*

-   Gilda and Bert are associated with **Chat from Support Portal** work stream.

-   But Bert is available with required capacity and Gilda is Away.

 ![MarkdownConversionFile_Omni channel Engagement Hub Guide image15](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image15.PNG)  

    Hence, the work item gets assigned to Bert.

<!-- -->

-   There are more rules that play a part in the work item assignment, like:

    - **Agent Affinity**: If the work item is coming for re-assignment after some follow-ups, it is allocated to the agent(s) who have worked on it in the past.

    -   Agent with the most available capacity will be allocated the work item first.

    -   If there are more than one agent who qualify for the work item and have the same capacity, work item will be allocated to the agent who has been idle at that capacity for the maximum time.

So, in the above scenario,

-   Both Gilda and Bert qualify for the incoming work item because:

<!-- -->

-   They are the members of the *Billing Queue.*

-   They are associated with the work stream **Chat from Support Portal.**

-   This time they both have their presence status as **Available.**

**Note**: Agent affinity doesn’t apply in this case as the work item is coming for the first time.

-   Assuming that **X** is Gilda’s available capacity and **Y** is Bert’s available capacity, the work item is assigned as per the following evaluation:

|                      | X&gt;Y                            | Y&gt;X                            | X=Y                                                                                       |
|----------------------|-----------------------------------|-----------------------------------|-------------------------------------------------------------------------------------------|
| Gilda’s Capacity (X) | 100 units                         | 50 units                          | 50 units (for 1 hour)                                                                     |
| Bert’s Capacity (Y)  | 50 units                          | 100 units                         | 50 units (for 2 hours)                                                                    |
| Condition Evaluation | Gilda has more capacity than Bert | Bert has more capacity than Gilda | Bert and Gilda both have equal capacity i.e. 50 units                                     
                                                                                               
    But Bert is available for 2 hours and Gilda is available for 1 hour                        |
| Result               | Work Item gets assigned to Gilda  | Work Item gets assigned to Bert   | Work Item gets assigned to Bert because he has been idle for a longer duration than Gilda |

## Automated work distribution

If a work item remains in an omni-channel queue with any agent, it becomes available for automated work distribution:

-   Work items with priority 1 queues are distributed before priority 2 queues. All items that belong to an omni channel queue are of equal priority.

-   Work items are queued according to their age.

-   As soon as the agents become available and they have enough capacity to take up the work, they start getting the items allocated to them.

-   Agents work on the work item and take either of the following actions:

<!-- -->

-   Transfer the work item to another queue or agent. This happens often because customers may select incorrect IVR options or Pre-chat questions.

-   Move the item to Waiting for Customer Input or other internal tasks that are not actionable by the agent. Work item will move from Waiting state to Open state when the customer responds.

-   Resolve the work item in consideration and move it to Closed state.

<span id="_Toc517185587" class="anchor"><span id="_Toc517358954" class="anchor"><span id="_Toc517199717" class="anchor"><span id="_Toc519606079" class="anchor"></span></span></span></span>

## Adjusting the capacity of the agent based on a work item allocation

When the agent accepts the work item, the capacity reduces. Also:

-   The work item is added to the agent’s My Items list.

-   Agent’s presence status may change to Busy/DND depending on total capacity utilized.

-   Utilized capacity increases.

-   Available capacity decreases.

## Adjusting the capacity of the agent based on closure of active work items

When the agent finishes working on the work item, the capacity should be added back to agent’s availability. Also:

-   The work item is removed from the agent’s My Items list.

-   Agent’s presence status may change to Busy/Available depending on total capacity utilized.

-   Utilized capacity decreases. Available capacity increases to the extent of free capacity.

If there are work items waiting in the queue that can be assigned to the agent, they are allocated as soon as the agent becomes available.

