---
title: Prerequisites applicable to all Sales agents
description: Learn how to set up prerequisites for using Sales agents in Dynamics 365 Sales.
ms.date: 02/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Prerequisites for all sales agents

To set up and use the built-in sales agents such as the Sales Qualification Agent and Sales Close Agent, make sure you meet certain common prerequisites. Some agents require additional prerequisites, which their respective agent setup articles cover.

## Verify prerequisites

You must be a tenant administrator to set up the prerequisites.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Go to **General Settings** > **Dynamics 365 AI hub**.  
   If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. Learn more in [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md).

1. Under **Agent manager**, select **Create and manage agents** .
1. On the **AI agents** page, select **Prerequisites** and verify that prerequisites common to all sales agents are marked as **Done**.
   :::image type="content" source="media/opportunity-research-agent-prerequisites.png" alt-text="Screenshot of the Prerequisites page for Sales Close Agent - Research."::: 
1. If any prerequisite isn't marked as **Done**, select the appropriate call-to-action to complete the prerequisite:
   - **Microsoft Copilot Studio capacity**: Select **Set up** to open the Power Platform admin center and set up capacity. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).

   - **Move data across regions**: Select **Accept terms** to open the Power Platform admin center and allow data movement under **Generative AI features** > **Move data across regions**.
   - **AI prompts**: Select **Set up** to open the Power Platform admin center and [turn on AI prompts](/ai-builder/administer#enable-or-disable-ai-prompts-in-power-platform-and-copilot-studio). This setting allows the agent to use custom or predefined prompts.
1. Turn on the following AI capabilities in Power Platform admin center:
   - [AI insight cards](/power-platform/admin/settings-features). This setting notifies sellers about the insights on the opportunity record. Learn more about turning on this feature in [Manage feature settings](/power-platform/admin/settings-features).
   - [AI Agents](/power-platform/admin/copilot/copilot-hub#turn-on-ai-capabilities-in-dynamics-365-sales). This setting enables the configuration and use of AI agents in Dynamics 365 Sales.


## Related information

- [Set up and configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
- [Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)
- [Configure the Sales Close Agent - Research (preview)](configure-opportunity-research-agent.md)