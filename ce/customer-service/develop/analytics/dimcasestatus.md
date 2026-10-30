---
title: DimCaseStatus table reference
description: Learn about the lifecycle state and status-reason hierarchy, composite keys, and dashboard relationships in DimCaseStatus.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseStatus table reference

Use `DimCaseStatus` to analyze case lifecycle state separately from the detailed status reason.

## Business value

State identifies active, resolved, and canceled cases. Status reason adds your organization's configured detail. To calculate open and closed populations, use state codes rather than translated reason labels.

## Grain and source

The table contains one row per case state and status-reason pair. Its source is `HelperEntityStatus`, filtered to `incident` with `IsDefaultLanguage` = true. The helper uses state and status metadata, not `HelperOptionSet`.

## Columns

| Column | Type | Source or derivation | Description |
|---|---|---|---|
| `CaseStatusKey` | STRING | `CaseStateCode:CaseStatusCode`. | Unique relationship key in the modern case model. Null when either component is unavailable. |
| `CaseStateCode` | INT | `HelperEntityStatus.StateCode`. | `0` Active, `1` Resolved, or `2` Canceled. |
| `CaseStateLabel` | STRING | `HelperEntityStatus.StateCodeLocalizedLabel`. | State label in the default language. |
| `CaseStatusCode` | INT | `HelperEntityStatus.StatusCode`. | Status-reason code. |
| `CaseStatusLabel` | STRING | `HelperEntityStatus.StatusCodeLocalizedLabel`. | Status-reason label in the default language. |
| `IsActive` | BOOLEAN | `CaseStateCode = 0` | Flag indicating whether the case is active. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Last data refresh date and time in UTC. |

For example, the standard Active/In Progress pair uses `0:1`, and Resolved/Problem Solved uses `1:5`. Labels can vary by language or organization.

## Dashboard relationships

Create single-direction, one-to-many relationships from `CaseStatusKey` to the matching column on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`. For case detail, the key is `FactCase.CurrentCaseStatusKey`.

The dashboard organizes state and status reason in a hierarchy. Ordinary metrics use current status, snapshot metrics use status at capture.

The **Cases waiting on others** visual excludes standard active reason codes `1` In Progress and `4` Researching. It includes all other active reasons, including custom reasons. This breakdown shows current state, not time spent waiting or in a status.

## Related information

[AggCaseSnapshot](aggcasesnapshot.md)      
[Case analytics data model](case-data-model.md)      
