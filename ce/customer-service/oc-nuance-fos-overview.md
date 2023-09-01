---
title: Integration of Nuance Cloud IVR bot with Customer Service
description: Learn about the integration of Nuance Cloud IVR bot with Customer Service
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: overview 
ms.collection:  
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Introduction to Nuance Cloud IVR bot integration

Nuance Cloud IVR bot is a part of the Digital Contact Center Platform&#8212;an open, extensible, and collaborative platform for seamless omnichannel customer engagement.

The bot can be integrated with the voice channel in Omnichannel for Customer Service to enable contextual call transfers. Customers can interact with the Nuance Cloud IVR bot first and then an Omnichannel agent if the call is escalated.

## How the integration works

The integration for Nuance Cloud IVR uses Azure Communication Services to route the incoming calls to the Nuance Cloud IVR bot and then from the bot to the voice channel. The customer call comes in through Direct Routing or Public Switched Telephone Network (PSTN) and is routed through Nuance’s Session Border Controller (SBC).

The call is escalated to an agent,through the Session Initiation Protocol, and a payload from Nuance Mix IVR is transferred to Dataverse.

The payload data is used to route the call to the agent, and display details such as the IVR transcript and call intent, which are captured during the IVR session, to the agent.

 :::image type="content" source="media/oc-nuance-fos-ref-arch.png" alt-text="reference architecture for nuance IVR omnichannel integration":::

## Next steps

[Setup Nuance Cloud IVR bot integration with voice channel](oc-nuance-fos-setup.md)
