---
title: Agent Dashboard | Microsoft Docs
description: Learn about the Agent dashboard insights to better understand agent performance in your organization.
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

# Agent dashboard

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

The Agent dashboard shows charts and KPIs that you can use to guide agents and understand overall agent performance.

![Agent dashboard](media/agent-dashboard-analytics-cs.png "Agent dashboard")

To view the Agent dashboard, navigate to customer service historical analytics and select **Agent** at the top of the workspace. The dashboard shows charts and KPIs for individual agents and overall agent performance, and includes the following insights:

> [!div class="mx-imgBorder"]
> ![Agent dashboard Insights](media/agent-dashboard.png "Agent dashboard insights")

To view the agent dashboard, go to Omnichannel historical analytics and select **Agent** in the workspace. The dashboard shows charts and KPIs for individual agents and overall agent performance.

## Report details

The reports summarize the key performance indicators for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, agent conversation and timezone. KPIs for the dashboard are displayed as shown.

> [!div class="mx-imgBorder"]
> ![Agent report](media/agent-report-cs.png "Agent report dashboard")

This table displays the key performance indicators in the agent report. 

| KPI            | Description    |
|----------------|----------------|
| Active cases   |  The number of cases that are currently open.   |
| Resolved cases   | The number of cases that have been closed by an agent.     |
| Escalated cases   | The percentage of cases that have been escalated.     |
| Average resolve time | The average time taken by an agent to resolve the case.   |
| Average CSAT   | The average customer satisfaction score, based on written feedback submitted by the customer in the Customer Voice survey.    |
| Average survey sentiment | The average sentiment score, based on written feedback submitted by the customer in the Customer Voice survey.  |

The agent dashboard has charts that have the following metrics.

| KPI            | Description    |
|----------------|----------------|
| Case volume over duration   |  Day-over-day trend of case volume.   |
| Average resolve time  | Month-over-month trend of case resolution time in minutes.     |
| CSAT and survey sentiment by agent   | Agent-focused view comparing CSAT and sentiment from Customer Voice survey responses.     |
| Agent metrics | Overview of core agent metrics in relation to other metrics and date.   |

## Agent drill down view

The Agent drill down view provides supervisors with a holistic look into individual agent performance on metrics and can be valuable in training/coaching scenarios for agents. 

To access the drill down, select any metric value for the desired agent and select **Details**.

> [!div class="mx-imgBorder"]
> ![Agent drill down view](media/agent-drill-down-view.png "Agent drill down view table")


### See also

- [Dashboard overview](customer-service-analytics-insights-csh.md) <br>
- [Summary dashboard](summary-dashboard-cs.md) <br>
- [Topics dashboard](topics-dashboard-cs.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]