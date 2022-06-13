---
title: "Best practices for configuring Azure bots | MicrosoftDocs"
description: "Use this article to understand the best practices for configuring Azure bots in Omnichannel for Customer Service."
ms.date: 05/16/2022
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: article
---

# Best practices for configuring Azure bots

Here are some best practices that you can follow when you configure Azure bots in Omnichannel for Customer Service:

- In a queue, if both bots and human agents are available, set the bot’s capacity higher than all agents. A bot’s capacity is not reduced even after a work item is assigned to it. This ensures that any chat routed to the queue is first picked up by the bot.

- In case of bot escalation, make sure that the context variables being updated by the bot and the corresponding routing rules match correctly.

- If a chat that's escalated by the bot comes to the same queue due to incorrect configurations or due to failure in updating context variables, then bot won't be assigned the same chat again. This is to ensure that the chat doesn't end up in an infinite loop. Therefore, some human agents should be configured as backup in the bot queue to handle such chats.

- Unlike other Omnichannel for Customer Service agents, bots are not added to a "default" queue at the outset; they're added from the Omnichannel admin center or Customer Service admin center apps.

### See also

[Integrate an Azure bot](configure-bot-azure.md)  
[Configure bots to escalate and end conversations](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
