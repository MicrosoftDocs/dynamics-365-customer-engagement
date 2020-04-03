---
title: View and understand Customer Service Analytics and Insights in Customer Service Hub | Microsoft Docs
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

# Preview: View and understand Customer Service Analytics and Insights

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Customer Service Analytics reports

The following reports are available for Customer Service Analytics:

- **Case Summary**

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics Case Summary report](media/cs-case-summary-csh.png "Customer Service Analytics Analytics Case Summary report")

- **Agent Summary**

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics Agent Summary report](media/cs-agent-summary-csh.png "Customer Service Analytics Analytics Agent Summary report")

The following KPIs are available.

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

You can use the following filters in the reports.

|Filters / Dimensions  |Description        |
|----------------------|-------------------|
|Duration              |Filters the reporting date range.|
|Queue                 |Provides an ability for the user to filter the queue into which they would like to drill deeper and see all metrics related to that queue. |
|Agent                 |Provides an ability for the user to filter all their reporting agents to understand how each is performing and plan to coach/train agents.  |
|Priority              |Filters the reporting to the selected priority of the case. (High, Normal, Low) |
|Subject               |Filters the reporting to the selected subject of the case.  |
|Channel               |Filters the reporting to the selected Omnichannel channels. (Example: Chat, SMS, Facebook)  |

When you select a filter condition, the data is automatically filtered and rendered in the report.

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics view and filter report](media/cs-analytics-view-filer-report.png "Customer Service Analytics view and filter report")

> [!NOTE]
>
> For the **Date** filter, the **Next** option will not display results in the report.

For detailed information about the reports, see [Case Summary report](customer-service-analytics.md#1-summary) and [Agent Summary report](customer-service-analytics.md#2-agent-and-queue).

## Information you need to know about Customer Service Analytics reports

### Reports refresh, data retention

The following information is applicable to reports refresh:

- **Data refresh:** Occurs every 24 hours. The reports are available during the refresh process. You might see a warning icon beside the **Last refresh (UTC)** label on the top right of each report when there is a delay or issue in the data refresh. When you hover the mouse over the icon, the tool tip message indicates whether the data set is up to date.
  > [!div class=mx-imgBorder]
  > ![Customer Service Analytics refresh status](media/cs-analytics-refresh-status.png)

- **Custom refresh:** Is not available.
- **Data refresh for inactive environments:** Data refresh is paused if the reports are not used continuously for two weeks. When a user accesses a report after a lengthy period of inactivity, the report will be refreshed in the subsequent refresh cycle.
- **Data retention:** Data is retained for a period of 24 months.

### Report customizations

Currently report customizations are not supported.

### Supported entities

The following entities are supported:

- Activitypointer
- Appmodule
- Incident
- Incidentresolution
- Organization
- Queue
- Queueitem
- Subject
- Systemuser

> [!NOTE]
>
> - A report might be blank if you have customized any of the listed entities or do not use the out-of-the-box entities.

## Regions supported in Customer Service Analytics reports

The Customer Service Analytics reports are supported in the following regions.

- North America
- South America
- Canada
- Europe, except France
- Asia Pacific, Japan
- Australia
- Japan
- India
- Great Britian

## Understand Customer Service Insights reports

Dynamics 365 Customer Service Insights gives you actionable insights into critical performance metrics, operational data, and emerging trends from your customer service system. Built-in dashboards, interactive charts, and visual filters provide views into support operations data across channels, and highlight areas for improvement that can have the greatest impact, helping you quickly evaluate and respond to key performance indicators (KPIs) and customer satisfaction levels. For more information about insights, see [Customer Service Insights](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/overview).

## Preview: Use the Customer Service Insights reports in Customer Service Hub

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

### Create and view reports

IF you have access to Customer Service , and if the Customer Service Insights reports have not been created for you or shared with you, you can create the reports in Customer Service Hub. Navigate to **Service** > **Insights (Preview)**, and click **Complete** on the **Analytics and insights settings** page.

> [!NOTE]
>
> You must be assigned to a security role that has the permission to view the site map for Customer Service Insights reports. Also, you must have a valid Customer Service Insights license to create, view, and share the reports.   You can select **Share** at the top of the report to share the reports.

The report consist of five pivots as follows:

- [Home](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/keyinsights)
- [KPI summary](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/dashboard-kpi-summary)
- [New cases](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/dashboard-incoming-cases)
- [Customer satisfaction](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/dashboard-csat)
- [Resolutions](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/dashboard-case-resolutions)

## Troubleshooting

To troubleshoot issues when you try to access or view the reports, do the following.

|   Error message    |            Action         |
|-------------------------|------------------------|
| Oops! No reports were found in CRM. You may not have access to these reports. Please contact your system administrator.       |   Contact your administrator to get access.     |  
| Oops! Internal service error, please contact your system administrator with Error Code: {numeric value}.   |   Contact Microsoft Support and create a support ticket.     | 
|   Oops! There was a problem rendering the report.   |   Refresh the report and if it doesn’t work, contact Microsoft Support and create a support ticket.     |  
| Oops! There was a problem rendering the report, please try again.   |   Refresh the report and if it doesn’t work, contact Microsoft Support and create a support ticket    |

### See Also

[Introduction to Customer Service Analytics and Insights](introduction-customer-service-analytics.md)

[Configure Customer Service Analytics and Insights in Customer Service Hub](configure-customer-service-analytics-insights-csh.md)

[Configure Customer Service Analytics in Power BI](configure-customer-service-analytics-dashboard.md)