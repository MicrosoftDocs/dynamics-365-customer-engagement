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

In Dynamics 365 Field Service, organizations can track their product inventory. For any given warehouse and product, an organization can track *Available*, *On Hand*, *On Order*, and *Allocated* inventory. Just select the **Inventory** area, select **Warehouses**, and then select the warehouse.

:::image type="content" source="media/inventory-product-inventory-levels.svg" alt-text="Screenshot of product inventory levels at a warehouse.":::

**Inventory Journal** is a Field Service table that serves as a ledger for all inventory changes that are related to field service warehouses and products. For example, when a field service purchase order is fulfilled, an inventory journal is created to document an increase in inventory for the receiving warehouse. When a field service inventory transfer is completed, two inventory journals are created: one that reduces inventory from the source warehouse and one that adds inventory for the receiving warehouse.

Inventory administrators can use manual inventory journals to manipulate inventory levels without performing the associated field service processes. For example, you can manually add inventory without creating and fulfilling field service purchase orders, or you can transfer inventory without creating inventory transfer records.

The primary purpose of manual inventory journals is to make it easier to integrate field service inventory with external inventory systems, such as Dynamics 365 finance and operations apps. Other use cases include:

- Documenting lost, stolen, or destroyed inventory.
- Enabling extensibility scenarios to use field service inventory.

[Inventory adjustments](inventory-purchasing-returns-overview.md#inventory-adjustments-and-transfers) can be used to increment/decrement available inventory for a given warehouse. This field service-related process applies only to adjustments to *Available* and *On Hand* inventory. By contrast, manual inventory journals can edit inventory levels of any type. Manual inventory journals are also more flexible and better suited to integration scenarios. For both manual inventory journals and inventory adjustments, product quantities can be set to a negative value to decrement inventory.

## Prerequisites

- You must be using Field Service version 8.2 or later.
- Warehouse records must exist in the system.
- Products where **Field Service Type** = *Inventory* must exist in the system.
- You must have the *Field Service - Inventory Purchase* security role.

## Access inventory journals

You can view existing inventory journals in Power Apps.

1. Sign in to [Power Apps](https://make.powerapps.com/), and select your environment.
1. Select **Tables** > **All**.
1. Search for and select **Inventory Journal**.

    :::image type="content" source="media/inventory-inventory-journals-find.svg" alt-text="Screenshot of the Inventory Journal table in Power Apps.":::

## Create a manual inventory journal

1. From the **Inventory Journal** table, select **Edit**.
1. If the grid doesn't include the **Transaction Type** column, select **New column** to add it.
1. Select **New row**.

    :::image type="content" source="media/inventory-create-manual-journal.svg" alt-text="Screenshot of a new row in the Inventory Journal table in Power Apps.":::

1. To specify how the inventory is incremented or decremented, select a journal type for your manual inventory.

    - *On Hand*: Increase *On Hand* and *Available* product inventory.
    - *On Order*: Increase *On Order* product inventory.
    - *Allocated*: Increase *Allocated* product inventory, and reduce *Available* product inventory.

    > [!NOTE]
    > The quantity can be set to a negative value to decrement inventory.

1. Enter the other information. The **Transaction Type** field is automatically set to *Manual*.
1. Select <kbd>Ctrl</kbd>+<kbd>S</kbd> to save the new inventory journal.

    :::image type="content" source="media/inventory-manual-journal.svg" alt-text="Screenshot of the manual inventory journal in Power Apps.":::

## View inventory changes

1. In Field Service, select the **Inventory** area, and then select **Warehouses**.
1. Open the warehouse where you added a manual inventory journal.
1. Select **Related** > **Product Inventory**. The inventory changes appear.

    :::image type="content" source="media/inventory-new-product-inventory-levels.svg" alt-text="Screenshot of the product inventory for a warehouse in Field Service.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
