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

Case handling time is the period you actively work on a case such as the time that you spent reviewing the case details, past cases and interactions with the customer through various channels, your offline research collaboration with team members, and the time spent on documenting case-related notes.

Supervisors can use the case handling time to understand the average time taken to handle cases, enabling effective workforce planning.

When you open a case, you can see the case handling timer widget that displays the total time spent on the case. If you select this widget, you can see the following details:

**Total time tracked** 
You can see the following details:
-  The total time spent on the case. This is the sum of the automatic time tracking, manual time tracking, and the time spent on activities linked to the case. 
- The **My time** toggle. Turn on this toggle to see the time that only you spent working on the case.
- The last updated time. Select refresh to view the updated time.

**Automatic time tracking**
The automatic timer tracks the time spent on a specific case only when it is in focus. 

- In Customer Service workspace, the timer is affected as follows:
    
| Scenario                                                                                           | Timer status                                     |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------- |
| The case is open in a session tab. You select a related entity record that opens as an app tab.           | The timer continues to run for the case.           |
| The case form is closed.                                                                           | Timer stops.                                       |
| You select a related case or a child case that's linked to the current case. The related case or child case opens.                       | The timer in the current case stops and the timer in the related case or child case starts.             |
| You select a resolved case.                       | The timer doesn't start               |
| You switch, minimize, refresh, or close browsers                                                   | Timer stops.                                       |
| You lock your screen with the case in focus.                                                       | The timer stops.                                   |
| The Case form is in the background when you perform actions like selecting queue item details or the resolve case dialog and so on.     | The timer continues to run.                        |
   
> [!NOTE]
> Based on admin configuration, the application updates the database with the time tracked at regular intervals. If the browser is refreshed or closed, the application records the time for the last completed interval, and might not update the time from the ongoing interval.
     
- In Customer Service Hub, as long as the case is in focus, the timer runs. If you close or refresh the browser, the timer stops.
- The personas of all the agents who spent time actively working on the case are displayed. If you select the **My time** toggle, the timer changes into a ticker to show your active time in hours, minutes, and seconds as applicable. A visual indicator is displayed to show that your time is tracked in real time. 

**Time logs**
- Display the cumulative time agents manually add to the case. 
- Based on your administrator's configurations, you can select the **Add** icon to log your time on a case.

**Activities**
The total time spent on the activities linked to the case.

**View history**:  
- **Automatic time**: The cumulative time of time spent by each agent on the case. You can edit the automatic time logged by you and not for other agents.  
- **Time logs**: The time manually added by each agent displayed by date.  
- **Activities**: The time added for each activity by each agent displayed by date.   


