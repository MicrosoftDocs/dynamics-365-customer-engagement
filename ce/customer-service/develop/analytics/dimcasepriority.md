---
title: DimCasePriority table reference
description: Reference priority metadata, column names, label ordering, and relationships in the DimCasePriority table.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCasePriority table reference

Use `DimCasePriority` to filter and compare case priorities with your organization's configured labels.

## Business value

Compare case workload and outcomes by priority: High (`1`), Normal (`2`), or Low (`3`). The dashboard identifies high-priority cases by code `1`, regardless of the displayed name or language.

## Grain and source

The table contains one row per `PriorityCode` in the default language. Its source is `HelperOptionSet`, filtered by `incident.prioritycode` with `IsDefaultLanguage` = true.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `PriorityCode` | INT | `HelperOptionSet.Option` | Original priority code and primary key. |
| `PriorityLabel` | STRING | `HelperOptionSet.LocalizedLabel` | Priority label in the default language. |
| `SortOrder` | INT | Derived | Dense rank by ascending option code. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |


## Dashboard relationships

Create single-direction, one-to-many relationships from `PriorityCode` to the matching column on `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`.

Priority names are displayed in reports, but filters use the underlying codes. Renaming a priority doesn't change which cases the dashboard counts as high priority.

## Related information

[Case metrics reference](../../use/case-metrics.md)       
[Case analytics data model](case-data-model.md)     