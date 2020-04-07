---
title: "Set up characteristics (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/10/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: FieldServiceDave
ms.assetid: 6a95bd55-8d7a-434e-a681-e1d1c0dc7598
caps.latest.revision: 14
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Specify skills for resources (Field Service)

Characteristics are skills that resources possess. For example, they can be used to indicate a license or certification is needed for certain types of work.  
  
 Adding characteristics to work orders allows you to document which knowledge or expertise is needed by a resource to complete the job, and to filter the list of available resources to those that have the matching characteristics when scheduling the work order.   
  
<a name="BKMK_AddCharacteristics"></a>   
## Add characteristics  
  
1.  From the main menu, open **Resource Scheduling** and then choose **Settings**.  
  
2.  Under the **Resource** section, choose **Skills.**  
  
3.  Select **New** to add characteristics.
  
<a name="BKMK_AssignCharacteristicsToResources"></a>   
## Assign characteristics to resources  
  
1. From the main menu, click **Field Service** > **Administration**, and then choose **Bookable Resources**. This will take you to the **Active Bookable Resources** screen, where you will find a list of all available resources in the system.  
  
   **Note**: More information: [Set up bookable resources](../field-service/set-up-bookable-resources.md)  
  
2. From the list, click a bookable resource name.  
  
3. Go to the **Characteristics** section, and on the left, click **+Add Bookable Resource Characteristics record**.  
  
4. This will open a pop-up window where you can find and select the required **Characteristics** and add a **Rating Value** for the resource.  
  
5. Click **Save & Close**.  
  
<a name="BKMK_AssignCharacteristicsToWorkOrders"></a>   
## Assign characteristics to work orders  
  
1.  Open a work order.  More information: [Create a work order](../field-service/create-work-order.md)  
  
2.  From the top bar, click the drop-down arrow next to the work order number, and then click **Characteristics**.  
  
3.  On the **Work Order Characteristics Associated View** screen, click **+Add new Work Order Characteristics to this record**.  
  
4.  This will open a pop-up window where you can find and select the required **Characteristics** and add a **Rating Value**.  
  
5.  Click **Save & Close**.  
  
### See also    
 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Set up bookable resources](../field-service/set-up-bookable-resources.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up resource pay types](../field-service/set-up-resource-pay-types.md)
 [User's Guide](../field-service/user-guide.md)
