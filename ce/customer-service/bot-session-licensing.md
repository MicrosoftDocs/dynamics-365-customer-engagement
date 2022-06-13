---
title: "Bot sessions and licensing | MicrosoftDocs"
description: "Use this article to learn about bot sessions and how you can purchase additional chatbot sessions."
ms.date: 05/16/2022
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - intro-internal
---

# Bot sessions and licensing

A bot session is defined as a conversation in which a bot is invoked. The bot can be invoked at the beginning, during, or end of a conversation.

- If two different bots are invoked in the same conversation, it is considered a single conversation.
- A conversation with a bot that's escalated to a human agent is considered a bot conversation.

> [!NOTE]
> If smart assist is enabled, the bot conversations don't include smart assist conversations. More information: [View smart assist suggestions for agents configured using custom Azure bot](oc-smart-assist.md)

Each Chat and Digital Messaging license receives an entitlement of 50 chatbot sessions for use with Microsoft Bot Framework bots. These sessions are pooled at the tenant level and expire at the end of each month. For additional chatbot sessions, you must purchase the Chatbot Sessions Add-on. For more information on Chatbot licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

## Purchase additional chatbot sessions

Chatbot session add-ons entitle customers with Chat or Digital Messaging to an additional 100 chatbot sessions for use with Microsoft Bot Framework bots, pooled at the tenant level. Additional chatbot sessions expire at the end of each month.

**To purchase additional bot conversations from Microsoft 365 admin center**

1. Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the global administrator credentials.

2. Go to **Billing** > **Purchase Services**, and then select **Add-ons**.

3. Under **Add-ons**, select **Dynamics 365 for Customer Service Chatbot session add-on**.

4. Select the number of add-ons required and complete the purchase.

> [!Note]
> Authentication cards are not supported in bots that are integrated with Omnichannel for Customer Service.


### See also

[Overview of bots](overview-bots.md)  
[Integrate an Azure bot](configure-bot-azure.md)  
[Integrate Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure Power Virtual Agents bot for voice](voice-channel-pva-bots.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]