---
title: "Emergency calling in the voice channel | MicrosoftDocs"
description: "Use this article to understand how emergency calls work in the voice channel of Omnichannel for Customer Service."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/03/2022
ms.topic: article
---

# Emergency calling in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article describes how emergency calling works in Omnichannel for Customer Service when agents dial an emergency number during crisis situations.

> [!NOTE]
>
> - Emergency calling is currently supported only in the United States and Puerto Rico where the emergency calling number is 911.
> - For the emergency call to be handled, one of the following conditions must be fulfilled:
>   - The number from which it originates must be a Microsoft calling plan number.
>   - When the Azure Communication Services resource (tenant) has both direct routing (third-party public switched telephone network (PSTN) carrier number) and at least one direct offer (Microsoft calling plan number) enabled and there is no direct routing rule for the emergency number, the call will follow the direct offer path and will be routed to our direct offer emergency calling service. More information: [Voice routing considersations](/azure/communication-services/concepts/telephony/direct-routing-provisioning#voice-routing-considerations)

## Prerequisites

You must ensure that the following conditions are met for emergency calling to work properly.

- The omnichannel user must have a capacity profile associated with a voice outbound profile. For more information, see [Configure capacity profiles](voice-channel-outbound-calling.md#configure-capacity-profiles-and-assign-users) and [Create outbound profiles](configure-outbound-inbound-profiles.md#create-outbound-profiles).
- Browser location setting must be enabled, and set to United States or Puerto Rico.

## How emergency calling works

In Customer Service workspace or Omnichannel for Customer Service, agents can use the dialer to call the emergency number during a crisis.

Here's how emergency calling works:

> [!NOTE]
> If a third-party PSTN carrier is used, the behavior needs to be discussed and configured with the carrier.

1. The agent calls the emergency number such as 911 in the US or Puerto Rico.
1. The agent status automatically changes to "Do not disturb", irrespective of the current status.
1. A temporary callback number is assigned to the agent for a duration of 60 minutes. 
1. If the emergency call is dropped or gets disconnected, then the emergency responder can call back the agent via this callback number. The emergency callback gets the highest priority, bypassing all configured routing rules, capacity profiles, and presence settings.
1. During the ongoing emergency conversation, the **Omnichannel Ongoing Conversations** dashboard displays the device settings and the **End call** button only. To ensure confidentiality, the outgoing and incoming emergency calls are not recorded and are not stored as activities in call history.
1. When the agent ends the emergency call, the agent presence is reset to the prior status.

### See also

[Set up outbound calling in the voice channel](voice-channel-outbound-calling.md)  
[Set up inbound calling in the voice channel](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
