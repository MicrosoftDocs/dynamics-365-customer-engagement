---
title: AggCaseAnalytics table reference
description: Learn about the AggCaseAnalytics table and the dimensions and metrics available for analyzing case volume, response, resolution, customer feedback, reopens, and SLA performance.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# AggCaseAnalytics table reference

Use `AggCaseAnalytics` to analyze aggregated case volume, response and resolution performance, customer feedback, reopens, and case-level service-level agreement (SLA) performance.

## Grain and source

Each row summarizes cases with the same creation period, queue, origin, priority, status, business unit, owner, worker, case type, and product.

`DateTimeKey` groups case creation times into 15-minute intervals. Other attributes, such as queue, owner, worker, and status, reflect current or last known values.

## Dimension columns

Filter and group cases by queue, origin, priority, owner, status, product, and the other attributes in this table.

| Column | Type | Description |
|---|---|---|
| `DateTimeKey` | BIGINT | Case creation time in UTC, grouped into 15-minute intervals. |
| `QueueId` | STRING | Case's current or last known queue. |
| `CaseOriginCode` | INT | Case origin. Relates to [DimCaseOrigin](dimcaseorigin.md). |
| `PriorityCode` | INT | Case priority. Relates to [DimCasePriority](dimcasepriority.md). |
| `CaseStatusCode` | INT | Case's current status reason. |
| `AgentBusinessUnitId` | STRING | Worker's business unit. |
| `OwnerKey` | STRING | Case owner. Relates to [DimCaseOwner](dimcaseowner.md). |
| `WorkerKey` | STRING | Case's current or last known worker. Relates to [DimCaseWorker](dimcaseworker.md). |
| `CaseBusinessUnitId` | STRING | Case's owning business unit. |
| `CaseTypeCode` | INT | Case type. Relates to [DimCaseType](dimcasetype.md). |
| `CaseStatusKey` | STRING | Case state and status reason. Relates to [DimCaseStatus](dimcasestatus.md). |
| `ProductId` | STRING | Case product. Relates to [DimCaseProduct](dimcaseproduct.md). |

> [!NOTE]
> Ownership and worker assignment are separate. A team-owned case can still have an assigned worker.

## Metric columns

The following columns provide counts and totals for case performance measures.

### Volume and response

| Column | Type | Description |
|---|---|---|
| `TotalCases` | BIGINT | Number of cases. |
| `ActiveCaseCount` | BIGINT | Number of currently active cases. For captured backlog metrics, use [AggCaseSnapshot](aggcasesnapshot.md). |
| `ResolvedCases` | BIGINT | Number of currently resolved cases. |
| `CancelledCases` | BIGINT | Number of currently canceled cases. |
| `EscalatedCases` | BIGINT | Number of cases marked as escalated. |
| `FirstResponseSentCount` | BIGINT | Number of cases with a sent first response, including canceled cases. |
| `ResponseEligibleCaseCount` | BIGINT | Number of noncanceled cases with known first-response status. |
| `ResponseCompletedCaseCount` | BIGINT | Number of eligible cases with a sent first response. |
| `ResponseUnknownCaseCount` | BIGINT | Number of noncanceled cases with unavailable first-response status. |

### Resolution, feedback, and reopens

| Column | Type | Description |
|---|---|---|
| `FirstResolutionSecondsSum` | BIGINT | Total elapsed seconds to the first known resolution for resolved cases with valid resolution data. |
| `LatestResolutionSecondsSum` | BIGINT | Total elapsed seconds to the latest known resolution for resolved cases with valid resolution data. |
| `ResolutionValidCaseCount` | BIGINT | Number of resolved cases with valid resolution data. Use as the denominator for average first or latest resolution time. |
| `CSATScoreSum` | DOUBLE | Total of valid CSAT scores. |
| `CSATValidResponseCount` | BIGINT | Number of valid customer satisfaction (CSAT) responses. |
| `SentimentScoreSum` | DOUBLE | Total of valid survey sentiment scores. |
| `SentimentValidResponseCount` | BIGINT | Number of valid survey sentiment responses. |
| `EverResolvedCaseCount` | BIGINT | Number of cases that have been resolved at least once. |
| `ReopenedCaseCount` | BIGINT | Number of cases that were reopened after a known resolution. |
| `ReopenEventCount` | BIGINT | Number of known reopen events. |
| `SurveyedCaseCount` | BIGINT | Number of cases with at least one valid CSAT response. |
| `TrackedTimeMinutesSum` | DOUBLE | Total tracked minutes, including fractional minutes. For each case, includes only time entries marked as Final if any exist; otherwise, includes all time entries. |
| `TrackedCaseCount` | BIGINT | Number of cases with a tracked-time value under this rule. Use as the denominator for average tracked time. |

First and latest resolution times measure elapsed calendar time, not active work time.

For tracked time, cases without a value are excluded from the average, but cases with zero recorded minutes are included. Both `TrackedCaseCount` and `TrackedTimeCount` count cases, not individual time entries. To calculate either average across multiple rows, divide the sum of the tracked-time totals by the sum of the corresponding case counts.

### Case-level SLA performance

Use these columns to understand SLA performance at the case level.

| Column | Type | Description |
|---|---|---|
| `SLAInScopeCaseCount` | BIGINT | Number of cases included in SLA performance calculations. |
| `SLABreachedCaseCount` | BIGINT | Number of cases with at least one breached SLA. |
| `SLAMetCaseCount` | BIGINT | Number of cases for which all applicable SLA requirements were met. |
| `SLAPendingCaseCount` | BIGINT | Number of cases with an SLA that's still in progress, nearing its target, or paused and doesn't have a breach. |
| `SLAOutOfScopeCaseCount` | BIGINT | Number of cases without an applicable SLA. |
| `SLAUnknownCaseCount` | BIGINT | Number of cases for which SLA status isn't available. |

Each case has one SLA outcome. When multiple SLA results apply, the outcome follows this order: breached, pending, unknown, and met.

To analyze individual SLA KPI executions instead of cases, use [AggCaseSLA](aggcasesla.md).

### Additional columns

These columns are available in the table but aren't included in the default [case dashboard](../../use/case-dashboard.md).

| Columns | Type | Description |
|---|---|---|
| `CustomerContactedCount`, `TotalChildIncidents` | BIGINT | Number of cases marked as contacted and number of child cases. |
| `TotalCaseAgeInDays`, `CaseAgeCount` | DOUBLE, BIGINT | Total case age and the number of cases with an age value. |
| `TotalHandleTimeInMinutes`, `HandleTimeCount` | BIGINT | Total elapsed minutes from case creation to resolution and the corresponding case count. This isn't active handling time. |
| `TotalTrackedTimeInMinutes`, `TrackedTimeCount` | BIGINT | Total tracked minutes from all time entries, regardless of category, and the corresponding case count. Each entry is converted to whole minutes before summing, so fractional minutes are discarded. Unlike `TrackedTimeMinutesSum`, this total doesn't give preference to Final entries. |
| `TotalCSATScore`, `CSATResponseCount` | DOUBLE, BIGINT | Total case-level CSAT score and the number of cases with a score. |
| `TotalSentimentScore`, `SentimentResponseCount` | DOUBLE, BIGINT | Total case-level sentiment score and the number of cases with a sentiment score. |
| `FirstResponseInSLACount`, `FirstResponseSLAExpiredCount` | BIGINT | Number of cases that met or exceeded their first-response SLA target. |

## Metadata columns

Use these columns to identify the creation period, record count, and refresh time for each aggregate row.

| Column | Type | Description |
|---|---|---|
| `_AggregationDate` | DATE | Date associated with the case creation period. |
| `_SourceRecordCount` | BIGINT | Number of case records represented by the aggregated row. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | Last data refresh date and time in UTC. |

## Measure examples

Calculate first-response completion by dividing completed cases by eligible cases:

```dax
FRT Completed % =
    DIVIDE(
        SUM(AggCaseAnalytics[ResponseCompletedCaseCount]),
        SUM(AggCaseAnalytics[ResponseEligibleCaseCount])
    )
```

Calculate average CSAT by dividing the total valid score by the number of valid responses:

```dax
Avg CSAT =
    DIVIDE(
        SUM(AggCaseAnalytics[CSATScoreSum]),
        SUM(AggCaseAnalytics[CSATValidResponseCount])
    )
```

For example, two cases with three valid survey responses and a combined CSAT score of 12 have an average CSAT of 4.

## Refresh and coverage

The table covers a rolling 24 months based on case creation date. Changes to a case update its original creation period.

Response, survey, SLA, and resolution-history metrics depend on source data and might be unavailable for some cases. Don't treat unavailable values as zero.

## Related information

[Case metrics reference](../../use/case-metrics.md)   
[Case analytics data model](case-data-model.md)    