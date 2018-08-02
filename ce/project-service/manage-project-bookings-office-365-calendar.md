---
title: "Manage projects and bookings in your Office 365 calendar (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
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
ms.assetid: 6c8b7914-7ee4-49a5-8b75-4f3131cd1fb4
caps.latest.revision: 11
ms.author: krbjoran
author: krbjoran
manager: shellyha
---
# Manage projects and bookings in your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar (Project Service Automation)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

View personal appointments, project-work bookings, and field service work order assignments using the [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar.  
  
 With everything in one place, it’s easy to manage your day. Your meetings, appointments, bookings, and tasks are all available in your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar.  
  
 If you’re using [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)], you can also enter your personal appointments in the Project Service time entry view. This lets project and resource managers know your availability for projects. It also saves you time, because you don’t have to enter info about your personal appointments twice. You can simply import your personal appointments from your calendar to Project Service time entry view.  
  
 Your calendar will sync project and work order bookings from today to upcoming four weeks. This setting can’t be changed.  
  
 Syncing is only supported one way, from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement to your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar. If you update a field service or project service booking in your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar, it will not sync and update in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. If you want to update or modify a booking, make sure you do it in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] – so that the booking syncs with your calendar.  
  
 To learn how to use your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar, see [Calendar in Outlook on the web for business](https://support.office.com/article/Calendar-in-Outlook-on-the-web-for-business-5219c457-d1fe-4c2f-9032-1a816b88e936).  
  
## Set-up  
 Before you can see and manage your bookings on your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar, you need to set a few things up.  
  
- You will need to have [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] Global Administrator or [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] System Administrator credentials.  
  
- You [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Admin will need to configure the email server profile and each user will need to configure their mailbox. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up email processing through server-side synchronization](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  
  
## Turn on synchronization for your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization (admin task)  
  
1.  From the main menu, click **Settings** -> **Administration**.  
  
2.  Click **System Settings**.  
  
3.  Click the **Synchronization** tab.  
  
4.  Under **Select whether to enable syncing of resource booking with**, check the **Synchronize resource booking with Outlook**.  
  
## Turn on synchronization for your user profile (user task)  
  
1.  Click the **Settings** button in the upper-right corner of the screen.  
  
2.  Click **Options**.  
  
3.  Click the **Synchronization** tab.  
  
4.  Under **Resource booking sync with Outlook**, check the **Synchronization resource booking with Outlook**.  
  
## Import your personal appointments (user task)  
 You can import your personal appointments from your calendar to Project Service Automation time entry view.  
  
1. Open [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar and click **Import Data**.  
  
2. On the Filters screen, select **Appointments from Exchange** and then click **Apply**.  
  
3. The system will pull appointments into time entry view as suggested entries from the current week. To add entries for another week, click **Previous** or **Next**.  
  
4. Select the appointment that you want to add to Project Service Automation time entry view.  
  
5. On the **Time Entry** popup box, select the appropriate options to convert the appointment to a Project Service Automation time entry view.  
  
6. Click **Save**.  
  
### See Also  
 [Time, Expense, and Collaboration Guide](../project-service/time-expense-collaboration-guide.md)
