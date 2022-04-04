---
title: "Emergency calling in the voice channel | MicrosoftDocs"
description: "Use this article to understand how emergency calls work in the voice channel of Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/04/2022
ms.topic: article
---

# Emergency calling in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article describes how emergency calling works in Omnichannel for Customer Service when agents dial an emergency number during crisis situations.

> [!Note]
> - Emergency calling is currently supported only in the United States and Puerto Rico where the emergency calling number is 911.

## Prerequisites

You must ensure the following conditions are met for emergency calling to work properly.
- The omnichannel user must have a capacity profile associated with a voice outbound profile. For more information, see [Configure capacity profiles](voice-channel-outbound-calling.md#configure-capacity-profiles-and-assign-users) and [Create outbound profiles](voice-channel-outbound-calling.md#create-outbound-profiles).
- Browser location setting must be enabled and set to United States or Puerto Rico.

## How emergency calling works

In Omnichannel for Customer Service, agents can use the dialer to call the emergency number during a crisis. When the agent dials the emergency number, a temporary callback number is assigned to the agent for a duration of 60 minutes. 
The emergency responder can call back the agent via the callback number if the emergency call is dropped or gets disconnected. The emergency callback gets the highest priority, directly bypassing any routing rules, capacity profiles, and presence settings (including the "Do not disturb" status). During the call, the agent status is automatically changed to "Do not disturb".

During the ongoing emergency conversation, the **Omnichannel Ongoing Conversations** dashboard displays the device settings and the **End call** button only. To ensure confidentiality, the outgoing and incoming emergency calls are not recorded and not stored as activities in call history. 

When the agent ends the emergency call, the agent presence is reset to the prior status.

### See also

[Set up outbound calling in the voice channel](voice-channel-outbound-calling.md)  
[Set up inbound calling in the voice channel](voice-channel-route-queues.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
