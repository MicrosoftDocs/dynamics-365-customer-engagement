---
title: Set up Case Management Agent to resolve cases (preview)
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently resolve cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 09/01/2025
ms.custom: bap-template
---


# Set up Case Management Agent to resolve cases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You can use the Case Management Agent to resolve cases by identifying case intent, automatically gathering required customer information, and drafting professional email responses. This feature eliminates repetitive back-and-forth exchanges, and ensures consistent, high-quality customer communications while enabling your support teams to focus on complex problem-solving rather than routine administrative tasks.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- The CSR Manager or System Administrator role.
- [Workstreams](create-workstreams.md) and [queues for unified routing](queues-omnichannel.md) are set up.
- Make sure [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot) is set up in the Power Platform admin center application.
- The case resolution feature of Case Management Agent uses the Data Entry Agent in the background. The Power Platform [Pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview) mandates the use of an Azure subscription the system charges when the agent runs. Make sure you [Set up consumption-based billing](setup-pay-as-you-go.md).
- Case management agent is set up to create and update cases. Learn more in [Set up Case Management Agent to create and update cases (preview)](set-up-autonomous-case-agents.md).
- [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) is configured.
- For the AI agent to send emails and resolve cases autonomously, you must set up a dedicated application user to send and receive emails on behalf of your organization. Perform the following steps:
   1. [Create](/entra/identity-platform/quickstart-create-new-tenant#create-a-new-microsoft-entra-tenant) and [register a single-tenant application registration](/entra/identity-platform/quickstart-register-app#register-an-application) in the Azure portal. Copy the values of **Client ID**, **Client Secret**, and **Tenant**.
   2. [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) with Customer Service Representative role in Power Platform admin center.
   3. Create a shared mailbox in Exchange Online. Learn more in [Shared mailboxes in Exchange Online](/exchange/collaboration-exo/shared-mailboxes).
   4. Assign the shared mailbox email id to the application user in Power Platform admin center. Learn more in [Manage email settings](/power-platform/admin/settings-email). This application user is used in Copilot Service admin center to receive and send responses.
   5. In Copilot Studio, select Case Processing Agent in **Agents** and create a connection reference with the following data. Learn more in [Configure and manage connections](/microsoft-copilot-studio/authoring-connections).
       - **Authentication Type**: Service Principal
       - Specify the **Client ID**, **Client Secret**, and **Tenant** that you've copied in the earlier step.
       - Publish the agent. 
       
## Configure global settings

In Copilot Service admin center, add the global settings for a fully-autonomous case flow. You can specify the user the AI agent should use to send and receive emails, the default Copilot template, and if the AI agent must use Copilot recommended template to draft emails. Perform these steps for the fully-autonomous case resolution process:

1. Select **Manage** for **Case Management Agent** in **Case settings**. The **Case Management Agent** page appears.
1. Select **Manage** for **Global settings**. The Global settings (preview) page appears.
1. Set the **Application user** to the application user created in the prerequisites section. This is the user that the AI agent uses to send and receive emails on behalf of your organization.
1. Select **Use copilot recommended template for drafting emails**. 
1. Optionally, you can set the **Default email template** dropdown to a template the AI agent uses when Copilot email template recommendations are unavailable. If you configured Copilot recommended email templates and [line-of-business segregated email templates](configure-lob-email-templates.md), the system uses the default email template when no line-of-business email template is available for the case. 
If you don't select a default template and Copilot recommended email templates is configured, after the agent identifies the intent, it sends emails using the [Copilot inline email assist capabilities](/dynamics365/contact-center/use/use-copilot-email#use-copilot-to-draft-an-email).

## Configure level of automation 

In Copilot Service admin center, follow these steps to configure the automation level for each line of business:

1. Select **Manage** for **Case Management Agent** in **Case settings**. The **Case Management Agent** page appears.
1. Select **Manage** for **Case Resolution**. The Case Resolution Agent (preview) page appears.
1. In **Level of automation per LOB**, the lines of business you configured in the Customer Intent Agent appear. Select the required line of business and then select **Edit**. You can specify the following automation levels for each line of business:
   - **Full**: The AI agent automatically resolves cases.
   - **Require agent confirmation**: The AI agent drafts email responses, but requires a representative to review and send the email.
   - **Disabled**: The agent doesn't draft email responses. 

### Record representative interactions with the AI agent

 You can select **Record service representative interactions with AI, including agent actions and their feedback on AI suggestions** to record and understand how representatives are interacting with the AI agent and how the agent is performing in a support organization. You can also download and use the data to analyze knowledge sources, and build usage reports.

## How autonomous case resolution works

The case management agent triggers the case resolution process for an incoming customer email associated with a case.

| Scenario | Fully autonomous | Semi-autonomous |
|----------|------------------|-----------------|
| Incoming customer email | <ol><li> A case is created and is routed to the AI mailbox.</li><li>The case resolution process is triggered. Based on the email content, the AI agent follows one of the following paths: 
<ul><li>Can't identify customer's intent</li><li>Identifies case intent, but requires additional information</li><li>Identifies the case intent and determines that the information is sufficient to resolve the case.</li></ul></li></ol> | <ol><li> A case is created and is routed to the service representative's mailbox.</li><li>The case resolution process is triggered. Based on the email content, the AI agent follows one of the following paths: 
<ul><li>Can't identify customer's intent</li><li>Identifies case intent, but requires additional information</li><li>Identifies the case intent and determines that the information is sufficient to resolve the case.</li></ul></li></ol> |
| Can't identify intent | Sends an email to the customer requesting additional information. Based on the customer's response, the agent follows one of the paths: <ul><li>Identifies case intent, but requires additional information</li><li>Identifies the case intent and determines that the information is sufficient to resolve the case.</li></ul>. Invokes the [update functionality](../use/use-case-creation-agent.md#autonomous-case-updates) of the Case Management Agent, if configured, to update the case fields, based on the customer's response.| Drafts an email to the customer requesting additional information. A service representative reviews and sends the email to the customer. Based on the customer's response, the agent follows one of the paths: <ul><li>Identifies case intent, but requires additional information</li><li>Identifies the case intent and determines that the information is sufficient to resolve the case.</li></ul>. Invokes the [update functionality](../use/use-case-creation-agent.md#autonomous-case-updates) of the Case Management Agent, if configured, to update the case fields, based on the customer's response. |
| Identifies case intent, but requires additional information to provide a resolution based on the attributes linked to the intent. | Sends an email to the customer requesting additional information. Based on the customer's response the case resolution agent either sends an email to the customer with the resolution or sends another email requesting additional information. Invokes the update functionality of the Case Management Agent to update the case fields, based on the customer's response. | Drafts an email to the customer requesting additional information. Based on the customer's response the case resolution agent either drafts an email to the customer with the resolution or another email requesting additional information. Invokes the update functionality of the Case Management Agent to update the case fields, based on the customer's response. |
| Identifies the case intent and determines that the information is sufficient to resolve the case. | Generates a solution and sends an email to the customer with resolution details.<ul><li>If the customer accepts the resolution, the AI agent sets the status of the case to **Resolved**. Invokes the [case follow-up](../use/use-case-follow-up-closure.md#use-autonomous-follow-up-and-closure-of-cases) functionality to follow up with the customer for case, if case-follow up and closure is configured for the Case Management Agent.</li><li>If the customer needs further assistance, the agent routes the case to a service representative.</li></ul> | Drafts a solution and sends an email to the customer with resolution details. If the customer accepts the resolution, the case resolution agent sets the status of the case to resolved. Invokes the case follow-up functionality to follow up with the customer for case. |
  
   > [!NOTE]
   > - The AI agent selects an appropriate email template using Copilot recommended templates and [line-of-business specific templates](configure-lob-email-templates.md#runtime-experience) to draft email responses.
   > - If no email template is available, the AI agent uses the default email template configured in the global settings.

## Integrate Case Management Agent with custom Copilot Studio agents 

You can integrate the Case Management Agent with custom Microsoft Copilot Studio agents to enhance the case resolution process. For example, you can create a custom agent that provides additional context or performs specific actions based on the case details. Learn more in [Integrate Case Management Agent with custom Copilot Studio agents](../develop/case-management-agent-integration.md).

## Related information

[Use Case Management Agent to resolve cases (preview)](../use/use-case-resolution-agent.md)