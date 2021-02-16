---
title: Set work hours to define availability (Dynamics 365 Customer Service) | MicrosoftDocs
description: Understand how to set work hours to define availability in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 11/20/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Set work hours to define availability (Customer Service app)

You can set up and define the hours a resource is available. By default, the resources are set up for a 7-days-a-week, 24-hour schedule. 

> [!IMPORTANT]
> In the new scheduling experience, you can set work hours for resource types in the **Resources** entity. To know more about setting up work hours, see [Set work hours for the resources](resources-service-scheduling.md#set-work-hours-for-the-resources).
  
## Set work hours for a facility or equipment
  
Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

1. Go to **Settings** > **Business Management**.

2. Select **Facilities/Equipment**. In the list, open the resource record you want modify.

3. Select **Work Hours**.
  
6.  On the **Monthly View** tab, double-click a date on the calendar that is the first day you want the new schedule to start, or any date that will be affected by the new schedule.  
  
7.  In the **Edit Schedule** dialog box, select one of the following, and then select **OK**.  
  
    - **This date only**  
  
         This option changes only the date selected.  
  
         Skip to step 10.  
  
    - **From \<this date> onward**  
  
         This option changes only the schedule going forward.  
  
    - **Entire recurring weekly schedule from start to end**  
  
         This option changes this entire schedule from the start to end date.  
  
         Selecting this option might change past days, which could affect reports regarding hours worked in the past.  
  
8.  In the **Weekly Schedule** dialog box, in the **Set the recurring weekly schedule** section, select one of the following:  
  
    - **Are the same each day**  
  
         The new schedule is the same for every day of the week. After you select this option, select the days of the week that the resource is available.  
  
    - **Vary by day**  
  
         The new schedule is different for one or more days of the week. After you select this option, select the days of the week that the resource is available.  
  
    - **None. Resource is not working**  
  
         The new schedule includes time that the resource is not working.  
  
     In the **Weekly Schedule** dialog box, you can also do any of the following:  
  
    -   If the schedule is for more than one day, select the days of the week that this schedule is effective.  
  
    -   If the resource does not work during business closures, select the **Observe** option.  
  
    -   Under **Date Range**, in the **Starting on** box, you can change the date the schedule starts.  
  
         You cannot change the date the schedule ends. To end a schedule, you must define a new schedule on that date.  
  
9. Choose the work hours link for the schedule you want to modify.  
  
     If work hours have not been set previously, the link is displayed as "Set Work Hours."  
  
10. In the **Set Work Hours and Service Restrictions** dialog box, complete the following fields, and then select **OK**:  
  
    - **Date**  
  
         Select a date from which the work hours for services are to be considered.  
  
    - **Start**  
  
         Select the time the work day starts.  
  
    - **End**  
  
         Select the time the work day ends.  
  
         To add a break in the work hours, such as a lunch break, select **Add Break**, and then select the start and end time of the break.  
  
11. To define a time when a service will not be available, on the **Service Restrictions** tab, select **New**. In the **Edit a Service Restriction** dialog box, select the service, and select the start and end time between which the service will be unavailable, and then select **OK**.  
  
12. Select **Save and Close** to close the **Weekly Schedule** dialog box.  
  
> [!NOTE]
> - You can set the work hours for a single day by double-clicking the day, and then in the **Edit Schedule** dialog box, select **This date only**, then select **OK**. Then, perform step 10 in the procedure.  
> - All of the options may not be available to you for selecting how much of the schedule you want to edit. The available options are based on the schedules that are already set up.  
  
### See also  
 
[Set when your business is closed (Customer Service app)](set-when-business-closed-cs-app.md)
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]