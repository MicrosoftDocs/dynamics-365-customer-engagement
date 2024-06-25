---
title: Use manual inventory journals
description: Learn about manual inventory journals in Dynamics 365 Field Service.
ms.date: 06/10/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: jacoh
author: jasonccohen
---

# Use manual inventory journals

In Dynamics 365 Field Service, organizations can track their product inventory. For any given warehouse and product, an organization can track **Available**, **On Hand**, **On Order**, and **Allocated** inventory. Simply select the **Inventory** area, then **Warehouses** and select the warehouse.

:::image type="content" source="media/inventory-product-inventory-levels.svg" alt-text="Screenshot of product inventory levels at a warehouse.":::

**Inventory Journal** is a Field Service table that serves as a ledger for all inventory changes related to field service warehouses and products. For example, when a field service purchase order is fulfilled, an inventory journal is created that documents an increase in inventory for the receiving warehouse. As another example, when a field service inventory transfer is completed, two inventory journals are created: one reducing inventory from the **source warehouse** and another adding inventory for the **receiving warehouse**.

Manual inventory journals allow inventory administrators to manipulate inventory levels without the associated field service processes. For instance, you can manually add inventory without creating and fulfilling field service purchase orders, or transfer inventory without creating inventory transfer records.

The primary purpose of manual inventory journals is to make field service inventory easier to integrate with external inventory systems, such as Dynamics 365 for Finance & Operations. Other use cases include:

- Documenting lost, stolen, or destroyed inventory
- Allowing extensibility scenarios to utilize field service inventory

[Inventory adjustments](inventory-purchasing-returns-overview.md#inventory-adjustments-and-transfers) can be used to increment/decrement available inventory for a given warehouse. This is a field service-related process and only applies to adjusting available and on hand inventory. In contrast, manual inventory journals can edit any type of inventory levels. They're also more flexible and better suited for integration scenarios. Both manual inventory journals and inventory adjustments products can have negative quantity values to decrement inventory.

## Prerequisites

- Field Service v8.2+
- Warehouse records must exist in the system
- Products with **Field Service Type = Inventory** must exist in the system
- **Field Service - Inventory Purchase** security role

## Access inventory journals

View existing inventory journals in Microsoft Power Apps.

1. Sign in to [Power Apps](https://make.powerapps.com/) and select your environment.

1. Select **Tables** > **All**.

1. Search for and select **Inventory Journal**.

   :::image type="content" source="media/inventory-inventory-journals-find.svg" alt-text="Screenshot of the Inventory Journal table in Power Apps.":::

## Create a manual inventory journal

1. From the Inventory Journal table, select **Edit**.

1. If you don't see the **Transaction Type** column, select **New column** to add it. Then select **New row**.

   :::image type="content" source="media/inventory-create-manual-journal.svg" alt-text="Screenshot of a new row on the Inventory Journal table in Power Apps.":::

1. To determine how the inventory is incremented or decremented, select a journal type for your manual inventory.

   - **On Hand**: increases **On Hand** and **Available** product inventory.
   - **On Order**: increases **On Order** product inventory.
   - **Allocated**: increases **Allocated** product inventory and reduces **Available** inventory.

   > [!Note]
   > Quantity value can be negative to decrement inventory.

1. Enter the other information. The **Transaction Type** field is automatically set to **Manual**.

1. Select **Ctrl + S** to save the new inventory journal.

   :::image type="content" source="media/inventory-manual-journal.svg" alt-text="Screenshot of the manual inventory journal in Power Apps.":::

## View inventory changes

1. In Field Service, select the **Inventory** area and then **Warehouses**.

1. Open the warehouse where you added a manual inventory journal.

1. Select **Related** > **Product Inventory**. The inventory changes appear.

   :::image type="content" source="media/inventory-new-product-inventory-levels.svg" alt-text="Screenshot of the product inventory for a warehouse in Field Service.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
