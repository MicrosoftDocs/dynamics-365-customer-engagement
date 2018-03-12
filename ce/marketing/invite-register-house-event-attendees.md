---
title: "Event invitations, registrations, and hotel bookings (Dynamics 365 for Marketing) | Microsoft Docs"
description: "After your event is set up, learn how to invite attendees, register attendees, and enter hotel bookings in Dynamics 365 for Marketing"
keywords: "events; event management"
ms.date: 04/01/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4844cf8c-bad1-4483-ba9b-e6e83874fd2b
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Invite, register, and house event attendees

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

After your event is fully modelled in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you're ready to start promoting it. The system provides many tools to help you do this.

## Register attendees for events, sessions, and passes

Event registration enables attendees to sign up for your event and reserve their seats for specific sessions or tracks. It also helps you gauge interest in the event, and to signal demand to event planners for purposes such as capacity planning. Event managers can use registration records to evaluate in advance how many resources they'll need to have available, which sessions require larger rooms, or even whether a session should be canceled. Advance registration also enables attendees to be confident that their place is reserved for all the sessions they want to attend.

Each registration results in an event-registration record, which pulls together a registrant's profile, their passes, the sessions they'll attend, and, eventually, the sessions they did attend. Each registration record has a unique ID, which the system encodes into a QR code that you can print onto attendee badges and passes for quick scanning during the event. You'll find the QR code embedded in the registration record.

After an attendee is registered for an event, they can then sign up for individual sessions at that event, provided they have the right pass. Each pass allows the purchaser to register for any or all sessions in the track associated with that pass, but it doesn't register the purchaser for any of those sessions. Passes with no track assigned allow access to all sessions. Each session page in the event portal provides a registration button to eligible users (it shows "not available" to others.) As with events, each session registration results in a session-registration record, which links an attendee's contact record and event registration to a session. As with event registration, each session registration also has a unique ID for which [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] automatically generates a QR code.

You can register attendees manually, by creating or importing new event registrations, session registrations, and pass assignments directly in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], or attendees can register themselves by using your event portal. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Import data](business-management-settings.md#import-data)

To view all current registrations and pass assignments, and to create them manually in the system, work in either of the following areas:

- **Events** &gt; **Event** &gt; **Event Registrations**: You can view and create registrations for all events here. 
- **Events** &gt; **Event** &gt; **Events**: Open an event record here and go to the **Registration & Attendance** tab to view and create registrations for the selected event. 

Each event registration record connects a contact to an event and shows related information including contact details, passes assigned, sessions registered for, session check-ins, and more. Each record has a unique event-registration ID, which is also provided as a QR code.

## Invite contacts to your events

After your event is planned and set up, it's time to start promoting it! [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides several tools to help you do this:

- Create a marketing email message that includes an event block in its design. The event block creates a call-to-action button in your message that takes message recipients directly to your event portal. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Prepare marketing email messages](prepare-marketing-emails.md) and [Event blocks](content-blocks-reference.md#event-blocks).
- Set up a customer journey that sends your marketing email message to all the relevant contacts, registers message interactions, and reacts to event registrations. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md).
- Create banners and social media posts to promote your event. Include a link to your event portal in each post, and use the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] redirect-URL feature to create short URLs that register clicks with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and instantly forward contacts to your event portal. You could create a different redirect URL for each social-media site, banner, or message, which would enable you to collect separate click results for each URL, so you can evaluate the success of each channel or initiative. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up redirect URLs](register-engagement.md#set-up-redirect-urls)

## Book hotel rooms for staff, speakers, and guests

If your organization has set up hotels and room allocations for your event in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you can view and create room bookings by going to **Events** &gt; **Logistics** &gt; **Hotel Room Reservations**. Each room booking links an event-registration record (and its associated contact) to a hotel room allocation set up in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Each room allocation represents a block of rooms of a specific type (single, double, or suite) at a specific hotel during a specific event. After all the rooms in an allocation are booked, that allocation is considered sold out unless you can request more from that hotel. Room bookings don't specify a room number, just a room type (based on allocation) and a unique reservation number.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage attendee logistics and accommodation availability](manage-event-logistic.md)

### See also

[Prepare marketing email messages](prepare-marketing-emails.md)  
[Event blocks](content-blocks-reference.md#event-blocks)  
[Create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Set up the event portal](set-up-event-portal.md)  
[Create an interactive customer journey with triggers and signup](create-interactive-customer-journey.md)