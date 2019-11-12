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

Customer Assets can be created:

1. manually or via import
2. automatically when work order products are used

### Manually 

You can create customer assets manually or via import. 

From the main menu, click **Field Service** > **Customer Assets** > **+New**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-create-manually.png)
  
**Name:** enter a reference name or title for the customer asset that stakeholders can refer to. This can be the make and model of the customer asset, the name of the product in the product catalog, a general name like "HVAC Unit," and can even hold descriptive information like "HVAC Unit 2nd Floor".

**Category:** - Add or create a customer asset category that serves as a label to organize assets into useful groups by function, model, etc based on your business needs.

**Service Account:** choose an account from the lookup to represent the location and customer of the customer asset. As a simple rule, if you were going to create a work order to repair the customer asset, the service account of the work order and the service account of the customer asset should be the same. 

**Product:** if the customer asset correlates with a product in your product catalog, choose it from the lookup. This is optional and allows for flexibility to manage more of the customer's assets even if the asset did not originate from your product catalog. One example is if the field service organization takes over managing existing assets from a different manufacturer or supplier. 

**Parent Asset:** Field Service supports hierarchical customer asset structures. As an example, a part can be the child of a widget, which is the child of a machine and you can have as many parent-child relationships as needed. Use this field to identify the direct parent of this customer asset. The **Master Asset** shows the top level parent in the relationship automatically. In addition, you can use the **Sub Asset** grid on the form to add child customer assets. 

 **Save**.  
   
### Automatically add customer assets to a service location  

Customer assets can also be created automatically when a work order product is used during a work order.

First go to the Product in the product catalog you would like to become a customer asset when it is sold to a customer (i.e. added to a work order and used).

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-convert-to-customer-asset.png)

In the Field Service section of the product record, set **Convert to Customer Asset** to **Yes**. 

> [!Note]
> Services cannot become customer assets, only products where Field Service Product Type = Inventory or Non-inventory.

Next add the product to a work order, thus creating a work order product. this can be done manually or automatically when a work order incident type is added.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-used.png)

Add a **Quantity** and set **Line Status** to **Used** on the work order product indicating it was consumed during the work order. This is most commonly done on Field Service Mobile by a field technician. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-work-order-complete.png)

Now, when a work order is completed, by changing the work order system status to **Open-Completed**, if the work order includes a work order product that was set to **Convert to Customer Asset**, the system will automatically generate the customer asset record, and associate it with the service account listed on the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-auto-new-list.png)

Unlike manually created customer assets, ones created from work order products will have a link to the work order product. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-auto-new-form.png)

  
## Build service history 

After customer assets are created you can track repairs, inspections, tests, IoT telemetry, and issues to build service history. Understanding service history is important for making better repair decisions, maintaining asset lifespan and uptime, and ultimately keeping the customer happy.

### Notes on timeline

The simplest and crudest way to build service history is to use notes and the timeline feature available on Dynamics 365 forms.

As an example, from Field Service Mobile, the field technician can navigate to the customer asset record and add a note.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-note-mobile-install.png)

Beyond typing text, Field Service Mobile allows you to add pictures, videos, and voice recordings with notes.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-note-web-install.png)

Notes will appear in the customer asset form timeline and things like pictures will show as attachments.

One drawback of using notes and the timeline is it is less organized and hard to report on or create metrics for. As an example, imagine as a field service organization you want to report on the number of times a specific asset or asset class has needed repairs; the timeline would be too unorganized for this. Using the timeline is better for anecdotal notes that give field technicians tips and context.

### With work orders

A standard and more organized way to build service history is to note the customer asset on work order incidents.

As a reminder, incident types are common and distinct issues that serve as work order templates and automatically add details like work order type, work order products, services, and tasks. See the topic on [Creating work order templates with incident types](./configure-incident-types.md).

The first and most important work order incident type can be added directly from the main work order form in the Primary Incident Type field. If the incident type is for example an inspection, and the purpose is to inspect a specific asset at the work order location (service account) then add a **Primary Incident Customer Asset**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-primary-incident.png)

Keep in mind you can add multiple work order incidents to a work order by going to **Related >  Incidents > +New Work Order Incidents** and each incident can be related to the same or different customer assets as long as they all belong to the same service account.

> [!Note]
> When noting a customer asset on a work order incident, the customer asset will also be noted on all work order products, services, and service tasks that result from that work order incident.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-product-asset-relation.png)

Any time a customer asset appears on a work order incident, the work order will appear in the **Related Work Orders** section of the customer asset. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-related-work-orders.png)

This allows managers to easily see a list of all work orders the customer asset is or was the subject of and helps with reporting because you can concretely relate asset details (name, category, product) with work order details (service account, work order type, incident type).

### With agreements

Similar to using work order incidents, you can also use Agreement Incident types to 

1. note which customer asset recurring maintenance is intended for 
2. ensure recurring maintenance is added to the customer asset service history

[Set up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md)  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-agreement-incident.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customer-asset-agreement-setup.png)

> [!NOTE]
> To associate customer assets with work order records, you must specify the customer asset within the work order incident or agreement incident records.  

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
- does product need to have field service product type to convert to asset? inventory and non inventory?
- [Adding 3D models to customer assets](../field-service/3D-viewer.md)

## Additional notes
- can relate to booking alerts

  
### See also    
[Create work order templates with incident types](../field-service/configure-incident-types.md) 

[Set up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md)

[Adding 3D models to customer assets](../field-service/3D-viewer.md)    
 
