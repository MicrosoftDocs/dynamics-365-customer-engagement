---
title: Set up a holiday schedule (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Understand how to setup holiday schedule in Dynamics 365 for Customer Service
keywords: Set up holiday schedule; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 09/15/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 7bb3b4c0-8ffb-42c3-aecc-c730bdad2e5e
ms.custom: dyn365-customerservice
---

# Set up a holiday schedule (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Avoid having your service level agreements (SLAs) affected when your service organization is closed by creating a holiday schedule and adding it to your service calendar.  
  
 For example, if your service organization has an SLA to reply to email cases within two business days, you can create a holiday schedule and add it to your service calendar. Then, if a customer submits an email case on that holiday, your SLA is clear and is not affected by the holiday closure.  
  
> [!IMPORTANT]
> This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)]. 
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3.  Click **Holiday Schedule**.  
  
4.  Click **+** **New** and in the **Create Holiday Schedule** dialog box, enter a name and description for the holiday, and then click **Create**.  
  
5.  In the list of holidays, click the holiday you created.  
  
6.  When the holiday is open, click **New** to add the holiday to your customer service calendar.  
  
7.  In the **Add a Holiday** dialog box, specify the name and select the time of the holiday, and then click **OK**.  
  
 The holiday is created and associated with your customer service calendar. After the customer service schedule is associated to an SLA,  then your SLA during business hours is not affected. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define service level agreements](../customer-service/define-service-level-agreements.md)  
  
### See also  
 [Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)   
 [Get started with service management](../customer-service/service-manager-guide.md)
