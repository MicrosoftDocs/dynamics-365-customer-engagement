---
title: "Configure incident types (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/14/2019
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: krbjoran
ms.assetid: debef702-a12a-491c-8087-e7e4bdb14b19
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
# Create work order templates with incident types

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Incident types act as service templates and allow users to quickly create work orders for the most common types of jobs that your company performs, including all of the necessary service tasks, products, services, required skills, and estimated work order duration.  
  
1. From the main menu, click **Field Service** > **Administration**, and then choose **Incident Type**.  
  
2. On the **Incident Type** screen, click **New** in the upper left corner.  
  
3. Name the incident type using the **Name** field.  
  
4. Use the **Description** field to add additional text describing the incident.  
  
5. Fill in the **Estimated Duration** for the length of the job.  
  
   > [!NOTE]
   >  Estimate Duration is set based on the total duration of all the service tasks on the incidents. The only way to set the duration manually on the incident is if the service tasks has no duration.  
  
6. Click **Save**.  
  
7. In the **Service Tasks** section, click **Add Incident Type Service Task record** to add a service task.  
  
8. In the **Product** section, click **Add Incident Type Product record** to add a product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product or service](../field-service/create-product-or-service.md)  
  
9. In the **Service** section, click **Add Incident Type Service record** to add a service. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product or service](../field-service/create-product-or-service.md)  
  
10. In the **Notes** section, add any additional notes.  
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up territories](../field-service/set-up-territories.md)   
 [Create a work order](../field-service/create-work-order.md)   
 [Create work order types](../field-service/create-work-order-types.md)   
 [Set up work order sub-statuses](../field-service/set-up-work-order-sub-statuses.md)   
 [Set priorities](../field-service/set-priorities.md)   
 [Set up time groups](../field-service/set-up-time-groups.md)   
 [Set up service task types](../field-service/set-up-service-task-types.md)

## Introduction

Incident types are used to define the specific work order issue and the recommended prescription to resolve the issue. Whereas Work Order Types define the general category of a work order (inspection, repair, maintenance, etc), incident types define the specific request of a work order and effectively add more details to the work order type. 

As an example, an incident type can be:
- a specific error code on a machine; "Error code 0048"
- a common customer complaint or request; "The building temperature is too hot"
- a specific procedure; "Perform stress test"

Most importantly, adding an incident type to a work order can add other details such as duration and add related records including work order service tasks, work order products, and work order services. This means incident types can **effectively serve as work order templates** that pre-populate information, which can be manually edited as needed.

The value organizations get from using incident types is they codify issues, procedures, and resolutions and help standardize processes across geographies and business lines. This ensures all field technicians are performing the same actions to resolve work orders, and if better procedures are discovered, the incident type is updated and implemented across the entire organization. Another benefit is using incident types saves time creating work orders. Without using incident types, the customer service reps or dispatchers creating work orders would have to manually add the details. Consider the Connected Field Service scenario where IoT alerts create work orders. If you correlate IoT alerts with incident types, your organization can have a situation where IoT alerts create work orders with much of the details filled in.

Other important features are (1) multiple incident types can be added to a work order to define multiple issues or procedures that need to be completed (2) each incident type can be related to a customer asset to build service history (3) relating incident types 


 ## Prerequisites

 ## Create an incident type

 ## add an incident type to a work order

 ## add multiple incident types to a work order

 ## Use customer assets with incident types

 ## Incidents for multi-resource scheduling




