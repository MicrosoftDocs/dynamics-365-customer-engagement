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

Segment-based journeys can be used to create outbound journeys like sending out announcements or a nurture campaign. To create journeys that can react to customers' actions in real-time see  [create an event-based journey](real-time-marketing-event-based-journey.md).

## Creating a segment-based journey to send an announcement

To illustrate the capabilities of a segment-based journeys we will create a simple journey that sends an announcement about an upcoming product to your most valuable customers. If the customers show interest in the product by clicking on the product link then we will send them a followup message when the product is launched.

## Pre-requisites

### Create segments

- Create a segment of your *Most valuable customers*. Segment-based journeys work with segments from outbound marketing as well as segments from Customer Insights. If you chose to use outbound marketing then the email and text content must use Contact as the audience data for personalization. If you choose to use Customer Insights then the email and text content must use Customer Profile as the audience data for personalization.

### Create email and text message

- *Product announcement email*: This will be the initial email announcement that is sent to your *most valuable customers*. This email must contain a link to the new product.
- *Product launched text message*: This will be a followup text message that is sent after the product is launched. This followup will only be sent to those customers that clicked on the link in the first email.

You can build the journey while the content is in **Draft** state. In order to publish and go live with the journey, the content must be in the **Ready to send** state.

## Set the journey start

Customer's start a segment based journey when they qualify to be part of a segment. You can set the following properties for starting the journey:

- **Audience**: This is the *Most valuable customers* segment.
- **Frequency**: Select *one-time journey* since this announcement will only be sent once.
- **Start date and time**: Specify the start date and time when you want to send the announcement. Everyone who is part of the *most valuable customers* segment at the start date and time will enter the journey at that time.

## Add the announcement messages

Use the plus sign on the journey canvas to add the individual steps in your journey

1. **Send an email**: As the first step of the journey is to send the product announcement, select the *Product announcement email*. For the **Send to** field, select the attribute which contains the email address you want to send the email to.

2. **Add an if/then branch**: Set the **Branch off this** property to the previous *Product announcement email*. You want to **Wait for** the *Email link clicked* event. For **Which link**, select the link to view the product details. Finally set the time limit to *1 day* to indicate that customers have upto one day after receiving the email to click on the product link.

3. **Add a wait**: If customers click on the view product link within 1 day they will proceed down the yes branch. Under the yes branch add a Wait and select *Until a specific date and time*. Here you can specify the exact date and time that the product will launch. This is helpful if say the product launches a few days after your email announement. Customers will wait on this step till the specific date and time. If the date and time has already passed customers will immediately proceed to the next step.  

4. **Send a text message**: After waiting for the product launch you can send the *Product launched text message*. For the **Send to** field, select the attribute which contains the phone number you want to send the text message to.

## Publish the journey

After adding all the steps to the journey canvas, the journey is ready to go live and message real customers. Before publishing the journey you must make sure all related content - email, text messages or push notifications are in the **Ready to send** state. The journey cannot be modified after its published, so its a good idea to verify all the steps in the journey are exactly how you want them before publishing.

Once the journey is published and live, you can look at [analytics](real-time-marketing-analytics.md) to understand how the journey is performing.

