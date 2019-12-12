---
title: "Create a purchase order (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/11/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: d0dd3b42-498f-492d-89c7-f5c3d2e11a2d
caps.latest.revision: 20
ms.author: krbjoran
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Create a purchase order (Field Service)

In [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)], a purchase order (P.O.) is created to add inventory to a warehouse, or to purchase products to sell to a customer in a work order.    
   

## Prerequisites

Before understanding purchase orders it's important to understand how [products and services](../field-service/create-product-or-service.md) are used in Field Service.

### Step 1: Create a purchase order 
  
1.  From the main menu, click **Field Service** > **Inventory tab** > **Purchase Orders**.  
  
2.  On the **Active Purchase Orders** screen, click **+New**.  
  
3.  Use the tooltips to help you fill in your information.  
  
4.  When you're done, click **Save**.  
  
  > [!NOTE]
  >  In the Details section, you can specify a lookup to a work order. Also, from a work order you can go to Related > Purchase Orders.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-purchase-order.png)

  
### Step 2: Add products to the P.O.  
  
  
1.  In the **Product** section, click **+Add Purchase Order product record**.  
  
2.  Use the tooltips to help you fill in your information.  
  
3.  When you're done, click **Save & Close**.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-purchase-order-products.png)

Back on the Purchase order, change the Purchase Order **System Status** to **Submitted**.

 
### Step 3: Get the P.O. approved    
  
If you have permissions to approve the P.O., then go to the purchase order and change the **System Status** to **Approved**.  

> [!NOTE]
> For products that are tracked in inventory and for purchase orders for warehouses, an inventory journal is created automatically in the background that increases the "On Order" warehouse quantity by the PO Product quantity. This helps inventory manages understand if more units have already been ordered.
   
### Step 4: Create a receipt for the P.O.  

When the order arrives, then you can create a receipt.  
  
1.  Go to **Field Service** > **Inventory tab** > **Receipts** > **+New**.  
  
2.  Give the receipt a name and assign it to the purchase order, and then mark the person creating the receipt.  
  
3.  Click **Save**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/inventory-purchase-order-receipt.png)

    
### Step 5: Add P.O. receipt products  
  
1. From the PO Receipt, add related PO Receipt Products  


  
  
### Step 6: Create P.O. bill  
 Once you receive an invoice from the vendor, then you can create a purchase order bill.  
  
1.  From the top menu, click the drop-down arrow next to the P.O. name that you created, and then click **Bills**.  
  
2.  On the **Purchase Order Bill Associated View** screen, click **+Add New Purchase Order Bill**.  
  
3.  Use the tooltips to help fill in your information:  
  
    -   Enter a **Bill Date**—this is the date that's on the purchase order bill.  
  
    -   Enter a **Vendor Invoice Number** so that you’ll have a cross reference to the invoice number that the vendor provided.  
  
4.  Click **Save**.  
  
5.  To add items on the bill, from the top menu, click the drop-down arrow next to the bill name, and then click **Receipt Products**.  
  
6.  On the **Purchase Order receipt Product Associated View** screen, click **+Add New Purchase Order Receipt Products**, and then add the item.  

## Ship via

When you create a [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] purchase order in the system, it's a good idea  to track how the order is shipped. This helps you track the purchase order. The ship-via option lets you specify different shipping methods used by your company.  
  
 For example, you might use freight shipping, USPS Ground, or FedEx when products are purchased. In this case, you can specify these shipping methods in the ship-via setting. When you create ship-via methods, you'll see this in the purchase order form.  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Ship Via**.  
  
2.  On the **Active Ship Via** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help you fill in your information, and then click **Save**.  

A P.O. Receipt does not need to contain all Products requested or all quantities requested. Oftentimes, Products
will be received as they arrive. Some Products may arrive sooner and larger quantity shipments may arrive in
numerous shipments. In these situations, numerous P.O. Receipts can be created for a single Purchase Order
  
### See also      
 [Configure and set up customer assets](../field-service/configure-set-up-customer-assets.md)   
 [Create an inventory adjustment](../field-service/create-inventory-adjustment.md)   
 [Create an inventory transfer](../field-service/create-inventory-transfer.md)   
 [View product inventory](../field-service/view-product-inventory.md)   
 [Create a return to vendor](../field-service/create-return-vendor.md)   
 [Process a return](../field-service/process-return.md)<br>

