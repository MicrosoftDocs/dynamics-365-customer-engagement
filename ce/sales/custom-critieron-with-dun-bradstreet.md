---
title: Configure custom criteria using Dataverse fields synched with Dun & Bradstreet
description: Discover how to integrate Dun & Bradstreet data with Dynamics 365 Sales to enrich leads and streamline qualification with custom ICP rules.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 09/09/2025
ms.topic: concept-article
---

# Configure custom criteria using Dataverse fields synched with Dun & Bradstreet

The Sales Qualification Agent in Dynamics 365 Sales automates lead research and engagement by evaluating leads against your Ideal Customer Profile (ICP). You can define custom ICP criteria using Dataverse fields—many of which can be enriched with firmographic data from Dun & Bradstreet (D&B). This article explains how to configure these criteria to leverage data synced from D&B for more precise lead qualification.

## Step 1: Install and set up Dun & Bradstreet sync

Before using D&B data in your custom criteria, you must install and configure the [Dun & Bradstreet Optimizer App for Microsoft](https://appsource.microsoft.com/en-us/product/dynamics-365/dnb.dnb_optimizer) from Microsoft AppSource. For step-by-step instructions, refer to the official installation guide under **Details + Support** > **Help** on the AppSource page.

:::image type="content" source="media/dnb-help-doc.png" alt-text="Screenshot of the help link under Details + Support section.":::

At a high-level, the installation and setup involves the following steps:

1. **Install the Dun & Bradstreet Optimizer Solution**
  - Download the solution package from AppSource.
  - Import it into your Dynamics 365 environment from Power Platform Admin Center.
1. **Configure the Dun & Bradstreet Connection**
  - Navigate to the Dun & Bradstreet Optimizer configuration page.
  - Enter your Dun & Bradstreet API credentials and validate the connection.
1. **Map Dun & Bradstreet Fields to Dataverse**
  - Use the field mapping interface to link Dun & Bradstreet data (e.g., revenue, industry, employee count) to Dataverse fields on account, lead, or contact tables.
1. **Enable Scheduled Sync**
  - Set up a recurring job to pull updates from Dun & Bradstreet into your CRM.
  - Confirm that enriched fields are populated correctly.

## Step 2: Identify Dataverse fields enriched by Dun & Bradstreet

Once Dun & Bradstreet sync is active, the following fields in the lead and account tables are typically enriched:

- **Industry** (industrycode)

- **Annual Revenue** (revenue)

- **Company Size** (numberofemployees)

- **Country** (address1_country)

- **D-U-N-S Number** (dunsnumber)

## Step 3: Configure the Sales Qualification Agent to use the enriched fields

After you synch Dun & Bradstreet data into Dataverse, you can configure the Sales Qualification Agent to use these enriched fields in the following agent configurations:

- **Lead selection criteria**: Use enriched fields in the lead selection criteria. For example, you can have the agent work only on leads from companies in the "Technology" industry. Learn more in [Configure selection criteria for Sales Qualification Agent (preview)](sales-qualification-agent-selection-criteria.md)
- **Handoff criteria**: Define ideal customer profile criteria based on enriched fields. Learn more in [Configure handoff criteria for the Sales Qualification Agent (preview)](configure-sales-qualification-agent-handoff-criteria.md). Here are some example criteria:

  | **Field Name** | **Logical Name**  | **Criteria Example**     |
  |----------------|-------------------|--------------------------|
  | Industry       | industrycode      | Equals “Technology”      |
  | Annual Revenue | revenue           | Greater than $5,000,000 |
  | Company Size   | numberofemployees | Between 50 and 500       |
  | Country        | address1_country  | Equals “United States”   |
  | D-U-N-S Number | dunsnumber        | Is not empty             |


# Step 4: Validate and Monitor

- Use the [testing guide](test-sales-qualification-agent.md) to simulate leads with varying degrees of fit.

- Monitor lead handovers and disqualifications using the [supervisor dashboard](monitor-leads-by-sales-qualification-agent.md).
- Refine your criteria based on performance insights.
