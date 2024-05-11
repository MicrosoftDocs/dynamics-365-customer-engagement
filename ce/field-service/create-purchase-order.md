---
title: Create a purchase order
description: Learn about creating purchase orders in Dynamics 365 Field Service.
ms.date: 05/08/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
---

# Create a purchase order

In Dynamics 365 Field Service, a purchase order (PO) is created to add inventory to a warehouse, or to purchase products to sell to a customer in a work order.

## Prerequisites

- Understand how [products and services](../field-service/create-product-or-service.md) are used in Field Service.

## Step 1: Create a purchase order
  
1. In **Field Service** go to the **Inventory** area.  

1. Under **Purchase**, select **Purchase Orders**.
  
1. On the **Active Purchase Orders** screen, select **+New**.  
  
1. Use the tooltips to help you fill in your information.  
  
1. When you're done, **Save**.  
  
1. On the **Details** tab, specify a lookup to a work order. You can also do that on the work order from **Related** > **Purchase Orders**.

:::image type="content" source="media/inventory-purchase-order.png" alt-text="Screenshot of a purchase order in draft state.":::

### Ship via

When you create a purchase order, you can track how the order is shipped. The **Ship Via** field on the **Details** tab lets you specify different shipping methods used by your company. To create new options, go to **Field Service** > **Settings** > **Inventory** > **Ship Via**. Common examples include freight shipping, private delivery, or postal services.

## Step 2: Add products to the purchase order
  
1. On the **Products** tab, select **+New Purchase Order Product** to create a product related to the purchase order.  
  
1. Use the tooltips to help you fill in your information.  
  
1. When you're done, **Save & Close**.  

:::image type="content" source="media/inventory-purchase-order-products.png" alt-text="Screenshot of purchase order products.":::

1. Go back to the purchase order and change the **System Status** to **Submitted**.

## Step 3: Get the purchase order approved
  
If you have permissions to approve the PO, go to the PO and change the **System Status** to **Approved**.  

> [!NOTE]
> For products that are tracked in inventory and for purchase orders being received to warehouses, an inventory journal is created automatically in the background that increases the **On Order** warehouse quantity by the PO product quantity. This helps inventory managers understand if more units have already been ordered.

## Step 4: Create a receipt for the purchase order  

When the order arrives, you can create a receipt.  
  
1. Go to **Field Service** > **Inventory tab** > **Receipts** > **+New**.  
  
1. Give the receipt a name and assign it to the purchase order, and then mark the person creating the receipt.  
  
1. Select **Save**.  

:::image type="content" source="media/inventory-purchase-order-receipt.png" alt-text="Screenshot of a purchase order receipt.":::

## Step 5: Add purchase order receipt products  
  
From the purchase order receipt, add related purchase order receipt products.

A purchase order receipt doesn't need to contain all products requested or all quantities requested. Products are often received as they arrive. Some products might arrive sooner and larger quantity shipments might arrive in multiple shipments. In these situations, multiple purchase order receipts can be created for a single purchase order.

## Step 6: Create purchase order bill

 Once you receive an invoice from the vendor, then you can create a purchase order bill.  
  
1. From the original purchase order, go to **Inventory** > **Purchase** > **Bills** and select **+New**.

1. Use the tooltips to help fill in your information:  
  
   - Enter a **Bill Date** to specify the date that's on the purchase order bill.  
  
   - Enter a **Vendor Invoice Number** to have a cross reference to the invoice number that the vendor provided.  
  
1. Select **Save**.  
  
1. To add items to the purchase order bill, go to **Related** > **Receipt Products** and select **+New**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
