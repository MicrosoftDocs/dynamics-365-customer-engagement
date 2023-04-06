---
title: Overview of real-time Omnichannel analytics dashboard| MicrosoftDocs
description: "Use this article to get an introduction to real-time Omnichannel analytics dashboard in Omnichannel for Customer Service and Customer Service workspace apps."
ms.date: 04/06/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# Overview of Omnichannel real-time analytics dashboards

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

In the digital contact center world, supervisors need to react to events like an increase in the volume of incoming customer interactions, longer call lengths and agent absenteeism by optimizing the allocation of agents in real time to provide quick support and boost customer satisfaction. Having visibility into the overall support performance through real-time reporting empowers them to monitor key operational metrics, make course corrections at the right time, and keep service levels high.

The real-time analytics reports provide information about the health and key performance indicators (KPIs) for your organization, that reflect the current situation in the contact center as supervisors oversee agents handling customer conversations coming through multiple channels. You can make changes to the visual display of the reports and save your personalized views as bookmarks.

As a supervisor, you can use the real-time analytics reports to:

- Monitor key operational metrics in near real-time and make course corrections at the right time to help keep service levels high​.

- Review the allocation of agents in near real-time, and then optimize to provide top-notch support and boost customer satisfaction.

- Improve agent staffing, effectiveness, and utilization by reviewing work distribution.

- Monitor ongoing conversations, track customer sentiment, and intervene, as required.

- Drill down to a specific channel, queue, or agent, as required, to gather key operational insights in real time and take necessary action.

> [!NOTE]
> - The reports include conversations that were handled only by agents, as well as those that were escalated by the Power Virtual Agents bots.
> - The reports don't include conversations that were resolved by Power Virtual Agents bots.

## Security roles and permissions

Real-time analytics works based on the security permissions defined in Dataverse. For example, if your organization has set business-unit level permission for you, then you'll be able to see the metrics computed based only on the business-unit level data.

As a supervisor, you can view the Omnichannel real-time analytics dashboard in Customer Service workspace. However, your administrator must enable the required permissions for you. To configure user roles to access analytics, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

> [!NOTE]
> If multiple users see different values in the metrics, you'll need to investigate the permissions for those users as this might be the reason for not seeing the same values in metrics.

## Access reports

You can view the various reports in the Customer Service workspace. In the Customer Service workspace default view, select the plus (+) icon, and then select **Omnichannel real-time analytics** dashboard. The **Summary** report is the default report that appears. You can view **Ongoing Conversations**, **Agent**, and **Voice** reports, by selecting the respective tabs.

If you're unable to view the reports, contact your system administrator. For more information, go to: [Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview). The real-time analytics reports are available only in English out of the box. You'll need to customize the reports to make them available in a language of your choice. More information: [Customize data models of historical analytics reports in Customer Service (preview)](model-customize-reports.md#customize-data-models-of-historical-analytics-reports-in-customer-service-preview)

## Dashboard details

The Omnichannel real-time analytics dashboard consist of the following:

- **Summary**: This report provides an overview of your organization in real time. This report provides KPIs across the volume of customer interactions and service levels, along with the available capacity in real time. More information: [View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md)

- **Voice**: This report provides an overview of conversations for the Omnichannel for Customer service voice channel. More information: [View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)

- **Agent**: This report provides an overview of the health and KPIs of agents in your organization. The information in this report is displayed based on the conversations. More information: [View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)

- **Ongoing Conversations**: This report provides information about the conversations that agents are handling and are in either active, open, wrap up, or waiting statuses. The report allows you to monitor, assign, transfer, and force close conversations for an agent, depending on your requirement. More information: [View and understand the Ongoing Conversation report in Omnichannel real-time analytics](realtime-ongoing.md)

## Filter information displayed on dashboards

You can use the filters on the dashboards like time, agent, channels, queue, time zone, and conversation status to drill down KPIs across the dashboard. You can adjust the filters based on insights you're looking for.

The **Time** dropdown list includes options such as **Include open conversations**, **Last 24hrs**, and **Today**.

- **Include open conversations**: Shows all conversations that started in the last 24 hours, as well as those that started in the last three days and are still open.
- **Last 24hrs**: Shows all conversations that started in the last 24 hours.
- **Today**: Shows all conversations that started today in the selected time zone.

### Pause updates on report data

Report data for all the reports is refreshed automatically in real time, except for Ongoing conversation report, which must be refreshed manually. You can use the **Pause updates** option to view and analyze real-time metrics at any point in time. You can reset the report data to be refreshed automatically by selecting **Resume updates**.

### See also

[Manage bookmarks](manage-bookmarks.md)  
[Customize visual display of historical analytics reports in Customer Service](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)  
[Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)    
[View and understand the Summary report in Omnichannel real-time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)    
[View and understand the Voice report in Omnichannel real-time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)    
[View and understand the Agents report in Omnichannel real-time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)    
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversation-report-in-omnichannel-real-time-analytics-preview)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
