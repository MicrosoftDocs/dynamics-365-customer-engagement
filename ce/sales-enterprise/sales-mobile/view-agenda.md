---
title: View meetings in the Dynamics 365 Sales mobile app
description: Learn how to view meetings in the Dynamics 365 Sales mobile app.
ms.date: 11/30/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# View meetings

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The information on the home page of the Dynamics 365 Sales mobile app can help you better plan your day. For example, the Meetings section displays your most recent meeting and the next upcoming meeting. To see more meetings for the day, tap **Meetings** either on the home page or on the navigation bar. Meetings that have been scheduled in Microsoft Outlook are displayed.    
> [!NOTE]
> - You can't create a meeting from the Dynamics 365 Sales mobile app.
> - The Meetings section only include meetings that have at least one attendee who's outside of your organization's domain.   
 
**To view meetings**

1.  On the navigation bar, tap **Meetings**. The calendar view opens.
    
    ![Meetings section](media/sm-meetings-nav-bar.png "Meetings section")
    
    The current meeting time is shown in blue with a triangle icon beside it. To see the details of a meeting, tap the meeting record.<!-- Edit note: Not seeing the triangle in the screenshot. -->
    
2.  To see meetings for a specific date, tap a date in the calendar.

    ![Select a date to see meetings](media/sm-select-date.png "Select a date to see meetings")
    
    If there are no meetings scheduled for the day, nothing is displayed.   

## View meeting details

To see details of a specific meeting, tap the meeting record on either the home page or in the calendar view. The meeting details are displayed, as shown in the following image.    
![Meeting details](media/sm-meeting-details.png "Meeting details")  

Meeting details include the following:<!-- Edit note: Maybe this should be a bullet list instead of numbered. -->

1. [Meeting information and attendees](#meeting-information-and-attendees)   
2. [Regarding entity, notes, and reminders](#regarding-entity-notes-and-reminders)

### Meeting information and attendees

>[!NOTE]
> The data that is displayed in this section is retrieved from your Microsoft Exchange server.

**Meeting information**

The meeting information section provides information about the meeting subject, location, time, and description. Tap the description section to show more details. Note that the meeting information can be viewed but cannot be edited in the app.

**Attendees**

Up to five meeting attendees are shown in the Attendees section, such as customers and the meeting organizer. You can see attendee acceptance status, such as accepted, tentative, declined, or no response. When you tap the name of an attendee, the quick view of their contact record opens. You can perform the following actions on the contact: view, edit, and create. More information: [Manage contacts](create-contact.md)            

### Regarding entity, notes, and reminders

>[!NOTE]
> The data that is displayed is related to the selected regarding entity and retrieved from your Dynamics 365 Sales organization.

**Regarding entity**

The Regarding section or entity specifies what the meeting is about, such as an opportunity, lead, contact, or account. When a meeting is attached to an entity, the meeting displays the timeline, insight, participant information, and corresponding related entities. Also, the regarding entity helps you to understand what the meeting is about, so you can come prepared with relevant information.

In the following screenshot, you can see that the meeting is about an opportunity to purchase 10,000 cars.<!-- Edit note: Actually should be convertible cars but can simplify in text, should fix the image. -->

> [!div class="mx-imgBorder"]
> ![View regarding entity](media/sm-view-regarding-entity.png "View regarding entity")

You can perform the following action on regarding entities: view, edit, change entity, and add entity. More information: [Manage records](open-record.md)   

**Notes**    

The Notes section for a meeting can be used to add notes related to a meeting, such as minutes from the meeting. You can add, edit, and delete notes. More information: [Manage notes](sales-mobile/view-edit-add-note.md)

**Reminders** 

Any reminders and insights related to the meeting are displayed in the Reminders section. For each card, you can tap the three dots on the left, **More options** (![Options button](media/sm-options-button.png "Options button")), to dismiss, snooze, and like or dislike the card. More information: [Notes and reminders](open-record.md#notes-and-reminders)

## See also   

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Manage contacts](create-contact.md)   
[Manage records](open-record.md)
