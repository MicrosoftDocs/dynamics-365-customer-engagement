---
title: Configure refresh frequency for Sales Opportunity Agent
description: Define how often the Sales Opportunity Agent refreshes its research data to provide up-to-date insights on opportunities.
ms.date: 03/30/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.service: dynamics-365-sales
ms.custom: bap-template
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure refresh frequency for Sales Opportunity Agent

Define how often the Sales Opportunity Agent refreshes its research data to provide up-to-date insights on opportunities.

**Follow these steps**:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. Under the **Guidance** settings section, select **Refresh frequency**.  
    :::image type="content" source="media/sca-research-refresh-frequency.png" alt-text="Screenshot of the Sales Opportunity Agent refresh frequency settings page.":::  
1. In the **Refresh frequency** page, specify how often the agent should refresh its research data.

    - **Initial research only (recommended)**: The agent refreshes data only when it's first assigned to an opportunity. Choose this option if your business operates in a stable market with minimal changes in competitive information. It consumes the least capacity since the agent conducts research only once per opportunity. Sellers can request additional research on demand if needed. 
    - **High**: The agent refreshes data every three days. Choose this option if your business always needs the latest information, but it consumes more capacity.
    - **Medium**: The agent refreshes data once in a week. Choose this option if your business needs regular updates but doesn't require daily insights. It balances performance and data accuracy.
    - **Low**: The agent refreshes data every 14 days. This option consumes the least capacity and is suitable for businesses that don't need frequent updates and want to save capacity.
1. To limit the capacity the agent can use, in the **Manage consumption limit** section, select **Manage limits**.
    The **Copilot Studio** page opens in a new tab. 
    Open the **Sales Opportunity Agent** for the environment to set up a usage limit.
    Rate-limiting configuration controls message usage per agent and sets monthly consumption limits for the agents. Set up a message limit at the agent level and enable the **Stop Usage** option to automatically stop the agent once the configured token or message threshold is exceeded.  
    When the message limit is reached, the Sales Opportunity Agent automatically pauses and prevents any further usage. Processing resumes once you increase the threshold or when message capacity is available in the next usage cycle.
    To learn more about managing consumption limits, see [Manage monthly consumption limits for Copilot Studio agents](/power-platform/admin/manage-copilot-studio-messages-capacity#manage-monthly-consumption-limits-for-copilot-studio-agents).

## How the agent processes records

The Sales Opportunity Agent processes opportunities based on the defined selection criteria and refresh frequency. Here's how it works:

1. The agent selects opportunities that meet the [defined selection criteria](configure-sales-close-agent-research-selection-criteria.md) and [prioritizes](configure-sales-close-agent-research-selection-criteria.md#how-the-agent-prioritizes-records) them using factors such as estimated revenue, expected close date, and research freshness.
1. **Refresh frequency** determines how often the agent updates its research data and re-evaluates opportunity priority. Opportunity prioritization is dynamic and can change with each refresh based on the latest data. For example: 
    - When set to **High**, the agent refreshes its research every three days and might reprioritize opportunities based on the latest information.
    - When set to **Initial research only**, the agent doesn't refresh its research after the initial run, so prioritization stays based on the original data.
1. The agent processes up to a maximum number of opportunities per refresh cycle, which varies by region. If more opportunities match the criteria than the refresh cycle allows, the agent prioritizes and researches the highest-ranked opportunities first. To know your daily processing capacity based on your refresh frequency, see the **Daily refresh limit** section in the **Selection criteria** settings page.
1. The agent defers any remaining opportunities that exceed the refresh cycle limit. These opportunities might become eligible for processing during the next refresh cycle depending on its priority. For example, if 10,000 opportunities match the criteria and refresh cycle is set to **High**, the agent processes the top 6,480 opportunities based on prioritization factors in three days. The remaining 3,520 opportunities are deferred and might be processed in the next refresh cycle based on their priority ranking at that time including the opportunities that are processed in the current cycle.

## Next step

[Configure importance and risk assessment](configure-sales-close-agent-research-opportunity-assessment.md).

## Related information

[Set up and configure the Sales Opportunity Agent](configure-opportunity-research-agent.md).
