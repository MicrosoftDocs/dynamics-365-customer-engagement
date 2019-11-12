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
  

In this article let's explore creating customer assets and noting them on work orders, agreements, and IoT devices to build service history.

  
## Prerequisites

- Customer assets can be created and noted on work orders to build service history in all versions of Field Service
- Associating customer assets with IoT devices in Connected Field Service is available with Field Service 7.5.5+ and 8.2+ 

## Create customer assets

### Manually 

You can create customer assets manually or via import. 

From the main menu, click **Field Service** > **Customer Assets** > **+New**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-create-manually.png)
  
**Name:** enter a reference name or title for the customer asset that stakeholders can refer to. This can be the make and model of the customer asset, the name of the product in the product catalog, a general name like "HVAC Unit," and can even hold descriptive information like "HVAC Unit 2nd Floor".
  
**Service Account:** choose an account from the lookup to represent the location and customer of the customer asset. As a simple rule, if you were going to create a work order to repair the customer asset, the service account of the work order and the service account of the customer asset should be the same. 

**Product:** if the customer asset correlates with a product in your product catalog, choose it from the lookup. This is optional. 

**Parent Asset:** Field Service supports hierarchical customer asset structures. As an example, a part can be the child of a widget, which is the child of a machine and you can have as many parent-child relationships as needed. Use this field to identify the direct parent of this customer asset. The **Master Asset** shows the top level parent in the relationship automatically. In addition, you can use the Sub Asset grid on the form to add child customer assets. 

 **Save**.  

> [!Note]
> If needed, you can even create a customer asset without a look up to the product record by simply 

   
### Automatically add customer assets to a service location  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-convert-to-customer-asset.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-used.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-work-order-complete.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-auto-new-list.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-auto-new-form.png)
  
1.  In the product catalog, find a product that you would like the system to automatically add as a customer asset when sold to a customer.  
  
2.  In the **Field Service** section of the product record form, set the **Convert to Customer Asset** field to **Yes**.  
  
3.  Save the changes to the product record.  
  
4.  Now, when a work order is completed, by changing the work order system status to **Closed - Posted**, if the work order includes a work order product that was set to **Convert to Customer Asset**, the system will automatically generate the customer asset record, and associate it with the service account listed on the work order.

## Build service history 

### Notes on timeline


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-note-mobile-install.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-note-web-install.png)

> [!NOTE]
> To associate customer assets with work order records, you must specify the customer asset within the work order incident or agreement incident records.  

### With work orders
- Incidents


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-primary-incident.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-asset-relation.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-related-work-orders.png)


- WOP, WOS, WOST

### With agreements

Agreement incident types

[Set up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md)  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-agreement-incident.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-agreement-setup.png)


## Connected Field Service

![Video symbol](../field-service/media/video-icon.png "Video symbol") [Set up Connected Field Service with Azure IoTCentral](https://youtu.be/Sp7_JoXjHDk)

relate one or more devices to a customer asset


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-iot-device.png)

See associated records > Connect 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-iot-device-connect.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-iot-alert.png)

## Configuration considerations

- serial number
- customer asset with quantity 2 will not create 2 customer asset records, but there will be a lookup reference to the work order product that will show a quantity of 2
- [Adding 3D models to customer assets](../field-service/3D-viewer.md)

## Additional notes
- can relate to booking alerts

  
### See also    
[Create work order templates with incident types](../field-service/configure-incident-types.md) 

[Set up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md)

[Adding 3D models to customer assets](../field-service/3D-viewer.md)    
 
