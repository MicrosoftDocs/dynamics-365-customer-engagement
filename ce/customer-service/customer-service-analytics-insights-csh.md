---
title: Insights dashboard overview | Microsoft Docs
description: Learn about the various dashboards and reports for historical operational metrics and KPIs to manage contact centers.
author: lalexms
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: laalexan
manager: shujoshi
ms.date: 10/22/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Dashboard overview

The Insights dashboards for Customer Service contain a variety of charts and metrics to help you to understand the factors that have the greatest impact on customer service for your organization. Key performance indicators and visual breakdowns of your organization's support cases are coupled with AI-generated insights on cases, agents, and topics that contribute to overall trends.

Customer Service dashboards give you a performance summary in addition to detailed reports on agents and topics.  

Right-clicking on a chart entry and hovering over **Drill through**, selecting **Agent Details** or **Topic details** brings up a more detailed report that's specific to the selected agent or topic.

Navigate to the Knowledge Search analytics tab to view key details about what search terms agents and smart agent assist are using to find knowledge articles related to cases. For more information, see [Knowledge search analytics dashboard](knowledge-search-analytics-cs.md).

## Configure dashboards

To enable the dashboards, see the following topics:

- [Configure historical analytics reports](configure-historical-analytics-csh.md)

- [Configure knowledge search insights](enable-knowledge-search-analytics.md)

## Customer Service historical analytics reports

The following dashboard reports are available for Customer Service historical analytics:

### Summary

The Summary dashboard gives you a broad overview of the customer service experience in your organization. It uses artificial intelligence (AI) technology to show you topics that are generating the highest volume and emerging topics with the highest rate of change in volume.

   > [!div class=mx-imgBorder]
   > ![Analytics Summary dashboard](media/summary-dashboard-analytics-cs.png "Customer Service analytics Summary dashboard")
   
For more details about the Summary dashboard, see [Summary dashboard](summary-dashboard-cs.md)

### Agent

The Agent dashboard shows charts and KPIs for individual agents and overall agent performance.

   > [!div class=mx-imgBorder]
   > ![Analytics Agent dashboard](media/agent-dashboard-analytics-cs.png "Customer Service analytics Agent dashboard")
   
For more details about the Agent dashboard, see [Agent dashboard](agent-dashboard-cs.md)

### Case Topics

The Case Topics dashboard shows a detailed breakdown of cases and their assigned topics.

   > [!div class=mx-imgBorder]
   > ![Analytics Topics dashboard](media/topics-dashboard-analytics-cs.png "Customer Service analytics Topics dashboard")
   
For more details about the Case Topics dashboard, see [Topics dashboard](topics-dashboard-cs.md)

## Omnichannel historical analytics report

The following dashboard reports are available for Omnichannel historical analytics.

### Conversation

The Conversation dashboard gives you a broad overview of the assisted support customer service experience in your organization.  

> [!div class="mx-imgBorder"]
> ![Conversation dashboard](media/conversation-dashboard.png "Conversation dashboard")

For more details about the conversation report, see [Conversation dashboard](conversation-dashboard.md)

### Queue

The Queue dashboard gives you a broad overview of the customer service experience in your organization by providing insights into how specific queues are operating.

> [!div class="mx-imgBorder"]
> ![Queue dashboard](media/queue-report.png "Queue dashboard")

For more details about the queue report, see [Queue dashboard](queue-dashboard.md)

### Agent

The Agent dashboard shows charts and KPIs that you can use to guide agents and understand overall agent performance.

> [!div class="mx-imgBorder"]
> ![Agent dashboard](media/agent-report-cs.png "Agent report").

For more details about the Agent report, see [Agent dashboard](agent-dashboard-cs.md)

### Bot

The Bot dashboard shows charts and KPIs that you can use to understand how bots are playing a role in a support organization. 

> [!div class="mx-imgBorder"]
> ![Bot dashboard](media/bot-dashboard-cs.png "Bot dashboard")

For more details about the bot report, see [Bot dashboard]()

### Conversation Topics

The Topics dashboard shows a detailed breakdown of conversations and their assigned topics. 

> [!div class="mx-imgBorder"]
> ![Conversation Topics](media/conversation-topics-dashboard.png "Conversation Topics")

For more details about the Conversation Topics dashboard, see 

### Knowledge Search Analytics report

The knowledge search analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles.

> [!div class="mx-imgBorder"]
> ![Knowledge search analytics report](media/knowledge-search-anlaytics-dashboard.png "Knowledge search analytics")

For more details about the Knowledge Search Analytics report, see [Knowledge Search Analytics Report](knowledge-search-analytics-cs.md)

## Information you need to know about the analytics reports

### Reports refresh, data retention

The following information is applicable to reports refresh:

- **Data refresh:** Occurs every 24 hours. The reports are available during the refresh process. You might see a warning icon beside the **Last refresh (UTC)** label in the upper-right corner of each report when there's a delay or issue in the data refresh. When you hover over the icon, the tooltip message indicates whether the dataset is up to date.
  > [!div class=mx-imgBorder]
  > ![Customer Service Analytics refresh status](media/cs-analytics-refresh-status.png "Customer Service Analytics refresh status")

- **Custom refresh:** Isn't available.
- **Data refresh for inactive environments:** Data refresh is paused if the reports aren't used continuously for two weeks. When you access a report after a lengthy period of inactivity, the report will be refreshed in the subsequent refresh cycle.
- **Data retention:** Data is retained for a period of 24 months.

### Report customizations

Currently, report customizations aren't supported.

### Supported tables

The following tables are leveraged for Customer service Historical Analytics:

- incident
- incidentresolution
- appmodule
- organization
- msfp_surveyresponse
- msfp_question
- msfp_questionresponse
- msdyn_casetopic
- msdyn_casetopic_incident
- msdyn_casetopicsetting
- Queue
- QueueItem
- Subject
- SystemUser

> [!NOTE]
> A report might be blank if you've customized any of the listed entities or are using out-of-the-box entities.

## Troubleshooting

To troubleshoot issues when you try to access or view the reports, do the following.

|   Error message    |            Action         |
|-------------------------|------------------------|
| Oops! No reports were found in CRM. You may not have access to these reports. Please contact your system administrator.       |   Contact your administrator to get access.     |  
| Oops! Internal service error, please contact your system administrator with Error Code: {numeric value}.   |   Contact Microsoft Support and create a support ticket.     | 
|   Oops! There was a problem rendering the report.   |   Refresh the report. If this doesn't work, contact Microsoft Support and create a support ticket.     |  
| Oops! There was a problem rendering the report, please try again.   |   Refresh the report. If this doesn't work, contact Microsoft Support and create a support ticket    |

### See also

[Introduction to Customer Service insights](introduction-customer-service-analytics.md)  
[Configure Customer Service insights for Customer Service Hub and Customer Service workspace](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service analytics in Power BI](configure-customer-service-analytics-dashboard.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]