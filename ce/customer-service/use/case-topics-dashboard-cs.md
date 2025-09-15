---
title: Topics dashboard
description: Learn about the Topics dashboard insights to better understand agent performance in your organization.
ms.date: 08/26/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection: bap-ai-copilot
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
searchScope:
- D365-App-customerservicehub
- D365-Entity-*
- D365-UI-Dashboard
- Dynamics 365
- Customer Service
- Customer Engagement
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Topics dashboard

The Topics dashboard shows a detailed breakdown of cases and their assigned topics. Customer Service Insights uses AI-generated topics and natural language understanding to automatically group your cases. This functionality can help you understand how different case types and topic areas affect your organization’s support performance. Learn how to [access the dashboard](customer-service-analytics-insights-csh.md#access-the-dashboards).

![Topics dashboard.](../media/topics-dashboard-analytics-cs.png "Topics dashboard")

## Key insights card

![Topics Key insights discovery card.](../media/topics-key-insights-card.png "Topics Key insights discovered card")

The **Key insights discovered** card has three areas:

- Topics impacting resolution time
- Topics impacting CSAT
- Topics impacting survey sentiment

## Report details

The key performance indicators (KPIs) summary charts summarize the KPIs for the specified time period and the percentage of change over the period. You can filter these areas by duration, channel, queue, and customer service representative (service representative or representative).

The topics dashboard report shows the following KPIs.

| KPI     | Description     |
|------------|--------------|
| Incoming cases   |  The number of cases created to support customers.     |
| Active cases  |  The number of cases that are currently open.      |
| Escalated rate   | The percentage of cases that were escalated.     |
| Avg. resolve time (hrs)   | The average time a representative took to resolve the case.   |
| SLA compliance | The percentage of cases that met the defined SLA.|
| Average CSAT    | The average customer satisfaction score, based on written feedback submitted by the customer in the Customer Voice survey.   |


The topic metrics chart shows the following metrics:

| Chart     | Description     |
|------------|--------------|
| Total cases |  The number of cases created to support customers.    |
| Occurrence by topic   | Percentage of cases classified to each given topic.   |
| Average resolution time  | Month over month trend of case resolution time in minutes.   |
| Average CSAT    | The average customer satisfaction score based on Customer Voice survey submitted by the customer.   |
| CSAT impact     | The amount that the given topic is driving the overall CSAT trend for the organization.     |
| Avg. survey sentiment   | The average sentiment score based on Customer Voice survey written feedback submitted by the customer.      |
| Survey sentiment impact    | The amount that the given topic is driving the overall sentiment trend for the organization.     |

### Case topics drill-down view

The case topics drill-down view provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding why end customers are contacting support.

To access the case topics drill down, select any metric value for the required topic, and then select **Details**.

> [!div class="mx-imgBorder"] 
> ![Case topics drill down view.](../media/case-topics-drill-down-view.png "Case topics drill view")

## Language availability for topics 

The topics capability in the Customer Service historical analytics reports comes with a natural language understanding model that can understand the text semantics and intent in the following languages: 

- English 
- French 
- German 
- Italian 
- Japanese 
- Portuguese 
- Simplified Chinese 
- Spanish 

> [!NOTE]
> While users can still use topic discovery in languages that aren't listed in this section, there might be differences in what they experience if they use topic discovery in unsupported languages.

### Related information

[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Summary dashboard](summary-dashboard-cs.md)  
[Representative dashboard](agent-dashboard-cs.md)  
[Manage report bookmarks](manage-bookmarks.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
