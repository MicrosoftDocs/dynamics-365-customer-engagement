---
title: FactCase table reference
description: Learn about the FactCase table and the case details available for analyzing assignments, resolution, tracked time, customer feedback, and support entitlements.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# FactCase table reference

Use `FactCase` to analyze individual cases, including their assignments, resolution history, tracked work time, customer feedback, and support entitlements. For summarized case performance, use [AggCaseAnalytics](aggcaseanalytics.md).

## Grain and source

Each row represents one case, identified by `CaseId`. The table combines case information with available assignment, resolution, time-tracking, and survey data.

Case status and ownership reflect the latest available information. Queue and worker details reflect the current assignment or, if none is available, the last known assignment. They don't identify who performed every action or resolved the case.

## Case details

Use these columns to identify a case or open its record.

| Column | Type | Description |
|---|---|---|
| `CaseId` | STRING | Unique case identifier. |
| `CaseNumber` | STRING | Case number shown to users. |
| `CaseTitle` | STRING | Case title. |
| `CaseUrl` | STRING | Link to open the case, when available. |

## Dimension columns

Use these columns to filter and group cases by assignment, classification, product, or support entitlement.

| Column | Type | Description |
|---|---|---|
| `QueueId` | STRING | Current active queue or, if none, last known queue. Cases without an available queue are reported under **(Unassigned)**. |
| `OwnerId` | STRING | Identifier of the user or team that owns the case. |
| `CurrentOwnerKey` | STRING | Case owner. Relates to [DimCaseOwner](dimcaseowner.md). |
| `OwningBusinessUnitId` | STRING | Case owner's business unit. |
| `AgentId` | STRING | Identifier of the current or last known worker. |
| `CurrentWorkerKey` | STRING | Current or last known worker. Relates to [DimCaseWorker](dimcaseworker.md). |
| `AgentBusinessUnitId` | STRING | Worker's business unit, when available. |
| `QueueAssignmentState` | STRING | Queue assignment coverage: `Assigned`, `NoQueue`, or `Unknown`. Assigned can include a last known queue. |
| `WorkerAssignmentState` | STRING | Worker assignment coverage: `Assigned`, `Unassigned`, or `Unknown`. Assigned can include a last known worker. |
| `SubjectId` | STRING | Case subject. Relates to [DimSubject](dimsubject.md). |
| `PriorityCode` | INT | Case priority. Relates to [DimCasePriority](dimcasepriority.md). |
| `SeverityCode` | INT | Case severity. Relates to [DimCaseSeverity](dimcaseseverity.md). |
| `CaseTypeCode` | INT | Case type. Relates to [DimCaseType](dimcasetype.md). |
| `CaseOriginCode` | INT | Channel through which the case was received. Relates to [DimCaseOrigin](dimcaseorigin.md). |
| `CaseStateCode` | INT | Current case state: `0` active, `1` resolved, or `2` canceled. |
| `CaseStatusCode` | INT | Current case status reason. |
| `CurrentCaseStatusKey` | STRING | Current case state and status reason. Relates to [DimCaseStatus](dimcasestatus.md). |
| `ProductId` | STRING | Associated product. Relates to [DimCaseProduct](dimcaseproduct.md). |
| `CurrentEntitlementId` | STRING | Assigned support entitlement. Relates to [DimCaseEntitlement](dimcaseentitlement.md). |

Ownership and worker assignment are separate. A team-owned case can have an individual worker. An unknown assignment means the information isn't available, not that the case is unassigned.

## Date and time columns

Use these columns to understand when a case was created, updated, escalated, or resolved.

| Column | Type | Description |
|---|---|---|
| `CreatedOnDateTime` | TIMESTAMP | Date and time the case was created. |
| `ModifiedOnDateTime` | TIMESTAMP | Date and time the case was last updated. |
| `ResolvedOnDateTime` | TIMESTAMP | Last update time for a currently resolved case. For recorded resolution times, use `FirstKnownResolvedOn` or `LatestKnownResolvedOn`. |
| `EscalatedOnDateTime` | TIMESTAMP | Date and time of the recorded escalation. |
| `IncidentResolutionDateTime` | TIMESTAMP | Date and time of the latest available completed resolution record. |
| `FirstKnownResolvedOn` | TIMESTAMP | Date and time of the earliest available completed resolution record. |
| `LatestKnownResolvedOn` | TIMESTAMP | Date and time of the latest available completed resolution record, retained if the case is reopened. |

Resolution dates depend on the records available for analysis. They don't guarantee a complete history of every resolution.

## Metric columns

The following columns describe case activity, elapsed time, tracked work, and customer feedback.

### Case activity

| Column | Type | Description |
|---|---|---|
| `IsResolved` | BOOLEAN | Whether the case is currently resolved. |
| `IsEscalated` | BOOLEAN | Whether the case is marked as escalated. |
| `IsCustomerContacted` | BOOLEAN | Whether the case is marked as having a customer contact. |
| `IsFirstResponseSent` | BOOLEAN | Whether the first response is marked as sent. Check `FirstResponseFlagKnown` before treating a false value as not sent. |
| `FirstResponseFlagKnown` | BOOLEAN | Whether first-response information is available. False means unknown. |
| `FirstResponseSLAStatusCode` | INT | First-response service-level agreement (SLA) status, including `3` for succeeded and `4` for expired. These codes differ from the execution statuses in [FactSLAKPIInstance](factslakpiinstance.md). |
| `CopilotEngaged` | BOOLEAN | Whether Copilot engagement is recorded for the case. A false value can also mean the information isn't available. |
| `NumberOfChildIncidents` | INT | Number of child cases. |

### Resolution and case age

| Column | Type | Description |
|---|---|---|
| `CaseAgeInDays` | DOUBLE | Calendar days from creation to `ResolvedOnDateTime` for currently resolved cases, or to the refresh time for other cases. |
| `CaseAgeDescription` | STRING | Age category based on `CaseAgeInDays`. |
| `HandleTimeInMinutes` | BIGINT | Elapsed calendar minutes from creation to `ResolvedOnDateTime` for currently resolved cases. This isn't active work time. |
| `FirstKnownResolutionId` | STRING | Identifier of the earliest available completed resolution record. |
| `LatestKnownResolutionId` | STRING | Identifier of the latest available completed resolution record. |
| `KnownResolutionCount` | BIGINT | Number of available completed resolutions. Zero means none are recorded in the available history; blank means resolution data isn't available. |
| `FirstKnownResolutionSeconds` | BIGINT | Elapsed calendar seconds from case creation to the earliest available completed resolution. |
| `LatestKnownResolutionSeconds` | BIGINT | Elapsed calendar seconds from case creation to the latest available completed resolution. |
| `ResolutionHistoryCoverage` | STRING | `RetainedOnly` means only retained resolution records are available. `Unknown` means resolution data isn't available. |

Reopened cases keep their known resolution history. Use the first and latest known resolution columns to analyze those earlier resolutions.

### Tracked time

| Column | Type | Description |
|---|---|---|
| `TrackedTimeMinutes` | DOUBLE | Tracked work minutes, including fractional minutes. Uses only entries marked as Final if the case has any; otherwise, uses all entries. |
| `TrackedTimeRecordCount` | BIGINT | Number of time entries used to calculate `TrackedTimeMinutes`, not a case count. |
| `TrackedTimeInMinutes` | BIGINT | Total minutes from all time entries, regardless of category. Fractional minutes are discarded from each entry before summing. |

Cases without tracked-time data have blank values, not zero. Tracked time measures recorded work, not the elapsed time between case creation and resolution.

### Customer feedback

| Column | Type | Description |
|---|---|---|
| `CSATScore` | DOUBLE | Average valid customer satisfaction (CSAT) score for the case. |
| `CSATScoreSum` | DOUBLE | Total of valid CSAT scores for the case. |
| `CSATResponseCount` | BIGINT | Number of valid CSAT responses. |
| `CSATCoverage` | STRING | `Available` means survey data is available for analysis, even if the case has no responses. `Unknown` means the data isn't available. |
| `SentimentScore` | DOUBLE | Average valid survey sentiment score for the case. Zero-valued survey responses are excluded. |
| `SentimentScoreSum` | DOUBLE | Total of valid survey sentiment scores. |
| `SentimentResponseCount` | BIGINT | Number of valid survey sentiment values. |
| `SentimentLabelCode` | INT | Sentiment category: `0` negative, `1` neutral, or `2` positive. Blank when no score is available. |

To calculate average CSAT across cases, divide the sum of `CSATScoreSum` by the sum of `CSATResponseCount`. This gives each response equal weight, even when cases have different numbers of responses.

## Metadata columns

Use these columns to identify the case creation period and data refresh time.

| Column | Type | Description |
|---|---|---|
| `CreatedDateKey` | BIGINT | Case creation time in UTC, grouped into 15-minute intervals. |
| `_StartDate` | DATE | Case creation date. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | Last data refresh date and time in UTC. |

## Relationships and coverage

Use `CaseId` to relate a case to its SLA executions in [FactSLAKPIInstance](factslakpiinstance.md). One case can have multiple executions. Count distinct cases when combining these tables so that multiple executions don't inflate case totals.

Optional details, such as product, entitlement, survey, and resolution information, depend on the available source data. Don't interpret missing information as zero, a failed SLA, or confirmation that no entitlement is assigned.

## Related information

[Case analytics data model](case-data-model.md)     
[AggCaseAnalytics table reference](aggcaseanalytics.md)     
[FactSLAKPIInstance table reference](factslakpiinstance.md)     
