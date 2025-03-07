---
title: Manage your agents
description: Learn how you can quickly configure agents in the Customer Service admin center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 03/03/2025
ms.custom: bap-template
---

# Manage your agents in Omnichannel for Customer Service

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

In Omnichannel for Customer Service, you can seamlessly add an AI agent (agent) and get it up and running within a few minutes while the integration is taken care of in the background.

You can manage your agents in Copilot Studio on the **Bots** page.

## Prerequisites

Agents in Copilot Studio must be available in the tenant where Omnichannel for Customer Service is available.

## Add an agent

When you add an agent by using the steps outlined in this section, the agent in Copilot Studio is automatically registered in Azure and connected to Omnichannel for Customer Service. You'll then configure topics in Copilot Studio for the scenarios that you want the agent to handle.

> [!NOTE]
> Agents that you create in Customer Service admin center or Contact Center admin center work with enhanced voice workstreams only. To create classic agents for existing voice workstreams that aren't migrated, use Copilot Studio.

1. In admin center, select **Bots** under **Customer support**.
1. On the **Bots** page, select **Add**, and on the **Add a bot** page, select **Create new bot**, and then select **Next**.
1. On the **Create a basic bot** page, enter a name for your agent and select the primary language that it must use, and then select **Create**. The agent is created and listed on the **Bots** page. 
1. Optionally, you can also add an existing agent if it's already created in Copilot Studio. The **Connect existing bot** option lets you connect the agent. The agent is connected after a few minutes and listed on the **Bots** page. The voice-enabled agent that you connected works with the enhanced voice workstream only.
> [!IMPORTANT]
> Agents that you've created in Copilot Studio by using the [**Try the unified canvas (preview)**](/power-virtual-agents/authoring-first-bot) option won't work with the voice workstreams.

## Manage your agents

On the **Bots** page, you can review the agent details and also perform the following actions:

- Disconnect the agent.
- Select the agent name. The Copilot Studio app opens on a new tab where you can configure topics and other settings for the agent.

### Next steps

[Add a bot to a workstream](create-workstreams.md#add-a-bot-to-a-workstream)  
[End bot conversation](configure-bot-virtual-agent.md#end-agent-conversations)  

### Related information

[Get started with Customer Service admin center](../implement/cs-admin-center.md)  
[Configure Copilot Studio bots for voice channel](voice-channel-pva-bots.md)  
