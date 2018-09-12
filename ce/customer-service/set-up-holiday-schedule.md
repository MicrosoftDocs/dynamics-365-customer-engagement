---
title: Set up a holiday schedule (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Understand how to set up a holiday schedule in Dynamics 365 for Customer Service
keywords: Set up holiday schedule; Dynamics 365; Customer Service; Create Holiday schedule
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 7bb3b4c0-8ffb-42c3-aecc-c730bdad2e5e
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage holiday schedule

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Avoid having your service level agreements (SLAs) affected when your service organization is closed by creating a holiday schedule and adding it to your service calendar.  
  
For example, if your service organization has an SLA to reply to email cases within two business days, you can create a holiday schedule and add it to your service calendar. Then, if a customer submits an email case on that holiday, your SLA is clear and is not affected by the holiday closure.  

> [!NOTE]
> With the October'18 release, holiday schedule in service management is available in the Customer Service Hub based on Unified Interface experience. You are recommended to create and manage holiday schedules using the new experience.

## Create holiday schedule  
Follow the procedure given below to create a new holiday schedule:
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub sitemap, go to **Service Management** and select **Service Terms** > **Holiday Schedule**.
  
4. Select **New** and in the **Create Holiday Schedule** dialog box, enter a name and description for the holiday, and then select **Create**.  
  
5. In the holidays grid, select the holiday you created.  
  
6. When the holiday is open, select **New** to add the holiday to your customer service calendar.  
  
7. In the **Add a Holiday** dialog box, specify the **Name**, **Start Date**, **End Date**, and **Duration** of the holiday, and then select **OK**.  
  
   The holiday is created and associated with your customer service calendar. After the customer service schedule is associated to an SLA,  then your SLA during business hours is not affected. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define service level agreements](../customer-service/define-service-level-agreements.md)  
 
To resolve any issues with SLA during holidays, see [SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday](troubleshoot-sla-timer-issue.md).

## Additional actions

- To edit an existing holiday schedule, go to **Service Management** > **Holiday Schedule**. The **All Holiday Schedules** view is displayed. Select the holiday schedule you want to edit from the list of holiday schedules and select **Edit** in the command bar.
    - You can edit the **Name** or **Description**, or add new holidays for the holiday schedule. 
    - By default, all the holidays of the current year are displayed. To switch to a different year, select and type the year as shown below:
    
- To print a holiday schedule, select **Print Preview** in the **Holidays** section of the holiday schedule. You can also export or import a holiday schedule in excel format. 


### See also  
 [Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)   

