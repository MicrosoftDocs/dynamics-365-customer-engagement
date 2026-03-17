---
title: Configure opportunity assessment for Sales Close Agent - Research
description: Learn how to configure the opportunity assessment settings for the Sales Close Agent - Research in Dynamics 365 Sales.
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

# Configure opportunity assessment for Sales Close Agent - Research

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Configure the fields that the agent uses as a factor to assess the importance and risk of the opportunities. In addition to these fields, the agent uses other signals such as customer interactions, stakeholder engagement, and so on. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Research settings page](open-sales-close-agent-research-settings.md).  
1. In the **Guidance** section, select **Opportunity assessment**.  
    :::image type="content" source="media/sca-opportunity-assessment-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Research opportunity assessment settings page.":::
1. In the **Opportunity assessment** settings, select the fields that the agent should use for assessing the importance and risk of opportunities.
    - **Monetary value:** Select the field that represents the monetary value, such as **Est. revenue**.
    - **Estimated close date:** Select the field that represents the estimated close date, such as **Est. close date**. 

    >[!NOTE]
    >You can customize the thresholds for risk and importance criteria in the **Advanced** settings. Learn more in [Configure risk and importance criteria](opportunity-research-agent-advanced-settings.md).

## Next step

[Configure knowledge sources.](configure-sqa-knowledge-source.md)

## Related information

[Set up and configure Sales Close Agent - Research.](configure-opportunity-research-agent.md)
