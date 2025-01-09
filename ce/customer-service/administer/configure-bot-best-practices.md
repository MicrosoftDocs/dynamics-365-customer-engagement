---
title: Best practices for configuring agents
description: This article lists the best practices that you can follow when you configure Azure and Copilot Studio bots in your contact center.
ms.date: 12/14/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.custom: bap-template
ms.collection:
---

# Best practices for configuring agents

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

[!INCLUDE[cc-context-variable-considerations](../../includes/cc-context-variable-considerations.md)]

When you configure Azure and Copilot Studio bots in Omnichannel for Customer Service, use the following best practices:

- In a queue, if both bots and customer service representatives (service representatives or representatives) are available, set the bot’s capacity higher than all representatives. A bot’s capacity isn't reduced even after a work item is assigned to it. This ensures that any conversation routed to the queue is first picked up by the bot.

- When a bot escalates a conversation to a representative, make sure that the context variables being updated by the bot and the corresponding routing rules match correctly.

- When a conversation that's escalated by a bot comes back to the bot queue due to incorrect routing or context variables not being updated at runtime, the bot won't be assigned to the same conversation again. So, to prevent conversations from ending up in an infinite loop, you must configure a representative for the bot queue.

- Unlike representatives, bots aren't added to a "default" queue at the outset; you must add them from the Customer Service admin center app.

- The message size must be less than or equal to 28 KB in all messaging channels. The size limit includes metadata like timestamps and tags. If you're a bot author or developer and want to pass complex cards or message types across channels, ensure that your message size doesn't exceed the limit. If you're integrating a custom channel via Direct Line, then make sure that the activity payload doesn't exceed the message size limit.


### Related information

[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate a Copilot Studio bot](configure-bot-virtual-agent.md)  
[Configure bots to escalate and end conversations](../develop/bot-escalate-end-conversation.md)  
[Manage context variables](manage-context-variables.md)  
[Context variables for a bot](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
