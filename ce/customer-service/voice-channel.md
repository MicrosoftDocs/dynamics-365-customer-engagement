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

Even with the rise of digital channels and self-service, telephony remains a critical channel for contact centers to provide customer support. Most CRM players lack native telephony and only support integrations with telephony providers, also known as CCaaS (Contact Center as a Service) players, through “at the glass” CTI (softphones) widgets. As telephony follows CRM to the cloud, customers are looking to simplify their combined solution. 

 

We see a major strategic opportunity to bring a differentiated CCaaS offering to the market through Dynamics 365 Omnichannel. By integrating with Azure Communications Service (aka Spool aka ACS), and extending our current assets, such as Power Virtual Agent, Intelligent Routing and conversation canvas, we can offer a telephony solution directly within Dynamics OC.  

Native voice 

Voice should be just another channel in Omnichannel that participates throughout the stack, i.e. Power Virtual Agent for IVR, Unified Routing for ACD, connected agent and supervisor experiences, connected reporting. 

Differentiating AI 

We should bring to bear the best demonstrations of real-time and historical voice intelligence from Microsoft. As more CRM companies follow this trend to integrate channels and voice, the use of the data to create insights will be a big differentiator. 

Seamless setup 

Our main differentiator is that all parts of our CCaaS solution come directly from Microsoft. However, as it’s so often the case, our internal organizational boundaries end up dictating the user experience. We need to be able to provide a seamless setup of telephony directly within Dynamics that masks the different services (e.g. Azure Communication Services) that we’re using to provide the solution. 

Elastic billing 

Most modern CCaaS competitors have a pay-as-you-go model. Amazon Connect has a no cost sign-up and consumption-based billing model that is disrupting the market. We should aim to follow this trend by moving away from license-based billing for Omnichannel. As contact centers need to rapidly scale up or down (especially for call-only agents), manually procuring and releasing licenses to manage expenses can be a blocker for seamless operations.  

## Watch an overview video

## Example organizations

## Roles

Call-only Customer Service Agent 

Blended Customer Service Agent (Call, Digital, Case) 

Agent Supervisor 

Queue Administrator 

Omnichannel System Administrator 

Tenant Admin 

## Key features

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


## Common use cases

## A day in the life of an agent using the Voice channel

## Next steps

