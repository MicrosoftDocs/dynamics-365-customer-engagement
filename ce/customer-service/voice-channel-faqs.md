---
title: FAQ about the voice channel
description: Use this article to know answers to your frequently asked questions (FAQ) about the voice channel in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.date: 05/31/2023
ms.topic: concept
ms.reviewer: shujoshi
ms.custom: bap-template

---

# FAQ about the voice channel in Omnichannel for Customer Service

This article includes frequently asked questions (FAQ) about the voice channel.

### Why is the agent unable to make an outbound call?

The agent must be a part of the outbound voice queue to make an outbound call. See [Set up outbound calling](voice-channel-outbound-calling.md) for information.

### Are overflow actions like voicemail and direct callback fulfilled for fallback queues?

No, overflow settings aren't applicable to fallback queues. The settings are ignored, and the routed work item is assigned to the queue. More information: [How overflow works](manage-overflow.md#how-queue-overflow-is-evaluated)

### Does the voice channel include real-time keyword recognition or sentiment tracking while an agent is on a call?

Yes, features such as sentiment analysis, agent suggestions for similar cases or knowledge articles, are available in the voice channel.

### Is the voice channel PCI DSS compliant?

The voice channel is compliant with Payment Card Industry Data Security Standard (PCI DSS) today, but support for credit card data capture over voice isn't yet available. Agents have the ability to pause or resume call recording and transcription to avoid capturing sensitive information. Agents can also pause transcription to avoid dual-tone multi-frequency (DTMF) tones being captured in the transcript. All data is stored in Dynamics 365 and can be scrubbed by the customer.

### Where does Azure Communication Services provide native PSTN services?

To register as a calling provider is a legally complex and country-specific process. Azure Communication Services has a multiyear road map to provide calling plans in different countries and regions. To see all the countries where PSTN services are available, check the [country availability](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability) page.

An alternative to Microsoft calling plans is Azure direct routing that allows you to bring your own phone numbers. More information: [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept)

### What about countries where Azure Communication Services doesn't provide native PSTN services?

Azure Communication Services is available worldwide, even if it isn't acting as the calling provider in certain countries. For these countries, Azure Communication Services provides a direct routing for local carriers, such as AT&T and Verizon, to connect to Azure Communication Services. With this mechanism, you'll still be able to deploy and use all the features of the voice channel in Dynamics 365.

### What codecs are implemented in the voice channel?

The voice channel supports the G.711 and Opus codecs for PSTN and VoIP services.

### Can I bring my own phone number?

Yes, you can bring your existing numbers to Omnichannel for Customer Service in the following ways:

- **Import numbers to Omnichannel for Customer Service**
    1. You must first port your existing phone numbers to Azure Communication Services. More information: [Quickstart: Port a phone number into Azure Communication Services](/azure/communication-services/quickstarts/telephony/port-phone-number)
    2. You can then import the phone numbers from Azure Communication Services to Omnichannel for Customer Service. More information: [Sync from Azure Communication Services](voice-channel-sync-from-acs.md)

- **Configure Azure direct routing**
    1. Configure a Session Border Controller (SBC) that's connected to your local carrier with Azure Communication Services.
    1. Register the phone number in Dynamics 365. More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

### Can my SBC and DNS server be deployed in different regions?

No. We recommend that the DNS server and SBC are deployed in the same region. More information:  [Bring your own carrier](voice-channel-bring-your-own-number.md#prerequisites)

### How can I acquire extra phone numbers from Azure Communication Services?

You can purchase one phone number per tenant for Azure Communication Services through the Azure portal. To acquire phone numbers in bulk or request a specific phone number, follow the instructions to create a special number request order [here](https://github.com/Azure/Communication/blob/master/special-order-numbers.md).

### Can I keep my existing contract with my carrier?

Yes, you can.

### Can I configure a third-party voice provider in Omnichannel for Customer Service?

Yes, you can use the Dynamics 365 Channel Integration Framework 2.0 connector to integrate third-party contact centers, such as Genesys Engage, Solgari, and NICE inContact.

### Does the voice channel tie in with Azure Communication Services or is it an entirely different technology?

The voice capabilities for Dynamics 365 Customer Service are built on Azure Communication Services.

### Do I have to buy phone numbers from Azure Communication Services?

No, you don't have to. You can bring phone numbers from another carrier to use in the voice channel using Azure direct routing. More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

If you've already brought numbers from another carrier into Microsoft Teams via Azure direct routing, then you can reuse your SBC and existing telephony infrastructure to bring those numbers into Azure Communication Services for use in the voice channel.  

> [!NOTE]
> Currently, you can't bring native Teams phone numbers to use in the voice channel.

### Is it possible to enable voice integrations outside of the Omnichannel for Customer Service app, such as, by adding omnichannel capabilities to a customer's Dynamics 365 app?

No, the voice channel isn't supported in the other apps of Dynamics 365. It's supported in the Customer Service workspace and Omnichannel for Customer Service apps only.

### How can I set up an IVR bot in the voice channel?

See the following articles to set up the interactive voice response (IVR) bot in the voice channel:
- [Configure Power Virtual Agents bots for voice](voice-channel-ivr-bots.md)
- [Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)

### Should the language of the bot be the same as the primary language configured in the Customer Service admin center or Omnichannel admin center app?

Yes, the primary language of the bot must be the same as that of the voice workstream to which the bot is attached, but you can configure different geographic locales for the bot and the voice workstream to which it's attached. Let's consider an example where English is set as the primary language for the bot and its voice workstream. You can set different locales, such as **English-UK** in the voice workstream and **English-US** in the bot; the bot will speak in English-UK as the workstream locale setting takes precedence.

You can transfer conversations from one bot to another with different primary languages. For example, you can transfer conversations from an English bot to a Spanish bot. But, if you configure different locales:
- The bot's accuracy will depend on the similarities between the two locales. 
- The preconfigured entities for the bot such as postal code might not be accurate. 
- A bot-to-bot transfer of the conversation with the same language but two different locales isn't possible. For example, the transfer of a conversation  from an **English-UK** bot to an **English-US** bot can't happen. As a workaround, you can make the **English-UK** bot transfer the conversation to another phone number attached to a workstream to which the **English-US** bot is attached. 

### Can I recover data and phone numbers from a voice trial organization after it has expired?

No, you can't recover your data and phone numbers after the voice trial organization has expired and been deprovisioned. 

### Is disaster recovery supported for the voice channel?

- Business Continuity and Disaster Recovery (BCDR) for production instances of the voice channel are supported on a geographical basis. In certain regions BCDR will be a fast follow. For details on the geographies that are currently supported and the geographies where BCDR is a fast follow, see [Local cloud deployments](voice-channel-region-availability.md#local-cloud-deployments).
- In supported regions, BCDR policies are based upon business continuity and disaster recovery for Dynamics 365 and SLA for Azure Communication Services. For more information, see [Business continuity and disaster recovery](/power-platform/admin/business-continuity-disaster-recovery) and [SLA for Azure Communication Services](https://azure.microsoft.com/support/legal/sla/communication-services/v1_0/).

### Do you provide voice quality SLA for voice in Omnichannel for Customer Service?

No, we don't publish a voice quality SLA as many factors related to voice quality like network connectivity, speed, and bandwidth, can't be controlled. The [SLA](https://azure.microsoft.com/support/legal/sla/communication-services/v1_0/) published for Azure Communication Services applies to the voice channel as well.

### What tools are available to isolate performance and quality of voice channel?

The tools for isolating voice performance and quality are available through Azure Communication Services and can be found at [Azure Communication Services media quality metrics](/azure/communication-services/concepts/voice-video-calling/media-quality-sdk).

More information:

- [Enable Azure Communication Services logs](/azure/communication-services/concepts/troubleshooting-info?tabs=csharp%2Cjavascript%2Cdotnet)
- [Turn on metrics to populate in Azure](/azure/communication-services/concepts/analytics/call-logs-azure-monitor)
- [Integrate with user-facing diagnostics](/azure/communication-services/concepts/voice-video-calling/user-facing-diagnostics)
- [Use media quality statistics](/azure/communication-services/concepts/voice-video-calling/media-quality-sdk)
- [Use pre-call diagnostics](/azure/communication-services/concepts/voice-video-calling/pre-call-diagnostics)
- [Use Azure Communication Services communication monitoring plug-in](https://www.npmjs.com/package/@azure/communication-monitoring)

### Does the voice channel support emergency calling?

Yes, the voice channel supports emergency calling; agents can call the emergency number during a crisis. This feature is currently supported in the United States and Puerto Rico where the emergency calling number is 911. More information: [How emergency calling works in the voice channel](voice-channel-emergency-calling.md)

### Are charges applicable for using the voice channel?

Yes. To understand the pricing calculation of various scenarios, see: [Pricing scenarios for voice calling](voice-channel-pricing-scenarios.md)

### See also

[Introduction to the voice channel](voice-channel.md)  
[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
