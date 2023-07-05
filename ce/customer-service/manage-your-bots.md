---
title: Manage your bots
description: Learn how you can quickly configure bots in the Customer Service admin center.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 07/05/2023
ms.custom: bap-template
---

# Manage your bots in Omnichannel for Customer Service

In Omnichannel for Customer Service, you can seamlessly add a bot and get it up and running within a few minutes while the integration is taken care of in the background.

You can manage your Power Virtual Agents bots on the **Bots** page.

## Prerequisites

Power Virtual Agents bots must be available in the tenant where Omnichannel for Customer Service is available.

## Add a bot

When you add a bot by using the steps outlined in this section, the Power Virtual Agents bot is automatically registered in Azure and connected to Omnichannel for Customer Service. You'll then configure topics in Power Virtual Agents for the scenarios that you want the bot to handle.

1. In Customer Service admin center, select **Bots** under **Customer support**.
1. On the **Bots** page, select **Add**, and on the **Add a bot** page, select **Create new bot**, and then select **Next**.
1. On the **Create a basic bot** page, enter a name for your bot and select the primary language that the bot should use, and then select **Create**. The bot is created and listed on the **Bots** page.
1. Optionally, you can also add an existing bot if a bot is already created in Power Virtual Agents. The **Connect existing bot** option let you connect the bot. The bot is connected after a few minutes and listed on the **Bots** page.  

> [!IMPORTANT]
> Bots that you've created in Power Virtual Agents by using the [**Try the unified canvas (preview)**](/power-virtual-agents/authoring-first-bot) option won't work with the voice workstreams.

## Manage your bots

On the **Bots** page, you can review the bot details and also perform the following actions:

- Disconnect the bot.
- Select the bot name and navigate to the Power Virtual Agents app to configure topics and other settings for the bot.

### Next steps

[Add a bot to a workstream](create-workstreams.md#add-a-bot-to-a-workstream)  
[End bot conversation](configure-bot-virtual-agent.md#end-bot-conversation)  

### See also

[Get started with Customer Service admin center](cs-admin-center.md)  
[Configure Power Virtual Agents bots for voice channel](voice-channel-pva-bots.md)  
