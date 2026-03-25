---
title: Configure refresh frequency for Sales Opportunity Agent
description: Define how often the Sales Opportunity Agent refreshes its research data to provide up-to-date insights on opportunities.
ms.date: 03/30/2026
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
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
    The frequency is set to **Medium** by default, which is ideal for most businesses. You can refresh the research data more or less often based on how quickly your market and competitive landscape change and the available Copilot Studio capacity.

    - **Initial research only (recommended)**: Data is refreshed only when the agent is first assigned to an opportunity. This option is best for businesses that operate in a stable market with minimal changes in competitive information. It consumes the least capacity since the agent conducts research only once per opportunity, and sellers can request additional research on demand if needed. 
    - **High**: Data is refreshed every three days. This option is ideal for businesses that always need the latest information, but it consumes more capacity.
    - **Medium**: Data is refreshed every week days. This option is suitable for businesses that need regular updates but don't require daily insights. It balances performance and data accuracy.
    - **Low**: Data is refreshed every 14 days. This option consumes the least capacity and is suitable for businesses that don't need frequent updates and want to save capacity.
1. To manage the capacity that the agent uses, in the **Manage consumption limit** section, select **Manage limits**.
    The **Copilot Studio** page opens in a new tab. 
    Open the **Sales Opportunity Agent** for the environment to set up a usage limit.
    Rate-limiting configuration controls message usage per agent and sets monthly consumption limits for the agents. Set up a message limit at the agent level and enable the **Stop Usage** option to automatically stop the agent once the configured token or message threshold is exceeded.
    When the message limit is reached, the Sales Opportunity Agent automatically pauses and prevents any further usage. Processing resumes once you increase the threshold or when message capacity is available in the next usage cycle.
    To learn more about managing consumption limits, see [Manage monthly consumption limits for Copilot Studio agents](/power-platform/admin/manage-copilot-studio-messages-capacity#manage-monthly-consumption-limits-for-copilot-studio-agents).

## Next step

[Configure importance and risk assessment.](configure-sales-close-agent-research-opportunity-assessment.md)

## Related information

[Set up and configure the Sales Opportunity Agent](configure-opportunity-research-agent.md)
