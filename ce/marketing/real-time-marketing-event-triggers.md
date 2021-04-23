---
title: "Real-time marketing event triggers (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about real-time marketing event triggers in Dynamics 365 Marketing."
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

# Real-time marketing event triggers

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Event triggers control the flow of [event-based journeys](real-time-marketing-event-based-journeys.md). They represent actions taken by customers such as a whitepaper download, a form submissions or a Wi-Fi sign-up, or significant business events such as a shipment of a purchase order or completion of an enrollment process. 

Event triggers can be used to either start, continue or stop a journey, for example:

- a 'Contact Created' event can be used to start a journey to welcome a new user;
- an 'Email Opened' event can be used to trigger a follow up response in a journey that engaged users by sending them a promotional email;
- an 'Order Placed' event can be used as an exit criteria to terminate a journey designed to periodically remind a customer to complete a purchase order.

## Event types

Real-time marketing offers three types of events in the Trigger Events Catalog: Custom Events, Interaction Events and Business Events.

### Custom Events
Custom events are defined by the users of Real Time Marketing and provide complete flexibility to capture any customer action or any significant business event.

Refer to [Custom Events in Real Time Marketing](real-time-marketing-custom-events.md) for more information, including important notes about security of custom events.

### Interaction Events
Interaction events represent customer interactions with journey elements such as e-mail, SMS and push channels. As such, interaction events cannot start or terminate journeys and are used within a journey and represent a logical continuation of a preceding step. For example, when a journey sends email, a set of events such as 'Email Delivered, 'Email Bounced' or 'Email Opened' becomes available to journey authors to make decisions about possible next steps. 

### Business Events
Business events represent changes in Dynamics 365 applications  systems such as Sales or Service. Those changes can reflect either the creation of a new record, or an update to an existing one. During public preview, the following Business Events are available:

- Contact Created
- Contact E-mail Address Updated
- Contact Address Updated
- Contact Phone Number Updated
- Lead Created
- Incident Created
- Incident State Updated
- Opportunity Created
- Opportunity State Updated
