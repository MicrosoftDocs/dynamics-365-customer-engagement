---
title: Upgrade your Sales Qualification Agent
description: Learn how to upgrade your Sales Qualification Agent in Dynamics 365 Sales to the latest version or extend its capabilities.
ms.date: 05/29/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Upgrade your Sales Qualification Agent

You can upgrade your Sales Qualification Agent to handle both research and engagement. This upgrade is available for customers who are currently using the Research-only mode of the agent and want to extend its capabilities to include engagement as well.

## Considerations for upgrading the agent to handle both research and engagement

- You can upgrade your Sales Qualification Agent from the Research-only mode to Research and engage mode, which includes both research and engagement capabilities.

- Downgrading from the Research and engage mode to the Research-only mode isn't supported.
- You can upgrade from both the April 2025 preview version and 7.3 Research-only mode to Research and engage mode.
- The research-related settings are preserved during the upgrade. You can just configure the engagement-related settings.

## Upgrade the agent from Research-only to Research and engage mode

1. From the **App Settings** area, select **Dynamics 365 AI Hub**.

1. Select the agent with type **Sales Qualification Agent** and skill **Research**.
   The **Edit agent** page opens with your existing settings for research.
1. In the **Automation** section, select **Engage**.
1. Scroll down and complete the additional prerequisites for engagement and select **Next**.
   Until all prerequisites are marked as Done, the **Next** button is disabled and the left pane isn't loaded with the settings.
   :::image type="content" source="media/upgrade-confirmation-message.png" alt-text="Screenshot of the confirmation message for upgrading the agent to handle both research and engagement.":::
   After you confirm the upgrade, the agent is set to **Draft** mode. Leads that are already in progress continues to be processed, but no new leads are processed until the agent is reconfigured and started.
1. Review each section and configure additional settings for engagement. Learn more about configuring engagement in [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md). 
1. Select **Start agent** when you're ready to upgrade the agent.
   The agent is turned **On** and starts processing leads that fulfill the selection criteria and starts engaging with the leads that meet the handover criteria.