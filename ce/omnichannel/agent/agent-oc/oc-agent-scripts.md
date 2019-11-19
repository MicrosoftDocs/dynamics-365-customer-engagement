---
title: "Agent scripts in the Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn how to use agent scripts in the Omnichannel for Customer Service app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
---

# Preview: Guide customer interaction with agent scripts

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../../legal/dynamics-insider-agreement.md).

## Overview of agent scripts

Agent scripts in Omnichannel for Customer Service provide guidance about what you (an agent) should do when you get a customer issue. They ensure that you share only accurate and company-endorsed information. Agent scripts help you to be accurate and effective while also being faster and more efficient in terms of customer handling.

> [!div class='mx-imgBorder']
> ![Agent script](../../media/agent-script-section.PNG "Agent script")

1. Agent script menu
2. Text instructions
3. Macro
4. Agent script

The agent script section consists of a set of steps. Based on the type of agent script the administrator has configured, you might follow these types of steps:

- Text instructions
- Macro
- Agent script

Each of the steps can be identified with the actionable icon. When you expand a step, the section displays a short description of what the step entails and the action you need to perform using the icons next to it. The step that is executed successfully is indicated with a green Tick icon, and the step that has an error is indicated with a red Cross icon. You can execute the steps again as needed, and the final state of the step, green Tick or red Cross, is based on the last run.

## Text instructions

The text instruction provides guidance on the actions you need to perform. The step in the agent script shows a title, instructions, and the Text instruction icon that is actionable. After you perform the step based on the instructions, you can select the **Mark as done** icon to indicate that you've completed the step.

**Example:**

| Title | Action you need to perform |
|----------------|-------------------------------------------------------------------------|
| Greet customer | Greet the customer with welcome message from the quick reply repository.|

> [!div class='mx-imgBorder']
> ![Agent script text instruction](../../media/agent-script-text-instruction.PNG "Agent script text instruction")

## Macro

A macro is a set of instructions that tells the system how to complete a task. When a macro runs, the system performs each instruction. The **Macro** step in the agent script shows a title, instruction that system performs, and the macro icon. When you select **Run** icon, the system performs the macro.

**Example:**

| Title | Instruction system performs |
|----------------|----------------------------------------|
| Create case | Triggers create case from customer context|

In this example, when an agent selects the **Macro** icon, the system opens a new **Create case** form in the application tab panel with prepopulated fields based on the customer context.

> [!div class='mx-imgBorder']
> ![Agent script macro](../../media/agent-script-run-macro.PNG "Agent script macro")

## Agent script

The step is used to load another agent script from the current agent script. When you select the view icon, the system loads the agent script. You can see that newly loaded script replaces the current script in the Agent script menu.

> [!div class='mx-imgBorder']
> ![Agent script](../../media/agent-script-view.PNG "Agent script")

## Sample agent script

When you get an incoming conversation (chat) notification, you accept the conversation request and then a chat session starts. Now, the agent script is available in a form based on the administrator configuration. 

For example, if the administrator has configured in the Customer Summary form, then you can see view the agent script in the Customer Summary form.

Let's see the sample agent script:

- Chat session
- Close session

Below the menu you can see the description for the selected script.

When the Chat session script is selected, the step you see is:

**Please follow these steps for resolving general chat queries**

The **Chat session** script has the following steps

| Step | Title | Instruction | Icon | Agent action |
|-----------|--------------------|-----------------------|----------------------|-----------------------|
| Text instruction | Greet Customer | Greet the customer with welcome message from the quick reply repository. | Mark as done | After you greet the customer, select the mark as done icon. |
| Text instruction | Verify Customer | Use any two of the following to verify the customer Kenny Smith:<ol> <li>Date of Birth</li> <li> Email id </li> <li>Zip code</li> <li>Mobile</li> | Mark as done | After you verify the customer, select the mark as done icon. | 
| Macro | Create case | Triggers create case form with customer context | Run | When you select the run macro icon, the system opens a case form in a new application tab panel. |
| Macro | Send details to the customer | Opens email to send details to the customer | Run | When you select the run macro icon, the system opens an draft email so you can send an email to the linked customer. |
| Agent script | Close conversation | Follow these steps to close a conversation | View | When you select the view icon, the system loads another agent script from the current agent script. In this sample, the another agent script is **Close conversation** script. |


Similarly, the administrator can create more agent scripts as per your business scenarios. To learn how to configure, see [Guide agents with scripts](../../administrator/agent-scripts.md).

## See also

[Guide agents with scripts](../../administrator/agent-scripts.md)
