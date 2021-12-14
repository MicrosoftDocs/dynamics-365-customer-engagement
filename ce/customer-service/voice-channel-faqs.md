---
title: "FAQs about the voice channel | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# FAQs about the voice channel in Omnichannel for Customer Service

## Overview

This topic contains the FAQs that you might have about the voice channel.

### Are real-time keyword recognition or sentiment tracking while an agent is on a call included with the voice channel?

Yes, features, such as sentiment analysis and agent suggestions for similar cases or knowledge articles will work with the voice channel.

### Is the voice channel PCI DSS compliant?

The voice channel implements Payment Card Industry Data Security Standard (PCI DSS) standards today, but support for credit card capture over voice is not yet available. Agents have the ability to pause or resume call recording and transcription to avoid capturing sensitive information. Agents don't hear dual tone multi frequency (DTMF) tones by design, and can pause transcription to avoid DTMF being captured in the transcript. All data is stored in Dynamics 365 and can be scrubbed by the customer.

### Where does Azure Communication Services provide native PSTN services?

Getting registered as a carrier is a legally-complex and country-specific process. Azure Communication Services has a multi-year road map to become a carrier in different countries around the world. As of November 2021, Azure Communication Services provides “Direct Offers” of toll-free and local numbers in United States only. Azure Communication Services plans to expand to Canada, Puerto Rico, United Kingdom, and Ireland in 2022.

An alternative to direct offers is Azure direct routing that allows customers to bring their own numbers via local carriers. More information: [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept)


### What about countries where Azure Communication Services doesn't provide native PSTN services?

Azure Communication Services is available worldwide, even if it isn't acting as the carrier in certain countries. For these countries, Azure Communication Services provides a direct routing for local carriers, such as AT&T and Verizon, to connect to Azure Communication Services. Through this mechanism, customers will still be able to deploy and use all the features of the voice channel in Dynamics.

### Can I bring my own phone number?

Yes, you have the following two options to bring your existing numbers to Dynamics 365:

- Port the number to Azure Communication Services. This will change ownership of the phone number from the existing carrier to Microsoft. More information: [Quickstart: Port a phone number into Azure Communication Services](/azure/communication-services/quickstarts/telephony/port-phone-number)

- Configure Azure direct routing. This will require you to configure a Session Border Controller (SBC) that is connected to your local carrier with Azure Communication Services, and register the phone number in Dynamics 365. More information: [Azure direct routing infrastructure requirements](/azure/communication-services/concepts/telephony/direct-routing-infrastructure)

### Can I keep my existing contract with my carrier?

Yes, you can.

### Can I configure my own voice provider in Omnichannel?

Yes, you can use Dynamics 365 Channel Integration Framework 2.0 connector to integrate third-party contact centers, such as Genesys Engage, Solgari, and NICE inContact.

### Does the voice channel tie in with Azure Communications Services or is it entirely a different technology?

The voice capabilities for Dynamics 365 Customer Service are built on the Azure Communications Services.

### Will Azure communications be an add-on service? I already have a competitor phone system and have Microsoft Teams?

Dynamics 365 doesn’t use calling plans for its voice channel. However, if customers are using Azure direct routing with Microsoft Teams, the same SBCs and setup can be used with Azure direct routing to reuse the voice channel.

### Is it possible to enable voice integrations outside of the Omnichannel for Customer Service app? For example, by adding omnichannel capabilities to a customer Dynamics 365 app?

The voice channel is supported only in the Customer Service workspace and Omnichannel for Customer Service apps.

### See also

[Introduction to the voice channel](voice-channel.md)  
[System requirements](system-requirements-omnichannel.md)  
[Voice channel regional availability](voice-channel-region-availability.md)  
