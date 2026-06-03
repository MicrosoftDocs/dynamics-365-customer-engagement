---
title: Manage opportunity risks and data enrichment using AI-recommended actions (preview)
description: Learn how action cards are created and shown in the carousel to help sellers address opportunity risks and data enrichment. 
ms.date: 06/03/2026
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: udaykirang
ms.author: udag
ms.reviewer: udag
ai-usage: ai-assisted
---

# Manage opportunity risks and data enrichment using AI-recommended actions (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Recommended Actions Agent generates risk insights and ranks them based on the deal importance and risk criticality. In this article, you learn how to view cards, how the agent prioritizes and displays them in the carousel, and how to interact with them to manage your opportunities effectively.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]  

## View AI-recommended risk insights action cards

The action cards appear in a carousel on the **Opportunities** list page in Dynamics 365 Sales under the **Suggested actions** section.  

>[!NOTE]
>If the **Suggested actions** section is in collapsed view, select the carousel header to expand and view the action cards.  

The following image shows an example of the action cards carousel.

:::image type="content" source="media/sca-research-action-cards-carousel.png" alt-text="Action cards carousel on the Opportunities list page in Dynamics 365 Sales.":::

The carousel shows action cards and data enrichment cards. Select **See all** to view action cards for opportunities with detected risks. To view enrichment cards, select a stacked card in the carousel.

## Interact with action cards
 
The Sales Opportunity Agent generates action cards when it detects a risk in an opportunity. The carousel shows prioritized cards first. Each card highlights a specific risk, such as a stalled deal or a disengaged contact. The card explains the risk and recommends actions to mitigate it.
  
The carousel shows one card per opportunity and highlights the top risk. After you address that risk, the next highest priority risk appears in the carousel. This process continues until you resolve all risks for the opportunity.

:::image type="content" source="media/recommended-action-card-details.png" alt-text="Details of an action card showing the risk, reason, and options to interact with the card.":::

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

- **Reason for priority**: Each card includes a reason for why the action is prioritized. At the bottom of the card, you find a brief explanation of the key factors contributing to the card's priority ranking. Hover over the reason to view a detailed breakdown of how the card's priority was determined based on the scoring model dimensions (Urgency, Impact, Confidence, Effort) and the specific signals that influenced each dimension. This information can help you understand why a particular action is recommended and how it can impact your opportunity. 

## Interact with data enrichment cards

When the Data Enrichment Agent detects missing or outdated information in an opportunity, it generates data enrichment cards that appear in the carousel alongside action cards. These cards provide insights about the missing or outdated information and recommend actions to update the opportunity data.

Select stacked cards in the carousel and the Data Enrichment pane opens with details about the data issue and recommended actions to resolve it. 

:::image type="content" source="media/data-enrichment-pane-recommended-actions.png" alt-text="Data enrichment pane in the carousel and the details pane that opens when you select the card."::: 

**Select all** to update the suggested fields directly from the pane. After you update the information, the data enrichment card is removed from the carousel.

Select the **Histoy** tab in the Data Enrichment pane to view a log of all data enrichment actions taken for the opportunity, including past updates and their timestamps. 

To learn more about data enrichment cards, see [Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md).
 
## How action cards are generated

The agent generates action cards by detecting risks that come from the agents. It turns these risks into a prioritized set of action cards for an opportunity.

## How action ranking works

The Recommended Actions Agent ranks actions by applying a consistent scoring and prioritization pipeline across all incoming actions.

### Scoring model (UICE framework)

The scoring engine evaluates each action across four dimensions, with scores ranging from 0 to 10:

- **Urgency** – How time-sensitive or critical the action is
- **Impact** – The potential business value or outcome
- **Confidence** – Reliability of the underlying insight
- **Effort** – Level of effort required to complete the action

The scoring engine generates these scores by using entity data, agent-provided signals, and derived insights.

### Priority score calculation

The final priority score uses a weighted formula:
```
Priority = (Urgency × 0.30)
         + (Impact × 0.35)
         + (Confidence × 0.20)
         − (Effort × 0.15)
         + (Principles × 0.05)
```

- **Impact** and **Urgency** contribute the most to the score
- **Effort** reduces the score
- **Principles** adds a small boost based on business priorities

### Role of signals in scoring

The scoring engine derives UICE values by using:

- **Entity signals** such as deal value, stage, and competitors
- **Agent-provided signals** passed through msdyn_prioritizationdata
- **Derived insights** such as sentiment or deal health

Signal definitions include dimension influence hints that guide how each signal affects urgency, impact, confidence, or effort. 

### Prioritization principles

Each agent maps its actions to one or more prioritization principles (for example, Risk Reduction, Deal Velocity, Revenue Generation).

These principles:

- Represent organizational priorities
- Slightly influence the final score through the Principles weight
- Help align ranking with business objectives

### Ranking and filtering

After scoring:

- Actions are processed with floor and ceiling rules to filter or boost relevance
- All actions are ranked globally across all agents
- The system surfaces only the top-ranked actions in the Recommended Actions carousel

### Default prioritization behavior

By default, prioritization is based on the combined evaluation of the following factors:

1. **Business impact**: Measures the expected value of the action, such as revenue growth, customer retention, or opportunity progression.
1. **Urgency**: Assesses how time-sensitive the action is and whether immediate execution is required.
1. **Risk**: Evaluates the potential risks associated with taking or not taking the action.
1. **Confidence**: Determines how well the action aligns with the current context and how confident the system is in the underlying data and insights.

This prioritization logic is applied consistently across all selected data sources.

## Related information

[Recommended Actions overview](sales-close-agent.md)  
