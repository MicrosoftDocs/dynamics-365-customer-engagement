---
title: "Real-time marketing link tracking mechanics (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about real-time marketing link tracking mechanics in Dynamics 365 Marketing."
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

# Real-time marketing link tracking mechanics

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

When executing customer journeys, all relevant hyperlinks are replaced with trackable links. If the content of a message is HTML, we also create an invisible pixel inside the message body. The invisible pixel is necessary to determine whether a user clicked on a link or opened the message.

Replaced links have the following format: 

`https://[geo-specific].dynamics.com/api/orgs/[hashed organization-identifier]/r/[link identifier]`

Links are replaced when the following conditions are met:

 - The links are not marked as **non-trackable** inside the message editor
 - The recipient customer profile indicates that the customer has consented to tracking

When the recipient clicks on a link or opens a message with a tracking pixel, two things happen:

 - The recipient is redirected to the original URL
 - The link click interaction is recorded
 
If the recipient has opted-out from tracking, the interaction is generated as anonymous. When the recipient has opted-out, the interaction does not store a customer profile reference.
 
> [!NOTE]
> All links generated on the text message channel are shortened, regardless of whether they are replaced with tracking links.