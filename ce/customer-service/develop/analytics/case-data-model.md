---
title: Case analytics data model
description: Understand fact tables, aggregate tables, dimensions, and reporting relationships in the modern case analytics data model.
ms.date: 10/30/2026
ms.topic: concept-article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# Case analytics data model

Use the case analytics data model to analyze case performance, service-level agreement (SLA) performance, and active backlog. Fact tables provide individual case and SLA execution details. Aggregate tables summarize results, and related dimensions let you filter and group the data.

The model differs from the legacy case analytics model described in [Data models and report mappings for historical analytics reports](../../use/oob-data-models.md).

## Aggregate tables

Choose the aggregate that matches your reporting question: case outcomes, SLA KPI executions, or captured backlog.

| Table | Description |
|---|---|
| [AggCaseAnalytics](aggcaseanalytics.md) | Aggregates case data for volume, response and resolution outcomes, feedback, reopens, and case-level SLA performance. |
| [AggCaseSLA](aggcasesla.md) | Aggregates SLA KPI executions for SLA performance and attainment analysis across cases. |
| [AggCaseSnapshot](aggcasesnapshot.md) | Provides a point-in-time view of active cases for analyzing backlog, response status, assignment coverage, case age, and staleness. |

All three aggregates use 15-minute case-creation intervals in `DateTimeKey`. Queue, owner, worker, status, and other classifications reflect the latest known state or the state observed at snapshot capture. They don't show assignment at resolution time.

## Fact tables

Use fact tables to explore the individual records behind case and SLA results.

| Table | Description |
|---|---|
| [FactCase](factcase.md) | One row per case, with assignment, status, resolution, tracked time, customer feedback, and support entitlement details. |
| [FactSLAKPIInstance](factslakpiinstance.md) | One row per SLA key performance indicator (KPI) execution, with the associated case, SLA policy, KPI, and execution status. |

The tables are linked by `CaseId`. One case can have multiple SLA executions, so count distinct cases when combining the tables to avoid counting the same case more than once.

For example, use `FactCase` with [DimCaseEntitlement](dimcaseentitlement.md) to analyze cases by support entitlement. Use `FactSLAKPIInstance` with [DimCaseSLAKPI](dimcaseslakpi.md) to compare individual SLA results by measure. Available details depend on the source data.



## Case dimensions

Use dimensions to filter, group, and analyze cases by descriptive attributes. The default semantic model includes some dimensions; others are available for detail or custom analysis.

| Dimension | Description |
|---|---|
| [DimCaseOwner](dimcaseowner.md) | Users or teams that own cases, including a category for cases without an assigned owner. |
| [DimCaseWorker](dimcaseworker.md) | Current or last known workers assigned to cases, who might differ from case owners. |
| [DimCaseOrigin](dimcaseorigin.md) | Channels through which cases are received. |
| [DimCasePriority](dimcasepriority.md) | Priority levels that indicate how urgently cases need attention. |
| [DimCaseType](dimcasetype.md) | Categories used to classify cases by the type of customer request. |
| [DimCaseStatus](dimcasestatus.md) | Current case status and the reason for that status. |
| [DimCaseProduct](dimcaseproduct.md) | Products associated with cases. |
| [DimCaseSLAKPI](dimcaseslakpi.md) | Measures tracked by service-level agreements (SLAs), such as first response or resolution. |
| [DimCaseAgeBand](dimcaseageband.md) | Age ranges that group active cases by how long they've been open. |
| [DimCaseSeverity](dimcaseseverity.md) | Severity levels that describe the impact of cases. |
| [DimSubject](dimsubject.md) | Topics and subtopics used to organize cases by subject. |
| [DimCaseSLA](dimcasesla.md) | SLA policies associated with cases. |
| [DimCaseEntitlement](dimcaseentitlement.md) | Support entitlements associated with cases, including the customer and support terms. |

## Shared dimensions and relationships

The model also uses these shared dimensions:

- `DimDate` provides date information for time-based analysis.
- `DimTimeZone` supports time-zone-based reporting.
- `DimQueue` provides queue information.
- `DimBusinessUnit` provides business unit information.

`DimDate` has one row per 15-minute interval. Don't use `Date` as a unique relationship key: its value repeats across intervals.

Creation-time filters follow this relationship path:

```text
DimDate.DateTimeKey
    -> DimTimeZone.LocalDateTimeKey
    -> DimTimeZone.UtcDateTimeKey
    -> ProxyUtcDateId.UtcDateTimeKey
    -> aggregate.DateTimeKey
```

## Related information

[Case dashboard](../../use/case-dashboard.md)   
[Case metrics reference](../../use/case-metrics.md)    
