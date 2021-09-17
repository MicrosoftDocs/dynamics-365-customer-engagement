---
title: "Historical analytics for unified routing in Ommichannel for Customer Service | MicrosoftDocs"
description: "Learn about the KPIs that are available in the historical analytics report for Omnichannel for Customer Service."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Historical analytics for unified routing in Omnichannel for Customer Service

## Introduction

With the introduction of Unified Routing, an advanced and elaborate set of capabilities are available for organizations to enhance their routing configurations. Business administrators and supervisors need metrics to track how these advanced routing capabilities are helping their businesses serve their customers.

## Unified routing in Omnichannel for Customer Service

The Unified routing report appears as a tab in the Customer Service historical analytics report if your administrator has enabled the corresponding setting on the **Insights** page in Omnichannel admin center. You can access the report in the Customer Service workspace or Omnichannel for Customer Service app, by selecting the plus (+) icon, and then selecting Customer Service historical analytics.

:::image type="content" source="media/oc-ha-unified-routing.png" alt-text="Historical analytics for unified routing in Omnichannel for Customer Service.":::

The report can be filtered on the following:

- **Duration**: Filters the data by the selected value of day, week, or month.
- **Channel**: Filters the data for the selected channel.
- **Queue**: Filters the data for the selected queue.
- **Conversation status**: Filters the data for the selected status.
- **Time zone**: Filters the data for the selected time zone.

The unified routing report displays the following metrics for the selected filters. The percentage value for each KPI denotes the comparative data with the previous period.


|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Incoming conversations     | The number of conversations initiated by the customer that can be presented to a human agent.        | All conversations, except bot conversations, are considered.        |
|Routed conversations     | Total number of incoming conversations that have been routed.        |         |
|Incoming sessions     | Total number of sessions that were created.        |         |
|Session transfer rate     | The percentage of incoming sessions that were transferred to another agent or queue.         |         |
|Incoming conversations VS. routed conversations     | The number of conversations initiated by the customer versus the number of conversations that were routed.      |         |
|Session transfer rate trend     | Day wise trend of session transfer rate.        |         |
|Top 5 Skills demanded     | Top five skills required by the incoming conversations.        |         |
||||

The **Routing metrics by queue** table displays data on incoming conversations, incoming sessions, and session transfer rate for each queue. You can select a queue, and then select **Details** to view the detailed KPIs for it.

:::image type="content" source="media/oc-routing-metrics-queue.png" alt-text="Routing metrics by queue in unified routing for Omnichannel for Customer Service.":::

The **Routing metrics by date** table displays the day wise data for the KPIs for the selected period in the **Duration** filter.

:::image type="content" source="media/oc-routing-metrics-date.png" alt-text="Routing metrics by date in unified routing for Omnichannel for Customer Service.":::

You can select a date, and then select **Details** to view the routing metrics by the hour.

### See also

[Enable Historical analytics for unified routing in Omnichannel for Customer Service](oc-historical-analytics-reports.md#enable-historical-analytics-for-unified-routing-in-omnichannel-for-customer-service)  

