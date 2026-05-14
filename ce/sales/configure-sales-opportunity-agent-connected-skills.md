---
title: Configure recommended actions for Sales Opportunity Agent
description: Learn how to enable recommended actions for the Sales Opportunity Agent in Dynamics 365 Sales to provide sellers with prioritized action recommendations based on detected risks in their opportunities.
ms.date: 05/19/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure recommended actions for Sales Opportunity Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Opportunity Agent can integrate with the [Recommended Actions Agent](recommended-actions-overview.md) to provide sellers with prioritized action recommendations based on detected risks in their opportunities. As an admin, you can enable this integration in the agent's configuration settings.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Follow these steps to enable recommended actions for the Sales Opportunity Agent:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. Under the **Guidance** settings section, select **Connected skills**.
1. In the **Recommended action** section, turn on the toggle.  

        :::image type="content" source="media/soa-recommended-actions-toggle.png" alt-text="Recommended actions toggle in Sales Opportunity Agent configuration page":::  

The recommended actions feature is enabled for the Sales Opportunity Agent. Action insight cards start appearing on opportunities that meet the criteria for the agent, providing sellers with prioritized recommendations to manage their opportunities effectively.  

The Sales Opportunity Agent appears in the AI agents list on the recommended actions configuration page, which indicates that it's enabled as a source for recommended actions. In that page, select **Sources**, and under **Default sources**, confirm that the Sales Opportunity Agent appears. To view and act on recommended actions, and to manage the agent's settings and insights, see [Configure Recommended Actions Agent](configure-recommended-actions.md).

:::image type="content" source="media/custom-source-added.png" alt-text="Screenshot of the recommended actions configuration page showing the added custom source.":::

## Next step

[Configure knowledge sources.](configure-sqa-knowledge-source.md)

## Related information

- [Set up and configure Sales Opportunity Agent](configure-opportunity-research-agent.md)
- [Configure Recommended Actions Agent](configure-recommended-actions.md)
