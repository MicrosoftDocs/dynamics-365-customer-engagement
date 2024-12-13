---
title: Overview of agents
description: Get an overview of agents and how you can configure and use them in Omnichannel for Customer Service.
ms.date: 12/14/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.collection:
ms.custom: bap-template
---

# Overview of agents

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


A bot is a program that provides automated responses in a conversational manner to a customer. It can also help resolve customer queries by using case deflection. A bot can also collect basic information from a customer and then provide it to a customer service customer service representative (service representative or representative) to work further on the issue raised by the customer.  

A bot eases the load on your customer service service representatives by handling basic queries. This saves your representatives' time so they can work on more complex issues. You can configure your bots to escalate a query to a human representative as required, or when requested by the customer.

In Omnichannel for Customer Service, you can integrate both Azure and Copilot Studio bots to perform tasks like starting a conversation with the customer, providing automated responses, and then transferring the conversation to a service representative, as required.

## Integrate Azure and Copilot Studio bots

When you integrate bots with Omnichannel for Customer Service, you get the following capabilities:

- Seamlessly integrate your bots with chat and social channels without needing to add channel-specific code in the bot.
- Transfer chat conversations from bots to representatives, together with the full context of the conversation.
- Analyze the bot transcript that's available in Microsoft Dataverse after the conversation is completed.
- Configure routing rules to selectively route incoming requests to bots based on context, such as issue type or customer type. For example, you can route low-complexity issues to bots, or route the conversation to a sales or support bot based on the web browsing history of the customer.
- Monitor bot conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use historical dashboards to get insights into the effectiveness of the bots through metrics such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.
- Configure post-call surveys to measure customer satisfaction.

### Related information

[Bot sessions and licensing](bot-session-licensing.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Copilot Studio bot](configure-bot-virtual-agent.md)  
[Configure Copilot Studio bot for voice](voice-channel-pva-bots.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
