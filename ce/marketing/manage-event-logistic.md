---
title: "Manage event logistics (Dynamics 365 for Marketing) | Microsoft Docs  "
description: "How to manage event logistics (including vendors, hotels, room allocations, and reservations) in Dynamics 365 for Marketing"
keywords: "events; event management; logistics; hotel; reservation"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: article
ms.assetid: 84b8206a-4e9e-40fe-8a9e-d9a502990027
ms.reviewer: renwe
ms.custom:
  - dyn365-marketing
---
# Manage attendee logistics and accommodation availability

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Use the entities in the **Logistics** area to provide information that can help attendees from farther away to plan accommodation for their trip. Register local hotels, record their contact information, allocate sets of rooms that will be made available to attendees, and take reservations for the allocated rooms. You can also register various other types of attendee-facing vendors here, such as airlines, car rentals, food caterers, and more.

Logistics features are mostly informational, and they are not exposed directly to attendees through the standard event portal. For example, you can enter hotel reservations in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] based on communications you've had with attendees, but you'd still need to contact the hotel to let them know about the reservations.

Use the following entities to record and provide logistics services for attendees:

- **Events** &gt; **Logistics** &gt; **Event Vendors**: Enter and view event-vendor details here. Each event vendor must be associated with an account (external company) already recorded in your system. You can assign each vendor a type, such as hotel group, airline, car rental, and so on. 
    > NOTE
    > A *hotel group* is typically a company that operates a chain of hotel properties under the same name, such as Marriott. You can associate individual hotels with the hotel group type, as explained below. 
- **Events** &gt; **Logistics** &gt; **Hotels**: Enter and view details about specific hotel properties here. You can associate each hotel record with a contact from your database, so you'll know who to call if you have any questions for the hotel. You can associate the hotel record with a hotel group (event vendor) if the property is part of a group. The hotel group and contact details are shown here, if they are defined. You must always specify the hotel's address as part of its record. You can also view and add room allocations for the current hotel here.
- **Events** &gt; **Logistics** &gt; **Hotel Room Allocations**: Room allocations represent a block of rooms that the hotel has agreed to make available during your event. Each room allocation record specifies the number of rooms allocated and the type of rooms they are (single, double, or suite). Each allocation must be associated with a hotel that is registered in your database. If you have allocated several different room types in the same hotel, you must set up a separate allocation for each type. You can also view and add room reservations associated with the current allocation here.
- **Events** &gt; **Logistics** &gt; **Hotel Room Reservations**: Here you can reserve rooms for attendees from among the rooms you have allocated. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Book hotel rooms for staff, speakers, and guests](invite-register-house-event-attendees.md#book-hotel-rooms-for-staff-speakers-and-guests)
