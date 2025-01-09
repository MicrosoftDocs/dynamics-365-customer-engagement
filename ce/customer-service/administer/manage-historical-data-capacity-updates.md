---
title: Delete historical data of agent capacity updates
description: Learn how to delete historical data of agent capacity profile updates in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 07/01/2024
ms.custom: bap-template
---

# Delete historical data of agent capacity updates

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The history of updates to your agents' capacity profiles is stored in [Dataverse for Apps](/power-platform/admin/capacity-storage). To help you use your storage capacity efficiently, we recommend that you periodically delete the historical data.

[Review your storage consumption](/power-platform/admin/capacity-storage#capacity-page-details). If the storage consumed is 50%&ndash;60% of the total capacity, consider moving the data to a different data store if you want to keep it. Otherwise, [delete it](/power-platform/admin/delete-bulk-records).

> [!CAUTION]
> Deleted data can't be recovered. We recommend that you verify the data isn't required before you delete it.

### Related information

[Manage capacity profiles](capacity-profiles.md)  
