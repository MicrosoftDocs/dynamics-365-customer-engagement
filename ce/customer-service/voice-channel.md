---
title: "Voice channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Introduction to the Voice channel 

Dynamics 365 Customer Service

Microsoft announces native Voice channel for Microsoft Dynamics 365 Customer Service. This is to complement Dynamics 365 Omni Channel which now has Voice, Chat, SMS, Whats App and more.


> [!VIDEO 
https://www.microsoft.com/en-us/videoplayer/embed/RE4G43k]



## Feature details
- Built on Microsoft Azure Communication Services 
- Even with the rise of digital channels and self-service, telephony remains a critical channel for contact centers to provide customer support. Most CRM players lack native telephony and only support integrations with telephony providers, also known as CCaaS (Contact Center as a Service) players, through “at the glass” CTI (softphones) widgets. As telephony follows CRM to the cloud, customers are looking to simplify their combined solution. 
extending our current assets, such as Power Virtual Agent, Intelligent Routing and conversation canvas, we can offer a telephony solution directly within Dynamics OC.  

## Key features

Call controls: Mute, Hold, End
Consulting and transferring
Monitoring and barging
Integrated customer and case history lookup
Notes and knowledge search
Live Transcription
Sentiment Analysis
Outbound calling (at GA)
Transfer to external phone number (at GA)
Call recording (at GA)


We will enable audio stream from the telephony channel to be directly into the Dynamics 365 Omnichannel data pipeline that exists for digital channels (see diagram below). This will allow us to achieve the following: 

Real-time intelligence for voice: Enriched audio streams from the telephony channel with real-time intelligence powered by Azure Cognitive Services for transcription, sentiment analysis, and agent suggestions. 

Speech-based self-service: NLU-powered IVRs and speech-enabled virtual agents by connecting the telephony channel to Power Virtual Agent for intuitive self-service and seamless elevation to agent-service. PVA bots will be built once and deployed across messaging and voice channels alike. 

Intelligent routing for voice: Improve the efficiency of automatic call distribution by directly routing calls to the right agent based on their individual skills, proficiencies, and capacity across all channels. 

Unified insights across channels: Customer insights and conversation intelligence that connect customer interactions over all digital and voice channel by leveraging the digital transcripts and call recordings that are stored in the Common Data Service. 

ACS will bring PSTN Calling
Bot Framework will bring underlying orchestration framework
Speech Services will bring Speech-to-Text, Text-to-Speech, and Telephony Channel
PVA will bring low code IVR authoring
Omnichannel will bring CCaaS solution

Outbound Calling
SMS
No-code Virtual Agent as IVR

Automatic Call Distribution (Routing)
Skills-based Assignment
Scheduled Callbacks
Calling controls
Music on hold
Native CRM
Agent-Assist AI Services
Call Transfer and Conferencing

Post-call Survey
Call Recordings
Conversation dashboards
Unified channel reporting
Call insights


Number Management

Get visibility into trends across all channels with native voice integration 
Leverage built-in AI to resolve issues faster with tools like call transcriptions and sentiment analysis 
Create true omnichannel experiences by providing agents will full customer interaction context no matter where the conversation is initiated



### Benefits

- With native voice, businesses receive seamless, end-to-end omnichannel experiences within a single solution, ensuring consistent, personalized, and connected support across all channels of engagement. This end-to-end solution unifies all points of customer interaction data, enabling businesses to simplify and streamline their processes, gain instant insights into trends, and deliver faster resolution from AI-driven assistance—all while ensuring your data remains secure and compliant, backed by the trusted Microsoft cloud.

The voice channel in Dynamics is built on the same secure, planet-scale platform used by Microsoft Teams

Native voice 

Voice should be just another channel in Omnichannel that participates throughout the stack, i.e. Power Virtual Agent for IVR, Unified Routing for ACD, connected agent and supervisor experiences, connected reporting. 

Differentiating AI 

We should bring to bear the best demonstrations of real-time and historical voice intelligence from Microsoft. As more CRM companies follow this trend to integrate channels and voice, the use of the data to create insights will be a big differentiator. 

Seamless setup 

Our main differentiator is that all parts of our CCaaS solution come directly from Microsoft. However, as it’s so often the case, our internal organizational boundaries end up dictating the user experience. We need to be able to provide a seamless setup of telephony directly within Dynamics that masks the different services (e.g. Azure Communication Services) that we’re using to provide the solution. 

Elastic billing 

Most modern CCaaS competitors have a pay-as-you-go model. Amazon Connect has a no cost sign-up and consumption-based billing model that is disrupting the market. We should aim to follow this trend by moving away from license-based billing for Omnichannel. As contact centers need to rapidly scale up or down (especially for call-only agents), manually procuring and releasing licenses to manage expenses can be a blocker for seamless operations.  


Microsoft’s Omnichannel for Customer Service allows us to escalate web chat conversations to voice and video calls, this is a great feature when conversations become complex and a chat conversation is simply more long winded than a voice call.

In this post I will explain how to setup the video calling feature. I will also give details about the agent and customer experiences.





## Example organizations

## Common use cases



## Roles

Call-only Customer Service Agent 

Blended Customer Service Agent (Call, Digital, Case) 

Agent Supervisor 

Queue Administrator 

Omnichannel System Administrator 

Tenant Admin 

## Agent experience using the Voice channel

[Agent experience using the voice channel in Dynamics 365 Customer Service](https://microsoft.sharepoint.com/:v:/t/CRMHOME/ua/EcxIBAEagJdKtkFer7rhItYBZJl_iNg-vtinvyAtaPeq3Q?e=W1tbR7)

## Next steps

- [Install and provision the voice channel]()
- [Make and receive your first call]()

### See also

[Blog: New voice channel streamlines omnichannel customer experiences](https://cloudblogs.microsoft.com/dynamics365/bdm/2020/09/23/new-voice-channel-streamlines-omnichannel-customer-experiences/)

