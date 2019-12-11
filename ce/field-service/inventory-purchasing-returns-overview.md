---
title: "Overview of inventory, purchasing, and returns in Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/10/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Overview of inventory, purchasing, and returns

Dynamics 365 Field Service inventory capabilities include:

- Warehousing
- Inventory adjustments and transfers
- Consuming and billing products during Work Orders
- Purchasing
- Returns
- Inventory journals

For basic inventory requirements, many organizations utilize the above capabilities included with Field Service. For more complex inventory and pricing requirements, Field Service is designed to integrate with enterprise resource planning (ERP) systems. A common example is integrating to [Dynamics 365 Finance & Operations](https://docs.microsoft.com/en-us/dynamics365/supply-chain/sales-marketing/prospect-to-cash) using a pre-built [common data service "prospect to cash" template](https://appsource.microsoft.com/en-us/product/dynamics-365/mscrm.c7a48b40-eed3-4d67-93ba-f2364281feb3?src=office&tab=Overview).

## Prerequisites
Knowledge of [Field Service product catalog capabilities](./create-product-or-service.md) is a critical before utilizing inventory, purchasing, and return functionality.

> [!Note]
>


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Warehouses and product inventory

A Warehouse in Field Service is any company location that holds inventory. This includes static as well as mobile locations such as:

- Warehouses
- Technician trucks
- Distribution centers
- Loading docks

Inventory at each warehouse is tracked as used work order products, purchase orders, returns, adjustments and transfers events incremement and decrement inventory levels. This is recorded in the related Product Inventory entity.

For each product at the warehouse, the system tracks:

**Quantity Available** - how many units are left to be sold.
**Quantity Allocated** - how many units are currently listed on Work Orders as allocated Work Order products.
**Quantity on Hand** - sum of quantity available and quantity allocated. Basically unsold units.
**Quantity on Order** - how many units are currently listed on Purchase Orders but have not been received and added to Inventory yet. Basically, units that are on the way.

## Inventory adjustments and transfers

**Inventory Adjustments** is a feature that allows you to manually add or subtract Inventory from Warehouses. This feature is typically used for routine checkups to reflect shrinkage and defects as well as compare expected Inventory to actual Inventory and then adjust for the difference.

**Inventory Transfers** is a feature that allows you to transfer Inventory from a source Warehouse to a destination warehouse. The most common example of this is transferring Inventory from a Warehouse to a technicians’s truck.

You can also enable adjustments and transfers on the Field Service Mobile app to allow technicians to meet in the field and record an inventory transfer from one truck to another as one example.

## Work order inventory

Adding products to work orders and using them affects inventory. 

As an example, adding a product as estimated and allocated (Line Status = Estimated, Allocated = Yes) reserves a portion of inventory from the specified warehouse, though it doesn’t actually deduct it.

If a Work Order Product is used during a Work Order (Line Status = Used), the inventory at the related warehouse is deducted by the work order product quantity. Typically, the warehouse listed on a work order product is the technician's truck.


## Purchase orders

Purchase orders are used to order products to a warehouse or directly to a work order to complete on site work. 

The Purchase Order process includes:

1. Requesting Products from a Vendor by creating a Purchase Order and adding Purchase Order Products
2. Gaining approval
3. Documenting receipt of Products by creating a PO receipt and PO Receipt Products. This will add the received Products to warehouse inventory or as Work Order Products.


## Returns

Sometimes the same organization that installs parts and equipment at a customer's location needs to process a return of that product or customer asset.

Common examples for why returns may be initiated include:

- The part or equipment is defective
- The customer is dissatisfied
- A repair is needed and the repair will not take place on site, but back at the service provider's or manufacturer's location
- The equipment was at the customer's location as part of a lease that is ending and will not be renewed


Field Service supports three out-of-the-box returns:

- Return to Warehouse
- Return to Vendor
- Change of Equipment Ownership

All Product Returns are initiated with Return Merchandise Authorizations, simply referred to as “RMAs.” The RMA designates the Products to be returned as well as all other important information, such as pricing. It also specifies a processing action, which is the type of Return. However, the return isn’t finalized until an RMA Receipt is created. The RMA Receipt confirms the correct Product and quantity were received as well as date and person handling the receipt.

There are three steps when issuing a Return
1. Create RMA
2. Create RMA Receipt
3. Inventory and Customer Asset adjustments are carried out (done automatically)

Other important features of RMAs include the ability to issue credits to customers who initiate returns and the ability to rrack returns as part of customer asset service history.

## Inventory journals

Inventory Journals are kept for each Warehouse. They keep track of Product movements
Navigate to a Warehouse
Select the Inventory Journals tile in the ribbon

## Configuration considerations
- Inventory purchase security role
- truck on bookable resource record

## Additional Notes
