---
title: Manage your agents
description: Learn how you can quickly configure agents in the Copilot Service admin center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 05/09/2025
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Manage your agents in Dynamics 365 Contact Center

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


In your contact center, you can seamlessly add an AI agent and get it up and running within a few minutes while the integration is taken care of in the background.

You can manage your Copilot agents on the **AI Agents** page.

## Prerequisites

Agents in Copilot Studio must be available in the tenant where Dynamics 365 Contact Center is available.

## Add an agent

When you add an agent by using the steps outlined in this section, the Copilot agent is automatically registered in Azure and connected to Dynamics 365 Contact Center. You'll then configure topics in Copilot Studio for the scenarios that you want the agent to handle.

> [!NOTE]
> Agents that you create in Copilot Service admin center work with enhanced voice workstreams only. To create classic agents for existing voice workstreams that aren't migrated, use Copilot Studio.

1. In the site map of Copilot Service admin center, select **AI Agents** under **Customer support**.
1. On the **AI Agents** page, select **Add**, and on the **Add a bot** page, select **Create new bot**, and then select **Next**.
1. On the **Create a basic bot** page, enter a name for your agent and select the primary language that it must use, and then select **Create**. The agent is created and listed on the **Bots** page. 
1. Optionally, you can also add an existing agent if it's already created in Copilot Studio. The **Connect existing bot** option lets you connect the agent. The agent is connected after a few minutes and listed on the **Bots** page. The voice-enabled agent that you connected works with the enhanced voice workstream only.
> [!IMPORTANT]
> Agents that you've created in Copilot Studio by using the [**Try the unified canvas (preview)**](/power-virtual-agents/authoring-first-bot) option won't work with the voice workstreams.

## Manage your agents

On the **AI Agents** page, you can review the agent details and also perform the following actions:

- Disconnect the agent.
- Select the agent name. The Copilot Studio app opens on a new tab where you can configure topics and other settings for the agent.

### Next steps

[Add an agent to a workstream](create-workstreams.md#add-an-agent-to-a-workstream)  
[End an agent conversation](configure-bot-virtual-agent.md#end-agent-conversations)  

### Related information

[Get started with Copilot Service admin center](../implement/cs-admin-center.md)  
[Configure Copilot agents for voice channel](voice-channel-pva-bots.md)  
