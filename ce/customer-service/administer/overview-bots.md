---
title: Overview of agents
description: Get an overview of agents and how you can configure and use them in Dynamics 365 Contact Center.
ms.date: 04/21/2025
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: overview
ms.collection:
ms.custom: bap-template
---

# Overview of agents

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


An AI agent is a program that provides automated responses in a conversational manner to a customer. It can also help resolve customer queries by using case deflection. An agent can also collect basic information from a customer and then provide it to a customer service representative (service representative or representative) to work further on the issue raised by the customer.  

An agent eases the load on your customer service service representatives by handling basic queries. This saves your representatives' time so they can work on more complex issues. You can configure your agents to escalate a query to a human representative as required, or when requested by the customer.

In Dynamics 365 Contact Center, you can integrate agents created in both Azure and Copilot Studio to perform tasks like starting a conversation with the customer, providing automated responses, and then transferring the conversation to a service representative, as required.

## Integrate Azure and Copilot agents

When you integrate agents with Dynamics 365 Contact Center, you get the following capabilities:

- Seamlessly integrate your agents with chat and social channels without needing to add channel-specific code in the agent.
- Transfer chat conversations from agents to representatives, together with the full context of the conversation.
- Analyze the agent transcript that's available in Microsoft Dataverse after the conversation is completed.
- Configure routing rules to selectively route incoming requests to agents based on context, such as issue type or customer type. For example, you can route low-complexity issues, or route the conversation to a sales or support agent based on the web browsing history of the customer.
- Monitor agent conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use historical dashboards to get insights into the effectiveness of the agents through metrics such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.
- Configure post-call surveys to measure customer satisfaction.

### Related information

[Bot sessions and licensing](bot-session-licensing.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Copilot Studio bot](configure-bot-virtual-agent.md)  
[Configure Copilot Studio bot for voice](voice-channel-pva-bots.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
