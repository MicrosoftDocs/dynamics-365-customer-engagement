---
title: Restrict a resource from performing a service (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to restrict a resource from performing a service in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shellyha
ms.date: 09/15/2017
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
ms.assetid: 069d1768-3521-4407-8b1f-582706ecfcf6
---

# Restrict a resource from performing a service (Customer Service)

You can restrict a resource from performing a service and define the service capacity for the resource. You can also restrict when a resource is available to be scheduled for a specific service. The resource is still available for scheduling service activities for other services.

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - Don’t have the correct permissions? Contact your system administrator.  
  
2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
3. Click **Users**.  
  
4. In the list, open the resource record you want to modify. The resource name appears in the nav bar. Click the arrow beside the resource name and select **Work hours**.
      
5. On the **Monthly View** tab, double-click a date on the calendar that is either the first day you want to restrict the resource from performing the service or a date in a recurring schedule.  
  
6. In the **Edit Weekly Schedule** dialog box, select one of the following options, and then click **OK**.  
  
    - **This date only**  
  
         This option changes only the date selected.  
  
         If you select this option, skip to step 8.  
  
    - **From \<this date> onward**  
  
         This option only changes the schedule going forward.  
  
    - **Entire recurring weekly schedule from start to end**  
  
         This option changes the entire schedule from the start to end date.  
  
         Selecting this option might change past days, which may affect reports regarding hours worked in the past.  
  
7. In the **Weekly Schedule** dialog box, click the work hours link for the schedule you want to modify.  
  
8. In the **Work Day** dialog box, click the **Service Restrictions** tab.  
  
9. On the Actions toolbar, click **New**.  
  
10. In the **Service Restrictions** dialog box, find and select a **Service**. Click the **Lookup** button ![Lookup button](../customer-service/media/crm-ua-lookup-v4.gif "Lookup button") to search for a record.  
  
11. In the **Start time** and **End time** lists, set the time when the facility or equipment is not available, and then click **OK**.  
  
12. Click **OK**, to close the **Work Day** dialog box.  
  
13. Click **Save** or **Save and Close**.  
  
> [!NOTE]
> - You can set up service restrictions in your own work schedule.  
> - All of the options may not be available to you for selecting how much of the schedule you want to edit. The available options are based on the schedules that are already set up.  
  
### See also  
 [Set work hours for a resource](../field-service/set-work-hours-resource.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]