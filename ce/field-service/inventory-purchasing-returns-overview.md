---
title: Overview of inventory, purchasing, and returns
description: Learn about inventory, purchasing, and returns in Dynamics 365 Field Service
ms.date: 06/26/2024
ms.topic: overview
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---

# Overview of inventory, purchasing, and returns

Dynamics 365 Field Service inventory capabilities include:

- Warehousing
- Inventory adjustments and transfers
- Consuming and billing products during work orders
- Purchasing
- Returns
- Inventory journals

Knowledge of [Field Service product catalog capabilities](create-product-or-service.md) is critical before using inventory, purchasing, and returns. Only products that have a **Field Service Type** set to **Inventory** are tracked in inventory. Otherwise, you don't see inventory changes when adding products to work orders, purchase orders, and return merchandise authorizations (RMAs).

To give a resource access to create and edit inventory-related tables, add the **Inventory Purchase** security role to their existing security role.

For basic inventory requirements, many organizations utilize these included capabilities. For more complex inventory and pricing requirements, Field Service is designed to integrate with enterprise resource planning (ERP) systems. A common example is integrating with [Dynamics 365 Supply Chain Management](/dynamics365/supply-chain/sales-marketing/prospect-to-cash) using a prebuilt [common data service "prospect to cash" template](https://appsource.microsoft.com/product/dynamics-365/mscrm.c7a48b40-eed3-4d67-93ba-f2364281feb3?src=office&tab=Overview).

## Warehouses and product inventory

A warehouse in Field Service is any company location that holds inventory, including static and mobile locations such as:

- Warehouses
- Technician trucks
- Distribution centers
- Loading docks

Inventory at each warehouse is updated based on used work order products, purchase orders returns, adjustments, and transfers. Updates are recorded in the related **Product Inventory** table.

:::image type="content" source="media/inventory-product-inventory.svg" alt-text="Screenshot of product inventory in the main warehouse.":::

For each product at the warehouse, the system tracks:

- **Quantity Available** - how many units remain to be sold.
- **Quantity Allocated** - how many units are currently listed on work orders as allocated work order products.
- **Quantity on Hand** - sum of quantity available and quantity allocated. Basically, unsold units.
- **Quantity on Order** - how many units are currently listed on purchase orders, but haven't been received and added to inventory. Basically, units that are on the way.

> [!NOTE]
> By adding a warehouse to each bookable resource, you can define the default warehouse that is used when that bookable resource uses a work order product.

## Inventory adjustments and transfers

To manually add or subtract inventory from warehouses, use an inventory adjustment. Use them for routine checkups to reflect shrinkage and defects, and compare expected inventory to actual inventory. Then you can adjust for the difference.

:::image type="content" source="media/inventory-adjustment.svg" alt-text="Screenshot of an inventory adjustment.":::

To transfer inventory from a source warehouse to a destination warehouse, use an inventory transfer. For example, transfer inventory from a warehouse to a technician’s truck.

:::image type="content" source="media/inventory-transfer.svg" alt-text="Screenshot of an inventory transfer.":::

You can also enable adjustments and transfers on the Field Service mobile app. For example, create an inventory transfer if technicians  meet in the field and transfer inventory from one truck to another.

## Work order inventory

Adding products to work orders and using them affects inventory. 

For example, adding a product as estimated and allocated (**Line Status** set to **Estimated**, **Allocated** and **Yes**) reserves a portion of inventory from the specified warehouse, though it doesn’t actually deduct it.

If a work order product is used during a work order (**Line Status** set to **Used**), the inventory at the related warehouse is deducted by the work order product quantity. Typically, the warehouse listed on a work order product is the technician's truck.

## Purchase orders

Purchase orders (POs) are used to order products to a warehouse or directly to a work order to complete on-site work.

The purchase order process includes:

1. Request products from a vendor by creating a **Purchase Order** and adding **Purchase Order Products**.
2. Gain approval.
3. Document receipt of products. Create a PO receipt and PO receipt product to add the received products to warehouse inventory or as work order products.

## Returns

Sometimes the same organization that installs parts and equipment at a customer's location needs to process a return of that product or customer asset. You can issue credits to customers who initiate returns and track returns as part of customer asset service history.

Common examples for why returns might be initiated include:

- The part or equipment is defective.
- The customer is dissatisfied.
- A repair is needed and the repair isn't taking place on-site, but back at the service provider's or manufacturer's location.
- The equipment is at the customer's location as part of a lease that is ending and isn't being renewed.

Field Service supports three out-of-the-box returns:

- Return to warehouse
- Return to vendor
- Change of equipment ownership

To issue a return:

1. Create return merchandise authorizations (RMAs). The RMA designates the products to be returned and other important information, such as pricing. It also specifies a processing action, which is the type of return.

1. Create RMA receipt. The return isn’t finalized until an RMA receipt is created. The RMA receipt confirms the correct product and quantity were received and the date and person handling the receipt.

The system automatically adjusts inventory and customer assets.

## Inventory journals

All inventory transactions are recorded in the **Inventory Journals**. For example, when one product is allocated to a work order, an inventory journal is created that increases quantity allocated by one. When that same product is then used to complete the work order, another inventory journal is created that decreases quantity on hand. Journals are recorded for all increases and decrease of product inventory. Basically, inventory journals serve as an inventory ledger within Field Service.

Most importantly, inventory journals are sometimes used to integrate Field Service inventory transactions into external ERP systems, depending on how the integration is architected. To make integrations easier and more flexible, [inventory journals can be manually created](manual-inventory-journals.md). 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
