---
title: "Integrate an Azure bot | MicrosoftDocs"
description: "Use this topic to understand how to integrate an Azure bot with Omnichannel for Customer Service."
ms.date: 09/30/2021
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Integrate an Azure bot

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

A bot is a program that provides automated responses in a conversational manner to a customer. It can also help resolve customer queries by using case deflection. A bot can also collect basic information from a customer and then provide it to a customer service agent to work further on the issue raised by the customer.  

A bot eases the load on your customer service agents by handling basic queries. This saves your agents' time so they can work on more complex issues. You can configure your bots to escalate the query to a human agent as required, or when requested by the customer.

In Omnichannel for Customer Service, you can integrate a bot to start the conversation with a customer, provide automated responses, and then shift the conversation to a human agent if required.

When you integrate an Azure bot with Omnichannel for Customer Service, you get the following capabilities for bot conversations:

- Seamlessly integrate your Azure bot with all channels without needing to add channel-specific code in the bot.
- Transfer bot conversations to human agents, and include the full context of the conversation.
- Analyze the bot transcript that's available in Microsoft Dataverse after the chat is completed.
- Configure routing rules to selectively route incoming requests to bots based on context, such as issue type or customer type. For example, you can route low-complexity issues to bots, or route the conversation to a sales or support bot based on the webpage browsing history of the customer.
- Monitor the bot conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use the historical dashboards to get insights into the effectiveness of the bots through metrics such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.
- Configure routing rules to use bots in post-chat surveys.
- Repurpose bots to be smart-assist bots and provide recommendations to agents.


## Prerequisites

You must ensure the following conditions are met before you integrate your bot with Omnichannel for Customer Service.

- You must have a bot that's built using [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0). To create an Azure bot resource, see [Create Azure bot resource](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0#create-the-resource) section in the Bot Framework SDK documentation. Be sure to note the values of the Microsoft App ID and the bot handle.

- The bot must be configured to [have Microsoft Teams as a supported channel](/azure/bot-service/bot-service-manage-channels?view=azure-bot-service-4.0).

> [!NOTE]
> Bots can escalate conversations to agents only if they are a part of push-based workstreams.

To integrate your bot with Omnichannel for Customer Service, perform the following steps:
1. Connect your bot resource to Omnichannel for Customer Service.
2. Create the bot user as application user and assign it as an omnichannel agent.
3. Add bot user to the queues.
4. Add code snippet to engage the bot.
5. Set escalation rules.

### Connect bot resource to Omnichannel for Customer Service

Perform the following steps to connect and register your bot with Omnichannel for Customer Service.

1. Open [https://portal.azure.com](https://portal.azure.com) and select your bot resource.

2. On the left pane, select **Channels (Preview)** under **Settings** pane, and then select **Omnichannel** from the list of channels.

3. On the **Configure Omnichannel** page, select **Apply**.

Your bot is now registered with Omnichannel for Customer Service. 

### Configure bot user as Omnichannel agent

A bot user is created as an application user and assigned with the **Omnichannel agent** role. 

To create a bot user:

1. Open Omnichannel admin center and go to **Advanced Settings** > **Security** > **Users**.

2. In the **Users** dropdown list, select **Application Users**, and then select **New**.

3. In the **New User** dropdown list, select **Application User**.

4. On the **New User** page, enter or select the following information:
    - **User Name**: User name of the bot. Note that this name will not be displayed in the chat widget.
    - **Application ID**: An application ID for any valid (non-expired) application created in Azure Active Directory (Azure AD) for the same tenant. This ID is not used by the bot in Omnichannel for Customer Service.
    - **Full Name**: Name of the bot to be displayed in the chat widget.
    - **Primary Email**: Enter a dummy email address. This email address is not used by the bot in Omnichannel for Customer Service.
    - **User type**: Select **Bot application user**.
    - **Bot application ID**: Bot's application ID from Azure AD that you copied in the previous step.
    - **Bot handle**: Enter the bot handle from the Bot profile settings.

    For more information on creating an application user, see [Create an application user](/dynamics365/customer-engagement/developer/use-multi-tenant-server-server-authentication#create-an-application-user--associated-with-the-registered-application--in-).

5. Select **Save and close**.

6. Select **Manage Roles** on the command bar.

7. In the **Manage User Roles** window, select **Omnichannel agent**, and then select **OK**.

    > [!NOTE]
    > By default, the bot user is assigned the same capacity as other users. You must assign the maximum capacity to the bot user among all users in a queue if you want the bot to handle the customer queries first. The capacity of a bot user isn't reduced when a query is handled by it.

### Add the bot user to queues

Queues distribute the incoming customer queries among bots and agents. You must ensure that the bot user has the highest capacity among all users in the queue. This ensures that the bot user receives the customer query first.

> [!NOTE]
> The bot works with the chat widget, work stream, and queues created in Omnichannel for Customer Service.

You can add a bot user to specific queues where you want the bot to handle the customer queries first. Alternatively, you can also create a queue with the bot user only. If you create a queue with the bot user only, ensure that the routing rules are set in a way that customer queries are sent to this queue first. This ensures that the bot acts as a first line of defense for all queries.

An agent can transfer a chat to a bot by adding the bot to a queue, and then transferring the chat to the queue. Please note that the chat cannot be transferred to the same bot.

You can set escalation rules to allow a bot to send customer queries to a customer service agent. More information: [Set escalation rules](#set-escalation-rules)

### Add code snippet to engage a bot

In order to send messages to Omnichannel Engagement Hub, you need to add the following code statement to the bot code:

```csharp
OmnichannelBotClient.BridgeBotMessage(turnContext.Activity);
```

More information: [Engage a bot](bot-escalate-end-conversation.md#engage-a-bot)

### Set escalation rules

Escalation rules allow you to create rules for the bot to escalate the queries to the appropriate agent. For escalation rules, you must create a context variable and appropriate routing rules to route the customer queries.

If the bot escalates the customer query, it is routed to the appropriate queue as per the defined routing rule. If the customer query in redirected to the same queue, another agent in the queue will pick the conversation as per the capacity. For information on working with queues, see [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md).

#### Create a context variable

You must create a context variable for the bot to handle the customer queries appropriately. The context variable is used in routing the incoming customer queries to the appropriate bots and agents. For information on creating context variables, see [Understand and create workstreams](create-workstreams.md).

#### Create routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable.

Bots are developed to receive customer queries first, gain information about the query, and then pass the query to a human agent if required. To achieve this behavior, you must add a bot user to the queue and configure routing rules in a way that the incoming customer queries are routed to the queue with the bot user.

Be sure to map the routing rules to the correct queues so that the queries are routed appropriately. For information on creating a routing rule, see [Create and manage routing rules](routing-rules.md).

## Sample configuration to integrate a bot

This sample provides exact steps and configuration values to integrate a bot and then escalate the query to a human agent. In this sample, three queues and three routing rules will be created. A bot user is added to one queue, and agents are added to two other queues. Routing rules are defined in such a way that whenever a customer initiates a chat, it will be sent to the bot first and then escalated to a human agent as per the conditions defined in the routing rules. The workstream used in this sample is **ChatWorkStream**.

1.	Follow the instructions in [Configure bot user as Omnichannel agent](#configure-bot-user-as-omnichannel-agent) to create a bot user.

2.	Follow the instructions in [Add the bot user to queues](#add-the-bot-user-to-queues) to create three queues and add users as follows:
    - **BotQueue**: Add the bot user to this queue.
    - **CreditCardQueue**: Add agents who will handle credit card&ndash;related queries.
    - **HomeLoanQueue**: Add agents who will handle home loan&ndash;related queries.

3. Follow the instructions in [Add code snippet to engage a bot](#add-code-snippet-to-engage-a-bot) to add a code snippet for engaging a bot.

4.	Follow the instructions in [Set escalation rules](#set-escalation-rules) to create escalation rules. Let's say you create a context variable named **BotHandoffTopic** in the **ChatWorkStream** workstream.

5.	Create three routing rules in the **ChatWorkStream** workstream in the following order:
    - **BotRule**: Specify the workstream and queue as **ChatWorkStream** and **BotQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query to bot.](media/bot-rule.png "Create a rule to send customer query to bot")
    - **CreditCardRule**: Specify the workstream and queue as **ChatWorkStream** and **CreditCardQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Send customer queries from a bot to an agent, by creating a rule.](media/credit-card-rule.png "Send customer queries from a bot to an agent, by creating a rule.")
    - **HomeLoanRule**: Specify the workstream and queue as **ChatWorkStream** and **HomeLoanQueue**, respectively. Add the condition as follows:
        > [!div class=mx-imgBorder]
        > ![Create a rule to send customer query from bot to an agent.](media/home-loan-rule.png "Create a rule to send a customer query from a bot to an agent")

When a chat is initiated by a customer, the query is routed to the bot through the **BotRule** routing rule. If the bot escalates the query, it is sent to the appropriate agent as per the configured routing rules. The bot needs to send the correct context variable and its value in the escalation request to route the query appropriately. For more information on setting up of context variable and escalation request, see [Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md).

## Bot sessions usage

Each Chat and Digital Messaging license receives an entitlement of 50 chatbot sessions for use with Microsoft Bot Framework bots. These sessions are pooled at the tenant level and expire at the end of each month. Additional chatbot sessions will require purchase of Chatbot Sessions Add-on.

> [!NOTE]
> For more information on Chatbot licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

### What is a bot session?

A bot session is defined as a conversation in which a bot is invoked. The bot can be invoked at the beginning, during, or end of a conversation.

- If two different bots are invoked in the same conversation, it is considered a single conversation.
- A conversation with a bot that's escalated to a human agent is considered a bot conversation.

> [!NOTE]
> If smart assist is enabled, the bot conversations do not include smart-assist conversations.

### Purchase additional chatbot sessions

Chatbot Session add-ons entitle customers with Chat or Digital Messaging to an additional 100 chatbot sessions for use with Microsoft Bot Framework bots, pooled at the tenant level. Additional chatbot sessions expire at the end of each month.

You can purchase additional bot conversations from Microsoft 365 admin center.

1.	Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the global administrator credentials.

2.	Go to **Billing** > **Purchase Services**, and select **Add-ons**.

3.	Under **Add-ons**, select **Dynamics 365 for Customer Service Chatbot session add-on**.

4.	Select the number of add-ons required and complete the purchase.

> [!Note]
>
> Authentication cards are not supported in bots integrated with Omnichannel for Customer Service.

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### See also

[Understand and create workstreams](create-workstreams.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Create and manage routing rules](routing-rules.md)  
[Add a chat widget](add-chat-widget.md)  
[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  
[Enable bot context NuGet package](enable-bot-context.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
