---
title: Create and manage holiday schedules
description: Create a holiday schedule in the Customer Service app and configure service-level agreements to ensure your SLAs are not affected.
ms.date: 06/21/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType:
  - admin
  - customizer
  - enduser
ms.custom:
  - dyn365-customerservice
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/22/2023
---

# Create and manage holiday schedules

Prevent your service-level agreements (SLAs) from being affected when your service organization is closed, by creating a holiday schedule and adding it to your service calendar.  
  
For example, if your service organization has an SLA to reply to email cases within two business days, you can create a holiday schedule and add it to your service calendar. Then, if a customer submits an email case on that holiday, your SLA is clear and the holiday closure doesn't affect it.  

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, holiday schedule in service terms is available in the Customer Service admin center. We recommend that you create and manage holiday schedules using the new experience.
 
## Create a holiday schedule

You can create a holiday schedule in the Customer Service admin center app.
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  

1. In the site map of Customer Service admin center, select **Calendar** in **Operations**. The **Calendar** page appears.

1. In the **Holiday calendar** section, select **Manage**. The **All Holiday Schedules** view is displayed. You can switch between various system views using the dropdown list.  
 
1. Select **New** and in the **Create Holiday Schedule** dialog box, enter a name and description for the holiday, and then select **Create**.  
  
1. When the holiday opens, select **New** in the **Holidays** grid to add the holiday to your customer service calendar.  
  
1. In the **Add Holiday** dialog box, specify the **Name**, **Start Date**, **End Date**, and **Duration** of the holiday, and then select **OK**.  
  
   The holiday is created and associated with your customer service calendar. After the customer service schedule is associated with an SLA, your SLA during business hours isn't affected. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Define service level agreements](define-service-level-agreements.md)  

   ![Holiday schedule in Customer Service Hub.](../media/holiday-schedule-csh.png "Holiday schedule in Customer Service Hub")
 
To resolve any issues with the SLA during holidays, see [SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday](../troubleshoot-sla-issues.md).


### Create a holiday schedule  (Customer Service app)

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)] [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_service_management](../../includes/proc-settings-service-management.md)]  
  
3. Select **Holiday Schedule**.  
  
4. Select **New** and in the **Create Holiday Schedule** dialog box, enter a name and description for the holiday, and then select **Create**.  
  
5. In the list of holidays, select the holiday you created.  
  
6. When the holiday is open, select **New** to add the holiday to your customer service calendar.  
  
7. In the **Add a Holiday** dialog box, specify the name and select the time of the holiday, and then select **OK**.  
  
   The holiday is created and associated with your customer service calendar. After the customer service schedule is associated to an SLA,  then your SLA during business hours isn't affected. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure service-level agreements](define-service-level-agreements.md)  

## More actions

- To edit an existing holiday schedule, go to **Service Management** > **Holiday Schedule**. The **All Holiday Schedules** view is displayed. Select the holiday schedule you want to edit from the list of holiday schedules and select **Edit** in the command bar.
    - You can edit the **Name** or **Description**, or add new holidays for the holiday schedule. 
    - By default, all the holidays of the current year are displayed. To switch to a different year, select and type the year in the **Holidays** grid:
    
- To print a holiday schedule, select **Print Preview** in the **Holidays** section of the holiday schedule.
- To import or export a holiday schedule, use the Calendar import or export feature as you can't import or export a holiday schedule in the Excel format.

### Related information

 [Create a customer service schedule and define the work hours](create-customer-service-schedule-define-work-hours.md)  



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
