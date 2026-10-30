---
title: DimCaseSeverity table reference
description: Reference case severity metadata and the detail-only reporting scope of DimCaseSeverity.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseSeverity table reference

Use `DimCaseSeverity` to display severity labels when you analyze case detail.

## Business value

Severity classifies cases separately from priority. The system doesn't use it as a filter or a grouping key in Case dashboard.

## Grain and source

The table contains one row per `SeverityCode` in the default language. Its source is `HelperOptionSet`, filtered to `incident.severitycode` with `IsDefaultLanguage` = true.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `SeverityCode` | INT | `HelperOptionSet.Option` | Original severity option code and primary key. |
| `SeverityLabel` | STRING | `HelperOptionSet.LocalizedLabel` | Severity label in the default language, including custom options. |
| `SortOrder` | INT | Derived | Dense rank by ascending option code. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Last data refresh date and time in UTC. |

Use the published label column `SeverityLabel`, not `SeverityName`.

## Reporting relationships

For detail analysis, create a single-direction, one-to-many relationship from `SeverityCode` to `FactCase.SeverityCode`.

The default dashboard doesn't import this dimension or `FactCase`. None of its three aggregates contains `SeverityCode`. Adding only the dimension therefore doesn't let you filter those metrics with a severity slicer.

## Related information

[DimCasePriority](dimcasepriority.md)          
[Case analytics data model](case-data-model.md)       
