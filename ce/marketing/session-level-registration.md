---
title: "Enable session-level registration and waitlisting for events (Dynamics 365 Marketing) | Microsoft Docs"
description: "Describes how to set up session-level registration and how it differs from event-level registration in Dynamics 365 Marketing."
ms.date: 04/01/2019
ms.service: dynamics-365-marketing
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

# Set up session-level registration and waitlisting

Session-level registration enables event organizers to give attendees the ability to assemble their own events from among all available sessions. In most ways, events with session-level registration work the same as those with event-level registration, but there are a few key differences, as outlined in the following table. Keep reading this topic for more information about these differences.

|   | **Event-level registration** | **Session-level registration** |
| --- | --- | --- |
| **Session&nbsp;selection&nbsp;during registration** | Preconfigured: Events can offer multiple passes, each of which provides access to a preselected collection of sessions. | Customized: Registrants choose exactly the sessions they want. |
| **Maximum capacity**<br/>(On-site only, not for webinar or hybrid events) | Set at the event level | Set at the session level |
| **Waitlists**<br/>(On-site only, not for webinar or hybrid events) | One waitlist per event | Individual waitlist per session |
| **Event passes** | Optional (required for online payment) | Not supported |
| **Online payment** | Optional, per pass | Not supported |
| **Registration list** | Available on the event record only | The event record lists each contact that registered for at least one session for that event; each session record shows registrations for that session. |

## Enable session-based registration

To enable session-based registration, start by [setting up the event](set-up-event.md) as usual, including basic settings and session schedule, but then go to the **Agenda** tab for the event and set **Allow registrants to create their own agenda** to **Yes**.

> [!NOTE]
> As mentioned in the introduction to this topic, session-based registration isn't supported for events that have passes defined. If you don't see the **Allow registrants to create their own agenda** setting, then it might be because you have one or more passes defined (you can see these on the **Registration and attendance** tab). If you define a pass after enabling session-based registration, then session-based registration will be disabled automatically.

## Set the maximum capacity for each session

With session-based registration, the system tracks registrations for each session rather than for the event as a whole. When session-based registration is enabled, the session capacity is a required field and is also requested by the quick-create form for sessions. However, if you enable session-based registration after creating the session, you may need to go back and set the capacity for each session.

When the system has received enough registrations to fill the capacity of the session, it will mark that session as sold out. If you enabled the waitlist, then registrants can choose to join the waitlist, but if you haven't then they won't be able to self-register for any sold out sessions using the event website. (Users of Dynamics 365 Marketing, however, can overrule the capacity limit by [adding new registrations directly](invite-register-house-event-attendees.md) into the system.)

To set or change the maximum capacity of a session:

1. Open the event record that that session belongs to.
2. Go to the **Agenda** tab.
3. Find the **Sessions** section of the **Agenda** tab and select a session.
4. In the **Venue** constraints area, enter a value for the **Maximum session capacity**.

**Note** : If you fill out any of the fields in the **Location area** ( **Building** , **Room** , and/or **Layout** ), then the initial value for the **Maximum session capacity** is automatically taken maximum capacity set for the most specific location (if available).

## View and edit event and session registrations

To view and edit registration details for a session-level event:

- To view all registrations for the event (people who registered for at least one session), open the relevant event record, go to the **Registration and attendance** tab and scroll to the **Event registration** section. You can also add or remove registrations from here.
- To view all registrations for a specific session), open the relevant event record, go to the **Agenda** tab, scroll to the **Sessions** list and select a session. In the open  session record, go to the Registration and attendance tab and scroll to the **Sessions registrations** list. You can also add or remove registrations from here.

## Session-level waitlists

The session-level waitlist works similarly to the event-level waitlist except that it manages a separate waitlist for each session. For details about how to set up and use the waitlist (including details about session-level waitlists) see [Set up and manage an event waitlist](event-waitlist.md). That topic also shows how to set up a customer journey that automatically lets contacts on the waitlist know when a spot has become available for them.

Session-level waitlist differ from event-level waitlists as follows:

- Waitlist members are shown on the session record rather than the event record. To see them, open a session, go to the **Registration and attendance** tab and scroll down to the **Waitlist** section. From here, you can add, remove, invite, and register attendees on the waitlist.
- If you'd like to create a segment of waitlisted or invited registrants for a session, use the session ID rather than the event ID.

### See also

[Event planning and management](event-management.md)  
[Set up an event](set-up-event.md)  
[Set up and manage an event waitlist](event-waitlist.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]