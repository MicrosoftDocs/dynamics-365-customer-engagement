---
title: Overview of inventory, purchasing, and returns
description: Learn about inventory, purchasing, and returns in Dynamics 365 Field Service.
ms.date: 11/01/2024
ms.topic: overview
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---

# Overview of inventory, purchasing, and returns

Inventory capabilities in Dynamics 365 Field Service include:

- Warehousing
- Inventory adjustments and transfers
- Consuming and billing products during work orders
- Purchasing
- Returns
- Inventory journals

Before you use inventory, purchasing, and returns, it's critical that you're familiar with [product catalog capabilities](create-product-or-service.md) in Field Service. Products are tracked in inventory only if their **Field Service Type** field is set to *Inventory*. Otherwise, inventory changes aren't shown when you add products to work orders, purchase orders, and return merchandise authorizations (RMAs).

To give a resource access to create and edit inventory-related tables, add the *Inventory Purchase* security role to their existing security role.

For basic inventory requirements, many organizations use the out-of-box capabilities. For more complex inventory and pricing requirements, Field Service is designed to integrate with enterprise resource planning (ERP) systems. In one common example, Field Service integrates with [Dynamics 365 Supply Chain Management](/dynamics365/supply-chain/sales-marketing/prospect-to-cash) by using a prebuilt [Dataverse "Prospect to cash" template](https://appsource.microsoft.com/product/dynamics-365/mscrm.c7a48b40-eed3-4d67-93ba-f2364281feb3?src=office&tab=Overview).

## Warehouses and product inventory

In Field Service, a warehouse is any company location that holds inventory. Warehouses include both static and mobile locations, such as:

- Warehouses
- Technician trucks
- Distribution centers
- Loading docks

Inventory at each warehouse is updated based on used work order products, purchase order returns, adjustments, and transfers. Updates are recorded in the related **Product Inventory** table.

:::image type="content" source="media/inventory-product-inventory.svg" alt-text="Screenshot of product inventory in the main warehouse.":::

For each product in the warehouse, the system tracks the following information:

- **Quantity Available**: The number of units that remain to be sold.
- **Quantity Allocated**: The number of units that are currently listed on work orders as allocated work order products.
- **Quantity on Hand**: The sum of **Quantity Available** and **Quantity Allocated** values. Basically, this field represents units still physically present in your warehouse, even if they're already committed to work.
- **Quantity on Order**: The number of units that are currently listed on purchase orders, but that haven't been received and added to inventory. Basically, this field represents units that are on the way.

> [!NOTE]
> By adding a warehouse to each bookable resource, you can define the default warehouse that is used when that bookable resource uses a work order product.

## Inventory adjustments and transfers

Use inventory adjustments to manually add inventory to warehouses or subtract inventory from warehouses. For example, use them during routine checkups to reflect shrinkage and defects, and to compare expected inventory to actual inventory. You can then adjust for the difference.

:::image type="content" source="media/inventory-adjustment.svg" alt-text="Screenshot of an inventory adjustment.":::

Use inventory transfers to transfer inventory from a source warehouse to a destination warehouse. For example, you can transfer inventory from a warehouse to a technician's truck.

:::image type="content" source="media/inventory-transfer.svg" alt-text="Screenshot of an inventory transfer.":::

You can also enable adjustments and transfers on the Field Service mobile app. For example, you can create an inventory transfer if technicians meet in the field and transfer inventory from one truck to another.

## Work order inventory

Inventory is affected when products are added to work orders and used. 

For example, a product is added as estimated and allocated (that is, the **Line Status** field is set to *Estimated*, and the **Allocated** field is set to *Yes*). In this case, a portion of inventory is reserved from the specified warehouse, but it isn't actually deducted.

If a work order product is used during a work order (that is, the **Line Status** field is set to *Used*), the inventory at the related warehouse is deducted by the quantity of the work order product. Typically, the warehouse that is listed on a work order product is a technician's truck.

## Purchase orders

Purchase orders (POs) are used to order products for a warehouse. They are also used to order products directly for a work order so that on-site work can be completed.

The purchase order process includes the following steps:

1. Request products from a vendor by creating a purchase order and adding purchase order products.
1. Gain approval.
1. Document the receipt of products. Create a purchase order receipt and a purchase order receipt product to add the received products to warehouse inventory, or to add them as work order products.

## Returns

Sometimes, the same organization that installs parts and equipment at a customer's location must process a return of the product or customer asset. You can issue credits to customers who initiate returns. You can also track returns as part of a customer asset's service history.

Common reasons why returns are initiated include:

- The part or equipment is defective.
- The customer is dissatisfied.
- A repair is needed, but it isn't occurring on-site. Instead, it's occurring at the service provider's or manufacturer's location.
- The equipment is at the customer's location as part of a lease that is ending and isn't being renewed.

Field Service supports three out-of-box return types:

- Return to warehouse
- Return to vendor
- Change of equipment ownership

To issue a return, follow these steps:

1. Create an RMA. The RMA indicates the products that can be returned and other important information, such as pricing. It also specifies a processing action, which is the type of return.
1. Create an RMA receipt. The return isn't finalized until an RMA receipt is created. The RMA receipt confirms that the correct product and quantity were received. It also indicates the date of the receipt and the person who handled it.

The system automatically adjusts inventory and customer assets.

## Inventory journals

All inventory transactions are recorded in inventory journals. For example, when one product is allocated to a work order, an inventory journal is created that increases the allocated quantity by one. When that same product is used to complete the work order, another inventory journal is created that decreases the on-hand quantity. Journals are recorded for all increases and decreases of product inventory. Basically, inventory journals serve as an inventory ledger in Field Service.

Most importantly, inventory journals are sometimes used to integrate Field Service inventory transactions with external ERP systems, depending on the architecture of the integration. To make integrations easier and more flexible, [inventory journals can be manually created](manual-inventory-journals.md).

## Next steps

- [Create a warehouse to track inventory](create-warehouse.md)
- [Create a purchase order](create-purchase-order.md)
- [Process a return (RMA and RTV)](process-return.md)
- [Use manual inventory journals](manual-inventory-journals.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
