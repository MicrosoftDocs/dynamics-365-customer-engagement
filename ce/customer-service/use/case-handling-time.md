---
title: Track your time on cases (preview)
description: Learn how to use the case handling time widget to view and log your time on cases in Customer Service.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/31/2024 
ms.custom: bap-template 
---

# Track your time on cases (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note.md)]

Case handling time is the time you spend to actively work on a case. This includes time taken to review case details, past cases and customer interactions, do offline research, collaborate with team members, or document case notes. Case handling time helps supervisors measure your productivity and plan staffing.

You can view the following details on the case handling time widget:```

- **Total time tracked**: The sum of the automatic time tracking, manual time tracking, and time spent on activities linked to the case.
- [**Automatic time tracking**](#automatic-time-tracking): The time that the application tracks when a case is in focus. 
- **Manual time tracking**: The [time that you log](#time-logs) manually or the time that you spend on  [activities](#activities) linked to the case.
 
You can also do these actions on the case handling time widget:

- View the profiles of all the customer service representatives (service representatives or representatives) who worked on the case. This includes representatives whose time was automatically recorded or manually logged, and representatives who worked on associated tasks activities such as phone calls, tasks, or emails.
- Turn on the **My time** toggle to see your time only on the case. The timer changes into a ticker that shows your active time in hours, minutes, and seconds as applicable. A visual indicator shows that your time is tracked in real time. 
 > [!NOTE]
 > You can view the **My time** toggle only if your administrator has enabled it in Power Apps. If it doesn't appear, **Total Time** displays only the time you've spent on the case.
- View when the timer was last updated. It refreshes automatically at the frequency set by your administrator. By default, it refreshes every 10 minutes. Select **Refresh** to update the timer and show the current time.
   - In Customer Service workspace, when you select **Refresh**, the **Total Time**, **Automatic Time**, or **Manual Time** values are updated. The records in **History** aren't updated.  
  - In Customer Service Hub, the timer widget displays the updated time automatically at the frequency set by your administrator or when you refresh the case form, navigate from the browser or form. When you select **Refresh**, the **Total Time**, **Automatic Time**, **Manual Time**, and the records in **History** are updated.
- [View history](#view-history).


### Automatic time tracking

The application tracks your time automatically when you focus on a specific case. Time is automatically tracked only when a case is open in a session tab or an app tab within a session tab. Automatic time tracking isn't supported when you switch from one case to another in the inbox.


- In Customer Service workspace, the timer is affected as follows:
    
   | Scenario                                                                                           | Timer status                                     |
   | -------------------------------------------------------------------------------------------------- | -------------------------------------------------- |
   | The case is open in a session tab. You select a related entity record that opens as an app tab. For example, you select a knowledge article linked to the case. The article opens in an app tab within the session form.<br><br> **Note**: This isn't applicable when you open a related case such as a similar case or child case in another app tab within the same case session.  | The timer continues to run for the case.      |
   | The user closes a case that's opened as a session or app tab.                                                      | Timer stops.                                       |
   | You select a related case or a child case linked to the current case. The related case or child case opens as an app tab in the same session.                   | The timer in the current case stops and the timer in the related case or child case starts.             |
   | You select a resolved case.                       | The timer doesn't start and shows the time recorded.   |
   | You switch, minimize, refresh, or close browsers.                                                   | Timer stops.                                       |
   | You open the same case but switch to another case form using Form selector.                                                | Timer stops.                                       |
   |You switch to another case, which is opened in another session tab. | Timer stops for the current case and starts for the case you switched to.|
   | You lock your screen with the case in focus.                                                       | The timer stops.                                   |
   | The Case form is in the background when you perform actions such as selecting queue item details or the **Resolve case** dialog.     | The timer continues to run.                        |
   | You create a new case and don't log time manually on the case or for activities. | Total time displayed is 0 sec. The total time is updated after the first update interval set by your administrator. Select refresh to manually update the time. |
   | You create a new case and don't log time manually on the case or for activities. The **My Time** toggle is turned off.| The total time is 0 sec and is updated after the first update interval. The automatic timer displays 0 sec. Select **Refresh** to manually update the time.|
   | You create a new case and don't log time manually on the case or for activities. The **My Time** toggle is turned on.| The total time is 0 sec and is updated after the first update interval. The automatic timer starts tracking time real-time. Select refresh to manually update the total time.  |
   
  > [!NOTE]
  > The app updates the database with the tracked time at regular intervals based on your administrator's configuration. If you refresh or close the browser in Customer Service workspace or Customer Service Hub, the app records the time for the last completed interval, but might not record the time from the ongoing interval. For example, if the update interval is set to 15 min, and you close the browser after 20 min, the app logs only 15 min. It might not capture the remaining 5 min, because the database wasn't updated in that time. 

- In Customer Service Hub, as long as the case is in focus, the timer runs. If you close or refresh the browser, navigate to a different entity or case form, the timer stops.

### Time logs  
- Show the total time that representatives log manually on the case.
- Based on your administrator's configurations, you can select the **Add** icon to log your time directly on the case. This can be the time that you spend working on the case outside the application such as researching offline, collaborating with other representatives or subject matter experts, or any other activity that contributes to resolving a customer's issue.

### Activities  
The total time spent on the activities linked to the case. If there are multiple activities linked to the case, each activity's time (calculated from duration attribute) contributes to the total Activities time.


### View history
  
- **Automatic time**: The total time spent by each representative on the case. You can edit only your own automatic time records. 
  > [!NOTE]
  > The record for each representative is updated at the frequency set by your administrator. For example, when you create a new case, there won't be any record of automatic time in the history. The record appears after the first update interval.
- **Time logs**: The time manually added by each representative sorted by date and displayed by newest to oldest.  
- **Activities**: The time added for each activity by each representative sorted by date and displayed by newest to oldest.


:::image type="content" source="../media/CHT-screenshot.png" alt-text="screenshot for case handling time":::


### Related information

[Add case handling time widget to case forms (preview)](../administer/add-case-handling-time.md)
