---
title: Create a customer service schedule and define the work hours (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to create a customer service schedule and define the work hours for Dynamics 365 for Customer Service
keywords: Service schedule; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 09/15/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: ee605a89-4bd5-4b93-8d45-2ec9ca0a9b8a
ms.custom: dyn365-customerservice
---

# Create a customer service schedule and define the work hours (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

To define when your service or support team is available for providing support to customers, create a customer service schedule in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. A customer service schedule determines the business hours for each day in a week and also the weekly off. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] uses these details for time tracking of service level agreements (SLAs).  
  
 For SLA time tracking, make sure you add a holiday schedule to the customer service schedule, and associate this customer service schedule to the SLA record.  
  
> [!IMPORTANT]
> This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)].  
  
## Create a customer service schedule  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3.  Click **Customer Service Schedule**.  
  
4.  To create a new customer service schedule, click **+ New**.  
  
     -OR-  
  
     To edit a schedule that you already have, in the list of records, select the schedule, and on the command bar, click **Edit**.  
  
5.  In the **Create Customer Service Schedule** dialog box, in the **Name** box, type a meaningful name for the schedule, like “APAC Customer Schedule”, and click **Create**.  
  
6.  In the **Weekly Schedule** dialog box, under **Set the recurring weekly schedule** section, follow these steps:  
  
    ![Schedule and hours settings](../customer-service/media/crm-ua-customer-holiday-schedule.png "Schedule and hours settings")  
  
   1.  For work hours, select one of these options:  
  
        - **Are the same each day**. The schedule is the same for every day of the week. After you select this option, to select the days of the week that the customer support is available, click **Set Work Hours**.  
  
             To set the work hours for the days, click **Set Work Hours**. For more information, see the **Define work hours for the customer service schedule section** in this topic.  
  
        - **Vary by day**. The new schedule is different for one or more days of the week. After you select this option, select the days of the week that the customer support is available, and also specify the work hours for each day.  
  
        - **24 x 7 support**. The customer support is available 24 hours a day, and all days a week.  
  
    2.  For **Work Days**, select the check box for each day that the customer support resources will be available and working.  
  
    3.  For **Holiday Schedule**, select **Observe** to specify when your service organization will be closed.  
  
         If you selected **Observe**, select a holiday schedule from the lookup box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up a holiday schedule](../customer-service/set-up-holiday-schedule.md)  
  
7.  Under **Select the time zone**, in the **Time Zone** drop-down box, select the time zone in which your customer support resources will work.  
  
8. [!INCLUDE[proc_click_or_tap_save_and_close](../includes/proc-click-or-tap-save-and-close.md)]  
  
## Define the work hours for the schedule  
 In the **Set Work Hours** dialog box, complete the following fields, and then click **OK**:  
  
- **Start**  
  
     Select the time the work day starts.  
  
- **End**  
  
     Select the time the work day ends.  
  
 To add a break in the work hours, like a lunch break, click **Add Break**, and then select the start and end time of the break.  
  
### See also  
 [Set up a holiday schedule](../customer-service/set-up-holiday-schedule.md)   
 [Define service level agreements](../customer-service/define-service-level-agreements.md)   
 [Create an entitlement to define the support terms for a customer](../customer-service/create-entitlement-define-support-terms-customer.md)
