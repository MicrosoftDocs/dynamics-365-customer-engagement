---
title: "Best practices for configuring bots | MicrosoftDocs"
description: "This article lists the best practices that you can follow when you configure Azure and Power Virtual Agents bots in Omnichannel for Customer Service."
ms.date: 07/18/2022
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: article
---

# Best practices for configuring bots

Here are some best practices that you can follow when you configure Azure and Power Virtual Agents bots in Omnichannel for Customer Service:

- In a queue, if both bots and human agents are available, set the bot’s capacity higher than all agents. A bot’s capacity isn't reduced even after a work item is assigned to it. This ensures that any chat routed to the queue is first picked up by the bot.

- When a bot escalates a conversation to a human agent, make sure that the context variables being updated by the bot and the corresponding routing rules match correctly.

- When a chat that's escalated by a bot comes to the same queue due to incorrect configurations or due to failure in updating context variables, then the bot won't be assigned to the same chat again. This ensures that the chat doesn't end up in an infinite loop. Therefore, some human agents should be configured as backup in the bot queue to handle such chats.

- Unlike other Omnichannel for Customer Service agents, bots aren't added to a "default" queue at the outset; they're added from the Omnichannel admin center or Customer Service admin center apps.  

- The maximum size of a message that can be sent across all messaging channels is approximately 28 KB. The message size limit includes any metadata, such as timestamps and tags, associated with the message. So if you're a bot author or developer and want to pass complex cards or message types across channels, ensure that your message size doesn't exceed the 28 KB limit. If you're integrating a custom channel via Direct Line, then make sure that the activity payload doesn't exceed the message size limit.

### See also

[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure bots to escalate and end conversations](bot-escalate-end-conversation.md)  
[Context variables for a bot](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
