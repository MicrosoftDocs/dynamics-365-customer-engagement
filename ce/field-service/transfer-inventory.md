---
title: Transfer inventory between warehouses
description: Learn how to create an inventory transfer in Dynamics 365 Field Service to move product inventory from one warehouse to another.
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

# Transfer inventory between warehouses

Use inventory transfers to move product inventory from a source warehouse to a destination warehouse in Dynamics 365 Field Service. For example, transfer inventory from a central warehouse to a technician's truck, or from one truck to another when technicians meet in the field.

When you add a product to a transfer, Field Service creates two [inventory journals](developer/reference/entities/msdyn_inventoryjournal.md): one that decreases the **Quantity on Hand** at the source warehouse, and one that increases the **Quantity on Hand** at the destination warehouse. Because **Quantity Available** is derived from **Quantity on Hand**, the available quantity changes at both warehouses.

To increase or decrease inventory at a single warehouse instead of moving it between warehouses, [adjust inventory levels](adjust-inventory.md).

## Prerequisites

- A source [warehouse](create-warehouse.md) and a destination warehouse must exist in your system.
- Products where **Field Service Product Type** = *Inventory* must exist in your system. You can't transfer non-inventory or service products.
- The source warehouse must have enough **Quantity on Hand** for the products you transfer. Field Service blocks a transfer when the quantity exceeds the amount on hand at the source warehouse, or when the product has no inventory record at the source warehouse.
- You need either the *Field Service - Administrator* security role or the *Inventory Purchase* security role added to your base Field Service security role. Learn more in [Security roles and column-level security profiles](security-permissions.md).

## Create an inventory transfer

1. In Field Service, select the **Inventory** area.

1. Under **Inventory**, select **Transfers**, and then select **New**.

1. In the **Source Warehouse** field, select the warehouse to move inventory from.

1. In the **Destination Warehouse** field, select the warehouse to move inventory to.

1. Select **Save** to create the record.

    :::image type="content" source="media/inventory-transfer.svg" alt-text="Screenshot of an inventory transfer.":::

## Add products to the inventory transfer

Add a row for each product that you want to move from the source warehouse to the destination warehouse.

1. In the saved inventory transfer, on the **Inventory Transfer Products** subgrid, select **New Inventory Transfer Product**.

1. In the **Product** field, select a product where **Field Service Product Type** = *Inventory*.

1. In the **Unit** field, select the unit of measure.

1. In the **Quantity** field, enter the amount to transfer. Enter a positive value that doesn't exceed the **Quantity on Hand** at the source warehouse.

1. Select **Save and Close**. Field Service creates the inventory journals that move the inventory between the warehouses.

1. Repeat these steps for each product that you want to transfer.

## Verify the inventory change

Confirm that the transfer updated the product inventory at both warehouses.

1. In Field Service, select the **Inventory** area, and then select **Warehouses**.

1. Open the source warehouse. On the **Related** tab, select **Product Inventory**, and confirm that the **Quantity on Hand** decreased for the transferred products.

1. Return to the list of warehouses and open the destination warehouse. On the **Related** tab, select **Product Inventory**, and confirm that the **Quantity on Hand** increased for the transferred products.

## Transfer inventory on the Field Service mobile app

Inventory transfers aren't available in the Field Service mobile app by default. To let technicians transfer inventory in the field—for example, from one truck to another when they meet on-site—an administrator with app customization privileges must add the **Inventory Transfer** table to the mobile app:

- Add the **Inventory Transfer** table to the mobile app's navigation. Learn more in [Edit the navigation and views on the mobile app](/dynamics365/guidance/resources/field-service-mobile-edit-navigation-views).
- To make transfers available when technicians work without a connection, add the **Inventory Transfer** and **Inventory Transfer Product** tables to the [mobile offline profile](mobile/set-up-offline-profile.md).

After the table is enabled, technicians create a transfer by using the same steps described in this article.

## Next steps

- [Overview of inventory, purchasing, and returns](inventory-purchasing-returns-overview.md)
- [Adjust inventory levels](adjust-inventory.md)
- [Create a warehouse to track inventory](create-warehouse.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
