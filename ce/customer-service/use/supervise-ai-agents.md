---
title: Supervise autonomous agents using agent feed (preview)
description: As supervisors, monitor AI agent activities in your Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 09/24/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Supervise autonomous agents using agent feed (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Use the agent activity monitoring experience in your contact center to observe AI agents interactions with customers. Agent feed helps identify issues and improve AI agents to better serve customers.

In the preview release, Case Management Agent only is supported. You can also enable any custom generative AI agents.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Agent feed is enabled by your administrator.
- Case Management Agent is configured.
- The supervisor must also be the flow owner to view the agent feed.

## Monitor autonomous agent activities

In Copilot Service workspace, as a supervisor, you can view the agent activities by using the agent feed.

1. In the site map, select **Agent feed**. The agent feed pane displays the activities in **To do** and **Other** categories.

1. You can do the following actions:
   
   - Expand **To do** to see if you need to manually complete an action.
   - Expand **Other** to view the action types, such as send email, enrich case, and act on a customer issue.
   - Select an action to view details such as follows:
       - An AI-generated summary: Provides a quick overview of what's completed by the agent. You can also view the sequence of steps, such as whether agent has created a case and sent a follow-up email.
       - Conversation ID: The conversation linked to the case.

   Details like whether the agent was able to resolve the case, the topics it used to act on the customer issue, and interactions with a record are displayed in the feed.

     :::image type="content" source="../media/screenshot-agent-feed.png" alt-text="Screenshot of agent activity feed.":::

You can learn more about the various options in [Supervise agents in model-driven apps with agent feed](/power-apps/user/supervise-agents-with-agent-feed).

### Related information

[Set up Case Management Agent to create and update cases](../administer/set-up-autonomous-case-agents.md)  
[Configure agent feed for autonomous agents](../administer/configure-agent-feed.md)  