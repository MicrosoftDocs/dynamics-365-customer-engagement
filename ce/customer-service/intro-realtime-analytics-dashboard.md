---
title: "Introduction to Real time Omnichannel analytics dashboard| MicrosoftDocs"
description: "Introduction to Real time Omnichannel analytics dashboard"
ms.date: 09/28/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# Introduction to Omnichannel Real time analytics dashboards (preview)

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

In the digital contact center world, supervisors need to react to events like increase in the volume of incoming customer interactions, longer call lengths and agent absenteeism by optimizing the allocation of agents in real-time to provide quick support and boost customer satisfaction. Having visibility into overall support performance through real-time reporting empowers them to monitor key operational metrics, make course corrections at the right time and keep service levels high.

Dynamics 365 customer service real time analytics provide information about the health and key performance indicators (KPIs) for your organization, that reflect the situation in the contact center as agents handle customer conversations coming through multiple channels.

The key capabilities of the feature include:

- Conversation – Contact center managers will be able to understand the volume of customer interactions, service levels along with the available capacity in real time. 
- Agent report providing the agent capacity, status for the past 24 hours with a drill down ability to see details at each agent level with their capacity, adherence, and so on.
- Voice report providing Omnichannel voice specific metrics for the past 24 hours.
- Conversation list report providing the list of current ongoing/closed conversations.
- Visual customization supported 
- Auto refresh / Pause refresh to help users to see real time metrics and interact with the report.

As a supervisor, you can view the Real time Omnichannel analytics dashboard in the Customer Service Workspace application. Select the dashboard on the left panel to open it.  

Omnichannel real time analytics consists of the following reports. 

- **Summary**: 

- **Voice**: 

- **Agent**: This tab provides an overview of information about the health and KPIs of agents in your organization. The information in this report is displayed based on the last 24 hours conversations. To learn more, see [View and understand the Agents report in Omnichannel real time analytics](realtime-agents-analytics.md). If you're unable to view the reports, contact your system administrator. More information: [Configure realtime analytics dashboard](enable-realtime-analytics-dashboard-administrator.md). The real time analytics reports are available only in the English language, out of the box. You'll need to customize the reports to make them available in a language of your choice.

- **Ongoing Conversations**: This tab provides information about the conversations that agents are handling and are in active, open, wrap up, and waiting status reason. To learn more, see [Ongoing Conversations dashboard](realtime-ongoing-conversations-dashboard .md).

## Security 
Real time analytics honors the security permissions defined in Dataverse. For example, if your organization has set BU level permission for the report user, then the user will only be able to see the metrics computed based on the BU level data.  

> [!NOTE]
> If multiple users see different values in the metrics, you need to investigate the permissions across those users as this might be the reason for not seeing the same values in metrics.  

### See also

[Configure to view intraday insights dashboard](configure-intraday-dashboard-supervisor.md)  
[View and understand Omnichannel intraday insights dashboard](intraday-insights-dashboard.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  
[Monitor and assign conversations](monitor-conversations.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
