---
title: Edit AI-powered Data Enrichment settings
description: Discover how to update agent settings, define access, and set enrichment rules for AI-powered Data Enrichment in Dynamics 365 Sales. 
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 09/08/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Edit AI-powered Data Enrichment settings

After you [create the AI-powered Data Enrichment agent](data-enrichment-agent-configure.md), you can edit its settings to align with your business needs and preferences. These settings include defining the agent profile, configuring user access, selecting Contact, Opportunity, Lead, and Account records for enrichment, and setting the agent's behavior.

<a name="open-settings"></a>
## Open the Data Enrichment settings page

1. From the lower-left corner of the Sales Hub app, select **Change Area** > **App Settings**.
1. Under **General Settings**, select **Dynamics 365 AI Hub** and then select **Create and manage agents**.
1. In the **AI Agents** page, select **Data Enrichment** with type **Conversation Enrichment**. 
   The settings page opens, displaying the current configuration of the Data Enrichment agent.
   :::image type="content" source="media/data-enrichment-prerequisites.png" alt-text="Screenshot of the Data Enrichment prerequisites page showing the status of required prerequisites.":::

## Verify prerequisites

1. In the **Prerequisites** section, ensure that all prerequisites are connected. If you see new prerequisites since your last configuration, connect them to ensure the agent functions correctly. For more information about the prerequisites, see [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md#prerequisites).
1. Select **Save** to save any updates to the prerequisites.

## Define the agent profile

In the **Agent profile** section of the [Data Enrichment settings](#open-settings), specify the name and description for the agent. This name helps identify the agent in the list of AI agents.

<a name="configure-user-access"></a>
## Configure user access

In the **User access** section of the [Data Enrichment settings](#open-settings), specify which sellers can access Data Enrichment suggestions. Data Enrichment analyzes supported records owned only by sellers selected in this section. These sellers also get access to the data enrichment suggestions for all supported records that they have read and write access to.

You can choose one of the following options:
 
- **All users with premium license**: Select this option to allow all users with a Dynamics 365 Sales Premium license to access the agent's suggestions.
- **Specific groups**: Select this option to allow specific sellers or those who meet certain criteria to access the agent's suggestions. You can either select individual users (up to 10) or specify criteria based on fields such as sales team, job title, or geography to determine who can access the agent's suggestions.  

## Select records for enrichment

In the **Record selection** section of the [Data Enrichment settings](#open-settings), define the criteria for the Contact, Opportunity, Lead, and Account records that Data Enrichment will analyze. You can use filters based on fields in the selected table or a related table. Important points to note:

- You must define the selection criteria for at least one record type to activate the agent.  
- You can disable data enrichment for specific record types by clearing the checkbox next to the record type name. 
- The record selection criteria are applied in addition to the user access criteria defined in the previous section. For example, if you select specific seller groups in the user access settings and set a filter for supported records created within a certain date range, only the records that meet both criteria will be analyzed and enriched by the agent. Learn more about which fields are supported for each record type in [Enrichment behavior by record type](data-enrichment-agent-overview.md#enrichment-behavior-by-record-type).

<a name="configure-agent-behavior"></a>
## Configure agent behavior

In the **Agent behavior** section of the [Data Enrichment settings](#open-settings), choose how Data Enrichment should handle updates:

- **Field scope**: Select the fields that you don't want Data Enrichment to enrich. These could be fields that are critical to your business processes or those that you prefer to manage manually. Some fields are excluded from enrichment by default and cannot be modified. See [Fields excluded from enrichment](#fields-excluded-from-enrichment) for more details.  

  > [!NOTE]
  > Field scope settings apply to Opportunity and Lead records only. Contact records are enriched using a fixed set of five out-of-the-box fields (such as phone number, job title, email address, and preferred contact method) that can't be configured. Account records don't support field enrichment.
- **Field update behavior**: Turn on **Automatically update fields** to allow Data Enrichment to make changes without a manual review. By default, this option is off, meaning sellers need to review and apply suggestions manually.
- **Enrichment frequency**: Indicates how often Data Enrichment applies updates automatically. The agent analyzes emails and generates suggestions every 4 hours. For manual updates, sellers can review suggestions as soon as they're generated. For automatic updates, changes are applied based on the enrichment frequency, which is set to **Daily** by default. This setting is informational and can't be changed.
- **Data sources**: Shows the data sources Data Enrichment uses to analyze records. It gathers context from Outlook interactions and Teams meetings. For Teams meetings, it uses AI-generated summaries (if you have a Microsoft 365 Copilot license) or meeting transcripts. This field is informational and can't be changed.

## Enable or disable connected skills

Connected skills extend Data Enrichment by integrating it with other features in Dynamics 365 Sales. In the **Connected skills** section of the [Data Enrichment settings](#open-settings), the following skill is currently available and turned on by default:

**Recommended action**: When enabled, this skill displays Data Enrichment suggestions in the **Suggested actions** carousel on the supported table list views, allowing sellers to review and apply suggestions without opening individual records. The skill recommends the next best action based on record context. If disabled, sellers can still access data enrichment suggestions from within each record, but they don't appear in the carousel. For more information, see [Configure Recommended Actions Agent](configure-recommended-actions.md).

The following screenshot shows an example of a Data Enrichment suggestion surfaced in the Suggested actions carousel for sellers to act on:
:::image type="content" source="media/data-enrichment-in-carousal.png" alt-text="Screenshot of the Suggested actions carousel showing Data Enrichment suggestions.":::

Select the toggle next to the skill name to enable or disable it based on your preferences.

<a name="start-agent"></a>
## Start or stop the agent

After configuring the settings, select **Save** and then **Start agent** to activate Data Enrichment with your specified configuration. You can stop the agent at any time by selecting **Stop agent** on the settings page. When the agent is stopped, it doesn't analyze records or generate suggestions.

The agent doesn't analyze any supported records, emails, or meeting data until sellers are enrolled. By default, sellers are automatically enrolled when they first open a supported record. Enrollment is specific to each seller. For more information, see [Consent for Data Enrichment to read your emails and Teams meetings data](use-data-enrichment-agent.md#consent-for-data-enrichment-to-read-your-emails).

## Fields excluded from enrichment

The following fields are excluded from enrichment by default and cannot be modified:

- Opportunity Name (Opportunity records only)

- Opportunity State (Opportunity records only)
- Fields with the following attribute types: Uniqueidentifier, Virtual, Lookup, Customer, Owner, PartyList, CalendarRules, ManagedProperty, EntityName
- Read-only fields and system fields


## Related information

[Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md)