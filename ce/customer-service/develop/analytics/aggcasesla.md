---
title: AggCaseSLA table reference
description: Learn about the AggCaseSLA aggregate table, its case-creation grain, execution status counts, and SLA calculation.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# AggCaseSLA table reference

Use `AggCaseSLA` to analyze service-level agreement (SLA) key performance indicator (KPI) execution outcomes and attainment. Counts represent executions, not cases: one case can have several executions.

## Grain and source

Each SLA KPI execution linked to a case is counted separately. Executions are grouped by the case's creation time and the following reporting attributes:

```sql
GROUP BY
    DateTimeKey,
    QueueId,
    OwnerKey,
    WorkerKey,
    CaseBusinessUnitId,
    OriginCode,
    PriorityCode,
    CaseTypeCode,
    CaseStatusKey,
    ProductId,
    SLAKPIId
```

Interpret `DateTimeKey` as case creation time, not SLA applicability, execution start, breach, or success time. Queue and assignment reflect the case's current or last known assignment, not its assignment when the SLA completed.

## Dimension columns

| Column | Type | Description |
|---|---|---|
| `DateTimeKey` | BIGINT | Case creation time in UTC, rounded down to a 15-minute interval. |
| `QueueId` | STRING | Case's current active queue or, if none, last known queue. If neither is available, the case's SLA executions are grouped under (Unassigned).|
| `OwnerKey` | STRING | Case owner key, including principal type. Relates to [DimCaseOwner](dimcaseowner.md). |
| `WorkerKey` | STRING | Current or last known worker key, including principal type. Relates to [DimCaseWorker](dimcaseworker.md). |
| `CaseBusinessUnitId` | STRING | Case's owning business unit, not the worker's business unit. |
| `OriginCode` | INT | Relates to `DimCaseOrigin.CaseOriginCode` in [DimCaseOrigin](dimcaseorigin.md). |
| `PriorityCode` | INT | Relates to [DimCasePriority](dimcasepriority.md). |
| `CaseTypeCode` | INT | Relates to [DimCaseType](dimcasetype.md). |
| `CaseStatusKey` | STRING | Current case lifecycle state and status reason. Relates to [DimCaseStatus](dimcasestatus.md). |
| `ProductId` | STRING | Relates to [DimCaseProduct](dimcaseproduct.md). |
| `SLAKPIId` | STRING | SLA KPI measured by the execution. Relates to [DimCaseSLAKPI](dimcaseslakpi.md). |

SLA policy, entitlement, severity, and subject aren't grouping keys.

## Metric columns

| Column | Type | Description |
|---|---|---|
| `InstanceCount` | BIGINT | Total number of case-linked executions in the row. |
| `NonCanceledInstanceCount` | BIGINT | Executions with a known status other than canceled. Includes in-progress, nearing, and paused executions. |
| `SucceededInstanceCount` | BIGINT | Executions with succeeded status. |
| `BreachedInstanceCount` | BIGINT | Executions with noncompliant status. |
| `PendingInstanceCount` | BIGINT | In-progress, nearing, or paused executions. |
| `CanceledInstanceCount` | BIGINT | Canceled executions, excluded from the attainment denominator. |
| `UnknownStatusInstanceCount` | BIGINT | Executions with a missing or unrecognized status. Excluded from the attainment denominator. |

Source execution statuses use these codes: `0` In progress, `1` Noncompliant, `2` Nearing, `3` Paused, `4` Succeeded, and `5` Canceled. Don't interpret them as the case's first-response SLA status codes.

## Metadata columns

| Column | Type | Description |
|---|---|---|
| `_AggregationDate` | DATE | Case creation interval date. Used for partitioning, not for a direct date-dimension relationship. |
| `_SourceRecordCount` | BIGINT | Number of prepared executions contributing to the row. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | Last data refresh date and time in UTC. |

## SLA attainment

Calculate attainment by dividing summed succeeded executions by summed known, noncanceled executions:

```dax
SLA Attainment =
    DIVIDE(
        SUM(AggCaseSLA[SucceededInstanceCount]),
        SUM(AggCaseSLA[NonCanceledInstanceCount])
    )
```

For example, three succeeded executions, one breached execution, and one pending execution give a score of 60% attainment. The pending execution remains in the denominator. One additional canceled execution increases `InstanceCount` to six without changing attainment.

An absent or zero denominator returns blank. Calculate the ratio from totals; don't average individual aggregate row percentages.

## Relationships and refresh

Use dimensions to filter and group SLA results. Filtering by `DimCaseSLAKPI` affects only this table, not case totals in `AggCaseAnalytics` or backlog counts in `AggCaseSnapshot`.

The report includes the most recent 24 months of data. When an older case's SLA results change, refresh the data for the period when the case was created.

To count cases with breached, met, pending, unknown, or out-of-scope SLA outcomes, use `AggCaseAnalytics`. For example, a case with two breached SLA executions counts as two breaches in `AggCaseSLA`, but only one breached case in `AggCaseAnalytics`.

## Related information

[Case metrics reference](../../use/case-metrics.md)   
[Case analytics data model](case-data-model.md)   
