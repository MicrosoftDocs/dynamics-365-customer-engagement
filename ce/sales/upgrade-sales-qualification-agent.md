---
title: Upgrade your Sales Qualification Agent
description: Learn how the Sales Qualification Agents in Dynamics 365 Sales can be your personal assistant in qualifying leads and improving sales outcomes.
ms.date: 07/31/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udaykirang
ms.reviewer: udaykirang
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Upgrade your Sales Qualification Agent

The following upgrade scenarios are supported for the Sales Qualification Agent in Dynamics 365 Sales:

- **Upgrade the agent to 7.3**: This upgrade is available for customers who signed up for the April 2025 public preview of the Sales Qualification Agent.
- **Upgrade the agent to handle both research and engagement**: This upgrade is available for customers who're currently using the research agent and want to extend its capabilities to include engagement tasks.


## Upgrade the agent to 7.3

After the 7.3 release is deployed in your environment, your existing Sales Qualification Agent will be set to the **Draft** mode. This change will impact the following functionalities:

- The agent will not be able to process new leads until it is reconfigured.

- For leads that are already processed by the agent, sellers will be able to see the lead insights until the agent is reconfigured. Sellers will see a notification informing them that the admin needs to reconfigure the agent.
- When you reconfigure the agent, existing agent settings won't be preserved. So, make note of your current settings if you'd like to continue with the same settings. Learn more about configuring the 7.3 Sales Qualification Agent in [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md).
- After the agent is reconfigured, leads that fulfill the selection criteria will get processed:
    - If a lead that was previously processed by the agent still fulfills the selection criteria, the agent processes it again for research and generates the outreach email.
    - For leads that no longer fulfill the selection criteria, sellers will only see the lead summary on the Lead research page. The seller is informed that due to the recent changes to agent settings, the research pages for some leads may not be available.
    :::image type="content" source="media/lead-research-not-accessible-banner.png" alt-text="Screenshot of the lead research page for leads that are not processed by the agent after upgrade.":::
    > [!NOTE]
    > The previous research data is stored in msdyn_leadagentresult (lead agent result) and msdyn_accountresearchresult (account research result).

## Upgrade the agent to handle both research and engagement

You can upgrade your Research agent to the Engage agent, which includes both research and engagement capabilities. Downgrading from the Engage agent to the Research agent is not supported.

- If you're using the 4.3 version of the Sales Qualification Agent (part of the April 2025 public preview), you can upgrade to the Engage agent by following the steps in [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md). Though the research-related settings are the same as the previous version, they won't be preserved during the upgrade. So, make note of your current settings if you'd like to continue with the same settings.

- If you're using the 7.3 version of the Research Agent and want to upgrade to the Engage agent, the research-related settings will be preserved during the upgrade. You can just configure the engagement-related settings. Learn more about configuring the Engage agent in [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md).


