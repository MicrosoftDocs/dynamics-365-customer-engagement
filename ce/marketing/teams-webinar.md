---
title: "Run webinars and meetings with Microsoft Teams (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create and host live events in Dynamics 365 Marketing using Microsoft Teams as the webinar provider."
ms.date: 01/31/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Use Microsoft Teams for Dynamics 365 Marketing online events

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/RE4J4cV" frameborder="0" allowfullscreen=""></iframe></div>

[!INCLUDE[marketing-trial-cta](../shared/trials/marketing-trial-cta.md)]

This article explains how to use Microsoft Teams as an online meeting provider for Dynamics 365 Marketing events. Teams event functionality is incorporated directly into the Marketing app, allowing you to use Teams webinars or Teams live events for one/some to many online events, and Teams meetings for interactive online meetings.

For general information about setting up Microsoft Teams, refer to the [Microsoft Teams deployment overview](/microsoftteams/deploy-overview).

> [!NOTE]
> To use Microsoft Teams as an online event provider, you must have a [Microsoft 365 license](/office365/servicedescriptions/teams-service-description) that allows you access to the Teams service. If you do not have the correct license, you will not see the Teams webinar, Teams meeting, or Teams live event options as a part of the **Streaming provider** list.

## Create an online event

To create a Teams event, select **Event planning** in the Marketing app area switcher, then select **Events** in the left navigation pane. Select **+New** in the top ribbon.

> [!NOTE]
> The **Event Format** field is hidden from the event form and is automatically set. To see the streaming options, set the **Do you want to stream this event** toggle to **Yes**. If you are using a custom form, ensure that you hide this field and set the value to **Hybrid event**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Azure resource groups.](./media/teams-webinar-stream2.png)

## Event streaming options

After you flip the **Do you want to stream this event** toggle to **Yes**, you’ll have three streaming options: Teams webinar, Teams meeting, and Teams live event.

### Teams webinar

Use Teams webinars to create online presentations. One or multiple presenters can share content, videos, and audio. Participants can view the content and optionally engage with the presenters. Audiences engage through reactions, posting in the chat, or answering poll questions. Attendees can’t share their own audio, video, or content.

Webinars are useful for conference keynotes or meetings where a few presenters are talking to a large audience. Webinars can support up to 1,000 attendees.

> [!NOTE]
> You can only create "public" Teams webinars from Dynamics 365 Marketing. These events are open to anyone who is registered for the event.

#### Enable Teams webinars in Dynamics 365

To enable Teams webinars, the Teams tenant administrator must set the policies listed below. These settings ensure that anyone, including anonymous users, can register for webinars. To implement the settings, run the following PowerShell commands:

1. Turn on meeting registration:

```powershell
Set-CsTeamsMeetingPolicy -AllowMeetingRegistration $True
```

2. Turn on private meeting scheduling:

```powershell
Set-CsTeamsMeetingPolicy -AllowPrivateMeetingScheduling $True
```

3. Allow anyone, including anonymous users, to register for webinars:

```powershell
Set-CsTeamsMeetingPolicy -WhoCanRegister Everyone
```

Read more: [Set up for webinars in Microsoft Teams](/microsoftteams/set-up-webinars).

#### Webinar settings

The default webinar settings are configured to provide the best attendee and presenter experience. However, you can easily tweak these settings from your Dynamics 365 Marketing event. To change the default settings, set the **Change meeting options** switch to **Yes**. This reveals the webinar settings, which you can adjust on a per-event basis.

> [!div class="mx-imgBorder"]
> ![Screenshot of Webinar settings.](./media/teams-webinar-webinar-settings.png)

Read more: [Manage meeting settings in Microsoft Teams](/microsoftteams/meeting-settings-in-teams).

#### Webinar roles

| Role name                    | What do they do?                                                                                   | How to create them? |
|------------------------------|----------------------------------------------------------------------------------------------------|----------------------------|
| Event owner                  | The user who owns the event record in Dynamics 365 Marketing. | Set the event owner using the **Assign** button on the event ribbon. |
| Teams meeting owner          | The user who created and *saved* the record after choosing the webinar option in Marketing. Changing the owner of the event record in Marketing doesn’t change the owner of the webinar in Teams. Any change to the event record in Marketing will only reflect in Teams when done by the owner or when they select **Sync to Teams**. | Sign in as this user in Dynamics 365 Marketing and create a new event with a webinar or meeting stream. |
| Presenter                    | In a Teams webinar, a presenter is a person who presents audio, video, or a screen to the live event, or moderates the Q&A. Presenters can only share audio, video, or a screen (desktop or window) in webinars produced in Teams.| If you want to invite another person to present to the webinar, add them to the event or session as a speaker. To add a speaker, create a speaker engagement at the event (or session) level. The speaker is added as a “presenter” for the webinar. Ensure that the speaker's email ID is filled in.

#### Invite a guest to present in a webinar

- Ensure that the guest user is added to your Teams instance. You only have to do this once. Learn more about adding guest users: [Guest to present](/microsoftteams/teams-live-events/plan-for-teams-live-events#guest-to-present).
- As a best practice, Teams recommends that you create a channel for producers and presenters so they can chat and share information before the event. Guests who don't have Microsoft 365 credentials won't see the calendar in Teams. To make it easy for guests to join the event, producers can post the event link to the channel. Presenters can then open Teams, go to the channel, and select the link to join the webinar.
- Add a guest as a presenter in your webinar by adding them as a speaker in your event or session in Dynamics 365 Marketing using the steps detailed in the table above.

#### View webinar engagement data

After you run a Teams webinar-based Dynamics 365 Marketing event, you can view the attendee engagement data (check-in and check-out times) in the Marketing app.

To generate the engagement data, send an email invite to webinar registrants before the event that contains the webinar **Join in Teams** link. See [Inviting registrants to attend the Teams event through email](teams-webinar.md#inviting-registrants-to-attend-the-teams-event-through-email) for details about creating an invite email in the Marketing email designer.

10 minutes after the webinar ends (based on the end date configured in the Marketing app), the Marketing app will automatically populate the engagement data for attendees.

> [!IMPORTANT]
> Organizations that manage their Teams user policies need to make sure that the admin enables the **allowTrackingInReport** and **allowEngagementReport** policies before synchronizing the engagement data. For more information, see [Set-CsTeamsMeetingPolicy](/powershell/module/skype/set-csteamsmeetingpolicy).

> [!NOTE]
> Check-out times are only supported for Teams webinar events (with streaming enabled). Live events, Teams meetings, or any other event types do not have automatic check-out times.

#### Known issues with Teams webinars

After creating a Teams webinar Dynamics 365 Marketing event, you can see it on your Teams calendar. It may look slightly different than you expect:

- There’s no webinar icon on the calendar item; it looks like a regular meeting.
-	The meeting details page is missing several sections like the meeting options tab, a link to the registration form, and the existing registrations file to download.

The discrepancies in appearance are styling issues that won't limit the functionality of the webinar. Until the webinar experience is updated in future releases, use the following guidelines to manage your webinar:

-	The Teams calendar item created for your event is read-only. Synchronization between Teams and Dynamics 365 works in one direction: from Dynamics 365 to Teams. Changes you apply in Teams won't take effect on the Dynamics 365 side and may be overwritten. For this reason, use Dynamics 365 Marketing to manage and edit your event. This includes configuring meeting settings, creating a registration form, and adding speakers or presenters to your event.
- You may notice that landing pages for Teams meetings and webinars look the same. This is expected. The in-meeting experience is the same for a traditional meeting and a webinar. Your webinar will take place as you structured it with the roles of the attendees.
- After you add a speaker engagement to your webinar through Dynamics 365, the meeting options in Teams will become visible. The calendar item will still be read-only in Teams. Make sure you edit your webinar only in Dynamics 365 Marketing.

### Teams meetings

The Teams meetings option allows you to create an interactive online meeting experience where all attendees can share audio, video, or content. More information about Teams meetings: [Meetings in Microsoft Teams](/microsoftteams/tutorial-meetings-in-teams).

After selecting Teams meetings as the streaming provider for your event, you can view and edit the meeting options inside Dynamics 365 Marketing, just as you would with a webinar.

> [!div class="mx-imgBorder"]
> ![Teams meeting settings.](./media/teams-webinar-meetings-settings.png)

After you save your event, your settings will be reflected in your Teams calendar item.

> [!NOTE]
> Synchronization between Teams and Dynamics 365 Marketing works in one direction: from Dynamics 365 Marketing to Teams. The Teams calendar item for your event is read-only. Any changes you make in Teams may be overwritten by Dynamics 365 Marketing. Make sure to manage and edit your meeting only from the Marketing app.

### Teams live events

> [!NOTE]
> We recommend that you use Teams webinars for your presentation event needs. Although Teams live events are still available, Teams webinars provide richer functionality (such as the ability to use [breakout rooms](https://support.microsoft.com/office/use-breakout-rooms-in-teams-meetings-7de1f48a-da07-466c-a5ab-4ebace28e461)) out of the box.

You can use Teams live events to create webinar-style online meetings. Live event presenters can share content, video, and audio. Attendees can view the content, but can’t share their own audio, video, or content.

Live events are useful for conference keynotes or meetings where a few presenters are presenting to a large audience. The audience can submit questions using the Q&A feature for the live event. More information on Teams live events: [What are Microsoft Teams live events?](/microsoftteams/teams-live-events/what-are-teams-live-events).

> [!NOTE]
> You can only create "public" Teams live events from Dynamics 365 Marketing. These events are open to anyone. Attendees are not required to sign in to attend an event.

#### Enable Teams live events in Dynamics 365 Marketing

To enable Teams live events, the following policies need to be set by the Teams tenant administrator. Dynamics 365 Marketing only supports creating public live events. These settings ensure that anyone can watch the event, including anonymous users.

To allow anyone to watch the live event, run the following PowerShell command:

```powershell
Set-CsTeamsMeetingBroadcastPolicy -BroadcastAttendeeVisibilityMode Everyone
```

To enable live event scheduling, run the following command:

```powershell
Set-CsTeamsMeetingBroadcastPolicy -AllowBroadcastScheduling $true
```

To allow the option to disable meeting recordings, run the following command:

```powershell
Set-CsTeamsMeetingBroadcastPolicy -BroadcastRecordingMode UserOverride
```

You can also apply these settings in the Teams admin center:

> [!div class="mx-imgBorder"]
> ![Teams admin center.](./media/teams-webinar-admin-center.png)

Read more: [Set up for live events in Microsoft Teams](/microsoftteams/teams-live-events/set-up-for-teams-live-events).

#### Live event settings

> [!div class="mx-imgBorder"]
> ![Teams live event settings.](./media/teams-webinar-live-event-settings2.png)

| Setting                                         | Description                                                                                        |
|-------------------------------------------------|----------------------------------------------------------------------------------------------------|
| Recording available to attendees                | Attendees can watch the event on-demand using DVR options for 180 days.                            |
| Do you want to enable Q/A for this event                                             | Attendees can interact with producers and presenters in a moderated Q&A.                           |
| Attendee URL                      | The URL that attendees will use to join the live event.                                      |

More information on details and settings for Teams live events: [Schedule a Teams live event](https://support.microsoft.com/office/schedule-a-teams-live-event-7a9ce97c-e1cd-470f-acaf-e6dfc179a0e2).

#### Live events roles

| Role Name                    | What do they do?                                                                                   | How to set them up? |
|------------------------------|----------------------------------------------------------------------------------------------------|----------------------------|
| Event owner                  | The user who owns the event record in Dynamics 365 Marketing. | Set the event owner using the **Assign** button on the event ribbon. |
| Teams meeting owner          | The user who created the live event in Marketing. The Teams meeting owner is designated as the owner of the event in Teams. Changing the owner of the event record in Marketing doesn’t change the owner of the live event in Teams. Any change to the event record in Dynamics 365 will only reflect in Teams when done by this user or when they select **Sync to Teams**. | Sign in as this user in Dynamics 365 Marketing and create a new event with a live event or meeting stream. |
| Presenter                    | In a Teams live event, a presenter is a person who presents audio, video, or a screen to the live event, or moderates Q&A. Presenters can only share audio, video, or a screen (desktop or window) in live events produced in Teams.| If you want to invite another person to present to the live event, add them as a speaker to the event or the session. To add the person as a speaker, create a speaker engagement at the event (or session) level. The speaker is added as the “presenter” for the live event. Ensure that the speaker's email ID is filled in.
| Producer                     | A producer is a host that makes sure attendees have a great viewing experience by controlling the live event stream. If you want another user to have the ability to produce the live event, you can add the producer user as an **Event Team Member**. This will only work when the Event Team Member is a Dynamics 365 Marketing and Microsoft Teams user. On the event, navigate to the **Additional information** tab and add the team members. Team members can have any role in Dynamics 365 Marketing, but they’ll always be producers in the Teams live event. |

> [!Important]
>
> **Join in Teams** buttons [generated in the Dynamics 365 Marketing email editor](teams-webinar.md#inviting-registrants-to-attend-the-teams-event-through-email) *cannot* be used for sending live event links to presenters or producers. Buttons generated in the email editor only work for attendees. Presenters or producers can access the live event by following the custom link in their calendar or in the Marketing app by going to **Events** > **Streaming URL**.

**Notes**:

- Caption configuration options (Teams preview feature) aren’t available when creating live events from Dynamics 365 Marketing.
- More about Teams roles: [Get started with Microsoft Teams live events](https://support.microsoft.com/office/get-started-with-microsoft-teams-live-events-d077fec2-a058-483e-9ab5-1494afda578a?#bkmk_roles).

#### Invite a guest to present in a live event

- Ensure that the guest user is added to your Teams instance. You only have to do this once. Learn more about adding guest users: [Guest to present](/microsoftteams/teams-live-events/plan-for-teams-live-events#guest-to-present).
- As a best practice, Teams recommends that you create a channel for producers and presenters so they can chat and share information before the event. Guests who don't have Microsoft 365 credentials won't see the calendar in Teams. To make it easy for them to join the event, producers can post the event link to the channel. Presenters can then open Teams, go to the channel, and select the link to join the event.
- Add a guest as a presenter in your live event by adding them as a speaker in your event or session in Dynamics 365 Marketing using the steps detailed above.

### Using other webinar providers

If your organization has already set up a webinar provider (using ON24), you can find the existing webinar configurations after setting the streaming provider to **Other**. Doing so reveals the classic **Webinar Configuration** settings. More information on the classic webinar settings: [Set up a webinar](set-up-webinar.md).

## Accessing a Teams live event or meeting attendee link

The Teams attendee URL is created when you save a Marketing event that is being streamed with Teams. You can navigate to the Teams live event or meeting using the attendee URL.

> [!NOTE]
> To invite a registrant to join the event, do not share the attendee URL directly. Instead, use the [email invitation method described below](teams-webinar.md#inviting-registrants-to-attend-the-teams-event-through-email).

## Calendar integration

Once a live event or meeting is created or updated and the producers and presenters are added (by adding team members and speakers), the meeting will show up in their Outlook calendar and in their Teams calendar. The calendar item is a **read-only** version of the event. Changes made to the event from the Teams meeting owner's calendar won’t update the event in Dynamics 365 Marketing. Speakers and team members can join the live event from their calendars.

> [!NOTE]
> Presenters that are guest users will not see the event on their calendar. To share the event link with guest users, send them the [attendee link from the event in Dynamics 365 Marketing](teams-webinar.md#accessing-a-teams-live-event-or-meeting-attendee-link).

> [!IMPORTANT]
> The calendar integration feature for producers and presenters is not affected by the **Calendar content** field in the **Additional information** tab in the event planning work area. The **Calendar content** field only affects .ics files sent through the email designer. Learn more: [Generate iCalendar files for events and sessions](add-to-calendar.md).

## Inviting registrants to attend the Teams event through email

After creating the event, going live with it, and gathering registrations, you should [send the registrants an email](email-design.md) to provide the attendee URL. In the Marketing email designer, you’ll find a **Join in Teams** option in the **Link to** menu for the button element.

The **Join in Teams** button generates a unique attendee URL for each registrant. When the registrant selects the button, the Marketing app creates a relevant check-in record for them, giving insights about the Teams event attendance in Marketing.

> [!IMPORTANT]
> The **Join in Teams** button uses a unique URL for each registrant. Forwarding an email with a **Join in Teams** button retains the URL specific to the original recipient. The forwarded email will not generate a new check-in for the forwarded invite. To ensure your event is ready to capture all attendee information, see [Make the most of your event check-in flow](optimize-check-in.md).

> [!TIP]
> If an attendee selects the **Join in Teams** button *more than 120 minutes* before the event starts, the check-in *won't* be created. This is a hard-coded feature to prevent accidental check-ins when a recipient tests the link after they receive the email.

### Create a Join in Teams button

1. Create [a new email](email-design.md) in the email editor.
1. In the **Toolbox** pane, go to **Elements** and drag and drop a **Button** element into the email.
1. The **Edit button** options will appear in the right pane. For the **Link to** option, select **Join in Teams**.

    > [!div class="mx-imgBorder"]
    > ![Join in Teams button](media/teams-webinar-join-in-teams.png "Join in Teams button")

1. In the **Edit button** pane, open the **Type** dropdown and select whether you want the button to link to an **Event** or a **Session**.
1. Select the specific event or session you want the customer to join. Next, enter the text label for the button and adjust the design to correspond with the email.

    > [!NOTE]
    > The event or session needs to be set to a Teams live event or meeting and must be in a "Live” state before you can select it.

    > [!div class="mx-imgBorder"]
    > ![Join in Teams button options.](media/teams-webinar-event-or-session.png "Join in Teams button options")

1. To preview the button in the **Preview and test** panel, select a contact that has a registration for the selected event or session.

## Keeping Dynamics 365 Marketing and Teams in sync

A user who has access to an event record and permissions to edit the record in Dynamics 365 Marketing can make any change to a record. However, since the same user may not have created the corresponding live event or meeting in Teams (and thus may not be the "Teams Meeting owner"), the changes the user makes to an event record in Marketing aren’t propagated to Teams. This functionality is similar to functionality within Teams, where a user can’t make changes to a live event or meeting created by another user.

In scenarios where event record changes aren’t propagated to Teams, the Marketing app displays a warning to any user who isn’t the Teams meeting owner. If Teams meeting owner opens the event record, they’ll see a **Sync with Teams** button in the ribbon. Selecting the **Sync with Teams** button syncs the changes made to the event by any non-owner users.

> [!NOTE]
> The Teams meeting owner is set to the user who creates the live event or meeting in Dynamics 365 Marketing. You cannot change the owner once the event has been created. This is different from the owner of the event record in Marketing.

## Viewing the event recording

Once the live event is over, attendees can view the event recording by navigating to the attendee URL from their email. The recording will be available if the creator of the live event in Marketing sets the **Recording available to attendees** flag to **Yes**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]