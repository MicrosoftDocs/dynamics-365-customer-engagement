---
title: "Event invitations, registrations, and hotel bookings (Dynamics 365 for Marketing) | Microsoft Docs"
description: "After your event is set up, learn how to invite attendees, register attendees, and enter hotel bookings in Dynamics 365 for Marketing"
keywords: events; event management
ms.date: 12/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 4844cf8c-bad1-4483-ba9b-e6e83874fd2b
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Invite, register, and house event attendees

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

After your event is fully modelled in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you're ready to start promoting it. The system provides many tools to help you do this.

## Invite contacts to your events

After your event is planned and set up, it's time to start promoting it! [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides several tools to help you do this:

- Create a marketing email message that includes an event element in its design. The event element creates a call-to-action button in your message that takes message recipients directly to your event website. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Prepare marketing email messages](prepare-marketing-emails.md) and [Event elements](content-blocks-reference.md#event-elements).
- Set up a customer journey that sends your marketing email message to all the relevant contacts, registers message interactions, and reacts to event registrations. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md).
- Create banners and social media posts to promote your event. Include a link to your event website in each post, and use the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] redirect-URL feature to create short URLs that register clicks with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and instantly forward contacts to your event website. You could create a different redirect URL for each social-media site, banner, or message, which would enable you to collect separate click results for each URL, so you can evaluate the success of each channel or initiative. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up redirect URLs](register-engagement.md#set-up-redirect-urls)

## Register attendees for events, sessions, and passes

Event registration enables attendees to sign up for your event and reserve their seats for specific sessions or tracks. It also helps you gauge interest in the event, and to signal demand to event planners for purposes such as capacity planning. Event managers can use registration records to evaluate in advance how many resources they'll need to have available, which sessions require larger rooms, or even whether a session should be canceled. Advance registration also enables attendees to be confident that their place is reserved for all the sessions they want to attend.

The [event website](set-up-event-portal.md) enables contacts to register themselves for any event that you are managing in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Depending on the [registration options](session-level-registration.md) you've chosen, attendees may be able to choose their schedule by selecting among available passes (each of which grants access to a different collection of sessions), or by selecting each session individually to assemble their own custom schedule. A simple event might just have one registration option that applies to all attendees. You can even implement [online payment](event-payment-gateway.md), but some custom development is required. [Waitlists](event-waitlist.md) are available for sold out events or sessions.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users can also register attendees manually by creating event registrations, session registrations, and pass assignments directly in the app. This lets you provide phone-based registration, for example. Manual registrations also enables users to bypass the [Waitlists](event-waitlist.md) if needed.

Each registration results in an event-registration record, which pulls together a registrant's profile, their passes, the sessions they'll attend, and, eventually, the sessions they did attend. Each registration record has a unique ID, which the system encodes into a QR code that you can embed in a registration-confirmation email sent to each registrant (see also [Event registration QR code elements](content-blocks-reference.md#qr-code)). You'll also find the QR code embedded in each registration record so you can use it in other contexts, such as to print badges to be handed out at the event. 

At the event, event organizers can scan the QR code presented by each attendee to capture the registration ID, which can then be used to verify the registration and/or register attendance at each event or session. The QR code provides only a registration ID, so event organizers must do some custom development to implement the verification, check-in, and registration features they need. One way to do this could be by creating a custom smartphone app.

To view all current registrations and pass assignments, and to create them manually in the system, work in either of the following entities of the [Events work area](open-events.md):

- **Events** > **Event** > **Event Registrations**: You can view and create registrations for all events here. 
- **Events** > **Event** > **Events**: Open an event record here and go to the **Registration & Attendance** tab to view and create registrations for the selected event. To view or create individual session registrations, go to the **Agenda** tab of the event record and open a session listed there.

## Set up segments for communicating with event attendees

As you prepare for (or follow up after) an event, you'll probably want to communicate with people who signed up for it from time to time. One good way to do this is to [set up a segment](segmentation-lists-subscriptions.md) to find the right attendees and then [create a customer journey](customer-journeys-create-automated-campaigns.md) that sends [email messages](prepare-marketing-emails.md) to them, sets up follow-up activities, and more.

To create segments that find contacts associated with event entities, your system must synchronize event-related entities with the marketing insights service. If your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] instance isn't already set up to sync the required event entities, then please talk to your admin about setting this up. If you are the admin, then see [Choose entities to sync with the marketing insights service](marketing-settings.md#dci-sync) for instructions. The primary event entity (Event) is normally set to sync by default, but the event registration entity (Event Registration), which can be useful for communicating with registered contacts, is not.

## Book hotel rooms for staff, speakers, and guests

If your organization has set up hotels and room allocations for your event in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you can view and create room bookings by going to **Events** > **Logistics** > **Hotel Room Reservations**. Each room booking links an event-registration record (and its associated contact) to a hotel room allocation set up in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Each room allocation represents a block of rooms of a specific type (single, double, or suite) at a specific hotel during a specific event. After all the rooms in an allocation are booked, that allocation is considered sold out unless you can request more from that hotel. Room bookings don't specify a room number, just a room type (based on allocation) and a unique reservation number.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage attendee logistics and accommodation availability](manage-event-logistic.md)

### See also

[Prepare marketing email messages](prepare-marketing-emails.md)  
[Event elements](content-blocks-reference.md#event-elements)  
[Create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Set up the event website](set-up-event-portal.md)  
[Create an interactive customer journey with triggers and signup](create-interactive-customer-journey.md)
