---
title: "Real-time marketing journey tile reference (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about real-time marketing tiles in Dynamics 365 Marketing."
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

# Real-time marketing journey tile reference

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

This article describes the various capabilities available in real-time marketing customer journeys. For complete examples of creating customer journeys see [Create an event-based journey](real-time-marketing-event-based-journey.md) and [Create a segment-based journey](real-time-marketing-segment-based-journey.md)

# Journey start

The journey start configuration lets you define how customers can start the journey.

## Event-based journey

- **Event trigger to start the journey**: Customers will start the journey as soon as the selected event trigger occurs.  

- **Repeating the journey**: Lets you configure how soon customers can repeat the journey, if the event trigger to start the journey occurs again. You can allow customers to repeat the journey immediately or only allow them to repeat the journey after a delay interval.

- **Exclude this segment**: Members of this segment will not be allowed to start the journey. This is a easy way to filter out certain segments of customers from starting the journey even if they performed the event trigger to start the journey.  

- **Journey Timing**: Lets you specify the time window in which customers can start the journey. Customers must perform the journey start event trigger after the start time to enter the journey. No new customers will be allowed to start the journey after the end time. The end time only affects when customers can start the journey, if a customer is already in the journey they will be allowed to continue the journey even after the end time.

## Segment-based journey

- **Audience**: This is the segment of people that will start the journey.

- **Exclude this segment**: Members of this segment will not be allowed to start the journey. Specifying an exclusion segment lets you remove anyone from the Audience that starts the journey.

- **Frequency**: Lets you specify whether the journey should repeat.
  - *One time*: One time journeys run only once with a static audience segment. This is useful for scenarios like one time email blasts that are sent on a specific date to a fixed set of customers.
  - *Ongoing*: Ongoing journeys run only once with a dynamic audience segment. This is useful for scenarios like nurture campaigns where anyone who gets added to the audience segment can start the journey as soon as they are added to the segment.
  - *Repeating*: These journeys repeat based on the time interval specified. Every time the journey repeats all the members of the audience segment will go through the journey. If any new members get added to the segment between the repeat interval then those new members will only go through the journey the next time the journey repeats. This type of journey is useful for scenarios like renewal reminders where you may want to send people through the journey everytime they are up for a renewal.

# Journey end

By default, customers will end the journey when they complete all the steps. You can set additional ways for customers to exit the journey by using event triggers or segments. 

- **Exit when an event occurs**: Customers who perform this event trigger will immediately exit the journey no matter where they are in the journey. This provides an easy way to remove customers who perform the event trigger from the journey, helping you ensure customers do not receive irrelevant messages from your customer journey.

- **Exit by segment**: Customers who are part of this segment will immediately exit the journey. This capability is often referred to as an supression segment and helps you ensure that members of this segment are supressed from the customer journey. Exit by segment will remove members of that segment from wherever they are in the customer journey, this is notably different from the *exclude by segment* property in journey start which will only exclude members of the exclusion segment from starting the journey.

# Journey goal

Journey goals let you track and [analyze the performance of the journey](real-time-marketing-analytics.md). You can use an event trigger as the journey goal and measure the success of the journey based on the customers who perform the event trigger as they are going through the journey.

Journey goals can also help you determine the winner of A/B tests and find the best channel for channel optimization. For more information on using A/B tests see [experiment and refine real-time marketing journeys](real-time-marketing-experimentation.md).

# Messaging customers

Real-time marketing customer journeys lets you reach customers through various channels including:

- [**Send an email**](real-time-marketing-email.md)
- [**Send a text message**](real-time-marketing-outbound-text-messaging.md)
- [**Send a push notification**](real-time-marketing-push-notifications.md)

## A/B test

A/B tests allow you measure which channel or content messaging strategy leads to higher success. For more information on using A/B tests see [experiment and refine real-time marketing journeys](real-time-marketing-experimentation.md)

## Channel optimization

Channel optimization uses AI to find the best channel to reach every individual customer and improve your engagement.

# Branching the customer journey

## If/then branch

The If/then branch lets your branch the customer journey based on customers actions like opening an email or completing a purchase. The if/then branch will wait for the customer to perform the event trigger within the time limit specified. If the customer performs the event trigger, they will immediately proceed down the yes branch. If the customer does not perform the event trigger within the time limit specified then they will proceed down the no branch after the time limit has passed. 

For example, you can configure the if/then branch to wait for the "Email Opened" event on a previously sent email. If the time limit is set to *1 day* then the if/then branch will wait for the customer to open the email within that day. If the customer opens the email within that day then they will immediately proceed down the yes branch. If the customer does not open the email within that day, then they will proceed down the no branch after one day.

## Attribute branch

The attribute branch lets you branch the journey based on various attributes including:

- Customer's attributes: You can branch the journey based on customer's attributes like address, age etc. The journey's audience defines which attributes will be shown. For example, if the journey is for Contacts then only attributes for Contacts will be shown.
- Customer's segment membership: You can branch the journey based on whether the customer is part of a segment. The journey's audience defines which segments will be shown. For example, only segments of Contacts will be shown for Journeys that are meant for Contacts.
- Attributes in event triggers: You can branch the journey based on attributes values in event triggers. For attribute values to be shown, the event trigger must have previously occured in the journey. So you can only check the attribute values for an event triggers that start an event-based journey or event triggers being used in an if/then branch.

The attribute branch checks for attribute values the moment a customer enters this step. For example, when a customer enters the attribute branch step, the segment membership condition will check whether the customer is part of the specified segment at that instant.

# Wait

The wait step will hold the customer in the journey for the specified wait period.

You can configure wait using the following:

- *A set amount of time*: customers will wait for the specified amount of time 1 hour, 1 day etc. The time period starts as soon as customers enter the wait step.
- *Until a specific date and time*: customers will wait until the specified date and time. If the date and time is already in the past then customers will immediately proceed to the next step.
- *Until a time specified by an event trigger*: customers will wait until the date and time that is specified by an event trigger attribute. This configuration is useful for scenarios like appointment reminders, where you can choose to wait 1 day before the appointment to send a reminder. The date and time information must be included in an event trigger that has previously occured in the journey.