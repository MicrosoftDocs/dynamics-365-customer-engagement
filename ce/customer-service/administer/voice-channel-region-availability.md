---
title: Supported cloud locations for voice channel
description: Use this article to know about the supported cloud locations for the voice channel in Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 11/04/2024
ms.topic: conceptual
ms.custom: bap-template
---

# Supported cloud locations for voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article provides information about the supported cloud locations for the voice channel.

For information about international availability of live chat and digital messaging channels, see [International availability of Omnichannel for Customer Service](../implement/international-availability.md#international-availability-of-omnichannel-for-customer-service).

> [!IMPORTANT]
>
> - Your Microsoft 365 tenant must be colocated in one of the following geographic locations where Omnichannel for Customer Service is available.
> - The geographic locations refer to your Microsoft 365 tenant only and not the data center where your Power Platform environment or org instance resides.

## Global cloud deployments

The following table lists the global region, URL, and general and trial availabilities of the voice channel. Use the global cloud deployments if the voice channel in Customer Service isn't yet available for your local cloud deployments.

|Geographic location |URL| General availability | Availability in Customer Service trial|
|----------|---------|-----|---------|
|North America |crm.dynamics.com |Available | Available|
|Europe, Middle East, Africa| crm4.dynamics.com|Available | Available|
|Asia Pacific |crm5.dynamics.com |Available | Available |

## Local cloud deployments

> [!IMPORTANT]
> As we transition to the enhanced voice experience, the local hosting capabilities for the legacy voice channel in Switzerland was deprecated on October 31, and in India and Japan, it was deprecated on September 09, 2024. Learn more in [Deprecations in Dynamics 365 Contact Center](/dynamics365/contact-center/implement/deprecations-contact-center).

If you need your data to stay within a region, the following table lists the local region, URL, and general and trial availabilities of the voice channel in local regions. Stay tuned for country or region-specific local deployment of the voice channel. More information: [Datacenter regions](/power-platform/admin/new-datacenter-regions)

|Geographic location | URL| General availability | Availability in Customer Service trial|
|----------|---------|-----|----------|
|Australia| crm6.dynamics.com |Available |Available|
|United Kingdom **<sup>1</sup>**| crm11.dynamics.com |Available | To be announced|
|Canada **<sup>1</sup>** |crm3.dynamics.com |Available | To be announced  |
|South America |To be announced | To be announced|To be announced|
|France | To be announced | To be announced|To be announced|
|Germany | To be announced | To be announced|To be announced|
|United Arab Emirates **<sup>3</sup>**| crm15.dynamics.com | Available |To be announced|
|South Africa | To be announced | To be announced|To be announced|
|Norway | To be announced | To be announced|To be announced|
|Korea | To be announced | To be announced|To be announced|
|Singapore|To be announced | To be announced|To be announced|

> [!NOTE]
> **<sup> 1</sup>** The geographic location currently doesn't have business continuity and disaster recovery (BCDR) support. BCDR support will be a fast follow in this region.
> **<sup> 2</sup>** The geographic location won't have Copilot Studio support.
> **<sup> 3</sup>** BCDR failover is available for a few services only.

## Sovereign cloud deployments

The following table lists the sovereign region, URL, and general availability of the voice channel in Customer Service.

|Sovereign region|URL|General availability|
|-------|---------|-----------|
|Government Community Cloud (GCC) Moderate| To be announced |To be announced|
|GCC High|To be announced |To be announced |
|GCC Department of Defense (DoD)|To be announced |To be announced |
|China | To be announced | To be announced|
|Germany | To be announced | To be announced|

### Microsoft calling plans

Microsoft calling plans are available for customers with billing locations in select geographies around the world. To learn more about your eligibility, see [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

You can purchase new phone numbers through the Azure portal, and then sync with Omnichannel for Customer Service. More information: [Import phone numbers](voice-channel-sync-from-acs.md)

You can also port existing US or toll-free phone numbers. More information: [Port a phone number](/azure/communication-services/quickstarts/telephony/port-phone-number)

### Azure direct routing

You can bring your own carrier through Azure direct routing. This feature is supported across all geographic locations using certified Session Border Controller (SBC). More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

In the geographic locations where the voice channel is generally available, Azure direct routing extends general availability support.

The voice channel in Omnichannel for Customer Service doesn't support emergency calling when Azure direct routing is used.

## Next steps

[Provision voice channel](voice-channel-install.md)  

### Related information

[Overview of the voice channel](voice-channel.md)  
[FAQ about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

