---
title: Manage routing diagnostics data
description: Learn how to manage routing diagnostics data for unified routing and archive it periodically to manage storage capacity.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/08/2023
ms.custom: bap-template
---

# Manage routing diagnostics data

The diagnostics data for unified routing is stored in [Dataverse for Apps Database Capacity](/power-platform/admin/capacity-storage). We recommend that you periodically delete the routing diagnostics data to manage the storage capacity.

You can use the information in this section to define an effective strategy to manage your diagnostics data.

The following table lists the analysis of the average data consumption of some of our large customer organizations. The values are based on the assumption that each stage has one ruleset only.

| Data consumption | Size/Record in kilobytes (average) | Description |
|--------|-----------|-------------|
| Data consumed per ruleset within a diagnostic work item | 13.27<sup>**1**</sup> | The average data that's consumed by a single ruleset in a routing stage for the diagnostics item generated for a routed work item. |
| Data consumed per diagnostics work item | 53.08 | The average data consumed by the diagnostics item that's generated for a routed work item. |

<sup>**1**</sup> The average values can vary based on factors, like the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters).

Let's take an example in which each routing stage has a single ruleset with a couple of rules and moderately complex rule conditions. If you route 500 work items per day, it generates 500 diagnostics work items that will consume approximately 25.64 MB of data. For information about routing stages, see [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics).

## Delete routing diagnostics data

> [!CAUTION]
> Delete operations are irreversible. Therefore, we recommend that you verify and ensure the data is no longer required before you run the delete job.

1. Perform the steps in the [Capacity page details](/power-platform/admin/capacity-storage#capacity-page-details) article to view the storage consumption of the diagnostics records mentioned in step 2.

1. Perform the steps in the [Use bulk deletion to remove large amounts of data](/power-platform/admin/delete-bulk-records) article to delete the following routing diagnostics data in the specified order.

   1. Routing diagnostics items for the msdyn_unifiedroutingdiagnostic entity. More information: [msdyn_unifiedroutingdiagnostic](developer/reference/entities/msdyn_unifiedroutingdiagnostic.md)
   1. Routing diagnostics for the msdyn_unifiedroutingrun entity. More information: [msdyn_unifiedroutingrun](developer/reference/entities/msdyn_unifiedroutingrun.md)

## Next steps

[View diagnostics for routed records](unified-routing-diagnostics.md)  
