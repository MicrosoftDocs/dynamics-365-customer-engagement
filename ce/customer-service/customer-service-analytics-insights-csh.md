---
title: View and understand Customer Service analytics and insights in Customer Service Hub | Microsoft Docs
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

# Preview: View and understand Customer Service analytics and insights

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Customer Service analytics reports

The following reports are available for Customer Service analytics:

- **Case Summary**

   > [!div class=mx-imgBorder]
   > ![Customer Service analytics Case Summary report](media/cs-case-summary-csh.png "Customer Service analytics Case Summary report")

- **Agent Summary**

   > [!div class=mx-imgBorder]
   > ![Customer Service analytics Agent Summary report](media/cs-agent-summary-csh.png "Customer Service analytics Agent Summary report")

The following KPIs are available.

| KPI                       | Description         |
|---------------------------|-------------------------|
|Total cases                |The number of cases created to support customers.      |
|Active cases               |The number of cases that are currently open.          |
|Resolved cases             |The number of cases that have been closed by an agent.   |
|Escalated cases %          |The percentage of cases that have been escalated.    |
|Average handle time (hrs) |The average length of time taken by an agent to resolve the case. |
|Avg. CSAT                  | The average customer satisfaction score, based on the survey submitted by the customer. |
|Case age                    |The average time the case was in an open state.                 |
|Total activities            |The total number of activities that were created by agents.              |

You can use the following filters in the reports.

|Filters / Dimensions  |Description        |
|----------------------|-------------------|
|Duration              |Filters the reporting date range.|
|Queue                 |Lets you filter the queue you'd like to drill down to and see all metrics related to that queue. |
|Agent                 |Lets you filter the report to show all the agents who report to you, to understand how each is performing and help you develop coaching and training plans.  |
|Priority              |Filters the reporting to the selected priority of the case (high, normal, or low). |
|Subject               |Filters the reporting to the selected subject of the case.  |
|Channel               |Filters the reporting to the selected Omnichannel for Customer Service channels, such as chat, SMS, or Facebook.  |

When you select a filter condition, the data is automatically filtered and rendered in the report.

   > [!div class=mx-imgBorder]
   > ![Customer Service analytics view and filter report](media/cs-analytics-view-filer-report.png "Customer Service analytics view and filter report")

> [!NOTE]
> For the **Date** filter, the **Next** option won't display results in the report.

For detailed information about the reports, see [Case Summary report](customer-service-analytics.md#1-summary) and [Agent Summary report](customer-service-analytics.md#2-agent-and-queue).

## Information you need to know about Customer Service analytics reports

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

### Supported entities

The following entities are supported:

- ActivityPointer
- AppModule
- Incident
- IncidentResolution
- Organization
- Queue
- QueueItem
- Subject
- SystemUser

> [!NOTE]
> A report might be blank if you've customized any of the listed entities or didn't use out-of-the-box entities.

## Regions supported in Customer Service analytics reports

The Customer Service Analytics reports are supported in the following regions:

- North America
- South America
- Canada
- Europe, except France
- Asia Pacific
- Australia
- Japan
- India
- Great Britain

## Understand Customer Service Insights reports

Dynamics 365 Customer Service Insights gives you actionable insights into critical performance metrics, operational data, and emerging trends from your customer service system. Built-in dashboards, interactive charts, and visual filters provide views into support operations data across channels, and highlight areas for improvement that can have the greatest impact, helping you quickly evaluate and respond to KPIs and customer satisfaction levels. More information: [Customer Service Insights](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/overview)

## Preview: Use the Customer Service Insights reports in Customer Service Hub

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

### Create and view reports

If you have access to Dynamics 365 Customer Service, and if Customer Service Insights reports haven't been created for you or shared with you, you can create the reports in Customer Service Hub. Navigate to **Service** > **Insights (Preview)**, and then select **Complete** on the **Analytics and insights settings** page.

> [!NOTE]
> You must be assigned to a security role that has permission to view the site map for Customer Service Insights reports. Also, you must have a valid Customer Service Insights license to create, view, and share the reports. You can select **Share** at the top of the report to share it.

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
|   Oops! There was a problem rendering the report.   |   Refresh the report. If this doesn't work, contact Microsoft Support and create a support ticket.     |  
| Oops! There was a problem rendering the report, please try again.   |   Refresh the report. If this doesn't work, contact Microsoft Support and create a support ticket    |

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights in Customer Service Hub](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics in Power BI](configure-customer-service-analytics-dashboard.md)