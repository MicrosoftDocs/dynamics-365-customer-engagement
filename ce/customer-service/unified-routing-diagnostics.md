---
title: Routing Diagnostics (Dynamics 365 Customer Service) | MicrosoftDocs
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

# Unified Routing Diagnostics

Unified routing helps you assign work items to the best suited agent or queue. You can check the progress and status of a work item. With unified routing you can prioritize and then choose which work item can be assigned to agents based on the agents' skills and related entities. 

## Enable routing diagnostics

To see data related to work items and their status, you need to opt-in to routing diagnostics. To opt-in perform the following steps.

1. Sign in to Dynamics 365 applications and do one of the following:

2. Go to Customer Service Hub and navigate to the **Service Management** work area.

 or

Sign in to Omnichannel admin centre.

3. Select **Diagnostics** from the **Advanced settings** list in the navigation menu.

4. In the **Routing diagnostics** page, select the **Turn on Routing diagnostics** option.

5. Select **Yes.**

You will now be able to see a list of work items on your screen.


## Understand routing stages and diagnostics

On your **Routing diagnostics** page, you will find a list of work items and the details and stages of each work item. This table displays the information to help you understand routing diagnostics.


| Work item | Routing status | Routing started on | Routing duration | Work stream | Queue |
|----------- | ------------- | -------------- | ------------ | ---------- | ------------ | 
| The name of the work item | The stage of the work item | The time and date when the routing began | The duration of the work item in the latest stage | The name of the work stream that the work item was assigned to | The name of the queue that the work item has been routed to. |

You can select any work item to see a **Summary** page that shows detailed information on when the work item was created, the routing stage. You can also open the work item to see the related case.

## Routing diagnostics flow

Each work item needs to pass through a set of stages for it to be assigned the stage of completion. You can create multiple work streams and assign work items based on their severity and priority. The standard flow of a work item is as follows.

Intake ➡ Classification ➡ Route to queue ➡ Prioritization ➡ Assignment selection ➡ Assignment

< screenshot to be added here>

> [!NOTE]
> If a work item skips a particular stage in the flow, then the stage is disabled.

### Intake

When a work item comes in, it goes to the first work stream in the Intake table and checks if it matches with the rule set. If not, it moves to the second work stream, checks for a match with the rule set and so on and so forth. When a work item matches with the legacy rule set, the work item is run.  You can create multiple work streams based on priority of the work items. This is called the Intake stage of the workflow. 

Once a work item passes the Intake stage, it is then classified into several rulesets and rule items.

### Classification

If a work item does not run through a particular ruleset in **Classification rulesets** list, the **Run status** is marked in red. If the work item executes a particular rule set, then the **Run status** is marked in green. A work item executes all rule sets, but it doesn't execute all rule items within the rule set. 

 < screenshot to be added here>


### Route to queue

Queue routing rules are formulated to send the work item to the correct queue.
For more information, see [Routing and assignment rules](routing-workstream-queues.md)

### Prioritization

Prioritization rule set is a list of prioritization rules. Work items are routed according to their priority. 

### Assignment selection

< Awaiting inputs from the Dev team. Info will be added later.>

### Assignment

Each work item is assigned to an agent or is sent to a queue based on the assignment rule set. Assignment rule sets contain conditions on which work items need to be assigned to agents. 

The **Detailed log** section in the **Summary** page provides information on the different stages that the work item went through, the progress of each stage and the duration of the work item in each stage. Sometimes, a work item can skip a stage in the workflow. You can see what stages were skipped and can modify your rule set accordingly. 

### See also

[Overview of Unified Routing](overview-unified-routing.md)


