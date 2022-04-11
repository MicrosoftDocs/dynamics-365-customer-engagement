---
title: "Integrate an Azure bot | MicrosoftDocs"
description: "Use this article to understand how to integrate an Azure bot with Omnichannel for Customer Service."
ms.date: 04/12/2022
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - intro-internal
ms.topic: article
---

# Integrate an Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This article includes detailed information about how you can integrate your Azure bot with Omnichannel for Customer Service. The topic also includes a sample configuration that explains the integration steps.

To integrate your Azure bot, perform the following steps:

1. [Connect your Azure bot resource to Omnichannel channel](#connect-your-azure-bot-resource-to-omnichannel-channel).
1. [Configure the bot user as an omnichannel agent](#configure-the-bot-user-as-an-omnichannel-agent).
1. [Create routing rules](#create-routing-rules).
1. [Add the bot user to queues](#add-the-bot-user-to-queues).
1. [Set escalation rules](#set-escalation-rules) as required.

> [!Note]
> - To integrate your Azure bot with the voice channel and enable calling/SMS services, see [Add Azure bot to conversational IVR](voice-channel-azure-bot-service.md).
> - To program Azure bots to route conversations to human agents and also end conversations in Omnichannel for Customer Service, see [Enable an Azure bot to escalate and end conversations](bot-escalate-end-conversation.md).

## Prerequisites

- Have a bot that's built using [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true). To create an Azure bot resource, see [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource&preserve-view=true) in the Bot Framework SDK documentation. 
- Open your bot resource on the Azure portal, and note the values of the app ID and bot handle.
- Configure your bot to have [Omnichannel channel](/azure/bot-service/bot-service-channel-omnichannel?view=azure-bot-service-4.0&preserve-view=true) and [Microsoft Teams](/azure/bot-service/channel-connect-teams?view=azure-bot-service-4.0&preserve-view=true) as supported channels.

## Connect your Azure bot resource to Omnichannel channel

Perform the following steps to connect and register your bot with Omnichannel channel.

1. Open [https://portal.azure.com](https://portal.azure.com), and then select your bot resource.

2. On the left pane, under **Settings**, select **Channels (Preview)**, and then select **Omnichannel** from the list of channels.

3. On the **Configure Omnichannel** page, select **Apply**.

Your bot is now registered with Omnichannel channel.

## Configure the bot user as an omnichannel agent

The bot user is first created as an application user and then assigned the **Omnichannel agent** role.

1. Open the [PowerPlatform admin center](https://admin.powerplatform.com). 

1. Select the environment you want to configure, and then select **Settings**.

1. On the **Settings** page, select ***Users + permissions**, and then select **Application users**.

1. On the **Application users** page, select **New app user** and in the **Create a new app user** dialog that opens, do the following:

    a. Select a **Business unit** from the dropdown list.
    
    b. Edit the **Security roles** field, and in the **Add security roles** page, select **Omnichannel agent** from the dropdown list and select **Save** to go back to the **Create a new app user** dialog.
    
    c. Select **Add an app**. The **Add an app from Azure Active Directory** dialog opens.
    
    d. Select the app that you created during your Azure app registration, and then select **Add** and **Create**.

1. Open the Dynamics 365 and under **Settings** > **System** > **Security** > **Users**, search and open the newly created user.

1. Select the **APPLICATION USER** form.

1. In the **User Information** section, do the following:
    - **User type**: Select **Bot application user** from the dropdown list.
    - **Bot application ID**: Enter the Microsoft App ID from Azure AD that you noted earlier from the Prerequisites section.
    - **Bot handle**: Enter the bot handle that you noted earlier from the Prerequisites section.

1. Select the save icon at the bottom of the page.

## Create routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable.

Bots can be developed to receive customer queries first, gain information about the query, and then pass the query to a human agent if required. To achieve this behavior, you must add a bot user to the queue and [configure routing rules](routing-rules.md) in a way that the incoming customer queries are routed to the queue with the bot user. Be sure to map the routing rules to the correct queues so that the queries are routed appropriately. 

## Add the bot user to queues

You can add a bot user to specific queues where you want the bot to handle the customer queries first, instead of the agent. For this, you must ensure that the bot user has the highest capacity among all users in the queue.

Alternatively, you can also create a queue with the bot user only. In such a case, ensure that the routing rules are set in a way that customer queries are sent to this queue first. This ensures that the bot acts as the first recipient for all queries.

An agent can transfer a chat to a bot by adding the bot to a queue, and then transferring the chat to the queue.

> [!Note]
> The chat cannot be transferred to the same bot.
> The bot works with the chat widget, workstream, and queues created in Omnichannel for Customer Service.

## Set escalation rules

Escalation rules allow you to create rules for the bot to escalate the queries to the appropriate agent. For escalation rules, you must [configure context variables](context-variables-for-bot.md) and set routing rules to route the customer queries. If the bot escalates a customer query, it's routed to the appropriate queue as per the defined routing rule. Even if the query is redirected to the same queue, another agent in the queue will pick the conversation as per the capacity.

## Sample configuration to integrate an Azure bot

The following sample provides the exact steps and configuration values to integrate an Azure bot and then escalate the query to a human agent. In this sample, three queues and three routing rules are created. The bot user is added to one queue, and the agents are added to the two other queues. Routing rules are defined in such a way that whenever a customer starts a chat, it will be first sent to the bot, and then escalated to a human agent as per the conditions defined in the routing rules. The workstream used in this sample is **ChatWorkStream**.

1. [Configure the bot user as an omnichannel agent](#configure-the-bot-user-as-an-omnichannel-agent).

2. [Create the following three queues](set-up-queues-manage-activities-cases.md#create-a-queue) and add users as follows:
    - **BotQueue**: Add the bot user to this queue.
    - **CreditCardQueue**: Add agents who will handle queries related to credit card.
    - **HomeLoanQueue**: Add agents who will handle queries related to home loan.

3. [Add a context variable](context-variables-for-bot.md#add-context-variables). Let's say you create a context variable named **BotHandoffTopic** in the **ChatWorkStream** workstream.

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
5. [Enable the Azure bot to escalate and end conversations](bot-escalate-end-conversation.md).

When a chat is started by a customer, the query is routed to the bot through the **BotRule** routing rule. If the bot escalates the query, it is sent to the appropriate agent as per the configured routing rules. The bot needs to send the correct context variable and its value in the escalation request to route the query appropriately.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Overview of the voice channel](voice-channel.md)  
[Understand and create workstreams](create-workstreams.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Create and manage routing rules](routing-rules.md)  
[View bot insights](omnichannel-insights-dashboard.md#botinsights)  
[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  
[Enable bot context NuGet package](enable-bot-context.md)  
[Create an application user](/powerapps/developer/data-platform/use-multi-tenant-server-server-authentication#create-a-multi-tenant-web-application-registered-with-your-azure-ad-tenant)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
