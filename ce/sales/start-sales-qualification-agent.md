---
title: Start the Sales Qualification Agent
description: Learn how to start the sales qualification settings in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 02/04/2026
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Start the Sales Qualification Agent

> [!IMPORTANT]
> - Ensure that the agent is properly configured to avoid editing configurations after starting. Editing the agent changes how leads are processed before and after the change, giving different results.
> - Ensure that terms are accepted for Bing Search and Move data across regions in Power Platform admin center.

The **Start agent** option is enabled only after following steps are completed:

- All the sections in the agent configuration page are completed and marked with a green check mark as shown in the following image. 
- Outreach email simulation is completed (applicable only for **Research and engage** mode).

:::image type="content" source="media/sqa-settings-start-agent.png" alt-text="Screenshot of selecting start agent option on the Sales Qualification Agent settings page.":::

A confirmation message is displayed, select **Start agent** to start the agent. The agent might take a few seconds to start, and you can continue working while the agent is being started. Upon successful activation, the agent is listed under the AI agents home page with status as **On**. As soon as the agent starts, it starts processing the leads that match the [configured selection criteria](sales-qualification-agent-selection-criteria.md). Ensure that your sellers have necessary permissions to work on leads handed over by the agent. Learn more in [Grant permissions to sellers to work on leads handed over by agent](configure-sales-qualification-agent.md#grant-permissions).

> [!NOTE]
> If the agent fails to start due to unknown issues, contact Microsoft support.

## Add agent-specific views to your app

After you start the agent, sellers can view the list of leads being processed by the agent, leads handed over by the agent, and leads that are disqualified by the agent. 

The Sales Hub app includes the following agent-specific views by default:

- [Leads from AI Agent](use-sales-qualification-agent.md#view-leads-handed-over-by-the-agent)
- [Leads disqualified by AI Agent](use-sales-qualification-agent.md#view-leads-disqualified-by-the-agent)
- [Leads handed over by AI Agent](monitor-leads-by-sales-qualification-agent.md)
- [Leads being processed by AI Agent](monitor-leads-by-sales-qualification-agent.md)

If you don't see these views in your app, it could be because:

- Your organization uses a custom app for sales.
- You turned off **Include all views in the app** option for the **Lead** entity in Power Apps.

To add the agent-specific views to your app, follow the steps in [Manage views and charts](/power-apps/maker/model-driven-apps/create-add-remove-forms-views-dashboards#manage-views-and-charts).

## Related information

- [Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)  
- [Manage the Sales Qualification Agent](manage-sales-qualification-agent.md)
