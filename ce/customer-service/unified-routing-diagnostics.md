---
title: Diagnostics for unified routing (Dynamics 365 Customer Service) | MicrosoftDocs
description: Learn how to set up routing diagnostics and understand the different stages of routing work items.
ms.date: 02/26/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Diagnostics for unified routing

## Introduction

Unified routing helps you assign a work item to the best suited agent or queue to handle it, based on the agent skills and the entities that are related to the work item. Routing diagnostics gives a granular view of each of the routed records to help you understand and self diagnose issues that occur in classification and assignment of work items.

## Enable routing diagnostics

To see data related to work items and their status, you need to enable routing diagnostics.

1. Sign in to Dynamics 365.

2. Perform one of the following steps:

   - In Omnichannel admin center, in **Advanced settings** in the site map, select **Diagnostics**.
   - In Customer Service Hub, go to **Service Management**, and in **Unified Routing** select **Diagnostics**.

3. On the **Routing diagnostics** page, select **Turn on routing diagnostics**.

4. In the confirmation message that appears, select **Yes**.

   You'll see that a list of new work items start to appear. However, Work items may not appear on your screen immediately.

> [!NOTE]
> After you enable diagnostics, the data will be stored in Microsoft Dataverse. This might impact your storage capacity. Select **Turn off diagnostics** to disable diagnostics.


## Understand routing stages and diagnostics

The **Routing diagnostics** page displays a list of work items with details and the stage each work item is in. The following table displays the information to help you understand routing diagnostics.

- **Work item**: The name of the work item. Work items can be searched and sorted by clicking the dropdown next to the work item column.
- **Routing status**: The stage the work item is in.
- **Routing started on**: The time and date when the routing began
- **Routing duration**: The amount of time the work item has been in its current stage.
- **Work stream**: The name of the work stream that the work item was assigned to.
- **Queue**: The name of the queue that the work item was routed to.

## Routing diagnostics flow

Each work item needs to pass through a set of stages before its routing stage can be assigned as completed. You can create multiple workstreams and assign work items based on their severity and priority. The diagnostics flow displays information based on the flow each work item goes through.

Intake ➡ Classification ➡ Route to queue ➡ Assignment

> [!NOTE]
> If a work item skips a stage in the flow, the stage is disabled.

### Summary

You can select a work item on the **Routing diagnostics** page to view the detailed information, such as when the work item was created, its current stage, and the duration of each stage. You can also select and open the work item to see the associated case. If the work item is not assigned or no rule item meets the criteria of the work item, error messages are displayed. You can select the stage to see further details of the error.

:::image type="content" source="media/routing-diagnostics-summary.png" alt-text="Summary view of a routed work item.":::

### Intake

> [!NOTE]
> The intake stage is applicable only for record routing.

When a work item comes in, it goes to the first workstream in the **Intake** table and is checked for whether it meets the conditions of the rule set. The work item moves to the second workstream and checks for a match with that rule set, and so on. When a work item matches the rule set, the work item is run. You can create multiple workstreams to handle work items based on their priority. This is called the **Intake** stage of the workflow.

After a work item passes the **Intake** stage, it's then classified through several rule sets and rule items.

A work item passes through three stages.

- **Processed** : Work item has passed through a rule set but didn't match with the rule set and is therefore not run.
- **Matched**: Applicable to only route-to-queue rules; displays with a green check mark if the rule conditions is true.
- **Applied** : Work item has passed through a rule set and matched with the conditions of the rule set.
- **Not processed**: Work item did not pass through a rule set.

### Classification

If a work item doesn't run through a particular rule set in the **Classification rulesets** list, the **Run status** check mark is displayed in red. When the work item runs a particular rule set, the **Run status** check mark is displayed in green. A work item runs all rule sets, but it doesn't run all rule items within the rule set.

If machine learning-based skills identification, effort estimation (preview), or a sentiment prediction (preview) model is used, the details of the model that's used are displayed in the **Classification** section.

:::image type="content" source="media/routing-diagnostics-classification.png" alt-text="View of classification ruleset and machine learning model.":::

### Route to queue

Queue routing rules are formulated to send the work item to the correct queue. More information: [Set Up routing and assignment rules](routing-rules.md)

The queue name to which the work item is routed is displayed on the route to queue page.

:::image type="content" source="media/routing-diagnostics-selected-queue.png" alt-text="Queue to which work item is assigned.":::

If no queue matches the requirement, the work item is assigned to the default queue.

### Assignment

Each work item is assigned to an agent or is sent to a queue based on the **Assignment** rule set. Assignment rule sets contain conditions for which work items need to be assigned to agents. In routing diagnostics, the assignment stage helps understand how the assignment of the work item was handled, such as how the prioritization was done and what assignment selection criteria was applied.

The following stages are available:

- **Prioritization**: Lists the prioritization rule that was applied if any. Work items are routed according to their priority. For more information, see : [Configure assignment methods and rules for queues](configure-assignment-rules.md)
- **Assignment selection**: Displays information about the conditions that determined in selecting an agent. If more than one assignment rule set exists, selection criteria defines the order in which the rule sets are to be evaluated. The assignment selection criteria determines the rule set that has the closest match and the rule that should be run out of the many rules.
- **Assignment ruleset**: Displays information about the rule sets that were processed.
- **Agent assignment trace**: Provides information that was used to determine and match the work item with the agent:
 
  - **Assignment criteria**:
      - **Assignment method**: Displays "Highest" or "Round robin".
      - **Capacity**: Displays the capacity information.
      - **Presence**: Displays the presence used.
      - **Skills**: Displays the skills that were matched if any.
  - **Assignment trace**:
      - **Current status**: Displays the status of the work item, such as whether an agent has been identified.
      - **Status reason**: Displays the associated reason of the status.
      - **Assigned to**: Displays the agent to whom the work item is assigned if any.
      - **Total attempts**: Displays the number of attempts that were required to assign the agent if any.
      - **Last attempt at**: Displays the date and time of the last attempt for assigning the work item was made.

    :::image type="content" source="media/agent-assignment-trace.png" alt-text="Information about assignment trace.":::

### See also

[Overview of skill based routing](overview-skill-work-distribution.md)  
[Assignment methods for Queues](assignment-methods.md)  
[Create and manage routing rules](routing-rules.md)  
[Routing and assignment rules](routing-workstream-queues.md)  
[Historical analytics for unified routing in Customer Service](cs-historical-analytics-unified-routing.md)  
[Historical analytics for unified routing in Omnichannel for Customer Service](oc-historical-analytics-unified-routing.md)  
[Configure work classification rules](configure-work-classification.md)  

