---
title: DimCaseWorker table reference
description: Reference DimCaseWorker, the semantic-model worker role of DimCaseOwner, and its relationships in modern case analytics.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseWorker table reference

Use `DimCaseWorker` to filter by a case's current or last known worker separately from its owner.


## Business value

A team can own a case that an individual works on. Separate dimensions let you analyze owner and worker responsibilities without joining one role through the other. Worker attribution doesn't describe who performed every action or resolved the case.

## Grain and source

The query reads [DimCaseOwner](dimcaseowner.md) and returns one row per one row for each user or team worker, plus one row for unassigned cases. The source contains user, team, and unassigned identities.

## Columns

Use these names in the semantic model. 

| Model column | Model type | Source column in DimCaseOwner | Description |
|---|---|---|---|
| `WorkerKey` | STRING | `OwnerKey` | Worker-role primary key. |
| `WorkerPrincipalId` | STRING | `PrincipalId` | User or team ID from the source. |
| `WorkerPrincipalType` | STRING | `PrincipalType` | `User`, `Team`, or `Unassigned`. |
| `WorkerName` | STRING | `DisplayName` | Worker display name. |

Worker data refreshes with the underlying owner data. The query doesn't import `_LastRefreshedDateTimeUtc`.

## Dashboard relationships

Create independent, single-direction, one-to-many relationships from `WorkerKey` to `WorkerKey` on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`. Don't create a direct relationship between `DimCaseWorker` and `DimCaseOwner`.

For detailed analysis, use `FactCase.CurrentWorkerKey`. The unassigned key is `Unassigned:00000000-0000-0000-0000-000000000000`. Worker-assignment coverage columns distinguish cases known to be unassigned from cases with unknown assignments.

The **Worker agent** filter, **Agent** tab in the Case dashboard, and hourly drill-through group by `WorkerName`. Users or teams with identical display names appear together in these views. Representative-count measures include only user-type principals.

## Related information

[DimCaseOwner](dimcaseowner.md)      
[Case dashboard](../../use/case-dashboard.md)       
