---
title: Set up and configure AI-powered Data Enrichment (preview)
description: Learn how to set up and configure the AI-powered Data Enrichment feature for opportunity records in Dynamics 365 Sales.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/06/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Set up and configure AI-powered Data Enrichment (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an admin, you can configure AI-powered Data Enrichment to work on specific opportunity records and set preferences for how updates are applied.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

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
    A dialog box appears with the recommended default settings.
    :::image type="content" source="media/data-enrichment-quick-setup.png" alt-text="Screenshot of the Data Enrichment quick setup dialog box with recommended default settings.":::
1. Do *ONE* of the following:
    - Review the default settings and select **Start agent** if you're satisfied with the defaults. 
    - Select **Edit in settings** to customize the configuration:
       1. [Define the agent profile](#define-the-agent-profile)
 
       2. [Select records for enrichment](#select-records-for-enrichment)
       3. [Configure agent behavior](#configure-agent-behavior)
       4. After configuring the settings, select **Apply changes** and then **Start agent** to activate Data Enrichment with your specified configuration.

  The agent doesn't analyze any opportunity records or emails until sellers [provide consent](use-data-enrichment-agent.md#provide-consent-for-data-enrichment-to-read-your-emails) to read their emails. The consent is specific to each seller. 

<a name="open-settings"></a>
## Open Data Enrichment settings after agent creation

To review or modify the Data Enrichment settings after the agent has been created, follow these steps:

1. From the Sales Hub app, navigate to **App Settings**.
1. Under **General Settings**, select **Dynamics 365 AI Hub** and then select **Create and manage agents**.
1. In the **AI Agents** page, select the Data Enrichment agent that you created to open its settings.

### Define the agent profile

In the **Profile** section of the [Data Enrichment settings](#open-settings), specify the name and description. This name helps identify the agent in the list of AI agents.

### Select records for enrichment

In the **Record selection** section of the [Data Enrichment settings](#open-settings), define the criteria for the opportunity records that Data Enrichment will analyze. You can use filters based on fields in the opportunity entity or a related entity. For example, you can set Data Enrichment to work only on opportunities created within a certain date range or those associated with specific sales teams.

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
