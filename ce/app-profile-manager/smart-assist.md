---
title: Smart assist for agent efficiency 
description: Learn how to smartly assist agents with the next-best steps in Customer Service workspace and Omnichannel for Customer Service apps.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 06/08/2023
ms.topic: how-to
ms.custom: bap-template
---

# Manage smart assist

The new-age customer service industry is moving toward the vision of being intelligent rather than process-driven while interacting with customers. Pivoting on intelligence capabilities helps unleash the productivity of agents to perform better on key performance indicators and&mdash;at the same time&mdash;deliver better customer experience.

Smart assist is an intelligent assistant that provides real-time recommendations to agents, helping them take actions while interacting with customers. It allows organizations to build a custom bot and plug-in to their environment. These custom bots interpret conversations in real time and provide relevant recommendations such as knowledge articles, similar cases, and next-best steps to the agent's user interface.

The smart assist feature can be enabled across all channels, such as Chat for Dynamics 365 Customer Service, SMS, and Facebook (excluding Entity Records Channel), making it a consistent experience for agents.

> [!IMPORTANT]
> The smart assist recommendations are displayed only after the agent sends a message.

## Value proposition

- Contextual recommendations are generated based on real-time conversations.

- Plug-in organization-specific recommendations are displayed to agents in real time.

- Action-oriented recommendations are displayed for agents to send responses or run automated actions.

- Intelligence is powered by using Microsoft Azure or third-party capabilities.

- Agents can achieve improved average handling time and first call resolution.

## Prerequisites

- Productivity pane must be enabled. Out of the box, productivity pane is enabled by default.
- Smart assist must be enabled.
- One of the following:
  - AI-suggested similar cases and knowledge articles should be enabled by your administrator.
  - Develop a smart assist bot and integrate it with Omnichannel for Customer Service. The smart-assist bot interprets the conversation context in real time and provides suggestions to agents. For information: [Build a smart assist bot using Azure Bot Service](../customer-service/smart-assist-bot.md).

  > [!NOTE]
  > Power Virtual Agents bots aren't supported as smart assist bots.

## Enable AI suggestions for similar cases and knowledge articles

To enable AI-suggested similar cases and knowledge articles, see [Enable AI suggestions for similar cases and knowledge articles](../customer-service/csw-enable-ai-suggested-cases-knowledge-articles.md).

## Enable smart assist for the bot framework in Omnichannel for Customer Service

To enable smart assist for the bot framework in Omnichannel for Customer Service, perform the following steps:

1. [Create a bot user](#step-1-create-a-bot-user)

1. [Add smart assist bot to a workstream](#step-2-add-smart-assist-bot-to-a-workstream)

### Create a bot user<a name="step-1-create-a-bot-user"></a>

Create a bot user in the application to work as a smart assistant to the agent. A bot user is created as an application user and assigned the **Omnichannel agent** role. If your bot needs to search for knowledge base articles, then you need to provide either the **Customer Service Manager** or **Customer Service Representative** role.

You can create an application user only in the web client. Use the bot application ID of the smart assist bot to create the bot user. More information: [Create a bot user](../customer-service/configure-bot.md#configure-the-bot-user-as-an-omnichannel-agent)

### Add a smart assist bot to a workstream<a name="step-2-add-smart-assist-bot-to-a-workstream"></a>

After you create a bot user, you need to add the bot to the workstream so that agents who use the channel of this workstream can see the suggestions.

1. In Customer Service admin center, go to **Workstreams** in **Customer support**, and select the workstream in which you want to add the smart assist bot.

2. Expand **Advanced settings**, and select **Add bot** in the **Smart Assist bots** area.

3. In the **Add from existing** panel, select a bot user from the list, and then select **Add**.

You can add multiple bots to a workstream based on your business requirements.

### Region availability and language support

To know about the regions and supported languages, see [Supported regions and languages](../customer-service/cs-region-availability-service-limits.md).

### See also

[Macros](macros.md)  
[Agent scripts](agent-scripts.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
