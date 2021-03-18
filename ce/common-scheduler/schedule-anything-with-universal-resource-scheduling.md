---
title: "Overview of Universal Resource Scheduling (Dynamics 365) | MicrosoftDocs"
description: Schedule anything in Dynamics 365 using Universal Resource Scheduling
ms.custom: 
  - dyn365-projectservice
  - dyn365-fieldservice
ms.date: 01/03/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: overview
author: krbjoran
ms.author: krbjoran
manager: shellyha
search.app: 
  - D365CE
  - D365PS
  - D365FS
---
# Overview of Universal Resource Scheduling in Dynamics 365

Schedule anything in Dynamics 365 using Universal Resource Scheduling. You can enable scheduling for any entity in Dynamics 365 Sales, Field Service, Customer Service, and Project Service Automation, including custom entities.   
  
For organizations that use:

- Dynamics 365 Field Service, you can use scheduling tools to assign work orders to the closest field technicians in the area. More information: [Dynamics 365 Field Service Help](../field-service/universal-resource-scheduling-for-field-service.md) 

- Dynamics 365 Customer Service, you can use scheduling tools to book cases to customer service reps in the right department and time zone. More information: [Dynamics 365 Customer Service - Service Scheduling](../customer-service/basics-service-service-scheduling.md)

- Dynamics 365 Project Service Automation, you can use scheduling tools to staff projects with consultants who have availability and the appropriate skill set. More information: [Dynamics 365 Project Service Automation Help](../project-service/overview.md) 
    
## Prerequisites  
 Before you can use Universal Resource Scheduling, make sure you have:  
  
- Dynamics 365 Field Service, Project Service, *or* Customer Service.
  
- A license for Resource Scheduling. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Onboard your organization and users to Dynamics 365 (online)](../admin/onboard-your-organization-and-users-to-dynamics-365-online.md)  
  
- User credentials with the Universal Resource Scheduling security role, in order to manage the solution once it has been deployed.
  
## Enable scheduling for an entity  
 When scheduling is enabled for an entity, the system creates a resource requirement record for the entity. This way, when you create a resource requirement, the system automatically checks which entity the resource requirement is for.  
  
1.  From the main menu, go to **Resource Scheduling** > **Administration**.  
  
2.  Select **Enable Resource Scheduling for Entities**.  
  
3.  On the **Setup Wizard - Enable Scheduling**, select **Add Entity**, and select the entity that you want to enable scheduling for.  
  
4.  Select **Booking Relationship** and select **Create New Relationship**.  
  
5.  Select **Requirement Relationship** and select **Create New Relationship**.  
  
    > [!NOTE]
    >  If you already have relationships created then you can select form an existing relationship.  
  
6.  Click **Publish Customization**.  
  
<!-- is the following really in all-caps?-->
7. On the **BOOKING SETUP METADATA: INFORMATION** form, use the tooltips to edit the default opens.  
  
   > [!NOTE]
   >  To update the Booking Status Field Logical Name, you will first need to customize the system to add additional statuses. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customize your Dynamics 365 system - define status reasons](../customize/define-status-reason-transitions.md)  
   > 
   >  In attribute settings sections field, can be mapped from entity that was enabled for scheduling to fields on booking requirement. For example, from Date, to Date, Territory, Duration and others.  
  
8. When you’re done, select **Save** on the lower right corner.  
  
## Edit or turn off scheduling for an entity  
  
1.  From the main menu, go to **Resource Scheduling** > **Administration** > **Enable Schedulable for Entities**.  
  
2.  From the list of **Enable Entities**, double-click on the entity that you want to edit.  
  
3.  When the **BOOKING SETUP METADATA: INFORMATION** form opens, do one of the following:  
  
    -   To turn off scheduling for the entity, on the command bar, select **DEACTIVATE**. On the **Confirm Deactivation** dialog box, select **Deactivate**.  
  
    -   Or, you can edit the form and when you’re done, select **Save** on the lower right corner.  
  
## Schedule something  
 **Step 1:** Create a resource requirement  
  
1. From the main menu, click **Sales**, **Service**, or **Marketing**.  
  
2. Choose an entity that has scheduling turned on. For example, let’s say it’s turned on for the **Leads** entity. In this case, from the main menu you would choose **Marketing** > **Leads**.  
  
3. From the list of leads choose an existing lead.  
  
4. When the form opens, go to  the subgrid menu, and select **Resource Requirement**.  
  
5. Under the **Resource Requirement Associated View**, select **New**.  
  
6. On the **Resource Requirement** form, use the tooltips to fill in the required information.  
  
7. When you’re done, select **Save**.  
  
    A plugin runs and checks the relationships and automatically sets the booking set-up metadata relationship appropriately.  
  
   **Step 2:** Schedule the booking requirement  
  
   To learn more about the schedule board, [Configure the schedule board](../field-service/configure-schedule-board.md).  
  
   There a few different ways to schedule a booking requirement:  
  
- **Option 1**: Right-click on an unscheduled booking and find available resources.  
  
    1.  From the main menu, go to **Resource Scheduling** > **Schedule Board**.  
  
    2.  From the **Booking Requirement** list, right-click on an unscheduled booking and choose one of the following:  
  
         Choose **Find availability - Current Resources** to find available resource from the list of resources on the schedule board.  
  
         -Or-  
  
         Choose **Find availability -Current Resources**, to find available resource from resources in the system.  
  
        > [!NOTE]
        >  When you do this, the filters will show the options for the selected booking requirement. If you can't find a available resource for the book, try adjusting the filters.  
  
    3.  When you see the available slot right-click on the time slot on the schedule board and choose **Book Here**. Or, drag and drop the booking requirement to the available time slot.  
  
- **Option 2**: Drag an unscheduled booking requirement from list view to the schedule board.  
  
    1.  From the main menu, go to **Resource Scheduling** > **Schedule Board**.  
  
    2.  Select an unscheduled booking requirement from the list at the bottom.  
  
    3.  Drag the item to an available resource/time slot on the schedule board.  
  
- **Option 3**: Schedule a booking requirement from the entity form.  
  
    1.  From the main menu, go to **Sales**, **Service**, or **Marketing**.  
  
    2.  Choose and entity that as scheduling turned on.  
  
         For example, let’s say it’s turned on for the **Leads** entity. In this case, from the main menu you would choose **Marketing** > **Leads**.  
  
    3.  From the list of leads, choose the lead that you want to schedule a booking for.  
  
    4.  When the lead form opens, on  the command bar, select **Book**.  
  
    5.  Use the schedule assistant  to book the requirement.  
  
### See also  
 [Install Dynamics 365 Field Service](../field-service/install-field-service.md)    
 [Install Dynamics 365 Project Service Automation](../project-service/install-customize.md)    


[!INCLUDE[footer-include](../includes/footer-banner.md)]