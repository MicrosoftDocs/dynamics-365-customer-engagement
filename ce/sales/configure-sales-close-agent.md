---
title: Set up and configure the Sales Close Agent - Engage (preview)
description: Set up and configure the Sales Close Agent - Engage to help your sales team engage with customers effectively.
ms.date: 09/24/2025
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

As an administrator, you can set up the autonomous Sales Close Agent - Engage to help sales teams manage leads efficiently without manual intervention. Once configured, you can only edit configurations if needed.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Ensure that the following prerequisites are met:  

- Your tenant admin has granted the consent for the agent to run Copilot Studio capacity. Ensure that you have enough capacity. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).  
- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).  
- You turned on the AI prompts feature in Power Platform and Copilot Studio. Learn more in [Enable AI prompts in Power Platform and Copilot Studio](/ai-builder/administer#enable-or-disable-ai-prompts-in-power-platform-and-copilot-studio).  
- You turned on the AI insight cards in Power Platform Admin Center. This feature is required for sellers to get notified about lead handovers and view insights on the lead record. Learn more about turning on this feature in [Manage feature settings](/power-platform/admin/settings-features).
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
- You configured server-side synchronization by integrating Dynamics 365 with Exchange. Learn more in [Set up email by integrating with Exchange](configure-email.md). If server-side synchronization isn't set up, the agent doesn't generate outreach emails or engage with leads.  
- You enabled in-app notifications to notify sellers and supervisors about lead handovers. Learn more in [Enable in-app notifications for your organization](/power-apps/developer/model-driven-apps/clientapi/send-in-app-notifications?tabs=clientapi#enable-the-in-app-notification-feature).  

## Considerations

Review the following considerations before you start deploying the autonomous Sales Close Agent - Engage:  

- **Only one agent can be deployed in an environment**.  
-	**Deactivation** of the agent will prevent new records from being assigned/processed by the agent. Existing records which are already in pipeline (orchestration), will continue until the record is handed over for next steps.  
-	You can’t **delete** an agent once configured. Contact your Microsoft support to delete the agent from your organization.  
-	Once an agent is published, we recommend only a few select fields to be **edited**. Sections that have tag **Avoid edits** should not be edited as it can lead to the agent being in bad state.  

## Grant permissions to custom security role

If you're using custom security roles for your sales team instead of the out-of-the-box roles, you have two options. 

- Grant the necessary permissions, listed in the following table, to the custom role. This option is recommended if you want to allow all the users with the custom role to work on leads handed over by the agent.

- Assign the out-of-the-box roles&mdash;Salesperson or Sales Manager&mdash;only to users who'll be working on leads handed over by the agent. This option is recommended if you want to allow only a subset of users to work on the agent-handed-over leads.

**Permissions required for custom security roles:**

| Purpose | Entity name (Logical name) | Permissions |
|---------|----------------------------|-------------|
| Access research insights | Sales Copilot Email Insight (msdyn_salescopilotemailinsight) <br> Sales Copilot Insight (msdyn_salescopilotinsight) <br> Sales Copilot Insight Card State (msdyn_salescopilotinsightcardstate) | **User**: Read, Write, Create, Append, Append To, Assign |
| Access leads handed over by the agent | Sales Agent Handover (msdyn_salesagenthandover) | **Global**: Read <br> **Basic**: Append, Append To, Assign, Write, Create, Delete, Share |
| Access outreach emails generated by the agent | Email Activity (email) <br> Lead (lead) | **User**: Read, Create (Email Activity) <br> **User**: Append, Append To (Lead) |
| View in-app notifications upon lead handover | Notification (appnotification) | **Basic**: Read |

Learn more about granting permissions in [Define the privileges and properties of a security role](/power-platform/admin/security-roles-privileges?tabs=new#define-the-privileges-and-properties-of-a-security-role).

The following image shows the permissions to access research insights as an example:

:::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the permissions to grant to a custom security role for use with the Sales Qualification Agent in Dynamics 365 Sales.":::  

## Set up the Sales Close Agent - Engage

As an administrator, you can set up the autonomous Sales Close Agent - Engage to help sales teams manage leads efficiently without manual intervention. Once configured, you can only edit configurations if needed.  
When all the configurations are properly set up, a green check mark is displayed beside each section. Before you start the agent ensure that all the sections are marked green.  
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
