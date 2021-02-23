---
title: Find the next available time before creating a service activity (Dynamics 365 Customer Service) | MicrosoftDocs
description: Find the next available time before creating a service activity in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Find the next available time before creating a service activity (Customer Service app)

Avoid conflicts while scheduling services by finding the time the resources are available beforehand.  
  
1. Make sure you have the Scheduler role or equivalent permissions.  
  
   #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_service_service_calendar](../includes/proc-service-service-calendar.md)]  
  
3. Select **Schedule**.  
  
4. On the **Schedule Service Activity** form, type or change information in the text boxes.  
  
    Hovertips provide hints about what to enter.  
  
   -   Under **Requested Time**, select criteria for the times you want:  
  
       -   To search for a time on a specific date, in **Start Date**, select **Specific Date**, and then enter the date you want.  
  
       -   To search within a range of dates, select **Range of Dates**, and then enter the **On or After** and **On or Before** dates. You can also select specific days of the week.  
  
       -   You can also search for times based on dates relative to the current date, such as **Today**, **Tomorrow**, **This Week**, **Next Week**, or **Next Month**.  
  
       -   Similarly, to search within specific range of time, in **Start Time**, select **Specific Time**, **Range of Times**, or **Morning**, **Evening**, **Afternoon**.  
  
       -   Do not clear the Use Default Duration check box and change the duration unless you want to schedule more time than the default duration of the service. The maximum duration of a service activity is 10 days.  
  
5. Select **Find Available Times**. The next available times are shown.  
  
6. Under **Available Times**, select the time for which you want to schedule the service activity, and then select **Schedule**.  
  
    The Schedule Service Activity form closes, and the application fills in the information from the selected time in the Service Activity form.  
  
7. Type or modify information in other text boxes, as required.  
  
    Hovertips provide hints about what to enter.  
  
8. When you’re ready to save your data, select **Save**.  
  
    The service activity appears as a color block on the Service calendar.  
  
> [!TIP]
>  If you want to find an available time without any time restriction, do not specify any criteria under **Requested Time**, and select **Find Available Times**.  
  
### See also  
 [Force an activity into a time slot](../customer-service/create-service-activity-without-checking-conflicts-cs-app.md)   
 [Navigate the service calendar](../customer-service/navigate-service-calendar-cs-app.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]