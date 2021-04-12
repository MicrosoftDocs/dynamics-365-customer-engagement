---
title: Routing diagnostics (Dynamics 365 Customer Service) | MicrosoftDocs
description: Learn how to set up routing diagnostics and understand the different stages of routing work items.
author: Meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 04/10/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Unified routing diagnostics

Unified routing helps you assign a work item to the agent or queue who's best suited to handle it, based on the agent's skills and the entities that are related to the work item. Routing diagnostics will provide visibility into work item classification and assignment events when using unified routing. 

## Enable routing diagnostics

To see data related to work items and their status, you need to enable routing diagnostics.

1. Sign in to Dynamics 365.

2. Perform one of the following steps. 

In Customer Service Hub, go to the **Service Management** work area and select **Diagnostics**.

or

Sign in to **Omnichannel admin center** and select **Diagnostics** from the **Advanced settings** options in the menu.

3. On the **Routing diagnostics** page command bar, select **Turn on routing diagnostics**.

4. In the confirmation message that appears, select **Yes**.

You'll see a list of new work items appear on your screen. However, Work items may not appear on your screen immediately.

> [!NOTE]
> After you enable diagnostics, the data will be stored in your CDS storage. This might impact your storage capacity. Select **Turn off diagnostics** to disable diagnostics.


## Understand routing stages and diagnostics

The **Routing diagnostics** page displays a list of work items with details and the stage each work item is in. The following table displays the information to help you understand routing diagnostics.

- **Work item**: The name of the work item.Work items can be searched and sorted by clicking the dropdown next to the work item column.
- **Routing status**: The stage the work item is in.
- **Routing started on**: The time and date when the routing began
- **Routing duration**: The amount of time the work item has been in its current stage.
- **Work stream**: The name of the work stream that the work item was assigned to.
- **Queue**: The name of the queue that the work item was routed to.

You can select any work item to see a **Summary** page that shows detailed information about when the work item was created, its current stage, and the duration of each stage. You can also open the work item to see the related case. 

## Routing diagnostics flow

Each work item needs to pass through a set of stages before its routing stage can be assigned as completed. You can create multiple work streams and assign work items based on their severity and priority. The standard flow of a work item is mentioned here.

Intake ➡ Classification ➡ Route to queue ➡ Prioritization ➡ Assignment selection ➡ Assignment

> [!NOTE]
> If a work item skips a stage in the flow, the stage is disabled.

### Intake

When a work item comes in, it goes to the first work stream in the **Intake** table and is checked for whether it meets the conditions of the rule set. The work item moves to the second work stream and checks for a match with that rule set, and so on. When a work item matches the rule set, the work item is run. You can create multiple work streams based on priority of the work items. This is called the **Intake** stage of the workflow. 

After a work item passes the **Intake** stage, it's then classified through several rule sets and rule items.

A work item passes through three stages.

- **Processed** : Work item has passed through a rule set but didn't match with the rule set and is therefore not run.
- **Applied** : Work item has passed through a rule set and matched with the conditions of the rule set.
- **Not processed**: Work item did not pass through a rule set. 

### Classification

If a work item doesn't run through a particular rule set in the **Classification rulesets** list, the **Run status** check mark is displayed in red. When the work item executes a particular rule set, the **Run status** check mark is displayed in green. A work item executes all rule sets, but it doesn't execute all rule items within the rule set.

 ### Route to queue

Queue routing rules are formulated to send the work item to the correct queue. More information: [Set Up routing and assignment rules](routing-rules.md)

### Prioritization

The Prioritization rule set is a list of prioritization rules. Work items are routed according to their priority. For more information, see : [Routing and assignment rules](routing-workstream-queues.md)

### Assignment selection

Assignment rule sets contain conditions that determine which work items are assigned to which agents. If more than one assignment rule set exists, selection criteria define the order in which the rule sets are to be evaluated. The assignment selection criteria determines which rule set has the closest match and also determine which rule out of the many rules should be run.

### Assignment

Each work item is assigned to an agent or is sent to a queue based on the **Assignment** rule set. Assignment rule sets contain conditions for which work items need to be assigned to agents. 


### See also

- [Overview of skill based routing](overview-skill-work-distribution.md)

- [Assignment methods for Queues](assignment-methods.md)

- [Create and manage routing rules](routing-rules.md)

- [Routing and assignment rules](routing-workstream-queues.md)


