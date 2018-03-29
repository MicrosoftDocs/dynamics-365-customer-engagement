---
title: Find the next available time before creating a service activity (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Find the next available time before creating a service activity in Dynamics 365 for Customer Service
keywords: Find the next available time before creating a service activity; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.service: crm-online
ms.assetid: e23ae2ff-620a-4498-97dc-6d3a93813166
---

# Find the next available time before creating a service activity

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Avoid conflicts while scheduling services by finding the time the resources are available beforehand.  
  
1.  Make sure you have the Scheduler role or equivalent permissions.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_service_service_calendar](../includes/proc-service-service-calendar.md)]  
  
3.  Click **Schedule**.  
  
4.  On the **Schedule Service Activity** form, type or change information in the text boxes.  
  
     Hovertips provide hints about what to enter.  
  
    -   Under **Requested Time**, select criteria for the times you want:  
  
        -   To search for a time on a specific date, in **Start Date**, select **Specific Date**, and then enter the date you want.  
  
        -   To search within a range of dates, select **Range of Dates**, and then enter the **On or After** and **On or Before** dates. You can also select specific days of the week.  
  
        -   You can also search for times based on dates relative to the current date, such as **Today**, **Tomorrow**, **This Week**, **Next Week**, or **Next Month**.  
  
        -   Similarly, to search within specific range of time, in **Start Time**, select **Specific Time**, **Range of Times**, or **Morning**, **Evening**, **Afternoon**.  
  
        -   Do not clear the Use Default Duration check box and change the duration unless you want to schedule more time than the default duration of the service. The maximum duration of a service activity is 10 days.  
  
5.  Click **Find Available Times**. The next available times are shown.  
  
6.  Under **Available Times**, select the time for which you want to schedule the service activity, and then click **Schedule**.  
  
     The Schedule Service Activity form closes, and [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] fills in the information from the selected time in the Service Activity form.  
  
7.  Type or modify information in other text boxes, as required.  
  
     Hovertips provide hints about what to enter.  
  
8.  When you’re ready to save your data, click **Save**.  
  
     The service activity appears as a color block on the Service calendar.  
  
> [!TIP]
>  If you want to find an available time without any time restriction, do not specify any criteria under **Requested Time**, and click **Find Available Times**.  
  
### See also  
 [Force an activity into a time slot](../customer-service/create-service-activity-without-checking-conflicts.md)   
 [Navigate the service calendar](../customer-service/navigate-service-calendar.md)
