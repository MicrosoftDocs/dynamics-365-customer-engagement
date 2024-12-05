---
title: Overview of the real-time Omnichannel analytics dashboard
description: Discover how to use an Omnichannel real-time analytics dashboard to optimize agent staffing, monitor key metrics, and improve customer satisfaction.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 12/06/2024
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
---

# Overview of Omnichannel real-time analytics dashboard

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. It isn't intended to be used, and should **not** be used, to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements.
>
> Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws that are related to accessing individual employee analytics, and monitoring, recording, and storing communications with users. As part of this compliance, customers must adequately notify users that their communications with customer service representatives (service representatives) might be monitored, recorded, or stored. As required by applicable laws, customers must also obtain consent from users before they use this feature with them. In addition, customers are encouraged to have a mechanism in place to inform their service representatives that their communications with users might be monitored, recorded, or stored.

In the digital contact center world, supervisors must be able to react to events by optimizing the allocation of service representatives in real time to provide quick support and boost customer satisfaction. Such events include an increase in the volume of incoming customer interactions, longer call lengths, and agent absenteeism. By providing visibility into overall support performance, real-time reporting helps supervisors monitor key operational metrics, make course corrections at the appropriate time, and keep service levels high.

The real-time analytics reports provide information about the health and key performance indicators (KPIs) for your organization. They reflect the current situation in the contact center as supervisors oversee service representatives who handle customer conversations that come in through multiple channels. You can change the visual display of the reports and save your personalized views as bookmarks.

As a supervisor, you can use the real-time analytics reports to perform these tasks:

- Monitor key operational metrics in near-real time, and make course corrections at the appropriate time to help keep service levels high.
- Review the allocation of service representatives in near-real time, and then optimize to provide top-notch support and boost customer satisfaction.
- Improve agent staffing, effectiveness, and utilization by reviewing the skill set and capacity profile of the agent. You can then assign or transfer ongoing conversations by filtering through queue or agent.
- Monitor ongoing conversations, track customer sentiment, and intervene as required.
- Drill down to a specific channel, queue, or agent as required, to gain key operational insights in real time and take necessary action.

> [!NOTE]
> The reports include conversations that were handled only by service representatives. They also include conversations that were escalated by the Copilot Studio bots. However, they don't include conversations that were resolved by Copilot Studio bots.

## Security roles and permissions

Real-time analytics takes advantage of the security permissions that are defined in Dataverse. For example, if your organization has set business unit-level permissions for you, only metrics that are computed based on business unit–level data are shown to you.

As a supervisor, you can view the **Omnichannel real-time analytics** dashboard in Customer Service workspace or Contact Center workspace. However, your administrator must provide the required permissions for you. [Learn how to configure user roles to access analytics and dashboards.](../administer/configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards)

> [!NOTE]
> If different values are shown to different users in the metrics, you must investigate the permissions for those users.

## Access reports

You can view the different reports in the Customer Service workspace or Contact Center workspace app. In the default view of the applications, select **Omnichannel real-time analytics** in **Service**. By default, the **Summary** report is shown. To view the **Ongoing conversation**, **Agents**, and **Voice** reports, select the appropriate tabs.

If you can't view the reports, contact your system administrator. For more information, go to [Manage real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service).

## Dashboard details

> [!NOTE]
> - The reports don't include work items of the Entity Record channel.
> - The reports are prefiltered based on the queues you are signed in to as a supervisor. Your view of metrics and conversations pertain to the assigned queues only, which helps ensure data privacy and relevance.

The **Omnichannel real-time analytics** dashboard consists of the following reports:

- **Summary**: This report provides an overview of your organization in real time. It provides KPIs across the volume of customer interactions and service levels, together with the available capacity in real time. [Learn more about the Summary report.](realtime-summary-dashboard.md)
- **Voice**: This report provides an overview of conversations for the voice channel. [Learn more about the Voice report.](realtime-voice-dashboard.md)
- **Agents**: This report provides an overview of the health and KPIs of service representatives in your organization. The information that is shown on this report is based on the conversations. [Learn more about the Agents report.](realtime-agents-analytics.md)
- **Ongoing conversation**: This report provides information about the conversations that service representatives are handling that are in active, open, wrap-up, or waiting status. Use it to monitor, assign, transfer, and forcibly close conversations for a service representative, after reviewing their skill set and capacity profiles. [Learn more about the Ongoing conversation report.](realtime-ongoing.md)

## Filter information displayed on dashboard

Use the filters to drill down to KPIs across the dashboard. Adjust the filters based on the insights that you're looking for. The available filters include **Time**, **Agent**, **Channels**, **Queue**, **Time zone**, and **Conversation status**. 

For example, the dropdown list for the **Time** filter includes the following options:

- **Include open conversations**: Show all conversations that started in the last 24 hours, and conversations that started in the last three days and are still open.
- **Last 24 hrs**: Show all conversations that started in the last 24 hours.
- **Today**: Shows all conversations that started on the current date in the selected time zone.

### Pause updates on report data

Report data is automatically updated in real time for all the reports except the **Ongoing conversation** report. The report data on that report must be manually updated. You can use the **Pause updates** option to view and analyze real-time metrics at any point in time. To resume automatic updates of the report data, select **Resume updates**.

### Related information

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)<br>
[Manage bookmarks](manage-bookmarks.md)<br>
[Customize the visual display of your analytics reports](customize-reports.md)<br>
[Manage real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service)<br>
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)<br>
[View and understand the Ongoing conversation report in Omnichannel real-time analytics](realtime-ongoing.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
