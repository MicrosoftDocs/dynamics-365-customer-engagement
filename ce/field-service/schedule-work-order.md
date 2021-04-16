---
title: "Schedule a work order (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to schedule a work order in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Schedule a work order (Field Service)

Once a work order has been created in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)], it's ready to be scheduled. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a work order](../field-service/create-work-order.md)  
  
 Before you use the schedule board, it’s important to set it up. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the schedule board](../field-service/configure-schedule-board.md)  
  
<a name="BKMK_ScheduleWOManually"></a>   
## Schedule a work order manually  
  
1.  From the main menu, click **Field Service** > **Schedule Board**.  
  
2.  There are several ways to manually schedule a work order:  
  
    - **Right-click an unscheduled booking and find available resources**.  
  
        1.  From the **Booking Requirement** list, right-click an unscheduled booking and choose one of the following:  
  
            1. **Choose Find availability -Current Resources** to find available resource from the list of resources on the schedule board.  
  
            2. **Choose Find availability -Current Resources**, to find available resource from resources in the system  
  
                > [!NOTE]
                >  When you do this, the filters will show the options for the selected booking requirement.  
  
            3.  When you see the available slot right-click the time slot on the schedule board and choose **Book Here**. Or, drag and drop the booking requirement to the available time slot.  
  
    - **Drag unscheduled work orders from list view to the schedule board**.  
  
        1.  Select an unscheduled work order from the list at the bottom.  
  
        2.  Drag the work order to an available resource/time slot on the schedule board.  
  
    - **Block out a slot on the schedule board directly, and select an unscheduled work order to schedule.**  
  
        1.  Select an available slot for the resource you are trying to schedule.  
  
        2.  While holding down **Shift**, select and drag across to highlight the duration you want to schedule.  
  
        3.  A pop-up window appears that allows you to choose a work order to schedule during the time slot. You can also create a work order from this screen by selecting **New** in the bottom-left corner.  
  
<a name="BKMK_bookoption"></a>   
## Schedule a work order using the Book option  
  
1.  From the main menu, select **Field Service** > **Work Orders**.  
  
2.  Select a work order from the list, or select the work order number.  
  
3.  On the command bar, select **Book**.  
  
4.  Choose from the recommended resources and then select **Book & Close**.  
  
    > [!NOTE]
    >  You can also the filter to find other resources.  
  
<a name="BKMK_SchedulingAssistant"></a>   
## Schedule a work order using the scheduling assistant  
  
1. From the main menu, select **Field Service** > **Work Orders**.  
  
2. Select a work order from the list, or select the work order number.  
  
3. On the command bar, select **Schedule Assistant**.  
  
4. When the schedule assistant opens, choose the constraints that you will use to query the system to find available resources and time slot options.  
  
   - **Duration**: Pulled from the estimated duration on the work order, which is driven by the incidents.  
  
   - **Radius Constraint**: Select the radius for the available resources. This defaults from a [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] setting.  
  
   - **Start and End Days**: Choose the date ranges. This is driven from the date window fields on the work order.  
  
<a name="BKMK_ReassignReschedule"></a>   
## Reassign and reschedule a work order  
  
-   From the schedule board, choose the work order, and then drag it to a new time slot or resource.  
  
<a name="BKMK_MoveUncompleted"></a>   
## Move work orders not completed to a future day  
  
-   Select the **Actions** menu, and then select **Move Booking to Next Day**.  
  
### See also   
 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Create a work order](../field-service/create-work-order.md)   
 [Submit and approve time-off requests](../field-service/submit-approve-time-off-requests.md)   
 [Configure the schedule board](../field-service/configure-schedule-board.md)<br>
 [User's Guide](../field-service/user-guide.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]