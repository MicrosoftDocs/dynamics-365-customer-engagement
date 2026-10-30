---
title: DimCaseSLA table reference
description: Learn more about SLA policy identity, applicability fields, and detail-analysis relationships in DimCaseSLA.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseSLA table reference

Use `DimCaseSLA` to identify which support policy a case SLA execution belongs to.

## Business value

SLA policies define service commitments for cases. They're different from the individual measures tracked by an SLA or service-level targets for omnichannel queues. A policy's name alone doesn't indicate a customer's service tier.

## Grain and source tables

The optional `sla` entity supplies one row per `SLAId`. Rows with null source IDs are excluded. When `modifiedon` is available, the latest version is retained. Optional attributes missing from the source remain null.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `SLAId` | STRING | `sla.slaid` | Policy identifier and primary key. |
| `SLAName` | STRING | `sla.name` | Policy display name. |
| `ApplicableFromField` | STRING | `sla.applicablefrom` | Configured SLA clock-start field, not the report's date axis. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |

## Reporting relationships

For detail analysis, create a single-direction, one-to-many relationship from `SLAId` to `FactSLAKPIInstance.SLAId`. The execution's policy is resolved through `slaitem.slaid`.

The default dashboard imports neither this dimension nor the execution fact. Because `AggCaseSLA` doesn't group by `SLAId`, relating this dimension to the default report alone doesn't enable policy filtering.

An SLA policy can include multiple rules with different time targets. This table doesn't include those rules or targets, so don't assume a policy name represents a single response or resolution time.

## Related information

[DimCaseSLAKPI](dimcaseslakpi.md)        
[DimCaseEntitlement](dimcaseentitlement.md)      
[Case analytics data model](case-data-model.md)     
