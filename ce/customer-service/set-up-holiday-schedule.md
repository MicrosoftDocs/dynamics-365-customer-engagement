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
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 7bb3b4c0-8ffb-42c3-aecc-c730bdad2e5e
ms.custom: dyn365-customerservice
---

# Create and manage holiday schedules

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Avoid having your service level agreements (SLAs) affected when your service organization is closed by creating a holiday schedule and adding it to your service calendar.  
  
For example, if your service organization has an SLA to reply to email cases within two business days, you can create a holiday schedule and add it to your service calendar. Then, if a customer submits an email case on that holiday, your SLA is clear and is not affected by the holiday closure.  

## Create Holiday Schedule  
Follow the procedure given below to create a new holiday schedule:
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)] <br>  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub sitemap, go to **Service Management** > **Holiday Schedule**. <br>

     - The **All Holiday Schedules** view is displayed. You can switch between multiple views using the drop-down. 
     - Select **Show Chart** in the command bar to see the chart view. <br>
  
  
3.  To create a new holiday schedule, select **New**. In the **Create Holiday Schedule** dialog box, enter **Name** and **Description** for the holiday schedule, and then select **Create**.  
  
4.  In the list of holiday schedules, select the holiday schedule you created.  
  
5.  When the holiday schedule is open, click **New** in the **Holidays** section to add a holiday to your customer service calendar.  
  
6.  In the **Add a Holiday** dialog box, complete the following information and then select **OK**.  
    - Holiday Name
    - Start Date 
    - End Date 
    - Duration 
   

 The holiday is created and associated with your customer service calendar. After the customer service schedule is associated to an SLA,  then your SLA during business hours is not affected. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define service level agreements](../customer-service/define-service-level-agreements.md)  
  
## Additional actions

- To edit an existing holiday schedule, go to **Service Management** > **Holiday Schedule**. The **All Holiday Schedules** view is displayed. Select the holiday schedule you want to edit from the list of holiday schedules and select **Edit** in the command bar.
    - You can edit the **Name** or **Description**, or add new holidays for the holiday schedule. 
    - By default, all the holidays of the current year are displayed. To switch to a different year, click and type the year as shown below:
    
- To print a holiday schedule, select **Print Preview** in the **Holidays** section of the particular holiday schedule. You can also export or import a holiday schedule in Excel format.




### See also  
 [Create a customer service schedule and define the work hours](../customer-service/create-customer-service-schedule-define-work-hours.md)   

