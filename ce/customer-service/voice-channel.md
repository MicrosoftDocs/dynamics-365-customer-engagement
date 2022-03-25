---
title: "Voice channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Get an overview of the voice channel in Omnichannel for Customer Service and its offerings."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 03/28/2022
ms.topic: overview
---

# Introduction to the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Enable your customer service representatives to communicate with customers on the phone to resolve issues using the voice channel in Dynamics 365 Customer Service. While many customers increasingly use chat, SMS messages, and social media to engage and request support from organizations, phone calls continue to be an important communication channel. With the voice channel, Omnichannel for Customer Service provides agents with the ability to receive and make public switched telephone network (PSTN) calls through a native calling experience in Dynamics 365, with real-time AI-powered features such as live call transcription, sentiment analysis, and AI-based suggestions to boost agent productivity. Omnichannel for Customer Service also provides a rich set of analytics and insights, including AI-driven topic clustering and call insights.

## Why choose the voice channel

Typically, customer service organizations must manually integrate standalone telephony and customer relationship management (CRM) solutions, which result in fragmented experiences for agents and customers across engagement channels. Ultimately, these stitched-together solutions from multiple providers are not only complex to roll out and maintain but create data silos with disconnected insights of customer interactions and agent performance across channels.

### Native platform

The voice channel is built, owned, and operated completely by Microsoft. This means it is an all-in-one customer service solution without fragmentation or manual data integration, and a faster time to value by enabling a quick and easy deployment of a voice channel for your business. Also, the voice channel is built on Microsoft Azure Communication Services with the scalability and reliability of the calling platform that powers Microsoft Teams worldwide today.

### Built alongside existing omnichannel capabilities with a common data framework

The voice channel in Dynamics 365 Customer Service is another channel to engage customers with Chat, SMS, and social media, ensuring consistent, personalized, and connected support across all channels of engagement. As an example, agents can escalate web chat conversations to voice and video calls. As another example, routing a voice call to an agent is completed with unified routing, the same way an incoming chat message is assigned to an agent. By using the same platform, the voice channel works well with other features like an Azure bot. This means the process to create and deploy a conversational interactive voice response (IVR) bot is the same as the process to create and deploy a chat bot.

Beyond workflows and processes, the voice channel benefits from a common data framework with the other channels, allowing organizations to better understand each customer's journey whether the customer sent a chat, made a phone call, or used social channels. This means the solution provides a single view of the customer that empowers agents to provide personalized service across all channels, and true omnichannel analytics and insights for agents and supervisors alike.

### Differentiating AI

The voice channel has Microsoft's award winning AI built into the product. This enables agents to resolve issues faster with tools like call transcriptions and sentiment analysis and gain instant insights into trends.

### Emergency callback

With the new emergency calling feature, emergency responders can call back an agent over a temporary callback number. When the agent dials in the emergency number, the auto-responder bot receives the call and sends out a callback number (subscriber identifier) to the caller (agent).

The agent can dial in using the callback number and leave a message. During the call, the agent's status is automatically changed to "Do not disturb", so the emergency callback gets the highest priority and all other incoming calls are blocked. The agent receives the responder callback directly bypassing any routing rules, capacity profiles, and presence setting (including the "Do not disturb" status).

During the active emergency conversation, the conversation dashboard only displays just the device settings and the **End call** button. After the call ends, no calling controls or conversation history is displayed to ensure confidentiality of the emergency call.

Omnichannel for Customer Service does not record or store details of incoming or outgoing emergency calls. Also, the Omnichannel Ongoing Conversations Dashboard will not display the emergency call details. 

When the agent exits out of the emergency call and ends the session, the presence changes back to the earlier base status.

> [!Note]
> The emergency callback number is assigned to the agent for a duration of 60 minutes.

## Key capabilities of the voice channel

Take a look at some of the key capabilities that makes the voice channel great for IT administrators, supervisors, agents, and customers.

| User experience | Capability |
| --- | --- |
| Agent  |  <ul><li>Call controls: Mute, Hold, End</li><li>Music on hold</li><li>Music on wait</li><li>Integrated customer and case history lookup</li><li>Notes and knowledge search</li><li>Mark a number as spam</li> <li>Receive calls from emergency responders during emergencies </li></ul>  |
| Calling and routing  | <ul><li>Ability to handle and distribute incoming calls, automatic call distribution (routing)</li><li>Ability to make outbound calls</li><li>Transfer to external phone number</li><li>Phone number provisioning and management</li><li>Skills-based assignment</li></ul> |
| AI | <ul><li>Call insights </li><li>Real-time sentiment analysis</li><li>Real-time transcription and recording</li><li>Real-time translation of call transcripts</li><li>Real-time smart-assist suggestions</li><li>No-code Virtual Agent as IVR</li></ul> |
| Supervisor  | <ul><li>Consulting and transferring</li><li>Monitoring and barging</li><li>Ability to record and manage phone calls</li><li>Operations management through supervisor dashboards</li></ul> |
| Customer   | <ul><li>Post-call survey</li><li>Queue position and wait time announcements</li><li>Music on hold and wait</li></ul> |

### See also

[Install the voice channel](voice-channel-install.md)  
[Regional availability of the voice channel](voice-channel-region-availability.md)  
[International availability of Omnichannel for Customer Service](international-availability.md)  
[System requirements](system-requirements-omnichannel.md)  
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[FAQs about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

[Blog: New voice channel streamlines omnichannel customer experiences](https://cloudblogs.microsoft.com/dynamics365/bdm/2020/09/23/new-voice-channel-streamlines-omnichannel-customer-experiences/)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
