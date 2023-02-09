---
title: "Manage context variables | MicrosoftDocs"
description: "Use this article to understand how you can add context variables and then configure them in Omnichannel for Customer Service."
ms.date: 02/02/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - intro-internal
---

# Manage context variables

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

*Context variables* enrich conversations with pre-conversation data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues. Context variables are also used in agent productivity tools like macros and agent scripts.

This article lists the considerations to use context variables and how you can create them.

## Considerations

[!INCLUDE[cc-context-variable-considerations](../includes/cc-context-variable-considerations.md)]

## Add context variables

1. Go to one of the admin apps, and perform the following steps:

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support** and open a workstream from the list.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     - In the site map, select **Workstreams** in **General settings** and open a workstream from the list.
    
   ### [Customer Service Hub](#tab/customerservicehub)

     - In the **Service Management** area, select **Workstreams** in **Unified Routing**, and then open a workstream from the list.
     
2. Select **Add context variable** in the **Advanced settings** section of a workstream.
3. In the **Edit** pane, select **Add**, and enter **Name**. Make sure that the variable name is less than or equal to 100 characters.
4. Select the **Type** of variable from the dropdown list. You can choose either **Text** or **Number**.
5. Repeat steps 3 and 4 to create the required variables.

## Configure context variables for Azure and Power Virtual Agents bots

You can also configure context variables for Azure and Power Virtual Agents bots in Omnichannel for Customer Service. When customers initiate a conversation, the relevant context that's related to the customer, the issue they're facing, and recent activities performed by them can be made available for the bot to intelligently provide contextual responses to resolve customer issues in a quick and efficient manner. For example, the bot can use the signed-in user details to look up the recent case information or order history of the customer and provide a response. Similarly, the pre-conversation information, custom context, or recent pages browsed on a website by the customer can be passed on to the bot by configuring context variables for the bot. Context variables set by the bot can also be passed to Omnichannel for Customer Service when the bot escalates to the human agent. For example, you can pass the ticketnumber for the case created by the bot to Omnichannel for Customer Service to link the case and load the customer summary for the agent to view.

To configure context variables for bots, see [Configure context variables for bots](context-variables-for-bot.md). But, before you configure context variables for bots, we recommend that you read the best practices for configuring bots. More information: [Best practices for configuring bots](configure-bot-best-practices.md)

To learn about using and sending custom context in a conversation, see [Send custom context](send-context-starting-chat.md).

### See also

[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Configure context variables for bots](context-variables-for-bot.md)  
[Configure bots to escalate and end conversations](bot-escalate-end-conversation.md)  
[Best practices for configuring bots](configure-bot-best-practices.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]