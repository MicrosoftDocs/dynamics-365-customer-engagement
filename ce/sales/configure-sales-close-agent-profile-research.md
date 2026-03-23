---
title: Configure the agent profile for Sales Opportunity Agent (preview)
description: Define the agent information, email signature, disclaimer, and other terms to set the context for the Sales Opportunity Agent.
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

# Configure the agent profile for Sales Opportunity Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define the agent information such as the name and the language to set the context for the Sales Opportunity Agent.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. Under the **General** settings section, select **Agent profile**.  
    :::image type="content" source="media/sca-research-agent-profile-settings.png" alt-text="Screenshot of the Sales Opportunity Agent agent profile settings page.":::  
1. In the **Agent profile** page, enter the following information:  

    | Field name | Description |
    |------------|-------------|
    | **Agent name** | Enter a meaningful name for the agent. |
    | **Agent language** | Enter the language the agent uses for communication. The agent uses this language to generate research insights. The available languages depend on the language packs installed in your environment through the Power Platform admin center. [What happens when the agent's language is different from user's preferred language?](opportunity-research-agent-faqs.md#agent-language-difference). |

## Next step

[Configure company info.](configure-sales-close-agent-research-company-info.md)

## Related information

[Set up and configure the Sales Opportunity Agent (preview).](configure-opportunity-research-agent.md)