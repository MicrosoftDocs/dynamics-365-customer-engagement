---
title: Set up and configure the Sales Close Agent - Engage (preview)
description: Set up and configure the Sales Close Agent - Engage to help your sales team engage with customers effectively.
ms.date: 11/28/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up and configure the Sales Close Agent - Engage (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can set up the autonomous Sales Close Agent - Engage type to help sales teams manage records efficiently without manual intervention. Once configured, you can only edit configurations if needed.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Ensure that the following prerequisites are met:  

- Your tenant admin has configured the following settings in Power Platform Admin Center:
  
    - Copilot Studio capacity to run the agent. Ensure that you have enough capacity. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).
    - AI Agents in Dynamics 365 Sales is turned on for your environment. Learn more in [Turn on AI capabilities in Dynamics 365 Sales](/power-platform/admin/copilot/copilot-hub#turn-on-ai-capabilities-in-dynamics-365-sales).
    - AI prompts feature is enabled. Learn more in [Enable AI prompts in Power Platform and Copilot Studio](/ai-builder/administer#enable-or-disable-ai-prompts-in-power-platform-and-copilot-studio).  
    - AI insight cards is turned on. This feature is required for sellers to get notified about records handovers and view insights on the record. Learn more about turning on this feature in [Manage feature settings](/power-platform/admin/settings-features).

- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).  

- You modified Data policies to allow the following connectors:

    | Connector | Why is it required? |
    |-----------|---------------------|
    | Knowledge source with public websites and data | The agent needs it to access public data for enrichment. |
    | Microsoft Copilot Studio | Copilot Studio is the core platform for building and deploying the agent. |
    | Microsoft Dataverse | A data platform that securely stores data from various Microsoft products, allowing agents to access and utilize it. |
    | Knowledge source with SharePoint or OneDrive | Required only if the agent is configured to use internal documents on SharePoint or OneDrive for enrichment. |
    | Knowledge source with documents | Required only if the agent is configured to use internal documents for enrichment. |
    | Direct Line channels in Copilot Studio | Required for the agent to connect to Microsoft Copilot Studio. |

   Learn more in [Manage data policies](/power-platform/admin/prevent-data-loss?tabs=new).  
- You configured server-side synchronization by integrating Dynamics 365 with Exchange. Learn more in [Set up email by integrating with Exchange](configure-email.md). If server-side synchronization isn't set up, the agent doesn't generate outreach emails or engage with customers.  
- You enabled in-app notifications to notify sellers and supervisors about record handovers. Learn more in [Enable in-app notifications for your organization](/power-apps/developer/model-driven-apps/clientapi/send-in-app-notifications?tabs=clientapi#enable-the-in-app-notification-feature).  
- (Optional but recommended) You turned on Copilot in Dynamics 365 Sales to allow your sellers to get a 360-degree view of the record and their company. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md) and [Get information from Copilot](copilot-get-information.md).  

## Considerations

Review the following considerations before you start deploying the autonomous Sales Close Agent - Engage type:  

- Only one instance of each agent type can be deployed in an environment. For example, if you have already deployed the Sales Close Agent - Research type in your environment, you can also deploy the Sales Close Agent - Engage type in the same environment. However, you can't deploy two instances of the Sales Close Agent - Engage type in the same environment.  
-	Deactivation of the agent will prevent new records from being assigned/processed by the agent. Existing records which are already in pipeline (orchestration), will continue until the record is handed over for next steps.  
-	You can’t delete an agent once configured. Contact your Microsoft support to delete the agent from your organization.  
-	Once an agent is published, we recommend only a few select fields to be edited.  Sections that have tag Avoid edits should not be edited as it can lead to the agent being in bad state.  

## Grant permissions to custom security role

If you're using custom security roles for your sales team instead of the out-of-the-box roles, you have two options.  

- Grant the necessary permissions, listed in the following table, to the custom role. This option is recommended if you want to allow all the users with the custom role to work on contacts handed over by the agent.  
- Assign the out-of-the-box roles—Salesperson or Sales Manager—only to users who'll be working on contacts handed over by the agent. This option is recommended if you want to allow only a subset of users to work on the agent-handed-over contacts.

**Permissions required for custom security roles:**

| Entity name (Logical name) | Permissions |
|----------------------------|-------------|
| Email Activity (email) | **User-level**: Read, Write, Create, Append, Append To |
| Contact (contact) | **User-level**: Read, Append, Append To |
|Sales Agent Profile (msdyn_salesagentprofile)<br>Sales Agent Run (msdyn_salesagentrun)<br>Sales Agent Configuration v2 (msdyn_salesagentconfigurationv2) | **Global-level**: Read |
| SCA Engage Agent Result (msdyn_dcaengageagentresult) | **Basic-level**: Read, Write |

Learn more about granting permissions in [Define the privileges and properties of a security role](/power-platform/admin/security-roles-privileges?tabs=new#define-the-privileges-and-properties-of-a-security-role).

The following image shows the permissions to access research insights as an example:

:::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the permissions to grant to a custom security role for use with the Sales Qualification Agent in Dynamics 365 Sales.":::  

## Set up the Sales Close Agent - Engage

As an administrator, you can set up the autonomous Sales Close Agent - Engage to help sales teams manage records efficiently without manual intervention. Once configured, you can only edit configurations if needed. There are two ways to set up the agent:  

- **AI assisted setup**: A guided experience that helps you set up the agent step-by-step.  
- **Manual setup**: A detailed guide that walks you through each configuration step.  

### AI assisted setup

The AI Setup Assistant, streamlines the setup process for the Sales Close Agent – Engage type. Traditionally, configuring agent is a time-consuming task due to the complexity and number of steps involved. The Setup Assistant addresses this challenge by delivering structured guidance, significantly reducing the friction and time typically required for setup.  
To begin the AI-assisted setup, follow these steps:  

1. [Open the Sales Close Agent - Engage setup assistant page](sales-close-agent-engage-setup-assistant.md).  
1. Choose a setup mode (Quick setup or Guided setup) and follow the on-screen instructions to complete the setup process.  
1. Set up the agent by following the prompts provided by the AI Setup Assistant.  

### Manual setup

Helps you set up the Sales Close Agent - Engage manually by configuring various sections such as agent profile, product details, target customers, email delivery, email content, and knowledge sources. Each section has specific configurations that need to be completed for the agent to function effectively. When all the configurations are properly set up, a green check mark is displayed beside each section. Before you start the agent ensure that all the sections are marked green.  
Let's look at the steps to set up and configure the agents.  

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. Configure the following prerequisites before you set up the agent.  
    - [Create an app in Azure](configure-requirements-for-sqa-agent.md#create-application-in-azure)
    - [Create an app user in Dataverse and assign AISalesPerson role](configure-requirements-for-sqa-agent.md#create-an-app-user-in-dataverse-and-assign-aisalesperson-role)
    - [Create a shared mailbox](configure-requirements-for-sqa-agent.md#create-a-shared-mailbox)
    - [Configure server-side synchronization](configure-requirements-for-sqa-agent.md#configuring-server-side-synchronization)  
1. [Configure the agent profile](configure-sales-close-agent-profile.md) for agent such as profile, company info, and email signature.  
1. [Configure the product details](configure-sales-close-agent-product-details.md) that the agent uses to recommend products during customer interactions.  
1. [Configure target customers](configure-sales-close-agent-target-customers.md) for the agent to process the records.  
1. [Configure email delivery](configure-sales-close-agent-email-delivery.md) for the agent to send outreach and follow-up emails to customers.  
1. [Configure email content](configure-sales-close-agent-email-content.md) that the agent uses for outreach and follow-up emails.  
1. [Configure knowledge sources](configure-sales-close-agent-knowledge-sources.md) that the agent uses to enrich customer interactions.  
1. After you are satisfied with the configuration, [start the agent](start-sales-close-agent.md).

## Related information

[Sales Close Agent overview (preview)](sales-close-agent.md)  
