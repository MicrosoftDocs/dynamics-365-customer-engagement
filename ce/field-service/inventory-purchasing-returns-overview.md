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

FieldOne Sky Inventory capabilities include:
Warehousing
Purchasing
Adjustments and Transfers
Selling Products through the Work Order process
Returns

## Prerequisites
> [!Note]
>


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Warehouses and product inventory

A Warehouse in FieldOne Sky is any company location that holds Inventory. This includes static as well as mobile locations
such as:
Warehouses
Distribution centers
Loading docks
Trucks

Quantity Available represents how many
units are left to be sold.
Quantity Allocated represents how many
units are currently listed on Work Orders as
Work Order products.
Quantity on Hand represents the total of
quantity available and quantity allocated.
Quantity on Order represents how many units
are currently listed on Purchase Orders but
have not been received and added to Inventory
yet. Basically, units that are on the way

## Inventory adjustments and transfers

Inventory Adjustments is a FieldOne Sky feature that allows you to manually add or subtract Inventory from Warehouses.
This feature is typically used for routine checkups to reflect shrinkage and defects as well as compare expected Inventory
to actual Inventory and then adjust for the difference.
Inventory Transfers is a FieldOne Sky feature that allows you transfer Inventory from a source Warehouse to a destination
Warehouse. The most common example of this is transferring Inventory from a Warehouse to a Field Agent’s truck.

INVENTORY TRANSFERS ON THE FIELDONE SKY MOBILE APP

## Work order inventory

Adding Products to Work Orders affects Inventory.
As an example, adding a Product as estimated reserves a portion of Inventory from the specified Warehouse, though it
doesn’t actually deduct it.
If a Work Order Product is added as used or an estimated Product is then used and sold to a customer during a Work
Order, this will deduct the Product from Inventory

We can add a Product to a Work Order as estimated. This
will allocate a portion of that Warehouse’s Inventory. It is also
important to note that we can skip the warehousing and transfer
process if we need to and send parts directly from a Purchase
Order to a Work Order location. This is done by simply relating a
Purchase Order to a Work Order. Refer to the LMS course titled
“Purchase Orders” for more details.

Adding a Product to a Work Order affects Inventory
There are two options when adding a Product as Estimated to a Work Order:
Not marked as Allocated: not reserving Product but specifying need
Marked as Allocated: reserving Product for the Work Order
Next, a Product may be added to a Work Order as Used
This deducts it from Inventory
And may allow it to become a piece of Customer Equipment depending if the Product is marked to do so

## Inventory journals

## Purchase orders

The Purchase Order process includes:
Requesting Products from a Vendor by creating a Purchase Order
Gaining approval
Finally, documenting receipt of Products by creating a PO receipt. This will add the ordered Product to Inventory

## Returns

FieldOne Sky supports three out-of-the-box Returns:
Return to Warehouse
Return to Vendor
Change of Equipment Ownership

Returns can be categorized to gain important analytics.
Common examples include:
Defect
Customer dissatisfaction
Repair under warranty
Repair not under warranty
End of lease
Each Return can be related to a piece of Customer Equipment if applicable. This is another way of keeping track of service
history. Throughout the lifetime of Equipment, you can see all the times it was returned, repaired, scrapped, changed
owner, etc.
You can issue credits to customers who return Products regardless if it is a full or partial credit based on warranty or other
circumstances.

All Product Returns are initiated with Return
Merchandise Authorizations, simply referred to
as “RMAs.” The RMA designates the Products
to be returned as well as all other important
information, such as warranty and pricing. It
also specifies a processing action, which is
the type of Return.
However, the Return isn’t finalized until an
RMA Receipt is created. The RMA Receipt
confirms the correct Product and quantity are
received as well as date and person handling
the receipt.

## Configuration considerations
## Additional Notes
