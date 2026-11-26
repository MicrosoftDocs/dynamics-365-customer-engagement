---
title: Use Service Agent in Customer Service
description: Learn how to use Service Agent in Microsoft 365 Copilot so representatives can quickly get answers about cases and customer records without manual searching.
ms.date: 09/26/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Use Service Agent in Customer Service

Service Agent is a Microsoft 365 Copilot agent that helps customer service representatives (service representatives, representatives) find, summarize, and update customer service information by using data from Dynamics 365 Customer Service and connected knowledge sources. It supports assisted Copilot scenarios, such as reviewing cases, retrieving knowledge, and performing case actions.

Service Agent is generally available as a Microsoft 365 Copilot agent. After an administrator [enables Service Agent](../administer/configure-service-agent.md), you can use Copilot to retrieve case and customer interaction summaries, view workload details, and get responses from knowledge sources across Dynamics 365 and SharePoint.

You can also take actions on cases, such as adding notes, updating status, and creating child cases.

When you ask Copilot a question or request assistance, Service Agent uses your organization’s customer service data—such as cases, customer records, and interactions—to generate Copilot responses without requiring manual searching.

You can use Service Agent in the following places:
-	Microsoft 365 Copilot
-	Copilot Service workspace while working on customer interactions
-	Any Microsoft 365, Dynamics 365, or Power Apps application where Copilot is enabled

## Access Service Agent in Customer Service

### Licensing and feature availability

Specific licensing requirements apply when you use Service Agent. The capabilities available to you can vary based on your organization's licensing and tenant configuration. Learn more in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

While you work on an active customer interaction in Customer Service, you can use Copilot capabilities to retrieve relevant service information in context.

To use Service Agent directly in Copilot Service workspace, follow these steps:

1. Select **Copilot** in the header to open the Copilot side pane.
1. In the Copilot pane, select the **Open navigation panel** icon (hamburger menu).
1. From the navigation panel, select **Service**.
   
   > [!Note]
   > If **Service** isn't visible, select **All agents**, and then select **Service** from the list.

   :::image type="content" source="../media/service-agent-open-navigation.png" alt-text="Copilot navigation panel showing Service selected under All agents":::

   Service Agent opens in the Copilot pane.
1. Ask a question or request assistance related to the current customer interaction.

When you select **Service**, Microsoft 365 Copilot activates customer service-specific skills. Service Agent can use the current app and customer interaction, such as an active case or work item, as context when it's available.

### How context is used

In Copilot Service workspace, Service Agent can automatically use the active case or work item as context. In other Microsoft 365 Copilot experiences, you might need to reference the case or record you want Copilot to use.

### Select a data source

Service Agent retrieves and updates customer service data from the Dynamics 365 Customer Service environment selected under **Sources**. 

If you have access to multiple environments, select **Sources** to view the available connections and choose the environment you want Service Agent to use. The selected source determines which customer service records Service Agent can access during your session.

:::image type="content" source="../media/service-agent-select-source.png" alt-text="Sources menu showing a connected Dynamics 365 Customer Service environment for Service Agent":::

## What you can do with Service Agent

Service Agent uses its skills to help you review, summarize, and update customer service information while you work with customers.

You can use Service Agent to perform the following tasks:

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

Use Service Agent to summarize recent customer interactions. Service Agent discovers data across Teams, Outlook, and Customer Service.

For example, you can ask Service Agent to:
-	Summarize recent interactions for this customer.
-	Show interaction history for this account.

### Retrieve knowledge responses

Use Service Agent to retrieve knowledge responses that are relevant to the customer’s issue. Service Agent discovers answers from Dynamics 365 knowledge and SharePoint. 

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
-	Resolve this case and record the resolution details.

### Draft knowledge articles and responses

Use Service Agent to draft a knowledge article or a customer-ready response based on how you resolved a case.

For example, you can ask Service Agent to:
-	Draft a knowledge article from the resolution of this case.
-	Draft a response that explains the workaround to the customer.

### Draft and send customer emails

Use Service Agent to draft an email to the customer and send it after you review it.

For example, you can ask Service Agent to:
-	Draft an email that summarizes the status of this case.
-	Send the follow-up email to the case contact.

### Get case intelligence and next best actions

Use Service Agent to understand what's driving a case and what to do next.

For example, you can ask Service Agent to:
-	Explain why this case is at risk of missing its service-level agreement (SLA).
-	Recommend the next best action for this case.

## Related information

[Configure Service Agent](../administer/configure-service-agent.md)
