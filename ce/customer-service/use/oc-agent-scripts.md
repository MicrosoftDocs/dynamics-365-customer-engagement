---
title: Scripts in the Omnichannel for Customer Service app
description: Learn how to use scripts in Copilot Service workspace and serve customers faster.
ms.date: 04/21/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Guide customer interaction with scripts


[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

## Overview of scripts

Scripts provide guidance about what you (a customer service representative (service representative or representative)) should do when you get a customer issue and ensure that you share only accurate and company-endorsed information. Scripts help you be accurate, effective, and efficient in customer handling.

> [!div class='mx-imgBorder']
> ![Productivity pane.](../media/productivity-pane-agent-script.PNG "Productivity pane")

## Components in script

:::image type="content" source="../media/components-agent-script.png" alt-text="Components in script":::

1. Script menu
2. Text instructions
3. Macro
4. Script

The script section consists of a set of steps. Based on the type of script the administrator has configured, you might see the following types:

- Text instructions
- Macro
- Script

Each of the steps can be identified with the actionable icon. When you expand a step, the section displays a short description of what the step entails and the action you need to perform using the icons next to it. The step that is executed successfully is indicated with a green Tick icon, and the step that has an error is indicated with a red Cross icon. You can run the steps again as needed, and the final state of the step, green Tick or red Cross, is based on the last run.

## Prerequisite

Make sure you (service representative and supervisor) have the **Productivity tools user** security role. Learn more in [Assign roles and enable users](../implement/add-users-assign-roles.md).

## Text instructions

The text instruction provides guidance on the actions you need to perform. The step in the script shows the title, instructions, and the Text instruction icon that is actionable. After you perform the step based on the instructions, you can select the **Mark as done** icon to indicate that you've completed the step.

**Example:**

| Title | Action you need to perform |
|----------------|-------------------------------------------------------------------------|
| Greet customer | Greet the customer with welcome message from the quick reply repository.|

> [!div class='mx-imgBorder']
> ![Script text instruction.](../media/agent-script-text-instruction.PNG "Agent script text instruction")

## Macro

A macro is a set of instructions that tells the system how to complete a task. When a macro runs, the system performs each instruction. The **Macro** step in the script shows a title, instruction that system performs, and the macro icon. When you select **Run** icon, the system performs the macro.

**Example:**

| Title | Instruction system performs |
|----------------|----------------------------------------|
| Create case | Triggers create case from customer context|

In this example, when a representative selects the **Macro** icon, the system opens a new **Create case** form in the application tab panel with prepopulated fields based on the customer context.

> [!div class='mx-imgBorder']
> ![Script macro.](../media/agent-script-run-macro.PNG "Agent script macro")

## Script

The step is used to load another script from the current script. When you select the view icon, the system loads the script. You can see that newly loaded script replaces the current script in the script menu.

> [!div class='mx-imgBorder']
> ![Script.](../media/agent-script-view.PNG "Agent script")

## Sample script

When you get an incoming conversation notification, you accept the conversation request and then a chat session starts. Now, the script is available in a form based on the administrator configuration. 

For example, if the administrator has configured scripts in the **Active Conversation** form, then you can view the script in the **Active Conversation** form.

Let's see the sample script:

- Chat session
- Close session

Below the menu you can see the description for the selected script.

When the Chat session script is selected, the step you see is:

**Please follow these steps for resolving general chat queries**

The **Chat session** script has the following steps

| Step | Title | Instruction | Icon | Representative action |
|-----------|--------------------|-----------------------|----------------------|-----------------------|
| Text instruction | Greet Customer | Greet the customer with welcome message from the quick reply repository. | Mark as done | After you greet the customer, select the mark as done icon. |
| Text instruction | Verify Customer | Use any two of the following to verify the customer Kenny Smith:<ol> <li>Date of Birth</li> <li> Email id </li> <li>Zip code</li> <li>Mobile</li> | Mark as done | After you verify the customer, select the mark as done icon. | 
| Macro | Create case | Triggers create case form with customer context | Run | When you select the run macro icon, the system opens a case form in a new application tab panel. |
| Macro | Send details to the customer | Opens email to send details to the customer | Run | When you select the run macro icon, the system opens a draft email so you can send an email to the linked customer. |
| Script | Close conversation | Follow these steps to close a conversation | View | When you select the view icon, the system loads another script from the current script. In this sample, the other script is **Close conversation** script. |


Similarly, the administrator can create more scripts as per your business scenarios. Learn how to configure scripts in [Guide representatives with scripts](../administer/agent-scripts.md).

### Related information

[Guide representatives with scripts](../administer/agent-scripts.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
