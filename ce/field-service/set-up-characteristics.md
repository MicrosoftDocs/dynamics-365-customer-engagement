---
title: "Set up characteristics (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to set up characteristics in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/10/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice 
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Specify skills for resources in Dynamics 365 Field Service

Characteristics are skills that resources possess. For example, they can be used to indicate a license or certification is needed for certain types of work.  
  
 Adding characteristics to work orders allows you to document which knowledge or expertise is needed by a resource to complete the job, and to filter the list of available resources to the resources that have the matching characteristics when scheduling the work order.   
  
<a name="BKMK_AddCharacteristics"></a>   
## Add characteristics  
  
1.  From the main menu, open **Resource Scheduling** and then choose **Settings**.  
  
2.  Under the **Resource** section, choose **Skills.**  
  
3.  Select **New** to add characteristics.
  
<a name="BKMK_AssignCharacteristicsToResources"></a>   
## Assign characteristics to resources  
  
1. From the main menu, go to **Field Service** > **Administration**, and then choose **Bookable Resources**. You'll then see the **Active Bookable Resources** screen, where there's a list of all available resources in the system.  
  
   **Note**: More information: [Set up bookable resources](../field-service/set-up-bookable-resources.md)  
  
2. From the list, select a bookable resource name.  
  
3. Go to the **Characteristics** section, and on the left, select **+Add Bookable Resource Characteristics record**.  
  
4. Find and select the required **Characteristics** and add a **Rating Value** for the resource.  
  
5. Select **Save & Close**.  
  
<a name="BKMK_AssignCharacteristicsToWorkOrders"></a>   
## Assign characteristics to work orders  
  
1.  Open a work order.  More information: [Create a work order](../field-service/create-work-order.md)  
  
2.  From the top bar, select the drop-down arrow next to the work order number, and then select **Characteristics**.  
  
3.  On the **Work Order Characteristics Associated View** screen, select **+Add new Work Order Characteristics to this record**.  
  
4.  Find and select the required **Characteristics** and add a **Rating Value**.  
  
5.  Select **Save & Close**.  
  
### See also    
 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Set up bookable resources](../field-service/set-up-bookable-resources.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up resource pay types](../field-service/set-up-resource-pay-types.md)
 [User's Guide](../field-service/user-guide.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]