---
title: "Integrate an Azure bot | MicrosoftDocs"
description: "Use this article to understand how to integrate Azure bots with Omnichannel for Customer Service."
ms.date: 12/02/2022
author: neeranelli
ms.author: nenellim
ms.collection: get-started
ms.topic: article
---

# Integrate an Azure bot

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

In Omnichannel for Customer Service, you can integrate Azure bots seamlessly with chat and social channels, and also repurpose Azure bots to be smart assist bots and provide recommendations to agents. For more information, see [Manage smart assist](smart-assist.md) and [View smart assist suggestions](oc-smart-assist.md). This article discusses how you can integrate Azure bots, configure routing rules, and set escalation rules.

## Prerequisites

- Have a bot that's built using the [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true). Ensure that you register the bot resource as a multitenant app.

    To create an Azure bot resource, see [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource&preserve-view=true) section in the Bot Framework SDK documentation. Be sure to note the values of the Microsoft App ID and the bot handle.
- Set the messaging endpoint in your bot configuration. More information: [Configure bot settings](/azure/bot-service/bot-service-manage-settings?view=azure-bot-service-4.0&preserve-view=true&tabs=userassigned)
- [Register your app on the Azure portal](/azure/active-directory/develop/quickstart-register-app#register-an-application). Make a note of the registered app name.

> [!NOTE]
> If you're using multiple Azure bots, unique application and application ID are required for each bot.

- To use the bot over messaging channels:
    - Add [Omnichannel channel](/azure/bot-service/bot-service-channel-omnichannel?view=azure-bot-service-4.0&preserve-view=true) as a supported channel, if you're using public cloud services.
    - Add both [Omnichannel channel](/azure/bot-service/bot-service-channel-omnichannel?view=azure-bot-service-4.0&preserve-view=true) and [Microsoft Teams](/azure/bot-service/channel-connect-teams?view=azure-bot-service-4.0&preserve-view=true) as supported channels, if you're using GCC (Government Community Cloud) services.

## Integrate Azure bots with Omnichannel for Customer Service

After you've checked for the prerequisites, perform the following steps to integrate your Azure bots with Omnichannel for Customer Service.

1. Connect your Azure bot resource to Omnichannel channel.
1. Configure the bot user as an omnichannel agent.
1. Configure routing rules and context variables.
1. Add the bot user to queues.
1. Set escalation rules as required.

### Connect your bot resource to Omnichannel channel

Perform the following steps to connect and register your bot with the Omnichannel channel.

1. Open the [Azure portal](https://portal.azure.com), and then select your bot resource.

2. On the left pane, under **Settings**, select **Channels** and then select **Omnichannel** from the list of channels.

3. On the **Configure Omnichannel** page, select **Apply**.

Your bot is now registered with the Omnichannel channel.

### Configure the bot user as an omnichannel agent

The bot user is first created as an application user and then assigned the **Omnichannel agent** role.

1. Open the [PowerPlatform admin center](https://admin.powerplatform.com).

1. Select the environment you want to configure, and then select **Settings**.

1. On the **Settings** page, select **Users + permissions**, and then select **Application users**.

1. On the **Application users** page, select **New app user** and in the **Create a new app user** dialog that opens, do the following:

    a. Select a **Business unit** in the list. Make sure that you select the top-level business unit.
    
    b. Edit the **Security roles** field, and in the **Add security roles** page, select **Omnichannel agent** from the dropdown list and select **Save** to go back to the **Create a new app user** dialog.
    
    c. Select **Add an app**. The **Add an app from Azure Active Directory** dialog opens.
    
    d. Select the app that you created during your Azure app registration, and then select **Add** and **Create**.

1. Open your Power Platform environment and under **Settings** > **System** > **Security** > **Users**, search and open the newly created user.

1. Select the **APPLICATION USER** form.

1. In the **User Information** section, do the following:
    - **User type**: Select **Bot application user** from the dropdown list.
    - **Bot application ID**: Enter the Microsoft App ID from the Azure AD (Active Directory) that you noted earlier from the **Prerequisites** section.
    - **Bot handle**: Enter the bot handle that you noted earlier from the **Prerequisites** section.

1. Select the save icon at the bottom of the page.

### Add the bot user to queues

You can add a bot user to specific queues where you want the bot to handle the customer queries first, instead of the agent. For this, you must ensure that the bot user has the highest capacity among all users in the queue.

Alternatively, you can also create a queue with the bot user only. In such a case, ensure that the routing rules are set in a way that customer queries are sent to this queue first. This ensures that the bot acts as the first recipient for all queries.

An agent can transfer a chat to a bot by adding the bot to a queue, and then transferring the chat to the queue.

> [!Note]
> - The chat cannot be transferred to the same bot.
> - The bot works with the chat widget, workstream, and queues created in Omnichannel for Customer Service.

### Configure routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using context variables. To learn about context variables and how to add them, see [Configure context variables for a bot](context-variables-for-bot.md).

Bots can be developed to receive customer queries first, gain information about the query, and then pass the query to a human agent if required. To achieve this behavior, you must first add the bot user to the queue and [configure routing rules](configure-route-to-queue-rules.md) in a way that the incoming customer queries are routed to the queue with the bot user. Be sure to map the routing rules to the correct queues so that the queries are routed appropriately.

### Set escalation rules

Escalation rules allow you to create rules for the bot to escalate the queries to the appropriate agent. For escalation rules, you must [configure context variables](context-variables-for-bot.md) and set routing rules to route the customer queries. If the bot escalates a customer query, it's routed to the appropriate queue as per the defined routing rule. Even if the query is redirected to the same queue, another agent in the queue will pick the conversation as per the capacity.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Overview of bots](overview-bots.md)  
[Sample configuration to integrate Azure bots](sample-config-azure-bot.md)  
[Best practices for configuring Azure and Power Virtual Agents bots](configure-bot-best-practices.md)  
[Integrate Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Create workstreams for unified routing](create-workstreams.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[View bot insights](omnichannel-insights-dashboard.md#botinsights)  
[Configure Azure bots to escalate and end conversation](bot-escalate-end-conversation.md)  
[Configure context variables for bots](context-variables-for-bot.md)  
[Manage context variables](manage-context-variables.md)  
[Create an application user](/powerapps/developer/data-platform/use-multi-tenant-server-server-authentication#create-a-multi-tenant-web-application-registered-with-your-azure-ad-tenant)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
