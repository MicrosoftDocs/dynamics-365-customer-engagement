---
title: Overview of the real-time Omnichannel analytics dashboard
description: Use Omnichannel real-time analytics dashboard for contact center operations. Track key metrics and access summary, voice, agents, and ongoing conversation reports to improve team performance.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: overview
ms.collection:
ms.date: 10/31/2025
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
---

# Overview of Omnichannel real-time analytics dashboard

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. It isn't intended to be used, and should **not** be used, to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements.
>
> Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws that are related to accessing individual employee analytics, and monitoring, recording, and storing communications with users. As part of this compliance, customers must adequately notify users that their communications with customer service representatives (service representatives or representatives) might be monitored, recorded, or stored. As required by applicable laws, customers must also obtain consent from users before they use this feature with them. In addition, customers are encouraged to have a mechanism in place to inform their service representatives that their communications with users might be monitored, recorded, or stored.

In the digital contact center world, supervisors must be able to react to events by optimizing the allocation of service representatives in real time to provide quick support and boost customer satisfaction. Such events include an increase in the volume of incoming customer interactions, longer call lengths, and service representative absenteeism. By providing visibility into overall support performance, real-time reporting helps supervisors monitor key operational metrics, make course corrections at the appropriate time, and keep service levels high.

The real-time analytics reports provide information about the health and key performance indicators (KPIs) for your organization. They reflect the current situation in the contact center as supervisors oversee service representatives who handle customer conversations that come in through multiple channels. You can change the visual display of the reports and save your personalized views as bookmarks.

As a supervisor, you can use the real-time analytics reports to perform these tasks:

- Monitor key operational metrics in near-real time, and make course corrections at the appropriate time to help keep service levels high.
- Review the allocation of service representatives in near-real time, and then optimize to provide top-notch support and boost customer satisfaction.
- Improve service representative staffing, effectiveness, and utilization by reviewing the skill set and capacity profile of the service representative. You can then assign or transfer ongoing conversations by filtering through queue or service representative.
- Monitor ongoing conversations, track customer sentiment, and intervene as required.
- Drill down to a specific channel, queue, or service representative as required, to gain key operational insights in real time, and take the necessary action.

> [!NOTE]
> The reports include conversations that only service representatives handled. They also include conversations that Copilot agents escalated. However, they don't include conversations that Copilot agents resolved.

## Security roles and permissions

Real-time analytics takes advantage of the security permissions that are defined in Dataverse. For example, if your organization set business unit-level permissions for you, only metrics that are computed based on business unit–level data are shown to you.

As a supervisor, you can view the **Omnichannel real-time analytics** dashboard in Copilot Service workspace. However, your administrator must provide the required permissions for you. [Learn how to configure user roles to access analytics and dashboards.](../administer/configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards)

> [!NOTE]
> If different values are shown to different users in the metrics, you must investigate the permissions for those users.

## Access reports

In the site map of Copilot Service workspace, select **Omnichannel real-time analytics** in **Service**. The **Summary** report appears by default. To switch reports, select the required report from the report filter. 

:::image type="content" source="../media/dashboard-filter-realtime.png" alt-text="Screenshot of report filter.":::

For example, to view the **Agent** report, select **Agent** from the report filter.

If you can't view the reports, contact your system administrator. Learn more in [Manage real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md).

## Dashboard details

> [!NOTE]
> - The reports don't include work items of the Entity Record channel. All entity record-type queues are available in [real-time analytics for record routing dashboards](rr-overview.md#overview-of-real-time-analytics-for-record-routing) only.
> - The reports are prefiltered based on the queues you're signed in to as a supervisor. Your view of metrics and conversations pertain to the assigned queues only, which helps ensure data privacy and relevance.

The **Omnichannel real-time analytics** dashboard consists of the following reports:

- **Summary**: This report provides an overview of your organization in real time. It provides KPIs across the volume of customer interactions and service levels, together with the available capacity in real time. Learn more in the [Summary report](realtime-summary-dashboard.md).
- **Voice**: This report provides an overview of conversations for the voice channel. Learn more in the [Voice report](realtime-voice-dashboard.md).
- **Agents**: This report provides an overview of the health and KPIs of service representatives in your organization. The information that is shown on this report is based on the conversations. Learn more in the [Agents report](realtime-agents-analytics.md).
- **Ongoing conversation**: This report provides information about the conversations that service representatives are handling and that are in active, open, wrap-up, or waiting status. Use it to monitor, assign, transfer, and forcibly close conversations for service representatives, after reviewing their skill set and capacity profiles. Learn more in the [Ongoing conversation report](realtime-ongoing.md).
- **Backlog conversation**: The Backlog conversation report lists all open, active, and waiting conversations that were created in the last 30 days. It allows you to view persistent chats that are longer than 24 hrs. Learn more in [Backlog conversation report](realtime-backlog-conv.md#view-and-understand-the-backlog-conversation-report-in-omnichannel-real-time-analytics).
- **Bot**: The Bot report provides insights into key metrics for all the Copilot agents used in your contact center. It allows you to monitor the volumes of in-progress and completed AI agent conversations. Learn more in [Bot report](/dynamics365/contact-center/use/agent-realtime-dashboard). 

## Filter information displayed on dashboard

Use the filters to drill down to KPIs across the dashboard. Adjust the filters based on the insights that you're looking for. The filters that are available by default include **Time**, **Agent**, **Channel**, **Queue**, **Time zone**, and **Conversation status**, and **Conversation skill**. 

For example, the dropdown list for the **Time** filter includes the following options:

- **2 hrs**: By default, shows all conversations from the last 2 hours. You can see conversations up to last 24 hours.
- **Today**: Shows all conversations started or modified in the selected time zone.

:::image type="content" source="../media/realtime-time-filter.png" alt-text="Screenshot of the Time filter on real-time analytics.":::

### Pause updates on report data

Report data is automatically updated in real time for all the reports except the **Ongoing conversation** report. The report data on that report must be manually updated. You can use the **Pause updates** option to view and analyze real-time metrics at any point in time. To resume automatic updates of the report data, select **Resume updates**.

### Related information

[Use report metrics](oc-metrics-dimensions.md)<br>
[Manage bookmarks](manage-bookmarks.md)<br>
[Customize the visual display of your analytics reports](customize-reports.md)<br>
[Manage real-time analytics reports](../administer/enable-realtime-analytics-dashboard-administrator.md)<br>
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)<br>
[View and understand the Ongoing conversation report in Omnichannel real-time analytics](realtime-ongoing.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
