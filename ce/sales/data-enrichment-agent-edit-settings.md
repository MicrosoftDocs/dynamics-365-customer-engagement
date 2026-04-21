---
title: Edit AI-powered Data Enrichment settings
description: Discover how to update agent settings, define access, and set enrichment rules for AI-powered Data Enrichment in Dynamics 365 Sales. 
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 04/21/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Edit AI-powered Data Enrichment settings

After you [create the AI-powered Data Enrichment agent](data-enrichment-agent-configure.md), you can edit its settings to align with your business needs and preferences. These settings include defining the agent profile, configuring user access, selecting records for enrichment, and setting the agent's behavior.

<a name="open-settings"></a>
## Open the Data Enrichment settings page

1. From the Sales Hub app, navigate to **App Settings**.
1. Under **General Settings**, select **Dynamics 365 AI Hub** and then select **Create and manage agents**.
1. In the **AI Agents** page, select **Data Enrichment** with type **Conversation Enrichment**. 

## Define the agent profile

In the **Agent profile** section of the [Data Enrichment settings](#open-settings), specify the name and description for the agent. This name helps identify the agent in the list of AI agents.

## Configure user access

In the **User access** section of the [Data Enrichment settings](#open-settings), specify which sellers can access Data Enrichment suggestions. Data Enrichment analyzes opportunities owned only by selected sellers. You can choose one of the following options:
 
- **All users with premium license**: Select this option to allow all users with a Dynamics 365 Sales Premium license to access the agent's suggestions.
- **Specific groups**: Select this option to allow specific sellers (up to 10 of them) or those who meet certain criteria to access the agent's suggestions. You can either select individual users or specify criteria based on fields such as sales team, job title, or geography to determine who can access the agent's suggestions.  

## Select records for enrichment

In the **Record selection** section of the [Data Enrichment settings](#open-settings), define the criteria for the opportunity records that Data Enrichment will analyze. You can use filters based on fields in the opportunity entity or a related entity. 

The record selection criteria are applied in addition to the user access criteria defined in the previous section. For example, if you select specific seller groups in the user access settings and set a filter for opportunities created within a certain date range, only the opportunities that meet both criteria will be analyzed and enriched by the agent.

## Configure agent behavior

In the **Agent behavior** section of the [Data Enrichment settings](#open-settings), choose how Data Enrichment should handle updates:

- **Field scope**: Select the fields that you don't want Data Enrichment to enrich. These could be fields that are critical to your business processes or those that you prefer to manage manually. Some fields are excluded from enrichment by default and cannot be modified. See [Fields excluded from enrichment](#fields-excluded-from-enrichment) for more details.  
- **Field update behavior**: Turn on **Automatically update fields** to allow Data Enrichment to make changes without a manual review. By default, this option is off, meaning sellers need to review and apply suggestions manually.
- **Enrichment frequency**: Indicates how often Data Enrichment applies updates automatically. The agent analyzes emails and generates suggestions every 4 hours. For manual updates, sellers can review suggestions as soon as they're generated. For automatic updates, changes are applied based on the enrichment frequency, which is set to **Daily** by default. This setting is informational and can't be changed.
- **Data sources**: Shows the data sources that Data Enrichment will use to analyze and enrich opportunity records. It currently uses email interactions in your Microsoft 365 mailbox to gather context about opportunities and suggest updates. This field is informational and cannot be changed.

## Start or stop the agent

After configuring the settings, select **Apply changes** and then **Start agent** to activate Data Enrichment with your specified configuration. You can stop the agent at any time by selecting **Stop agent** on the settings page. When the agent is stopped, it won't analyze records or generate suggestions.

The agent doesn't analyze any opportunity records or emails until sellers [provide consent](use-data-enrichment-agent.md#provide-consent-for-data-enrichment-to-read-your-emails) to read their emails. The consent is specific to each seller. 

## Fields excluded from enrichment

The following fields are excluded from enrichment by default and cannot be modified:

- Opportunity Name

- Opportunity State
- Fields with the following attribute types: Uniqueidentifier, Virtual, Lookup, Customer, Owner, PartyList, CalendarRules, ManagedProperty, EntityName
- Read-only fields and system fields


## Related information

[Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md)