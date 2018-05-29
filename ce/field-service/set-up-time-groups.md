---
title: "Set up time groups (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 9bfa089a-57a1-4790-bb13-0239f055803f
caps.latest.revision: 14
ms.author: krbjoran
manager: shellyha
---
# Set up time groups for scheduling (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Specify time groups consisting of multiple time windows to be used for scheduling in Dynamics 365 for Field Service.  
  
 The schedule assistant will add the time group start and end times to the search results. This lets a user group the results by time group.  
  
 Time groups are saved based on the time zone of the user who creates the time group record. If your organization has users in different time zones (for example PST and EST) and you create time groups such as:  
  
-   9 AM to 12 PM  
  
-   12 PM to 5 PM  
  
Then make sure to create these time groups for each time zone since time groups are time zone sensitive.  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Time Groups**.  
  
2.  On the **Active Time Groups** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then click **Save**.  
  
    -   Specify the top time group results that will display in the schedule assistant. For example, if you have 5 set then the top 5 results will show for the specified time block. Top is determined by least amount of travel time. If set to 0 (zero), then all results will be displayed.  
  
    -   Set **Hide Booking Time on Schedule Assistant** to **Yes** or **No**. If set to No, then these fields will be hidden from the schedule assistant results: start time, estimated time of arrival, and end time.  
  
4.  In the **Details** section, click **+Add Time Group Detail record**.  
  
    -   Name the group and set a start and end time.  
  
    -   Click **Save & Close**.  
  
### See also  
  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Create a work order](../field-service/create-work-order.md)   
 [Create work order types](../field-service/create-work-order-types.md)   
 [Set up work order sub-statuses](../field-service/set-up-work-order-sub-statuses.md)   
 [Set up service task types](../field-service/set-up-service-task-types.md)   
 [Configure incident types](../field-service/configure-incident-types.md)   
 [Set priorities](../field-service/set-priorities.md)<br>
 [User's Guide](../field-service/user-guide.md)  
