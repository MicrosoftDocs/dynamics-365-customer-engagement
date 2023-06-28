---
title: "Sample configuration to integrate an Azure bot | MicrosoftDocs"
description: "This article includes a sample configuration integrate Azure bots with Omnichannel for Customer Service."
ms.date: 05/16/2022
author: neeranelli
ms.author: nenellim
ms.topic: article
---

# Sample configuration to integrate an Azure bot

This article provides the exact steps and configuration values to integrate an Azure bot with Omnichannel for Customer Service, and then escalate the query to a human agent. 

In this sample configuration, three queues and three routing rules are created. The bot user is added to one queue, and the agents are added to the two other queues. Routing rules are defined in such a way that whenever a customer starts a chat, it will be first sent to the bot, and then escalated to a human agent as per the conditions defined in the routing rules. The workstream used in this sample is **ChatWorkStream**.

1. [Configure the bot user as an omnichannel agent](configure-bot.md#configure-the-bot-user-as-an-omnichannel-agent).

2. [Create the following three queues](set-up-queues-manage-activities-cases.md#create-a-queue) and add users as follows:
    - **BotQueue**: Add the bot user to this queue.
    - **CreditCardQueue**: Add agents who will handle queries related to credit card.
    - **HomeLoanQueue**: Add agents who will handle queries related to home loan.

3. [Add a context variable](manage-context-variables.md#add-context-variables). Let's say you create a context variable named **BotHandoffTopic** in the **ChatWorkStream** workstream.

4. [Create the following routing rules](routing-rules.md) in the **ChatWorkStream** workstream in this order:
    - **BotRule**: Specify the workstream and queue as **ChatWorkStream** and **BotQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query to bot.](media/bot-rule.png "Create a rule to send customer query to bot")
    - **CreditCardRule**: Specify the workstream and queue as **ChatWorkStream** and **CreditCardQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Send customer queries from a bot to an agent, by creating a rule.](media/credit-card-rule.png "Send customer queries from a bot to an agent, by creating a rule.")
    - **HomeLoanRule**: Specify the workstream and queue as **ChatWorkStream** and **HomeLoanQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent.](media/home-loan-rule.png "Create a rule to send a customer query from a bot to an agent")
5. [Configure the Azure bot to escalate and end conversations](bot-escalate-end-conversation.md).

When a chat is started by a customer, the query is routed to the bot through the **BotRule** routing rule. If the bot escalates the query, it is sent to the appropriate agent as per the configured routing rules. The bot needs to send the correct context variable and its value in the escalation request to route the query appropriately.

### See also

[Integrate an Azure bot ](configure-bot.md)  
[Best practices for configuring Azure and Power Virtual Agents bots](configure-azure-bot-best-practices.md)  
[Configure Azure bots to escalate and end conversation](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  
[View bot insights](omnichannel-insights-dashboard.md#botinsights)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
