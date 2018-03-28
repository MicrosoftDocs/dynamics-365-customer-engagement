---
title: "Create or edit an appointment (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: 50af7faf-8578-4244-9710-f05544b97f38
caps.latest.revision: 41
ms.author: "shujoshi"
manager: "sakudes"
---
# Create or edit an appointment

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Block time to meet or talk to your customers by using appointments. You can modify any of the information in an open appointment. If you change the date and times of the appointment, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] will recheck for schedule conflicts.  

The calendar displays canceled and completed appointments and service activities. 

> [!NOTE]
>  You can’t insert attachments in a recurring appointment.  


To remove an appointment or service activity from the calendar, delete the record.  
  
1.  To create an appointment or a recurring appointment on the Service Calendar, on the nav bar: [!INCLUDE[proc_service_service_calendar](../includes/proc-service-service-calendar.md)]  
  
    To create an appointment or recurring appointment in the Activities area, on the nav bar: [!INCLUDE[proc_sales_activities](../includes/proc-sales-activities.md)]  
  
2.  On the command bar, click **Appointment**.  
  
3.  Type or change information in the text boxes. You can point to a field to get a tip on what data to enter.  
  
4.  If this is a recurring appointment, click **Recurrence**, and then select the time, pattern, and date range you want.  
  
5.  Click **Save**.  
  
     If any participants have a schedule conflict, a warning appears. You can click **Ignore and Save** to save the appointment anyway.  
  
If you want to add an attachment, make sure you save the appointment first. Then, in the **Attachments** section, click the **Add attachment record** button ![Add Appointment button](../basics/media/plus-sign-icon.png "Add Appointment button") (you may have to scroll to the right to see the button) and browse for the file. The attachment size limitation is the same as the email attachment size limitation, which can be changed by your system administrator. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Email tab](../admin/system-settings-dialog-box-email-tab.md)

> [!IMPORTANT]
>  If you plan to include appointments in solutions, we strongly recommend that you don’t include only appointments and only recurring appointments in separate solutions. If you install and uninstall separate solutions with different appointment types, you’ll encounter a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] error and you’ll have to recreate the appointments. 

<!-- Commented out deprecated features>      
 **If you’re using Dynamics 365 for Outlook**  
  
 Keep the following in mind if you’re using [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] in addition to the web application:  
  
-   If you’re using the [!INCLUDE[pn_crm_online_2015_update](../includes/pn-crm-online-2015-update.md)] or later, [!INCLUDE[pn_crm_2015](../includes/pn-crm-2015.md)] or later, or [!INCLUDE[pn_crm_2015_outlook](../includes/pn-crm-2015-outlook.md)] or later, you can synchronize appointment attachments between [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] if your system administrator has enabled attachment synchronization. You can insert the attachments in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
-   Appointments created in the web application and synchronized with [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] automatically set a 15-minute reminder and appear on the [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] calendar. You can change the reminder in [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
-   Service calendar items aren’t added to your [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] calendar.  
-->  
### See also  
 [Navigate the service calendar](../customer-service/navigate-service-calendar.md)   
 [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)   
<!-- 
[Track Outlook appointments in Dynamics 365 for Outlook](../outlook-add-in/track-outlook-appointments-dynamics-365-outlook.md)
-->
