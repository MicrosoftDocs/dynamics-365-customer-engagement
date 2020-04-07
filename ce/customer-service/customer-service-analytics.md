---
title: View and understand Customer Service Analytics | Microsoft Docs
description: Dashboards and reports provide historical operational metrics and KPIs to manage contact centers.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
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

# View and understand Customer Service Analytics

## Customer Service Analytics dashboard

The Customer Service Analytics dashboard that is created in Microsoft Power BI provides information about the historical operational metrics and key performance indicators (KPIs) to effectively manage contact centers.

The following is an example of the Customer Service Analytics overview dashboard:  

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics overview dashboard](media/cs-analytics-overview-dashboard.png "Customer Service Analytics overview dashboard")

This section consists of the following KPIs:  

| KPI                       | Description         |
|---------------------------|-------------------------|
|Total cases                |Number of cases created to support customers.      |
|Active cases               |Number of cases that are currently open.          |
|Resolved cases             |Number of cases that have been closed by an agent.   |
|Escalated cases %          |Percentages of cases that have been escalated.    |
|Average handle time (hrs) |Average length of time taken by an agent to resolve the case. |
|Avg. CSAT                  |Average customer satisfaction score based on the survey submitted by the customer. |
|Case age                    |Average time the case was in an open state.                 |
|Total activities            |Total activities that are created by agents                |

This section also consists of the following filters:

|Filters / Dimensions  |Description        |
|----------------------|-------------------|
|Duration              |Filters the reporting date range.|
|Queue                 |Provides an ability for the user to filter the queue into which they would like to drill deeper and see all metrics related to that queue. |
|Agent                 |Provides an ability for the user to filter all their reporting agents to understand how each is performing and plan to coach/train agents.  |
|Priority              |Filters the reporting to the selected priority of the case. (High, Normal, Low) |
|Subject               |Filters the reporting to the selected subject of the case.  |
|Channel               |Filters the reporting to the selected Omnichannel channels. (Example: Chat, SMS, Facebook)  |

## Customer Service Analytics reports

The following is an example of the Customer Service Analytics report detail view.

The Customer Service Analytics report detail view has three views:

- [Summary](#1-summary)

- [Agent/queue](#2-agent-and-queue)

- [Case/activity list](#3-case-and-activity-list)

### 1. Summary

  This view provides KPIs and metrics across customer service with an ability for supervisors to filter the view:

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics summary view](media/cs-analytics-summary-view.png "Customer Service Analytics summary view")

   This section contains the following visuals/KPIs:

   |Visual / KPI              |Description                   |
   |---------------------------|------------------------------|
   |Incoming cases by channel  |This visual shows the volume of cases created in each of the support channels. |
   |Incoming cases by priority |This visual shows the volume of active and resolved cases by priority.        |
   |Incoming cases by subject  |This visual shows active and resolved cases by subject. This considers the last node in the subject hierarchy. |
   |Incoming cases by SLA status |This visual shows the volume of active and resolved cases by SLA status.      |
   |Case volume trend           |This visual shows the trend of active and resolved cases based on the time the case was created. |
   |Case by age                 |This visual groups the cases that are currently open and grouped on the number of days/weeks/months they are currently open. |
   |Escalated case trend        |This visual shows the trend of cases escalated over the period selected. |
   |CSAT trend                  |This visual shows the CSAT trend over the period selected.  |

### 2. Agent and queue

   This view provides KPIs and metrics across customer service with an ability for supervisors to filter the view:

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics agent/queue view](media/cs-analytics-agent-queue-view.png "Customer Service Analytics agent/queue  view")

   This section contains the following visuals/KPIs:

   |Visual / KPI              |Description                            |
   |---------------------------|---------------------------------------|
   |Agents with most cases     |This visual shows the top agents who have handled the most cases along with the states of those cases.|
   |Agents with most open activities          |This visual shows the agents with the most open activities. This helps users enable agents to clear the backlog.|
   |Agents with highest avg. handle time      |This visual shows the agents with the highest average handle time.|
   |Agents with highest CSAT                  |This visual shows the agents with the highest CSAT. |
   |Agents with lowest CSAT                   |This visual shows the agents with the lowest CSAT. Supervisors use this information to train agents and improve overall customer satisfaction.|
   |Key influencers for CSAT                   |This visual shows the factors that drive the CSAT metric. It analyzes data, ranks the factors that matter, and displays them as key influencers. |
   |Open activities by agent                  |This visual shows the number of open activities by agent and type of activity.|

### 3. Case and activity list

   This section provides a detailed view of cases and activities that a supervisor can use to drill into each case or activity to help resolve customer issues. The link in this report directs the user to customer service or the customer service hub application in Dynamics 365.  

   > [!NOTE]
   > Prerequisite for the link to work: you must have either a Customer Service Hub application or Customer Service app installed from AppSource.

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics case/activity list view](media/cs-analytics-case-activity-list-view.png "Customer Service Analytics case/activity list view")

## View and filter report  

Filter information by viewing the reports and selecting from Duration, Queue, Agent, Case priority, Subject, and Case status. 

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics view and filter report](media/cs-analytics-view-filer-report.png "Customer Service Analytics view and filter report")

Select the subject as needed, and information is filtered according to your selection. This helps to quickly analyze KPIs and take necessary steps to improve outcomes.

### See Also

[Introduction to Customer Service Analytics and Insights](introduction-customer-service-analytics.md)

[Configure Customer Service Analytics and Insights in Customer Service Hub](configure-customer-service-analytics-insights-csh.md)

[View and understand Customer Service Analytics and Insights in Customer Service Hub](customer-service-analytics-insights-csh.md)

[Configure Customer Service Analytics in Power BI](configure-customer-service-analytics-dashboard.md)
