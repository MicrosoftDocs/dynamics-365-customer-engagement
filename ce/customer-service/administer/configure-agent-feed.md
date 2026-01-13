---
title: Configure AI agent feed (preview)
description: Configure agent feed for supervisors to monitor AI agent activities in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 01/14/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Configure AI agent feed (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The agent activity monitoring experience in your contact center allows supervisors to observe AI agents interactions with customers. A granular view of the activities enables the supervisors to identify issues and improve AI agents performance to better serve customers.

In the preview release, Case Management Agent only is supported. You can also enable any custom generative AI agents.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

Administrator role with permissions to access Power Apps.

## Add an autonomous agent feed

To view the agent activity, you need to add the autonomous agent to the Copilot Service workspace app in Power Apps. Learn more in [Add agents to your model-driven app](/power-apps/maker/model-driven-apps/add-agents-to-app).

1. Sign in to Power Apps and select the  environment in which your contact center resides.

1. In the site map, select **Apps**, search for Copilot Service workspace, and edit it.
1. In the site map, select the **Agents** icon.
1. Under **Agent feed**, select the agent that corresponds to Case Management Agent, such as **Case Processing Agent**, select the ellipses (...) > **Add to app**.

   :::image type="content" source="../media/screenshot-add-agent-feed.png" alt-text="Screenshot of adding agent feed to monitor AI agents.":::

1. Save and publish the changes.
1. Sign in to Copilot Service workspace with a supervisor role to verify that the agent feed appears in the site map.

### Related information

[Set up Case Management Agent to create and update cases](set-up-autonomous-case-agents.md)  
[Supervise AI agents](../use/supervise-ai-agents.md)  