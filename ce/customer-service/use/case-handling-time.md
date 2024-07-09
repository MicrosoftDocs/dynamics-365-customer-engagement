---
title: How time spent on handling cases is tracked (preview)
description: How time spent on handling cases is tracked in Customer Service
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/01/2024 
ms.custom: bap-template 
---

# How time spent on handling cases is tracked (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note.md)]

Case handling time is the time you spend actively working on a case. This can be the time that you spend reviewing case details, past cases and interactions with the customer through various channels, offline research, collaborating with team members, and documenting case notes.

Supervisors can use the case handling time to determine the average time taken to handle cases, enabling effective workforce planning.

When you open a case, you can see the case handling timer widget. Select the widget to expand it and see the following details:

- **Total time tracked**: The sum of the automatic time tracking, manual time tracking, and the time spent on activities linked to the case.
- [**Automatic time tracking**](#automatic-time-tracking): The time spent on a case when it is in focus. 
- **Manual time tracking**: The [time manually](#time-logs) added to the case by agents and the time spent on [activities](#activities) linked to the case.
 
You can also perform the following actions on the case handling time widget:

- View the profiles of all agents who actively contributed to the case, including those with time automatically recorded or manually logged, and agents who worked on associated tasks.
- Select the **My time** toggle. Turn on this toggle to see the time that only you spent working on the case. The timer changes into a ticker to show your active time in hours, minutes, and seconds as applicable. A visual indicator is displayed to show that your time is tracked in real time. 
 > [!NOTE]
 > The **My time** toggle appears only if your administrator has enabled the feature in Power Apps. If you don't see the toggle, you can see the time only you've spent on the case.
- View the the last updated time. This is automatically refreshed based on your administrator's settings. By default, the timer is refreshed every 10 minutes. Select refresh to manually update the time. 
- [View history](#view-history).


### Automatic time tracking
The automatic timer tracks the time spent on a specific case only when it is in focus.  

 > [!NOTE]
 > Automatic time tracking is applicable when the case is opened in the session tab or an app tab within a session tab. When you switch from one case to another in the Inbox, the automatic timer isn't triggered and your time isn't logged. 


- In Customer Service workspace, the timer is affected as follows:
    
   | Scenario                                                                                           | Timer status                                     |
   | -------------------------------------------------------------------------------------------------- | -------------------------------------------------- |
   | The case is open in a session tab. You select a related entity record that opens as an app tab. For example, you select a knowledge article linked to the case. The article opens in an app tab within the session form.<br><br> **Note**: This isn't applicable when you open a related case such as a similar case or child case in another app tab within the same case session.  | The timer continues to run for the case.      |
   | The status of the case opened as a session or app tab is closed.                                                                           | Timer stops.                                       |
   | You select a related case or a child case that's linked to the current case. The related case or child case opens as an app tab in the same session.                   | The timer in the current case stops and the timer in the related case or child case starts.             |
   | You select a resolved case.                       | The timer doesn't start and the time recorded up to that moment is displayed.           |
   | You switch, minimize, refresh, or close browsers                                                   | Timer stops.                                       |
   |You switch to another case which is opened in another session tab. | Timer stops for the current case and starts for the case you've switched to.|
   | You lock your screen with the case in focus.                                                       | The timer stops.                                   |
   | The Case form is in the background when you perform actions like selecting queue item details or the resolve case dialog and so on.     | The timer continues to run.                        |
   | You create a new case, and haven't manually logged time on the case or for activities. | Total time displayed is 0 seconds. The total time is updated after the first update interval set by your administrator. |
   | You create a new case, and haven't manually logged time on the case or for activities. The **My Time** toggle is turned off.| The total time is 0 seconds and is updated after the first update interval. The automatic timer displays 0 seconds. |
   | You create a new case, and haven't manually logged time on the case or for activities.The **My Time** toggle is turned on.| The total time is 0 seconds and is updated after the first update interval. The automatic timer starts tracking time realtime.  |
   
  > [!NOTE]
  > Based on admin configuration, the application updates the database with the time tracked at regular intervals. If the browser is refreshed or closed, the application records the time for the last completed interval, and might not update the time from the ongoing interval. For example, if the update interval is set to 15 minutes, and you close the browser after 20 minutes, the application logs the 15 minutes. However, the subsequent 5 minutes may not be captured, as the database wouldn't have been updated in that time.
     
- In Customer Service Hub, as long as the case is in focus, the timer runs. If you close or refresh the browser, navigate to a different entity or case form, the timer stops.

### Time logs  
- Display the cumulative time agents manually add to the case. 
- Based on your administrator's configurations, you can select the **Add** icon to log your time directly on a case. This can be the time that you spend working on the case outside the application such as researching offline, collaborating with other agents or subject matter experts, or any other activity that contributes to resolving a customer's issue.

### Activities  
The total time spent on the activities linked to the case. If there are multiple activities linked to the case, the time spent on each activity contributes to the total Activities time.

### View history
  
- **Automatic time**: The cumulative time spent by each agent on the case. You can edit the automatic time logged by you and not for other agents. 
- **Time logs**: The time manually added by each agent sorted by date and displayed by newest to oldest.  
- **Activities**: The time added for each activity by each agent sorted by dated and displayed by newest to oldest.     


