---
title: Set up and configure AI-powered Data Enrichment
description: Learn how to set up and configure the AI-powered Data Enrichment feature for opportunity records in Dynamics 365 Sales.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/16/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Set up and configure AI-powered Data Enrichment

As an admin, you can configure AI-powered Data Enrichment to work on specific opportunity records and set preferences for how updates are applied.

## Prerequisites

Ensure that you meet the following prerequisites:

- You marked the prerequisites common to all Sales agents as **Done**. For more information, see [Prerequisites for all Sales agents](prerequisites-for-all-agents.md).
- You have the appropriate Dynamics 365 Sales license. Check out the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/?linkid=2152923) to know more about licensing requirements.
- You have admin privileges in Dynamics 365 Sales.
- If you have custom fields that you want the agent to enrich, ensure that these fields have a meaningful name and description to help the agent understand their purpose and provide accurate suggestions.

## Set up and configure AI-powered Data Enrichment

1. From the Sales Hub app, navigate to **App Settings**.

1. Under **General Settings**, select **Dynamics 365 AI Hub** and then select **Create and manage agents**.
1. In the **AI Agents** page, select **Create**.  
   If the **Create** button is disabled, select the **Prerequisites** button next to it to ensure that all the common prerequisites are met.
1. Select **Data Enrichment** from the list of available AI agents.
   A dialog opens with a quick tour of the Data Enrichment feature and the option to create the agent.
1. Select **Next** to get a quick tour of the feature or select **Skip** to get started with the agent configuration.
1. In the **Set up required prerequisites** dialog, configure the following prerequisites:
   > [!NOTE]
   > Sales Opportunity Agent and Data Enrichment use the same Microsoft 365 Services and Dataverse Search configuration. If you have already configured these prerequisites for Sales Opportunity Agent, they will be marked as done for Data Enrichment too.
   
   - - **Dataverse Search**: Data Enrichment uses Dataverse Search to find and enrich records in Dynamics 365 Sales. If you didn't set up Dataverse Search, select **Set up** to open the **Features** page in Power Platform admin center. Learn more about [configuring Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization). After setting up Dataverse Search, return to the agent configuration page and select **Refresh** to update the status of this prerequisite. 
  
   - **Microsoft 365 Services**: To allow the agent to read seller emails and fetch relevant data for enrichment, select **Mark as done** and then **Apply changes**. Sellers are prompted to provide consent the first time they access the **Opportunity** page. This method reads emails in place without storing them in CRM. The agent uses emails from Microsoft 365 to generate suggestions for opportunity records.
   
     To configure and use Microsoft 365 Services, you need:
     - At least one of the following roles: Global administrator, Dynamics 365 administrator, or similar.
     - At least one of the following licenses: Microsoft 365/Office 365, Power Automate Premium, or Dynamics 365 Sales Enterprise Edition.

1. Select **Create agent**.
   The Start your Data Enrichment with recommended defaults dialog opens with recommended default settings:    
    :::image type="content" source="media/data-enrichment-quick-setup.png" alt-text="Screenshot of the Data Enrichment quick setup dialog box with recommended default settings.":::
    The default settings include:

    | Setting | Value |
    |---------|-------|
    | User access | All premium users in your organization |
    | Target records | Active Opportunities created in the last 30 days |
    | Action | Enrich BANT-related fields in the opportunity record |
    | Schedule | Runs everyday |
    | Behavior | Suggests field updates based on email conversations (seller approval required) |
    | Data sources | Email, Outlook |
    
1. Do *ONE* of the following:
    - Review the recommended settings and select **Start agent** if the default settings work for your business needs. 
    - Select **Edit in settings** to customize the configuration. Learn more about configuring the settings in the [Configure AI-powered Data Enrichment settings](data-enrichment-agent-edit-settings.md) article.


## Related information

[Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md)