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

Based on the unique needs of your business, you may want to trigger custom processes or Power Automate flows at certain points in a customer journey. Or, you might want to create multiple journeys that logically function together. Custom event triggers allow you to accomplish these actions, working as the glue between journeys or between journeys and custom processes.

Here are some examples of custom event triggers in action:

1. You’re engaging customers so that they can purchase a subscription, but if they don’t do so by the end of the customer journey, you need to add them to a nurture journey. You can route the customers by activating a custom event trigger from the subscription journey and using that as the entry event trigger from the nurture journey.
1. A loan application journey has various steps that require a human agent’s approval. By creating a separate customer journey or Power Automate Flow for loan exception approval, you can trigger it from various points in the loan application journeys where exceptions can occur by simply activating the custom event trigger.
1. You need to engage customers through another application/channel, such as Microsoft Teams, which has a Power Automate connector. You can create a Power Automate Flow using this connector and have it start using the custom event trigger that you can activate from the relevant points in your journey.
1. You need to create Dynamics 365 activities (such as sales call, service tickets, etc.) from any point in the customer journey. By activating a custom event trigger, you can trigger a Power Automate Flow that creates those activities on behalf of the journey.

To learn more about custom event triggers, see [Custom event triggers in real-time marketing](real-time-marketing-custom-events.md).

Take an example using a journey with the goal of nurturing customers who have made purchases. Customers enter this journey when they’ve made a purchase on our online store, and we want to respond to them using the relevant information we have. This simple journey uses an Attribute branch that sends customers to the yes branch if they’re a new customer and the no branch if they’re a current customer or rewards member. In each branch is a custom event designed to fulfill a specific task.

Given Customer 1 and Customer 2, here’s how this action performs in this journey:

*Customer 1: Enters the journey as an existing rewards member and proceeds to the no branch. The no branch contains an action that activates a custom event trigger that enters them into a separate journey designed to nurture rewards members.*

*Customer 2: Enters the journey as a new customer and proceeds down the yes branch. In the yes branch they reach a custom event trigger we’ve connected to a Power Automate flow. As the customer has never made a purchase, we want to prefill relevant information about the customer using the purchase data. The Flow assigns a rewards number to the customer if there’s a valid phone number provided at the time of registration.*

The custom event action is composed of three steps: select a custom event, understand the selected event usage, and map attributes.

## 1. Select a custom event

After placing the tile on the journey canvas, you must select which custom event will be activated when a customer reaches this point in the journey.

> [!div class="mx-imgBorder"]
> ![Screenshot of selecting a custom event.](media/real-time-marketing-custom-event-actions-trigger-event.png "Screenshot of selecting a custom event")

## 2. Understand the selected event usage

Once a custom event has been selected the current usage of this custom event in all journeys will be displayed. By clicking the clickthrough link, you’ll be able to see all journeys and corresponding states that use the same custom event within them.

> [!NOTE]
> Power Automate flows that reference this custom event trigger are not tracked or displayed here.

> [!TIP]
> Live journeys displayed in the event usage tooltip will also activate the same custom event within them when a customer reaches this action in the journey. This will trigger other journeys using the same custom event trigger as an entry trigger. It will also trigger steps in other journeys that reference the custom event trigger, for instance, the if/then branches, exit conditions, or goals.

> [!div class="mx-imgBorder"]
> ![Screenshot of a trigger for a nurture journey.](media/real-time-marketing-custom-event-actions-nurture-journey.png "Screenshot of a trigger for a nurture journey")

## 3. Map attributes

When a customer reaches this stage of the journey the custom event activated must know where to get the customer information. The attributes shown in the side pane will allow dynamic mapping for the information sent in the event action.

> [!NOTE]
> Custom event attributes are data-type-specific.

## Trigger Power Automate flows from real-time marketing journeys

Custom events activated through a customer journey can also be used to trigger Power Automate flows.

> [!div class="mx-imgBorder"]
> ![Animation of choosing a Power Automate flow.](media/real-time-marketing-custom-event-actions-power-automate.gif "Animation of choosing a Power Automate flow")

The example above assigns a customer rewards number when the custom event tile is triggered.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Automate flow.](media/real-time-marketing-custom-event-actions-performed.png "Screenshot of Power Automate flow")

To learn more about this [Dataverse connector](/power-automate/dataverse/overview) action, see [Trigger flows with actions](/power-automate/dataverse/action-trigger).