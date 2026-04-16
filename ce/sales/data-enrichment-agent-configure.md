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
  
   - **Microsoft 365 Services**: To allow the agent to read seller emails and fetch relevant data for enrichment, select **Mark as done** and then **Apply changes**. Sellers are prompted to provide consent the first time they access the **Opportunity** page. This method reads emails in place without storing them in CRM. The agent uses emails from both Microsoft 365 and Dataverse to generate suggestions for opportunity records.
   
     To configure and use Microsoft 365 Services, you need:
     - At least one of the following roles: Global administrator, Dynamics 365 administrator, or similar.
     - At least one of the following licenses: Microsoft 365/Office 365, Power Automate Premium, or Dynamics 365 Sales Enterprise Edition.

1. Select **Create agent**.
   The Start your Data Enrichment with recommended defaults dialog opens with recommended default settings for the agent profile, user access, record selection, and agent behavior.    
    :::image type="content" source="media/data-enrichment-quick-setup.png" alt-text="Screenshot of the Data Enrichment quick setup dialog box with recommended default settings.":::
1. Do *ONE* of the following:
    - Review the recommended settings and select **Start agent** if the default settings work for your business needs. 
    - Select **Edit in settings** to customize the configuration:
 
       1. [Define the agent profile](#define-the-agent-profile)
       1. [Configure user access](#configure-user-access)
       2. [Select records for enrichment](#select-records-for-enrichment)
       3. [Configure agent behavior](#configure-agent-behavior)
       4. After configuring the settings, select **Apply changes** and then **Start agent** to activate Data Enrichment with your specified configuration.

  The agent doesn't analyze any opportunity records or emails until sellers [provide consent](use-data-enrichment-agent.md#provide-consent-for-data-enrichment-to-read-your-emails) to read their emails. The consent is specific to each seller. 

<a name="open-settings"></a>
## Open the Data Enrichment settings page

To review or modify the Data Enrichment settings after the agent has been created, follow these steps:

1. From the Sales Hub app, navigate to **App Settings**.
1. Under **General Settings**, select **Dynamics 365 AI Hub** and then select **Create and manage agents**.
1. In the **AI Agents** page, select the agent with type **Conversation Enrichment**.

### Define the agent profile

In the **Agent profile** section of the [Data Enrichment settings](#open-settings), specify the name and description. This name helps identify the agent in the list of AI agents.

### Configure user access

In the **User access** section of the [Data Enrichment settings](#open-settings), specify which sellers can access Data Enrichment suggestions. Data Enrichment analyzes only opportunities owned by selected sellers, and only those sellers can view the suggestions. You can choose one of the following options:
 
- **All users with premium license**: Select this option to allow all users with a Dynamics 365 Sales Premium license to access the agent's suggestions.
- **Specific groups**: Select this option to allow specific sellers (up to 10 of them) or those who meet certain criteria to access the agent's suggestions. You can either select individual users or specify criteria based on fields such as sales team, job title, or geography to determine who can access the agent's suggestions.  


### Select records for enrichment

In the **Record selection** section of the [Data Enrichment settings](#open-settings), define the criteria for the opportunity records that Data Enrichment will analyze. You can use filters based on fields in the opportunity entity or a related entity. 

The record selection criteria are applied in addition to the user access criteria defined in the previous section. For example, if you select specific groups in the user access settings and set a filter for opportunities created within a certain date range, only the opportunities that meet both criteria will be analyzed and enriched by the agent.

### Configure agent behavior

In the **Agent behavior** section of the [Data Enrichment settings](#open-settings), choose how Data Enrichment should handle updates:

- **Field scope**: Select the fields that you don't want Data Enrichment to enrich. These could be fields that are critical to your business processes or those that you prefer to manage manually. Some fields are excluded from enrichment by default and cannot be modified. See [Fields excluded from enrichment](#fields-excluded-from-enrichment) for more details.  
- **Field update behavior**: Turn on **Automatically update fields** to allow Data Enrichment to make changes without a manual review. By default, this option is off, meaning sellers need to review and apply suggestions manually.
- **Enrichment frequency**: Indicates how often Data Enrichment applies updates automatically. The agent analyzes emails and generates suggestions every 4 hours. For manual updates, sellers can review suggestions as soon as they're generated. For automatic updates, changes are applied based on the enrichment frequency, which is set to **Daily** by default. This setting is informational and can't be changed.
- **Data sources**: Shows the data sources that Data Enrichment will use to analyze and enrich opportunity records. It currently uses email interactions in Dataverse to gather context about opportunities and suggest updates. This field is informational and cannot be changed.

## Fields excluded from enrichment

The following fields are excluded from enrichment by default and cannot be modified:

- Opportunity Name

- Opportunity State
- Fields with the following attribute types: Uniqueidentifier, Virtual, Lookup, Customer, Owner, PartyList, CalendarRules, ManagedProperty, EntityName
- Read-only fields and system fields
