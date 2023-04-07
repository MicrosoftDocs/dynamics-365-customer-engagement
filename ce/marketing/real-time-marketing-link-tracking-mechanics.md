---
title: "Real-time marketing link tracking mechanics (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about real-time marketing link tracking mechanics in Dynamics 365 Marketing."
ms.date: 08/02/2021
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

# Real-time marketing link tracking mechanics

When executing customer journeys, all relevant hyperlinks are replaced with trackable links. If the content of a message is HTML, we also create an invisible pixel inside the message body. The invisible pixel is necessary to determine whether a user clicked on a link or opened the message.

Replaced links have the following format:

`https://[geo-specific].dynamics.com/api/orgs/[hashed organization-identifier]/r/[link identifier]`

Links are replaced when the following conditions are met:

- The links are not marked as **non-trackable** inside the message editor.
- The recipient customer profile indicates that the customer has consented to tracking.

When the recipient selects a link or opens a message with a tracking pixel, two things happen:

1. The recipient is redirected to the original URL.
1. The link click interaction is recorded.
 
If the recipient previously opted out from tracking, the interaction is generated as anonymous. When the recipient has opted out, the interaction does not store a customer profile reference.
 
> [!NOTE]
> All links generated in the [text message channel](real-time-marketing-outbound-text-messaging.md) are shortened, regardless of whether they are replaced with tracking links.
