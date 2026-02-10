---
title: Manage opportunity risks using AI-generated insights (preview)
description: Learn how action cards are created and shown in the carousel to help sellers address opportunity risks. 
ms.date: 02/10/2026
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: udaykirang
ms.author: udag
ms.reviewer: udag
ai-usage: ai-assisted
---

# Manage opportunity risks using AI-generated insights (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Close Agent - Research generates risk insights and ranks them based on the deal importance and risk criticality. In this article, learn how to view cards, how the agent prioritizes and displays them in the carousel, and how to interact with them to manage your opportunities effectively.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]  

## View AI-generated risk insights action cards

The action cards appear in a carousel on the **Opportunities** list page in Dynamics 365 Sales under the **Suggested actions** section.  

>[!NOTE]
>If the **Suggested actions** section is in collapsed view, select the carousel header to expand and view the action cards.  

The following image shows an example of the action cards carousel.

:::image type="content" source="media/sca-research-action-cards-carousel.png" alt-text="Action cards carousel on the Opportunities list page in Dynamics 365 Sales.":::

The carousel displays the top five action cards at a time. When a higher-priority action card is generated, it replaces the lowest-priority card in the carousel. For example, if a new card has a higher priority than the cards currently in the carousel, the new card is added to the carousel and the lowest-priority card is removed.  
Select **See all** to view all the action cards for all opportunities with detected risks.  
The carousel always displays only one card per opportunity, highlighting the top risk. After you address the top risk, the next highest-priority risk for that opportunity appears in the carousel. This process continues until all risks for the opportunity are resolved.  

Each action card displays the top risk for an opportunity and includes the following information and options:  

- **Basic card details**: The card header highlights the risk detected for an opportunity, the body contains the reason for the risk, and the opportunity name is displayed at the bottom of the card.  
    Select the card to open the [opportunity summary page](copilot-summarize-records.md#opportunity-summary) and view more details about the risk and recommended actions. Other detected risks for the opportunity are also shown on the insights page.  
    Select the opportunity name at the bottom of the card to open the opportunity record.  
- **Perform more tasks**: The more options icon (**...**) provides additional options as described in the following table:

    | Task | Description |
    |------|-------------|
    | Not relevant | If the action isn't relevant to the opportunity, select this option to remove the card from the carousel. |
    | Mark as done | If you took the suggested action, select this option to mark the task as completed. The card is removed from the carousel. |
    | Go to record form | Select this option to go to the opportunity record to view more details and take additional actions. |

- **Provide feedback**: To provide feedback on the relevance of an action card, hover over the card and select the thumbs up or thumbs down icon on the card. If you select thumbs down, you can enter additional feedback in the pop-up window.  

## How action cards are generated

The agent generates action cards by detecting out-of-the-box risks that come from the Sales Close Agent - Research agent. It turns these risks into a prioritized set of action cards for an opportunity.

## How action cards are prioritized

The agent prioritizes action cards by using simple first-release ranking rules as described in the following list:

- **Deal importance first**: The agent groups action cards by the opportunity’s deal-importance value. It always prioritizes cards for the most strategically important deals over those from lower-importance deals, regardless of risk level.
- **Risk criticality within each group**: Within each deal-importance group, the agent orders cards by risk criticality. The most severe or urgent risks appear first, ensuring that high-impact risks are addressed before lower-criticality ones.
- **One card per opportunity**: The carousel shows only the top risk for each opportunity at a time. If an opportunity has multiple risks, only the highest-priority risk appears. Once you address this risk, the next highest-priority risk for that opportunity is displayed.
- **Continuous risk surfacing**: After you resolve a risk, the agent automatically surfaces the next highest-priority risk for the same opportunity, if any remain. This process ensures that all risks are addressed in order of priority.
- **Newest cards first**: If two cards have the same deal importance and risk criticality, the agent displays the most recently created card first. This rule keeps the carousel focused on the latest changes and newly detected risks.

## Related information

[Sales Close Agent overview](sales-close-agent.md)  
[Work on opportunities handled by Sales Close Agent - Research](use-opportunity-research-agent.md)
