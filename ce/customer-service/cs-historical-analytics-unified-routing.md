---
title: "Historical analytics for unified routing in Customer Service | MicrosoftDocs"
description: "Learn about the KPIs that are available in the historical analytics report for Customer Service."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Historical analytics for unified routing in Customer Service

## Introduction

With the introduction of Unified Routing, an advanced and elaborate set of capabilities are available for organizations to enhance their routing configurations. Business administrators and supervisors need metrics to track how these advanced routing capabilities are helping their businesses serve their customers.

In Customer Service, the report displays metrics pertaining to only those records that are routed using unified routing.

## Unified routing in Customer Service

The Unified routing report appears as a tab in the Customer Service historical analytics report if your administrator has enabled the corresponding setting on the **Insights** page in Customer Service Hub. You can access the report in Service. In the site map, select **Customer Service historical analytics**, and then select **Unified routing**.

:::image type="content" source="media/cs-ha-unified-routing.png" alt-text="Historical analytics for unified routing in Customer Service.":::

The report can be filtered on the following:

- **Duration**: Filters the data by the selected value of day, week, or month.
- **Record type**: Filters the data for the selected record, such as a case, lead, or custom record.
- **Queue**: Filters the data for the selected queue that is enabled for unified routing.
- **Time zone**: Filters the data for the selected time zone.

The unified routing report displays the following metrics.

|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Records routed     | Number of records that were successfully routed.        |         |
|Routing attempts     | Number of records that were attempted to be routed.        |         |
|First route success     | Number of records that were successfully routed in the first attempt.       |         |
|Records transfer rate|The percentage of records that were transferred to another agent or queue.||
|Records routed    | Day wise view of records that have been routed.        |         |
|Transfer rate trend     | Day wise view of transfer rate of records.        |         |
|Top 5 skills demanded     |  Top five skills required by the routed records.        |         |
| | | |

The **Routing metrics by queue** table displays data on the routed records and transfer rate for each queue. You can select a queue, and then select **Details** to view the detailed KPIs for it.

:::image type="content" source="media/cs-routing-metrics-queue.png" alt-text="Routing metrics by queue in unified routing for Customer Service.":::

The **Routing metrics by date** table displays the day wise data for the KPIs for the selected period in the **Duration** filter.

:::image type="content" source="media/cs-routing-metrics-date.png" alt-text="Routing metrics by date in unified routing for Customer Service.":::

You can select a date, and then select **Details** to view the routing metrics by the hour.

### See also

[Enable Historical analytics for unified routing](configure-cs-historical-analytics-csh.md#enable-historical-analytics-for-unified-routing)  