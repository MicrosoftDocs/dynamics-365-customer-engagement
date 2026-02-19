---
title: Enable and configure the Sales Hub dialer
description: Step-by-step guidance for administrators to enable the Omnichannel dialer in Dynamics 365 Sales Hub, sync Teams phone numbers, configure profiles, and assign numbers to sellers.
ms.date: 03/01/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Enable and configure the Sales Hub dialer (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

As a sales administrator, you can enable the Omnichannel dialer in Dynamics 365 Sales Hub so that sellers can make and receive calls directly within the application using dedicated phone numbers. The Omnichannel dialer replaces the Teams-based dialer with a more advanced voice experience built on the same cloud telephony infrastructure that powers Dynamics 365 Contact Center.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Key terminology

Before you begin, familiarize yourself with the following terms:

| Term | Definition |
|---|---|
| **Direct Inward Dialing (DID)** | A seller-assigned phone number that lets customers call a seller directly. Numbers are obtained in the Teams Admin Center and synced to Dynamics 365. |
| **Inbound profile** | Defines how incoming calls are routed to sellers, including business logic, consult/transfer settings, and capacity configuration. [Learn more](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-inbound-profiles) |
| **Outbound profile** | Controls how sellers make outgoing calls, including caller ID and dialing rules. [Learn more](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles#create-outbound-profiles) |
| **Capacity profile** | Sets the number of concurrent calls a seller can handle. A capacity greater than 1 allows sellers to receive new call notifications while on a call. [Learn more](/dynamics365/customer-service/administer/capacity-profiles) |
| **Channel Integration Framework (CIF)** | A Dynamics 365 app for managing voice providers and enabling the Omnichannel dialer in Sales Hub. [Learn more](/dynamics365/channel-integration-framework/channel-integration-framework) |

## Prerequisites

For details on required admin roles, licenses, voice channel provisioning, and seller roles, see [Prerequisites for the Sales Hub dialer](sales-hub-dialer-prerequisites.md).

## Set up the dialer

Complete the following tasks in order to enable the Sales Hub dialer for your organization:

| Step | Task | Description |
|---|---|---|
| 1 | [Sync Teams phone numbers to Dynamics 365](sales-hub-dialer-sync-numbers.md) | Retrieve environment IDs, convert user numbers to service numbers, create and license Teams resource accounts, and sync numbers to your Dynamics 365 environment. |
| 2 | [Configure the Omnichannel dialer in Channel Integration Framework](sales-hub-dialer-configure-cif.md) | Enable the Omnichannel voice provider for the Sales Hub app and assign access roles. |
| 3 | [Set up capacity profiles](sales-hub-dialer-capacity-profiles.md) | Define how many concurrent calls sellers can handle by configuring default or custom capacity profiles. |
| 4 | [Configure inbound and outbound profiles](sales-hub-dialer-call-profiles.md) | Create inbound profiles to control call routing behavior and outbound profiles to control how sellers place calls. |
| 5 | [Assign phone numbers to sellers](sales-hub-dialer-assign-numbers.md) | Assign dedicated geographic phone numbers to individual sellers via User Management or the phone number setup flow. |

## Post-setup configuration

After the dialer is enabled, configure these optional features:

- [Understand call routing](sales-hub-dialer-call-routing.md) — Learn how inbound calls are routed to sellers based on profiles and capacity.
- [Configure voicemail](sales-hub-dialer-voicemail.md) — Set up voicemail for calls that can't be assigned to a seller, and learn how sellers access voicemail.
- [Enable Dataverse search for the dial pad](sales-hub-dialer-dataverse-search.md) — Allow sellers to search for CRM records directly from the dialer keypad.

## Related content

- [Make and receive calls with the Sales Hub dialer](sales-hub-dialer.md)
- [Configure Teams Phone in voice channel](/dynamics365/contact-center/administer/configure-teams-phone-in-voice-channel)
- [Configure outbound and inbound profiles](/dynamics365/customer-service/administer/configure-outbound-inbound-profiles)
- [Create and manage capacity profiles](/dynamics365/customer-service/administer/capacity-profiles)
- [Channel Integration Framework guide](/dynamics365/channel-integration-framework/channel-integration-framework)
