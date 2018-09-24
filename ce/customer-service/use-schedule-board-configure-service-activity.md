---
title: Use the schedule board to configure service activity (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to schedule a service activity using the schedule board in Dynamics 365 for Customer Service
keywords: schedule a service activity; Dynamics 365; Customer Service Hub; Schedule board
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: fb655829-90d7-4aa3-b1af-7d6fc76f4700
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Use the schedule board to configure service activity

Schedule Board in Service Scheduling lets you view resource availability before you can book them for service activities. Set up views and filters as per your preference and book service activities for each of your resources.

In the schedule board, you can do the following tasks and activities:  
  
- View your organization's daily, weekly, and monthly schedule of appointments and service activities.  
  
- View work schedules and service activity schedules for a variety of resources.  
  
- Create new appointments and schedule service activities.  
  
- Change the status of an existing service activity.  
  
- Search for conflicts in the schedule.  
  
> [!NOTE]
> You can’t customize the schedule board or change the default view with the application. However, you can ask your system administrator to change the colors of the time blocks.  
 
## Access Schedule Board

In the Customer Service Hub sitemap, navigate to **Service Scheduling** > **Tools** and select **Schedule Board**.

## Navigate the Schedule Board

In the **Schedule Board**:

![schedule-board](media/schedule-board.png)

   |Label |Description |
   |---------|---------|
   |1     |   A list of resources is displayed on the left side of the calendar in alphabetical order. To view the resources, appointments, and service activities for anyone in your organization, in the **Type** list, select **Resource**, and then in the **View** list select the resource view.  </br> </br>  To find a specific resource, in the **Search** box, enter the first few letters of a name.      |
   |2    |   The **Calendar** appears on the top, in the **Configuration** tab . To change the date, select a date in the calendar. Use the arrows on either side of the month to change the month displayed.  </br> </br> **Configuration** tabs let you choose the time unit to be displayed, the view orientation, the time offset, and other actions like getting driving directions, moving bookings to the next day, printing the schedule, or add a booking alert.    | 
   |3     | To sort the view on the basis of  **Hours**, **Days**, **Weeks**, and **Months**, choose an option here.   |
   |4     | Create additional schedule board tabs in the **Initial public view**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create additional tabs](#create-additional-tabs) </br></br> To edit an existing schedule board view, double-click the view name.     |
   |5    |   **Scheduler settings** help you synchronize dates and content with a location. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Scheduler settings](#scheduler-settings) |
   |6    |   View additional details of the booking in the **Details** tab.|
   |7   |   Select requirements and create a resource booking in the **Create Resource Booking** tab. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create Resource Booking](#create-resource-booking) |
   |8 | To change how much of the calendar is available to view, use the **Zoom** scale. Select specific date ranges to view in the **From** and **To** lists.  |
   |9     |  Filter information by **Characteristics - Rating Roles**, **Territories**, **Organizational Units**, **Resource Types**, **Teams**, and **Business Units** to narrow or expand the schedule board view, suing the **Filter** tab. </br> </br> Map view shows the location of resources, organizational units, bookings, and requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the filter and map view](#configure-the-filter-and-map-view)  |
   | 10    |   To view the details of any resource, appointment, or service activity, select the record in the list to the left of the calendar, and then at the bottom of the calendar, under the **Zoom** scale, select the **Expand** button to expand the preview pane. You can also double-click a record to open it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Configure Booking Requirements](#configure-booking-requirements)    |
   |  |     |
 
### Create additional tabs  

You can create and add additional tabs in the schedule board using the  **Initial public view**.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create additional tabs](../field-service/configure-schedule-board.md#create-additional-tabs)

### Scheduler settings 

**Scheduler settings** in the Configuration tab helps you configure your time offset so you can synchronize dates and content with a location.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Scheduler settings](../field-service/configure-schedule-board.md#scheduler-settings)  

### Create resource booking

You can select requirements and create a booking for the selected resource using the **Create Resource Booking** tab. 

In the tab:

- Select a resource in the **Resource** drop-down.
- Select the start and end date using the calendars in **Start Date** and **End Date**.
- Choose **Booking Status** and **Booking Method**.
- Select **Book** to create a resource booking.

### Configure the filter and map view

You can set filters to see selected information in the **Filter and Map view**. Maps shows you the location of resources.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the filter and map view](../field-service/configure-schedule-board.md#configure-the-filter-and-map-view)

### Configure booking requirements

See the details of all unscheduled bookings and create a schedule for them using the **Configure Booking Requirements** tab.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Booking Requirements](../field-service/configure-schedule-board.md#configure-booking-requirements)


### See also

[Schedule a service activity](schedule-service-activity-csh.md)
