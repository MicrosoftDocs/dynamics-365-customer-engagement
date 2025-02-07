---
title: View and understand the Agents report in Omnichannel real-time analytics
description: Understand customer service representative performance and optimize allocation in real-time with the Omnichannel Agents report.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/03/2025
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/05/2023
---

# View and understand the Agents report in Omnichannel real-time analytics

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The **Agents** report consists of metrics that provide an overview of customer service representatives (service representatives or representatives) performance to help contact center managers optimize the allocation of service representatives in real time. This capability is crucial for ensuring that customers receive the best possible support.

The **Agents** report provides information about the capacity and status of service representatives for the last 24 hours. By drilling down to view details such as capacity at each service representative's level, you can quickly identify and allocate resources to address any staffing shortages. In this way, you help ensure that customers receive support when they need it.

You can also sort service representatives by skills by using the **Skills** filter. In the **Agent list** section, when you hover over a service representative's name, the skill set and proficiency of the service representative appears. You can review the skills and then assign the best service representative required to solve the issue at hand.

You can select the **All** filter to view the performance of service representatives across all channels. Alternatively, you can select a channel to view channel-specific service representative performance. You can also filter areas by time, queue, time zone, and conversation status. Learn more in [Overview of Omnichannel Real-time analytics dashboards](intro-realtime-analytics-dashboard.md).

[Learn more about the metrics that are shown on the Agents report.](oc-metrics-dimensions.md)

:::image type="content" source="../media/realtime-agent insights.png" alt-text="Screenshot of real-time Agents report.":::

## Interactive charts

You can view different types of charts on the report, such as donut charts. The visual display helps you discern changes and patterns in the data so that you can act quickly to address the most important issues.

When you select a component in a chart, the data is filtered accordingly. In this way, you can view only data that is related to the selected component. For example, if you select the **Busy** component in the **Agent availability status** chart, the dashboard is refreshed and shows only the service representatives who are currently in the **Busy** state.

## Agent details drill-down

> [!NOTE]
> If you don't see all the listed service representatives from the report as signed in, work with your administrator to make sure your service representatives have the **Omnichannel agent** role, or that custom roles have the **Read** privilege on the [Agent Status (msdyn_agentstatus) table](../../developer/reference/entities/msdyn_agentstatus.md).

You can drill down from the **Agent list** section on the dashboard to view key metrics about service representative details and specific insights about individual service representatives' performance.

You'll see the following tabs. The tabs also show custom presence statuses, configured by you and used by your service representatives. 

- **Agent online**: Shows service representatives who are online at the moment.

- **Agent offline**: Shows service representatives who logged in earlier but are offline at the moment.

- **Agents with sessions**: Shows service representatives who worked on a session today, or in the last 24 hours, or have open conversations, depending on the Time filter.

Depending on the information that you want to see, select the tab, and then select a service representative name from the **Agent list** grid. Select **Detailed view**. Service representative details are shown on a new page.

On the service representative details page, you can view service representative skills by proficiency, and service representative availability by units and capacity profiles.

You can drill down further through **Conversations** and track how a conversation progressed and the customer sentiment that is associated with it. Through **Agent presence history**, you can view service representative presence in real time.

[Learn more about the metrics in the Agent list grid and on the agent details page.](oc-metrics-dimensions.md)

:::image type="content" source="../media/realtime-agent-detailed-view.png" alt-text="Screenshot of the drill-down to service representative details.":::

### Related information

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md)<br>
[Manage real-time analytics reports in Omnichannel for Customer Service](../administer/enable-realtime-analytics-dashboard-administrator.md)<br>
[Overview of Omnichannel real-time analytics dashboard](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboard)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Ongoing conversation report in Omnichannel real-time analytics](realtime-ongoing.md)<br>
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
