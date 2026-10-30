---
title: DimCaseEntitlement table reference
description: Learn more about the entitlement identity, customer lookup types, allocation settings, and Fabric detail relationships in DimCaseEntitlement.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimCaseEntitlement table reference

Use `DimCaseEntitlement` to analyze case detail with the support entitlement assigned to each case.

## Business value

The dimension identifies the entitlement, customer lookup, configured SLA, allocation unit, and term dates. It doesn't measure entitlement consumption or remaining allowance.

## Grain and source tables

The optional `entitlement` table supplies one row per `EntitlementId`. Records without an entitlement ID aren't included. When a last-updated date is available, only the most recent version of each record is kept. Optional details remain blank if the source doesn't provide them.

## Columns

| Column | Type | Source field | Description |
|---|---|---|---|
| `EntitlementId` | STRING | `entitlement.entitlementid` | Primary key. |
| `EntitlementName` | STRING | `entitlement.name` | Entitlement display name. |
| `CustomerId` | STRING | `entitlement.customerid` | Account or contact identifier. |
| `CustomerType` | STRING | `customerid_entitytype` in the export. | `Account` or `Contact`. Unknown types remain null and aren't inferred from names. |
| `EntitlementSLAId` | STRING | `entitlement.slaid` | Configured SLA policy, not an execution outcome. |
| `AllocationTypeCode` | INT | `entitlement.allocationtypecode` | Allocation unit: `0` cases or `1` hours. |
| `DecreaseRemainingOnCode` | INT | `entitlement.decreaseremainingon` | When remaining allowance decreases: `0` resolution or `1` creation. |
| `StartDate` | DATE | `entitlement.startdate` | Term start date. |
| `EndDate` | DATE | `entitlement.enddate` | Term end date. |
| `StateCode` | INT | `entitlement.statecode` | Source state code. |
| `StatusCode` | INT | `entitlement.statuscode` | Source status-reason code. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Date and time of the pipeline refresh. |

## Reporting relationships

For Fabric detail analysis, create a single-direction, one-to-many relationship from `EntitlementId` to `FactCase.CurrentEntitlementId`. The customer lookup can reference either an account or a contact, so keep `CustomerType` with `CustomerId` when joining it.

## Related information

[DimCaseSLA](dimcasesla.md)     
[Case analytics data model](case-data-model.md)    
