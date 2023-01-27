---
title: "Business unit support in real-time marketing  (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to use business unit support in Dynamics 365 Marketing."
ms.date: 01/27/2023
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
# Business unit support in real-time marketing 

> [!Important]
>
> A preview feature is a feature that is not yet complete but is made available to customers > to get early access before it’s officially included in a release  and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
>
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to assist you with issues or questions. Preview features aren’t meant for production use, particularly when processing personal data or other data subject to legal or regulatory compliance requirements.
>
>Business Unit scoping in Real-Time Marketing can be enabled at an environment level by the administrators. Once this feature is enabled, all the Journeys and Segments created within the environment are automatically scoped to the record owner’s business unit.. 

## Segment scopes, membership, and member lists

In addition to the standard effects described [previously](), business units affect segments as follows:

- When [scoping is enabled](https://learn.microsoft.com/dynamics365/marketing/business-units#enable-bu-scopes) for your instance, each [segment](https://learn.microsoft.com/dynamics365/marketing/segmentation-lists-subscriptions) is automatically scoped to the segment owner’s business unit. In addition,
    - Business-unit scoped segments will only include audience members from the same business unit as the segment owner—even if the selection criteria would otherwise identify contacts from all business units.

## Customer journey scopes, design, processing, and content settings

In addition to the standard effects described previously, business units affect customer journeys as follows:
- When [scoping is enabled](https://learn.microsoft.com/dynamics365/marketing/business-units#enable-bu-scopes) for your instance, each [customer journey](https://learn.microsoft.com/dynamics365/marketing/customer-journeys-create-automated-campaigns) is automatically be scoped to the journey owner’s business unit. In addition,
    - Business-unit scoped journeys will only process audience members that belong to the same business unit as the journey owner.
    - Additionally, if the environment's business-unit scoping is enabled, all journeys will automatically filter the Segments, Emails, SMS and Push messages that can be used in a journey to those that are in the same business unit as the journey. 

## Message (Email, SMS, Push Notification) and template design

In addition to the standard effects described previously, business units affect messages (Emails, SMS and Push Notification) and templates as follows:
- When [scoping is enabled](https://learn.microsoft.com/dynamics365/marketing/business-units#enable-bu-scopes) for your instance, each message/template is automatically scoped to the email owner’s business unit. 
    - A message/template would only be able to include elements from the same business unit as that of its owner.

## Forms

In addition to the standard effects described previously, business units affect forms as follows:
- When [scoping is enabled](https://learn.microsoft.com/dynamics365/marketing/business-units#enable-bu-scopes) for your instance, each [form](https://learn.microsoft.com/dynamics365/marketing/customer-journeys-create-automated-campaigns) is automatically scoped to the form owner’s business unit. In addition,
    - Business-unit scoped forms, when submitted, will lead to creation of records in the form owner’s business unit.

## Enabling business unit scopes in Real-Time Marketing

**Note:** While the Business Unit scoping feature can be turned on or off in Outbound Marketing, it behaves differently for Real-Time Marketing. Business Unit scoping for Real-Time Marketing is an irreversible feature switch – once it's enabled, it can't be disabled. 
To enable this feature:
1.	Go to **Settings** > **Other settings** > **Feature switches**.
2.	Set the **Business Unit Scoping (Real-Time Marketing)** slider to **On**.
3.	Read the customer agreement displayed in the prompt and select on **I Agree** to turn on the feature.

