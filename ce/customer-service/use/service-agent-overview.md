---
title: Overview of Service Agent
description: Learn about Service Agent, an AI-powered assistant in Dynamics 365 Customer Service that helps representatives resolve cases faster.
ms.date: 06/30/2026
author: lalexms
ms.author: laalexan
ms.collection: bap-ai-copilot
ms.topic: overview
ms.reviewer: laalexan
ms.update-cycle: 180-days
ms.custom: bap-template 
---

# Overview of Service Agent

Service Agent is an AI-powered assistant in Dynamics 365 Customer Service that helps customer service representatives resolve cases by completing supported tasks directly in Copilot Service workspace. Representatives use natural language to retrieve information, summarize cases, draft communications, and complete service-related tasks without leaving the workspace.

## Prerequisites

Before you can use Service Agent, your administrator must configure it for your organization. Learn more in [Configure Service Agent](../administer/configure-service-agent.md).

## What Service Agent can do

Service Agent supports capabilities throughout the case lifecycle, including the following areas:

- **Case and customer context**: Summarize cases, conversations, accounts, contacts, timelines, and related service activities so you can quickly understand a customer's situation.
- **Knowledge and answer discovery**: Search and synthesize information from trusted knowledge sources across Dataverse, SharePoint, and Microsoft 365 to generate grounded responses.
- **Service actions and follow-through**: Update cases, create notes and activities, draft customer communications, recommend next best actions, and complete supported tasks from within the conversation.
- **Quality and operations**: View evaluation insights, coaching recommendations, service-level agreement (SLA) and queue information, workforce context, and supervisor insights.
- **Administration and extensibility**: Configure, govern, and extend Service Agent by using role-based access, custom Model Context Protocol (MCP) tools, environment settings, and Microsoft 365 grounding.
- **In-chat experiences**: Keep work in the conversation with interactive, in-chat features that include:
    - File upload and image understanding
    - Image generation
    - Charts generated from service data
    - Microsoft Word, Excel, and PowerPoint creation
    - Interactive apps-in chat with grids, forms, and cards

## Where Service Agent appears

Service Agent is available in the following experiences:

- **Copilot Service workspace**: Service Agent is selected automatically as the active agent in the Copilot pane.
  - **Side pane**: A persistent panel that remains available while you work on records.
  - **Full page (Microsoft 365 Copilot app)**: A full conversational experience for working with Service Agent.
- **Microsoft Outlook**: Service Agent can use the currently open email thread as context to provide relevant assistance. Learn more in [Use Service Agent with Outlook](use-service-agent-outlook.md).

### Related information

- [Use Service Agent](use-service-agent.md)  
- [Use starter prompts in Service Agent](use-service-agent-starter-prompts.md)  
- [Use the prompt gallery in Service Agent](use-service-agent-prompt-gallery.md)  
- [Frequently asked questions about Service Agent](service-agent-faq.md)
