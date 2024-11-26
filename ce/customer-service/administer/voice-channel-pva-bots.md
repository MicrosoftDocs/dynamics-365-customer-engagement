---
title: Set up IVR bots in the voice channel using Copilot Studio
description: Learn about how to add a Copilot Studio bot to use in the voice channel.
author: gandhamm
ms.author: mgandham
ms.reviewer: shujoshi
ms.date: 11/15/2024
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Set up IVR bots in the voice channel using Copilot Studio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

To route customer calls to the best department, diagnose issues, collect information, and give recommendations, conversational IVR bots speak to customers when they call. Copilot Studio makes it easy to author Interactive Voice Response (IVR) bots, and you can use the same bots for other channels, like chat and voice.

The following voice capabilities are available for the Copilot Studio bots:

- Collect customer input through speech or [Dual-Tone Multi-Frequency (DTMF)](/microsoft-copilot-studio/voice-dtmf). Customers can talk without using a prompt script, and Copilot understands their commands or questions. Customers can also enter data by pressing keys on their phone keypad. The Copilot bot detects when customers stop speaking using silence detection and responds accordingly.
- Adjust the voice output by using [speech synthesis markup language (SSML)](/microsoft-copilot-studio/voice-configuration#format-speech-synthesis-with-ssml). You can change the tone, pitch, and speed of the voice that interacts with customers.
- You can also upload your audio files to use in the bot. For example, you can upload a custom greeting or a message that plays when the bot can't understand the customer's request. Learn more in [Play secure audio file from Copilot Studio](/dynamics365/guidance/resources/copilot-studio-play-audio-file).
- Enable [barge-in](/microsoft-copilot-studio/voice-configuration#enable-barge-in) to let customers interrupt Copilot at any time. You can also use long-running operation messages to let customers know that the voice-enabled Copilot is working on their request.
- Control the call flow by [transferring](/microsoft-copilot-studio/voice-configuration#transfer-a-call-to-an-agent-or-external-phone-number) or [terminating](/microsoft-copilot-studio/voice-configuration#configure-call-termination) calls. If a customer wants to talk to a live representative, the voice copilot can transfer the call to an available representative or an external phone number. If the voice copilot can't solve the customer issue, it can end the call and give an appropriate message.

## Supported languages and locale codes

Learn about the supported languages and locales for IVR capabilities in [Supported languages and locale codes](/dynamics365/customer-service/administer/voice-channel-supported-languages?context=/dynamics365/contact-center/context/administer-context).

## Prerequisites

Perform the steps in [Integrate a Copilot Studio bot](configure-bot-virtual-agent.md). We recommend that you perform the steps in the specified order:

1. [Acquire phone numbers](/dynamics365/customer-service/administer/voice-channel-manage-phone-numbers) or set up [bring your own carrier](/dynamics365/customer-service/administer/voice-channel-bring-your-own-number) phone numbers.
1. Create a workstream and configure the corresponding routing rules for the workstream.
1. Set up voice channel in that workstream and link a phone number to the channel.
1. Add an IVR bot to that workstream.

You can then specify how the bot should handle failure conditions and set up the bot to handle multiple languages.

## Set up IVR features in the workstream

In the voice channel, you can configure the following features for the IVR bots:

- Set up your IVR bot to [handle multiple languages](/dynamics365/contact-center/administer/configure-multilingual-agents?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.yml).

## Automatically end conversations

The duration of a bot-handled voice call can be one hour only. The call is disconnected if it doesn't end or escalated. The limit isn't applicable after the call is transferred to an agent or an external number.

## Next steps

[Configure a sample voice agent template](/dynamics365/contact-center/administer/bot-scenario-configure)

### Related information

[Overview of the voice channel](/dynamics365/customer-service/administer/voice-channel)  
[Configure context variables](/dynamics365/customer-service/administer/context-variables-for-bot)  
[Manage your bots](/dynamics365/customer-service/administer/manage-your-bots?context=/dynamics365/contact-center/context/administer-context)  
[Set up a multilingual bot in Copilot Studio](/dynamics365/customer-service/administer/set-up-multilingual-pva-bot)  