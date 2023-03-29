---
title: "Add email CC recipients (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to add CC recipients to journeys in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 03/24/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Add email CC recipients to journeys in real-time marketing

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW10sVQ]

You can add Carbon Copy (CC) recipients to your journeys when sending emails. When designing your journey, you can select up to five recipients for your emails from the email tile. You'll dynamically choose your CC recipients by mapping them to your marketable contacts.

> [!IMPORTANT]
>
>- When you add CC recipients to your emails, the sent email will be identical for both primary and carbon copy contacts. The interactions from CC recipients with sent emails (open, forward, clicks, unsubscribe) will be counted as a primary recipient interactions and will have direct impact on your insights and analytics.
>- If a CC recipient clicks on the unsubscribe button for marketing emails, they will unsubscribe the primary contact.
>- Additionally, the CC recipient interaction will trigger the next step in the journey if you are utilizing the **Respond to an action** element in your journey based on the customer interaction.
>- CC contacts are counted for marketable contact quota.
>- CC contacts interactions are counted for interaction quota.
>
> CC recipients will receive the same amount of emails as the overall emails sent to primary recipients, meaning, if you send 1000 emails to primary recipients with two people in CC, your overall sent emails will be 3000.
>
We recommend that you select people in CC who are aware of how this feature functions.  

## Enabling the CC feature

The CC feature is disabled by default, to enable the feature:

1. Go to the **Settings** page and select **Feature Switches**.
    > [!div class="mx-imgBorder"]
    > ![Select feature switches from settings.](media/real-time-email-cc-settings-feature-switches.png "Select feature switches from settings")

2. Enable the feature in the Customer Journey section.
    > [!div class="mx-imgBorder"]
    > ![Select feature switches from settings.](media/real-time-email-cc-enable-feature.png "Select feature switches from settings")

## How to use the CC feature in Customer Journey

In your journey, select the **Send an email** action.
> [!div class="mx-imgBorder"]
> ![Select feature switches from settings.](media/real-time-email-cc-send-email.png "Select feature switches from settings")

Select the **Select a recipient** to dynamically select the CC recipient. You have to select the relation to your target audience (contact or lead).
> [!div class="mx-imgBorder"]
> ![Select feature switches from settings.](media/real-time-email-cc-select-recipient.png "Select feature switches from settings")

You'll able to select up to five recipients. Make sure you're selecting entities that contain email addresses. If you select an entity that doesn't contain an email, it's ignored when sending the email.
> [!div class="mx-imgBorder"]
> ![Select feature switches from settings.](media/real-time-email-cc-select-recipient-up-to-5.png "Select feature switches from settings")

