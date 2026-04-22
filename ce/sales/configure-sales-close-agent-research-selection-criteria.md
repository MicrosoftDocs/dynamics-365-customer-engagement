---
title: Configure selection criteria for Sales Opportunity Agent
description: Add conditions to filter opportunities for the Sales Opportunity Agent to focus on.
ms.date: 03/30/2026
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

# Configure selection criteria for Sales Opportunity Agent

Add conditions to filter opportunities for the Sales Opportunity Agent to focus on. The agent researches only opportunities that meet the specified criteria, so you can prioritize high-value or strategic opportunities.

**Follow these steps**:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. In the **Guidance** section, select **Selection criteria**.  
    :::image type="content" source="media/sca-selection-criteria-settings-page.png" alt-text="Screenshot of the Sales Opportunity Agent selection criteria settings page.":::
1. In the **Selection criteria** tab, specify the following information:
   - **Segment name:** Enter a name for the segment, such as *Microsoft 365 Opportunities*. Use the segment name to identify the opportunities the agent handles (it doesn't use the segmentation feature in Dynamics 365 Sales).
   - **Description:** Enter a description, such as *Opportunities related to Microsoft 365 products*.
   - **Filter conditions:** Define the filter conditions. The agent handles opportunities that are **open** and match these conditions. For example:
     - Rating equals **Hot**
     - Est. revenue greater than or equal to $100,000
     - Status equals **Open**

1. To have the agent research on opportunities you created in the past, select the **Consider opportunities created in the last** checkbox and specify a look-back period in days. Otherwise, the agent only considers opportunities created after it's turned on.

1. To know your daily processing capacity based on your refresh frequency, see the **Daily refresh limit** section. The capacity might vary based on your region.  

1. Select **Preview** to view a sample of matching opportunities and verify that the agent is picking the right ones.

   > [!NOTE]
   > If you didn't specify a look-back period, the preview is empty because the agent only considers opportunities created after it's turned on.

    A sample list of matched opportunities appears along with total matching opportunities. Review the sample to ensure the criteria are correctly set to capture the right opportunities for the agent to research. You can adjust the filter conditions and preview again until you're satisfied with the results.

## How the agent prioritizes records

Selection criteria help the agent pick the records to research. The agent also prioritizes which records to process first based on factors like opportunity value, estimated close date, and research freshness. This prioritization ensures that the agent researches the most important and relevant opportunities first and surfaces the most effective insights to sellers.

The system scores opportunities based on these factors in the following order of importance:

| Priority order | Factor | What it measures | Higher priority when |
|----------------|--------|------------------|----------------------|
| 1 | Estimated revenue | Deal value relative to other opportunities. | The estimated revenue is higher. |
| 2 | Estimated close date | How soon the deal is expected to close. | The estimated close date is sooner. |
| 3 | Research freshness | How recently the agent researched the opportunity. | The opportunity hasn't been researched recently. |
| 4 | Email activity | Emails received from the last research cycle. | More emails received since the last research cycle. |
| 5 | Predictive score | AI-generated score indicating the likelihood of winning the deal. | The opportunity has a *lower* predicted win rate&mdash;it might need more attention. |
| 6 | Manual refresh request | Whether a seller manually requested the agent to refresh research on the opportunity. | The seller requested a manual refresh. |

Each opportunity receives a score between 0 and 100, with higher scores indicating higher priority. The system recalculates scores for [each research cycle](configure-sales-close-agent-research-refresh-frequency.md), so an opportunity's position in the queue can change as the factors evolve.  
By default, the system gives more weight to research freshness and manual refresh request, reflecting the importance of keeping data current and responding to seller intent. When an opportunity receives multiple manual refresh requests within the same refresh cycle, the agent automatically prioritizes it high regardless of its score on other factors.

To manually refresh an opportunity, go to the opportunity record in research mode and select **Refresh**.

### Considerations for prioritization

The following considerations apply to how the system prioritizes records for research:

- Each research cycle has a fixed processing capacity based on your configured refresh frequency. 
- If more records are eligible than the system can process in a single cycle, it prioritizes and processes only the highest-priority opportunities.
- If your selection criteria exceed the current cycle's capacity, the selection criteria preview shows a warning message.
- Unprocessed records remain eligible and the system can pick them up in subsequent cycles as it recalculates priorities.

## Next step

[Configure refresh frequency](configure-sales-close-agent-research-refresh-frequency.md).

## Related information

[Set up and configure Sales Opportunity Agent](configure-opportunity-research-agent.md).
