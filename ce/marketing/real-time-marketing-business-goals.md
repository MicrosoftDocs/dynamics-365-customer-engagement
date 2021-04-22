---
title: "Set a business goal and measure progress through a journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to set real-time marketing business goals and measure progress in Dynamics 365 Marketing."
ms.date: 04/23/2021
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

# Set a business goal and measure progress through a journey

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Most customer journeys are created to drive a specific customer behavior or action such as making a purchase, signing up for an event, or renewing a subscription. You can now choose the intended behavior as the goal of your customer journey and set a target you want to hit. Using the goal, you can measure the success of the customer journey on an ongoing basis. Goal settings enable you to make incremental improvements to reach your targets more quickly and effectively.

Using the goal-setting feature, you can:
- Define goals that track customer engagement, drive a purchase, increase customer loyalty, customer onboarding, send general announcements or customize it to fit your desired outcomes.
- Measure the success of the customer journey on an ongoing basis using the goal metric and a target.
- Optimize your A/B tests and channel selections based on the journey goal.
- Express goal targets in count or percentage to determine how well a journey is performing.

## Create a real-time marketing business goal

1. Go to **Real-time marketing** > **Customer engagement** > **Journeys** and open an existing journey or create a new one.
1. Select **Goal** on the right side pane.
    > [!NOTE]
    > You can only select one goal per journey.
1. Under **The goal of this journey is**, select the general purpose of the journey, for example, **Engage customers**.
1. Under **This goal is met when**, define successful criteria for the goal. The successful criteria may be in the form of completing a custom event, or completing an event from the event catalog.
1. Under **The amount of people needed for this goal is**, specify a target amount you believe would mean success. For example, you might determine the goal was successful if 50% of the customers that go through the journey achieve it.

## Example goals and measurement criteria

| Goal                        | Examples                                                           | Possible goal measurements                                                                  |
|-----------------------------|--------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| Drive a purchase            | - Cart abandonment campaigns <br> - Promote sales for new products | - Checkout custom event trigger on the website <br> - "Thank you for purchasing" email open |
| Engage customers            | - Satisfaction survey campaigns                                    | - Message is opened or clicked                                                              |
| Increase loyalty            | - Upsell campaigns                                                 | - User is upgraded from a lead to a contact                                                 |
| Onboard new people          | - Remind customers who did not finish the sign-up process          | - Message is opened or clicked                                                              |
| Send a general notification | - New product announcements <br> - Alerts about upcoming changes   | - Message is opened or clicks                                                               |

## Attribution window for the journey

A user can only count towards the journey goal as long as they are actively a part of the journey. There is a default listening time of three days after the journey completed, in case the desired action takes place after the user left the journey. The app will not count the journey success of a user if they:
1. Never entered the journey because they were part of an exclusion segment.
1. Exited the journey because they were added to a suppression segment and hit the goal after they exited the journey.
1. The journey is completed and the user hit the goal after the default three-day window expired.

If a user is part of two journeys with the same goal, and the user hits the goal event after journey 1 has ended (or they have exited), but before journey 2 has ended (or they have exited), the user will *only* count towards the journey 2 goal.

## Analytics

**Filter by goal category**: To view all campaigns that share a similar goal, filter by the goal category. To filter by the goal category, go to the **Analytics** section in the left navigation pane and select the filter icon.
