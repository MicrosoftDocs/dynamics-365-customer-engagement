---
title: DimCaseOrigin table reference
description: Learn about case origin codes, metadata labels, ordering, and aggregate relationships in DimCaseOrigin.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseOrigin table reference

Use `DimCaseOrigin` to display and filter case origins, such as Phone, Email, or Web.

## Business value

Origin comes from `incident.caseorigincode`, not an omnichannel conversation channel. It doesn't tell you how a representative handled the case.

## Grain and source

The table contains one row per `CaseOriginCode` in the default language. Its source is `HelperOptionSet`, filtered to `EntityName` = `incident`, `OptionSetName` = `caseorigincode`, and `IsDefaultLanguage` = true.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `CaseOriginCode` | INT | `HelperOptionSet.Option` | Original option code and primary key. |
| `CaseOriginLabel` | STRING | `HelperOptionSet.LocalizedLabel` | Display label in the default language, including custom options. |
| `SortOrder` | INT | Derived | Dense rank by ascending option code, not the display order from source metadata. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |

Use the published names `CaseOriginCode` and `CaseOriginLabel`, not `OriginCode` and `OriginName`.

## Dashboard relationships

Use case origin to filter and group case performance, SLA results, and backlog by the channel through which cases were received.

The Origin filter and charts display the names in `CaseOriginLabel`. Different origin codes can share the same name, so names aren't ordered by `SortOrder`.

## Related information

[AggCaseAnalytics](aggcaseanalytics.md)      
[Case analytics data model](case-data-model.md)   
