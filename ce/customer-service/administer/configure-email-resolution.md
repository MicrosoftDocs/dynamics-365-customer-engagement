---
title: Configure email resolution to resolve customer issues (preview)
description: Learn how to set up email resolution in Dynamics 365 Customer Service to automatically analyze incoming emails and respond without creating cases.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 07/07/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure email resolution to resolve customer issues (preview)

[!INCLUDE [cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Use email resolution to analyze incoming customer emails and respond directly from the email channel without creating a case.

Email resolution is a feature that applies Case Management Agent capabilities to analyze customer intent and draft responses.

When a customer sends an email, email resolution performs the following actions: 
- Identifies the customer’s intent based on the email content.
- Generates an email to request more information or drafts a suggested or final resolution.
- Sends the response autonomously.
- If the issue can't be resolved, creates a case for a customer service representative to work on and associates the email with the case.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Data movement is set up for your environment in Power Platform admin center. Learn more in [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot).
- The Power Platform [pay-as-you-go plan](/power-platform/admin/pay-as-you-go-overview) requires an Azure subscription for the system to charge when the agent runs. Make sure [consumption-based billing](setup-pay-as-you-go.md) is set up.
- Configure [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- The guided setup for autonomous email resolution is completed. Learn more in [Configure Case Management Agent](case-management-global-settings.md).
- To configure the fully autonomous email resolution flow, [create the application user and set up the shared mailbox](set-up-case-resolution-agent.md#set-up-an-application-user-and-shared-mailbox).

## Enable email resolution

Complete the following steps:

1. In Copilot Service admin center, select **Email settings**.
1. On the **Email settings** page, select **Manage** next to **Email resolution (preview)**. The **Email Resolution (preview)** page appears.
1. Set the **Turn on email resolution** toggle to **On**.
1. In **Select the application user for email management**, select the user you want to reply to emails and create a case autonomously if needed from the **Application user** dropdown.
1. In the **LOB (lines of business) deployment settings** section, select the checkbox next to a category for which you want to edit the deployment settings. The **Configure LOB (lines of business) deployment settings** pane appears, where you can edit the settings for the following features:
   - **LOB (lines of business)**
   - **Deployment status**
1. If you want to use the **Copilot-recommended template**, select the **Use Copilot-recommended template for drafting emails** check box, and then select the default template you want to use from the dropdown menu.
   > [!NOTE]
   > To use this setting, email template recommendations must be enabled.
1. In **Language settings**, select the single language to use for all emails from the dropdown menu.
1. Save your changes.

## Runtime behavior 

After you configure email resolution, the following actions occur:

- Email resolution runs when an incoming email from a customer matches the email rules configured for a line of business in Customer Intent Agent.
- Email resolution uses Customer Intent Agent to identify the intent from the incoming email.
- Email resolution uses case resolution capabilities and available knowledge to generate a response. 
- Based on your configuration, email resolution sends responses autonomously. 
- If the issue isn't resolved, email resolution creates a case for a service representative to address.

## Related information

[Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md)

