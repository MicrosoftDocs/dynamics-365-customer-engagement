---
title: "Configure a bot | MicrosoftDocs"
description: "Instructions to configure a bot in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B76E910B-0018-4499-B21F-6FEBDFBB2A22
ms.custom: 
---

# Work with bots

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

A bot is a program that initiates a conversation with a customer and collect basic information. This basic information is then provided to a customer service agent to work further on the issue raised by the customer.

You can ease the load on your customer service agents by using bots that can handle basic queries from the customer. This will save some of your agent’s time and they can work on more complex issues. Bots can be configured to escalate the query to a human agent as and when required by the customer.

In Omni-channel Engagement Hub, you can integrate a bot to start the conversation to a customer and then shift the conversation to a human agent as required. Let’s now see how to integrate a bot with Omni-channel Engagement Hub.

## Integrate a bot with Omni-channel Engagement Hub

**Prerequisites**: You must ensure that you have a bot that is built by using Microsoft Bot Framework. For more information on how to build a bot, see [Azure Bot Service Documentation](https://docs.microsoft.com/en-us/azure/bot-service/?view=azure-bot-service-4.0).

To integrate a bot with Omni-channel Engagement Hub, you must:

1.	[Create a bot user](#step-1-create-a-bot-user)
2.	[Create a work stream and context variable](#step-2-create-a-work-stream-and-context-variable)
3.	[Create queues](#step-3-create-queues)
4.	[Creating routing rules](#step-4-creating-routing-rules)
5.	[Create a chat widget](#step-5-create-a-chat-widget)

### Step 1: Create a bot user

Creating a bot user is supported in the web-client only. A bot user is created as an application user and assigned with the Omni-channel agent role. To create a bot user, you must have the following information available:

- Application ID of your Dynamics 365 for Customer Engagement app that is registered in Azure Active Directory
- Bot application ID of your bot

To create a bot user:

1.	Sign in to Dynamics 365 for Customer Engagement app.

2.	Go to **Settings** > **Security**.

3.	Select **Users**.

4.	Change the view to **Application Users**.

5.	Select **New**.

6.	On the **New User** page, enter the following information:
    - **Name**: Name of the bot user.
    - **Application ID**: Application ID of your Dynamics 365 for Customer Engagement app from Azure AD.
    - **Full Name**: Full name of the bot user.
    - **Primary Email**: Email of the bot user.
    - **Agent type**: Select Bot.
    - **Bot application ID**: Bot's application ID from Azure AD.

7.	Save the record.

8.	Select **Manage Roles** on the command bar.

9.	In the **Mange User Roles** window, select **Omni-channel agent**, and then select **OK**.

### Step 2: Create a work stream and context variable

You must create a work stream and the required context variable for the bot handle the customer queries appropriately. The context variable is used in routing the incoming customer queries to the appropriate bots and agents. You must create a context variable named **BotHandoffTopic**. This context variable will be used in [Step 4](#step-4-creating-routing-rules) when you create routing rules. For information on creating a work stream and context variables, see [Understand and create work streams](work-streams-introduction.md).

> [!NOTE]
> If you want to use any other context variable, it must be updated in the bot code.

### Step 3: Create queues

Queues distribute the incoming customer queries among bots and agents. You must add a bot user as the first user in the queue and then followed by the agents. You can also create multiple queues for bot users and agents. For information on creating a queue, see [Work with queues in Omni-channel Engagement Hub](queues-omni-channel.md).

### Step 4: Creating routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable (as defined in [Step 2](#step-2-create-a-work-stream-and-context-variable)).

You must set the value of the **BotHandoffTopic** context variable to **Does Not Contain Data** for a bot to engage in a conversation. Set the value of the context variable to any other value as per the requirement to route the conversation to a human agent. You must keep the routing rule that maps to the queue containing a bot user as the first routing rule.

Ensure to map the routing rules to the correct queues so that the queries are routed appropriately. For information on creating a routing rule, see [Create and manage routing rules](routing-rules.md).

### Step 5: Create a chat widget

A chat widget lets your customers connect with you in a way that is convenient for them (for example, from their mobile devices or a computer). The bot or customer service agents can then connect with the customers to respond to their queries. For information on creating a chat widget, see [Add a chat widget](add-chat-widget.md).

## Sample configuration to integrate a bot

This sample provides exact steps and configuration values to integrate a bot and then escalate the query to a human agent. In this sample, three queues and three routing rules will be created. Bot user is added to one queue and agents are added to other two queues. Routing rules are defined in a way that whenever a customer initiates a chat, it will be sent to the bot first and then escalated to a human agent as per the conditions defined in the routing rules .

1.	Follow the instructions in [Step 1](#step-1-create-a-bot-user) to create a bot user.

2.	Follow the instructions in [Step 2](#step-2-create-a-work-stream-and-context-variable) to create a work stream and a context variable named **BotHandoffTopic**. Let's say you created a work stream named **BotWorkStream**.

3.	Follow the instructions in [Step 3](#step-3-create-queues) to create three queues as follows:
    - **BotQueue**: Add the bot user to this queue.
    - **CreditCardQueue**: Add agents who will handle credit card related queries.
    - **HomeLoanQueue**: Add agents who will handle home loan related queries.

4.	Follow the instructions in [Step 4](#step-4-creating-routing-rules) to create three routing rules in the **BotWorkStream** work stream in the following order:
    - **BotRule**: Specify the work stream and queue as **BotWorkStream** and **BotQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query to bot](../media/bot-rule.png "Create a rule to send customer query to bot")
    - **CreditCardRule**: Specify the work stream and queue as **BotWorkStream** and **CreditCardQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent](../media/credit-card-rule.png "Create a rule to send customer query from bot to an agent")
    - **HomeLoanRule**: Specify the work stream and queue as **BotWorkStream** and **HomeLoanQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent](../media/home-loan-rule.png "Create a rule to send customer query from bot to an agent")

5.	Follow the instructions in [Step 5](#step-5-create-a-chat-widget) to create a chat widget and specify the work stream as **BotWorkStream**.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization’s compliance boundary (even if your organization is in a Government Cloud environment). For more information on how we process your data, please refer to the Microsoft Privacy Statement.

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Work with queues in Omni-channel Engagement Hub](queues-omni-channel.md)<br>
[Work with queues in Omni-channel Engagement Hub](queues-omni-channel.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Add a chat widget](add-chat-widget.md)
