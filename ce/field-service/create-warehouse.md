---
title: "Create a warehouse (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: 14811327-a740-4d02-815f-fc908421fbc2
caps.latest.revision: 12
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
# Create a warehouse to track inventory (Field Service)

Track your product inventory using a warehouse record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
 To do this, create a warehouse record, and then add your product inventory to it.  
  
<a name="BKMK_1"></a>   
## Step 1: Create a warehouse record  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Warehouses**.  
  
    Or, from the main menu, click **Field Service** > **Warehouses**.  
  
2.  On the **Active Warehouse** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then click **Save**.  
  
<a name="bkmk_2"></a>   
## Step 2: Manually add product inventory to the warehouse record  
 Product inventory is automatically adjusted in the warehouse record when an inventory adjustment record is created.  
  
 You can also manually add product inventory to a warehouse record, but keep in mind that you won’t be able to modify the quantity values.  
  
1.  From the top menu, click the drop-down arrow next to the warehouse that you created, and then click **Product Inventory**.  
  
2.  Click **+Add New Product Inventory**.  
  
3.  Fill in the **Product**, **Unit**, and **Quantity** information.  
  
4.  Click **Save & Close**.  
  
<a name="bkmk_3"></a>   
## Optional: Add a reorder and location inventory  
  
1.  Go to a **Warehouse**, and then select **Product Inventory**.  
  
2.  Select a product.  
  
3.  You can specify the **Bin** and **Row** where the product resides in the warehouse. You can also render a reorder point.  
  
### See also  

- [Create a product or service](../field-service/create-product-or-service.md)
