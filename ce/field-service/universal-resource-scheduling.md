---
title: "Schedule anything in Dynamics 365 with Universal Resource Scheduling | MicrosoftDocs"
ms.date: 09/30/2017
ms.service: dynamics-365-customerservice
ms.topic: get-started-article
ms.assetid: c92c0cba-cc1d-41ef-983f-869a7a8c1988
author: FieldServiceDave
ms.author: daclar
manager: shellyha
ms.reviewer: krbjoran
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 14
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-projectservice
  - dyn365-fieldservice
search.app: 
  - D365CE
  - D365PS
  - D365FS
ms.technology: common-scheduler
searchScope: 
  - Customer Service
  - Field Service
  - Project Service
---
# Schedule anything with Universal Resource Scheduling (Sales, Customer Service, Field Service, Project Service Automation)

Schedule anything in Dynamics 365 using Universal Resource Scheduling. You can enable scheduling for any entity including custom entities.   
  
 For example, you can enable scheduling for the opportunity form and schedule marketing visits for your opportunities. You can also do this for the case form and schedule time to work on cases.  
  
 For organizations that use:

- [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)], you’ll see a new integrated scheduling experience. More information: [Dynamics 365 Field Service Help](../field-service/overview.md) 
  
- [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)], you’ll have a new improved scheduling experience. More information: [Dynamics 365 Project Service Automation Help](../project-service/overview.md) 
  
## Prerequisites  
 Before you can start using  Universal Resource Scheduling, make sure you have the following:  
  
- You will need to have either [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] or [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)].  
  
- A license for Universal Resource Scheduling. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Onboard your organization and users to Dynamics 365 (online)](../admin/onboard-your-organization-and-users-to-dynamics-365-online.md)  
  
- To manage the solution once it has been deployed you will need user credentials with Universal Resource Scheduling security role.  
  
## Enable scheduling for an entity  
 When scheduling is enabled for an entity, the system creates a resource requirement record for the entity. This way, when you create a resource requirement, the system automatically checks which entity the resource requirement is for.  
  
1.  From the main menu, click **Resources Scheduling** > **Administration**.  
  
2.  Click **Enable Resource Scheduling for Entities**.  
  
3.  On the **Setup Wizard - Enable Scheduling**, click **Add Entity** and select the entity that you want to enable scheduling for.  
  
4.  Click **Booking Relationship** and select **Create New Relationship**.  
  
5.  Click **Requirement Relationship** and select **Create New Relationship**.  
  
    > [!NOTE]
    >  If you already have relationships created then you can select form an existing relationship.  
  
6.  Click **Publish Customization**.  
  
<!-- is the following really in all-caps?-->
7. On the **BOOKING SETUP METADATA: INFORMATION** form, use the tooltips to edit the default opens.  
  
   > [!NOTE]
   >  To update the Booking Status Field Logical Name, you will first need to customize the system to add additional statuses. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customize your Dynamics 365 system - define status reasons](../customize/define-status-reason-transitions.md)  
   > 
   >  In attribute settings sections field, can be mapped from entity that was enabled for scheduling to fields on booking requirement. For example, from Date, to Date, Territory, Duration and others.  
  
8. When you’re done, click **Save** on the lower right corner.  
  
## Edit or turn off scheduling for an entity  
  
1.  From the main menu, click **Resources Scheduling** > **Administration** > **Enable Schedulable for Entities**.  
  
2.  From the list of **Enable Entities**, double-click the entity that you want to edit.  
  
3.  When the **BOOKING SETUP METADATA: INFORMATION** form opens, do one of the following:  
  
    -   To turn off scheduling for the entity, on the command bar, click **DEACTIVATE**. On the **Confirm Deactivation** dialog box, click **Deactivate**.  
  
    -   Or, you can edit the form and when you’re done, click **Save** on the lower right corner.  
  
## Schedule something  
 **Step 1:** Create a resource requirement  
  
1. From the main menu, click **Sales**, **Service**, or **Marketing**.  
  
2. Choose an entity that has scheduling turned on. For example, let’s say it’s turned on for the **Leads** entity. In this case, from the main menu you would choose **Marketing** > **Leads**.  
  
3. From the list of leads choose an existing lead.  
  
4. When the form opens, go to  the sub-grid menu, and click **Resource Requirement**.  
  
5. Under the **Resource Requirement Associated View**, click **New**.  
  
6. On the **Resource Requirement** form, use the tooltips to fill in the inform required information.  
  
7. When you’re done, click **Save**.  
  
    A plugin runs and checks the relationships and automatically sets the booking set-up metadata relationship appropriately.  
  
   **Step 2:** Schedule the booking requirement  
  
   To learn more about the schedule board, [Configure the schedule board](../field-service/configure-schedule-board.md).  
  
   There a few different ways to schedule a booking requirement:  
  
- **Option 1**: Right-click an unscheduled booking and find available resources.  
  
    1.  From the main menu, click **Resource Scheduling** > **Schedule Board**.  
  
    2.  From the **Booking Requirement** list, right-click an unscheduled booking and choose one of the following:  
  
         Choose **Find availability - Current Resources** to find available resource from the list of resources on the schedule board.  
  
         -Or-  
  
         Choose **Find availability -Current Resources**, to find available resource from resources in the system.  
  
        > [!NOTE]
        >  When you do this, the filters will show the options for the selected booking requirement. If you can't find a available resource for the book, try adjusting the filters.  
  
    3.  When you see the available slot right-click the time slot on the schedule board and choose **Book Here**. Or, drag and drop the booking requirement to the available time slot.  
  
- **Option 2**: Drag an unscheduled booking requirement from list view to the schedule board.  
  
    1.  From the main menu, click **Resource Scheduling** > **Schedule Board**.  
  
    2.  Select an unscheduled booking requirement from the list at the bottom.  
  
    3.  Drag the item to an available resource/time slot on the schedule board.  
  
- **Option 3**: Schedule a booking requirement form the entity form.  
  
    1.  From the main menu, click **Sales**, **Service**, or **Marketing**.  
  
    2.  Choose and entity that as scheduling turned on.  
  
         For example, let’s say it’s turn on for the **Leads** entity. In this case, from the main menu you would choose **Marketing** > **Leads**.  
  
    3.  From the list of leads, choose the lead that you want to schedule a booking for.  
  
    4.  When the lead form opens, on  the command bar, click **Book**.  
  
    5.  Use the schedule assistant  to book the requirement.  
  
### See also  
 [Install Dynamics 365 Field Service](../field-service/install-field-service.md)    
 [Install Dynamics 365 Project Service Automation](../project-service/install-customize.md)    


[!INCLUDE[footer-include](../includes/footer-banner.md)]
