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

Case handling time is the duration you spend actively working on a case. This can be the time that you spend reviewing case details, past cases and interactions with the customer through various channels, offline research, collaborating with team members, and documenting case notes. Case handling time helps supervisors measure agent productivity and forecast agent staffing.

The case handling time widget shows you the following information:

- **Total time tracked**: The sum of the automatic time tracking, manual time tracking, and the time spent on activities linked to the case.
- [**Automatic time tracking**](#automatic-time-tracking): The time tracked by the application when a case is in focus. 
- **Manual time tracking**: The [time that you add](#time-logs) to the case manually or the time that you spend on  [activities](#activities) linked to the case.
 
You can also perform the following actions on the case handling time widget:

- See the profiles of all agents who worked on the case. This includes agents whose time was automatically recorded or manually logged, and agents who worked on associated tasks activities such as phone calls and tasks
- Turn on the **My time** toggle to see only your time on the case. The timer changes into a ticker that shows your active time in hours, minutes, and seconds as applicable.A visual indicator shows that your time is tracked in real time. 
 > [!NOTE]
 > You can see the **My time** toggle only if your administrator has enabled it in Power Apps. If you don't see it, the Total Time displays only the time you've spent on the case.
- •	See when the timer was last updated. It refreshes automatically at the frequency based on your administrator's settings. By default, it refreshes every 10 minutes. Select refresh to manually refresh the timer, which will show the time tracked until that point of time. 
- In Customer Service Workspace, clicking on Refresh icon will only update Total time, Automatic time or Manual time tracking. It will not update the history of time tracker records. 
- In Customer Service Hub, the timer widget shows the updated time automatically at the frequency set by your administrator or on case form refresh, browser navigation, form navigation (navigating away from form and returning). Clicking on Refresh icon will update Total time, Automatic time and manual time tracking as well as time tracker records, displayed in history.
- [View history](#view-history).


### Automatic time tracking

The application tracks your time automatically when you have a specific case in focus.

 > [!NOTE]
 > The application automatically tracks time only when a case is open in a session tab or an app tab within a session tab. Automatic time tracking is not supported for scenarios when you switch from one case to another in the Inbox.


- In Customer Service workspace, the timer is affected as follows:
    
   | Scenario                                                                                           | Timer status                                     |
   | -------------------------------------------------------------------------------------------------- | -------------------------------------------------- |
   | The case is open in a session tab. You select a related entity record that opens as an app tab. For example, you select a knowledge article linked to the case. The article opens in an app tab within the session form.<br><br> **Note**: This isn't applicable when you open a related case such as a similar case or child case in another app tab within the same case session.  | The timer continues to run for the case.      |
   | The case that is opened as a session or app tab, is closed by the user.                                                                          | Timer stops.                                       |
   | You select a related case or a child case that's linked to the current case. The related case or child case opens as an app tab in the same session.                   | The timer in the current case stops and the timer in the related case or child case starts.             |
   | You select a resolved case.                       | The timer doesn't start and shows the time recorded.   |
   | You switch, minimize, refresh, or close browsers                                                   | Timer stops.                                       |
   | You open the same case but switch to another case form using Form selector.                                                | Timer stops.                                       |
   |You switch to another case which is opened in another session tab. | Timer stops for the current case and starts for the case you've switched to.|
   | You lock your screen with the case in focus.                                                       | The timer stops.                                   |
   | The Case form is in the background when you perform actions such as selecting queue item details or the resolve case dialog .     | The timer continues to run.                        |
   | You create a new case and haven't manually logged time on the case or for activities. | Total time displayed is 0 seconds. The total time is updated after the first update interval set by your administrator. Select refresh to manually update the time. |
   | You create a new case and haven't manually logged time on the case or for activities. The **My Time** toggle is turned off.| The total time is 0 seconds and is updated after the first update interval. The automatic timer displays 0 seconds. Select refresh icon on the timer to manually update the time.|
   | You create a new case and haven't manually logged time on the case or for activities.The **My Time** toggle is turned on.| The total time is 0 seconds and is updated after the first update interval. The automatic timer starts tracking time realtime. Select refresh to manually update the total time.  |
   
  > [!NOTE]
  > The app updates the database with the time tracked at regular intervals based on your administrator's configuration. If you refresh or close the browser in Customer Service workspace or Customer Service Hub, the app records the time for the last completed interval, but might not record the time from the ongoing interval. For example, if the update interval is set to 15 minutes, and you close the browser after 20 minutes, the app logs only 15 minutes. It might not capture the remaining 5 minutes, because the database wasn't updated in that time. 

- In Customer Service Hub, as long as the case is in focus, the timer runs. If you close or refresh the browser, navigate to a different entity or case form, the timer stops.

### Time logs  
- Show the total time that agents add to the case manually.
- Based on your administrator's configurations, you can select the **Add** icon to log your time directly on a case. This can be the time that you spend working on the case outside the application such as researching offline, collaborating with other agents or subject matter experts, or any other activity that contributes to resolving a customer's issue.

### Activities  
The total time spent on the activities linked to the case. If there are multiple activities linked to the case, the time spent on each activity(calculated from duration attribute) contributes to the total Activities time.

### View history
  
- **Automatic time**: The cumulative time spent by each agent on the case. You can edit the automatic time logged by you and not for other agents. 
  > [!NOTE]
  > The time record shown for each user, is updated at the frequency defined by your administrator. For example, when you create a new case, there will not be any record of automatic time in the history. It will display the tracked time after the first update interval happens to the database, according to the frequency set by your administrator. In Customer Service Hub, you can click on Refresh icon to display the record in the history.   
- **Time logs**: The time manually added by each agent sorted by date and displayed by newest to oldest.  
- **Activities**: The time added for each activity by each agent sorted by dated and displayed by newest to oldest.


