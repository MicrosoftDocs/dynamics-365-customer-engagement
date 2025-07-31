---
title: Set up and configure the Sales Qualification Agent
description: Learn how to activate and set up the Sales Qualification Agent in Dynamics 365 Sales to help your sellers use AI for effective lead qualification.
ms.date: 07/31/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up and configure the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an admin, you need to set up the Sales Qualification Agent before your sellers can use it for lead research, ideal customer profile (ICP) fit assessment, and initial email outreach. This article discusses how to configure the details about your company and products you sell, your ideal customer profile, and other settings to help the agent align with your company's sales strategy and goals.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Ensure that the following prerequisites are met:  

- Your tenant admin has granted the following consent:  
    - Consent for data movement across regions and Bing search. Learn more in [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot?tabs=new).  
    - The agent needs Copilot Studio capacity to run. Ensure that you have enough capacity. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).  
- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).  
- You modified Data Loss Prevention (DLP) policies to allow the following connectors:

    | Connector | Why is it required? |
    |-----------|---------------------|
    | Knowledge source with public websites and data | The agent needs it to access public data for enrichment. |
    | Microsoft Copilot Studio | Copilot Studio is the core platform for building and deploying the agent. |
    | Knowledge source with SharePoint or OneDrive | Required only if the agent is configured to use internal documents on SharePoint or OneDrive for enrichment. |
    | Knowledge source with documents | Required only if the agent is configured to use internal documents for enrichment. |

   Learn more in [Configure data loss prevention policies for agents](/microsoft-copilot-studio/admin-data-loss-prevention).  
- You configured server-side synchronization by integrating Dynamics 365 with Exchange. Learn more in [Set up email by integrating with Exchange](configure-email.md). If server-side synchronization isn't set up, the agent doesn't generate outreach emails.  
- You enabled in-app notifications to notify sellers and supervisors about lead handovers. Learn more in [Enable in-app notifications for your organization](/power-apps/developer/model-driven-apps/clientapi/send-in-app-notifications?tabs=clientapi#enable-the-in-app-notification-feature).  
- (Optional but recommended) You turned on Copilot in Dynamics 365 Sales to allow your sellers to get a 360-degree view of the lead and their company. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md) and [Get information from Copilot](copilot-get-information.md).

## Considerations

Review the following considerations before you start deploying the autonomous Sales Qualification Agent:

- Only one of the following modes can be deployed in an organization:  
    - **Research-only mode**: Analyzes assigned leads and drafts outreach email based on the insights and provides recommended actions.  
    - **Research and engage mode**: Analyzes and autonomously engages with the customer. Hands over the leads to sellers with detected purchase interest and customer profile fit based on configured handover criteria.  
- You can **upgrade** from **Research-only** mode to the **Research and engage** mode later, but not the other way around.  
- **Stopping the agent** will prevent new leads from being assigned/processed by the agent. Existing leads which are already in pipeline (orchestration), will continue until the lead is handed over to seller or supervisor for next steps.  
- You can’t **delete** an agent once configured. Contact Microsoft support to delete the agent from your organization.  
- Once an agent is published, we **recommend** only a few select fields to be edited. Sections that have tag "Avoid edits" should not be edited as it can lead to the agent being in bad state.  

<a name="grant-permissions"></a>

## Grant permissions to custom security role

If you're using custom security roles for your sales team instead of the out-of-the-box roles, you have two options. 

- Grant the necessary permissions, listed in the following table, to the custom role. This option is recommended if you want to allow all the users with the custom role to work on leads handed over by the agent.

- Assign the out-of-the-box roles&mdash;Salesperson or Sales Manager&mdash;only to users who'll be working on leads handed over by the agent. This option is recommended if you want to allow only a subset of users to work on the agent-handed-over leads.

**Permissions required for custom security roles:**

| Purpose | Entity name (Logical name) | Permissions |
|---------|----------------------------|-------------|
| Access research insights | Sales Copilot Email Insight (msdyn_salescopilotemailinsight) <br> Sales Copilot Insight (msdyn_salescopilotinsight) <br> Sales Copilot Insight Card State (msdyn_salescopilotinsightcardstate) | **User**: Read, Write, Create, Append, Append To, Assign |
| Access leads handed over by the agent (Only for Research and engage mode) | Sales Agent Handover (msdyn_salesagenthandover) | **Global**: Read <br> **Basic**: Append, Append To, Assign, Write, Create, Delete, Share |
| Access outreach emails generated by the agent | Email Activity (email) <br> Lead (lead) | **User**: Read, Create (Email Activity) <br> **User**: Append, Append To (Lead) |

Learn more about granting permissions in [Define the privileges and properties of a security role](/power-platform/admin/security-roles-privileges?tabs=new#define-the-privileges-and-properties-of-a-security-role).

The following image shows the permissions to access research insights as an example:

:::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the permissions to grant to a custom security role for use with the Sales Qualification Agent in Dynamics 365 Sales.":::

## Set up Sales Qualification Agent

The Sales Qualification Agent is available in two modes&mdash;Research-only mode and Research and engage mode&mdash;depending on the level of automation you want to achieve. The configuration steps are similar for both types, but the Engage has additional settings such as adding email signature, customized email instructions, and configuring BANT criteria for handover to work autonomously. Let's look at the steps to set up and configure the agents.

**Follow these steps**:

1. [Open the Sales Qualification Agent settings page](open-sales-qualification-agent-settings.md).  
1. Configure the following prerequisites before you set up the agent.  

    |&nbsp; | Research-only mode | Research and engage mode |
    |-------|----------|--------|
    | **Prerequisites** | [Create an app in Azure](configure-requirements-for-sqa-agent.md#create-application-in-azure)<br>[Create an app user in Dataverse](configure-requirements-for-sqa-agent.md#create-an-app-user-in-dataverse)  | [Create an app in Azure](configure-requirements-for-sqa-agent.md#create-application-in-azure)<br>[Create an app user in Dataverse](configure-requirements-for-sqa-agent.md#create-an-app-user-in-dataverse)<br>[Create a shared mailbox](configure-requirements-for-sqa-agent.md#create-a-shared-mailbox)<br>[Configure server-side synchronization](configure-requirements-for-sqa-agent.md#configuring-server-side-synchronization) |  

1. [Configure general information](sales-qualification-agent-general-settings.md) for agent such as profile, company info, and products.  
1. [Configure selection criteria](sales-qualification-agent-selection-criteria.md) for the agent process the leads.  
1. [Configure email instructions and address validation](sales-qualification-agent-email-instruction-validation.md) for the agent.
1. [Configure handoff criteria](configure-sales-qualification-agent-handoff-criteria.md) for the agent to identify leads that are a good fit for further engagement.  
1. [Configure assignment rules](configure-sqa-assignment-rules.md) for the agent to assign processed leads to the appropriate sellers.  
1. [Configure knowledge sources](configure-sqa-knowledge-source.md) for research insights, outreach, and follow-up emails.
1. (**Engage only**) [Run simulation to review the agent's outreach emails](run-simulation-sqa-outreach-email.md) are customized and relevant to the leads.  
1. After you are satisfied with the configuration, [start the agent](start-sales-qualification-agent.md).

## View the agent's usage consumption

After the agent is published, you can start monitoring the capacity it consumes and how much capacity is left. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new)

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq.md)
- [Qualify leads with the Sales Qualification Agent](use-sales-qualification-agent.md)
