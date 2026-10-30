---
title: Case metrics reference for Shared Analytics Platform
description: Learn more about case metric definitions, DAX calculations, reporting populations, and data coverage caveats for modern analytics in Dynamics 365 Customer Service.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# Case metrics reference for Shared Analytics Platform

Use this reference to interpret case metrics for three reporting populations:

- Cases in a creation-date cohort.
- SLA KPI executions linked to those cases.
- Cases observed at the latest snapshot.

Don't interchange these populations or their denominators.

> [!IMPORTANT]
> Date filters on all three aggregates select cases by creation time. Resolution and closure metrics don't count resolution or closure events that occurred in the selected period. 

The DAX calculations use the semantic model's measure names and published column names. Visual captions can differ from measure names, particularly for resolution time.

## Volume and outcome metrics

These [AggCaseAnalytics](../develop/analytics/aggcaseanalytics.md) measures describe case volume and outcomes for the selected creation-date cohort.

| Measure | Definition | DAX calculation |
|---|---|---|
| Total Cases | All cases created in the selected period. | `SUM(AggCaseAnalytics[TotalCases])` |
| Resolved Cases | Cases in the cohort that are currently resolved. | `SUM(AggCaseAnalytics[ResolvedCases])` |
| Canceled Cases | Cases in the cohort that are currently canceled. | `SUM(AggCaseAnalytics[CancelledCases])` |
| Closed Cases | Cases in the cohort that are currently resolved or canceled. | `[Resolved Cases] + [Canceled Cases]` |
| Cancellation Rate | Canceled cases divided by all cases in the cohort. | `DIVIDE([Canceled Cases], [Total Cases])` |
| Escalated Cases | Cases marked as escalated. | `SUM(AggCaseAnalytics[EscalatedCases])` |
| Escalation Rate | Escalated cases divided by all cases in the cohort. | `DIVIDE([Escalated Cases], [Total Cases])` |
| High Priority Cases | Cases with the standard high-priority code, `1`. | `CALCULATE([Total Cases], DimCasePriority[PriorityCode] = 1)` |
| High Priority % | High-priority cases divided by total cases with the priority filter removed. | `DIVIDE([High Priority Cases], CALCULATE([Total Cases], REMOVEFILTERS(DimCasePriority)))` |

Current classification and assignment determine which groups a case belongs to. When the data refreshes, a case can move between queue, owner, worker, and status groups without changing its creation cohort.

## Response completion metrics

Response completion uses the case's first-response flag, not a first-response timestamp.

| Measure | Definition | DAX calculation |
|---|---|---|
| First Responses Sent | Cases whose first-response flag is sent, including canceled cases. | `SUM(AggCaseAnalytics[FirstResponseSentCount])` |
| First Responses Completed | Eligible, noncanceled cases whose first-response flag is known and sent. | `SUM(AggCaseAnalytics[ResponseCompletedCaseCount])` |
| First Response Eligible Cases | Noncanceled cases whose first-response flag is known. | `SUM(AggCaseAnalytics[ResponseEligibleCaseCount])` |
| FRT Completed % | First Responses Completed divided by First Response Eligible Cases. | `DIVIDE([First Responses Completed], [First Response Eligible Cases])` |

`ResponseUnknownCaseCount` counts noncanceled cases whose response flag is unknown. These cases aren't treated as unanswered and are excluded from the completion denominator.

Use `ResponseCompletedCaseCount`, not `FirstResponseSentCount`, for the completion numerator. `FirstResponseSentCount` includes canceled cases, but the completion denominator excludes them. Older aggregate rows can have a null completion count until their creation-date partitions are rebuilt.

FRT completion measures neither elapsed time to the first response nor whether that response met its SLA.

## Resolution time metrics

Both averages include only currently resolved cases for which both the first and latest known resolution durations are valid and nonnegative. Durations measure elapsed calendar time from case creation, not business hours or representative effort.

| Measure | Visual caption | DAX calculation |
|---|---|---|
| Avg Time to Resolution (hrs) | **Time to first resolution**. | `DIVIDE(SUM(AggCaseAnalytics[FirstResolutionSecondsSum]), SUM(AggCaseAnalytics[ResolutionValidCaseCount])) / 3600` |
| Avg Time to Close (hrs) | **Time to final resolution**. | `DIVIDE(SUM(AggCaseAnalytics[LatestResolutionSecondsSum]), SUM(AggCaseAnalytics[ResolutionValidCaseCount])) / 3600` |

The first known resolution can remain in history even after reopening cancels its resolution activity. Currently active, reopened cases don't contribute to either average.

"Final" means the latest known resolution of a currently resolved case, not its eventual final closure.

## Customer feedback metrics

Interpret feedback averages as response-weighted results, not averages of per-case scores.

| Measure | Definition | DAX calculation |
|---|---|---|
| CSAT Responses | Number of valid CSAT responses. | `SUM(AggCaseAnalytics[CSATValidResponseCount])` |
| Avg CSAT | Valid score sum divided by valid response count. | `DIVIDE(SUM(AggCaseAnalytics[CSATScoreSum]), [CSAT Responses])` |
| Sentiment Responses | Number of valid survey sentiment responses. | `SUM(AggCaseAnalytics[SentimentValidResponseCount])` |
| Avg Sentiment | Survey sentiment score sum divided by valid sentiment response count. | `DIVIDE(SUM(AggCaseAnalytics[SentimentScoreSum]), [Sentiment Responses])` |
| Survey Coverage | Cases with at least one valid CSAT response divided by cases resolved at least once. | `DIVIDE(SUM(AggCaseAnalytics[SurveyedCaseCount]), SUM(AggCaseAnalytics[EverResolvedCaseCount]))` |

Survey sentiment uses a 0-to-1 scale and isn't conversation sentiment.

Survey coverage isn't an invitation response rate. Its numerator counts surveyed cases in the cohort, not invitations, and isn't limited to surveyed cases in the denominator. Interpret survey coverage in the context of survey linkage and source coverage.

For response-weighted denominators, use `CSATValidResponseCount` and `SentimentValidResponseCount`. The published `CSATResponseCount` and `SentimentResponseCount` columns instead count cases with a per-case score.

## Reopen metrics

Reopen counts are inferred from retained resolution records, including resolution activities canceled by a reopen. There's no fixed reopen observation window.

| Measure | Definition | DAX calculation |
|---|---|---|
| Reopened Cases | Cases with two or more known resolutions, or cases with at least one resolution that aren't currently resolved. Includes cases later canceled after reopening. | `SUM(AggCaseAnalytics[ReopenedCaseCount])` |
| Reopened Rate | Reopened cases divided by cases resolved at least once. | `DIVIDE([Reopened Cases], SUM(AggCaseAnalytics[EverResolvedCaseCount]))` |
| Reopens per Case | Reopen events divided by reopened cases, not all cases. | `DIVIDE(SUM(AggCaseAnalytics[ReopenEventCount]), [Reopened Cases])` |

For a currently resolved case, the reopen event count is its known resolution count minus one, with a minimum of zero. For cases in other current states, the event count equals the known resolution count.

Missing or incomplete retained history can undercount both reopened cases and reopen events. Don't interpret unknown history as a measured zero.

## Case-level SLA metrics

Use these [AggCaseAnalytics](../develop/analytics/aggcaseanalytics.md) measures for case-level SLA verdicts. A case contributes at most one verdict, even if it has several SLA KPI executions.

| Measure | Definition | DAX calculation |
|---|---|---|
| SLA In-Scope Cases | Cases with at least one noncanceled or unknown-status SLA execution. | `SUM(AggCaseAnalytics[SLAInScopeCaseCount])` |
| SLA Breached Cases | In-scope cases with at least one breached execution. | `SUM(AggCaseAnalytics[SLABreachedCaseCount])` |
| SLA Met Cases | In-scope cases whose executions all succeeded after canceled executions are removed. | `SUM(AggCaseAnalytics[SLAMetCaseCount])` |
| SLA In Progress Cases | Cases without a breach that have an in-progress, nearing, or paused execution. | `SUM(AggCaseAnalytics[SLAPendingCaseCount])` |
| SLA Unknown Cases | Cases without a breach or pending execution that have an unknown execution status. | `SUM(AggCaseAnalytics[SLAUnknownCaseCount])` |
| SLA Breach Rate | Breached cases divided by in-scope cases. | `DIVIDE([SLA Breached Cases], [SLA In-Scope Cases])` |
| No SLA Applied Cases | Cases with no executions or only canceled executions. | `SUM(AggCaseAnalytics[SLAOutOfScopeCaseCount])` |
| No SLA Applied % | Out-of-scope cases divided by cases with a computed SLA verdict. | `DIVIDE([No SLA Applied Cases], [SLA In-Scope Cases] + [No SLA Applied Cases])` |

After canceled executions are removed, verdict precedence is breached, pending, unknown, then met.

Verdict counts remain null if the SLA fact source hasn't been ingested. If the source exists but a case's executions are missing from the export, the case can appear as out of scope. **No SLA applied** therefore doesn't prove that no policy was configured.

For **No SLA Applied %**, the denominator excludes cases without a computed verdict. Using total cases instead can understate the percentage while older partitions lack verdicts.

## SLA execution metrics

Use these [AggCaseSLA](../develop/analytics/aggcasesla.md) measures to count SLA KPI executions, not case-level SLA verdicts.

| Measure | Definition | DAX calculation |
|---|---|---|
| SLA KPI Instances | SLA KPI executions linked to cases. | `SUM(AggCaseSLA[InstanceCount])` |
| SLA Non-Canceled Instances | Executions whose status is known and isn't canceled. Includes pending and paused executions. | `SUM(AggCaseSLA[NonCanceledInstanceCount])` |
| SLA Succeeded Instances | Executions whose status is succeeded. | `SUM(AggCaseSLA[SucceededInstanceCount])` |
| SLA Breached Instances | Executions whose status is noncompliant. | `SUM(AggCaseSLA[BreachedInstanceCount])` |
| SLA Pending Instances | In-progress, nearing, or paused executions. | `SUM(AggCaseSLA[PendingInstanceCount])` |
| SLA Attainment | Succeeded executions divided by known, noncanceled executions. | `DIVIDE([SLA Succeeded Instances], [SLA Non-Canceled Instances])` |

For example, three succeeded executions, one breached execution, and one pending execution produce 60% attainment. The five executions can belong to fewer than five cases. Don't treat case SLA breach rate as the complement of execution SLA attainment.

## Backlog and ageing metrics

These [AggCaseSnapshot](../develop/analytics/aggcasesnapshot.md) measures describe the latest capture, which is the only capture the model imports.

| Measure | Definition | DAX calculation |
|---|---|---|
| Active Cases | Cases in the selected creation-date cohort that are active at capture. | `SUM(AggCaseSnapshot[ActiveCaseCount])` |
| Avg Active Case Age (days) | Average elapsed age of active cases at capture, in days. | `DIVIDE(SUM(AggCaseSnapshot[ActiveAgeSecondsSum]), SUM(AggCaseSnapshot[ActiveAgeValidCount])) / 86400` |
| Oldest Active Case Age (days) | Maximum active-case age, not a sum of row maxima. | `MAX(AggCaseSnapshot[OldestActiveAgeSeconds]) / 86400` |
| Awaiting Response Cases | Active cases whose first-response flag is known and unsent. | `SUM(AggCaseSnapshot[AwaitingResponseCount])` |
| Known Unassigned Cases | Active cases known to have no worker. Team ownership alone doesn't imply unassigned work. | `SUM(AggCaseSnapshot[KnownUnassignedCount])` |
| Stale Cases | Active cases whose last source update is at least seven calendar dates before capture. | `SUM(AggCaseSnapshot[StaleCaseCount])` |
| Stale Case Rate | Stale cases divided by active cases. | `DIVIDE([Stale Cases], [Active Cases])` |

`UnknownResponseCaseCount` and `UnknownAssignmentCaseCount` identify coverage gaps, not unanswered or known-unassigned cases.

Staleness uses the case's source modification date. Automated updates reset the clock, so staleness doesn't measure a representative's inactivity.

Age bands use elapsed time: less than 2 days, 2 to less than 8 days, 8 to less than 31 days, 31 to less than 90 days, and 90 days or more. Learn more in [DimCaseAgeBand](../develop/analytics/dimcaseageband.md).

Never add snapshot values across capture dates. You can't calculate backlog growth from the published table because it doesn't retain earlier captures.

## Representative, queue, and hourly metrics

For **Cases Closed per Rep**, the numerator is closed cases attributed to user-type workers. The denominator is the number of user-type workers with cases in the selected cohort. Both populations exclude team and unassigned workers.

Ownership identifies responsibility. Worker attribution doesn't identify who performed every action or resolved the case.

The lowest-response-completion, worst-SLA, lowest-CSAT, and lowest-sentiment queue cards rank queue IDs with at least 30 eligible cases, noncanceled executions, CSAT responses, or sentiment responses, respectively. They exclude blank identities, blank names, **(Unassigned)**, and blank metric values. Ties sort first by queue name, then by ID.

**Hourly Completion %** divides closed cases by total cases in the same creation-hour group. **Peak Hour** and **Busiest Day** identify the hour and weekday with the most created cases, not when cases were closed.

## Interpret totals, blanks, and refresh

Calculate rates by dividing the summed numerators by the summed denominators. Don't average row percentages or row averages. For oldest-age columns, use `MAX`.

The measures use `DIVIDE` without a zero alternate result, so an absent or zero denominator returns blank. Cards display **(Blank)**, and table cells stay empty. A measured zero, or a zero rate with a real denominator, remains zero.

`_AggregationDate` identifies the case-creation partition date, not another reporting relationship. For both creation-cohort aggregates, the model keeps and refreshes a rolling 24 months. Updates to older cases can therefore change values in their original creation partitions.




## Related information

[Case dashboard](case-dashboard.md)
[Case analytics data model](../develop/analytics/case-data-model.md)
