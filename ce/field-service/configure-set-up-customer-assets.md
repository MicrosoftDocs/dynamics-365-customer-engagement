---
title: "Asset Management in Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/29/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: 75a7739a-53e8-43e7-bd6d-ca7317a69d30
caps.latest.revision: 16
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
# Asset Management in Field Service 

Customer asset functionality lets you maintain a list of serviceable items related to a service location.  
  
 When you create and maintain a list of serviceable items, you can:  
  
-   Record specific information about the item.  
  
-   Create a historic log of all of the work orders that are related to the item, which gives you a complete service history for the item.  
  
Customer asset records can be configured in a hierarchy in order to maintain service history at the sub-component level.  
  
> [!NOTE]
> To associate customer assets with work order records, you must specify the customer asset within the work order incident or agreement incident records.  
  
 
## Create customer assets

### Manually 
  
1.  From the main menu, click **Field Service** > **Customer Assets**.  
  
2.  On the **Active Customer Assets** screen, click **New**.  Use the tooltips to help you fill in information.  
  
3.  Enter the **Name** of the customer asset record.  
  
4.  Enter the **Service Account** to indicate the service location of the customer asset.  
  
5.  Optionally, enter the direct **Parent** of the current asset if you are creating a sub-component customer asset. For example, a refrigerator asset record can be the parent asset to a compressor asset record.  
  
6.  Optionally, enter the **Product** from the product catalog that identifies this asset.  
  
7.  When you're done, click **Save**.  
  
8.  In the **Sub Assets** section, click **Add Customer Asset record** to add any related assets.  
   
### Automatically add customer assets to a service location  
  
1.  In the product catalog, find a product that you would like the system to automatically add as a customer asset when sold to a customer.  
  
2.  In the **Field Service** section of the product record form, set the **Convert to Customer Asset** field to **Yes**.  
  
3.  Save the changes to the product record.  
  
4.  Now, when a work order is completed, by changing the work order system status to **Closed - Posted**, if the work order includes a work order product that was set to **Convert to Customer Asset**, the system will automatically generate the customer asset record, and associate it with the service account listed on the work order.

## Build service history 

- notes + timeline

### With work orders
- Incidents

- WOP, WOS, WOST

### With agreements

Agreement incident types

## Connected Field Service

## Configuration considerations
- serial number
- customer asset with quantity 2 will not create 2 customer asset records, but there will be a lookup reference to the work order product that will show a quantity of 2

## Additional notes
- can relate to booking alerts

  
### See also    
[Create work order templates with incident types](../field-service/configure-incident-types.md) 

[Set up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md)

[Adding 3D models to customer assets](../field-service/3D-viewer.md)    
 
