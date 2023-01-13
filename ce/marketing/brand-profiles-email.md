---
title: "Preview: Use brand profiles in real-time marketing email (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use brand profiles in email in Dynamics 365 Marketing."
ms.date: 08/15/2022
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

# Preview: Use brand profiles in real-time marketing email

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Brand profiles allow you to create consistently branded content efficiently, even if your organization has multiple brands. You can create multiple brand profiles for your organization or profiles for each of your business units. To learn about creating brand profiles, see [Create consistent branding with brand profiles](brand-profiles.md).

This article describes how to use brand profiles in the real-time marketing email designer.

## How to enable the brand profiles preview

This article refers to a feature that is in preview and may not be enabled in your environment. If you don’t see this feature in your app, contact your admin who can activate it by going to **Settings** > **Other settings** > **Feature switches** > **Email editor** and enabling the **Brand profiles*** feature switch.

## How to use brand profiles

To use brand profiles in the real-time marketing email designer, select the desired profile from the **Brand profile** dropdown in the top right.

> [!div class="mx-imgBorder"]
> ![Select a brand profile in the real-time marketing email designer.](media/brand-profile-email-select.png "Select a brand profile in the real-time marketing email designer")

After you select a brand profile, the default sender for the profile will be automatically populated into the email sending settings. If you've more than one sender, you can remove the default sender, and then choose from any of the other senders in the profile by selecting the lookup icon in the **Sender** box under **Send settings**.

> [!div class="mx-imgBorder"]
> ![Select a different sender.](media/brand-profiles-email-senders.png "Select a different sender")

> [!NOTE]
> If you want to use a one-time sender for your email (and don’t want to add it to the brand profile), you can leave the sender field empty and manually insert custom sender settings.

## Use dynamic values

You can use the dynamic values from a brand profile to set social links for your social media images in the email. You can access the values by opening the brand profile category in the personalization window. This will ensure that the URLs are accurate no matter which brand profile you've selected.

Learn more about dynamic values: [Personalize content](real-time-marketing-personalization.md).

> [!div class="mx-imgBorder"]
> ![Add dynamic values.](media/brand-profiles-email-dynamic.png "Add dynamic values")