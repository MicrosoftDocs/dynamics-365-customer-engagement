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

Unified routing helps you assign a work item to the agent or queue who's best suited to handle it, based on the agent's skills and the entities that are related to the work item. With unified routing, you can prioritize work items and keep track of their progress and status.<!--note from editor: Edits suggested.-->

## Enable routing diagnostics

To see data related to work items and their status, you need to opt in to routing diagnostics.

1. Sign in to Dynamics 365.<!--note from editor: Removed "applications" to be parallel with other instances in our content where we're not specifying one particular application. -->

2. Do one of the following: 

   - In Customer Service Hub, go to the **Service Management** work area.
   - Sign in to **Omnichannel Administration**.<!--note from editor: This is how this is typically referred to in our content. (Actually the most common pattern is "Sign in to the Omnichannel Administration app," but my edit assumes that Omnichannel Administration is indeed the UI string.) If the UI says "Omnichannel admin centre," we'll need to talk about the UI.-->

3. On the left pane under **Advanced settings**, select **Diagnostics**.

4. On the **Routing diagnostics** page command bar<!--note from editor: Suggested, just to help the reader see where the command is.-->, select **Turn on routing diagnostics**.

5. In the confirmation message that appears, select **Yes**.<!--note from editor: Edit okay?-->

You'll see a list of work items on your screen, similar to the following image.


## Understand routing stages and diagnostics

The **Routing diagnostics** page displays a list of work items with details and the stage each work item is in: The following table displays the information to help you understand routing diagnostics.<!--note from editor: Writing Style Guide says to use a table only if there are two or more rows. This content is better suited to a list.-->

- **Work item**: The name of the work item.
- **Routing status**: The stage the work item is in.
- **Routing started on**: The time and date when the routing began
- **Routing duration**: The amount of time the work item has been in its current stage.<!--note from editor: "The duration of the work item in the latest stage" made me think that this would be a continuously incremented amount. That is, when a work item is completed the duration just keeps increasing, but I don't think that's right.-->
- **Work stream**: The name of the work stream that the work item was assigned to.
- **Queue**: The name of the queue that the work item was routed to.

You can select any work item to see a **Summary** page that shows detailed information about when the work item was created, its current stage, and the duration of each stage. You can also open the work item to see the related case.<!--note from editor: Edits suggested. I have a note about the UI on this page: I'd suggest that instead of "Routed agent," it should be "Routed to."-->

## Routing diagnostics flow

Each work item needs to pass through a set of stages before it can be assigned the **Completed** stage<!--note from editor: Is it okay that there's no stage named "Completed" in the diagram of the flow, below?-->. You can create multiple work streams and assign work items based on their severity and priority. The standard flow of a work item is shown in the following image.<!--note from editor: I assume the following line of text will be replaced by an image? Then this text can become the alt text for that image.-->

Intake ➡ Classification ➡ Route to queue ➡ Prioritization ➡ Assignment selection ➡ Assignment

< screenshot to be added here>

> [!NOTE]
> If a work item skips a stage in the flow, the stage is disabled.

### Intake

When a work item comes in, it goes to the first work stream<!--note from editor: How is a work stream different from a rule set?--> in the **Intake** table and is checked whether it meets the conditions of the rule set.<!--note from editor: I'm not sure that "matches with the rule set" is the best way to describe this step. Isn't it more that it meets (or doesn't meet) the conditions in the rule set?--> If it doesn't, it moves to the second work stream and is checked for a match with that rule set<!--note from editor: According to the video associated with task 2205519, the work item runs through every rule set whether it met conditions for the previous one or not. Is this the case?-->, and so on. When a work item matches the legacy<!--note from editor: What does "legacy" mean here? Some are not called "legacy" here, some areIs it the case that some rule sets are legacy, some are new, or should they all be referred to as "legacy"? Does it matter to the reader--> rule set, the work item is run. You can create multiple work streams based on priority of the work items. This is called the **Intake** stage of the workflow. 

After a work item passes the **Intake** stage, it's then classified through several rule sets and rule items.

### Classification

If a work item doesn't run through a particular rule set in the **Classification rulesets** list, the **Run status** check mark is displayed in red. When the work item executes a particular rule set, the **Run status** check mark is displayed in green. A work item executes all rule sets, but it doesn't execute all rule items within the rule set.<!--note from editor: Meghana, can you advise the UI designer that color shouldn't be the only way that status is displayed? This is especially true of using red and green, which is a common type of color blindness.-->

 < screenshot to be added here>

### Route to queue

Queue routing rules are formulated to send the work item to the correct queue. More information: [Routing and assignment rules](routing-workstream-queues.md)

### Prioritization

The **Prioritization** rule set<!--note from editor: Should this be "stage"? I'm a bit confused by stage versus rule sets (and work streams).--> is a list of prioritization rules. Work items are routed according to their priority. 

### Assignment selection

< Awaiting inputs from the Dev team. Info will be added later.>

### Assignment

Each work item is assigned to an agent or is sent to a queue based on the **Assignment**<!--note from editor: It was fine to use lowercase "assignment," but I wonder whether we might want to use bold and caps to echo the UI?--> rule set. Assignment rule sets contain conditions on which work items need to be assigned to agents. 

<!--note from editor: The following is redundant.
The **Detailed log** section in the **Summary** page provides information on the different stages that the work item went through, the progress of each stage and the duration of the work item in each stage. Sometimes, a work item can skip a stage in the workflow. You can see what stages were skipped and can modify your rule set accordingly.
-->

### See also

[Overview of unified routing](overview-unified-routing.md)


