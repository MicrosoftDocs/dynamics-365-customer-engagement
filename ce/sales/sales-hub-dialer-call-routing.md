---
title: Understand call routing for the Sales Hub Dialer
description: Learn how inbound calls are routed to sellers based on inbound profiles, capacity profiles, and notification templates in the Sales Hub Dialer.
ms.date: 03/01/2026
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Understand call routing for the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

When a customer calls a seller's phone number, the system processes the call through a three-step flow to determine where the call should go.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Inbound profile identification

The system determines which inbound profile applies to the seller:

- If a custom inbound profile exists and the seller is associated with it, that profile is used.
- Otherwise, the default inbound profile is used as a fallback.

The inbound profile dictates the incoming call settings, notification templates, and capacity profile.

## Capacity profile evaluation

The capacity profile linked to the identified inbound profile is evaluated:

- If the seller is associated with the capacity profile and has available capacity, the call is routed to the seller.
- If the seller is associated but has no available capacity (applicable when capacity is set to 1), the call routes to voicemail.
- If the seller is not associated with the capacity profile, the call routes to voicemail.

## Notification and session templates

When the call is routed to the seller, the notification and session templates configured in the inbound profile are used to display the incoming call alert in Sales Hub.

## Related information

- [Enable and configure the Sales Hub Dialer](configure-sales-hub-dialer.md)
- [Configure inbound and outbound profiles](sales-hub-dialer-call-profiles.md)
- [Set up capacity profiles](sales-hub-dialer-capacity-profiles.md)
- [Configure voicemail](sales-hub-dialer-voicemail.md)
