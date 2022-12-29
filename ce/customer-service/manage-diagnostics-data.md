---
title: Manage routing diagnostics data
description: Learn how to manage diagnostics data for unified routing and archive it
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 12/28/2022
ms.custom: bap-template
---

# Manage routing diagnostics data

The diagnostics data for unified routing is stored in Dataverse for Apps Database Capacity. We recommend that you periodically delete the diagnostics data to manage the storage capacity.

You can use the information in this section to define an effective strategy to manage your diagnostics data.

The following table lists the analysis of the average data consumption of some of our large customer organizations. The values are based on the assumption that each stage has one ruleset only.

| Data consumption | Size/Record in kilobytes (average) | Description |
|--------|-----------|-------------|
| Data consumed per ruleset within a diagnostic work item | 13.27<sup>**1**</sup> | The average data consumed by a single ruleset in a routing stage for the diagnostics item that's generated for a routed work item. |
| Data consumed per diagnostics work item | 53.08 | The average data consumed by the diagnostics item that's generated for a routed work item. |

<sup>**1**</sup>The average values can vary based on factors, like the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters). Let's take an example in which each routing stage has a single ruleset with a couple of rules and moderately complex rule conditions. If you route 500 work items per day, it generates 500 diagnostics work items that will consume approximately 25.64 MB of data. For information about routing stages, see [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics).

## View consumption and delete routing diagnostics data

1. Perform the steps in the [Capacity page details](/power-platform/admin/capacity-storage#capacity-page-details) article to view the storage consumption of the diagnostics records mentioned in step 2.

1. Perform the steps in the [Use bulk deletion to remove large amounts of data](/power-platform/admin/delete-bulk-records) article to delete the following routing diagnostics data.
   - Routing diagnostics
     - **Logical name**: msdyn_unifiedroutingrun
   - Routing diagnostics items
     - **Logical name**: msdyn_unifiedroutingdiagnostic

## Next steps

[View diagnostics for routed records](unified-routing-diagnostics.md)  
