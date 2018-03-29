---
title: "Create an inventory adjustment (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: f819da43-ccc8-4c76-9467-3c4a4d8f4c18
caps.latest.revision: 16
ms.author: "mkaur"
manager: "amyla"
---
# Add or subtract inventory from a warehouse (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can do an inventory adjustment in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] to add or subtract inventory to or from a warehouse.  
  
Let's say you're getting a new shipment of  Product A that you're going to add to Warehouse 1. In this case you would create a new inventory adjustment record and specify the warehouse. Next you'll add the product to the inventory adjustment record and specify the product, unit, and quantity.  
  
<a name="BKMK_1"></a>   
## Step 1: Create an inventory adjustment  
  
1.  From the main menu, click **Field Service** > **Inventory Adjustments**.  
  
2.  On the **Active Inventory Adjustment** screen, click **+New**.  
  
3.  Choose the **Warehouse** where the inventory will be added or subtracted.  
  
4.  Choose who is making the adjustment:  
  
    -   If you're making the inventory adjustment, choose your name in the **Adjusted By Resource** field.  
  
    -   If another resource requested the adjustment, choose their name in the **Adjusted By Resource** field.  
  
5.  Click **Save**.  
  
<a name="BKMK_2"></a>   
## Step 2: Add products to the inventory adjustment  
  
1.  From the top menu, click the drop-down arrow next to the item you created, and then click **Products**.  
  
2.  Click **+Add New Inventory Adjustment Product**.  
  
3.  Fill in the **Product**, **Unit**, and **Quantity**.  
  
4.  Click **Save & Close**.  
  
### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Configure and set up customer assets](../field-service/configure-set-up-customer-assets.md)   
 [Create a purchase order](../field-service/create-purchase-order.md)   
 [Create an inventory transfer](../field-service/create-inventory-transfer.md)   
 [View product inventory](../field-service/view-product-inventory.md)   
 [Create a return to vendor](../field-service/create-return-vendor.md)   
 [Process a return](../field-service/process-return.md)   
 [Create a warehouse](../field-service/create-warehouse.md)   
 [Create a product or service](../field-service/create-product-or-service.md)<br>
 [User's Guide](../field-service/user-guide.md) 
