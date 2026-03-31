---
title: Use Service Agent in Microsoft 365 Copilot (preview)
description: Learn how to use Service Agent in Microsoft 365 Copilot to quickly get responses on case and customer records without manually searching for the information.
ms.date: 03/31/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
---

# Use Service Agent in Customer Service

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

After an administrator [enables Service Agent](../administer/configure-service-agent.md), customer service representatives can use Copilot to retrieve case and customer interaction summaries, details on their workload, responses from knowledge across Dynamics and SharePoint, and take actions on cases such as adding notes, updating status and creating child cases. relevant customer service information without manually searching for records. 

When you ask Copilot a question or request assistance, Service Agent uses your organization’s customer service data—such as cases, customer records, and interactions—to generate Copilot responses without requiring you to manually search for that information.

You can use Service Agent in the following ways:
-	In Microsoft 365 Copilot chat
-	Directly in Copilot Service workspace while working on customer interactions
-	In any Microsoft 365, Dynamics 365 or Power Apps application where Microsoft 365 Copilot is enabled.

## Access Service Agent in Customer Service

While you work on an active customer interaction in Customer Service, you can use these Copilot capabilities to retrieve relevant service information in context.

To use Service Agent directly in Copilot Service workspace, perform the following steps:

1. Select **Copilot** in the header to open the Microsoft 365 Copilot side pane.
1. In the Copilot pane, select **Service (Preview)** from the list of available agents. Service Agent opens in the Copilot pane.
1. Ask a question or request assistance related to the customer interaction.

> [!Note}
> Service Agent runs within Microsoft 365 Copilot. When used outside of Copilot Service workspace, Service Agent isn’t tied to an active case or work item and doesn’t automatically use the available app context.

## What you can do with Service Agent

Copilot uses the Service agent skills to help you review, summarize, and update customer service information while you work with customers.

You can use Service Agent to do the following tasks in Customer Service:

**Review and prioritize cases**

You can use Copilot to review and prioritize cases based on relevant case information.

For example, you can ask Copilot to:
- Show high-priority cases for this customer.
- Identify open cases that require follow-up.

**Summarize case details**

You can use Copilot to summarize information from an existing case.

For example, you can ask Copilot to:
-	Summarize the activity for this case.
-	Provide an overview of this case.

**Summarize customer interactions**

You can use Copilot to summarize recent customer interactions. Copilot will discover data across Teams, Outlook and Dynamics Customer Service.

For example, you can ask Copilot to:
-	Summarize recent interactions for this customer.
-	Show interaction history for this account.

**Retrieve knowledge responses**

You can use Copilot to retrieve knowledge responses that are relevant to the customer’s issue. Copilot will discover answers from Dynamics knowledge and SharePoint. 

For example, you can ask Copilot to:
-	Find knowledge articles related to this case.
-	Find details on how to address this case. 
-	Show recommended knowledge responses.

**Perform case write actions**
You can use Copilot to update case information.

For example, you can ask Copilot to:
-	Update the case priority.
-	Add notes to this case.
-	Create a new child case associated with this case.

## Related information

[Configure Service Agent](../administer/configure-service-agent.md)


