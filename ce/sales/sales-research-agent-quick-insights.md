---
title: Get quick insights in Sales Research Agent (preview)
description: Learn how Quick Insights provides an initial response while Sales Research Agent generates detailed research.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: concept-article
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Get quick insights in Sales Research Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Quick Insights in Sales Research Agent gives you an initial answer to your sales questions based on your Dynamics 365 Sales data. It surfaces high-level findings while the agent generates a detailed research blueprint, so you can start understanding your sales performance without waiting for the full analysis.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Quick Insights is integrated into your existing research workflow. You don't need to choose a separate mode or stop the detailed research process. Quick insights appear in the following scenarios:

- For the initial question that starts your research.
- For follow-up questions that you ask by using the AI cursor.

## Prerequisites

Your admin must enable the **SalesSpecificQnA** model in your environment. For more information about enabling the model, see [Customize Copilot in Dynamics 365 Sales](extend-copilot-chat.md#add-glossary-and-synonyms-to-help-copilot-understand-your-business-terms).

## How Quick Insights works

When you create a workspace, Sales Research Agent automatically checks whether the **SalesSpecificQnA** model is available in the environment.

If the prerequisite is available, the agent uses the existing semantic model and Dataverse Q&A to retrieve high-level findings from your data. Quick Insights displays these findings first while the regular content-generation flow continues to create the detailed blueprint. This combination gives you an initial answer quickly and more detailed analysis when the blueprint finishes generating.

If the model isn't available, quick insights won't be shown and the agent continues to generate the detailed research blueprint. 

## View Quick Insights

1. In the Sales Hub site map, go to **My Work** > **Sales Research Agent**.
1. Start a new workspace or open an existing workspace.
1. Enter your question, and then select **Generate**.
   Quick Insights displays high-level findings while Sales Research Agent continues generating the detailed blueprint.
   :::image type="content" source="media/quick-insights.png" alt-text="Screen showing Quick Insights in Sales Research Agent workspace with high-level findings":::

You can also activate the AI cursor and ask a follow-up question. Quick Insights provides an initial response while the agent generates the detailed result.

## Related information

- [Sales Research Agent overview](sales-research-agent.md)
- [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)
- [Set up and configure Sales Research Agent](configure-sales-research-agent.md)
- [Frequently asked questions about Sales Research Agent](faqs-sales-research-agent.md)
