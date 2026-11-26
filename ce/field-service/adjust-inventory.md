---
title: Adjust inventory levels
description: Learn how to create an inventory adjustment in Dynamics 365 Field Service to manually increase or decrease product inventory at a warehouse.
ms.date: 08/11/2026
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: jacoh
author: jasonccohen
ms.reviewer: puneetsingh
ms.custom: 
    - bap-template
    - ai-gen-docs-bap
    - ai-seo-date: 08/11/2026
ai-usage: ai-assisted
---

# Adjust inventory levels

Use inventory adjustments to manually increase or decrease the product inventory at a warehouse in Dynamics 365 Field Service. Inventory adjustments are useful when you want to:

- Record the starting quantities of products at a new warehouse.
- Reflect shrinkage, defects, loss, or theft after a physical count.
- Correct discrepancies between expected inventory and actual inventory.

Each inventory adjustment applies to a single warehouse. When you add a product to the adjustment, Field Service creates an [inventory journal](developer/reference/entities/msdyn_inventoryjournal.md) that updates the **Quantity on Hand** for that product at the warehouse. Because **Quantity Available** is derived from **Quantity on Hand**, the available quantity also changes.

For more flexibility, such as adjusting *On Order* or *Allocated* quantities, or supporting integration scenarios, use [manual inventory journals](manual-inventory-journals.md) instead.

## Prerequisites

- A [warehouse](create-warehouse.md) record must exist in your system.
- Products where **Field Service Product Type** = *Inventory* must exist in your system. You can't adjust non-inventory or service products.
- You need either the *Field Service - Administrator* security role or the *Inventory Purchase* security role added to your base Field Service security role. Learn more in [Security roles and column-level security profiles](security-permissions.md).

## Create an inventory adjustment

1. In Field Service, select the **Inventory** area.

1. Under **Inventory**, select **Adjustments**, and then select **New**.

1. In the **Warehouse** field, select the warehouse where you want to adjust inventory.

1. Select **Save** to create the record.

    :::image type="content" source="media/inventory-adjustment.png" alt-text="Screenshot of an inventory adjustment.":::

> [!NOTE]
> After you add products to an inventory adjustment, you can't change the warehouse. Create a separate adjustment to update inventory at a different warehouse.

## Add products to the inventory adjustment

Add a row for each product whose quantity you want to change at the warehouse.

1. In the saved inventory adjustment, on the **Products** tab, select **+ New Inventory Adjustment Product** to open **Inventory Adjustment Product** window.

1. In the **Product** field, select a product where **Field Service Product Type** = *Inventory*.

1. In the **Unit** field, select the unit of measure.

1. In the **Quantity** field, enter the amount to change the inventory by:

    - Enter a positive value to increase the **Quantity on Hand**.
    - Enter a negative value to decrease the **Quantity on Hand**.

1. Select **Save and Close**. Field Service creates an inventory journal that updates the product inventory at the warehouse.

1. Repeat these steps for each product that you want to adjust.

> [!NOTE]
> Field Service doesn't enforce non-negative inventory for adjustments. If you enter a negative quantity that exceeds the amount on hand, the **Quantity on Hand** can become negative.

## Verify the inventory change

Confirm that the adjustment updated the product inventory at the warehouse.

1. In Field Service, select the **Inventory** area, and then select **Warehouses**.

1. Open the warehouse that you adjusted.

1. On the **Related** tab, select **Product Inventory**. The updated **Quantity on Hand** and **Quantity Available** values appear for the adjusted products.

## Next steps

- [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md)
- [Use manual inventory journals](manual-inventory-journals.md)
- [Create a warehouse to track inventory](create-warehouse.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
