---
title: "Real-time marketing triggers (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about real-time marketing triggers in Dynamics 365 Marketing."
ms.date: 03/07/2022
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

# Real-time marketing triggers

> [!Note]
> “Event triggers” are now called “triggers” in the app and the documentation. The change was made to avoid confusion when referencing event management functionality versus triggering real-time marketing event-based journeys.

Triggers control the flow of [event-based journeys](real-time-marketing-event-based-journey.md). They represent customer actions such as a whitepaper download, a form submitted, or a Wi-Fi sign-up. Triggers can also represent significant business events, such as a purchase that has shipped or completion of an enrollment process.

Triggers can be used to start, continue, or stop a journey. For example:

- A **Contact created** event can be used to start a journey to welcome a new user.
- An **Email opened** event can be used to trigger a follow-up response in a journey that engaged users by sending the users a promotional email.
- An **Order placed** event can be used as exit criteria to terminate a journey designed to periodically remind a customer to complete a purchase order.

## Event types

Real-time marketing offers three types of events in the triggers catalog: custom events, interaction events, and business events.

### Custom events

Custom events are defined by real-time marketing users. Custom events provide a flexible way to capture any customer action or significant business event.

For more information including important notes about security for custom events, see [Custom event triggers in real-time marketing](real-time-marketing-custom-events.md).

### Interaction events

Interaction events represent customer interactions with journey elements such as email, SMS, and push channels. Interaction events can’t start or stop journeys; they're used within a journey and represent a logical continuation of a preceding step. For example, when a journey sends an email message, a set of events such as *Email delivered*, *Email bounced*, or *Email opened* becomes available to journey authors, allowing them to make decisions about possible next steps.

### Business events

Business events represent changes in Dynamics 365 applications such as Sales or Service. These changes can reflect either the creation of a new record, or an update to an existing one. The following business events are available:

- *Contact created*
- *Contact e-mail address updated*
- *Contact address updated*
- *Contact phone number updated*
- *Lead created*
- *Incident created*
- *Opportunity created*
- *Marketing event check-in created*
- *Marketing event registration created*
- *Marketing event registration canceled*
- *Marketing form submitted*
