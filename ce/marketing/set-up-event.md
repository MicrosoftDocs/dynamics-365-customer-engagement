---
title: "Initial and ongoing event planning (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to plan an event (including: register basic info; set up your team; manage sessions and speakers; set the event schedule; issue passes;  and manage venues) in Dynamics 365 for Marketing"
keywords: "events; event management"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a3d1dc05-8a69-43dd-94ee-a36ea4de650e
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom: dyn365-marketing
---

# Set up an event

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

To get started planning an event with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you start by creating an event record, which collects all of your planning details, gives links to related records, and provides a business-process timeline that helps guide you through each step of the event-planning process. Then you set up your event team, manage speakers and sessions, set up event passes, and set up a venue.

## Create the root event record

The first thing you'll do when setting up your event in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is to set up an event record. Everything that you do related to a given event will either be stored directly in the event record itself, or stored in other records that are linked to that event.

Though the solution offers many different views into other record types, you'll probably do most of your work directly in the relevant event record because you'll be able to view and create most types of related recordS from here, and everything that you do will automatically be related to that event.

You can see a list of all your event records by going to **Events** &gt; **Event** &gt; **Events**, and from here you use the standard list-view controls to search, sort, and filter the list to find and open an existing event, or to create a new event record.

![Example of an event record](media/event-record.png "An example of an event record")

As with many other forms in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], the event form provides a summary of its most important settings at the top, where you'll also find the business workflow timeline, which helps organize your work at each stage of the event-management process. A standard business workflow for events is provided out of the box, but you can customize it to match the process in place at your organization.

The first time you create a new event, you must specify values for each of the required fields (marked with a red asterisk), and we recommend that you fill out the business-critical fields too (marked with a blue plus sign). All required and business-critical fields are available at the top of the page in the business workflow, where you can fill them out quickly and easily. All settings that you enter in the business workflow will also be visible among the other event details further down the page. You'll still be able to see and edit these settings even after you move forward to the next stage in the workflow.

After you enter values for all the required fields, you can save the record. You'll probably return to the event record many times over several days while you plan your event. Use the workflow as a to-do list and to track your progress during each stage.

The main body of the page repeats all the important information requested by, and shown in, the workflow, plus much more. It's organized into tabs, which you can navigate between by using the links provided near the top of the page body. You can enter your planning details in the main body of the page whenever you want to—you don't have to wait until you get to a specific part of the workflow. Here's how to work in each of the available tabs:

| **Tab**                     | **Use**  |
|---------------------------------|----------|
| **General**                     |Here you can see and edit your basic event information, including:<ul><li>**Key information**: Includes the name of your event and other basic details. Note especially the **Format** setting, which is where you can set up your event to include one or more webinars or webinar simulcasts.</li><li>**Schedule**: Specifies start and end dates.</li><li>**Additional information**: Gives a basic description and outlines your goals.</li><li>**Timeline**: Here you can build a record of the activities (such as calls, emails, and appointments) that you and others do in relation to the event. You can also share notes here. Use the links, buttons, and menus at the top of this area to create new items and to search and sort the list.</li><li>**Event team members**: Add links to coworkers and external contacts who are helping you organize the event. The table here shows each team member's name and role, so you can easily see who to call and find their contact info when needed. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up your event team](#set-up-your-event-team)</li></ul>|
| **Agenda**                      |This tab includes details about the schedule of sessions happening during your event. Here you can find tables for each of the following:<ul><li>**Sessions**: Each session is typically a single presentation, class, discussion, or webinar.</li><li>**Tracks**: Each (external) track is a collection of related, non-conflicting sessions that likely would be of interest to the same audience. Attendees might sign up for a specific track, which you can manage by using passes. You can also set up internal tracks, which are not exposed to attendees but can help you with your planning.</li><li>**Speaker engagements**: A list of people who will be speaking at the event. Select any of these to see which sessions a given speaker will be leading.</li><li>**Sponsors**: A list of companies who are sponsoring the event.</li></ul><p>Below the **Sessions** and **Tracks** tables are a few graphs for analyzing your session and track distributions.</p><p>[!INCLUDE[proc-more-information](../includes/proc-more-information.md)]</p><ul><li>[Manage event sessions and speakers](#manage-event-sessions-and-speakers)</li><li>[Set up event passes](#set-up-event-passes)</li><li>[Manage event sponsorships](manage-event-sponsorships.md)</li></ul>|
| **Organize**                    |Here you can view and specify details about the event venue, including its primary address and each of the rooms you'll be using. You'll also set up your webinars here.<p>[!INCLUDE[proc-more-information](../includes/proc-more-information.md)]</p><ul><li>[Set up the event venue and subvenues](#set-up-the-event-venue-and-subvenues)</li><li>[Set up a webinar](set-up-webinar.md)</li></ul>|
| **Registration and attendance** |Here you can see and create each type of pass you'll provide for the event, and view some analytics about them. Below this, you can see a list of registrations (select a listed registration for full details). Each registration tells you who the attendee is, which sessions and passes she signed up for, and (after the event) which sessions she attended.<p>[!INCLUDE[proc-more-information](../includes/proc-more-information.md)]</p><ul><li>[Set up event passes](#set-up-event-passes)</li><li>[Invite, register, and house event attendees](invite-register-house-event-attendees.md)</li></ul>|
| **Financials**                  |Here you can view and record budget details for your event. These values appear in dashboard charts and analytics for your events, but are intended for information only, not for formal accounting or bookkeeping.
| **Post-event**                  |Here you can view and create surveys related to your event. You'd typically use this to collect attendee opinions about how it went. A second table provides links to individual survey responses.</p><p>Surveys are provided by the Voice of the Customer feature. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and run online surveys](surveys.md)|

## Set up your event team

Your event team includes coworkers and external contacts who are helping you organize the event. Each event record lists each team member's name and role, plus links for more information, so you can easily see who to call and find their contact info when needed.

- You can view and edit the list of all team members who worked, are working, or will work on all your events by going to **Events** &gt; **Event** &gt; **Event Team Members**. Use this area to set up a database of people who are available to help with your various events.
- You can view and edit the list of team members associated with a specific event by going to **Events** &gt; **Event** &gt; **Events**, opening the appropriate event, and looking at the **Event Team Members** section of the **General** tab. The list on the **Events** page works the same as the list on the **Event Team Members** page, except that it only shows and adds team members who are assigned to the current event.

Each team member record can be associated with a contact or user record.

- *Users* are people who work for your organization and have a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] license.
- *Contacts* come from your contact database, which will include customers, potential customers, vendors, partners, and other external people (or internal people who don't use [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]).

When you create a new team member record, you'll be able to choose whether to associate it either with a user or a contact. If you choose to associate the record with a contact, the team-member record will display relevant information from that contact record. User records don't include any contact information, so if you associate the record with a user, the association will be shown but no additional information will be loaded. The team-member record also provides information about that member's role and which events he or she has worked on. You can create team members from either the **Event Team Members** list page or directly from a specific **Event** record.

When you're looking at a list view of team members, the list includes both a **User** and a **Contacts** column, but only one of these will show a value. From the list, you can go to the user or contact record by selecting the name in the list, or you can open the team-member record itself by double-clicking on a row anywhere away from the person's name.

## Manage event sessions and speakers

The core attractions of your event offering will typically be its sessions and speakers. A simple event might have just one session, whereas a conference will typically have several sessions spread over several days. A 

### Set up event sessions and tracks

A session represents a subdivision of things that are happening at your event. Each session is usually a something like a seminar or keynote, but the concept is actually quite flexible so you can adapt it as needed. For example, if your event is a trade show rather than a conference, you can use sessions to represent booths.

A large conference might have several sessions running concurrently, and might even feature several session *tracks*, which organize multiple related and non-conflicting sessions by audience so attendees can easily choose the best track for themselves without having to study the entire offering. Later, you'll be able up event and session passes to manage ticketing and enable attendees to choose a track.

There are two types of tracks: _internal_ and _external_. Use internal tracks during the planning phase to group sessions along organization lines, such as according to team resources or required equipment. Use external tracks to group sessions by content or audience, and to enable ticketing and registration. External tracks are published on customer-facing platforms such as event portals and mobile apps. As needed, you can set up a pass type for each relevant external track, but you wouldn't set up passes for internal tracks. Use the **Track Type** setting, at the top of the form to set the track to internal or external.

Use the **Agenda** tab of an event record to view and set up sessions and sessions tracks for that event. 

- Each session is associated with a specific event and speaker, and includes scheduling details.
- For each track, you can assign an audience and a few other descriptive details and then add member sessions, one at a time. All sessions in a track must be from the same event.


### Set up and assign session speakers

Use the following pages to manage your speakers and speaker engagements:

- **Events** &gt; **Participants** &gt; **Speakers**: Lists all speakers who are available for previous, current, or future events, and lets you set up new speakers.
- **Events** &gt; **Event** &gt; **Events**: Work on the **Agenda** tab of the appropriate event record to set up speaker engagements for that event. You can also create new speaker records here if needed while setting up speaker engagements.

Each speaker record can include a photo, contact details, and biographical details that you can eventually publish to the event portal for attendees to review. It also includes a record of all speaking engagements and sessions where the speaker has presented or will present. You can choose to link a speaker to a contact record, but it's not required. The contact, photo, and biographical information in the speaker record is independent from the contact record, so you can safely keep private contact information (possibly stored in the contact record) away from the public speaker information (stored in the speaker record) that will be published to your event portal. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up the event portal](set-up-event-portal.md)

When setting up a speaker engagement, you map a speaker to a specific session for the event record you are working with. To set up a speaker engagement:

- A speaker record must exist.
- If you're assigning a session, a session record must exist. (For single-session events, you might not have a session record and instead will treat the event itself as a session.)

## Set up event passes

Event passes are essentially tickets that you can sell or give away to grant access to your event and/or its various sessions and tracks. Passes are optional, but if you want to use them, you'll start by setting up the basic types of passes that you need for an event. Later, you'll assign a pass of the appropriate type to each attendee by mapping each event registration to one or more pass types. Passes can also be shown on the event portal, so attendees can register for the passes they want while registering for the event itself; in this case, the registration/pass mapping is made automatically. For each assigned pass, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] generates a unique QR code, which you can print onto a physical badge that event personnel can quickly scan on entrance to confirm eligibility and record attendance.

For each pass type, you'll set the event where it applies and then assign a category (attendee, speaker, sponsor, journalist, and so on), a price, an allocation (the number available), and other details. You can also assign a session track for the pass, which grants access to all the sessions in that track, but not necessarily to all sessions at the event. To create a pass that applies to a single session, you must create a track that includes just that session.

For a simple event, you might set up just one pass type, which grants access to all sessions for all types of attendees. For a complex event, you might have passes for each of several session tracks, and might require specific pass types for accessing certain areas of the venue (such as a lounge just for journalists). Passes only make sense for physical attendees—you wouldn't set up passes for webinar-only attendees, events, or sessions.

To view and create passes for an event, open the appropriate event record and go to its **Registration & Attendance** tab.

When setting up a pass, pay attention to the **Passes Allocated** field, where you set the number of passes available, and its related fields: **Passes Sold** and **Passes Remaining**. Each time a pass is granted to an attendee, the **Passes Sold** number automatically increases and the **Passes Remaining** number decreases. When **Passes Remaining** reaches zero, that pass will be shown on the portal as "sold out" and will no longer be available for purchase by further attendees. If you set **Passes Allocated** to zero, that pass won't be shown on the portal at all; you might do this for VIP passes, or to keep a pass as a draft until you're ready to publish it by setting **Passes Allocated** to a positive value.

## Set up the event venue and subvenues

A venue is any physical or virtual location where you hold an event or session. It might represent a collection of buildings, a single building, or a single room. For each venue, you can register many types of important details, including name, location, facilities, capacity, subvenues, events that will or have occurred there, and more. After you've set up a venue, you can assign events and sessions to it as needed.

Use the various types of venue entities in the **Events** &gt; **Venue Management** area to construct a hierarchical model of your event location. Later, you'll be able to assign events and sessions to each venue space from your model. A simple venue could be a single building with a single room, while a complex venue could include several buildings, each with several rooms with various layouts.

![Chart of venue structure and relations](media/venue-hierarchy-ill.png "Chart of venue structure and relations")

Use the following entities to model your venues:

- **Events** &gt; **Venue Management** &gt; **Venues**: Here you can see all types of venues that are available to be assigned to sessions. This list includes standalone venues (which are only listed here), but also buildings and rooms (which also exist as independent entities, as described later in this list). The system is very flexible, but you'd typically set up a venue record to represent a simple venue with no subvenues, but set up a building record with associated room records for events that have concurrent sessions. For a very complex location, you could set up a master venue with buildings as subvenues, each of which contains rooms as "sub-subvenues." Other than some restrictions on hierarchy structure, venues, buildings, and rooms all offer the same settings.
- **Events** &gt; **Venue Management** &gt; **Buildings**: Buildings represent free-standing structures that might or might not be divided into rooms. Each building that you see or create here is considered a type of venue, and is therefore also listed on the **Venues** page.
- **Events** &gt; **Venue Management** &gt; **Rooms**: Rooms represent subdivisions of buildings, and each must be assigned to a building record also stored in the system. Each room that you see or create here is considered a type of venue and is therefore also listed on the **Venues** page, where it's listed together with the building it belongs to with a name such as "My Building &gt;&gt; My Room".
- **Events** &gt; **Venue Management** &gt; **Layouts**: During an event, you might use a single room to host several types of sessions, each of which might require a different arrangement of chairs and other facilities. The room layout might have practical consequences that affect, for example, seating capacity. Each layout must be associated with a particular room, but you can set up any number of layouts for each room. Layouts aren't treated as venues, so you won't see them on the **Venues** page.
