---
title: FAQ about the InBound and OutBound calls, VoiceMail and Transcripts
description: Use this article to know answers to your frequently asked questions (FAQ) about the inBound and outBound calls, voicemail, and transcripts.
ms.date: 07/29/2024
ms.topic: conceptual
author: snehasishlaik
ms.author: v-slaik
ms.reviewer: v-slaik
ms.collection:
ms.custom: bap-template
---

# InBound, OutBound Calls, Voice mail, Transcripts

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article includes frequently asked questions (FAQ) about the the inBound and outBound calls, voicemail and transcripts.

## General

### Why is the agent unable to make an outbound call?

The agent must be a part of the outbound voice queue to make an outbound call. See [Set up outbound calling](voice-channel-outbound-calling.md) for information.

### Are overflow actions like voicemail and direct callback fulfilled for fallback queues?

No, overflow settings are not applicable to fallback queues. The settings are ignored, and the routed work item is assigned to the queue. More information: [How overflow works](manage-overflow.md#handle-overflow-before-work-item-is-queued)

### Does the voice channel include real-time keyword recognition or sentiment tracking while an agent is on a call?

Yes, features such as sentiment analysis, agent suggestions for similar cases or knowledge articles, are available in the voice channel.

### See also

[Introduction to the voice channel](voice-channel.md)  
[System requirements for Omnichannel for Customer Service](../implement/system-requirements-omnichannel.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)