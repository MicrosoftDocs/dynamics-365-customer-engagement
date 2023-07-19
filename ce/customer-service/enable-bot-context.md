---
title: Configure bot context  
description: Use this article to understand how you can enable your Azure or Power Virtual Agents bots to understand context while authoring bot flows.
ms.date: 07/12/2022
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---
# Configure bot context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Bot context includes context name-value pairs for the current conversation and custom context passed by API programmatically. When customers start a conversation, the relevant context that's related to the customer, the issue they're facing, and recent activities performed by them can be made available for the bot to intelligently provide contextual responses to resolve customer issues in a quick and efficient manner. For example, the bot can use the signed-in user details to look up the recent case information or order history of the customer and provide a response. Similarly, the pre-conversation information, custom context, or recent pages browsed on a website by the customer can be passed on to the bot by configuring context variables for your bots. 

For Azure bots, see [Configure bot context in Azure bots](enable-bot-context-azure.md).
For Power Virtual Agents bots, see [Configure bot context in Power Virtual Agents bots](enable-bot-context-pva.md).

## Next steps

[Configure bot context in Azure bots](enable-bot-context-azure.md)  
[Configure bot context in Power Virtual Agents bots](enable-bot-context-pva.md)  

### See also

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](developer/reference/methods/setContextProvider.md)  
[Integrate an Azure bot](configure-bot-azure.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
