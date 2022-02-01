---
title: "Use custom events as actions in real-time marketing journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use custom events as actions in real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 02/02/2022
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

# Use custom events as actions in real-time marketing journeys

Based on the unique needs of your business, you may need to trigger custom processes/Power Automate flows at relevant points in a customer journey. Or you might have multiple journeys that logically function together. These scenarios can now be accomplished easily with Dynamics 365 Marketing, by using custom event triggers as the glue between journeys as well as between journeys and your custom processes. Some examples include:

1. You’re engaging customers so that they can purchase a subscription, but if they don’t do so by the end of the customer journey, you need to add them to a nurture journey. You can route the customers by activating a custom event trigger from the subscription journey and using that as the entry event trigger from the nurture journey.
1. A loan application journey has various steps that require a human agent’s approval. By creating a separate customer journey or Power Automate Flow for loan exception approval, you can trigger it from various points in the loan application journeys where exceptions can occur by simply activating the custom event trigger.
1. You need to engage customers through another application/channel, such as Microsoft Teams, which has a Power Automate connector. You can create a Power Automate Flow using this connector and have it start using the custom event trigger that you can activate from the relevant points in your journey.
1. You need to create Dynamics 365 activities (such as sales call, service tickets, etc.) from any point in the customer journey. By activating a custom event trigger, you can trigger a Power Automate Flow that creates those activities on behalf of the journey.

To learn more about custom event triggers, see [Custom event triggers in real-time marketing](real-time-marketing-custom-events.md).

Take an example using a journey with a goal of nurturing customers who have made purchases. Customers enter this journey when they’ve made a purchase on our online store, and we want to respond to them using relevant information we have. This simple journey uses an Attribute branch which sends customers to the yes branch if they are new customer and the no branch if they are a current customer or rewards member. In each branch is a custom event designed to fulfill a specific task.

Given Customer 1 and Customer 2 here is how this action performs in this journey:

*Customer 1: Enters the journey as an existing rewards member and proceed to the no branch. The no branch contains an action which activates a custom event trigger which enters them into a separate journey designed to nurture rewards members.*

*Customer 2: Enters the journey as a new customer and proceed down the yes branch. In the yes branch they reach a custom event trigger we have connected to a Power Automate flow. As the customer has never made a purchase, we want to prefill relevant information about the customer using the purchase data. The Flow assigns a rewards number to the customer if there is a valid phone number provided at the time of registration.*

The custom event action is comprised of three steps: select custom event, understand selected event usage, and map attributes.

## 1. Select custom event

After placing the tile on the journey canvas, you must select which custom event will be activated when a customer reaches this point in the journey.

## 2. Understand selected event usage

Once a custom event has been selected the current usage of this custom event in all journeys will be displayed. By clicking the clickthrough link you will be able to see all journeys and corresponding states that use the same custom event within them.

> [!NOTE]
> Power Automate flows that reference this custom event trigger are not tracked or displayed here.

> [!TIP]
> Live journeys displayed in the event usage tooltip will also activate the same custom event within them when a customer reaches this action in the journey. This will trigger other journeys using the same custom event trigger as entry trigger. It will also trigger steps in other journeys that reference the custom event trigger, for instance the if/then branches, exit conditions or goals.

## 3. Map attributes

When a customer reaches this stage of the journey the custom event activated must know where to get the customer information. The attributes shown in the side pane will allow dynamic mapping for the information sent in the event action.

> [!NOTE]
> Custom event attributes are data type specific.

## Trigger Power Automate Flows from real-time marketing journeys

Custom events activated through a customer journey can also be used to trigger Power Automate flows. The following walkthrough shows an example of how to set this up.

To learn more about this [Dataverse connector](/power-automate/dataverse/overview) action, see [Trigger flows with actions](/power-automate/dataverse/action-trigger).