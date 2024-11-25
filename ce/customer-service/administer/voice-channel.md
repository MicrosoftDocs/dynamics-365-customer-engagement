---
title: Introduction to the voice channel
description: Enable agents to communicate with customers on the phone to resolve issues using the voice channel in Customer Service.
author: neeranelli
ms.author: nenellim
ms.date: 07/01/2024
ms.topic: overview
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/28/2023
---

# Introduction to the voice channel


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


> [!NOTE]
> Voice-enabled Copilots provide [enhanced voice capabilities](/microsoft-copilot-studio/voice-overview). If you have an existing voice channel configured, [migrate your existing workstreams](migrate-voice-workstream.md) to make sure that they are compatible with the enhanced Copilots. New deployments and voice workstreams get the enhanced experience out of the box.

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[cc-trial-sign-up](../../includes/cc-trial-sign-up.md)]

Enable your customer service representatives to communicate with customers on the phone to resolve issues using the voice channel in Dynamics 365 Customer Service. While many customers increasingly use chat, SMS messages, and social media to engage and request support from organizations, phone calls continue to be an important communication channel. The voice channel provides agents with the ability to receive and make public switched telephone network (PSTN) calls through a native calling experience in Dynamics 365. Real-time AI-powered features such as live call transcription, sentiment analysis, and AI-based suggestions are available to boost agent productivity. The application also provides a rich set of analytics and insights, including AI-driven topic clustering and call insights.

## Why choose the voice channel

Most organizations manually integrate standalone telephony and customer relationship management (CRM) solutions, which result in fragmented experiences for agents and customers across engagement channels. Such solutions from multiple providers are complex to roll out and maintain, and create data silos with disconnected insights of customer interactions and agent performance across channels.

### Native platform

The voice channel is built, owned, and operated completely by Microsoft. It's an all-in-one customer service solution that reduces time to value by enabling quick and easy deployment of the voice channel for your business. Also, the voice channel is built on Microsoft Azure Communication Services with the scalability and reliability of the calling platform.

### Built alongside existing omnichannel capabilities with a common data framework

The voice channel allows customers to with Chat, SMS, and social media, ensuring consistent, personalized, and connected support across all channels of engagement. As an example, agents can escalate web chat conversations to voice and video calls. As another example, routing a voice call to an agent is completed with unified routing, the same way an incoming chat message is assigned to an agent. The voice channel works well with other features like a Copilot Studio bot, as they share the same platform. The process to create and deploy a conversational interactive voice response (IVR) bot is the same as the process to create and deploy a chat bot.

Beyond workflows and processes, the voice channel benefits from a common data framework with the other channels, allowing organizations to better understand each customer's journey whether the customer sent a chat, made a phone call, or used social channels. This means the solution provides a single view of the customer that empowers agents to provide personalized service across all channels, and true omnichannel analytics and insights for agents and supervisors alike.

### Differentiating AI

The voice channel has Microsoft's award-winning AI built into the product. This enables agents to resolve issues faster with tools like call transcriptions and sentiment analysis, and gain instant insights into trends.

### Support for emergency calling

The voice channel supports emergency calling where agents can dial in the emergency number in a crisis. Any omnichannel voice agent with a capacity profile associated with a voice outbound profile can make an emergency call. The emergency responders can call the agent back over a temporary callback number if the call is dropped (even if the agent makes the call via a shared outbound number).

## Key capabilities of the voice channel

Take a look at some of the key capabilities that makes the voice channel great for IT administrators, supervisors, agents, and customers.

| User experience | Capability |
| --- | --- |
| Agent  |  <ul><li>Call controls: Mute, Hold, End</li><li>Music on hold</li><li>Music on wait</li><li>Integrated customer and case history lookup</li><li>Notes and knowledge search</li><li>Mark a number as spam</li><li>Dial the emergency number during crisis (currently supported in the United States and Puerto Rico only)</li> <li>Receive calls from emergency responders over a dedicated callback number </li></ul>  |
| Calling and routing  | <ul><li>Ability to handle and distribute incoming calls, automatic call distribution (routing)</li><li>Voicemail</li> <li>Ability to make outbound calls</li><li>Transfer to external phone number</li><li>Phone number provisioning and management</li><li>Skills-based assignment</li></ul> |
| AI | <ul><li>Call insights </li><li>Real-time sentiment analysis</li><li>Real-time transcription and recording</li><li>Real-time translation of call transcripts</li><li>Real-time smart assist suggestions</li><li>No-code virtual agent as IVR</li></ul> |
| Supervisor  | <ul><li>Consulting and transferring</li><li>Monitoring and barging</li><li>Ability to record and manage phone calls</li><li>Operations management through supervisor dashboards</li></ul> |
| Customer   | <ul><li>Post-call survey</li><li>Queue position and wait time announcements</li><li>Music on hold and wait</li></ul> |

### Related information

[Install the voice channel](voice-channel-install.md)  
[Supported cloud locations, languages, and locale codes ](voice-channel-region-availability.md)  
[International availability of Omnichannel for Customer Service](../implement/international-availability.md)  
[System requirements](../implement/system-requirements-omnichannel.md)  
[Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)  
[FAQ about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  
[Blog: New voice channel streamlines omnichannel customer experiences](https://cloudblogs.microsoft.com/dynamics365/bdm/2020/09/23/new-voice-channel-streamlines-omnichannel-customer-experiences/)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
