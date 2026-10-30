---
title: Overview of case analytics using the Shared Analytics Platform
description: Learn how modern case analytics helps you understand support demand, review service outcomes, and monitor case backlog in Dynamics 365 Customer Service.
ms.date: 10/30/2026
ms.topic: overview
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
ai-usage: ai-assisted
---

# Overview of case analytics using the Shared Analytics Platform

Customer service historical analytics using the Shared Analytics Platform turns case data into consistent metrics for historical reporting and analysis. In Dynamics 365 Customer Service, you can use these metrics to understand support demand, review service outcomes, and identify areas that need attention.

Whether you're a supervisor monitoring response completion or an operations leader reviewing resolution and customer feedback, you can use the Case dashboard to investigate performance. A shared data model gives case volume, SLA performance, and backlog measures common definitions, so you can interpret results consistently across report pages.

The dashboard brings together case creation trends, resolution outcomes, survey feedback, and the latest captured backlog. You can compare results by queue, worker, owner, priority, origin, and other case classifications without preparing separate calculations for each view.

The dashboard isn't a direct replacement for [Customer Service historical analytics](summary-dashboard-cs.md). Metric definitions, reporting populations, and available detail can differ. Before using case analytics for business reviews, compare key metrics with matching filters and review the changes your custom reports need. Learn more about definitions and calculations in [Case metrics reference](case-metrics.md).

> [!IMPORTANT]
> The date range selects cases **created** during the selected period, not response or resolution events that occurred during that period. Backlog metrics describe those cases at the latest capture. The report doesn't provide historical backlog trends.

## How the platform turns case data into insights

The Shared Analytics Platform connects case records and SLA executions to descriptive information and precalculated summaries. You don't need to work with these tables to use the dashboard, but understanding their roles helps you interpret results and plan custom analysis.

### Ingestion and storage

The analytics pipeline uses Dataverse case data and related sources, such as resolution activities, SLA KPI executions, survey responses, and assignment information. It publishes analytics tables in Delta format for downstream reporting.


### Transformation and semantic model

The model uses a star schema that connects detailed activity and summaries to dimensions.

| Table type | What it contributes to your analysis |
|---|---|
| Dimension tables | Provide context, such as queue, owner, worker, origin, priority, product, and status. Use these attributes to filter and group results. |
| Fact tables | Store case and SLA execution detail used by pipeline calculations and detail analysis. The default dashboard doesn't import these tables or provide individual case lists. |
| Aggregate tables | Store counts, duration totals, score totals, and matching denominators. These summaries support dashboard queries and consistent calculations across filters. |

Learn more in [Case analytics data model](../develop/analytics/case-data-model.md).

### Analytics consumption

The Power BI report shows consistent metrics across seven pages. Shared filters let you compare case volume, outcomes, and backlog for cases created in the same period. Drill-through views show hourly case creation patterns for a selected worker or queue.

The report's data model stores and refreshes summarized data for cases created in the past 24 months. By default, the report shows the last 12 months. 

## Find the right report page and metrics for your business question

Choose a page based on the question you want to answer. All pages are part of the [Case historical analytics dashboard](case-dashboard.md).

| What do you want to understand? | Report page | Metrics and analysis |
|---|---|---|
| What is the overall demand, and how are cases progressing? | **Summary** | Total and closed cases, escalation rate, SLA attainment, resolution time, CSAT, and survey sentiment. |
| Which classifications drive support demand? | **Volume & mix** | Case creation trends and breakdowns by origin, priority, status, product, and case type. |
| Are cases receiving responses, and how are SLAs performing? | **Response & SLA** | First-response completion, execution-level SLA attainment, case-level verdicts, and breached cases by queue. |
| Are cases reopening or taking repeated resolutions? | **Quality** | Reopened cases, reopened rate, reopens per case, and time to first versus latest known resolution. |
| Which parts of the current backlog need attention? | **Aging** | Active cases, elapsed age bands, awaiting-response counts, stale cases, and queue-level backlog distribution. |
| How do outcomes compare across workers? | **Agent** | Worker-attributed case outcomes, resolution time, reopens, feedback, SLA attainment, and active cases. |
| Which queues need operational attention? | **Queue** | Queue-level volume, response completion, resolution time, feedback, SLA attainment, and backlog. |

Review [Case metrics reference](case-metrics.md) before comparing results or building a custom report. It explains denominators, blank values, source coverage, and distinctions such as response completion versus first-response elapsed time.

Worker and queue attribution reflects current or last known assignment, not necessarily who resolved a case or where it was assigned when an SLA completed. Backlog age is measured at capture time, not when you open the report.

## Extend analysis for your organization


You can extend analytics at different layers depending on your requirements.

| Scenario | Use |
|---|---|
| Change visualizations, layouts, filters, or report pages | [Report customization](/dynamics365/contact-center/administer/modern-contact-center-analytics-journey#customize-report-visuals) |
| Create measures, combine additional governed data, or build role-specific reports | [Power BI data model customization](/dynamics365/contact-center/administer/modern-contact-center-analytics-journey#customize-the-power-bi-data-model) |
| Perform data engineering, data science, cross-domain analysis, or create a customer-owned semantic model | [Microsoft Fabric](/dynamics365/contact-center/administer/modern-contact-center-analytics-journey#extend-analytics-with-microsoft-fabric) |


## Related information

[Case dashboard](case-dashboard.md)  
[Case metrics reference](case-metrics.md)   
[Case analytics data model](../develop/analytics/case-data-model.md)   
