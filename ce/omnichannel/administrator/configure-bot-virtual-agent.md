---
title: "Configure a bot | MicrosoftDocs"
description: "Instructions to configure a bot in Omnichannel for Customer Service."
keywords: ""
author: sbmjais
ms.author: ktaylor
manager: shujoshi
applies_to: 
ms.date: 10/04/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: e5c82c7b-bd48-4eca-a157-e4b349e3baf8
ms.custom: 
---

# Preview: Integrate a Virtual Agent bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

Microsoft Dynamics 365 Virtual Agent for Customer Service allows organizations to automate routine conversations, letting agents focus on high-value interactions. When a conversation is escalated from a bot to a human agent, agents can see the full transcript of bot conversations and have complete context while engaging with customers.

Once you have created your bot and connected it to an Omnichannel for Customer Service environment, you can go to the Omnichannel configuration in order to add your bot to queues and configure context variables to route chat sessions to queues. 

**Prerequisites**: 
* Product license - You need a product license for Virtual Agent ([click here to start a trial](https://go.microsoft.com/fwlink/p/?LinkId=2092080&clcid=0x409)) and Omnichannel for Customer service ([click here to learn more](https://docs.microsoft.com/dynamics365/customer-engagement/omnichannel/try-chat-for-dynamics365))
* Role - In order to successfully complete these steps, signed in user must be a "Omnichannel Administrator" in Omnichannel. [Click here to learn more about managing and assigning user roles in Omnichannel](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/administrator/add-users-assign-roles).
* Azure Application ID - You will need an application registered in Azure prior to connecting to Omnichannel. [Click here to learn more](https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#create-an-azure-active-directory-application)
* Bot - You must have a bot that is built using Microsoft Bot Framework. For more information on how to build a bot, see [Virtual Agent Bot Service Documentation](https://docs.microsoft.com/en-us/azure/ai/virtual-agent). 
* Integration - Your bot must be integrated with Omnichannel for Customer Service. For more information, see [Omnichannel setup & configure](https://github.com/MicrosoftDocs/dynamics-365-ai-pr/blob/pawant-ms-handoff/ai-docs/customer-service-virtual-agent/how-to-setup-omnichannel-handoff.md).

Once the Virtual Agent bot is created and configured to work with Omnichannel, you can configure it to hand off conversations to queues in Omnichannel. To receive incoming messages, the bot must be added to at least one queue. The bot will use the routing rules that were created at setup.  You can change them in the Work Streams section of Omnichannel.

To set up your Virtual Agent bot:
1. Connect virtual agent to Omnichannel and go to the Omnichannel configuration. For more information, see [Omnichannel setup & configure](https://github.com/MicrosoftDocs/dynamics-365-ai-pr/blob/pawant-ms-handoff/ai-docs/customer-service-virtual-agent/how-to-setup-omnichannel-handoff.md).

    ![Virtual Agent bot settings](../media/virtual-agent-bot-settings.png)
    
    The bot will be auto-created in Omnichannel, and you just need to finish setting it up.

2. Assign the bot to an existing queue.
    
    ![Virtual Agent bot select queue](../media/virtual-agent-bot-select-queues.png)

3. Click Done. Now you're on the bot profile page and you can see that your bot is connected. 
    
    ![Virtual Agent bot profile page](../media/virtual-agent-bot-profile.png)
    
    Your Virtual Agent bot is ready to accept and respond to customer-initiated conversations.

Existing routing rules will send incoming messages to the Virtual Agent. When a handoff is triggered, customers will be transferred from the Virtual Agent to the human agent according to the escalation routing rules.

### Set escalation rules

Escalation rules allow you to create rules for the bot to escalate the queries to the appropriate agent. For escalation rules, you must create work streams containing context variables and appropriate routing rules to route the customer queries.

If the bot escalates the customer query, it is routed to the appropriate queue as per the defined routing rule. If the customer query in redirected to the same queue, another agent in the queue will pick the conversation as per the capacity. For information on working with queues, see [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md).

> [!NOTE]
> If you have only one queue with bot and agents, and you didn't create a routing rule, the customer query is redirected to the same queue in case of escalation and picked up by an agent.

#### Create a work stream

A work stream is a collection of routing and work distribution settings. In order to route messages correctly, you must create at least two routing rules within a workstream to account for the virtual agent bot and the human agent.

1. Select or create a work stream.

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream context variable](../media/virtual-agent-work-stream-context-variables.png "Virtual Agent work stream context variable")

    > ![Virtual Agent work stream](../media/virtual-agent-work-streams.png)

    > ![Virtual Agent work stream](../media/virtual-agent-work-streams.png)

2. Add a context variable to the work stream. 

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream context variable](../media/virtual-agent-work-stream-context-variables.png "Virtual Agent work stream context variable")

3. Create a routing rule for the human agent and add it to the work stream.

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream routing rules](../media/virtual-agent-work-stream-routing-rule.png "Virtual Agent work stream routing rules")

4.  Create a routing rule for the virtual agent and add it to the work stream.

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream bot routing rules](../media/virtual-agent-work-stream-routing-rule-bot.png "Virtual Agent work stream bot routing rules")

For more information about work streams, see [Understand and create work streams](work-streams-introduction.md).

#### Create a context variable

You must use the context variables that were created during setup for the bot to handle the customer queries appropriately. The context variable is used in routing the incoming customer queries to the appropriate bots and agents. For information about context variables, see [Contextual variables available upon hand-off](https://github.com/MicrosoftDocs/dynamics-365-ai-pr/blob/pawant-ms-handoff/ai-docs/customer-service-virtual-agent/how-to-trigger-contextual-handoff.md#contextual-variables-available-upon-hand-off).

#### Create routing rules

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable.

Bots are developed to receive customer queries first, gain information of the query,  and then pass the query to a human agent, if required. To achieve this behavior, you must add a bot user to the queue and configure routing rules in a way that the incoming customer queries are routed to the queue with bot user.

Ensure to map the routing rules to the correct queues so that the queries are routed appropriately. For information about routing rules, see [Create and manage routing rules](routing-rules.md).

## Known limitations
- Adaptive cards (for CSAT card only)
- Suggested actions
- Typing

## Privacy notice

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement).

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Add a chat widget](add-chat-widget.md)<br>
[Enable a bot to escalate and end conversation](../developer/bot-escalate-end-conversation.md)
