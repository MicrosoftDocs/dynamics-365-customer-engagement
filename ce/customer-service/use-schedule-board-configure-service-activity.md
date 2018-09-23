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
  
2. A list of resources is displayed on the left side of the calendar in alphabetical order. To view the resources, appointments, and service activities for anyone in your organization, in the **Type** list, select **Resource**, and then in the **View** list select the resource view.  
  
3. To find a specific resource, in the **Search** box, enter the first few letters of a name.  
  
4. To view the details of any resource, appointment, or service activity, select the record in the list to the left of the calendar, and then at the bottom of the calendar, under the **Zoom** scale, click the **Expand** button ![arrow&#95;up&#95;blue](../customer-service/media/crm-ua-arrow-up-blue.gif "arrow_up_blue") to expand the preview pane. You can also double-click a record to open it.  
  
5. The Calendar pane appears on the right side of the calendar. It can be collapsed or expanded. To change the date, click a date in the calendar. Use the arrows on either side of the month to change the month displayed.  
  
6. To change the number of days that are displayed in the linear calendar, click any of the calendar options in the Calendar pane.  
  
7. To change how much of the calendar is available to view, use the **Zoom** scale. Select specific date ranges to view in the **From** and **To** lists.  
  
### Legend of colors and statuses  
 Appointments and service activities appear in the linear calendar as labeled color blocks. Move your mouse over these blocks to see the status of the appointment or service activity. 
 

## Find the next available time before creating a service activity


3. Click **Schedule**.  
  
4. On the **Schedule Service Activity** form, type or change information in the text boxes.  
  
    Hovertips provide hints about what to enter.  
  
   -   Under **Requested Time**, select criteria for the times you want:  
  
       -   To search for a time on a specific date, in **Start Date**, select **Specific Date**, and then enter the date you want.  
  
       -   To search within a range of dates, select **Range of Dates**, and then enter the **On or After** and **On or Before** dates. You can also select specific days of the week.  
  
       -   You can also search for times based on dates relative to the current date, such as **Today**, **Tomorrow**, **This Week**, **Next Week**, or **Next Month**.  
  
       -   Similarly, to search within specific range of time, in **Start Time**, select **Specific Time**, **Range of Times**, or **Morning**, **Evening**, **Afternoon**.  
  
       -   Do not clear the Use Default Duration check box and change the duration unless you want to schedule more time than the default duration of the service. The maximum duration of a service activity is 10 days.  
  
5. Click **Find Available Times**. The next available times are shown.  
  
6. Under **Available Times**, select the time for which you want to schedule the service activity, and then click **Schedule**.  
  
    The Schedule Service Activity form closes, and [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] fills in the information from the selected time in the Service Activity form.  
  
7. Type or modify information in other text boxes, as required.  
  
    Hovertips provide hints about what to enter.  
  
8. When you’re ready to save your data, click **Save**.  
  
    The service activity appears as a color block on the Service calendar.  
  
> [!TIP]
>  If you want to find an available time without any time restriction, do not specify any criteria under **Requested Time**, and click **Find Available Times**.  


## Force an activity into a time slot in the service schedule

You can create a service activity by finding the next available times of resources for a service or simply without checking for conflicts. If needed, you can force a service activity into a time slot to squeeze another service activity into the leftover time from a previous service activity. If you save a service activity without finding available times in the schedule, then [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] displays the service activity in the schedule without checking for conflicts.  
  
 One reason to force a service activity into a time slot is to squeeze another service activity into the leftover time from a previous service activity.  
  
1. Make sure you have the Scheduler security role or equivalent permissions in Microsoft Dynamics 365.  
  
2. [!INCLUDE[proc_service_service_calendar](../includes/proc-service-service-calendar.md)]  
  
3. On the command bar, click **Service Activity**.  
  
4. On the Service Activity form, type or change information in the text boxes.  
  
    Hovertips provide hints on what to enter.  
  
5. When you’re ready to save your data, click **Save**.  
  
> [!TIP]
>  You can record a customer's preferences for a specific time, day, service, facility, equipment, and customer service representative in the customer record on the **Administration** tab. As you are scheduling a service activity, the customer's preference is displayed in the **Form Assistant** pane.  
  
> [!NOTE]
> - If at any time before you save this service activity you want to search the schedule for an available time, you can click **Schedule** in the **Actions** group to open the **Schedule Service Activity** dialog box.  
> - To check the schedule for conflicts, in **Service Calendar**, in the **Actions** group, click **Conflicts**.  
