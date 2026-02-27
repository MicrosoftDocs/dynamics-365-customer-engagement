---
title: Enable and configure the Sales Hub Dialer (preview)
description: Step-by-step guidance for administrators to enable the Omnichannel dialer in Dynamics 365 Sales Hub, sync Teams Phone numbers, configure profiles, and assign numbers to sellers.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Enable and configure the Sales Hub Dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

As a sales administrator, you can enable the Sales Hub Dialer in Dynamics 365 Sales Hub so that sellers can make and receive calls directly within the application using dedicated phone numbers. The Sales Hub Dialer offers a more advanced voice experience built on the same cloud telephony infrastructure that powers Dynamics 365 Contact Center. It includes enhanced features like intelligent call routing, integrated CRM context, and improved call management capabilities that provide a better alternative to the Teams-based dialer.


[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

For details on required admin roles, licenses, voice channel provisioning, and seller roles, see [Prerequisites for the Sales Hub Dialer](sales-hub-dialer-prerequisites.md).

## Set up the dialer

Complete the following tasks in order to enable the Sales Hub Dialer for your organization:

| Step | Task | Description |
|---|---|---|
| 1 | [Sync Teams Phone numbers to Dynamics 365](sales-hub-dialer-sync-numbers.md) | Retrieve environment IDs, convert user numbers to service numbers, create and license Teams resource accounts, and sync numbers to your Dynamics 365 environment. |
| 2 | [Configure the Omnichannel dialer in Channel Integration Framework](sales-hub-dialer-configure-cif.md) | Enable the Omnichannel voice provider for the Sales Hub app and assign access roles. |
| 3 | [Set up capacity profiles](sales-hub-dialer-capacity-profiles.md) | Define how many concurrent calls sellers can handle by configuring default or custom capacity profiles. |
| 4 | [Configure inbound and outbound profiles](sales-hub-dialer-call-profiles.md) | Create inbound profiles to control call routing behavior and outbound profiles to control how sellers place calls. |
| 5 | [Assign phone numbers to sellers](sales-hub-dialer-assign-numbers.md) | Assign dedicated geographic phone numbers to individual sellers via User Management or the phone number setup flow. |

## Post-setup configuration

After the dialer is enabled, configure these optional features:

- [Understand call routing](sales-hub-dialer-call-routing.md): Learn how inbound calls are routed to sellers based on profiles and capacity.
- [Configure voicemail](sales-hub-dialer-voicemail.md): Set up voicemail for calls that can't be assigned to a seller, and learn how sellers access voicemail.
- [Enable Dataverse search for the dial pad](sales-hub-dialer-dataverse-search.md): Allow sellers to search for CRM records directly from the dialer keypad.

## Related information

[Make and receive calls with the Sales Hub Dialer](make-receive-calls-sales-hub-dialer.md)

