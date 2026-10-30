---
title: DimCaseType table reference
description: Learn more about case type codes, labels, metadata filtering, and relationships in the DimCaseType table.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseType table reference

Use `DimCaseType` to group cases by configured types such as Question, Problem, or Request.

## Business value

Identify which case categories generate support demand. The dashboard also compares product/type combinations. It doesn't use type label text as a fixed business condition.

## Grain and source

The table contains one row per `CaseTypeCode` in the default language. Its source is `HelperOptionSet`, filtered to `incident.casetypecode` with `IsDefaultLanguage` = true.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `CaseTypeCode` | INT | `HelperOptionSet.Option` | Original type code and primary key. |
| `CaseTypeLabel` | STRING | `HelperOptionSet.LocalizedLabel` | Type label in the default language, including custom options. |
| `SortOrder` | INT | Derived | Display order, based on the case type code. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Last data refresh date and time in UTC. |

Use the published label column `CaseTypeLabel`, not `CaseTypeName`.

## Relationships

Create single-direction, one-to-many relationships from `CaseTypeCode` to the matching column on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`.

Case-type charts display `CaseTypeLabel`. Because multiple codes can share a label, the model doesn't sort labels by `SortOrder`.

## Related information

[DimCaseProduct](dimcaseproduct.md)      
[Case analytics data model](case-data-model.md)      
