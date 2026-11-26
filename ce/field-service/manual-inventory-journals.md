---
title: Use manual inventory journals in Field Service
description: Manual inventory journals give inventory administrators flexible control over product levels in Dynamics 365 Field Service. 
ms.date: 07/23/2026
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: jacoh
ms.reviewer: v-wendysmith
author: jasonccohen
---

# Use manual inventory journals

By using manual inventory journals, inventory administrators can directly update product quantities in Dynamics 365 Field Service without running related processes, such as purchase orders or inventory transfers. Use manual journals to:

- Support integrations with external inventory systems, such as Dynamics 365 finance and operations apps.
- Document lost, stolen, or destroyed inventory.
- Enable extensibility scenarios to use Field Service inventory.

The [**Inventory Journal**](./developer/reference/entities/msdyn_inventoryjournal.md) is a Field Service table that serves as a ledger for all inventory changes that are related to Field Service warehouses and products. For example, when a Field Service purchase order is fulfilled, an inventory journal is created to document an increase in inventory for the receiving warehouse. When a Field Service inventory transfer is completed, two inventory journals are created: one that reduces inventory from the source warehouse and one that adds inventory for the receiving warehouse.

[Inventory adjustments](inventory-purchasing-returns-overview.md#inventory-adjustments-and-transfers) modify *Available* and *On Hand* inventory levels, while manual inventory journals offer greater flexibility by supporting any inventory type. Manual journals are better suited for integration scenarios. Both methods support negative quantities to decrease inventory.

## Prerequisites

- Warehouse records must exist in the system.
- Products where **Field Service Type** = *Inventory* must exist in the system.
- You must have the *Field Service - Inventory Purchase* security role.

## Access inventory journals

You can view existing inventory journals in Power Apps.

1. Sign in to [Power Apps](https://make.powerapps.com/), and select your environment.

1. Select **Tables** > **All**.

1. Search for and select **Inventory Journal**.

   :::image type="content" source="media/inventory-inventory-journals-find.png" alt-text="Screenshot of the Inventory Journal table in Power Apps." lightbox="media/inventory-inventory-journals-find.png":::

## Create a manual inventory journal

1. From the **Inventory Journal** table, select **Edit**.

1. If the grid doesn't include the **Transaction Type** and **Unit** columns, select **More** next to the column headings to show existing columns. Then add them.

1. Select **New row** in the command bar.

   :::image type="content" source="media/inventory-create-manual-journal.png" alt-text="Screenshot of a new row in the Inventory Journal table in Power Apps." lightbox="media/inventory-create-manual-journal.png":::

1. To specify how the inventory is incremented or decremented, select a journal type for your manual inventory.

    - *On Hand*: Increase *On Hand* and *Available* product inventory.
    - *On Order*: Increase *On Order* product inventory.
    - *Allocated*: Increase *Allocated* product inventory, and reduce *Available* product inventory.

    > [!NOTE]
    > Set the quantity to a negative value to decrement inventory.

1. Enter the other information. The **Transaction Type** field is automatically set to *Manual*.

1. Select <kbd>Ctrl</kbd>+<kbd>S</kbd> to save the new inventory journal.

    :::image type="content" source="media/inventory-manual-journal.png" alt-text="Screenshot of the manual inventory journal in Power Apps.":::

## View inventory changes

1. In Field Service, select the **Inventory** area, and then select **Warehouses**.

1. Open the warehouse where you added a manual inventory journal.

1. Select **Related** > **Product Inventory**. The inventory changes appear.

    :::image type="content" source="media/inventory-new-product-inventory-levels.png" alt-text="Screenshot of the product inventory for a warehouse in Field Service." lightbox="media/inventory-new-product-inventory-levels.png":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
