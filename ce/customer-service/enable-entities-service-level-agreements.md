---
title: Enable entities for service level agreements (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to enable entities for service level agreements in Dynamics 365 for Customer Service
keywords: Enable entities for service level agreements; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 8e93491c-4321-4816-ad4c-4e095015b10e
ms.custom: dyn365-customerservice
---

# Enable entities for service level agreements

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Service level agreements are not just important in the customer service space, but also for sales and marketing to ensure efficient handling of leads from start to finish.  
  
Previously, you could only create SLAs for case records. With Dynamics CRM Onlin 2016 Update 1, you can now enable any of these entities for SLA:  
  
-   Account  
  
-   Contact  
  
-   Order  
  
-   Invoice  
  
-   Quote  
  
-   Opportunity  
  
-   Lead  
  
-   All activity entities like email, phone, and appointment, except recurring appointment and its instances.  
  
 SLAs can also be enabled for custom entities and custom activities.  
  
> [!IMPORTANT]
>  Only enhanced SLAs can be created for other entities. A standard SLA can be created only for the Case entity.  
  
#### To enable  an entity for SLA  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Click **Customize the System**.  
  
4.  In the solution explorer, in the left nav pane, click the entity that you want to enable for SLA.  
  
5.  Under **Communication & Collaboration**, select the **Enable for SLA** check box.  
  
6.  Click **Save**.  
  
7.  Click **Publish**.  
  
> [!NOTE]
> - The maximum number of entities that can have active SLAs for your organization is 7.  
> - The maximum number of SLA KPIs allowed per entity for your organization is 5.  
  
### See also  
 [Define service level agreements](../customer-service/define-service-level-agreements.md)
