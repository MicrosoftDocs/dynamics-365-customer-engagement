---
title: Configure selection criteria for Sales Close Agent - Research
description: Add conditions to filter opportunities for the Sales Close Agent - Research to focus on.
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

# Configure selection criteria for Sales Close Agent - Research

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Add conditions to filter opportunities for the Sales Close Agent - Research to focus on. The agent researches only opportunities that meet the specified criteria, so you can prioritize high-value or strategic opportunities.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Research settings page](open-sales-close-agent-research-settings.md).  
1. In the **Guidance** section, select **Selection criteria**.  
    :::image type="content" source="media/sca-selection-criteria-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Research selection criteria settings page.":::
1. In the **Selection criteria** tab, specify the following information:
   - **Segment name:** Enter a name for the segment, such as *Microsoft 365 Opportunities*. Use the segment name to identify the opportunities the agent handles (it doesn't use the segmentation feature in Dynamics 365 Sales).
   - **Description:** Enter a description, such as *Opportunities related to Microsoft 365 products*.
   - **Filter conditions:** Define the filter conditions. The agent handles opportunities that are **open** and match these conditions. For example:
     - Rating equals **Hot**
     - Est. revenue greater than or equal to $100,000
     - Status equals **Open**

1. To have the agent research opportunities you created in the past, select the **Consider opportunities created in the last** checkbox and specify a look-back period in days. Otherwise, the agent only considers opportunities created after it's turned on.

1. Select **Preview** to view a sample of matching opportunities and verify that the agent is picking the right ones.

   > [!NOTE]
   > If you didn't specify a look-back period, the preview is empty because the agent only considers opportunities created after it's turned on.

    A sample list of matched opportunities appears along with total matching opportunities. Review the sample to ensure the criteria are correctly set to capture the right opportunities for the agent to research. You can adjust the filter conditions and preview again until you're satisfied with the results. 

## Next step

[Configure importance and risk assessment.](configure-sales-close-agent-research-opportunity-assessment.md)

## Related information

[Set up and configure Sales Close Agent - Research.](configure-opportunity-research-agent.md)
