---
title: "FAQ about the voice channel | MicrosoftDocs"
description: "This article includes frequently asked questions (FAQ) about the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/17/2022
ms.topic: article

---

# FAQ about the voice channel in Omnichannel for Customer Service

## Overview

This topic contains frequently asked questions (FAQ) about the voice channel.

### Does the voice channel include real-time keyword recognition or sentiment tracking while an agent is on a call?

Yes, features such as sentiment analysis and agent suggestions for similar cases or knowledge articles work with the voice channel.

### Is the voice channel PCI DSS compliant?

The voice channel is compliant with Payment Card Industry Data Security Standard (PCI DSS) today, but support for credit card data capture over voice isn't yet available. Agents have the ability to pause or resume call recording and transcription to avoid capturing sensitive information. Agents can also pause transcription to avoid dual-tone multi-frequency (DTMF) tones being captured in the transcript. All data is stored in Dynamics 365 and can be scrubbed by the customer.

### Where does Azure Communication Services provide native PSTN services?

Getting registered as a carrier is a legally complex and country-specific process. Azure Communication Services has a multiyear roadmap to become a carrier in different countries and regions. As of January 2022, Azure Communication Services provides “Direct Offers” of toll-free and local numbers (Microsoft through Azure Communication Services is the carrier) for those with billing postal codes in United States,  Puerto Rico, United Kingdom, and Ireland.

An alternative to Microsoft as a carrier is Azure direct routing that allows customers to bring their own carrier. More information: [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept)

### What about countries where Azure Communication Services doesn't provide native PSTN services?

Azure Communication Services is available worldwide, even if it isn't acting as the carrier in certain countries. For these countries, Azure Communication Services provides a direct routing for local carriers, such as AT&T and Verizon, to connect to Azure Communication Services. With this mechanism, customers will still be able to deploy and use all the features of the voice channel in Dynamics 365.

### What codecs are implemented in the voice channel?

The voice channel supports the G.711 and Opus codecs for PSTN and VoIP services.

### Can I bring my own phone number?

Yes, you have the following two options to bring your existing numbers to Dynamics 365:

- Port the number to Azure Communication Services. This will change ownership of the phone number from the existing carrier to Microsoft. More information: [Quickstart: Port a phone number into Azure Communication Services](/azure/communication-services/quickstarts/telephony/port-phone-number)

- Configure Azure direct routing. This will require you to configure a Session Border Controller (SBC) that is connected to your local carrier with Azure Communication Services, and register the phone number in Dynamics 365. More information: [Azure direct routing infrastructure requirements](/azure/communication-services/concepts/telephony/direct-routing-infrastructure)
 
### How can I acquire additional phone numbers from Azure direct offer?

You can purchase one phone number per tenant for Azure Communication Services through the Azure portal. To acquire phone numbers in bulk or request a specific phone number, download and complete this [form](https://github.com/Azure/Communication/blob/master/Forms/ACS%20-%20Manual%20Number%20Acquisition%20Form%20US-UK-CA-DK.docx) and email it to acstnrequest@microsoft.com. Ensure that the subject line of the email begins with "Azure Communication Services Number Request:".

### Can I keep my existing contract with my carrier?

Yes, you can.

### Can I configure a third-party voice provider in Omnichannel for Customer Service?

Yes, you can use the Dynamics 365 Channel Integration Framework 2.0 connector to integrate third-party contact centers, such as Genesys Engage, Solgari, and NICE inContact.

### Does the voice channel tie in with Azure Communication Services or is it an entirely different technology?

The voice capabilities for Dynamics 365 Customer Service are built on Azure Communication Services.

### Will Azure Communication Services be an add-on service? I already have a competitor phone system and have Microsoft Teams.

Dynamics 365 doesn’t use calling plans for its voice channel. However, if customers are using Azure direct routing with Microsoft Teams, the same SBCs and setup can be used with Azure direct routing to reuse the voice channel. More information: [Bring your own carrier](voice-channel-bring-your-own-number.md)

### Is it possible to enable voice integrations outside of the Omnichannel for Customer Service app? For example, by adding omnichannel capabilities to a customer Dynamics 365 app.

The voice channel is supported only in the Customer Service workspace and Omnichannel for Customer Service apps.

### How can I set up an IVR bot in the voice channel?

See the following topics to set up the interactive voice response (IVR) bot in the voice channel:
- [Configure Power Virtual Agents bots for voice](voice-channel-ivr-bots.md)
- [Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)

### Should the language of the bot be the same as the primary language configured in the Omnichannel admin center app?
 
Yes, the language of the bot must be the same as that of the voice workstream to which the bot will be attached. You can configure different geographic locales for the bot and voice workstream.

For example, you can set English-UK in the voice profile and English-US in the bot.

The bot's accuracy depends on the similarities between locales. However, if you configure different locales, preconfigured entities for the bot such as postal code might not be accurate. 

### Can I recover a voice trial after it's no longer provisioned?

No, you can't recover your data and trial phone numbers after the trial organization is deprovisioned.

### Is disaster recovery supported for the voice channel?

- Business Continuity and Disaster Recovery (BCDR) for production instances of the voice channel are supported on a geographical basis. In certain regions BCDR will be a fast follow. For details on the geographies that are currently supported and the geographies where BCDR is a fast follow, see [Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md).
- In supported regions, BCDR policies are based upon business continuity and disaster recovery for Dynamics 365 and SLA for Azure Communication Services. For more information, see [Business continuity and disaster recovery](/power-platform/admin/business-continuity-disaster-recovery) and [SLA for Azure Communication Services](https://azure.microsoft.com/support/legal/sla/communication-services/v1_0/).

### Does the voice channel support emergency calling?

Yes, the voice channel supports emergency calling; agents can call the emergency number during a crisis. This feature is currently supported in the United States and Puerto Rico where the emergency calling number is 911. More information: [How emergency calling works in the voice channel](voice-channel-emergency-calling.md)

### See also

[Introduction to the voice channel](voice-channel.md)  
[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
