---
title: "Corelating across multiple custom triggers (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to correlate across multiple custom triggers in Dynamics 365 Marketing."
ms.date: 02/08/2022
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

# Corelating across multiple custom triggers

For event-based, repeatable journeys, a customer can repeat a journey without having completed the previous run. For example, consider a journey that sends appointment confirmations and reminders. When a person registers for their first appointment, they enter the journey and receive a confirmation. They will continue to wait in the journey until they receive a reminder a day before the appointment. During this time, the same person could register for a second appointment. The journey participant will start the same journey a second time for the second appointment. In other words, the same person is now going through two instances of the same journey.

In such a situation, if the journey participant cancels one of the appointments, they should exit only the journey associated with the cancelled appointment. For example, if they cancel the first appointment, they should exit the journey associated with the first appointment but continue the journey associated with the second appointment. If you are using out-of-the-box Dataverse-based events, then the behavior is automatic and no additional action is needed. However, if you are using custom triggers, you must configure the trigger to correctly identify the specific instance of the journey that the trigger must be associated with.

## Using the *bindingid* attribute to uniquely identify each instance of the journey

Every custom trigger has an optional *bindingid* attribute that can be used to bind the trigger to specific instances of a journey. When the *bindingid* attribute is not present, the trigger will act on all instances of the journey that the person is participating in. For example, if the person has registered for two appointments but cancels one, and if the cancelled trigger did not use a *bindingid*, then that person will exit both instances of the journey. If you intend to use triggers in repeatable journeys, it is highly recommended that you include a *bindingid* in the trigger.

When a *bindingid* in the trigger that starts a journey, that ID will be used to identify the journey instance. To identify the journey instance, any other event should also use the same *bindingid*. For example, if your start event is *Appointment Confirmed* and it has a binding ID of “123,” your exit event *Appointment Cancelled* should also use the same ID (“123”) to uniquely identify the journey instance.

If you are only using custom events in the journey, you can rely on unique strings to identify the journey instances.

> [!NOTE]
> A custom trigger will act on all instances of a journey that someone is participating in if the *bindingid* is missing *or* if the binding is for a different entity type.

## Corelating across custom events and out-of-the-box events or custom business events

If you want to use a combination of custom events and out-of-the-box or custom business events, *bindingid* uses special formatting to uniquely identify the Dataverse table and row. For example, your journey could start with the out-of-the-box event *Opportunity Created*. You could then use a custom trigger called *Opportunity Won* for the exit event. The custom trigger *Opportunity Won* must contain a *bindingid* that follows the pattern of the *Opportunity Created* event to uniquely identify each instance.

Whenever a journey is started by an out-of-the-box or custom business event, each instance of the journey can be uniquely identified by the pattern ``{table_name}/{unique row ID}``. This pattern must be included in the *bindingid* attribute of any custom event to corelate across custom events and out-of-the-box or custom business events.

In the case of the *Opportunity Won* custom event, the *bindingid* could be:

- *bindingid* = ``opportunity/{unique ID of the opportunity row}``

If custom triggers follow the *bindingid* pattern described above, they can be used to identify the exact journey instance, even when used with other business events. When the *bindingid* is implemented, it works acts on all instances of the journey.

> [!NOTE]
> The binding only works across the same entity types.