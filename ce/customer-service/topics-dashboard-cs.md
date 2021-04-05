---
title: Topics Dashboard | Microsoft Docs
description: Learn about the Topics dashboard insights to better understand agent performance in your organization.
author: lalexms
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: laalexan
manager: shujoshi
ms.date: 04/05/2021
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

# Topics dashboard

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

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
| Average handle time   | The average time taken by an agent to resolve the case.   |
| Average CSAT    | The average customer satisfaction score, based on written feedback submitted by the customer in the Customer Voice survey.   |
| Average sentiment    |  The average sentiment score, based on written feedback submitted by the customer in the Customer Voice survey.    |


The topic metrics chart has the following metrics displayed:

| Chart     | Description     |
|------------|--------------|
| Total cases |  The number of cases created to support customers.    |
| Occurrence by topic   | Percentage of cases classified to each given topic.   |
| Average resolution time  | Month over month trend of case resolution time in minutes.   |
| Average CSAT    | The average customer satisfaction score, based on Customer Voice survey submitted by the customer.   |
| CSAT impact     | The amount that the given topic is driving the overall CSAT trend for the organization.     |
| Average sentiment   | The average sentiment score, based on Customer Voice survey written feedback submitted by the customer.      |
| Sentiment impact    | The amount that the given topic is driving the overall sentiment trend for the organization.     |

### Case topics drill down view

The Topic drill down view provides supervisors with a holistic look into individual topics in reference to key business metrics and can be valuable in understanding why end customers are contacting support. 

To access the drill down, select any metric value for the desired topic and select **Details**.

> [!div class="mx-imgBorder"] 
> ![Case topics drill down view](media/case-topics-drill-down-view.png "Case topics drill view")

### Enable availability of topics for Power Virtual Agent bots

AI discovered topics in Customer Service historical analytics are often prime candidates as topics for automation in Power Virtual Agents bots. If Power Virtual Agents bot is available in the region that your Customer Service organization is located, the feature can be enabled by the administrator for use. 

> [!div class="mx-imgBorder"]
> ![Automate topics to Power virtual agents](media/automate-topics-to-PVA.png "Automate topics to Power virtual agents")

After a topic is identified as a good automation candidate, the automation workflow can be triggered by selecting **Power virtual agents** on the **Topic metrics** grid. Select **Details** and then select **Automate to bot** within the drill through view. This will launch the topic editing form.  

> [!div class="mx-imgBorder"]
> ![Editing form for Power virtual agents](media/PVA-editing-form.png "Editing form")

The topic is provided as well as suggested trigger phrases based on the case title. The first step is to select the Power Virtual Agents bot that is ideal for adding the topic to. If no bot exists, selecting **Create Bot** will redirect to the Power Virtual Agents application for bot creation. Both the topic name and trigger phrases can be modified, and in the case of trigger phrases, additional ones can be added.

> [!NOTE]
> Any bots created via the Microsoft Teams channel will not be listed in the bot selection dropdown. Users creating bots using the drill down page for a topic in CSW will be redirected to CSH for form completion. 

### See also

- [Dashboard overview](customer-service-analytics-insights-csh.md) <br>
- [Summary dashboard](summary-dashboard-cs.md) <br>
- [Agent dashboard](agent-dashboard-cs.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]