---
title: Restrict a resource from performing a service (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to restrict a resource from performing a service in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/01/2018
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

# Restrict a resource from performing a service

You can restrict a resource from performing a service and define the service capacity for the resource. You can also restrict when a resource is available to be scheduled for a specific service. The resource is still available for scheduling service activities for other services.
  
1. In the Customer Service Hub sitemap, go to **Service Scheduling**.

2. From the list of entity records, select **Scheduling > Resources**.  
  
4. In the list, open the resource record you want to modify and select **Show Work hours**.
      
5.  On the **Monthly View** tab, double-click a date on the calendar that is either the first day you want to restrict the resource from performing the service or a date in a recurring schedule.  
  
6. In the **Edit Weekly Schedule** dialog box, select one of the following options, and then select **OK**.  
  
    - **This date only**  
  
         This option changes only the date selected.  
  
         If you select this option, skip to step 8.  
  
    - **From \<this date> onward**  
  
         This option only changes the schedule going forward.  
  
    - **Entire recurring weekly schedule from start to end**  
  
         This option changes the entire schedule from the start to end date.  
  
         Selecting this option might change past days, which may affect reports regarding hours worked in the past.  
  
7. In the **Weekly Schedule** dialog box, select the work hours link for the schedule you want to modify.  
  
8. In the **Work Day** dialog box, select the **Service Restrictions** tab.  
  
9. On the Actions toolbar, select **New**.  
  
10. In the **Service Restrictions** dialog box, find and select a **Service**. Select the **Lookup** button to search for a record.  
  
11. In the **Start time** and **End time** lists, set the time when the facility or equipment is not available, and then select **OK**.  
  
12. Select **OK**, to close the **Work Day** dialog box.  
  
13. Select **Save** or **Save and Close**.  
  
> [!NOTE]
> - You can set up service restrictions in your own work schedule.  
> - All of the options may not be available to you for selecting how much of the schedule you want to edit. The available options are based on the schedules that are already set up.  
  
### See also  
[Set work hours for the resources](resources-service-scheduling.md#set-work-hours-for-the-resources)

[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]