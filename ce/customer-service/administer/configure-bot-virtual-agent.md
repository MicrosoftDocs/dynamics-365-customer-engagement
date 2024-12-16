---
title: Integrate a Copilot Studio agent
description: Use this article to get instructions on how to integrate a Copilot Studio agent in your contact center.
ms.date: 12/16/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Integrate a Copilot Studio agent

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

[!INCLUDE[cc-trial-sign-up](../../includes/cc-trial-sign-up.md)]

Use agents to simulate human-like conversations for routine activities so that you can let your customer service representatives (service representative or representative) focus on high-value interactions. You can use Microsoft Copilot Studio to create agents that can interact with customers in Dynamics 365 Contact Center or Dynamics 365 Customer Service.

The following capabilities are available for the agent conversations:

- Seamlessly integrate your agent with all channels without needing to add channel-specific code in the agent.
- Configure interactive voice response (IVR) capabilities for voice-enabled agents.
- Configure contextual transfers to service representatives.
- Analyze the agent transcript that's available in Microsoft Dataverse after the conversation is completed.
- Configure routing rules to selectively route incoming requests to agents based on context, such as issue type or customer type. For example, you can route low-complexity issues to agents, or route the conversation to a sales or support agent based on the webpage browsing history of the customer.
- Monitor the agent conversations in real time by using the supervisor dashboard, which includes details such as customer sentiment.
- Use the historical dashboards to get insights into the effectiveness of the agents through metrics, such as resolution rate, escalation rate, resolution time, escalation time, and average sentiment.

When a conversation is escalated from a agent to a representative, the representative can see the full transcript of the agent conversation and get complete context while engaging with the customer. Learn more in [Enable a agent to escalate and end conversation](/dynamics365/customer-service/develop/bot-escalate-end-conversation?context=/dynamics365/contact-center/context/extend-context).


## Prerequisites

You must have:
 - A product license for Copilot Studio. Learn more in [Licensing for Copilot Studio](/microsoft-copilot-studio/requirements-licensing-subscriptions).
 - A product license for chat, digital messaging, or voice channel for Dynamics 365 Customer Service, depending on your business requirements.  
 - The CCI Admin security role to access the agent you create in Customer Service admin center or Contact Center admin center in Copilot Studio.
 - The Omnichannel administrator role. Learn more in [Manage user roles](/dynamics365/customer-service/implement/add-users-assign-roles)

## Create a Copilot Studio agent

You can create Copilot Studio agents in one of the following ways:

- TCreate the agent in the Dynamics 365 Contact Center admin center and then navigate to Copilot Studio to finish the configuration. Learn more at [add a agent](/dynamics365/customer-service/administer/manage-your-agents).
- Create the agent in Copilot Studio, which is then available in the Dynamics 365 Contact Center admin center. Learn more in:
     - [Create and delete copilots](/microsoft-copilot-studio/authoring-first-bot)
     - [Create a custom agent from a template](/microsoft-copilot-studio/template-fundamentals)
     - [Create voice-enabled agents from templates](/microsoft-copilot-studio/voice-build-from-template)
     
## Connect your Copilot Studio agent to omnichannel instance

For the agent to be able to interact with customers in Dynamics 365 Contact Center or Customer Service, you must integrate the agent with your application. Follow the procedure in [Connect your Copilot Studio agent to omnichannel](/microsoft-copilot-studio/configuration-hand-off-omnichannel) to connect your Copilot Studio agent to the omnichannel instance. 

When your customers need to speak with a representative, your agent can seamlessly hand off the conversation. When your agent hands off a conversation, it can share the full history of the conversation, and all relevant variables. Make sure you have an escalation article configured in your agent to hand off the conversation to a representative. Learn more in [hand off to a live agent](/microsoft-copilot-studio/advanced-hand-off).

## Set up agent capabilities

In Copilot Studio, you can add the following capabilities to your agent to finish your setup:

- Add knowledge sources to your agent to help it answer customer questions. Learn more in [Add knowledge sources to your agent](/microsoft-copilot-studio/knowledge-copilot-studio).
- Configure multilingual agents to support multiple languages. Learn more in [Configure multilingual agents](/microsoft-copilot-studio/multilingual).
-  IVR capabilities that are specific to voice-enabled agents such as dual-tone multi-frequency (DTMF) input, context variables, call transfer, and speech and DTMF customization. Learn more in [Configure Copilot Studio IVR agents](voice-channel-pva-bots.md).
- [Customize the look and feel of a copilot](/microsoft-copilot-studio/customize-default-canvas).

## Add a agent to a workstream

In the Customer Service admin center app, select the Copilot Studio agent from the list of agents in the [**Workstreams**](/dynamics365/customer-service/administer/create-workstreams?context=/dynamics365/contact-center/context/administer-context) area. Learn more in [Add an agent to a workstream](/dynamics365/customer-service/administer/create-workstreams#add-a-bot-to-a-workstream?context=/dynamics365/contact-center/context/administer-context).

> [!NOTE]
> - You can add only one agent per workstream.
> - Agents can receive conversations only if they're added to push-based workstreams.
> - Voice-enabled agents that you create in the Customer Service admin center or Contact Center admin center work with enhanced voice workstreams only. Classic agents aren't supported in the enhanced voice experience. To create classic agents for existing voice workstreams that aren't migrated, use Copilot Studio.


### Configure context variables for the Copilot Studio agent

After you configure your agent and add it to a workstream, you can configure context variables to [route work items](/dynamics365/customer-service/administer/queues-omnichannel?context=/dynamics365/contact-center/context/administer-context). You can also share context from Omnichannel with your Copilot Studio agent to create a rich and personalized experience. For information about creating context variables, go to [Manage context variables](/dynamics365/customer-service/administer/manage-context-variables?context=/dynamics365/contact-center/context/administer-context). For information about configuring context variables for Copilot Studio agents, go to [Configure context variables for Copilot Studio agent](/dynamics365/customer-service/administer/context-variables-for-bot#context-variables-for-copilot-studio-bots?context=/dynamics365/contact-center/context/administer-context).

## Add an agent to a queue

You can add an agent to the queue so that the agent can receive conversations from the queue. Learn more in [create and manage queues for unified routing](/dynamics365/customer-service/administer/queues-omnichannel?context=/dynamics365/contact-center/context/administer-context).


## Automatically close a conversation

When an agent receives a conversation that isn't escalated to a service representative, the conversation is closed if the customer abandons it. The conversation will also be closed automatically after 30 minutes of inactivity.

This conversation appears in the Omnichannel for Customer Service dashboard with the status set to **Closed** and **Resolved/abandoned** state in the Copilot Studio dashboard. Learn more in [Session outcomes over time chart](/power-virtual-agents/analytics-summary#session-outcomes-over-time-chart).

## End agent conversations

You must include an end of conversation article in a Copilot Studio agent to provide a clear and natural conclusion to the interaction, enhancing the overall user experience. It also allows the agent to suggest next steps, gather feedback, and handle any final errors, ensuring the user leaves the interaction satisfied. 

In the voice channel, the system doesn't listen for the **closeOmnichannelConversation** context variable. You must configure an [end of conversation message](#end-agent-conversations) that explicitly ends the conversation in Omnichannel for Customer Service.

1. In Copilot Studio, for the selected agent, add a new topic.

1. Select **Go to authoring canvas**, and in **Add node**, select **Call an action**, and then select **Create a flow**.

1. On the Power Automate window that opens on a new tab, do the following:
   1. In the **Return value(s) to Power Virtual Agents** box, select **Add an output**, and then select **Yes/No**.
   2. In the **Enter title** box, enter CloseOmnichannelConversation, which is the Omnichannel for Customer Service context variable name.
   3. In the **Enter a value to respond** box, select the **Expression** tab, and then enter **bool(true)** to build the expression, and select **OK**.
   4. Save the changes, and then exit Power Automate.

1. In the topic that you were editing, select **Call an action** again, and then in the list, select the flow that you created.

1. In **Add node**, select **End the conversation**, and then select **Transfer to agent**.

1. Go to the topic in which you need to invoke the topic for ending the agent conversation in Omnichannel for Customer Service, and use the **Go to another topic** option in **Add a node**.

1. Select the topic that you created for ending the agent conversation.

1. Save and publish the changes.

### Limitations


| Description     | Limitation     |
|-----------------|----------------|
| **Adaptive cards**</br>An adaptive card is a customizable card that can contain any combination of text, speech, images, buttons, and input fields.|<ul><li> You can build an adaptive card by adding a skill through Copilot Studio. Learn more in [Use Microsoft Bot Framework Skills in Copilot Studio](/power-virtual-agents/advanced-use-skills) </li><li> Adaptive card styling isn't supported.</li></ul> |
| **Typing**</br>An agent receives a typing activity to indicate that the user is typing a response. An agent may send a typing activity to indicate to the user that it's working to fulfill a request or compile a response. | Typing indicators don't appear. |
| **Format bot messages**</br>You can set the optional `TextFormat` property to control how the text content of your message is rendered. | <ul><li> Copilot Studio doesn't support Markdown with images and text. </li><li>When Copilot Studio sends Markdown text, there's an extra space between lines. </li></ul>|
| **OAuth card in Microsoft Teams**</br>Using a chat agent and presenting an OAuth card in the Microsoft Teams channel. | In Copilot Studio, the sign-in node presents an OAuth card and it doesn't work properly. |

## Privacy notice

You understand that your data might be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages are shared with the agent which could be interacting with a third-party system based on the integration done by you. Learn more about how we process your data in [Microsoft Privacy Statement](https://privacy.microsoft.com/privacystatement).

### Troubleshoot issues for agents

[How to end an agent conversation in Omnichannel for Customer Service](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/pva-conversations-active-dashboard)


## Next steps

[Agent transfer scenarios](/dynamics365/contact-center/administer/transfer-to-agents?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.yml) 

### Related information

[Manage your agents](manage-your-bots.md)  
[Integrate an Azure agent](configure-bot-azure.md)  
[Manage context variables](manage-context-variables.md)  
[Configure context variables for agents](context-variables-for-bot.md)  
[Identify customers automatically](record-identification-rule.md)  
[Enable an agent to escalate and end conversation](../develop/bot-escalate-end-conversation.md)  
[Best practices for configuring Azure and Copilot Studio bots](configure-bot-best-practices.md)  
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Understand and create workstreams](create-workstreams.md)  
[Create and edit topics in Copilot Studio agent](/power-virtual-agents/authoring-create-edit-topics)  
[Suggested actions](../develop/suggested-actions.md)  
[Add a chat widget](add-chat-widget.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
