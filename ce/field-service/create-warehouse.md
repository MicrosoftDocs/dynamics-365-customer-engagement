---
title: Create a warehouse to track inventory
description: Learn how to create a warehouse in Dynamics 365 Field Service to track product inventory.
ms.date: 07/17/2025
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
ms.custom: bap-template
---

# Create a warehouse to track inventory

Track your product inventory by using a warehouse record in Dynamics 365 Field Service. After you create a warehouse record, add your product inventory to it. Learn more at [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md).

## Create a warehouse record

1. In Field Service, select the **Inventory** area.

1. Under **Inventory**, select **Warehouses**.

    :::image type="content" source="media/warehouse-list.svg" alt-text="Screenshot of an Active Warehouses view with a list of warehouses in Field Service.":::

1. Select **New** and provide a name for the warehouse and assign an owner.

1. Select **Save** to create the record.

## Add product inventory to a warehouse record

Product inventory in a warehouse record is automatically adjusted through [inventory adjustment records](inventory-purchasing-returns-overview.md).

You can also manually add product inventory to a warehouse record. However, keep in mind that you can't modify the quantity values.

1. In a warehouse record, on the **Related** tab, select **Product Inventory**.
1. Select **New Product Inventory**.
1. Fill in the **Product** and **Unit** fields.
1. Optional: Fill in the **Bin** and **Row** fields to specify where the product resides in the warehouse.
1. Select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
