---
title: "Create an inventory transfer (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: dyn365-fieldservice 
ms.date: 09/30/2017
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
ms.assetid: dbf20833-9c77-464e-be79-e80150e2121e
caps.latest.revision: 14
ms.author: krbjoran
manager: shellyha
---
# Change the warehouse location of inventory (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

An inventory transfer is when you change the warehouse location of product inventory.  
  
 For example, if you decide to transfer Product A from Warehouse 1 to Truck 2, then you would create an inventory transfer record. Next, you'll specify the product that you are moving from one location to another.  
  
 When you transfer inventory, it automatically creates an inventory adjustment product record within the inventory transfer record.  
  
1.  From the main menu, click **Field Service** > **Inventory Transfers**.  
  
2.  On the command bar at the top, click **Transfer Inventory.** A new pop up window will appear.  
  
    > [!NOTE]
    >  Do not create an inventory transfer using the **+New** option.  
  
3.  Select the **Source Warehouse**; this is where the inventory is currently stored.  
  
4.  Select the **Destination Warehouse**; this is where the inventory will be moved to.  
  
5.  Enter the quantity you want to transfer in the **Transfer Qty**field. Remember, you cannot transfer more than what is listed in **Quantity On Hand**.  
  
6.  Click **Transfer**.  
  
### See also    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Configure and set up customer assets](../field-service/configure-set-up-customer-assets.md)   
 [Create a purchase order](../field-service/create-purchase-order.md)   
 [Create an inventory adjustment](../field-service/create-inventory-adjustment.md)   
 [View product inventory](../field-service/view-product-inventory.md)   
 [Create a return to vendor](../field-service/create-return-vendor.md)   
 [Process a return](../field-service/process-return.md)   
 [Create a warehouse](../field-service/create-warehouse.md)   
 [Create a product or service](../field-service/create-product-or-service.md)<br>
 [User's Guide](../field-service/user-guide.md)
