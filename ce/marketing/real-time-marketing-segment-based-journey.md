---
title: "Create a segment-based journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a real-time marketing segment-based journey in Dynamics 365 Marketing."
ms.date: 04/01/2021
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

# Create a segment-based journey

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

Segment-based journeys can be used to create outbound journeys like sending out email blasts or a nurture campaign. To create journeys that can react to customers' actions in real-time see  [create an event-based journey](real-time-marketing-event-based-journey.md).

# Starting a segment-based journey

Customer's start a segment based journey when they qualify to be part of a segment.

**Audience**: The audience property lets you specify the segment of people that will start the journey. Segment based journeys support segments from outbound marketing as well as segments created in Customer Insights. The journey will use audience data based upon the segment selected. For example, if the journey is started with outbound marketing segments which contains a segment of Contacts then the journey will use Contacts as its Audience data. Similarly, if the journey is started using a Customer Insights segment which is a segment of Customer Profiles then the journey will use Customer Profile as its Audience data. Once an audience segment has been selected all other segments used in the journey must be of the same type (segment from outbound marketing or customer insights segment).





Exclude this segment: Members of this segment will not be allowed to start the journey. Specifying an exclusion segment lets you remove anyone from the Audience that starts the journey.

Frequency: Lets you specify whether the journey should repeat.

One time: One time journeys run only once with a static audience segment. This is useful for scenarios like one time email blasts that are sent on a specific date to a fixed set of customers.
Ongoing: Ongoing journeys run only once with a dynamic audience segment. This is useful for scenarios like nurture campaigns where anyone who gets added to the audience segment can start the journey as soon as they are added to the segment.
Repeating: These journeys repeat based on the time interval specified. Every time the journey repeats all the members of the audience segment will go through the journey. If any new members get added to the segment between the repeat interval then those new members will only go through the journey the next time the journey repeats. This type of journey is useful for scenarios like renewal reminders where you may want to send people through the journey everytime they are up for a renewal.
