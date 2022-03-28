---
title: "Emergency calling in the voice channel | MicrosoftDocs"
description: "Use this article to understand how emergency calls work in the voice channel of Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 01/04/2022
ms.topic: article
---

# Emergency calling in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Prerequisites

The omnichannel user should have an outbound profile and must belong to a voice queue.

## Introduction

With the new emergency calling feature, anyone who's configured to make outbound calls, whether it's an omnichannel administrator, supervisor, or agent, can call the emergency number during a crisis situation. When the agent dials the emergency number, a temporary callback number is assigned to the agent. The callback number is temporarily assigned to the agent for a duration of 60 minutes.

During the call, the agent's status is automatically changed to "Do not disturb", so the emergency callback gets the highest priority and all other incoming calls are blocked. The agent receives the responder callback directly bypassing any routing rules, capacity profiles, and presence setting (including the "Do not disturb" status).

During the ongoing emergency conversation, the conversation dashboard displays just the device settings and the **End call** button. After the call ends, no calling controls or conversation history is displayed to ensure confidentiality of the emergency call. When the agent exits the emergency call and ends the session, the presence changes back to the earlier base status.

> [!Note]
> - Emergency calling is currently supported only in the US and Puerto Rico where the emergency calling number is 911.
> - Omnichannel for Customer Service does not record or store details of incoming or outgoing emergency calls. Also, the Omnichannel Ongoing Conversations Dashboard will not display the emergency call details.

### See also

[Introduction to the voice channel](voice-channel.md)  
[Regional availability of the voice channel](voice-channel-region-availability.md)  
[International availability of Omnichannel for Customer Service](international-availability.md)  
[System requirements](system-requirements-omnichannel.md)  
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[FAQs about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

[Blog: New voice channel streamlines omnichannel customer experiences](https://cloudblogs.microsoft.com/dynamics365/bdm/2020/09/23/new-voice-channel-streamlines-omnichannel-customer-experiences/)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
