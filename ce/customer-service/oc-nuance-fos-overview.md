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

Nuance Cloud IVR bot is a part of the Digital Contact Center Platform, an open, extensible, and collaborative platform for seamless, omnichannel customer engagement.
The IVR bot allows customers to communicate effectively and resolve their issues efficiently, as if they were speaking with a live agent. Customers can resolve issues on their own using the IVR bot that leads to improved satisfaction and reduced costs.

## How the Nuance Cloud IVR bot works in Customer Service

The bot can be integrated with the voice channel in Omnichannel for Customer Service to enable contextual call transfer. This helps customers to interact with the Nuance IVR bot first and then an Omnichannel for Customer Service agent if the call is escalated.

The integration for Nuance Cloud IVR uses the telephony layer configuration to orchestrate the incoming call between the IVR bot and the Digital Contact Center Platform. The customer call comes in through Direct Routing or Public Switched Telephone Network (PSTN) and is routed through Nuance’s Session Border Controller (SBC).
When the Nuance IVR bot needs to escalate the call to a live agent in the Digital Contact Center Platform, the call is referred to Azure Communication Services through the Session Initiation Protocol, and a payload from Nuance Mix IVR is transferred to Dataverse.
Once the call reaches the Digital Contact Center Platform, data from the Nuance IVR payload can be used to route the call to the proper agent, display the Nuance Mix IVR transcript, call intent, and any additional data captured during the IVR session to the agent.

 :::image type="content" source="media/oc-nuance-fos-ref-arch.png" alt-text="reference architecture for nuance IVR omnichannel integration":::

## Next steps

[Setup Nuance cloud IVR bot integration with voice channel](oc-nuance-fos-setup.md)
