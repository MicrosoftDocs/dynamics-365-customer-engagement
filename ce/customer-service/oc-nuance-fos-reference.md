---
title: Reference architecture for integration
description: Reference architecture for integration 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: conceptual
ms.collection:
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Reference architecture for integration

The integration for Nuance Cloud IVR uses the telephony layer configuration to orchestrate the incoming call between the IVR bot and the Digital Contact Center Platform. The customer call comes in through Direct Routing or Public Switched Telephone Network (PSTN) and is routed through Nuance’s Session Border Controller (SBC). 
When the Nuance IVR bot needs to escalate the call to a live agent in the Digital Contact Center Platform, the call is referred to Azure Communication Services through the Session Initiation Protocol, and a payload from Nuance Mix IVR is transferred to Dataverse.
Once the call reaches the Digital Contact Center Platform, data from the Nuance IVR payload can be used to route the call to the proper agent, display the Nuance Mix IVR transcript, call intent, and any additional data captured during the IVR session to the agent.

 :::image type="content" source="media/oc-nuance-fos-ref-arch.png" alt-text="reference architecture for nuance IVR omnichannel integration":::

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
