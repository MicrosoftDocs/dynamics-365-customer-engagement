---
title: Manage your bots
description: Learn how you can quickly configure bots in the Customer Service admin center.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/19/2023
ms.custom: bap-template
---

# Manage your bots in Omnichannel for Customer Service

In Omnichannel for Customer Service, you can seamlessly add a bot and get it up and running within a few minutes while the integration is taken care of in the background.

You can manage your Power Virtual Agents bots, such as connect and disconnect them on the **Bots** page.

## Prerequisites

Power Virtual Agents bots must be available in the tenant where Omnichannel for Customer Service is available.

## Add a bot

When you add a bot by using the steps outlined in this section, the Power Virtual Agents bot is automatically registered in Azure and connected to Omnichannel for Customer Service. You'll then configure greetings topics in Power Virtual Agents for the scenarios that you want the bot to handle.

1. In Customer Service admin center, select **Bots** under **Customer support**.
1. On the **Bots** page, select **Add**, and on the **Add a bot** page, select **Create new bot**, and then select **Next**.
1. On the **Create a basic bot** page, enter a name for your bot and select the primary language that the bot should use, and select **Create**. The bot is created and listed on the **Bots** page.
1. Optionally, you can also add an existing bot if a bot is already created in Power Virtual Agents. The **Connect existing bot** option let you connect the bot. The bot is connected after a few minutes and listed on the **Bots** page.  

## Manage your bots

Some of the information that's listed on the **Bots** page includes the bot name, the type, whether voice is enabled, the workstreams to which the bot is connected, the queues to which the bot belongs, and its status. You can use the various options on the **Bots** page to manage your bots in the following ways:

- Disconnect the bot.
- Select the bot name and you'll navigate to the Power Virtual Agents app to configure topics and other settings for the bot.

### Next steps

[Add a bot to a workstream](create-workstreams.md#add-a-bot-to-a-workstream)  
[End bot conversation](configure-bot-virtual-agent.md#end-bot-conversation)  

### See also

[Get started with Customer Service admin center](cs-admin-center.md)  
[Configure Power Virtual Agents bots for voice channel](voice-channel-pva-bots.md)  
