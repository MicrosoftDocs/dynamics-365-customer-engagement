---
title: Manage opportunities with action cards (preview)
description: Learn how action cards are created and shown in the carousel to help sellers address opportunity risks. 
ms.date: 02/09/2026
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: udaykirang
ms.author: udag
ms.reviewer: udag
ai-usage: ai-assisted
---

# Manage opportunities with action cards (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Learn how action cards are created and shown in the carousel to help sellers address opportunity risks. Understand how the cards are prioritized, displayed in the carousel, and how you can interact with them to manage your opportunities effectively.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]  

## Open and understand action cards

The action cards appear in a carousel on the **Opportunities** list page in Dynamics 365 Sales under the **Suggested actions** section. The following image shows an example of the action cards carousel.

:::image type="content" source="media/sca-research-action-cards-carousel.png" alt-text="Action cards carousel on the Opportunities list page in Dynamics 365 Sales.":::

The carousel displays the top five action cards at a time. When a higher-priority action card is generated, it appears first in the carousel.  
Select **Show all** to open the carousel and view all the action cards in a view for all opportunities that have risks detected.  
At any given time, the carousel displays only one card per opportunity with top risk. When you resolve the top risk, the next card appears in the order of priority of risks for that opportunity. This order appears because the opportunity isn't risk-free.  

>[!NOTE]
>If the **Suggested actions** section is in collapsed view, select the carousel header to expand and view the action cards.  

Each card displays top risk for each opportunity with the following information and options:  

- **Basic card details**: The card header highlights a risk detected for an opportunity, the body contains the reason for the risk, and the name of the opportunity is displayed at the bottom of the card.  
    When you select the card, [the opportunity summary page](copilot-summarize-records.md#opportunity-summary) opens with more details about the risk and recommended actions to mitigate the risk. Additionally, other risks that are detected for the opportunity are also displayed on the insights page.  
    When you select the name of the opportunity at the bottom of the card, the opportunity record opens.  
- **Perform more tasks**: The more options icon (**...**) provides additional options as described in the following table:

    | Task | Description |
    |------|-------------|
    | Not relevant | If the action card is irrelevant and doesn't apply to the opportunity, select this option to remove the card from the carousel. |
    | Mark as done | If you address the risk highlighted on the card, select this option to close the card as task complete. The card is removed from the carousel. |
    | Go to record form | Select this option to go to the opportunity record to view more details and take additional actions. |

- **Provide feedback**: You can provide feedback on the relevance of the action card by selecting either the thumbs up or thumbs down icon on the card. Hover over card and select the icon to provide feedback. If you dislike the card, you can provide additional feedback in the pop-up window.  

## How action cards are generated

The agent generates action cards by detecting out-of-the-box risks that come from the Sales Close Agent - Research agent. It turns these risks into [a prioritized set of action cards](#how-action-cards-are-prioritized) for an opportunity.

## How action cards are prioritized

The agent prioritizes action cards by using simple first-release ranking rules as described in the following list:

- The agent groups all action cards into tiers based on the opportunity’s deal-importance value before doing any finer sorting. This grouping ensures that cards tied to the most strategically important deals are always considered ahead of cards from lower-importance deals, even if the lower-importance deals have moderately high risks.  
- Within a given deal-importance bucket, the agent places all cards in the same deal-priority tier, so the next ranking criterion is risk criticality. In practice, that means the system orders cards from most severe or urgent risk to least, using the criticality levels defined in the agent. As a result, you see the highest-impact risks first for their most important deals, while lower-criticality risks are shown later within the same bucket.
- **One card per opportunity (top risk only)**. The carousel avoids displaying multiple alerts from the same opportunity at once. So, even if an opportunity has several detected risks, the agent shows only the single highest-priority risk for that opportunity as the current action card, while the other risks are queued. Once you mitigate the top risk, the next highest-priority remaining risk (if any) surfaces as a new card for that same opportunity.  
- **After mitigation, move to next risk**. After you resolve the current (top) risk, the agent doesn't stop to check whether the same opportunity still has other open risks. If the opportunity does, the next highest-priority remaining risk becomes the new active candidate, is re-ranked against other opportunities’ cards, and can then show up in the carousel as a new card.
- When two action cards have the same priority based on the main rules (same deal-importance bucket and similar risk criticality), the agent uses creation time to decide the order. In that case, the newer card (created more recently) is shown first, so the carousel stays focused on the latest changes and newly detected risks.

## Related information

[Sales Close Agent overview](sales-close-agent.md)  
[Work on opportunities handled by Sales Close Agent - Research](use-opportunity-research-agent.md)
