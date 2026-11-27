---
title: Configure global settings for Case Management Agent 
description: Learn how to configure global settings for Case Management Agent in Dynamics 365 Customer Service to enable fully autonomous case resolution, follow-up, and closure capabilities.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days 
ms.date: 11/26/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Configure Case Management Agent 

Use Case Management Agent to automate case creation, updates, resolution, follow-up, and closure. Configure capabilities individually or combine them into an end-to-end process.

**Case creation and update**: The agent extracts key details from incoming customer requests to create case records and updates case data as it receives new information.

**Case resolution**: The agent analyzes case context and your organization's knowledge bases to generate resolution steps, suggest relevant resources, and draft customer responses.

**Case follow-up and closure**: The agent generates follow-up communications and case summaries, and automatically closes the case when all requirements are met.

## Prerequisites

- An Azure account with an active subscription.
- The [Application Developer](/entra/identity/role-based-access-control/permissions-reference#application-developer) role to create app registrations.
- The CSR Manager or Customer Service Representative role.

[!INCLUDE[enable-ai-agents-ppac](../../includes/ai-features/enable-ai-agents-ppac.md)]


## Set up Case Management Agent

The AI agent requires a dedicated application user to send emails and resolve cases autonomously. This application user handles all email communications on behalf of your organization. Complete the steps in the following sections in order.

On the **Case Management Agent** page, the **Prerequisites** section shows global settings, such as connection references and Power Automate flows, and their current status. Use these options to open settings that need configuration. To open the **Case Management Agent** page:

1. Select **Case settings** in **Customer support**.
1. Select **Manage** for **Case Management Agent** on the **Case Settings** page.

Select **Manage** for the flow you want to configure.

## Determine the level of automation

For case resolution and follow-up, you can configure the agent to function in one of the following modes:

- **Semi-autonomous (human-in-the-loop)**: The AI agent suggests resolutions and drafts follow-up emails, which a customer service representative (service representative or representative) must review and approve.

- **Fully autonomous**: The agent performs end-to-end actions without human intervention.


## Configure individual capabilities

| Feature area | Operational mode | Description | Prerequisites | Learn more |
| :--- | :--- | :--- | :--- | :--- |
| **Case creation and update** | - | Manage how the agent assists service representatives with creating and updating case records. | Guided setup | [Set up Case Management Agent for case creation and update](set-up-autonomous-case-agents.md) |
| **Case resolution** | Semi-autonomous | The AI agent suggests resolutions and drafts emails for service representative review. | Guided setup | [Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md) |
| **Case resolution** | Fully autonomous | The AI agent automatically resolves cases and handles emails based on defined logic. | Guided setup, application user, shared mailbox | [Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md) |
| **Case follow-up and closure** | Semi-autonomous | The AI agent suggests follow-up actions and drafts closure summaries for service representative review. | Guided setup | [Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md) |
| **Case follow-up and closure** | Fully autonomous | The AI agent handles follow-up and case closure automatically. | Guided setup | [Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md) |

## Next steps

[Set up Case Management Agent to create and update cases](set-up-autonomous-case-agents.md)  
[Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md)  
[Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md)  
