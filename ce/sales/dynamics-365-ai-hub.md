---
title: Access Dynamics 365 AI Hub
description: Learn how to add Dynamics 365 AI Hub sitemap entry to your custom app to manage your sales AI agents.
ms.date: 10/06/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Access Dynamics 365 AI Hub

Dynamics 365 AI Hub is a centralized hub for managing all your sales AI agents, such as the Sales Qualification Agent and Opportunity Research Agent. The AI Hub provides a unified interface to create, configure, and monitor your AI agents. It has the resources and tools you need to get started with agents and manage their performance over time. The following screenshot shows the Dynamics 365 AI Hub interface:

:::image type="content" source="media/dynamics-365-ai-hub.png" alt-text="Screenshot of the Dynamics 365 AI Hub interface.":::

Typically, sales managers and sales admins use the AI Hub to set up and manage AI agents that assist sales representatives in their daily tasks. The Hub includes the following tools:

- **Agent Manager**: Create and manage AI agents for various sales tasks, such as lead qualification and opportunity research.
- **AI optimization hub**: Monitor the performance of your AI agents and optimize their settings to improve their effectiveness.
- **Learn how AI agents work**: Access resources and documentation to understand how AI agents function and how to leverage them effectively in your sales processes.
- **Architecture, security, privacy, and compliance**: Find information about the technical architecture of AI agents, as well as details on responsible AI, security, privacy, and compliance considerations when using AI in your sales processes.

## Access the Dynamics AI Hub from Sales Hub app

To access the Dynamics 365 AI Hub from the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**. Then, go to **General settings** > **Dynamics 365 AI hub**.

## Access the Dynamics AI Hub from custom app

To access Dynamics 365 AI Hub from your custom app, [add a site map entry](add-custom-site-map.md) with the following URL:
`/main.aspx?pagetype=control&controlName=MscrmControls.CopilotTrustCenter.CopilotTrustCenterHubControl&data=%7B"product"%3A"sales"%7D`

If you're using custom roles, ensure that users have the privileges to access the respective agent management features. Otherwise, users will have access issues or see inaccurate or incomplete data in the dashboard.

- For Sales Qualification Agent management, read [Grant permissions to custom security role](configure-sales-qualification-agent.md#grant-permissions-to-custom-security-role)
- For Opportunity Research Agent management, read [Grant permissions to custom security role](configure-opportunity-research-agent.md#grant-permissions-to-custom-security-role)


## Related resources

- [Monitor opportunities handed over by the Opportunity Research Agent](monitor-opportunity-agent.md) 
- [Monitor leads handled by the Sales Qualification Agent (preview)](monitor-leads-by-sales-qualification-agent.md)
- [Set up and configure the Sales Qualification Agent (preview)](configure-sales-qualification-agent.md)
- [Configure the Opportunity Research Agent (preview)](configure-opportunity-research-agent.md)