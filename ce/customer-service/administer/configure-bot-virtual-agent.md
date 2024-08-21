---
title: Integrate a Copilot Studio bot
description: Use this article to get instructions on how to integrate a Copilot Studio bot in your contact center.
ms.date: 02/29/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.collection:
ms.custom: bap-template
---

# Integrate a Copilot Studio bot

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

[!INCLUDE[cc-trial-sign-up](../../includes/cc-trial-sign-up.md)]

Microsoft Copilot Studio allows organizations to automate routine conversations, letting agents focus on high-value interactions. When a conversation is escalated from a bot to a human agent, the agent can see the full transcript of the bot conversation and get complete context while engaging with the customer. More information: [Enable a bot to escalate and end conversation](../develop/bot-escalate-end-conversation.md)  

When you integrate a Copilot Studio bot with Omnichannel for Customer Service, you get the following capabilities for bot conversations:

- Seamlessly integrate your bot with all channels without needing to add channel-specific code in the bot.
- Transfer bot conversations to human agents, and include the full context of the conversation.
- Analyze the bot transcript that's available in Microsoft Dataverse after the chat is completed.
- Configure routing rules to selectively route incoming requests to bots based on context, such as issue type or customer type. For example, you can route low-complexity issues to bots, or route the conversation to a sales or support bot based on the webpage browsing history of the customer.
- Monitor the bot conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use the historical dashboards to get insights into the effectiveness of the bots through metrics, such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.

## Prerequisites

Before you integrate Copilot Studio bots in Omnichannel for Customer Service, check the following:

1. You must have:

    - A product license for Copilot Studio. More information: [Licensing for Copilot Studio](/power-virtual-agents/requirements-licensing-subscriptions)

    - A product license for chat, digital messaging, or voice channel for Dynamics 365 Customer Service, depending on your business requirements. More information: [Licensing](../implement/system-requirements-omnichannel.md#licensing)
1. You must have the Omnichannel administrator role. More information: [Manage user roles](../implement/add-users-assign-roles.md)
1. You'll need an application registered on the Azure portal before connecting to Omnichannel for Customer Service. More information: [Register an application with Microsoft Entra ID](/entra/identity-platform/howto-create-service-principal-portal)
1. You must have a preconfigured bot that can integrate with Omnichannel for Customer Service. More information: [Configure seamless and contextual hand-off to Omnichannel for Customer Service](/power-virtual-agents/configuration-hand-off-omnichannel)

## Install Copilot Studio extensions

Copilot Studio lets you seamlessly hand off voice and text-based conversations to human agents using the chat, digital messaging, and voice channels in Dynamics 365 Customer Service. For your bot to hand off conversations to the omnichannel interface, you must install the Copilot Studio extension solutions for Dynamics 365 Customer Service.

To do so, perform the following steps:

1. [Ensure the prerequisites are met](/microsoft-copilot-studio/configuration-hand-off-omnichannel#prerequisites).
2. [Install the extension solutions](/microsoft-copilot-studio/configuration-hand-off-omnichannel#install-extension-solutions).
3. Verify if the extension solutions are successfully installed by checking whether the extension solution variables are available in Copilot Studio.

## Connect your Copilot Studio bot to omnichannel instance

Follow the procedure in the section [Connect omnichannel to your Copilot Studio bot](/power-virtual-agents/configuration-hand-off-omnichannel#connect-your-bot-to-omnichannel-for-customer-service) to connect your Copilot Studio bot to the omnichannel instance.

> [!NOTE]
> If you're using multiple bots, make sure that you create unique applications and have unique application IDs for each bot.

## Configure your Copilot Studio bot in the admin app

In the Customer Service admin center app, select the Copilot Studio bot from the list of bots in the **Workstreams** area, so the bot can be used to hand off conversations to human agents. For more information, see [Add a bot to a workstream](create-workstreams.md#add-a-bot-to-a-workstream).

> [!NOTE]
> Bots can receive conversations only if they're added to push-based workstreams.

## Enable a human agent to transfer a conversation back to a bot

Some support scenarios may require a human agent to transfer a conversation back to a Copilot Studio bot after delivering personalized support. This transfer from human agent to bot may be used to provide further assistance with basic, repetitive tasks, or to collect additional data, as in a customer survey.

You can facilitate the transfer of a conversation from a human agent back to a bot in the following ways:

- Create two bots that reside in two queues
- Create two bots that reside in the same queue

### Two bots in two queues

In this scenario, a bot has transferred a conversation to a human agent. The human agent will transfer the conversation again to another bot in another queue.

1. A customer starts a conversation.
2. The conversation is routed to Queue 1.
3. The first bot (Bot A) accepts the conversation.
4. The customer requests to chat with a human agent.
5. The conversation is transferred to a human agent within Queue 1.
6. The customer converses with the human agent.
7. The human agent has completed delivering support and wants to hand off the conversation to a second bot (Bot B), which resides in Queue 2.
8. The human agent is disconnected from the conversation.
9. The conversation routed to Bot B in Queue 2.
10. The system triggers Bot B to send a greeting message.
11. The customer now chats with Bot B.

### Two bots in one queue

In this scenario, after a bot has transferred a conversation to a human agent, the agent will transfer the conversation to another bot in the same queue when the agent's task is over. For the conversation to flow correctly, you must set the first bot (Bot A) with the highest capacity, the human agent with the next highest capacity, and the second bot (Bot B) with the lowest capacity.

1. A customer starts a conversation that is routed to a queue.
2. The first bot (Bot A) that has the highest capacity accepts the conversation.
3. The customer requests to chat with a human agent.
4. The conversation is transferred to a human agent as the agent has second-highest capacity.
5. The customer chats with the human agent.
6. The human agent has finished delivering support and wants to hand off the conversation to a second bot (Bot B), which resides in the same queue.
7. The human agent is disconnected from the conversation, and the conversation is routed to Bot B.
8. Bot B receives the messages in the following order:
    - A conversation update that the “Bot is added”
    - The Omnichannel Set context event
9. The system triggers Bot B to send a greeting message.
10. The customer now chats with Bot B.

## Configure context variables for the Copilot Studio bot

After you've configured your bot and added it to a workstream, you can configure context variables to route work items. You can also share context from Omnichannel with your Copilot Studio bot to create a rich and personalized experience. For information about creating context variables, see [Manage context variables](manage-context-variables.md). For information about configuring context variables for Copilot Studio bots, see [Configure context variables for Copilot Studio bot](context-variables-for-bot.md#context-variables-for-copilot-studio-bots).

## Automatically close a conversation

When a bot receives a conversation that's subsequently not escalated to a human agent, the conversation is closed if the customer abandons it. The conversation will also be closed automatically after 30 minutes of inactivity.

This conversation will then appear in the **Closed** state in the Omnichannel for Customer Service dashboard and in the **Resolved/abandoned** state in the Copilot Studio dashboard. For more information on the state of conversations, see [Session outcomes over time chart](/power-virtual-agents/analytics-summary#session-outcomes-over-time-chart).

## End bot conversation

You must configure the Copilot Studio web app bot to end a conversation. More information: [End conversation](/power-virtual-agents/authoring-create-edit-topics#end-the-conversation)

After a customer closes the chat window, you must also configure a context variable that explicitly ends the conversation in Omnichannel for Customer Service.

1. In Copilot Studio, for the selected bot, add a new topic.

1. Select **Go to authoring canvas**, and in **Add node**, select **Call an action**, and then select **Create a flow**.

1. On the Power Automate window that opens on a new tab, do the following:
   1. In the **Return value(s) to Power Virtual Agents** box, select **Add an output**, and then select **Yes/No**.
   2. In the **Enter title** box, enter CloseOmnichannelConversation, which is the Omnichannel for Customer Service context variable name.
   3. In the **Enter a value to respond** box, select the **Expression** tab, and then enter **bool(true)** to build the expression, and select **OK**.
   4. Save the changes, and then exit Power Automate.

1. In the topic that you were editing, select **Call an action** again, and then in the list, select the flow that you created.

1. In **Add node**, select **End the conversation**, and then select **Transfer to agent**.

    :::image type="content" source="../media/end-bot-conversation.png" alt-text="Configure end conversation topic in Copilot Studio.":::

1. Go to the topic in which you need to invoke the topic for ending the bot conversation in Omnichannel for Customer Service, and use the **Go to another topic** option in **Add a node**.

1. Select the topic that you created for ending the bot conversation.

1. Save and publish the changes.

### Limitations

| Description     | Limitation     |
|-----------------|----------------|
| **Adaptive cards** An adaptive card is a customizable card that can contain any combination of text, speech, images, buttons, and input fields.|<ul><li> You can build an adaptive card by adding a skill through Copilot Studio. More information: [Use Microsoft Bot Framework Skills in Copilot Studio](/power-virtual-agents/advanced-use-skills) </li><li> Adaptive card styling isn't supported.</li></ul> |
| **Typing** A bot receives a typing activity to indicate that the user is typing a response. A bot may send a typing activity to indicate to the user that it is working to fulfill a request or compile a response. | Typing indicators won't appear. |
| **Format bot messages** You can set the optional `TextFormat` property to control how the text content of your message is rendered. | <ul><li> Copilot Studio does not support Markdown with images and text. </li><li>When Copilot Studio sends Markdown text, there's an extra space between lines. </li></ul>|
| **OAuth card in Microsoft Teams** Using a chat bot and presenting an OAuth card in the Microsoft Teams channel. | In Copilot Studio, the sign-in node presents an OAuth card and it doesn't work properly. |

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, see [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### Troubleshoot issues for bots

[How to end a bot conversation in Omnichannel for Customer Service](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/pva-conversations-active-dashboard)

### Related information

[Manage your bots](manage-your-bots.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Manage context variables](manage-context-variables.md)  
[Configure context variables for bots](context-variables-for-bot.md)  
[Identify customers automatically](record-identification-rule.md)  
[Enable a bot to escalate and end conversation](../develop/bot-escalate-end-conversation.md)  
[Best practices for configuring Azure and Copilot Studio bots](configure-bot-best-practices.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Understand and create workstreams](create-workstreams.md)  
[Create and edit topics in Copilot Studio bot](/power-virtual-agents/authoring-create-edit-topics)  
[Suggested actions](../develop/suggested-actions.md)  
[Add a chat widget](add-chat-widget.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
