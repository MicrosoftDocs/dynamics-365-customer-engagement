---
title: Manage case handling time
description: How-to description
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/01/2024 
ms.custom: bap-template 
---

# Manage case handling time

Case handling time is the period you actively work on a case, which includes the time spent reviewing the case details, customer's past cases and interactions, and communicating with the customer through various channels, offline research, collaborating with team members, and documenting case-related notes. 

Supervisors can use the case handling time to understand the average time taken to handle cases, enabling effective workforce planning.

When you open a case, you can see the case handling timer bubble that displays the total time spent on the case. If you select this bubble, you can see the following details:

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
| The case is open in a session tab. You select a related record that opens as an app tab.           | The timer continues to run for the case.           |
| The case form is closed.                                                                           | Timer stops.                                       |
| You select a related case or a child case that's linked to the current case.                       | The timer in the current case stops.               |
| You select a resolved related case or child case linked to the current case.                       | The timer in the current case stops.               |
| You switch, minimize, refresh, or close browsers                                                   | Timer stops.                                       |
| You lock your screen with the case in focus.                                                       | The timer stops.                                   |
| The Case form is in the background when you perform actions like selecting queue item details.     | The timer continues to run.                        |
   
> [!NOTE]
> The application updates the database with the time tracked at regular intervals, based on your administrator's configuration. When a browser is refreshed or closed, the time tracked might be updated for the previous interval and might not contain the time tracked in the current interval.
     
- - In Customer Service Hub, as long as the case is in focus, the timer runs. If you switch to another tab, close or refresh the browser, the timer stops.
- The personas of all the agents who spent time actively working on the case are displayed. If you select the **My time** toggle, the timer changes into a ticker to show your active time in hours, minutes, and seconds as applicable. A visual indicator is displayed to show that the ticker is now tracking your time, real time. 

**Time logs**
- Display the cumulative time agents manually add to the case. 
- Based on your administrator's configurations, you can select the **Add** icon to log your time on a case.

**Activities**
The total time spent on the activities linked to the case.

**View history**:<br>
- **Automatic time**: The cumulative time of time spent by each agent on the case. You can edit the automatic time logged by you and not for other agents.<br>
- **Time logs**: The time manually added by each agent displayed by date.<br>
- **Activities**: The time added for each activity by each agent displayed by date.<br>


