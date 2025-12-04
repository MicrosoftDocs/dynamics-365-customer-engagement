---
title: View and understand the Summary report in Omnichannel real-time analytics
description: View and understand the Summary report in Omnichannel real-time analytics to analyze customer conversations, sentiment, and operational metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 09/26/2025
ms.custom:
  - dyn365-customerservice
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/05/2023
search.audienceType:
  - admin
  - customizer
  - enduser
---
# View and understand the Summary report in Omnichannel real-time analytics

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The **Summary** report shows customer conversations over time by channel or queue. This report shows all omnichannel type queues, like messaging, live chat, and phone, except entity record type queues. View entity record type queues in real-time analytics for record routing reports. Statistics about the channel a conversation comes from help you analyze and manage queue distribution. For example, a high rate of abandoned conversations can decrease customer satisfaction. To fix abandoned conversations, examine operational metrics like customer service representative (service representative or representative) availability and queue distribution in real time. Learn how to [access the report](intro-realtime-analytics-dashboard.md#access-reports).

Track customer sentiment to learn if customers get enough support. For example, a high average handle time might mean service representatives take longer than needed to fix customer issues. Depending on the issue, provide training or support to help service representatives fix customer issues faster.

Filter this report by time, channel, queue, time zone, conversation status, and skills. Learn more in [Overview of the real-time Omnichannel analytics dashboard](intro-realtime-analytics-dashboard.md).

Edit the visual display to add metrics to those already shown on the **Summary** report. Learn more in [Customize visual display](customize-reports.md).

[Learn more about the metrics that are shown on the Summary report](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics).

:::image type="content" source="../media/realtime-summary-page.png" alt-text="Screenshot of the real-time summary report.":::

## Interactive charts

View different types of charts on the report, like bar, horizontal bar, and donut charts. The visual display helps you spot changes and patterns in the data, so you can act quickly to address the most important issues.

When you select a component in a chart, the data filters accordingly. This way, you see only data related to the selected component. For example, if you select the **Busy** component in the **Agent availability status** chart, the dashboard refreshes and shows only the service representatives who are currently in the **Busy** state.

## Drill-down reports

Drill down to sections of a report to find the data that interests you most. This section describes the two drill-down reports you view on the **Summary** report.

### Conversations over time drill-down report

To view conversation analytics, select the **Show more** link on the **Conversations over time** KPI. You can drill through the conversations over time and analyze data by selecting the **Channel** or **Queue** tab.

### Agent availability status drill-down report

To view more details about service representative analytics by queue, select the **Show more** link on the **Agent availability status** KPI. You can drill through agent analytics by:

**Availability status**

:::image type="content" source="../media/realtime_summary_queue-drilldown_1.png" alt-text="Drilldown agent analytics by Availability status":::

**Capacity unit**
:::image type="content" source="../media/realtime_summary_queue-drilldown_2.png" alt-text="Drilldown agent analytics through capacity unit":::

These tabs help you effectively manage service representative activity in real time.

### Related information

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md)<br>
[Manage real-time analytics reports in Omnichannel for Customer Service](../administer/enable-realtime-analytics-dashboard-administrator.md)<br>
[Overview of Omnichannel real-time analytics dashboard](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboard)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)<br>
[View and understand the Ongoing conversation report in Omnichannel real-time analytics](realtime-ongoing.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
