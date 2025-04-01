---
title: Set business closures
description: Learn how to set business closures in Dynamics 365 Customer Service
ms.date: 12/05/2023
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---

# Set when your business is closed

Prevent the scheduling of resources on holidays and other nonwork days by defining business closures in Customer Service. You can set both the days and times that your organization is closed. 

## Schedule a new business closure

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage security roles in service scheduling](../administer/manage-security-roles.md)

You can schedule a business closure in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Service Scheduling** in **Operations**. The **Service Scheduling** page appears.
    1. In the **Business closure** section, select **Manage**.

   ### [Customer Service Hub](#tab/customerservicehub)

    1. In the site map, go to **Scheduling**.
    1. From the list of entity records, select **Business Closures** in **Settings**.
      
   The **Business Closures** view is displayed. If you have any closures already scheduled, they're listed. You can sort the views using the dropdown menus beside **Name**, **Start Time**, **End Time**, and **Duration**.

1. On the command bar, select **New** to schedule a new business closure. </br>
 
   You can also select **New** from the business closure grid to create a new business closure record.

   A quick create dialog box is displayed.
  
1.  In the **Schedule a Business Closure** dialog box, type or modify information in the text boxes:  
  
    - In the **Name** box, type a name that describes the purpose of the closure.
  
         The first 12 characters of the name appear on each day of the closure on the calendar view of the affected resource's **Work Hours**.  
  
    -  If the closure is an all-day event, leave **All Day Event** set to **Yes**. The application automatically enters the duration of *one day*.
    -  If the closure isn't an all-day event, select **No** for **All Day Event**. In **Start Time** and **End Time**, select the start and end dates and times for the closure.
    - If you want to enter duration instead of an end time, select the **Start Time**, and then select the length of the closure in **Duration**. The application automatically calculates the end time for you. 
  
1.  To save this business closure, select **OK**.  
  
### Related information  
 [Set work hours for the resources](../administer/resources-service-scheduling.md#set-work-hours-for-the-resources) </br>
 [Set up a holiday schedule](../administer/set-up-holiday-schedule.md)   </br>
 [Create a customer service schedule and define the work hours](../administer/create-customer-service-schedule-define-work-hours.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
