---
title: Set up and configure Data Enrichment Agent
description: Learn how to configure the agent.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 01/19/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
---

# Set up and configure Data Enrichment Agent

As an admin, you can configure the Data Enrichment Agent to work on specific opportunity records and set preferences for how updates are applied.


## Prerequisites

Ensure that you meet the following prerequisites:

- You have the Sales Premium license.
- You have admin privileges in Dynamics 365 Sales.

## Configure Data Enrichment Agent

1. From the Sales Hub app, navigate to **App Settings**.
1. Under **General Settings**, select **Dynamics 365 AI Hub**.
1. Select **Create and manage agents** and select **Data Enrichment Agent**.

### Define the agent profile

In the **Agent profile** section, specify the name and description for the agent.

### Select records for enrichment

In the **Record selection** section, define the criteria for the opportunity records that the agent will analyze. You can use filters based on fields in the opportunity entity or a related entity. For example, you can set the agent to work only on opportunities created within a certain date range or those associated with specific sales teams.

### Configure agent behavior

In the **Agent behavior** section, choose how the agent should handle updates:

- **Field scope**: Select the fields that you want to exclude from enrichment. By default, all fields are included. 
- **Field update behavior**: Turn on **Automatically update fields** to allow the agent to make changes without a manual review. By default, this option is off, meaning sellers need to review and apply suggestions manually.
- **Enrichment frequency**: Shows how often the agent will analyze and update opportunity records. This is set to **Daily** by default. However, this field is informational and cannot be changed.
- **Data sources**: Shows the data sources that the agent will use to analyze and enrich opportunity records. The agent uses email interactions and data from Sales Close Agent - Research (if configured) to gather context about opportunities and suggest updates. This field is informational and cannot be changed.

## Fields excluded from enrichment by default

The following fields are excluded from enrichment by default and cannot be modified:

- Opportunity Name
- All rollup fields and calculated fields
- Opportunity State