---
title: FactSLAKPIInstance table reference
description: Learn about the FactSLAKPIInstance table and the execution details available for analyzing case SLA results by policy, KPI, and status.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# FactSLAKPIInstance table reference

Use `FactSLAKPIInstance` to analyze individual service-level agreement (SLA) key performance indicator (KPI) executions associated with cases. For summarized SLA results, use [AggCaseSLA](aggcasesla.md).

## Grain and source

Each row represents one SLA KPI execution, identified by `SLAKPIInstanceId`. An execution tracks an SLA measure, such as first response or resolution, for an individual case.

One case can have multiple executions. Execution counts aren't case counts: a case with two breached executions contributes two breaches but only one breached case.

## Dimension columns

Use these columns to identify an execution and analyze results by case, SLA policy, or KPI.

| Column | Type | Description |
|---|---|---|
| `SLAKPIInstanceId` | STRING | Unique SLA KPI execution identifier. |
| `CaseId` | STRING | Associated case. Relates to [FactCase](factcase.md). |
| `SLAItemId` | STRING | SLA rule associated with the execution. |
| `SLAId` | STRING | SLA policy associated with the rule. Relates to [DimCaseSLA](dimcasesla.md). |
| `SLAKPIId` | STRING | SLA KPI measured by the execution. Relates to [DimCaseSLAKPI](dimcaseslakpi.md). |

The KPI identifies what's measured. The SLA rule determines the applicable target. This table doesn't include target durations.

## Execution status

Use `StatusCode` (INT) to identify the execution's latest available outcome or progress.

| Value | Status | Description |
|---|---|---|
| `0` | In progress | The execution is still in progress. |
| `1` | Noncompliant | The SLA target was breached. |
| `2` | Nearing | The execution is nearing its SLA target. |
| `3` | Paused | The SLA timer is paused. |
| `4` | Succeeded | The SLA target was met. |
| `5` | Canceled | The execution was canceled. |

A blank or unrecognized status means the outcome is unknown. Don't treat it as met or breached. These codes differ from the case's first-response SLA status codes in [FactCase](factcase.md).

## Date and metadata columns

Use these columns to understand the execution's applicability and data refresh date.

| Column | Type | Description |
|---|---|---|
| `ApplicableFrom` | TIMESTAMP | Date and time from which the SLA applies, when available. This isn't the case creation date or the time the target was met or breached. |
| `_StartDate` | DATE | Date the SLA KPI execution record was created. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | Last data refresh date and time in UTC. |

The table doesn't include breach deadlines, success timestamps, or elapsed execution durations.

## Relationships and coverage

Use `CaseId` to relate executions to [FactCase](factcase.md) for case details, such as queue, owner, priority, and case creation date. For case reporting, include only executions linked to a known case. Count distinct cases if you need case totals rather than execution totals.

SLA policy and KPI details depend on the available rule information and might be blank. The table is available only when the required SLA execution data is available.

## Measure example

To match the SLA attainment measure in [AggCaseSLA](aggcasesla.md), divide succeeded executions by executions with a known status other than canceled. Include in-progress, nearing, and paused executions in the denominator.

For example, three succeeded executions, one breached execution, and one pending execution give 60% attainment. Adding a canceled execution doesn't change the percentage. If there are no eligible executions, leave the result blank.

For case-level SLA outcomes, use [AggCaseAnalytics](aggcaseanalytics.md) instead of counting executions.

## Related information

[Case analytics data model](case-data-model.md)    
[FactCase table reference](factcase.md)       
[AggCaseSLA table reference](aggcasesla.md)       
