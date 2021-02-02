---
title: Topics Dashboard | Microsoft Docs
description: Learn about the Topics dashboard insights to better understand agent performance in your organization.
author: lalexms
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: laalexan
manager: shujoshi
ms.date: 02/02/2021
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

# Preview: Topics dashboard

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

The Topics dashboard shows a detailed breakdown of cases and their assigned topics. Customer Service Insights uses AI-generated topics and natural language understanding to automatically group your cases to help you better understand how different case types and topic areas are impacting your organization’s support performance.

![Topics dashboard](media/topics-dashboard-analytics-cs.png "Topics dashboard")

To view the Topics dashboard, navigate to customer service historical analytics and select **Topics** at the top of the workspace. 

## Key insights card

![Topics Key insights discovery card](media/topics-key-insights-card.png "Topics Key insights discovered card")

The Key insights discovered card has three areas:

- Topics to watch
- Topics impacting CSAT
- Topics impacting resolution time

## Report details

The KPI summary charts summarize the key performance indicators for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, and agent.

KPIs for the following areas are displayed:

| KPI     | Description     |
|------------|--------------|
| Total cases   |  The number of cases created to support customers.     |
| Active cases  |  The number of cases that are currently opened.      |
| Escalated cases   | The percentage of cases that have been escalated.     |
| Average handle time   | The average length of time taken by an agent to resolve the case.   |
| Average CSAT     | The average customer satisfaction score, based on Customer Voice survey submitted by the customer.   |
| Average sentiment    |  The average sentiment score, based on Customer Voice survey written feedback submitted by the customer.    |


The topic metrics chart has the following metrics displayed:

| Chart     | Description     |
|------------|--------------|
| Total cases |  The number of cases created to support customers.    |
| Occurrence by topic   | Percentage of cases classified to each given topic.   |
| Average resolution time  | Month over month trend of case resolution time in minutes.   |
| Average CSAT    | The average customer satisfaction score, based on Customer Voice survey submitted by the customer.   |
| CSAT impact     |       |
| Average sentiment   | The average sentiment score, based on Customer Voice survey written feedback submitted by the customer.      |
| Sentiment impact    |       |

### See also
- [Dashboard overview](customer-service-analytics-insights-csh.md) <br>
- [Summary dashboard](summary-dashboard-cs.md) <br>
- [Agent dashboard](agent-dashboard-cs.md) 
