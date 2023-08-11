---
title:  Introduction to Nuance Cloud IVR bot integration
description: Learn about the Nuance Cloud IVR bot integration
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: overview 
ms.collection: get-started 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Introduction to Nuance Cloud IVR bot integration

Nuance Cloud IVR bot is a part of the Digital Contact Center Platform, an open, extensible, and collaborative platform for seamless omnichannel customer engagement.

The bot can be integrated with the voice channel in Omnichannel for Customer Service to enable contextual call transfer. Customers can interact with the Nuance IVR bot first and then an Omnichannel agent if the call is escalated.

## How the integration works

The integration for Nuance Cloud IVR uses the telephony layer configuration to route the incoming calls to the IVR bot and then from the IVR bot to the voice channel. The customer call comes in through Direct Routing or Public Switched Telephone Network (PSTN) and is routed through Nuance’s Session Border Controller (SBC).

When the Nuance IVR bot escalates the call to an Omnichannel agent, the call is referred to Azure Communication Services through the Session Initiation Protocol, and a payload from Nuance Mix IVR is transferred to Dataverse.

The data from the Nuance IVR payload is used to route the call to the proper agent, display the IVR transcript, call intent, and any other data captured during the IVR session to the agent.

 :::image type="content" source="media/oc-nuance-fos-ref-arch.png" alt-text="reference architecture for nuance IVR omnichannel integration":::

## Next steps

[Setup Nuance cloud IVR bot integration with voice channel](oc-nuance-fos-setup.md)
