---
title: Use Service Agent in Microsoft 365 Copilot (preview)
description: Learn how to use Service Agent in Microsoft 365 Copilot to quickly get responses on case and customer records without manually searching for the information.
ms.date: 04/07/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Use Service Agent in Customer Service (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Service Agent is a Microsoft 365 Copilot agent that helps customer service representatives (service representatives, representatives) find, summarize, and update customer service information by using data from Dynamics 365 Customer Service and connected knowledge sources. It supports assisted Copilot scenarios, such as reviewing cases, retrieving knowledge, and performing case actions.

After an administrator [enables Service Agent](../administer/configure-service-agent.md), customer service representatives can use Copilot to retrieve case and customer interaction summaries, details about their workload, and responses from knowledge across Dynamics 365 and SharePoint, and take actions on cases such as adding notes, updating status and creating child cases with Copilot assistance.

When you ask Copilot a question or request assistance, Service Agent uses your organization’s customer service data—such as cases, customer records, and interactions—to generate Copilot responses without requiring you to manually search for that information.

You can use Service Agent in the following ways:
-	In Microsoft 365 Copilot app
-	Directly in Copilot Service workspace while working on customer interactions
-	In any Microsoft 365, Dynamics 365 or Power Apps application where Microsoft 365 Copilot is enabled

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Access Service Agent in Customer Service

While you work on an active customer interaction in Customer Service, you can use Copilot capabilities to retrieve relevant service information in context.

To use Service Agent directly in Copilot Service workspace, perform the following steps:

1. Select **Copilot** in the header to open the Copilot side pane.
1. In the Copilot pane, select the **Open navigation panel** icon (hamburger menu).
1. From the navigation panel, select **Service (Preview)**
   
   > [!Note]
   > If **Service (Preview)** isn’t visible, select **All agents**, and then select **Service (Preview)** from the list.

   :::image type="content" source="../media/service-agent-open-navigation.png" alt-text="Copilot navigation panel showing Service (Preview) selected under All agents":::

   Service Agent opens in the Copilot pane.
1. Ask a question or request assistance related to the current customer interaction.

When you select **Service (Preview)**, Microsoft 365 Copilot activates customer service-specific skills. Service Agent can use the current app and customer interaction, such as an active case or work item, as a context when it's available.

### How context is used

In Copilot Service workspace, Service Agent can automatically use the active case or work item as context when it's available.

In other Microsoft 365 Copilot experiences you might need to explicitly reference the case or record you want Copilot to use.

### Select a data source

Service Agent retrieves and updates customer service data from the Dynamics 365 Customer Service environment selected under **Sources**. 

If you have access to multiple environments, select **Sources** to view the available connections and choose the environment you want Service Agent to use. The selected source determines which customer service records Service Agent can retrieve and update during your session.

:::image type="content" source="../media/service-agent-select-source.png" alt-text="Sources menu showing a connected Dynamics 365 Customer Service environment for Service Agent":::

## What you can do with Service Agent

Copilot uses the Service Agent skills to help you review, summarize, and update customer service information while you work with customers.

You can use Service Agent to do the following tasks in Customer Service:

### Review and prioritize cases

You can use Service Agent to review and prioritize cases based on relevant case information.

For example, you can ask Service Agent to:
- Show high-priority cases for this customer.
- Identify open cases that require follow-up.

### Summarize case details

You can use Service Agent to summarize information from an existing case.

For example, you can ask Service Agent to:
-	Summarize the activity for this case.
-	Provide an overview of this case.

### Summarize customer interactions

You can use Service Agent to summarize recent customer interactions. Copilot discovers data across Teams, Outlook and Customer Service.

For example, you can ask Copilot to:
-	Summarize recent interactions for this customer.
-	Show interaction history for this account.

### Retrieve knowledge responses

You can use Service Agent to retrieve knowledge responses that are relevant to the customer’s issue. Copilot discovers answers from Dynamics 365 knowledge and SharePoint. 

For example, you can ask Service Agent to:
-	Find knowledge articles related to this case.
-	Find details on how to address this case. 
-	Show recommended knowledge responses.

### Perform case write actions

You can use Service Agent to update case information.

For example, you can ask Service Agent to:
-	Update the case priority.
-	Add notes to this case.
-	Create a new child case associated with this case.

## Related information

[Configure Service Agent](../administer/configure-service-agent.md)
