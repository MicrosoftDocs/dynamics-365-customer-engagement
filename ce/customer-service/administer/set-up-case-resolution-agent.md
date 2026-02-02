---
title: Set up Case Management Agent to resolve cases
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently resolve cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---


# Set up Case Management Agent to resolve cases

You can use Case Management Agent to resolve cases by identifying case intent, automatically gathering required customer information, and drafting professional email responses. This feature eliminates repetitive back-and-forth exchanges, and ensures consistent, high-quality customer communications while enabling your support teams to focus on complex problem-solving rather than routine administrative tasks.

## Prerequisites

- Make sure [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot) is set up in the Power Platform admin center application.
- The Power Platform [Pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview) mandates the use of an Azure subscription the system charges when the agent runs. Make sure you [Set up consumption-based billing](setup-pay-as-you-go.md).
- [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) is configured.
- For the AI agent to send emails and resolve cases autonomously, you must set up a dedicated application user to send and receive emails on behalf of your organization. Perform the steps in [Configure global settings for Case Management Agent](case-management-global-settings.md).

## Configure case resolution settings

 You can specify the user the AI agent should use to send emails, the default Copilot template, and if the AI agent must use Copilot recommended template to draft emails. Perform these steps for the fully-autonomous case resolution process:

1. Select **Manage** for **Case Management Agent** in **Case settings**. The **Case Management Agent** page appears.
1. Select **Manage** for **Global settings**. The **Global settings** page appears.
1. Set the **Application user** to the application user created in the prerequisites section. This is the user that the AI agent uses to send emails on behalf of your organization.
1. Optionally, select **Use copilot recommended template for drafting emails**.
1. Optionally, you can set the **Default email template** dropdown to a template the AI agent uses when Copilot email template recommendations are unavailable. If you configured Copilot recommended email templates and [line-of-business segregated email templates](configure-lob-email-templates.md), the system uses the default email template when no line-of-business email template is available for the case. 
If you don't select a default template and Copilot recommended email templates is configured, after the agent identifies the intent, it sends emails using the [Copilot inline email assist capabilities](/dynamics365/contact-center/use/use-copilot-email#use-copilot-to-draft-an-email).

## Configure level of automation

In Copilot Service admin center, follow these steps to configure the automation level for each line of business:

1. Select **Manage** for **Case Management Agent** in **Case settings**. The **Case Management Agent** page appears.
1. Select **Manage** for **Case Resolution**. The Case Resolution Agent page appears.
1. In **Level of automation per LOB**, the lines of business you configured in the Customer Intent Agent appear. Select the required line of business and then select **Edit**. You can specify the following automation levels for each line of business:
   - **Full**: The AI agent automatically resolves cases.
   - **Require agent confirmation**: The AI agent drafts email responses, but requires a representative to review and send the email.
   - **Disabled**: The agent doesn't draft email responses. 

### Record representative interactions with the AI agent

 You can select **Record service representative interactions with AI, including agent actions and their feedback on AI suggestions** to record and understand how representatives are interacting with the AI agent and how the agent is performing in a support organization. You can also download and use the data to analyze knowledge sources, and build usage reports.

## Understand case resolution triggers

Case Management Agent triggers the case resolution process automatically based on the following out-of-the-box and custom events:

- For an inbound email with the **Regarding** field set to a case.
- For a conversation linked to a case. When a conversation is closed and a transcript is created with the **Regarding** field set to a case.
- Call [`msdyn_invokeCaseProcessingAgent`](../develop/use-case-processing-agent.md) business event to invoke the case resolution process. `msdyn_invokeCaseProcessingAgent` provides a customization point that can be called by customer plugins, Power Platform flows, or external systems to trigger case resolution processing based on customer specific business logic or events.

## Runtime experience

When the case resolution process is triggered, based on your configuration, the AI agent follows the path specified in the table.

| Scenario | Fully autonomous | Semi-autonomous |
|----------|------------------|-----------------|
| **Can't identify intent** | Sends an email to the customer requesting additional information. Based on customer response, the agent follows one of the paths:<br>• Identifies case intent, but requires additional information<br>• Identifies the case intent and determines that the information is sufficient to resolve the case.<br><br>Invokes the [update functionality](../use/use-case-creation-agent.md#autonomous-case-updates) of Case Management Agent, if configured, to update the case fields, based on customer response. | Drafts an email to the customer requesting additional information. A service representative reviews and sends the email to the customer. Based on customer response, the agent follows one of the paths:<br>• Identifies case intent, but requires additional information<br>• Identifies the case intent and determines that the information is sufficient to resolve the case.<br><br>Invokes the [update functionality](../use/use-case-creation-agent.md#autonomous-case-updates) of Case Management Agent, if configured, to update the case fields, based on customer response. |
| **Identifies case intent, but requires additional information** | Sends an email to the customer requesting additional information. Based on customer response the case resolution agent either sends an email to the customer with the resolution or sends another email requesting additional information. Invokes the update functionality of Case Management Agent to update the case fields, based on customer response. | Drafts an email to the customer requesting additional information. Based on the customer response the case resolution agent either drafts an email to the customer with the resolution or another email requesting additional information. Invokes the update functionality of Case Management Agent to update the case fields, based on customer response. |
| **Identifies the case intent and determines information is sufficient** | Generates a solution and sends an email to the customer with resolution details.<br>• If the customer accepts the resolution, the AI agent sets the status of the case to **Resolved**. Invokes the [case follow-up](../use/use-case-follow-up-closure.md#use-autonomous-follow-up-and-closure-of-cases) functionality to follow up with the customer for case, if case follow-up and closure is configured for Case Management Agent.<br>• If the customer needs further assistance, the agent routes the case to a service representative. | Drafts a solution and sends an email to the customer with resolution details. If the customer accepts the resolution, the case resolution agent sets the status of the case to **Resolved**. Invokes the [case follow-up](../use/use-case-follow-up-closure.md#use-autonomous-follow-up-and-closure-of-cases) functionality to follow up with the customer for case, if case follow-up and closure is configured for Case Management Agent. |
  
   > [!NOTE]
   > - The AI agent selects an appropriate email template using Copilot recommended templates and [line-of-business specific templates](configure-lob-email-templates.md#runtime-experience) to draft email responses.
   > - If no email template is available, the AI agent uses the default email template configured in the global settings.

## Integrate Case Management Agent with custom Copilot Studio agents 

You can integrate Case Management Agent with custom Microsoft Copilot Studio agents to enhance the case resolution process. For example, you can create a custom agent that provides additional context or performs specific actions based on the case details. Learn more in [Integrate Case Management Agent with custom Copilot Studio agents](../develop/case-management-agent-integration.md).

## Related information

[Use Case Management Agent to resolve cases](../use/use-case-resolution-agent.md)