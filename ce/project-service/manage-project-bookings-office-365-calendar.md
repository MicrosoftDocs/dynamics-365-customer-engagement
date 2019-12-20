---
title: Manage projects and bookings in your Office 365 calendar 
description: How to manage projects and bookings in your Office 365 calendar
author: ruhercul
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
---


<!--from editor: Lines 45, 52, 54, and 56 contain Customer Engagement "includes" tags that need to be updated to remove Customer Engagement. -->


# Manage projects and bookings in your calendar (Project Service)

> [!Note]
> DEPRECATED: This feature has been deprecated and is no longer available.

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

[!INCLUDE[pn_office_365](../includes/pn-office-365.md)] 

View personal appointments, project-work bookings, and field service work order assignments using the [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar.  
  
 With everything in one place, it’s easy to manage your day. Your meetings, appointments, bookings, and tasks are all available in your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar.  
  
 If you’re using [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)], you can also enter your personal appointments in the Project Service time entry view. This lets project and resource managers know your availability for projects. It also saves you time, because you don’t have to enter info about your personal appointments twice. You can simply import your personal appointments from your calendar to Project Service time entry view.  
  
 Your calendar will sync project and work order bookings from today to upcoming four weeks. This setting can’t be changed.  
  
 Syncing is only supported one way, from PSA to your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar. You can sync in the reverse order. 
  
 To learn how to use your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar, see [Calendar in Outlook on the web for business](https://support.office.com/article/Calendar-in-Outlook-on-the-web-for-business-5219c457-d1fe-4c2f-9032-1a816b88e936).  
  
## Setup  
 Before you can see and manage your bookings on your [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] calendar, you need to set a few things up.  
  
- You will need to have [!INCLUDE[pn_office_365](../includes/pn-office-365.md)] Global Administrator or System Administrator credentials.  
  
- Your Admin will need to configure the email server profile and each user will need to configure their mailbox. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up email processing through server-side synchronization](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  
  
## Turn on synchronization for your organization (admin task)  
  
1.  From the main menu, click **Settings** > **Administration**.  
  
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
