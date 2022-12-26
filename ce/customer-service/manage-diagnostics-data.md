---
title: Manage diagnostics data for optimal storage
description: Learn how to manage diagnostics data for unified routing and archive it
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 12/26/2022
ms.custom: bap-template
---

# Manage diagnostics data for optimal storage

The diagnostics data for unified routing is stored in Microsoft Dataverse. The data for the routed work items might consume more space compared to other items and can affect the storage capacity. Therefore, we recommend that you delete diagnostics data periodically to manage the storage.

The following table lists the average storage consumption. The values are based on the assumption that each stage has one ruleset only. The average values can vary based on factors, like the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters). For example, if you route 500 records per day, then the daily data consumption will be approximately 26.54 MB. The complexity within each routing stage is also a contributing factor. More information: [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics)

| Data consumption | Size/Record in kilobytes (average) |
|--------|-----------|
| Data consumed per ruleset within a diagnostics record | 13.27 |
| Data consumed per record | 53.08 |

You can use the information to define an effective strategy to manage your diagnostics data.

## View consumption and delete diagnostics data

1. Perform the steps in the [Capacity page details](/power-platform/admin/capacity-storage#capacity-page-details) article to view the storage consumption of the following diagnostics records:

   - Routing diagnostics
     - **Logical name**: msdyn_unifiedroutingrun
   - Routing diagnostics items
     - **Logical name**: msdyn_unifiedroutingdiagnostic

1. Perform the steps in the [Use bulk deletion to remove large amounts of data](/power-platform/admin/delete-bulk-records) article to remove the data.

## Next steps

[View diagnostics for routed records](unified-routing-diagnostics.md)  
