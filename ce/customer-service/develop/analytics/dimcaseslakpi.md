---
title: DimCaseSLAKPI table reference
description: Learn about SLA KPI definitions, optional source attributes, and execution-level relationships in DimCaseSLAKPI.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseSLAKPI table reference

Use `DimCaseSLAKPI` to identify the measure an SLA execution tracks, such as first response or resolution.

## Business value

Compare how often SLA targets are met for measures such as first response or resolution. A KPI identifies what's measured, not the time allowed. Different SLA rules can set different time targets for the same KPI.

## Grain and source tables

The optional `msdyn_slakpi` source supplies one row per `SLAKPIId`. Rows with null IDs are excluded. When `modifiedon` is available, the latest version is retained.


## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `SLAKPIId` | STRING | `msdyn_slakpi.msdyn_slakpiid` | KPI definition identifier and primary key. |
| `SLAKPIName` | STRING | `msdyn_slakpi.msdyn_name` | KPI display name. |
| `ApplicableEntity` | STRING | `msdyn_slakpi.msdyn_entityname` | Applicable entity, when available in source data. |
| `KPIField` | STRING | `msdyn_slakpi.msdyn_kpifield` | KPI definition's field, when available in source data. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Last data refresh in UTC. |

`ApplicableEntity` and `KPIField` are included when those attributes exist in the source. Otherwise, they remain null.

The table has no target-duration column. Targets belong to `slaitem` rules, not a single KPI definition.

## Relationships

Create a single-direction, one-to-many relationship from `SLAKPIId` to `AggCaseSLA.SLAKPIId`. This dimension doesn't filter `AggCaseAnalytics` or `AggCaseSnapshot`.

For detail analysis, the same key is available in `FactSLAKPIInstance.SLAKPIId`. The execution's `slaitem` rule determines KPI identity. `SLAItemId` remains on the detail fact.

## Related information

[AggCaseSLA](aggcasesla.md)      
[DimCaseSLA](dimcasesla.md)       
[Case analytics data model](case-data-model.md)     
