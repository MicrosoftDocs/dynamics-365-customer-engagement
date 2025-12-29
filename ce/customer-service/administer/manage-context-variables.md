---
title: Manage context variables
description: Use this article to understand how you can add context variables and then configure them in Dynamics 365 Contact Center.
ms.date: 04/21/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Manage context variables

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

*Context variables* enrich conversations with pre-conversation data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues. Context variables are also used in customer service representative (service representative or representative) productivity tools like macros and scripts.

This article lists the considerations to use context variables and how you can create them.

## Considerations

[!INCLUDE[cc-context-variable-considerations](../../includes/cc-context-variable-considerations.md)]

## Add context variables

1. In the site map of Copilot Service admin center, select **Workstreams** in **Customer support** and open a workstream from the list.
1. Select **Add context variable** in the **Advanced settings** section of a workstream.
1. In the **Edit** pane, select **Add**, and enter **Name**. Make sure that the variable name is less than or equal to 100 characters.
1. Select the **Type** of variable from the dropdown list. You can choose either **Text** or **Number**.
1. Repeat steps 3 and 4 to create the required variables.

## Configure context variables for AI agents

You can also configure context variables for AI agents created in Azure and Copilot Studio in the application. When customers initiate a conversation, the relevant context that's related to the customer, the issue they're facing, and recent activities performed by them can be made available for the agent to intelligently provide contextual responses to resolve customer issues in a quick and efficient manner. For example, the agent can use the signed-in user details to look up the recent case information or order history of the customer and provide a response. Similarly, customers can configure context variables for the agent to pass on pre-conversation information, custom context, or recent pages that they browsed on a website. Context variables set by the AI agent can also be passed to Dynamics 365 when it escalates to the service representative. For example, you can pass the ticket number for the case created by the agent to Dynamics 365 Contact Center to link the case and load the customer summary for the representative to view.

Learn how to configure context variables for agents in [Configure context variables for AI agents](context-variables-for-bot.md). But, before you configure context variables for agents, we recommend that you read the best practices for configuring them. Learn more in [Best practices for configuring AI agents](configure-bot-best-practices.md).

Learn how to use and send custom context in a conversation in [Send custom context](../develop/send-context-starting-chat.md).

### Related information

[Integrate a Copilot Studio agent](configure-bot-virtual-agent.md)  
[Integrate an Azure agent](configure-bot-azure.md)  
[Configure context variables for agents](context-variables-for-bot.md)  
[Configure agents to escalate and end conversations](../develop/bot-escalate-end-conversation.md)  
[Best practices for configuring agents](configure-bot-best-practices.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
