---
title: Configure agent context  
description: Use this article to understand how you can enable your Azure or Copilot agents to understand context while authoring agent flows.
ms.date: 04/29/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Configure agent context

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

AI agent context includes context name-value pairs for the current conversation and custom context passed by API programmatically. When customers start a conversation, the relevant context that's related to the customer, the issue they're facing, and recent activities performed by them can be made available for the agent to intelligently provide contextual responses to resolve customer issues in a quick and efficient manner. For example, the agent can use the signed-in user details to look up the recent case information or order history of the customer and provide a response. Similarly, the pre-conversation information, custom context, or recent pages browsed on a website by the customer can be passed on to the agent by configuring context variables for your agents.

For Azure agents, see [Configure agent context in Azure agents](enable-bot-context-azure.md).
For Copilot agents, see [Configure agent context in Copilot agents](enable-bot-context-pva.md).

## Next steps

[Configure agent context in Azure agents](enable-bot-context-azure.md)  
[Configure agent context in Copilot agents](enable-bot-context-pva.md)  

### Related information

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](reference/methods/setContextProvider.md)  
[Integrate an Azure agent](../administer/configure-bot-azure.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
