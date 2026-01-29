---
title: Set up IVR agents in the voice channel using Copilot Studio
description: Learn about how to add a Copilot agent to use in the voice channel in Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 01/19/2026
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Set up IVR agents in the voice channel using Copilot Studio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

To route customer calls to the best department, diagnose issues, collect information, and give recommendations, conversational IVR agents speak to customers when they call. Copilot Studio makes it easy to author Interactive Voice Response (IVR) agents, and you can use the same agents for other channels, like chat and voice.

The following voice capabilities are available for the Copilot agents:

- Collect customer input through speech or [Dual-Tone Multi-Frequency (DTMF)](/microsoft-copilot-studio/voice-dtmf). Customers can talk without using a prompt script, and Copilot understands their commands or questions. Customers can also enter data by pressing keys on their phone keypad. The Copilot agent detects when customers stop speaking using silence detection and responds accordingly.

- Adjust the voice output by using [speech synthesis markup language (SSML)](/microsoft-copilot-studio/voice-configuration#format-speech-synthesis-with-ssml). You can change the tone, pitch, and speed of the voice that interacts with customers.
- You can also upload your audio files to use in the agent. For example, you can upload a custom greeting or a message that plays when the agent can't understand the customer's request. Learn more in [Play secure audio file from Copilot Studio](/dynamics365/guidance/resources/copilot-studio-play-audio-file).
- Enable [barge-in](/microsoft-copilot-studio/voice-configuration#enable-barge-in) to let customers interrupt the Copilot agent at any time. You can also use long-running operation messages to let customers know that the voice-enabled Copilot is working on their request.
- [!INCLUDE[cc-natural-language-model](../../includes/cc-natural-language-model.md)]
- Enable constrained speech recognition using grammars for optimized recognition of alphanumeric strings like tracking and account numbers and list-based input like addresses and stock tickers. Learn more in [Use external speech grammars](/microsoft-copilot-studio/voice-external-grammars).
- Control the call flow by [transferring](/microsoft-copilot-studio/voice-configuration#transfer-a-call-to-an-agent-or-external-phone-number) or [terminating](/microsoft-copilot-studio/voice-configuration#configure-call-termination) calls. If a customer wants to talk to a live representative, the voice copilot can transfer the call to an available representative or an external phone number. If the voice copilot can't solve the customer issue, it can end the call and give an appropriate message.

## Supported languages and locale codes

Learn about the supported languages and locales for IVR capabilities in [Supported languages and locale codes](/dynamics365/customer-service/administer/voice-channel-supported-languages?context=/dynamics365/contact-center/context/administer-context).

## Prerequisites

Perform the steps in [Integrate a Copilot agent](configure-bot-virtual-agent.md). We recommend that you perform the steps in the specified order:

1. [Acquire phone numbers](/dynamics365/customer-service/administer/voice-channel-manage-phone-numbers) or set up [bring your own carrier](/dynamics365/customer-service/administer/voice-channel-bring-your-own-number) phone numbers.
1. Create a workstream and configure the corresponding routing rules for the workstream.
1. Set up voice channel in that workstream and link a phone number to the channel.
1. Add an IVR agent to that workstream.

You can then specify how the agent should handle failure conditions and set up the agent to handle multiple languages.

## Set up IVR features in the workstream

In the voice channel, you can configure the following features for the IVR agents:

- Set up your IVR agent to [handle multiple languages](/dynamics365/contact-center/administer/configure-multilingual-agents?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.yml).

## Automatically end conversations

The duration of a bot-handled voice call can be one hour only. The call is disconnected if it doesn't end or is escalated. The limit isn't applicable after the call is transferred to an agent or external number.

## Next steps

[Configure a sample voice agent template](/dynamics365/contact-center/administer/bot-scenario-configure)

### Related information

[Overview of the voice channel](voice-channel.md)  
[Configure context variables](context-variables-for-bot.md)  
[Manage your bots](manage-your-bots.md)  
[Set up a multilingual bot in Copilot Studio](set-up-multilingual-pva-bot.md)  
[Use best practices for configuring AI agents](configure-bot-best-practices.md)  
