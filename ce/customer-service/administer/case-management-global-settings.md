---
title: Configure global settings for Case Management Agent 
description: Learn how to configure global settings for Case Management Agent in Dynamics 365 Customer Service to enable fully autonomous case resolution, follow-up, and closure capabilities.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days 
ms.date: 02/20/2026
ms.custom: bap-template
---

# Configure Case Management Agent 

Case Management Agent enables organizations to automate case lifecycle processes, including creation, updates, resolution, follow-up, and closure. The Case Management Agent has the following flows that you can configure to work together as a seamless end-to-end process, or set them up individually to address specific stages of the case lifecycle.

**Case creation and update**: The agent processes incoming customer requests to create comprehensive case records. It automatically extracts key details to populate relevant fields and updates case data as new information is received.

**Case resolution**: By analyzing the case context and referencing organizational knowledge bases, the agent formulates accurate resolution steps, surfaces relevant resources, and drafts tailored responses to the customer.

**Case follow-up and closure**: The agent manages the post-resolution cadence. It can generate follow-up communications to ensure customer satisfaction, create concise case summaries for future reference, and automatically close the case record once all requirements are met.

## Prerequisites

- An Azure account that has an active subscription.
- You have the [Application Developer](/entra/identity/role-based-access-control/permissions-reference#application-developer) role to create app registrations.
- You have the CSR Manager or Customer Service Representative role.

[!INCLUDE[enable-ai-agents-ppac](../../includes/ai-features/enable-ai-agents-ppac.md)]


## Setup Case Management Agent

The AI agent requires a dedicated application user to send emails and resolve cases autonomously. This application user handles all email communication on behalf of your organization. Do the steps in the following sections in the order specified.

The global settings, such as connection references or Power Automate flows, appear on the **Case Management Agent** page with the current status under the **Prerequisites** section. Use the options to quickly navigate to the settings that need to be configured for Case Management Agent. You can navigate to the **Case Management Agent** page as follows:

1. Select **Case settings** in **Customer support**.
1. Select **Manage** for **Case Management Agent** in the Case Settings page. 

Select **Manage** for the required flow you want to configure.

## Determine level of automation

For case resolution and follow-up, you can configure the agent to function in one of the following modes:

- **Semi-autonomous (Human-in-the-loop)**: The AI agent acts as an assistant. It suggests resolutions and drafts follow-up emails, which a customer service representative must review and approve.

- **Fully autonomous**: The agent performs end-to-end actions without human intervention.

To configure fully autonomous flows, you must configure an application user and a shared mailbox. Through the application user, agents manage autonomous cases and handle customer correspondence. For automated outbound emails, a Shared Mailbox is used to ensure messages come from a centralized address.

Perform the following steps.

### Create an application user in Power Platform admin center

The application user you create in Power Platform admin center is used to receive and send responses. Perform the following steps:

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com) and perform the steps in [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) to create a new application user.
1. Assign the Customer Service Representative role to the application user.

### Assign a shared mailbox to the application user

1. Go to [Microsoft 365 admin center](https://admin.cloud.microsoft/) and do the steps 1 through 4 in [Create a shared mailbox](/microsoft-365/admin/email/create-a-shared-mailbox#create-a-shared-mailbox-and-add-members). Copy the email  of the shared mailbox.
1. In Power Platform admin center, open the application user that you created in [Create an application user](#create-an-application-user-in-power-platform-admin-center) and set the shared mailbox ID to the email ID you copied in the previous step. Learn more in [View or edit the details of an application user](/power-platform/admin/manage-application-users?tabs=new#view-or-edit-the-details-of-an-application-user).

## Configure individual capabilities

| Feature Area | Operational Mode | Description | Prerequisites | Learn more |
| :--- | :--- | :--- | :--- | :--- |
| **Case Creation and Update** | - | Manage how the agent assists service representatives during the initial intake and continuous updating of case records. | Guided Setup | [Set up Case Management Agent for case creation and update](set-up-autonomous-case-agents.md) |
| **Case Resolution** | Semi-autonomous | AI agent suggests resolutions and drafts emails for service representative review. | Guided Setup | [Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md) |
| **Case Resolution** | Fully autonomous | AI agent automatically resolves cases and emails, based on defined logic. | Guided Setup, Application User, Shared Mailbox | [Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md) |
| **Case Follow-up and Closure** | Semi-autonomous | AI suggests follow-up actions and drafts closure summaries for agent review. | Guided Setup | [Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md) |
| **Case Follow-up and Closure** | Fully autonomous | AI handles the complete follow-up cadence and case closure automatically. | Guided Setup, Application User, Shared Mailbox. If fully autonomous case resolution is configured, the agent uses the configured shared mailbox. | [Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md) |

### Next steps

[Set up Case Management Agent to create and update cases](set-up-autonomous-case-agents.md)  
[Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md)  
[Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md)  
