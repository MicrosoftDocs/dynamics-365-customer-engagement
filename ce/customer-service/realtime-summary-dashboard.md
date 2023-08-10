---
title: View and understand the Summary report in Omnichannel real-time analytics
description: Learn about the real-time Summary report to help your organization provide a better customer service experience.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 07/21/2023
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
  - enduser

---
# View and understand the Summary report in Omnichannel real-time analytics

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The **Summary** report appears by default when you open the **Omnichannel real-time analytics** dashboard in Customer Service workspace. You can filter this report by time, channels, queue, time zone, and conversation status. For more information, go to [Overview of the real-time Omnichannel analytics dashboard](intro-realtime-analytics-dashboard.md).

The **Summary** report provides a summary of customer conversations over time, by channel or queue. Statistics about the channel that a conversation came in through can help you analyze and manage queue distribution. For example, a high rate of abandoned conversations can lead to decreased customer satisfaction. To address the rate of abandoned conversations, you can examine operational metrics such as agent availability and queue distribution in real time.

Additionally, you can track customer sentiment to analyze whether customers are getting adequate support. For example, a high average handle time might indicate that agents are taking more than the required time to resolve customer issues. Depending on the issue, you can provide the required training or support to help agents resolve customer issues faster.

By editing the visual display, you can add metrics to the ones that are already shown on the **Summary** report. For more information, go to [Customize visual display](customize-reports.md).

[Learn more about the metrics that are shown on the Summary report.](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)

:::image type="content" source="media/realtime_summary.png" alt-text="Screenshot of real-time Summary report.":::

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut charts. The visual display helps you discern changes and patterns in the data, so that you can act quickly to address the most important issues.

When you select a component in a chart, the data is filtered accordingly. In this way, you can view only data that is related to the selected component. For example, if you select the **Busy** component in the **Agent availability status** chart, the dashboard is refreshed and shows only the agents who are currently in the **Busy** state.

## Drill-down reports

Drill down to sections of a report to find the data that interests you the most. This section provides details about the two drill-down reports that you can view on the **Summary** report.

### Conversations over time drill-down report

To view conversation analytics, select the **Show more** link on the **Conversations over time** KPI. You can drill through the conversations over time and analyze data by selecting the **Channel** or **Queue** tab.

:::image type="content" source="media/realtime_summary-conversation-analytics.png" alt-text="Screenshot of the Channel tab on the drill-down report for the Conversations over time KPI.":::

### Agent availability status drill-down report

To view more details about agent analytics by queue, select the **Show more** link on the **Agent availability status** KPI. You can drill through agent analytics by selecting the **Availability status** or **Capacity unit** tab. These tabs will help you effectively manage agent activity in real time.

:::image type="content" source="media/realtime_summary-agent-analytics.png" alt-text="Screenshot of the Availability status tab on the drill-down report for the Agent availability status KPI.":::

### See also

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)<br>
[Manage real-time analytics reports in Omnichannel for Customer Service](enable-realtime-analytics-dashboard-administrator.md)<br>
[Overview of Omnichannel real-time analytics dashboard](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboard)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)<br>
[View and understand the Ongoing conversation report in Omnichannel real-time analytics](realtime-ongoing.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
