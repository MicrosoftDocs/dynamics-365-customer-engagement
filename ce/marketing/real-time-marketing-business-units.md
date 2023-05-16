---
title: "Business unit support in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use business unit support in Dynamics 365 Marketing."
ms.date: 01/27/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Business unit support in real-time marketing

Business unit scoping in real-time marketing can be enabled at an environment level by an administrator. Once this feature is enabled, all real-time journeys and segments created within the environment will be automatically scoped to the record owner’s business unit.

## Segment scopes, membership, and member lists

Business units affect real-time marketing segments as follows:

- When [scoping is enabled](real-time-marketing-business-units.md#enabling-business-unit-scopes-in-real-time-marketing) for your instance, each [segment](real-time-marketing-build-segments.md) is automatically scoped to the segment owner’s business unit. In addition:
    - Business unit scoped segments will only include audience members from the same business unit as the segment owner, even if the selection criteria would otherwise identify contacts from all business units.

## Journey scopes, design, processing, and content settings

Business units affect customer journeys as follows:
- When [scoping is enabled](real-time-marketing-business-units.md#enabling-business-unit-scopes-in-real-time-marketing) for your instance, each [journey](real-time-marketing-trigger-based-journey.md) is automatically be scoped to the journey owner’s business unit. In addition:
    - Business unit scoped journeys will only process audience members that belong to the same business unit as the journey owner.
    - If the environment's business unit scoping is enabled, all journeys will automatically filter the segments, emails, text messages, and push notifications that can be used in a journey to those that are in the same business unit as the journey.

## Message (email, text message, push notification) and template design

Business units affect messages (emails, text messages, and push notifications) and templates as follows:
- When [scoping is enabled](real-time-marketing-business-units.md#enabling-business-unit-scopes-in-real-time-marketing) for your instance, each message or template is automatically scoped to the email owner’s business unit.
    - A message or template can only include elements from the same business unit as that of its owner.

## Forms

Business units affect forms as follows:
- When [scoping is enabled](real-time-marketing-business-units.md#enabling-business-unit-scopes-in-real-time-marketing) for your instance, each [form](real-time-marketing-form-overview.md) is automatically scoped to the form owner’s business unit. In addition:
    - Business unit scoped forms, when submitted, will create records in the form owner’s business unit.

## Enabling business unit scopes in real-time marketing

> [!NOTE]
> While the business unit scoping feature can be turned on or off in outbound marketing, it behaves differently for real-time marketing. Business unit scoping for real-time Marketing is an irreversible feature switch; once it's enabled, it can't be disabled. To enable this feature:

1. Go to **Settings** > **Other settings** > **Feature switches**.
1. Set the **Business Unit Scoping (Real-Time Marketing)** toggle to **On**.
1. Read the customer agreement displayed in the prompt and select on **I Agree** to turn on the feature.
1. Select **Save** in the upper right.

[!INCLUDE[footer-include](../includes/footer-banner.md)]