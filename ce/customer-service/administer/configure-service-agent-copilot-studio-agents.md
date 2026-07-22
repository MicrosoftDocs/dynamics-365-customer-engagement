---
title: Configure Copilot Studio agents in Service Agent
description: Learn how administrators can extend Service Agent in Dynamics 365 Customer Service by connecting published Microsoft Copilot Studio agents.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 06/30/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure Copilot Studio agents in Service Agent

Administrators can extend Service Agent by connecting published Microsoft Copilot Studio agents. A connected agent appears as a capability that Service Agent can invoke to help service representatives complete business processes. You can add, update, and remove published Copilot Studio agents.

> [!NOTE]
> This article describes how to connect a published Copilot Studio agent to Service Agent in Microsoft 365 Copilot by using maker mode. Learn more in:
>
> - [Extend Copilot with Copilot Studio](extend-copilot-with-copilot-studio.md), to extend the in-app Copilot help pane (**Ask a question**) in Customer Service.
> - [Integrate a Copilot agent](configure-bot-virtual-agent.md), to integrate a Copilot Studio agent into Omnichannel voice or chat routing.

## Prerequisites

- You have a published Copilot Studio agent.
- You have access to the target environment.
- You have a security role that allows Service Agent administration (for example, System Administrator or System Customizer) with the `prvmsdyn_ServiceAgentMakerCustomize` Dataverse privilege for the `msdyn_agentmetadataoverride` elastic table.

## Add a Copilot Studio agent

1. Open Service Agent and ask to **enter maker mode**.
1. Select **Organization** as the scope.
1. Prompt to **Add Copilot Studio agent**.
1. Add the agent by using one of the following options:
   - **Browse published agents**: Choose from the agents available in the connected environment.
   - **Provide identifiers manually**: Enter the **Agent ID** (Bot ID) and **Environment ID**.
1. Before you save, test the connection to validate connectivity, confirm the agent metadata, and verify authentication.
1. Add an agent description. The orchestrator uses this description to determine when to call the agent.

Learn more about maker mode scopes, reviewing current configurations, and exiting maker mode in [Configure Service Agent experiences](configure-service-agent-experiences.md#enter-maker-mode).

## Modify an agent

1. Open Service Agent and type **enter maker mode**.
1. Select **Organization** as the scope.
1. Open Copilot Studio agent management, and then select the agent that you want to update.
1. Update the agent's description or usage guidance, revalidate the connection, or refresh the metadata.

## Remove an agent

1. Open Service Agent and type **enter maker mode**.
1. Select **Organization** as the scope.
1. Open Copilot Studio agent management, and then remove the agent that you want to disconnect.

When you remove an agent, Service Agent stops invoking it. Removing the agent doesn't delete the original Copilot Studio agent.

## Best practices

Write a meaningful description for each agent. The description helps Service Agent determine when to use the agent.

| Quality | Example |
| --- | --- |
| Effective | Provides company product news, announcements, blogs, and product updates. |
| Ineffective | News Bot |

## Related information

- [Configure Service Agent experiences](configure-service-agent-experiences.md)  
- [Configure non-Microsoft MCP servers in Service Agent](configure-service-agent-mcp-servers.md)
