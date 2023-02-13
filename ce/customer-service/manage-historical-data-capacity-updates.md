---
title: Manage historical data of capacity updates for agents
description: Learn how to manage historical data of capacity updates for agents.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/13/2023
ms.custom: bap-template
---

# Manage historical data of capacity updates for agents

The historical data of the capacity updates against capacity profiles for agents is stored in [Dataverse for Apps Database Capacity](/power-platform/admin/capacity-storage#licenses-for-the-new-storage-model).

We recommend that you periodically delete the historical data to manage the storage capacity.

## Delete historical data for capacity updates

1. Perform the steps in [Capacity page details](/power-platform/admin/capacity-storage#capacity-page-details) to view the storage consumption.
1. If the storage consumed is 50-60% of the total capacity, you can do the following:
   1. Move the data to a different data store if you want to retain it.
   1. Delete it from Dataverse for Apps Database Capacity.
1. Perform the steps in [Use bulk deletion to remove large amounts of data](/power-platform/admin/delete-bulk-records) to delete the historical data stored in the [msdyn_agentcapacityupdatehistory](developer/reference/entities/msdyn_agentcapacityupdatehistory.md) entity.

> [!CAUTION]
> Delete operations are irreversible and therefore we recommend that you verify and ensure the data isn't required before you run the delete job.

### See also

[Manage capacity profiles](capacity-profiles.md)  
