---
title: Configure Sales Qualification Agent to use Dataverse fields enriched by third-party data providers
description: Learn to configure the Sales Qualification Agent in Dynamics 365 Sales with ZoomInfo or Dun & Bradstreet enriched fields for precise lead qualification.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 09/17/2025
ms.topic: concept-article
---

# Configure Sales Qualification Agent to use Dataverse fields enriched by third-party data providers

The Sales Qualification Agent in Dynamics 365 Sales automates lead research and engagement by evaluating leads against your target customer profile. You can define custom target customer profile criteria using Dataverse fields—many of which can be enriched with firmographic data from ZoomInfo, Dun & Bradstreet (D&B), or any other provider that integrates with Dataverse. Learn more about [Custom criteria examples for sales teams across industries](custom-icp-examples.md).

This article covers instructions for integrating with ZoomInfo and Dun & Bradstreet. However, you can choose any other provider, such as Clay, 6Sense, Similarweb, and Builtwith, that syncs firmographic data into Dataverse fields. The high-level steps remain similar.

## Step 1: Install and set up the integration

Before using ZoomInfo or D&B data in your Sales Qualification Agent configuration, install and configure the respective app from Microsoft AppSource.

### Integrate ZoomInfo data

Integrate ZoomInfo data by following the instructions in these articles:

1. [Install ZoomInfo app](install-zoominfo-app.md)
1. [Configure export preferences](configure-export-preferences-zoominfo.md)
1. [Match fields between Dynamics 365 and ZoomInfo](match-fields-between-dynamics365-zoominfo.md)
1. [Customize the ZoomInfo app](customize-zoominfo-app.md)

### Integrate Dun & Bradstreet data

Integrate Dun & Bradstreet data by installing and configuring the [Dun & Bradstreet Optimizer App for Microsoft](https://appsource.microsoft.com/en-us/product/dynamics-365/dnb.dnb_optimizer) from Microsoft AppSource. For step-by-step instructions, refer to the official installation guide under **Details + Support** > **Help** on the AppSource page.
:::image type="content" source="media/dnb-help-doc.png" alt-text="Screenshot of the help link under Details + Support section.":::


## Step 2: Identify ZoomInfo or D&B-enriched Dataverse fields

Once the synchronization between ZoomInfo or D&B is active, the following fields in the lead and account tables are typically enriched:

| **Field Name** | **Logical Name**  |
|----------------|-------------------|
| Industry       | industrycode      |
| Annual Revenue | revenue           |
| Company Size   | numberofemployees |
| ZoomInfo ID or D-U-N-S Number (for D&B) | zoominfoid or dunsnumber |

You can enrich additional fields based on your industry and target customer profile. For example, if you're in the technology sector, you might want to enrich fields like "Technology Stack" using BuiltWith data. Refer to the documentation of your chosen data provider for a comprehensive list of available fields.

## Step 3: Configure the Sales Qualification Agent to use enriched fields

After the data from ZoomInfo or D&B is synced into Dataverse, you can configure the Sales Qualification Agent to use these enriched fields in the following agent configurations:

- **Lead selection criteria**: Use enriched fields in the lead selection criteria. For example, you can have the agent work only on leads from companies in the "Technology" industry. Learn more in [Configure selection criteria for Sales Qualification Agent](sales-qualification-agent-selection-criteria.md)
- **Handoff criteria**: Define target customer profile criteria based on enriched fields. Learn more in [Configure handoff criteria for the Sales Qualification Agent](configure-sales-qualification-agent-handoff-criteria.md). Here are some example criteria:

  | **Field Name** | **Logical Name**  | **Criteria Example**     |
  |----------------|-------------------|--------------------------|
  | Industry       | industrycode      | Equals “Technology”      |
  | Annual Revenue | revenue           | Greater than \$5,000,000 |
  | Company Size   | numberofemployees | Between 50 and 500       |
  | ZoomInfo ID    | zoominfoid        | Is not empty             |

## Step 4: Validate and monitor

- Use the [testing guide](test-sales-qualification-agent.md) to simulate leads with varying degrees of fit.

- Monitor lead handovers and disqualifications using the [supervisor dashboard](monitor-leads-by-sales-qualification-agent.md).
- Refine your criteria based on performance insights.
