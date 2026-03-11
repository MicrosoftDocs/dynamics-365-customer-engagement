---
title: Extend Copilot with Copilot Studio (preview)
description: Learn how to extend Copilot in Dynamics 365 Customer Service by using the Microsoft Copilot Studio.
author: lalexms
ms.author: borisvolfson
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 03/11/2026
---

# Extend Copilot with Copilot Studio (preview)

[!INCLUDE [preview-banner](../../includes/cc-preview-features-definition.md)]

Administrators can extend Copilot in Dynamics 365 Customer Service by using Microsoft Copilot Studio. This capability enables organizations to configure custom knowledge sources and tools that Copilot can use when responding to user questions.

As of March 2026, extensibility configuration for Copilot is primarily managed in Copilot Studio instead of the Copilot Service admin center.

## Prerequisites

- You have the System Administrator or Customer Service administrator role.
- A license for Microsoft Copilot Studio is available in your tenant. Learn more in [Manage Copilot credits and capacity](../power-platform/admin/manage-copilot-studio-messages-capacity) and [View agent's billing consumption](../microsoft-copilot-studio/analytics-consumption).
- Copilot is enabled in Dynamics 365 Customer Service.

## Understand how Copilot extensibility works

When Copilot extensibility is enabled, Copilot evaluates user questions by using the following sequence:

1. Copilot determines whether Copilot Studio extensibility is enabled.
2. If enabled, Copilot sends the request and available context to Copilot Studio.
3. If Copilot Studio provides a confident response, that response is shown to the user.
4. If no confident response is available, Copilot falls back to its configured knowledge sources.

This approach ensures that custom extensibility is used when appropriate while maintaining a consistent user experience.

## If you already use plugins

If your organization already uses plugins, the following scenarios apply:

**You’re already using plugins and don’t need to make changes**

No action is required. Existing plugins continue to work and remain available in **Ask a question** and other Copilot experiences.

**You want to update existing plugins**

To make changes to existing plugins, locate the relevant agent tool in Copilot Studio, and then update the tool configuration as needed.

If you want to change anything beyond the connector or description, we recommend that you create a new tool in Copilot Studio. In this case, configuration in the Copilot Service admin center is no longer required, except for context settings.

## Enable Copilot Studio extensibility

To enable Copilot Studio extensibility:

1. Open the **Copilot Service admin center** app.
2. In the site map, go to **Copilot** > **Extend agent**.
3. Select **Extend agent with Copilot Studio**.

After extensibility is enabled, you’re redirected to Copilot Studio to configure custom capabilities.

## Context sent to Copilot Studio

When Copilot sends a request to Copilot Studio, it includes contextual information to improve response quality.

### Default context

By default, Copilot includes standard contextual information, such as:

- The current record
- User role information
- Session or conversation metadata

This context is sent automatically and requires no additional configuration.

### Add custom context

You can add additional contextual information in Copilot Studio. Custom context helps tailor responses to your organization’s data and scenarios.

For example:
- Default context can be used to answer general case-related questions.
- Custom context can provide domain-specific details or additional data sources.

## Extensibility options in Copilot Studio

Copilot Studio provides multiple extensibility options.

### Knowledge

Knowledge sources allow Copilot to retrieve information from configured content locations. For example, use knowledge sources to answer questions based on internal documentation.

### Tools

Tools enable Copilot to perform actions or retrieve structured data. For example, use a tool to retrieve case details or perform a targeted lookup.

> [!Note]
> Some out-of-the-box scenarios, such as **case summaries** and **case question-and-answer**, use built-in Copilot capabilities and don’t require additional configuration.
