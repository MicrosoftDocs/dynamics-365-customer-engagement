---
title: Force an activity into a time slot (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to force an activity into a time slot in Dynamics 365 for Customer Service
keywords: Force an activity; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.custom: article
ms.service: crm-online
ms.assetid: e2050e36-3e95-49b1-9f2b-f0025eb7022c
---

# Force an activity into a time slot in the service schedule

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can create a service activity by finding the next available times of resources for a service or simply without checking for conflicts. If needed, you can force a service activity into a time slot to squeeze another service activity into the leftover time from a previous service activity. If you save a service activity without finding available times in the schedule, then [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] displays the service activity in the schedule without checking for conflicts.  
  
 One reason to force a service activity into a time slot is to squeeze another service activity into the leftover time from a previous service activity.  
  
1.  Make sure you have the Scheduler security role or equivalent permissions in Microsoft Dynamics 365.  
  
2. [!INCLUDE[proc_service_service_calendar](../includes/proc-service-service-calendar.md)]  
  
3.  On the command bar, click **Service Activity**.  
  
4.  On the Service Activity form, type or change information in the text boxes.  
  
     Hovertips provide hints on what to enter.  
  
5.  When you’re ready to save your data, click **Save**.  
  
> [!TIP]
>  You can record a customer's preferences for a specific time, day, service, facility, equipment, and customer service representative in the customer record on the **Administration** tab. As you are scheduling a service activity, the customer's preference is displayed in the **Form Assistant** pane.  
  
> [!NOTE]
> - If at any time before you save this service activity you want to search the schedule for an available time, you can click **Schedule** in the **Actions** group to open the **Schedule Service Activity** dialog box.  
> - To check the schedule for conflicts, in **Service Calendar**, in the **Actions** group, click **Conflicts**.  
  
### See also  
 [Navigate the service calendar](../customer-service/navigate-service-calendar.md)   
 [Find the next available time before creating a service activity](../customer-service/find-next-available-time-before-create-service-activity.md)   
 [Overview of service and service scheduling](../customer-service/basics-service-service-scheduling.md)   
