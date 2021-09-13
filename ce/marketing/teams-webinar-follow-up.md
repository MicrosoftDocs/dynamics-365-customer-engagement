---
title: "Customize your Teams webinar participant follow-up (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to customize your follow-up with Microsoft Teams webinar participants using Dynamics 365 Marketing."
ms.date: 08/06/2021
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

# Customize your Teams webinar participant follow-up

In just a few steps, you can use contacts, segments, and a customer journey to follow up with Teams webinar participants, [even if you are not an existing Dynamics 365 Marketing user](teams-journey.md). The tools within Dynamics 365 Marketing allow you to create groups of participants and send tailored messages, create and send surveys, improve outcomes with email analytics, save participant details for future use, attract participants with personalized invitations, and increase attendance with automated confirmations and reminders.

Before you continue and customize the conversation with webinar participants, it's helpful to familiarize yourself with some Dynamics 365 Marketing terminology.

## Marketing terminology

Marketing uses different terminology than Teams for your participant information. The following bolded terms are tools that the Marketing app uses to organize, personalize, and automate your webinar participant data.

- **Contact**: In Marketing, participant information such as names, email addresses, company names, and mailing addresses are stored as contacts. You can use other tools, such as segments (see below), to group contacts for targeted messaging.
- **Segment**: A segment is a defined group of contacts, such as contacts who work at Contoso and attended a webinar. Segments allow you to choose the right audience to market to.
- **Customer journey**: After you've identified the audience you want to target, you can create a journey that automates a series of communications. For example, you can use a journey to send an email requesting a response from all participants who registered but did not attend a webinar. You may find that the webinar was off topic or was at an inconvenient time, helping you improve your future webinar plans.
- **Customer journey tile**: Each step in a customer journey is represented by a tile. The [tiles represent actions](customer-journey-tiles-reference.md)) that the Marketing app can take. For example, an email tile automatically sends personalized email messages to a segment of your choosing.

## Using the automatically created customer journey with your webinar data

The automatically created customer journey uses the power of Dynamics 365 Marketing to follow up with webinar participants. The journey creates the three most common follow-ups (paths) for your webinar participants:

- The first path sends an email to registrants who did not attend the webinar.
- The second path sends an email to registrants who attended the webinar.
- The third path sends an email to registrants who canceled their webinar registration.

> [!div class="mx-imgBorder"]
> ![Generated customer journey](media/team-follow-up-journey.png "Generated customer journey")

Each path includes an email template to send notification emails. You can personalize each email template to suit your branding and company needs. To personalize the email, select the **Send an email** tile. This opens the email designer, which allows you to [personalize the design](email-design.md#design-your-content) and [tailor the content](dynamic-email-content.md) to individual contacts.

You can also add tiles to create more complex paths for your journey. For example, you could try adding a **Wait for** tile and another **Send an email** tile to wait a week before sending a reminder email.

Refer to the links below to learn more about Marketing features and how to customize your journey.

## Customize your journey or create a new one

The links below guide you through the key steps you'll need to follow to create custom groups of participants, create your own customer journeys, and customize your follow-ups.

- [Edit the email content for a specific path](create-marketing-email.md)
- [Create a group of participants based on certain criteria](create-segment.md)
- [Send a survey](customer-voice.md)
- [Spread the word about the next webinar](create-simple-customer-journey.md)

## Additional resources

- [Explore training on Microsoft Learn](/learn/browse/?products=dynamics-marketing)
- [Watch videos on the product playlist](https://www.youtube.com/playlist?list=PLcakwueIHoT_cV1n1es1YJt_T2A5u-XpR)

> [!NOTE]
> Microsoft Teams and Dynamics 365 Marketing each have their own [service-specific licensing terms](https://www.microsoft.com/licensing/terms/productoffering). The service-specific terms that apply depend on which service processes your data. For example, when you transition from Microsoft Teams to Dynamics 365 Marketing, your Microsoft Teams data related to the webinar (such as the attendance report, engagement data, etc.) is transferred to Dynamics 365 Marketing whereupon it becomes Dynamics 365 Marketing data and the Dynamics 365 service-specific terms apply.