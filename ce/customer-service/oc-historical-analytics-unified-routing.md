---
title: "Historical analytics for unified routing in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the KPIs that are available in the historical analytics report for Omnichannel for Customer Service."
ms.date: 10/12/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Historical analytics for unified routing in Omnichannel for Customer Service

With the introduction of unified routing, an advanced and elaborate set of capabilities are available for organizations to enhance their routing configurations. Supervisors and business administrators need metrics to track how these advanced routing capabilities are helping their businesses serve their customers.

### Access the Unified routing dashboard

[!INCLUDE[cc-navigation](../includes/cc-navigation.md)]

## Unified routing report in Omnichannel historical analytics

The Unified routing report provides routing-specific KPIs and metrics that can be used by supervisors and administrators to track the success of their routing strategy. They can also track the incorrectly routed work items and configurations and correct them to improve the routing effectiveness and thereby customer satisfaction.

The report appears as a tab in the Omnichannel historical analytics report if your administrator has enabled the corresponding setting on the **Insights** page in Omnichannel admin center.

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
|Routed conversations     | The total number of incoming conversations that have been routed successfully. <br> **Note:** A conversation routed to a fallback queue is not considered in the calculation of the metric.       |         |
|Incoming sessions     | The total number of sessions that were created.        |         |
|Session transfer rate     | The percentage of incoming sessions that were transferred to another agent or queue.         |         |
|Incoming conversations v/s routed conversations     | The number of conversations initiated by the customer versus the number of conversations that were routed successfully.      |         |
|Session transfer rate trend     | The day wise trend of session transfer rate.        |         |
|Top 5 Skills demanded     | The top five skills required by the incoming conversations.        |         |

### Queue drill-down view

On the **Unified routing** report page, in the **Routing metrics by queue** table, select a queue, and then select **Details** to view the detailed KPIs for it. You can view data on incoming conversations, incoming sessions, and session transfer rate for the queue.

:::image type="content" source="media/ur-oc-hist-drill-down-view.png" alt-text="Routing metrics by queue in unified routing for Omnichannel for Customer Service.":::

The queue drill-down view displays the following KPIs.

|Metric  |Description  |
|---------|---------|
|Incoming sessions in queue vs incoming sessions transferred  |The day-wise view of incoming sessions in the selected queue that are still in the queue versus sessions that have been transferred to other queues.|
|Incoming session transferred by queue| The queues to which sessions from the selected queue have been transferred.|

### Hourly drill-down view

On the **Unified routing** report page, the **Routing metrics by date** table displays the day wise data for the KPIs for the selected period in the **Duration** filter.

:::image type="content" source="media/oc-routing-metrics-date.png" alt-text="Routing metrics by date in unified routing for Omnichannel for Customer Service.":::

You can select a date, and then select **Details** to view the routing metrics by the hour.

### See also

[Enable Historical analytics for unified routing in Omnichannel for Customer Service](oc-historical-analytics-reports.md#enable-historical-analytics-for-unified-routing-in-omnichannel-for-customer-service)  
[Overview of unified routing](overview-unified-routing.md)  
[Diagnostics for unified routing](unified-routing-diagnostics.md)  
[Manage report bookmarks](manage-bookmarks.md)  
