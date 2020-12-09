---
title: View meetings in the Dynamics 365 Sales mobile app
description: Instructions to view meetings in the Dynamics 365 Sales mobile app
ms.date: 11/30/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# View meetings

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

On the home page, you can see resources that can help you better plan your day. For example, one past and one upcoming meeting are displayed in the **Meetings** section.    
To see more meetings for the day, tap **Meetings** either on the home page or on the navigation bar. Meetings that have been scheduled in Microsoft Outlook are displayed.    
> [!NOTE]
> - You can't create a meeting from the Dynamics 365 Sales mobile app.
> - The Meetings section only include meetings that have at least one attendee who's outside of your organization's domain.   
 
**To view meetings**    
1.  On the navigation bar, tap **Meetings**.    
    The calendar view opens.    
    ![Meetings section](media/sm-meetings-nav-bar.png "Meetings section")    
    The current meeting time is shown in blue with a triangle icon beside it. To see the details of a meeting, tap the meeting record.    
2.  To see meetings for a specific date, tap a date in the calendar.    
    ![Select a date to see meetings](media/sm-select-date.png "Select a date to see meetings")   
    If there are no meetings scheduled for the day, nothing is displayed.   

## View meeting details    
To see details of a specific meeting, tap the meeting record on either the home page or the calendar view. The meeting details are displayed, as shown in the following image.    
![Meeting details](media/sm-meeting-details.png "Meeting details")  

Meeting details include the following:   
1. [Meeting information](#meeting-information)   
2. [Attendees](#attendees)   
3. [Regarding entity](#regarding-entity)   
4. [Notes and Reminders](#notes-and-reminders)   

### Meeting information   
The meeting information section provides information on the subject, when the meeting is scheduled, where the meeting is happening, and description. Tap the description section to get a detailed information on what the meeting is about. The information is view-only and you can't edit it in the app.  
### Attendees    
Attendees are the customers and the organizer who are attending the meeting. Up to five attendees are shown and you can see who will attend with the acceptance status such as accepted, tentative, declined, or no response. When you tap the name of an attendee, the quick view of their contact record opens. You can perform the following actions on the contact: view, edit, and create. More information: [Manage contacts](create-contact.md).            
### Regarding entity    
The regarding entity specifies what the meeting is about, such as opportunity, lead, contact, or account. When a meeting is attached to an entity, the meeting displays the timeline, insight, participant information, and corresponding related entities. Also, the regarding entity helps you to understand what the meeting is about, so you can come prepared with relevant information.  
In the following image, you can see that the meeting is regarding an opportunity to purchase 10,000 no roof cars.   
> [!div class="mx-imgBorder"]
> ![View regarding entity](media/sm-view-regarding-entity.png "View regarding entity")   
You can perform the following action on regarding entities: view, edit, change entity, and add entity. More information: [Manage records or regarding entities](open-record.md).    
### Notes and Reminders    
The timeline also shows any related notes and reminders through insight cards based on the related entities. The cards are retrieved from your Dynamics 365 Sales organization for the selected regarding entity.   
The following reminder insight cards are supported:    
<table>
<tr>
<td>{activity} due today</td><td>Buying intent detected in email</td><td>Close date coming soon</td>
</tr>
<tr>
<td>Competitor mentioned</td><td>Email opened</td><td>Email reminder</td>
</tr>
<tr>
<td>File requested</td><td>Issue detected</td><td>Meeting requested</td>
</tr>
<tr>
<td>Missed (opportunity) closed date</td><td>Missed email</td><td>No activity with {record type}</td>
</tr>
<tr>
<td>Opportunity at risk (phrase detection)</td><td>Opportunity at risk (sentiment detection)</td><td>Suggested stakeholder</td>
</tr> 
<tr>
<td></td><td></td><td></td>
</tr>
</table>   

To know more about the insight cards, see [Insight cards reference](https://docs.microsoft.com/dynamics365/ai/sales/action-cards-reference)   

### See also   

[Use the Dynamics 365 Sales mobile app](../sales-mobile/use-sales-mobile-app.md)    
[Manage contacts](create-contact.md)   
[Manage records or regarding entities](open-record.md)
