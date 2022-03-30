---
title: "Emergency calling in the voice channel | MicrosoftDocs"
description: "Use this article to understand how emergency calls work in the voice channel of Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/01/2022
ms.topic: article
---

# Emergency calling in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Prerequisites

You must ensure the following conditions are met for emergency calling to work properly.
- The omnichannel user must have a capacity profile associated with a voice outbound profile. For more information, see [Configure capacity profiles](voice-channel-outbound-calling.md#configure-capacity-profiles-and-assign-users) and [Create outbound profiles](voice-channel-outbound-calling.md#create-outbound-profiles).
- Browser location setting must be enabled and set to United States or Puerto Rico.

## How emergency calling works

With the new emergency calling feature, agents can call the emergency number during a crisis situation. When the agent dials the emergency number, a temporary callback number is assigned to the agent. This way, the agent can be reached via callback in case of a dropped emergency call even when using a shared outbound number. The callback number is temporarily assigned to the agent for a duration of 60 minutes.

During the call, the agent's status is automatically changed to "Do not disturb", so the emergency callback gets the highest priority and all other incoming calls are blocked. The agent receives the responder callback directly bypassing any routing rules, capacity profiles, and presence settings (including the "Do not disturb" status).

During the ongoing emergency conversation, the **Omnichannel Ongoing Conversations** dashboard displays just the device settings and the **End call** button; the dashboard doesn't display any call details. After the call ends, the calling controls and conversation history are not displayed to ensure confidentiality of the emergency call. When the agent exits the emergency call and ends the session, the presence changes back to the earlier base status.

> [!Note]
> - Emergency calling is currently supported only in the United States and Puerto Rico where the emergency calling number is 911.
> - Omnichannel for Customer Service does not record or store details of incoming or outgoing emergency calls.

### See also

[Set up outbound calling in the voice channel](voice-channel-outbound-calling.md)  
[Set up inbound calling in the voice channel](voice-channel-route-queues.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
