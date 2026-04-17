---
title: Extend Copilot with Copilot Studio (preview)
description: Learn how to extend Copilot in Dynamics 365 Customer Service by using the Microsoft Copilot Studio.
author: lalexms
ms.author: borisvolfson
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 04/17/2026
---

# Extend Copilot with Copilot Studio (preview)

[!INCLUDE [preview-banner](../../includes/cc-preview-features-definition.md)]

Administrators can extend Copilot in Dynamics 365 Customer Service by using Microsoft Copilot Studio. This capability enables organizations to configure custom knowledge sources, agents, and tools that Copilot can use when responding to user questions.

As of April 2026, extensibility configuration for Copilot is primarily managed in Copilot Studio instead of the Copilot Service admin center.

## Prerequisites

- You have the System Administrator or Customer Service administrator role.
- A license for Microsoft Copilot Studio is available in your tenant. Learn more in [Manage Copilot credits and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity) and [View agent's billing consumption](/microsoft-copilot-studio/analytics-consumption).
- Copilot is enabled in Dynamics 365 Customer Service.

## Understand how Copilot extensibility works

When Copilot extensibility is enabled, Copilot evaluates user questions by using the following sequence:

1. Copilot determines whether Copilot Studio extensibility is enabled.
2. If enabled, Copilot sends the request and available context to the Copilot Studio agent.
3. If Copilot Studio provides a confident response, that response is shown to the user.
4. If no confident response is available, Copilot falls back to its configured knowledge sources if they're enabled.

> [!NOTE]
> Basic functionality, such as rephrasing, summarization of text, and translation, take priority oer Copilot Studio extensibility.

## If you already use plugins or Copilot Studio knowledge

If your organization already uses plugins or Copilot Studio knowledge, the following scenarios apply:

**You’re already using plugins or knowledge and don’t need to make changes**

No action is required. Existing plugins and knowledge continue to work and remain available in **Ask a question** and other Copilot experiences.

**You want to update existing plugins**

To make changes to existing plugins, locate the relevant tool in the Copilot Studio agent ("Customer Service Copilot Bot"), and then update the tool configuration as needed.

> [!NOTE]
> If you want to change anything beyond the connection or Tool description, we recommend that you create a new tool in Copilot Studio agent and remove the old one. If you want to pass any Dynamics context to the tool it should be done in Copilot Service admin center. [Add custom context](#how-to-add-context).

## Enable Copilot Studio extensibility

To enable Copilot Studio extensibility:

1. Open the **Copilot Service admin center** app.
1. In the site map, go to **Productivity** > **Copilot settings** > **Manage**.
1. Go to **Agent within Copilot** > **Customer Support** > **Settings**.
1. Select the **Extend agent** tab, and then check the box for **Extend agent with Copilot Studio**.
1. Select **Save**.

## Context sent to Copilot Studio

When Copilot sends a request to Copilot Studio, it includes contextual information to improve response quality.

### Default context

By default, Copilot includes standard contextual information, such as:

- The current record
- User role information
- Session or conversation metadata

This context is sent automatically and doesn't require additional configuration.

### Custom context

You can add additional Dynamics 365 information to send to the Copilot Studio agent. This context helps the Copilot Studio agent to answer questions without needing the Copilot user to manually provide it.

For example, custom context can pass the customer's first and last name, which is used as input for a tool searching a database.

### How to add context**

To configure Extensibility capabilities in Copilot Studio, perform the following steps:

1. Open the **Copilot Service admin center** app.
1. In the site map, go to **Productivity** > **Copilot settings** > **Manage**.
1. Go to **Agent within Copilot** > **Customer Support** > **Settings**.
1. Select the **Extend agent** tab, and then select the plus (+) icon.
   > [!NOTE]
   > Make sure the **Extend Agent with Copilot Studio** check box is selected.
1. Enter the entity, data field, and description of the context you want the system to pass to the Copilot Studio agent.
   > [!NOTE]
   > The description you enter is used by the Copilot Studio agent orchestrator to understand how the context will be used.
1. Select **Save**

## How to get to Copilot Studio Extensibility Agent

To configure extensibility capabilities in Copilot Studio, perform the following steps:

1. Open the **Copilot Service admin center** app.
1. In the site map, go to **Productivity** > **Copilot settings** > **Manage**.
1. Go to **Agent within Copilot** > **Customer Support** > **Settings**.
1. Select the **Extend agent** tab, and then select the **Copilot Studio** link. The Copilot Studio **Customer Service Copilot Bot** opens, where you can modify the agent with your choice of tools, knowledge, agents, and topics.

## Type of Copilot Studio extensibility

The Customer Service Copilot Bot is a managed Copilot Studio agent that's connected to Copilot in Service Ask a question. It has Copilot Studio capabilities with some limitations. Learn more in [Limitations and restrictions](#limitations-and-restrictions). 

Use the following sections to learn about the different extensibilities and how you can use them in your environment.

### Knowledge

Knowledge sources allow Copilot to retrieve information from configured content locations. For example, use knowledge sources to answer questions based on internal documentation that might be available on your organization's SharePoint or public website.

Learn more in [Knowledge sources summary](../microsoft-copilot-studio/knowledge-copilot-studio).

### Tools

Tools enable Copilot to perform actions or retrieve structured data. For example, you can set up a tool that connects to an MCP Server that allows Copilot to get account information. Or, you could add a custom connector tool that updates the address of the same account.

Learn more in [Add tools to custom agents](../microsoft-copilot-studio/add-tools-custom-agent).

### Agents

Agents empower your Copilot by connecting it to other agents. They allow you to scale your solutions more efficiently and effectively. For example, you can create an agent that specializes in questions related to one area of your business. You can also connect to other agents your organization has created.

Learn more: [Add other agents overview](../microsoft-copilot-studio/authoring-add-other-agents).

### Topics

Topics let you design and control how Copilot responds to user interactions. You can use topics to define specific business logic that Copilot must follow when a topic is triggered.

With topics, you can:

- Guide conversations by defining the sequence of dialogs, messages, tools, agents, and knowledge sources.
- Implement complex workflows by controlling how Copilot responds at each step.
- Use a low-code canvas to define logic and manage variables.
- Integrate data, actions, and external systems as part of the experience.

Topics help you create structured, predictable interactions while still allowing Copilot to use its generative capabilities within the boundaries you define.

Learn more in [Use system topics](../microsoft-copilot-studio/authoring-system-topics).

### Limitations/Restrictions

At this time, you can't update the following components:

- The agent model. However, if you connect this agent to other agents, you can use a different model in those agents.
- Instructions.
- Certain managed topics. Topics with names that start with 
with `msdyn_` can't be modified.
- Custom connectors that use OAuth authentication. For improved user experience, select **Maker Authentication** for **User Experience benefits** when possible. Learn more in [User connectors with maker-provided credentials](../microsoft-copilot-studio/advanced-connectors#use-connectors-with-maker-provided-credentials).

