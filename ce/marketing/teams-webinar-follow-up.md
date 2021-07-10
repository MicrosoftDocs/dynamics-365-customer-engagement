---
title: "Customize your Teams webinar participant follow-up (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to customize your follow-up with Microsoft Teams webinar participants using Dynamics 365 Marketing."
ms.date: 07/12/2021
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

In just a few steps, you can use contacts, segments, and a customer journey to follow up with webinar participants, even if you are not an existing Dynamics 365 Marketing user. To follow up with participants:

1. In Teams, select the **Attendance** tab to view the attendance report.
1. In the top-right corner, select **Follow up with participants**.
1. Select **Get started**. If you are an existing Marketing customer, a window pops up that lists your Dynamics organizations. Select the organization you want to use from the dropdown. If you are not a Marketing customer, a window opens that allows you [sign up for a free Dynamics 365 Marketing trial](trial-signup.md).
    > [!div class="mx-imgBorder"]
    > ![Follow up button](media/teams-follow-up-get-started.png "Follow up button")
1. A browser tab then opens with a customer journey and segments that are personalized to your webinar data.
    > [!div class="mx-imgBorder"]
    > ![Generated customer journey](media/team-follow-up-journey.png "Generated customer journey")

## Using the automatically created customer journey with your webinar data

The automatically created customer journey uses the power of Dynamics 365 Marketing to follow up with webinar participants. The journey creates the three most common follow-ups (paths) for your webinar participants:

- The first path sends an email to registrants who did not attend the webinar.
- The second path sends an email to registrants who attended the webinar.
- The third path sends an email to registrants who canceled their webinar registration.

Each path includes an email template to send notification emails. You can personalize each email template to suit your branding and company needs. To personalize the email, select the **Send an email** tile.

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