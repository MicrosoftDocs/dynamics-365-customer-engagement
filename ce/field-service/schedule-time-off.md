---
title: Schedule time off (Dynamics 365 Customer Service) | MicrosoftDocs
description: Understand how to schedule time off in Dynamics 365 Customer Service
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
ms.assetid: 9488c217-f9f8-4774-8f96-ca0f98b86167
---

# Schedule time off (Customer Service)

You can schedule a period of time in the middle of a schedule when a resource is not available to be scheduled for a service activity. For a user, this could be a sick day or vacation. For a facility or equipment, this could be an equipment failure.

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
More information on scheduling a resource for business closure or holiday: *Set or change work hours for a user, facility, or equipment*.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
3. Choose **Facilities/Equipment**.  
  
4. In the list, open the resource you want to modify.  
  
5. Under **Common**, click **Work Hours**.  
  
6. On the **Monthly View** tab, select a date on the calendar.  
  
7. On the Actions toolbar, click **Set Up** > **Time Off**, and then in the **Schedule Time Off** dialog box, enter the following details:  
  
   - **Reason**. Type a short explanation for the resource’s absence.  
  
   - **All Day Event**. Select this check box if the resource is unavailable for the entire day (midnight to midnight) for all of the days.  
  
   - **Start Time** and **End Time**. If you have not selected the **All Day Event** check box, you can set specific start and end times. When the end date is reached, the previous schedule continues.  
  
   - **Duration**. If you don’t want to calculate the end date, select the number of days the resource is unavailable.  
  
   - **Time Zone**. If the resource is in a different time zone, select the time zone. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] automatically adjusts the times on the calendars.  
  
8. Click **OK**.  
  
    In the working hours calendar, affected days are marked with a red block. In the Service calendar the time appears as a white block and cannot be scheduled.  
  
    You can update your own working hours or time off, and add yourself to teams and resource groups. On the **Tools** menu, click **Options**. On the **General** tab, at the bottom of the page, click the **user information** link.  
  
### See also  
 [Set work hours for a resource](../field-service/set-work-hours-resource.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]