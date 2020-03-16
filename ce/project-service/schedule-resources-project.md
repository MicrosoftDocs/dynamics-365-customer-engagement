---
title: Schedule resources for a project 
description: How to schedule resources for a project in Project Service
author: JohnPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Schedule resources for a project (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

You can check resource availability to get an overall view of how booked your resources are, or you can filter the view by skills, team, location, and other options.  
  
The schedule board shows list of resources and their availability. Select a view mode to show availability by **Hours**, **Day**, **Week**, or **Month**.  
  
Before you use the schedule board, it’s important to set it up. For more information, see [Configure the schedule board (Field Service or Project Service Automation)](../field-service/configure-schedule-board.md).
  
If you are using an older version, for resource availability, see [View resource availability](../project-service/view-resource-availability.md).  

> [!IMPORTANT]
>  To use the schedule board booking functionality, geocoding, and location services, you need to turn on maps.  
> 
> 1. On the main menu, select **Resource Scheduling** > **Administration**.  
> 2. Click **Scheduling parameters**.  
> 3. Open record and scroll down to the **Resource Scheduling Optimization** section.  
> 4. On the **Connect to Maps** field, choose **Yes**.  
> 5. Accept terms and save the record.  
> 6. On the main menu, select **Project Service** > **Schedule board**. From here, there are several ways to manually schedule a booking requirement. Choose the method that works for you.
  
## Find available resources

1.  From the **Booking Requirement** list, right-click an unscheduled booking and choose one of the following:  
  
- Choose **Find availability - Current Resources** to find an available resource from the list on the schedule board.  
- Choose **Find availability - All Resources**, to find an available resource from resources in the system  
   > [!NOTE]
   >  When you do this, the filters will show options for the selected booking requirement.  
  
2. When you see an available slot, right-click the time slot on the schedule board and choose **Book Here**. Or, drag and drop the booking requirement to the available time slot.  
  

## Book a resource using the daily view and find who’s under-booked
  
1.  On the schedule board, select **View Mode** and select **Days**.  
  
    This shows a grid view of how many hours a resource is booked per day and which days they are free.  
  
2.  Click the name of the resource you want to book, and then select **Book**.  
  
3.  On the **Resource booking (create)** dialog box, choose the project that you want to book the resource for along with booking method and start and end times.  
  
4.  When you’re done, select **Book**.  
  
## View to the schedule board
  
1.  Select an unscheduled booking requirement from the list at the bottom.  
  
2.  Drag the booking requirement to an available resource/time slot on the schedule board.  
  
3.  When you're done, select **Book**.  
  
### Additional resources  
 [Resource manager guide](../project-service/resource-manager-guide.md)
