---
title: Set up IVR agents in the voice channel using Copilot Studio
description: Learn about how to add a Copilot agent to use in the voice channel in Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 11/26/2026
ms.update-cycle: 180-days
ms.topic: how-to
ai-usage: ai-assisted
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Set up IVR agents in the voice channel using Copilot Studio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

Use Microsoft Copilot Studio to create interactive voice response (IVR) agents that answer customer calls, diagnose issues, collect information, and route calls to service representatives. You can also use these agents in other channels, such as chat.

IVR agents support the following voice capabilities:

- Collect customer input through speech or [dual-tone multifrequency (DTMF)](/microsoft-copilot-studio/voice-dtmf). Customers can speak naturally or enter data by pressing keys on their phone keypad. The IVR agent uses silence detection to identify when customers stop speaking and respond to their commands or questions.

- Adjust the voice output by using [speech synthesis markup language (SSML)](/microsoft-copilot-studio/voice-configuration#format-speech-synthesis-with-ssml). You can change the tone, pitch, and speed of the voice that interacts with customers.
- Upload audio files, such as a custom greeting or a message that plays when the agent can't understand the customer's request. Learn more in [Play secure audio file from Copilot Studio](/dynamics365/guidance/resources/copilot-studio-play-audio-file).
- Enable [barge-in](/microsoft-copilot-studio/voice-configuration#enable-barge-in) to let customers interrupt the IVR agent at any time. You can also use long-running operation messages to let customers know that the agent is working on their request.
- [!INCLUDE[cc-natural-language-model](../../includes/cc-natural-language-model.md)]
- Enable constrained speech recognition using grammars for optimized recognition of alphanumeric strings like tracking and account numbers and list-based input like addresses and stock tickers. Learn more in [Use external speech grammars](/microsoft-copilot-studio/voice-external-grammars).
- Control the call flow by [transferring](/microsoft-copilot-studio/voice-configuration#transfer-a-call-to-an-agent-or-external-phone-number) or [terminating](/microsoft-copilot-studio/voice-configuration#configure-call-termination) calls. If a customer wants to talk to a service representative, the IVR agent can transfer the call to an available representative or an external phone number. If the IVR agent can't resolve the issue, it can end the call and provide an appropriate message.
- Context from and to external systems as part of the telephony call can be passed through Dynamics 365 Contact Center voice agents. The setting applies to incoming calls and outbound transfers to external phone numbers with direct routing telephony configuration. Context is supported through SIP User-to-User (SIP UUI) headers and SIP X-Headers. UUI enables passing extended call-related data in a standardized field, while SIP X-Headers provide a flexible way to include custom context fields, helping organizations preserve existing telephony setups and enabling richer integration across systems. Learn about how to configure SIP X-headers in [Configure SIP X-headers for voice-enabled agents](/microsoft-copilot-studio/voice-sip-x-header).

## Supported languages and locale codes

Learn about the supported languages and locales for IVR capabilities in [Supported languages and locale codes](/dynamics365/customer-service/administer/voice-channel-supported-languages?context=/dynamics365/contact-center/context/administer-context).

## Prerequisites

Follow the steps in [Integrate a Copilot agent](configure-bot-virtual-agent.md). Complete the following tasks in order:

1. [Acquire phone numbers](/dynamics365/customer-service/administer/voice-channel-manage-phone-numbers) or set up [bring your own carrier](/dynamics365/customer-service/administer/voice-channel-bring-your-own-number) phone numbers.
1. Create a workstream and configure its routing rules.
1. Set up the voice channel in the workstream and link a phone number to the channel.
1. Add an IVR agent to the workstream.

You can then specify how the agent should handle failure conditions and set up the agent to handle multiple languages.

<a name="set-up-ivr-features-in-the-workstream"></a>

## Set up multilingual IVR agents

Set up your IVR agent to [handle multiple languages](/dynamics365/contact-center/administer/configure-multilingual-agents?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.yml).

## Automatically end conversations

The duration of a bot-handled voice call can be one hour only. The call is disconnected if it doesn't end or is escalated. The limit isn't applicable after the call is transferred to an agent or external number.

## Regulatory and compliance considerations

In some geographical regions, your organization might be legally required to inform callers when it uses AI-generated voice responses. You can configure an introductory greeting message with an AI disclosure that plays before the conversation with the AI agent begins.

Learn more in [Configure automated messages](configure-automated-message.md).

## Next steps

[Configure a sample voice agent template](/dynamics365/contact-center/administer/bot-scenario-configure)

## Related information

[Overview of the voice channel](voice-channel.md)  
[Configure context variables](context-variables-for-bot.md)  
[Manage your bots](manage-your-bots.md)  
[Set up a multilingual bot in Copilot Studio](set-up-multilingual-pva-bot.md)  
[Use best practices for configuring AI agents](configure-bot-best-practices.md)  
