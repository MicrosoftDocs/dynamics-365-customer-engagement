---
title: "FAQs about the voice channel | MicrosoftDocs"
description: ""Learn about the frequently asked questions (FAQs) for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/10/2021
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

Getting registered as a carrier is a legally-complex and country-specific process. ACS has a multi-year road map to become a carrier in different countries around the world. As of November 2021, ACS provides “Direct Offers” of toll-free and local numbers in United States only. ACS plans to expand to Canada, Puerto Rico, United Kingdom and Ireland in 2022.

An alternative to direct offers is Azure direct routing that allows customers to bring their own numbers via local carriers. More information: [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept)
