---
title: Real-time analytics Summary report| Microsoft Docs
description: Learn about the real-time summary report to cater to your organization's customer service experience better.
ms.date: 04/27/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice

---
# View and understand the Summary report in Omnichannel real-time analytics

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The **Summary** report is the default report that appears when you select the Omnichannel real-time analytics dashboard in Customer Service workspace. You can filter the report by by time, channels, queue, time zone, or conversation status. More information: [Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md)

This report provides the summary of customer conversations over time and by channel or queue. Statistics about the channel through which a conversation comes in can help you analyze and manage queue distribution accordingly. For example, higher abandoned conversations can often lead to decreased customer satisfaction. You can take care of high abandoned conversations by looking into operational metrics such as agent availability and queue distribution in real time.

Additionally, you can also track customer sentiment to analyze whether customers are getting adequate support. For example, a high average handle time might indicate that agents are taking more than the required time to resolve customer issues. Depending on the issue, you could then provide the required training or support to help agents resolve customer issues faster.

In addition to the metrics that you already see on the Summary dashboard, you can also add more metrics by editing the visual display of your report. More information: [Customize visual display](customize-reports.md#customize-visual-display)

:::image type="content" source="media/realtime_summary.png" alt-text="Screenshot of realtime summary report":::

For details on metrics displayed in the Summary report, go to [Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics).

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut chart. The visual display helps you see the changes and patterns in the data, and act quickly to address the most important issues.

When you select a component on the chart, the data gets filtered accordingly and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

## Drill-down reports
Drill down to sections within a report to find the data that interests you the most. The following sections provide details about the two drill-down reports that you can view in the Summary report.

### Conversations over time drill-down

You can view conversations analytics when you select the **Show more** link on the **Conversations over time** KPI. You can drill through conversations over time and analyze data by selecting the **Channel** or **Queue** tabs.

:::image type="content" source="media/realtime_summary-conversation-analytics.png" alt-text="The image desrcibes conversation analytics by queue.":::

### Agent availability status drill-down

You can view additional details about agent analytics by queue when you select the **Show more** link on the **Agent availability status** KPI. You can drill through agent analytics by selecting the **Availability status** or **Capacity unit** tabs, which will help you effectively manage agent activity in real time.

:::image type="content" source="media/realtime_summary-agent-analytics.png" alt-text="The image describes agent analytics by queue.":::

### See also

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)  
[Manage real-time analytics reports in Omnichannel for Customer Service](enable-realtime-analytics-dashboard-administrator.md)  
[Overview of Omnichannel real-time analytics reports](intro-realtime-analytics-dashboard.md)  
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)  
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)  
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics](realtime-ongoing.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
