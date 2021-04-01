---
title: Set work hours for a resource (Dynamics 365 Customer Service) | MicrosoftDocs
description: Understand how to set work hours for a resource in Dynamics 365 Customer Service
ms.date: 09/15/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 97634d1f-1e31-4f0e-a7f0-82b4940aeee9
author: lalexms
ms.author: laalexan
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
search.app: 
  - D365CE
  - D365FS
---

# Set work hours for a resource (Customer Service)

You can set the hours a user works or set the operating hours for a facility or equipment. By default, users, facilities, and equipment are set up for a 7-days-a-week, 24-hour schedule. 

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
 You can edit existing work hours by following steps 1 and 2 to go to the Users or Facilities/Equipment area. Then, open the resource you want to edit. Editing a schedule does not affect existing service activities created for the resource.  
  
<a name="bkmk_WorkHoursFacilities"></a>   
## Set work hours for a facility or equipment  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
3. Click **Facilities/Equipment**.  
  
4. In the list, open the resource record you want modify.  
  
5. Click **Work Hours**.  
  
6. On the **Monthly View** tab, double-click a date on the calendar that is the first day you want the new schedule to start, or any date that will be affected by the new schedule.  
  
7. In the **Edit Schedule** dialog box, select one of the following, and then click **OK**.  
  
   - **This date only**  
  
        This option changes only the date selected.  
  
        Skip to step 10.  
  
   - **From \<this date> onward**  
  
        This option changes only the schedule going forward.  
  
   - **Entire recurring weekly schedule from start to end**  
  
        This option changes this entire schedule from the start to end date.  
  
        Selecting this option might change past days, which may affect reports regarding hours worked in the past.  
  
8. In the **Weekly Schedule** dialog box, in the **Set the recurring weekly schedule** section, select one of the following:  
  
   - **Are the same each day**  
  
        The new schedule is the same for every day of the week. After you select this option, select the days of the week that the resource is available.  
  
   - **Vary by day**  
  
        The new schedule is different for one or more days of the week. After you select this option, select the days of the week that the resource is available.  
  
   - **None. Resource is not working**  
  
        The new schedule includes time that the resource is not working.  
  
     In the **Weekly Schedule** dialog box, you can also do any of the following:  
  
   - If the schedule is for more than one day, select the days of the week that this schedule is effective.  
  
   - If the resource does not work during business closures, select the **Observe** option.  
  
   - Under **Date Range**, in the **Starting on** box, you can change the date the schedule starts.  
  
      You cannot change the date the schedule ends. To end a schedule, you must define a new schedule on that date.  
  
9. Choose the work hours link for the schedule you want to modify.  
  
     If work hours have not been set previously, the link is displayed as "Set Work Hours."  
  
10. In the **Set Work Hours and Service Restrictions** dialog box, complete the following fields, and then click **OK**:  
  
    - **Date**  
  
         Select a date from which the work hours for services are to be considered.  
  
    - **Start**  
  
         Select the time the work day starts.  
  
    - **End**  
  
         Select the time the work day ends.  
  
         To add a break in the work hours, such as a lunch break, click **Add Break**, and then select the start and end time of the break.  
  
11. To define a time when a service will not be available, on the **Service Restrictions** tab, click **New**. In the **Edit a Service Restriction** dialog box, select the service, and select the start and end time between which the service will be unavailable, and then click **OK**.  
  
12. Click **Save and Close** to close the **Weekly Schedule** dialog box.  
  
> [!NOTE]
> - You can set the work hours for a single day by double-clicking the day, and then in the **Edit Schedule** dialog box, select **This date only**, then click **OK**. Then, perform step 10 in the procedure.  
> - All of the options may not be available to you for selecting how much of the schedule you want to edit. The available options are based on the schedules that are already set up.  
  
<a name="bkmk_WorkHoursUsers"></a>   
## Set work hours for a user  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
2. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
3. Click **Users**.  
  
4. Open the user record you want to set work hours for.  
  
5. On the top, select the arrow next to the name of the user.  
  
6. Click **Work Hours**.  
  
7. From the **Set up** drop-down list, choose the schedule display as required..  
  
   > [!NOTE]
   >  Monthly schedules are the default display; you can choose weekly and daily schedules.  
  
8. Double-click a date on the calendar that is the first day for which you want to set work hours.  
  
9. In the **Edit Schedule** dialog box, select one of the following and then click **OK**.  
  
    - **This date only**  
  
         This option changes only the selected day.  
  
         Skip to step 12.  
  
    - **From \<this date> onward**  
  
         This option changes only the schedule going forward.  
  
    - **Entire recurring weekly schedule from start to end**  
  
         This option changes this entire schedule from the start to end date.  
  
         Selecting this option might change past days, which may affect reports regarding hours worked in the past.  
  
10. In the **Weekly Schedule** dialog box, in the **Set the recurring weekly schedule** section, select one of the following:  
  
    - **Are the same each day**  
  
         The new schedule is the same for every day of the week. After you select this option, select the days of the week that the resource is available.  
  
    - **Vary by day**  
  
         The new schedule is different for one or more days of the week. After you select this option, select the days of the week that the resource is available.  
  
    - **None. User is not working**  
  
         The new schedule includes time that the resource is not working.  
  
      In the **Weekly Schedule** dialog box, you can also do any of the following:  
  
    - If the schedule is for more than one day, select the days of the week this schedule is effective.  
  
    - If the resource does not work during business closures, select the **Observe** option.  
  
    - Under **Date Range**, in the **Starting on** box, you can change the date the schedule starts.  
  
       You cannot change the date the schedule ends. To end a schedule, you must define a new schedule on that date.  
  
11. Choose the work hours link for the schedule you want to modify.  
  
     If work hours have not been set previously, the link is displayed as "Set Work Hours."  
  
12. In the **Set Work Hours and Service Restrictions** dialog box, complete the following fields, and then click **OK**:  
  
    - **Date**  
  
         Select a date from which the work hours for services are to be considered.  
  
    - **Start**  
  
         Select the time the work day starts.  
  
    - **End**  
  
         Select the time the work day ends.  
  
         To add a break in the work hours, such as a lunch break, click **Add Break**, and then select the start and end time of the break.  
  
13. To define a time when a service won’t be available, on the **Service Restrictions** tab, click **New**. In the **Edit a Service Restriction** dialog box, select the service, and select the start and end time between which the service will be unavailable, and then click **OK**.  
  
14. To close the **Weekly Schedule** dialog box, click **Save and Close**.  
  
### See also  
 [Set the capacity required for a service or resource](../field-service/set-capacity-required-service-resource.md)   
 [Set when your business is closed](../field-service/set-when-business-closed.md)   
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
