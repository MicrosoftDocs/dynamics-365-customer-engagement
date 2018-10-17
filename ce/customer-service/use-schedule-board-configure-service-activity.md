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

Schedule board in Service Scheduling lets you view resource availability before you book them for service activities. Set up views and filters as per your preference and book service activities for each of your resources.

In the schedule board, you can do the following tasks and activities:  
  
- View your organization's daily, weekly, and monthly schedule of appointments and service activities.  
  
- View work schedules and service activity schedules for a variety of resources.  
  
- Create new appointments and schedule service activities.  
  
- Change the status of an existing service activity.  
  
- Search for conflicts in the schedule.  
  
> [!NOTE]
> You can’t customize the schedule board or change the default view with the application. However, you can ask your system administrator to change the colors of the time blocks.  
 
## Access the schedule board

In the Customer Service Hub sitemap, navigate to **Service Scheduling** > **Tools** and select **Schedule Board**.

## Navigate the schedule board

Here’s what you’ll see when you open the schedule board:

![schedule-board](media/schedule-board.png)


|Label  |Field  |Description  |
|---------|---------|---------|
|1    |    View list of resources     |  A list of resources is displayed on the left side of the calendar in alphabetical order. To view the resources, appointments, and service activities for anyone in your organization, in the **Type** list, select **Resource**, and then in the **View** list select the resource view.  </br> </br>  To find a specific resource, in the **Search** box, enter the first few letters of a name.       |
|Row2     |         |         |
|Row3     |         |         |
|Row4     |         |         |
|Row5     |         |         |
|Row6     |         |         |
|Row7     |         |         |
|Row8     |         |         |
|Row9     |         |         |
|Row10     |         |         |


 
 
### Create additional tabs  

You can create and add additional tabs in the schedule board using the  **Initial public view**.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create additional tabs](../field-service/configure-schedule-board.md#create-additional-tabs)

### Scheduler settings 

**Scheduler settings** in the Configuration tab helps you configure your time offsite so you can synchronize dates and content with a location.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Scheduler settings](../field-service/configure-schedule-board.md#scheduler-settings)  

### Create resource booking

You can select requirements and create a booking for the selected resource using the **Create Resource Booking** tab. 

In the tab:

- Select a resource in the **Resource** drop-down list.
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
