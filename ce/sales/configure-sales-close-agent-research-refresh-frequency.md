---
title: Configure refresh frequency for Sales Close Agent - Research
description: Define how often the Sales Close Agent - Research refreshes its research data to provide up-to-date insights on opportunities.
ms.date: 03/13/2026
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

# Configure refresh frequency for Sales Close Agent - Research

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define how often the Sales Close Agent - Research refreshes its research data to provide up-to-date insights on opportunities.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Research settings page](open-sales-close-agent-research-settings.md).  
1. Under the **Guidance** settings section, select **Refresh frequency**.  
    :::image type="content" source="media/sca-research-refresh-frequency.png" alt-text="Screenshot of the Sales Close Agent - Research refresh frequency settings page.":::  
1. In the **Refresh frequency** page, specify how often the agent should refresh its research data.  
    The frequency is set to **Medium** by default, which is ideal for most businesses. You can refresh the research data more or less often based on how quickly your market and competitive landscape change and the available Copilot Studio capacity.

    - **Initial research only (recommended)**: Data is refreshed only when the agent is first assigned to an opportunity. This option is best for businesses that operate in a stable market with minimal changes in competitive information. It consumes the least capacity since the agent conducts research only once per opportunity, and sellers can request additional research on demand if needed. 
    - **High**: Data is refreshed every three days. This option is ideal for businesses that always need the latest information, but it consumes more capacity.
    - **Medium**: Data is refreshed every week days. This option is suitable for businesses that need regular updates but don't require daily insights. It balances performance and data accuracy.
    - **Low**: Data is refreshed every 14 days. This option consumes the least capacity and is suitable for businesses that don't need frequent updates and want to save capacity.

## Next step

[Set selection criteria for opportunities.](configure-sales-close-agent-research-selection-criteria.md)

## Related information

[Set up and configure the Sales Close Agent - Research (preview).](configure-opportunity-research-agent.md)
