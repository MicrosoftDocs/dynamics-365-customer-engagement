---
title: "Introduction to Real time Omnichannel analytics dashboard| MicrosoftDocs"
description: "Introduction to Real time Omnichannel analytics dashboard"
ms.date: 10/14/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# Introduction to Omnichannel Real-time analytics dashboards (preview)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

In the digital contact center world, supervisors need to react to events like increase in the volume of incoming customer interactions, longer call lengths and agent absenteeism by optimizing the allocation of agents in real time to provide quick support and boost customer satisfaction. Having visibility into the overall support performance through real-time reporting empowers them to monitor key operational metrics, make course corrections at the right time and keep service levels high.

The real-time analytics reports provide information about the health and key performance indicators (KPIs) for your organization, that reflect the situation in the contact center as supervisors oversee agents handling customer conversations coming through multiple channels.

The key capabilities of the feature include:

- Ability for supervisors to monitor key operational metrics in near real-time, and to make course corrections at the right time and keep service levels high​.

- Ability to optimize the allocation of agents in near real-time to provide top notch support and boost customer satisfaction.

- Ability to improve agent staffing, effectiveness, and utilization by adjusting work distribution.

- Ability to monitor ongoing conversation, track customer sentiment and intervene as required.

- Ability to drill down as required to a specific channel, queue, or agent (and more) to gather key operational insights in real-time and react to it.

 You could use the **Edit report** option to customize the visual display of reports. For example, modify the visual look of the data, such as to display a metric trend over time versus a tabular view. You could also create visuals using metrics in the data model that aren't directly exposed in the out-of-box reports. More information: [Customize visual display of historical analytics reports in Customer Service](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service). You can save personalized views of your reports as bookmarks and use the **Bookmarks** option to  select a saved view, update or delete a bookmark, and set a default bookmark. More information: [Manage bookmarks for reports](manage-bookmarks.md#manage-bookmarks-for-reports)

Data on the report is refreshed near real-time. You can use the **Auto refresh** or **Pause updates** option to see real-time metrics and interact with the report. Additionally, you could use the filters on the dashboards like agent, time of day, or queue to drill down KPIs across the dashboard. You can adjust the filters based on insights you are looking for.

 The Omnichannel real-time analytics reports consist of the following:

- **Summary**: This report provides an overview of your organization in near real time. This report provides KPIs across the volume of customer interactions and service levels along with the available capacity in near real time.

- **Voice**: This report provides an overview of conversations in the last 24 hours for the Omnichannel Voice channel.

- **Agent**: This report provides an overview of the health and KPIs of agents in your organization. The information in this report is displayed based on the conversations in the last 24 hours. To learn more, see [View and understand the Agents report in Omnichannel real time analytics](realtime-agents-analytics.md).

- **Ongoing Conversations**: This report provides information about the conversations that agents are handling and are in either active, open, wrap up, or waiting statuses. To learn more, see [Ongoing Conversations dashboard](realtime-ongoing-conversations-dashboard.md).

If you're unable to view the reports, contact your system administrator. More information: [Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview) The real time analytics reports are available only in the English language, out of the box. You'll need to customize the reports to make them available in a language of your choice. More information: [Customize data models of historical analytics reports in Customer Service (preview)](model-customize-reports.md#customize-data-models-of-historical-analytics-reports-in-customer-service-preview)

## Security 

As a supervisor, you can view the real-time Omnichannel analytics dashboard in Customer Service Workspace. However, your administrator must enable the required permissions for you. More information: [Provide report access to additional security roles](enable-realtime-analytics-dashboard-administrator.md#provide-report-access-to-additional-security-roles)

Real-time analytics honors the security permissions defined in Dataverse. For example, if your organization has set BU level permission for the report user, then the user will only be able to see the metrics computed based on the BU level data.  

> [!NOTE]
> If multiple users see different values in the metrics, you need to investigate the permissions across those users as this might be the reason for not seeing the same values in metrics. 

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[View and understand the Summary report in Omnichannel real time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Voice report in Omnichannel real time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
