---
title: Integrate an Azure agent
description: Use this article to understand how to integrate Azure agents in the contact center.
ms.date: 04/20/2025
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.topic: how-to
ms.custom: bap-template
---

# Integrate an Azure agent

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


In Omnichannel for Customer Service, you can integrate Azure AI agents (agents) seamlessly with chat and social channels, and also repurpose Azure agents to be smart assist agents and provide recommendations to customer service representatives (service representatives or representatives). Learn more in [Manage smart assist](smart-assist.md) and [View smart assist suggestions](../use/oc-smart-assist.md). This article discusses how you can integrate Azure agents, configure routing rules, and set escalation rules.

## Prerequisites

- Have an AI agent that's built using the [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true). Ensure that you register the agent resource as a multitenant app.

    Learn about how to create an Azure agent resource in the [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource&preserve-view=true) section in the Bot Framework SDK documentation. Be sure to note the values of the Microsoft App ID and the Bot Application ID.
- Set the messaging endpoint in your bot configuration. Learn more in [Configure bot settings](/azure/bot-service/bot-service-manage-settings?view=azure-bot-service-4.0&preserve-view=true&tabs=userassigned).
- [Register your app on the Azure portal](/azure/active-directory/develop/quickstart-register-app#register-an-application). Make a note of the registered app name.

> [!NOTE]
> If you're using multiple AI agents, make sure that you create unique applications and have unique application IDs for each agent.

- To use the agent over messaging channels, add [Omnichannel channel](/azure/bot-service/bot-service-channel-omnichannel?view=azure-bot-service-4.0&preserve-view=true) as a supported channel.

## Integrate Azure agents with Omnichannel for Customer Service

After you meet the prerequisites, perform the following steps to integrate your Azure agents with Omnichannel for Customer Service.

1. Connect your Azure agent resource to Omnichannel channel.
1. Configure the agent user as an omnichannel representative.
1. Configure routing rules and context variables.
1. Add the agent user to queues.
1. Set escalation rules as required.

### Connect your agent resource to Omnichannel channel

Perform the following steps to connect and register your agent with the Omnichannel channel.

1. Open the [Azure portal](https://portal.azure.com), and then select your agent resource.

2. On the left pane, under **Settings**, select **Channels** and then select **Omnichannel** from the list of channels.

3. On the **Configure Omnichannel** page, select **Apply**.

Your agent is now registered with the Omnichannel channel.

### Configure the AI agent user as an omnichannel representative

The agent user is first created as an application user and then assigned the **Omnichannel agent** role.

1. Open the [PowerPlatform admin center](https://admin.powerplatform.com).

1. Select the environment you want to configure, and then select **Settings**.

1. On the **Settings** page, select **Users + permissions**, and then select **Application users**.

1. On the **Application users** page, select **New app user** and in the **Create a new app user** dialog that opens, do the following:

    a. Select a **Business unit** in the list. Make sure that you select the top-level business unit.
    
    b. Edit the **Security roles** field, and in the **Add security roles** page, select **Omnichannel agent** from the dropdown list and select **Save** to go back to the **Create a new app user** dialog.
    
    c. Select **Add an app**. The **Add an app from Microsoft Entra Identity** dialog opens.
    
    d. Select the app that you created during your Azure app registration, and then select **Add** and **Create**.

1. Open your Power Platform environment and under **Settings** > **System** > **Security** > **Users**, search and open the newly created user.

1. Select the **APPLICATION USER** form.

1. In the **User Information** section, do the following:
    - **User type**: Select **Bot application user** from the dropdown list.
    - **Bot application ID**: Enter the Microsoft App ID from Microsoft Entra ID that you noted earlier from the **Prerequisites** section.
    - **Bot Application ID**: Enter the bot application ID that you noted earlier from the **Prerequisites** section.

1. Select the save icon at the bottom of the page.

### Add the AI agent user to queues

You can add an AI agent user to specific queues where you want the agent to handle the customer queries first, instead of the representative. For this option, you must ensure that the agent user has the highest capacity among all users in the queue.

Alternatively, you can also create a queue with the agent user only. In such a case, ensure that the routing rules are set in a way that customer queries are sent to this queue first. This action ensures that the agent acts as the first recipient for all queries.

A representative can transfer a chat to an AI agent by adding it to a queue, and then transferring the chat to the queue.

> [!Note]
> - The chat cannot be transferred to the same agent.
> - The agent works with the chat widget, workstream, and queues created in Omnichannel for Customer Service.

### Configure routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For agents, the condition is built by using context variables. Learn more about context variables and how to add them in [Configure context variables for a bot](context-variables-for-bot.md).

AI agents can be developed to receive customer queries first, gain information about the query, and then pass the query to a representative if necessary. To achieve this behavior, you must first add the agent user to the queue and [configure routing rules](configure-route-to-queue-rules.md) in a way that the incoming customer queries are routed to the queue with the agent user. Be sure to map the routing rules to the correct queues so that the queries are routed appropriately.

### Set escalation rules

Escalation rules allow you to create rules for the AI agent to escalate the queries to the appropriate representative. For escalation rules, you must [configure context variables](context-variables-for-bot.md) and set routing rules to route the customer queries. If the AI agent escalates a customer query, it routes to the appropriate queue as per the defined routing rule. Even if the query is redirected to the same queue, another representative in the queue picks the conversation as per the capacity.

## Privacy notice

You understand that your data may be transmitted and shared with external systems, and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages are shared with the agent, which could be interacting with a third-party system based on the integration done by you. Learn more about how we process your data in [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### Related information

[Overview of bots](overview-bots.md)   
[Best practices for configuring Azure and Copilot Studio bots](configure-bot-best-practices.md)  
[Integrate Copilot Studio bot](configure-bot-virtual-agent.md)  
[Create workstreams for unified routing](create-workstreams.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[View bot insights](../implement/omnichannel-insights-dashboard.md#botinsights)  
[Configure Azure bots to escalate and end conversation](../develop/bot-escalate-end-conversation.md)  
[Configure context variables for bots](context-variables-for-bot.md)  
[Manage context variables](manage-context-variables.md)  
[Create an application user](/powerapps/developer/data-platform/use-multi-tenant-server-server-authentication#create-a-multi-tenant-web-application-registered-with-your-azure-ad-tenant)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
