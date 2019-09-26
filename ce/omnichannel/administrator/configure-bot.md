---
title: "Configure a bot | MicrosoftDocs"
description: "Instructions to configure a bot in Omnichannel for Customer Service."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B76E910B-0018-4499-B21F-6FEBDFBB2A22
ms.custom: 
---

# Preview: Integrate an Azure bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

A bot is a program that provides automated responses in a conversational manner to a customer. It can also help in resolving customer queries by using case deflection. A bot can also collect basic information from a customer and then provided it to a customer service agent to work further on the issue raised by the customer.  

A bot eases the load on your customer service agents by handling basic queries. This saves your agents' time and they can work on more complex issues. You can configure your bots to escalate the query to a human agent as and when required by the customer.

In Omnichannel for Customer Service, you can integrate a bot to start the conversation with a customer, provide automated responses, and then shift the conversation to a human agent, if required. Let's now see how to integrate a bot with Omnichannel for Customer Service.

## Integrate a bot with Omnichannel for Customer Service 

**Prerequisites**: You must have a bot that is built using Microsoft Bot Framework. For more information on how to build a bot, see [Azure Bot Service Documentation](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0).

To integrate a bot with Omnichannel for Customer Service, you must:

1.	[Create a bot user](#step-1-create-a-bot-user)
2.	[Add a bot user to the queue(s)](#step-2-add-a-bot-user-to-the-queues)
3.  [Add code snippet to engage a bot](#step-3-add-code-snippet-to-engage-a-bot)
4.	[Set escalation rules](#step-4-set-escalation-rules)


### Step 1: Create a bot user

A bot user is created as an application user and assigned with the **Omnichannel agent** role. Creating an application user is supported in the Web Client only. To create a bot user, you must:

1.	Get the Microsoft App ID of the bot.
2.	Create an application user and add bot specific information to the application user.

To get Microsoft App ID of the bot:

1.	Open [https://portal.azure.com](https://portal.azure.com) and select **Bot Services** in the **All services** section.

2.	Search for the appropriate **Bot Channels Registration** in the list and select it.

    > [!div class=mx-imgBorder]
    > ![Bot Channels Registration](../media/bot-channels-reg.png "Bot Channels Registration")

3.	Select **Settings** and then copy the value in the **Microsoft App ID** field. This value is your bot's application ID to be used while creating a bot user.

    > [!div class=mx-imgBorder]
    > ![Copy Microsoft App ID](../media/bot-id.png "Copy Microsoft App ID")

To create a bot user:

1. Open the Web Client and go to **Settings** > **Security** > **Users**.

2. In the view drop-down, select **Application Users**.

3. Select **New**.

4. In the view drop-down, select **Application User**.

4.	On the **New User** page, enter or select the following information:
    - **User Name**: User name of the bot. It is not displayed in the chat widget.
    - **Application ID**: An application ID for any valid (non-expired) application created in Azure Active Directory for the same tenant. It is not used by the bot in Omnichannel.
    - **Full Name**: Name of the bot as to be displayed in the chat widget.
    - **Primary Email**: Enter a dummy email address. It is not used by the bot in Omnichannel.
    - **Agent type**: Select **Bot application user**.
    - **Bot application ID**: Bot's application ID from Azure AD that you copied in the previous step.

    For more information on creating an application user, see [Create an application user](https://docs.microsoft.com/dynamics365/customer-engagement/developer/use-multi-tenant-server-server-authentication#create-an-application-user--associated-with-the-registered-application--in-).

5.	Save the record.

6.	Select **Manage Roles** on the command bar.

7.	In the **Manage User Roles** window, select **Omnichannel agent**, and then select **OK**.

    > [!NOTE]
    > By default, the bot user is assigned the same capacity as other users. You must assign the maximum capacity to the bot user among all users in a queue if you want the bot to handle the customer queries first. The capacity of a bot user doesn't reduce when a query is handled by it.

### Step 2: Add a bot user to the queue(s)

Queues distribute the incoming customer queries among bots and agents. You must ensure that the bot user has the highest capacity among all users in queue. This ensures that the bot user receives the customer query first. 

> [!NOTE]
> The bot works with the chat widget, work stream, and queues created in Omnichannel for Customer Service.

You can add a bot user to specific queues where you want the bot to handle the customer queries first. Alternatively, you can also create a queue with the bot user only. If you create a queue with the bot user only, ensure that the routing rules are set in a way that customer queries are sent to this queue first. This ensures that the bot acts as a first line of defense for all queries.

An agent can transfer a chat to a bot by adding the bot to a queue, and then transferring the chat to the queue. Please note that the chat cannot be transferred to the same bot.

You can set escalation rules to allow a bot to send customer queries to a customer service agent. More information: [Step 4: Set escalation rules](#step-4-set-escalation-rules)

### Step 3: Add code snippet to engage a bot

In order to send messages to Omni-channel Engagement Hub, you need to add the following code statement to the bot code:

```csharp
OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);
```

More information: [Engage a bot](../developer/bot-escalate-end-conversation.md#engage-a-bot)

### Step 4: Set escalation rules

Escalation rules allow you to create rules for the bot to escalate the queries to the appropriate agent. For escalation rules, you must create a context variable and appropriate routing rules to route the customer queries.

If the bot escalates the customer query, it is routed to the appropriate queue as per the defined routing rule. If the customer query in redirected to the same queue, another agent in the queue will pick the conversation as per the capacity. For information on working with queues, see [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md).

> [!NOTE]
> If you've only one queue with bot and agents, and you didn't create a routing rule, the customer query is redirected to the same queue in case of escalation and picked up by an agent.

#### Create a context variable

You must create a context variable for the bot to handle the customer queries appropriately. The context variable is used in routing the incoming customer queries to the appropriate bots and agents. For information on creating context variables, see [Understand and create work streams](work-streams-introduction.md).

#### Create routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable.

Bots are developed to receive customer queries first, gain information of the query,  and then pass the query to a human agent, if required. To achieve this behavior, you must add a bot user to the queue and configure routing rules in a way that the incoming customer queries are routed to the queue with bot user.

Ensure to map the routing rules to the correct queues so that the queries are routed appropriately. For information on creating a routing rule, see [Create and manage routing rules](routing-rules.md).

## Sample configuration to integrate a bot

This sample provides exact steps and configuration values to integrate a bot and then escalate the query to a human agent. In this sample, three queues and three routing rules will be created. A bot user is added to one queue and agents are added to two other queues. Routing rules are defined in a way that whenever a customer initiates a chat, it will be sent to the bot first and then escalated to a human agent as per the conditions defined in the routing rules. The work stream used in this sample is **ChatWorkStream**.

1.	Follow the instructions in [Step 1](#step-1-create-a-bot-user) to create a bot user.

2.	Follow the instructions in [Step 2](#step-2-add-a-bot-user-to-the-queues) to create three queues and add users as follows:
    - **BotQueue**: Add the bot user to this queue.
    - **CreditCardQueue**: Add agents who will handle credit card related queries.
    - **HomeLoanQueue**: Add agents who will handle home loan related queries.

3. Follow the instructions in [Step 3](#step-3-add-code-snippet-to-engage-a-bot) to add code snippet for engaging a bot.

4.	Follow the instructions in [Step 4](#step-4-set-escalation-rules) to create escalation rules. Let's say you create a context variable named **BotHandoffTopic** in the **ChatWorkStream** work stream. 

5.	Create three routing rules in the **ChatWorkStream** work stream in the following order:
    - **BotRule**: Specify the work stream and queue as **ChatWorkStream** and **BotQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query to bot](../media/bot-rule.png "Create a rule to send customer query to bot")
    - **CreditCardRule**: Specify the work stream and queue as **ChatWorkStream** and **CreditCardQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent](../media/credit-card-rule.png "Create a rule to send customer query from bot to an agent")
    - **HomeLoanRule**: Specify the work stream and queue as **ChatWorkStream** and **HomeLoanQueue** respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent](../media/home-loan-rule.png "Create a rule to send customer query from bot to an agent")

When a chat is initiated by a customer, the query is routed to the bot through the **BotRule** routing rule. If the bot escalates the query, it is sent to the appropriate agent as per the configured routing rules. The bot needs to send the correct context variable and its value in the escalation request to route the query appropriately. For more information on setting up of context variable and escalation request, see [Enable a bot to escalate and end conversation](../developer/bot-escalate-end-conversation.md).

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Add a chat widget](add-chat-widget.md)<br>
[Enable a bot to escalate and end conversation](../developer/bot-escalate-end-conversation.md)
