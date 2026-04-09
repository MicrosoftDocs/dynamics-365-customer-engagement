---
title: Smart assist for representative efficiency 
description: Learn how to smartly assist representatives with the next-best steps in Copilot Service workspace.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 06/11/2025
ms.topic: how-to
ms.custom: bap-template
---

# Manage smart assist

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

> [!NOTE]
> The case and knowledge suggestions in smart assist aren't supported starting June 02, 2025. Learn more in [deprecations in Customer Service](../implement/deprecations-customer-service.md).

The new-age customer service industry is moving toward the vision of being intelligent rather than process-driven while interacting with customers. Pivoting on intelligence capabilities helps unleash the productivity of representatives to perform better on key performance indicators and&mdash;at the same time&mdash;deliver better customer experience.

Smart assist is an intelligent assistant that provides real-time recommendations to representatives, helping them take actions while interacting with customers. It allows organizations to build a custom AI agent (agent) and plug-in to their environment. These custom agents interpret conversations in real time and provide relevant recommendations such as knowledge articles, similar cases, and next-best steps to the representative's user interface.

The smart assist feature can be enabled across all channels, such as Chat for Dynamics 365 Customer Service, SMS, and Facebook (excluding Entity Records Channel), making it a consistent experience for representatives.

> [!IMPORTANT]
> The smart assist recommendations are displayed only after the representative sends a message.

## Value proposition

- Contextual recommendations are generated based on real-time conversations.

- Plug-in organization-specific recommendations are displayed to representatives in real time.

- Action-oriented recommendations are displayed for representatives to send responses or run automated actions.

- Intelligence is powered by using Microsoft Azure or third-party capabilities.

- Representatives can achieve improved average handling time and first call resolution.

## Prerequisites

- Productivity pane must be enabled. Out of the box, productivity pane is enabled by default.
- Smart assist must be enabled.
- One of the following:
  - AI-suggested similar cases and knowledge articles should be enabled by your administrator.
  - Develop a smart assist bot and integrate it with Omnichannel for Customer Service. The smart-assist bot interprets the conversation context in real time and provides suggestions to representatives. For information: [Build a smart assist bot using Azure Bot Service](../develop/smart-assist-bot.md).

  > [!NOTE]
  > - Microsoft Copilot agents aren't supported as smart assist agents.
  > - End conversation command isn't supported in the smart assist agents.

## Enable AI suggestions for similar cases and knowledge articles

To enable AI-suggested similar cases and knowledge articles, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md).

## Enable smart assist for the bot framework in Omnichannel for Customer Service

To enable smart assist for the bot framework in Omnichannel for Customer Service, perform the following steps:

1. [Create a bot user](#step-1-create-a-bot-user)

1. [Add smart assist bot to a workstream](#step-2-add-smart-assist-bot-to-a-workstream)

### Create an agent user<a name="step-1-create-a-bot-user"></a>

Create an agent user in the application to work as a smart assistant to the representative. An agent user is created as an application user and assigned the **Omnichannel agent** role. If your agent needs to search for knowledge base articles, then you need to provide either the **Customer Service Manager** or **Customer Service Representative** role.

You can create an application user only in the web client. Use the agent application ID of the smart assist bot to create the agent user. More information: [Create an agent user](../configure-bot.md#configure-the-bot-user-as-an-omnichannel-agent)

### Add a smart assist bot to a workstream<a name="step-2-add-smart-assist-bot-to-a-workstream"></a>

After you create an agent user, you need to add the agent to the workstream so that representatives who use the channel of this workstream can see the suggestions.

1. In Copilot Service admin center, go to **Workstreams** in **Customer support**, and select the workstream in which you want to add the smart assist bot.

2. Expand **Advanced settings**, and select **Add bot** in the **Smart assist bots** area.

3. In the **Add from existing** panel, select an agent user from the list, and then select **Add**.

You can add multiple agents to a workstream based on your business requirements.

### Region availability and language support

To learn about the regions and supported languages, see [Supported regions and languages](cs-region-availability-service-limits.md).

### Related information

[Macros](macros.md)  
[Scripts](agent-scripts.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
