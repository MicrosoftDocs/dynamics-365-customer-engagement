---
title: AggCaseSnapshot table reference
description: Learn about the AggCaseSnapshot table and the dimensions and metrics available for analyzing active cases, backlog, case age, assignment, and response status.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# AggCaseSnapshot table reference

Use `AggCaseSnapshot` to analyze active cases, backlog, case age, response status, assignment, and staleness at the latest capture. The table contains only the latest snapshot, not historical backlog trends.

## Grain and source

Each row summarizes cases with the same snapshot date, creation period, queue, owner, worker, business unit, origin, priority, case type, status, product, and age band.

Use `DateTimeKey` for case creation time and `SnapshotDate` for capture time. These fields distinguish case age from the date when the case's state was observed.

## Dimension columns

Filter and group cases by queue, owner, priority, status, age, and the other attributes in this table.

| Column | Type | Description |
|---|---|---|
| `SnapshotDate` | DATE | Date of the case data capture. |
| `DateTimeKey` | BIGINT | Case creation time in UTC, grouped into 15-minute intervals. |
| `QueueId` | STRING | Case's current or last known queue. |
| `OwnerKey` | STRING | Case owner. Relates to [DimCaseOwner](dimcaseowner.md). |
| `WorkerKey` | STRING | Case's current or last known worker. Relates to [DimCaseWorker](dimcaseworker.md). |
| `CaseBusinessUnitId` | STRING | Case's owning business unit. |
| `OriginCode` | INT | Case origin. Relates to [DimCaseOrigin](dimcaseorigin.md). |
| `PriorityCode` | INT | Case priority. Relates to [DimCasePriority](dimcasepriority.md). |
| `CaseTypeCode` | INT | Case type. Relates to [DimCaseType](dimcasetype.md). |
| `CaseStatusKey` | STRING | Case state and status reason at capture. Relates to [DimCaseStatus](dimcasestatus.md). |
| `ProductId` | STRING | Case product. Relates to [DimCaseProduct](dimcaseproduct.md). |
| `AgeBandCode` | STRING | Active case's age range. Relates to [DimCaseAgeBand](dimcaseageband.md). |

## Metric columns

Use these counts and durations to analyze volume, response and assignment status, age, and staleness. Apply the aggregation specified for each column.

| Column | Type | Aggregation | Description |
|---|---|---|---|
| `CaseCount` | BIGINT | SUM | Number of cases at capture time, including resolved and canceled cases. |
| `ActiveCaseCount` | BIGINT | SUM | Number of active cases at capture time. |
| `AwaitingResponseCount` | BIGINT | SUM | Number of active cases awaiting a first response. |
| `UnknownResponseCaseCount` | BIGINT | SUM | Number of active cases with unavailable first-response status. |
| `KnownUnassignedCount` | BIGINT | SUM | Number of active cases with no worker assigned. |
| `UnknownAssignmentCaseCount` | BIGINT | SUM | Number of active cases with unavailable assignment status. |
| `ActiveAgeSecondsSum` | BIGINT | SUM | Total active-case age in seconds. |
| `ActiveAgeValidCount` | BIGINT | SUM | Number of active cases with a valid age value. |
| `OldestActiveAgeSeconds` | BIGINT | MAX | Oldest active-case age in seconds. |
| `ActiveLastUpdateAgeSecondsSum` | BIGINT | SUM | Total elapsed seconds since active cases' last updates. |
| `ActiveLastUpdateAgeValidCount` | BIGINT | SUM | Number of active cases with a valid last-update age. |
| `OldestActiveLastUpdateAgeSeconds` | BIGINT | MAX | Longest elapsed time since an active case's last update, in seconds. |
| `StaleCaseCount` | BIGINT | SUM | Number of active cases whose last update was at least seven calendar days before the capture date. |

> [!NOTE]
> Any case update, including an automated update, affects last-update age. Staleness doesn't necessarily measure time since a service representative last worked on the case.

## Age bands

Group active cases by age with `AgeBandCode`.

| Code | Display label | Age |
|---|---|---|
| `D0_1` | 0-1 day | Less than 2 days. |
| `D2_7` | 2-7 days | At least 2 days and less than 8 days. |
| `D8_30` | 8-30 days | At least 8 days and less than 31 days. |
| `D31_89` | 31-89 days | At least 31 days and less than 90 days. |
| `D90Plus` | 90+ days | At least 90 days. |
| `NotActive` | Not active | Case isn't active, or its age information is unavailable. |

## Metadata columns

Use these columns to identify the creation period, record count, and refresh time for each aggregate row.

| Column | Type | Description |
|---|---|---|
| `_AggregationDate` | DATE | Date associated with the case creation period. |
| `_SourceRecordCount` | BIGINT | Number of case records represented by the aggregated row. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | Last data refresh date and time in UTC. |

## Measure examples

Use these examples to calculate active-case counts, average and oldest age, and stale case rate.

```dax
Active Cases =
    SUM(AggCaseSnapshot[ActiveCaseCount])
```

```dax
Avg Active Case Age (days) =
    DIVIDE(
        SUM(AggCaseSnapshot[ActiveAgeSecondsSum]),
        SUM(AggCaseSnapshot[ActiveAgeValidCount])
    ) / 86400
```

```dax
Oldest Active Case Age (days) =
    MAX(AggCaseSnapshot[OldestActiveAgeSeconds]) / 86400
```

```dax
Stale Case Rate =
    DIVIDE(
        SUM(AggCaseSnapshot[StaleCaseCount]),
        [Active Cases]
    )
```

## Import and refresh

Each refresh updates the table with the latest case data and replaces the previous view of the backlog. Earlier views aren't saved. 

## Related information

[Case metrics reference](../../use/case-metrics.md)   
[Case analytics data model](case-data-model.md)   