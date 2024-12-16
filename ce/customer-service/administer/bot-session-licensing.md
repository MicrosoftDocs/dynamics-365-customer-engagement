---
title: Bot sessions and licensing
description: Use this article to learn about bot sessions and licensing in your contact center.
ms.date: 12/13/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.custom: bap-template
ms.collection:
---

# Bot sessions and licensing

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

A bot session is defined as a conversation in which a bot is invoked. The bot can be invoked at the start, middle, or end of a conversation.

- If two different bots are invoked in the same conversation, it is considered a single conversation.
- A conversation with a bot that's escalated to a human agent is considered a bot conversation.

The add-in applications such as Chat, Digital Messaging, and Voice channel are licensed per user. Each add-in application is entitled to a specific number of bot sessions. You can also purchase additional bot sessions on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true)

To learn about the required subscriptions to use the chat and voice channels, see the [Licensing](../implement/system-requirements-omnichannel.md#licensing) section. Learn more about licenses and pricing in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

### Related information

[Overview of bots](overview-bots.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Copilot Studio bot](configure-bot-virtual-agent.md)  
[Configure Copilot Studio bot for voice](voice-channel-pva-bots.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
