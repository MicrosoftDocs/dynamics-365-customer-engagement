---
title: "Overview of bots | MicrosoftDocs"
description: "Get an overview of bots and how you can configure and use them in Omnichannel for Customer Service."
ms.date: 05/16/2022
author: neeranelli
ms.author: nenellim
ms.collection: get-started
---

# Overview of bots

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

A bot is a program that provides automated responses in a conversational manner to a customer. It can also help resolve customer queries by using case deflection. A bot can also collect basic information from a customer and then provide it to a customer service agent to work further on the issue raised by the customer.  

A bot eases the load on your customer service agents by handling basic queries. This saves your agents' time so they can work on more complex issues. You can configure your bots to escalate a query to a human agent as required, or when requested by the customer.

In Omnichannel for Customer Service, you can integrate both Azure and Power Virtual Agents bots to perform tasks like starting a conversation with the customer, providing automated responses, and then transferring the conversation to a human agent, as required.

## Integrate Azure and Power Virtual Agents bots

When you integrate bots with Omnichannel for Customer Service, you get the following capabilities:

- Seamlessly integrate your bots with chat and social channels without needing to add channel-specific code in the bot.
- Transfer chat conversations from bots to human agents, together with the full context of the conversation.
- Analyze the bot transcript that's available in Microsoft Dataverse after the conversation is completed.
- Configure routing rules to selectively route incoming requests to bots based on context, such as issue type or customer type. For example, you can route low-complexity issues to bots, or route the conversation to a sales or support bot based on the web browsing history of the customer.
- Monitor bot conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use historical dashboards to get insights into the effectiveness of the bots through metrics such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.
- Configure post-call surveys to measure customer satisfaction.

### See also

[Bot sessions and licensing](bot-session-licensing.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure Power Virtual Agents bot for voice](voice-channel-pva-bots.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
