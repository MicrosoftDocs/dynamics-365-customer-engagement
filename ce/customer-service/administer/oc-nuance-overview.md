---
title: Integration of Nuance Cloud IVR bot with Customer Service
description: Learn about the integration of Nuance Cloud IVR bot with Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: overview 
ms.collection:  
ms.date: 10/27/2023
ms.custom: bap-template 
---

# Introduction to Nuance Cloud IVR bot integration

Nuance Cloud IVR bot is part of the Digital Contact Center Platform&#8212;an open, extensible, and collaborative platform for seamless omnichannel customer engagement.

The bot can be integrated with the voice channel in Omnichannel for Customer Service to enable contextual call transfers. Customers can interact with the Nuance Cloud IVR bot first and then an Omnichannel agent if the call is escalated.

## How the integration works

The integration for Nuance Cloud IVR uses Azure Communication Services to route incoming calls to the Nuance Cloud IVR bot and then from the bot to the voice channel. The customer call comes in through Direct Routing or Public Switched Telephone Network (PSTN) and is routed through Nuance’s Session Border Controller (SBC).

The call is then escalated to an agent through Azure Communication Services using the  Session Initiation Protocol. The SIP header data is used to route the call and display details to the agent such as the IVR transcript and call intent, which are captured during the IVR session.

 :::image type="content" source="../media/oc-nuance-ref-arch.png" alt-text="Architecture diagram of the integration of Nuance Cloud IVR bot with voice channel.":::

## Next steps

[Set up Nuance Cloud IVR bot integration with voice channel](oc-nuance-setup.md)
