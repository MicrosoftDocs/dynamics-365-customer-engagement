---
title: Create a warehouse to track inventory
description: Learn how to create a warehouse in Dynamics 365 Field Service.
ms.date: 09/23/2022
ms.topic: article
author: jshotts
ms.author: jasonshotts
---

# Create a warehouse to track inventory

Track your product inventory using a warehouse record in Dynamics 365 Field Service.  
  
This article explains how to create a warehouse record and add your product inventory to it.

:::image type="content" source="media/warehouse-list.png" alt-text="Screenshot of an Active Warehouses view with list of warehouses in Field Service.":::
  
## Create a warehouse record  
  
1. In Field Service, change to the **Inventory** area.

1. In the **Inventory** section, go to **Warehouses**.
  
1. On the **Active Warehouse** screen, select **New**.  
  
1. Provide a name for the warehouse and assign an owner.

1. Select **Save** to create the record.
  
## Add product inventory to the warehouse record

Product inventory is automatically adjusted in the warehouse record with [inventory adjustment records](inventory-purchasing-returns-overview.md).  
  
You can also manually add product inventory to a warehouse record, but keep in mind that you won’t be able to modify the quantity values.  
  
1. On a warehouse record, select the **Related** tab and choose **Product Inventory**.  
  
2. Select **New Product Inventory**.  
  
3. Fill in the **Product**, and **Unit** information. Optionally, specify the **Bin** and **Row** where the product resides in the warehouse.
  
4. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
