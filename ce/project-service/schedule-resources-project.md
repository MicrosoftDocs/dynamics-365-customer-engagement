---
title: "Schedule resources for a project (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
ms.custom:
  - dyn365-projectservice
ms.date: 07/19/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "project-service-automation"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 224c13f6-04f4-4f16-83b2-80212c8c4795
caps.latest.revision: 12
ms.author: krbjoran
manager: shellyha
---
# Schedule resources for a project (Project Service Automation)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can check resource availability to get an overall view of how booked your resources are, or you can filter the view by skills, team, location, and other options.  
  
 The schedule board shows list of resources and their availability. Select a view mode to show availability by **Hours**, **Day**, **Week**, or **Month**.  
  
 Before you use the schedule board, it’s important to set it up. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the schedule board (Field Service or Project Service Automation)](../field-service/configure-schedule-board.md)  
  
>  If you are using an older version, for resource availability see, [View resource availability](../project-service/view-resource-availability.md).  
  
> [!IMPORTANT]
>  To use the schedule board booking functionality, geocoding, and location services, you need to turn on maps.  
>   
>  1.  From the main menu, click **Resource Scheduling** > **Administration**.  
> 2.  Click **Scheduling parameters**.  
> 3.  Open record and scroll down to the **Resource Scheduling Optimization** section.  
> 4.  On the **Connect to Maps** field, choose **Yes**.  
> 5.  Accept terms and save the record.  
  
<a name="BKMK_ScheduleWOManually"></a>   
1.  From the Main menu, click **Project Service** > **Schedule board**. From here, there are several ways to manually schedule a booking requirement. Choose the method that works for you.
  
## Right-click on an unscheduled booking to find available resources

        1.  From the **Booking Requirement** list, right-click on an unscheduled booking and choose one of the following:  
  
            1.  Choose **Find availability - Current Resources** to find an available resource from the list on the schedule board.  
  
            2.  Choose **Find availability - All Resources**, to find an available resource from resources in the system  
  
                > [!NOTE]
                >  When you do this, the filters will show options for the selected booking requirement.  
  
            3.  When you see an available slot right-click on the time slot on the schedule board and choose **Book Here**. Or, drag and drop the booking requirement to the available time slot.  
  

## Book a resource using the daily view and find who’s under-booked
  
        1.  On the schedule board, click **View Mode** and select **Days**.  
  
             This shows a grid view of how many hours a resource is booked per day and which days they are free.  
  
        2.  Click the name of the resource you want to book, and then click **Book**.  
  
        3.  On the **Resource booking (create)** dialog box, choose the project that you want to book the resource for along with booking method and start and end times.  
  
        4.  When you’re done, click **Book**.  
  
## Drag an unscheduled booking requirement from the list view to the schedule board
  
        1.  Select an unscheduled booking requirement from the list at the bottom.  
  
        2.  Drag the booking requirement to an available resource/time slot on the schedule board.  
  
        3.  When you're done, click **Book**.  
  
### See Also  
 [Resource Manager Guide](../project-service/resource-manager-guide.md)
