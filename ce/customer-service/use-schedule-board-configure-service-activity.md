---
title: Use the schedule board to configure service activity (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to schedule a service activity using the schedule board in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 11/20/2018
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
  - D365CS
---

# Use the schedule board to configure service activity

Schedule board in service scheduling lets you view resource availability before you book them for service activities. Set up views and filters as per your preference and book service activities for each of your resources.

In the schedule board, you can do the following tasks and activities:  
  
- View your organization's daily, weekly, and monthly schedule of service activities.  
  
- View work schedules and service activity schedules for a variety of resources.  
  
- Schedule service activities.  
  
- Change the status of an existing service activity.  
  
- Search for conflicts in the schedule.  
  
> [!NOTE]
> You can’t customize the schedule board or change the default view with the application. However, you can ask your system administrator to change the colors of the time blocks.  
 
## Navigate the schedule board
In the Customer Service Hub sitemap, navigate to **Scheduling** > **Tools** and select **Schedule Board**.

Here’s what you’ll see when you open the schedule board:

![schedule-board](media/schedule-board.png)


|Label  |Field  |Description  |
|---------|---------|---------|
|1    |    View list of resources     |  A list of resources is displayed on the left side of the calendar in alphabetical order. To view the resources, and service activities for anyone in your organization, in the **Type** list, select **Resource**, and then in the **View** list select the resource view.  </br> </br>  To find a specific resource, enter the first few letters of the name in the **Search** box.       |
|2    |   Initial public view      |    Add more schedule board tabs in the Initial public view section. </br></br> To edit an existing schedule board view or to modify tab settings, double-click the view name or select the settings icon.       |
|3    |  Scheduler settings       |   **Scheduler settings** help you synchronize dates and content with a location.    |
|4  |     Details    |     View additional details of the booking in the **Details** tab.    |
|5     | Create Resource Booking     |   Select requirements and create a resource booking in the **Create Resource Booking** tab.     |
|6     |     Filter & Map view    |   Filter information by **Characteristics - Rating, Roles**, **Territories**, **Organizational Units**, **Resource Types**, **Teams**, and **Business Units** to narrow or expand the schedule board view, using the **Filter** tab. </br> </br> Map view shows the location of resources, organizational units, bookings, and requirements.       |
|7     |   Service Activities view      |    To view the details of any resource, or service activity, select the record in the list to the left of the calendar, and then at the bottom of the calendar, under the **Zoom** scale, select the **Expand** button to expand the preview pane. You can also double-click a record to open it.  |
| |         |         |

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the schedule board for resource availability](../field-service/configure-schedule-board.md)

## Schedule a booking for a service activity

You can select unscheduled service activities and schedule a booking using the **Create Resource Booking** tab:

1. In the **Booking Requirements** section, go to **Unscheduled Service Activities** tab and select the activity for which you want to schedule a booking.

   The **Find Availability** button is displayed. 

     ![find-availability](media/find-availability.png)
 
2. Select the **Find Availability** button to view the resources or resource groups that are available for booking.

   The **Schedule Assistant** filter lets you filter resources based on **Available Duration**, **Organizational Units**, and many other parameters.

   ![select-resources](media/select-resources.png)

3. Select a resource group from the **Teams** list.
4. In the **Create Resource Booking** tab: 

   - View the resources from the resource group that will be booked once the booking is created.
   - Select the start and end date and time using the calendars in **Start Date** and **End Date**.
   - Select **Booking Status** from the drop-down list.
   - Select **Book & Exit** to create a resource booking and exit the tab.
     ![booking-from schedule-board](media/sb-booking.png)

### See also

[Schedule a service activity](schedule-service-activity-csh.md)
