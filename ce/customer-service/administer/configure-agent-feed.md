---
title: Configure AI agent monitoring
description: Configure agent feed for supervisors to monitor AI agent activities in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 05/27/2026
ms.update-cycle: 180-days
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Configure autonomous agent monitoring


The agent activity monitoring experience helps supervisors track autonomous agent activities on cases. A detailed view of the activities helps supervisors identify problems and improve autonomous agents performance to better serve customers.

Supervisors can monitor agent activity by using **Agent Feed** (preview) and **Agent Supervisor** view in case forms.

## Prerequisites

Administrator role with permissions to access Power Apps.

##  Add autonomous agent feed and agent supervisor view

To view the agent activity, you need to add the autonomous agent and the Agent Supervisor view to the Copilot Service workspace app in Power Apps. Learn more in [Add agents to your model-driven app](/power-apps/maker/model-driven-apps/add-agents-to-app).

1. Sign in to Power Apps and select your contact center environment.
1. In the site map, select **Apps**, search for Copilot Service workspace, and edit it.
1. Follow these steps to enable Agent feed:
    1. In the site map, select the **Agents** icon.
    1. Under **Agent feed**, select the agent that corresponds to Case Management Agent, such as **Case Processing Agent**, select the ellipses (...) > **Add to app**.
    1. Save and publish the changes.
1. Follow these steps to add Agent Supervisor view:
    1. Search for and select **Case** view.
    1. In **Cases** pane, select **Views**.
    1. Select the ellipses (...) for **Agent Supervisor** and then select **Add**.
    1. Save and publish the changes.
1. Sign in to Copilot Service workspace with a supervisor role to verify that the agent feed appears in the site map.

### Related information

[Set up Case Management Agent to create and update cases](set-up-autonomous-case-agents.md)  
[Supervise autonomous agents](../use/supervise-ai-agents.md)  