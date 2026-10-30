---
title: DimCaseOwner table reference
description: Reference typed user, team, and unassigned owner identities in the DimCaseOwner table for modern case analytics.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseOwner table reference

Use `DimCaseOwner` to analyze case ownership without treating teams as people or counting cases more than once. Ownership identifies responsibility, not measured individual effort.

## Business value

User and team owners have consistent keys that include their principal type. The semantic model uses the same source table independently for the [worker role](dimcaseworker.md).

## Grain and source tables

The table contains one row per typed `OwnerKey` and an additional unassigned member.

| Source table | Purpose |
|---|---|
| `systemuser` | Supplies the user identifier and full name. |
| `team` | Supplies the team identifier and name when team data is available. |

For each source ID, user and team records are deduplicated separately. The latest `modifiedon` is retained when available, and null source IDs are excluded. Without team input, the table can still publish user and unassigned rows.

## Columns

| Column | Type | Source | Description |
|---|---|---|---|
| `OwnerKey` | STRING | Derived from principal type and ID. | Primary key in the form `User:<id>`, `Team:<id>`, or the unassigned key. |
| `PrincipalId` | STRING | `systemuser.systemuserid` or `team.teamid`. | Original source ID; all zeros for the unassigned member. |
| `PrincipalType` | STRING | Derived | `User`, `Team`, or `Unassigned`. |
| `DisplayName` | STRING | `systemuser.fullname` or `team.name`. | Owner display name; **(Unassigned)** for the unassigned member. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |

The unassigned key is `Unassigned:00000000-0000-0000-0000-000000000000`. Use the complete typed key in relationships. `PrincipalId` alone doesn't identify the owner type.

## Dashboard relationships

Create single-direction, one-to-many relationships from `OwnerKey` to `OwnerKey` on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`.

In the semantic model, Power Query renames `PrincipalId`, `PrincipalType`, and `DisplayName` to `OwnerPrincipalId`, `OwnerPrincipalType`, and `OwnerName`, respectively. The renamed fields aren't separate Delta columns.

For detail analysis, `FactCase.CurrentOwnerKey` contains the same typed key. The default dashboard doesn't import `FactCase`.

The owner filter groups principals with identical names because it uses `OwnerName`. To distinguish individual identities in a custom report, use typed keys.

## Related information

[DimCaseWorker](dimcaseworker.md)      
[Case analytics data model](case-data-model.md)    
