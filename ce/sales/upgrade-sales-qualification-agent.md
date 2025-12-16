---
title: Upgrade your Sales Qualification Agent
description: Learn how to upgrade your Sales Qualification Agent in Dynamics 365 Sales to the latest version or extend its capabilities.
ms.date: 07/31/2025
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udaykirang
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Upgrade your Sales Qualification Agent

The following upgrade scenarios are supported for the Sales Qualification Agent in Dynamics 365 Sales:

- **Upgrade the agent to 7.3**: This upgrade is available for customers who signed up for the April 2025 public preview of the Sales Qualification Agent.
- **Upgrade the agent to handle both research and engagement**: This upgrade is available for customers who are currently using the Research-only mode of the agent and want to extend its capabilities to include engagement as well.

## Considerations for upgrading the agent to 7.3

After the 7.3 release is deployed in your environment, your existing Sales Qualification Agent is automatically set to the **Draft** mode. This change impacts the following functionalities:

- The agent can't process new leads until it's upgraded to 7.3.

- For leads that are already processed by the agent, sellers can see the lead insights until the agent is reconfigured and restarted. Sellers will see a notification informing them that the admin needs to reconfigure the agent.
- When you upgrade or reconfigure the agent, existing agent settings are preserved.
- After the agent is reconfigured, leads that fulfill the selection criteria will get processed:
    - If a lead that was previously processed by the agent still fulfills the selection criteria, the agent processes it again for research and generates the outreach email.
 
    - For leads that no longer fulfill the selection criteria, sellers will only see the lead summary on the Lead research page. The seller is informed that due to the recent changes to agent settings, the research pages for some leads may not be available.
    :::image type="content" source="media/lead-research-not-accessible-banner.png" alt-text="Screenshot of the lead research page for leads that aren't processed by the agent after upgrade.":::
    > [!NOTE]
    > You can access the previous research data from the msdyn_leadagentresult (lead agent result) and msdyn_accountresearchresult (account research result) tables.
 

## Upgrade the agent to 7.3

1. From the **App Settings** area, select **Dynamics 365 AI Hub**. 
   In the list of agents, you see that your Sales Qualification Agent is in **Draft** mode.

1. Select the agent.
   The **Edit agent** page opens with your existing agent settings.
1. Review the settings and make changes if needed. If you want to upgrade the agent to handle both research and engagement, you need more prerequisites and settings. Learn more in [Set up and configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
1. Select **Start agent** when you're ready to upgrade the agent.
   The agent is turned **On** and starts processing leads that fulfill the selection criteria.

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