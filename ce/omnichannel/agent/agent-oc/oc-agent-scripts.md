---
title: "Agent scripts in the Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn about to use agent scripts in the Omnichannel for Customer Service app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 90361CFB-001A-4EFF-8BCF-5505CF14D052
ms.custom: 
---

# Preview: Guide customer interaction with agent scripts

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview of agent scripts

Agent script in Omnichannel for Customer Service provides guidance about what you (agent) should be doing when you get a customer issue. It ensures that you share only the accurate and company-endorsed information. Agent scripts help you to be accurate, and effective while being faster and more-efficient in terms of customer handling.

When you accept an incoming conversation request, a session starts and the **Customer Summary** application tab opens. You can see the Agent script section, which has a agent script .

> [!div class='mx-imgBorder']
> ![Agent script](../../media/agent-script-section.PNG "Agent script")

1. Agent script control
2. Text instructions
3. Macro
4. Sub agent script

Based on the type of agent script administrator has configured, you may following type of steps:

- Text instructions
- Macro
- Sub agent script

When you expand the step, the configured instructions appears.

## Text instructions

The text instructions provides guidance on the action you must perform. The **Text instructions** step in the agent script shows a title, instruction(s), and the text instruction icon. After you perform the the instruction, you can select the icon **Mark as done** to indicate that you've executed the step.

**Example:**
| Title | Instruction you need to perform |
|----------------|-------------------------------------------------------------------------|
| Greet customer | Greet the customer with welcome message from the quick reply repository.|

> [!div class='mx-imgBorder']
> ![Agent script text instruction](../../media/agent-script-text-instruction.PNG "Agent script text instruction")

## Macro

A macro is a set of instructions that tells the system how to complete a task. When a macro runs, the system performs each instruction. The **Macro** step in the agent script shows a title, instruction that system performs, and the macro icon. When you select run macro icon, the system executes the macro.

**Example:**

| Title | Instruction system performs |
|----------------|----------------------------------------|
| Create case | Triggers create case from customer context|

In this is example, when an agent selects the macro icon, the system opens a new **Create case** form in the application tab panel with pre-populated fields based on the customer context.

> [!div class='mx-imgBorder']
> ![Agent script macro](../../media/agent-script-run-macro.PNG "Agent script macro")

## Sub agent script

The sub agent script is another agent script which is invoked from the current agent script. When you select the view icon, the system loads the sub agent script.

> [!div class='mx-imgBorder']
> ![Sub agent script](../../media/agent-script-view.PNG "Sub agent script")

## See also

[Guide agents with scripts](../../administrator/agent-scripts.md)