---
title: "Run webinars and meetings with Microsoft Teams (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create and host live events in Dynamics 365 Marketing using Microsoft Teams as the webinar provider"
keywords:
ms.date: 08/03/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
ms.assetid: 361dea50-9093-4668-910c-50f715fdd572
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Set up a Microsoft Teams webinar

> [!IMPORTANT]
> Early access features are currently available only on opted-in instances. You can opt in for early access on any instance, but we recommend that you do so only on trial, test, or sandbox instances, which will give you a chance to learn the new functionality before it shows up on your production instances later this year.
>
> For instructions on how to opt in and enable early access, see [Opt in to early access updates](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates). For more information about the 2020 release wave 2 schedule, and for answers to frequently asked questions about the early access program, see [2020 release wave 2 features available for early access](https://docs.microsoft.com/dynamics365-release-plan/2020wave2/features-ready-early-access).
>
> We encourage all customers to provide feedback related to early access features on the [Dynamics 365 Marketing Forum](https://community.dynamics.com/365/marketing/f/dynamics-365-for-marketing-forum), your Microsoft contact or partner, and/or through [Microsoft Support](https://docs.microsoft.com/power-platform/admin/get-help-support).

This article explains how to use Microsoft Teams as an online meetings provider for Dynamics 365 Marketing events. Teams event functionality is now incorporated directly into Marketing, allowing you to host Teams live events for webinars and Teams meetings for interactive online meetings.

> [!NOTE]
> To use Microsoft Teams as a webinar provider, you have must a [Microsoft 365 license](https://docs.microsoft.com/office365/servicedescriptions/teams-service-description) that allows you access to the Teams service.

## Create an online event

To create a Teams event, click on **Events** in the left navigation pane of the Marketing app. Then click on **+New** in the ribbon. You will see a new banner highlighting that Teams is available as a streaming provider.

![Teams webinar banner](media/teams-webinar-banner.png "Teams webinar banner")

> [!NOTE]
> The field **Event Format** is hidden from the event form and is automatically set. Set the **Do you want to stream this event** toggle to **Yes**, and it will show the streaming options.

## Event streaming options

After you flip the **Do you want to stream this event** toggle to **Yes**, you will have three options for selecting the streaming provider.

### Teams live events

Use Teams live events to create webinar style online meetings. Live event presenters can share content, video, and audio. Attendees can view the content, but cannot share their own audio, video, or content. 

Live events are useful for conference keynotes or meetings where a few presenters are presenting to a large audience. The audience can optionally submit questions using the Q&A feature for the live event. More information on Teams live events: [What are Microsoft Teams live events?](https://docs.microsoft.com/microsoftteams/teams-live-events/what-are-teams-live-events)

> [!NOTE]
> You can only create “public” Teams live events from Dynamics 365 Marketing. These events are open to anyone. Attendees are not required to sign in to attend the event.

#### Live event settings

![Teams live event settings](media/teams-webinar-live-event-settings.png "Teams live event settings")

| Setting                                         | Description                                                                                        |
|-------------------------------------------------|----------------------------------------------------------------------------------------------------|
| Recording available to producers and presenters | A downloadable recording will be made available to producers for 180 days after the event is over. |
| Recording available to attendees                | Attendees can watch the event on demand using DVR options for 180 days.                            |
| Attendee engagement report                      | You can download a report that tracks attendee participation.                                      |
| Q&A                                             | Attendees can interact with producers and presenters in a moderated Q&A.                           |

More information on details and settings for Teams live events: [Schedule a Teams live event](https://support.microsoft.com/office/schedule-a-teams-live-event-7a9ce97c-e1cd-470f-acaf-e6dfc179a0e2)

**Notes**:

- Captions configuration options (Teams preview feature) are not available when creating live events from Dynamics 365 Marketing.
- The attendee engagement report includes downloadable CSV details of attendees. The report details may slightly differ from the auto-generated check-in information in Marketing.
- The **Teams meeting owner** is the user who originally created the live event in Marketing. The Teams meeting owner is designated as the owner of the event in Teams. Changing the owner of the event record in Marketing does not change the owner of the live event in Teams.
- The event planner cannot assign the Teams meeting owner.
- Events created in the Marketing app's event management are not available in the Teams calendar for owners, producers, or attendees.

### Teams meetings

The Teams meetings option allows you to create an interactive online meeting experience where all attendees are able to share audio, video, or content. More information about Teams meetings: [Meetings in Microsoft Teams](https://docs.microsoft.com/microsoftteams/tutorial-meetings-in-teams)

### Others

If your organization has already set up a webinar provider (using ON24), you can find the existing webinar configurations after setting the streaming provider to **Other**. Doing so reveals the classic “Webinar Configuration” settings. More information on the classic webinar settings: [Set up a webinar](set-up-webinar.md)

## The Teams live event or meeting attendee link

The Teams attendee URL is created when you save a Marketing event that is being streamed with Teams. You can navigate to the Teams live event or meeting using the attendee URL.

## Adding presenters and producers to a Teams live event

In a Teams live event, a presenter is a person who presents audio, video, or a screen to the live event, or moderates Q&A. Presenters can only share audio, video, or a screen (desktop or window) in live events produced in Teams.

A producer is a host that makes sure attendees have a great viewing experience by controlling the live event stream.

More about Teams roles: [Get started with Microsoft Teams live events](https://support.office.com/article/get-started-with-microsoft-teams-live-events-d077fec2-a058-483e-9ab5-1494afda578a?ui=en-US&rs=en-US&ad=US#bkmk_roles)

Adding a presenter or a producer to a Teams live event is simple.

- If you want another user to have the ability to produce the live event, you can add the producer user as a Event Team Member. This will only work when the Event Team Member is a Dynamics 365 Marketing and Microsoft Teams user.
- If you want to invite another person to present to the live event, add them as a speaker to the event or the session. To add the person as a speaker, create a speaker engagement at the event (or session) level. The speaker is added as the “presenter” for the live event. Ensure that the speaker email ID is filled in.
- You can invite the presenters and producers of your live event to present the event by sharing the attendee URL with them. The attendee URL is displayed on the event form after the event is saved for the first time.

> [!NOTE]
> To invite a registrant to join the event, do not share the attendee URL directly. Instead, use the method [described below](teams-webinar.md#inviting-registrants-to-attend-the-live-event-through-email).

## Inviting registrants to attend the live event through email

After creating the event, going live with it, and gathering registrations, you should [send the registrants an email](email-design.md) to provide the attendee URL. In the Marketing email designer, you will find a new **Teams check-in** element in the new **Events communication** area.

The **Teams check-in** button generates a unique attendee URL for each registrant. When the registrant clicks the button, Marketing will create a relevant check-in record for them, giving insights about the attendance of the live event in Marketing.

**To create a Teams check-in button**:

1. Create [a new email](email-design.md) in the email editor.
1. In the **Toolbox** pane, go to **Events communication** and drag and drop the **Teams check-in** element into the email. This will create a check-in button.

    ![Teams check-in element](media/teams-webinar-check-in-element.png "Teams check-in element")

3. In the **Properties** pane, select the Event or Session you want the customer to join. (Note: the Event or Session needs to be set to a Teams live event or meeting and must be in “Live” state before you can select it). Design the button according to the design of the email.

    ![Teams check-in button options](media/teams-webinar-check-in-options.png "Teams check-in button options")

4. To preview the button in the **Preview** panel, select a contact that has a registration for the selected Event or Session.

> [!TIP]
> The email with the Teams check-in button should be shared shortly before the event start time, not days in advance. If the email is shared too far in advance, contacts may click on the button and create automated check-ins, only to receive a notice that the “Live event has not started yet.”

## Keeping Dynamics 365 Marketing and Teams in sync

A user who has access to an event record and permissions to edit the record can make any change to a record. However, since the same user may not have created the corresponding Live Event/Meeting in Teams (and thus may not be the “Teams Meeting owner”) – the changes they made to the event record in Dynamics would not get propagated to Teams (similar to how a user cannot make changes to a Live Event or Meeting created by another user in Teams itself).

When such a scenario arises, the Marketing application would display a warning to any user who is not the Teams Meeting owner. When the user who is the “Teams Meeting owner” for that event opens the event record, they would see a “Sync with Teams” button in the ribbon. Clicking on this button would sync the changes made to the event by any “non-owner” users.

> [!NOTE]
> Teams meeting owners are set to the user who creates the live event or meeting in Dynamics 365 Marketing. You cannot change the owner once the event has been created. This is different from the owner of the event record in Marketing.

## Viewing the event recording

Once the live event is over, the attendees can view the recording of the event by navigating to the attendee URL from their email. The recording will be available if the creator of the live event in Marketing sets the **Recording available to attendees** flag to **Yes**.

### See also

[Event management settings](events-settings.md)  
[Set up a webinar](set-up-webinar.md)