---
title: Supported cloud locations for voice channel
description: Use this article to know about the supported cloud locations for the voice channel in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 05/10/2023
ms.topic: conceptual
ms.custom: bap-template
---
# Supported cloud locations for voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article provides information about the supported cloud locations for the voice channel.

For information about international availability of live chat and digital messaging channels, see [International availability of Omnichannel for Customer Service](international-availability.md#international-availability-of-omnichannel-for-customer-service).

## Supported cloud locations

This section lists the availability of voice channel in Omnichannel for Customer Service for various regions.

> [!IMPORTANT]
>
> - Your Microsoft 365 tenant must be colocated in one of the following geographic locations where Omnichannel for Customer Service is available.
> - The geographic locations refer to your Microsoft 365 tenant only and not the data center where your Power Platform environment or org instance resides.

### General region deployments

The following table lists the general and trial availability of the voice channel in Omnichannel for Customer Service for various regions. Use the general region deployments if the voice channel in Omnichannel for Customer Service isn't yet available for your region-specific cloud deployments. Voice trials are supported for specific general region deployments only as listed in the table.

|Geographic location | General availability | Availability in Customer Service trial|
|----------|---------|-----|
|North America (crm.dynamics.com) |November 2021  | November 2021|
|Europe, Middle East, Africa (crm4.dynamics.com)|December 2021 | May 2022|
|Asia Pacific (crm5.dynamics.com) |December 2021 | May 2022 |
|Australia, New Zealand, Fiji (crm6.dynamics.com) |December 2021 |September 2022|
|South America (crm2.dynamics.com) |To be announced | To be announced|
|Government Community Cloud (GCC) (crm9.dynamics.com) |To be announced |To be announced|
|Government Community Cloud (GCC) High|To be announced |To be announced|

### Region-specific deployments

If you need your data to stay within a region, see the following table for preview and general availability timelines. Stay tuned for country or region-specific local deployment of the voice channel. More information: [Datacenter regions](/power-platform/admin/new-datacenter-regions)

|Geographic location | Preview availability| General availability |
|----------|---------|-----|
|United Kingdom **<sup>1</sup>** (crm11.dynamics.com) |June 2022  | October 14, 2022 |
|Canada **<sup>1 </sup>** (crm3.dynamics.com) |August 2022 | November 30, 2022  |
|Switzerland **<sup>1</sup>** (crm17.dynamics.com)  | January 2023 | April 01, 2023|
|India **<sup>1</sup>**  (crm8.dynamics.com) | February 2023 | April 01, 2023  |
|Japan **<sup>1, 2</sup>** | August 2022 | To be announced  |
|France | To be announced | To be announced|
|Germany | To be announced | To be announced|
| United Arab Emirates | To be announced | To be announced |
|South Africa | To be announced | To be announced|
|China | To be announced | To be announced|
|Norway | To be announced | To be announced|
|Korea | To be announced | To be announced|
|Singapore|To be announced | To be announced|

> [!NOTE]
> **<sup> 1</sup>** The geographic location currently doesn't have business continuity and disaster recovery (BCDR) support. BCDR support will be a fast follow in this region.
>
> **<sup> 2</sup>** The geographic location won't have Power Virtual Agents support.

### Microsoft calling plans

Microsoft calling plans are available for customers with billing locations in select geographies around the world. To learn more about your eligibility, see [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

You can purchase new phone numbers through the Azure portal, and then sync with Omnichannel for Customer Service. More information: [Import phone numbers](voice-channel-sync-from-acs.md)

You can also port existing US or toll-free phone numbers. More information: [Port a phone number](/azure/communication-services/quickstarts/telephony/port-phone-number)

### Azure direct routing

You can bring your own carrier through Azure direct routing (preview). This feature is supported across all geographic locations using certified Session Border Controller (SBC). More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

In the geographic locations where the voice channel is generally available, Azure direct routing extends general availability support.

The voice channel in Omnichannel for Customer Service doesn't support emergency calling when Azure direct routing is used.

## Next steps

[Provision voice channel](voice-channel-install.md)  

### See also

[Overview of the voice channel](voice-channel.md)  
[FAQ about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

