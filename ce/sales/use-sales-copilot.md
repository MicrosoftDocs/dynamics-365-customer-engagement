---
title: Use Copilot in Dynamics 365 Sales
description: Learn how to use Copilot to summarize sales records, catch up on recent changes, prepare for meetings, and enrich your leads with data from different sources.
ms.date: 06/13/2024
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Use Copilot in Dynamics 365 Sales

Copilot is an AI assistant that helps you be more productive and efficient in your daily work in Dynamics 365 Sales apps. Copilot can summarize information about your leads and opportunities, help you catch up on recent changes to your records, prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role, such as Salesperson or Sales Manager](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Your admin [turns on and sets up Copilot](enable-setup-copilot.md).

## Open Copilot

You can open Copilot in a [side pane](#open-copilot-in-a-side-pane)&mdash;side-by-side with a record such as an opportunity or a lead&mdash;or in a [full-screen view](#open-copilot-immersive).

### Open Copilot in a side pane

Open the Copilot side pane when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings without leaving the current page.

1. Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the right side of your app. You can open the **Copilot** side pane from any page in your app except for the **Copilot** page.

1. Select a prompt from the suggestion list or select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) to get a list of suggested requests, or *prompts*, that Copilot can help you with. [Learn more about the prompts](#chat-with-copilot).

<a name=open-copilot-immersive></a>

### Open Copilot in full-screen view (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [cc-preview-note-sales](../includes/cc-preview-note-sales.md)]

Open the Copilot page in a full-screen view when you want more space and focus to chat with Copilot and ask questions. 

1. Select **Copilot** in your site map.

   If it isn't there, ask your admin to [turn on Copilot preview features](copilot-preview-features.md#turn-on-all-copilot-preview-features). If you're using a custom app, ask your admin to [add the Copilot page to your app's site map](enable-setup-copilot.md#add-the-copilot-page-site-map-entry-to-custom-sales-app).

2. Select a prompt from the suggestion list or select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) to get a list of suggested requests, or *prompts*, that Copilot can help you with. [Learn more about the prompts](#chat-with-copilot). 

    :::image type="content" source="media/copilot-immersive.svg" alt-text="Screenshot of the Copilot page showing suggested requests, with the Copilot icons in the left and right side panes highlighted.":::

    The following screenshot is an example of how the Copilot full-screen view displays the opportunity pipeline view:

    :::image type="content" source="media\copilot-immersive-pipeline-view.svg" alt-text="Screenshot of the Copilot page showing an opportunity pipeline in a full-screen view.":::

## Chat with Copilot

You can chat with Copilot in natural language or use predefined prompts to get the most out of Copilot.

<a name=chat-with-copilot-in-NL></a>
### Chat with Copilot in natural language

When you chat with Copilot in natural language, you can use the following types of requests:

- **Data-based questions:** Straightforward data requests such as:

  - What's Contoso's annual revenue?

  - Who is the owner of Alpine Ski House?
  - Show me all my opportunities that are closing this month.

These questions are answered using the data stored in Dataverse, which is the underlying data platform for Dynamics 365 Sales. For more such questions, see [Questions about sales data](faqs-sales-copilot-natural-language.md#questions-about-sales-data).

- **Questions with sales-specific terminology:** Questions that are based on terms specific to Sales organizations. Questions around the following topics are supported:

  - **Conversion rates**. For example, what is my lead conversion rate for the last quarter?

  - **Deal cycle**. For example, what is the average deal cycle for my opportunities?
  - **Pipeline with filters**. For example, show my pipeline with deals closing in next 30 days.
  - **Deal sizes and values**. For example, display open deals with deal size greater than 10000.
  
For a list of sample questions, see [Questions with sales-specific terminology](faqs-sales-copilot-natural-language.md#questions-with-sales-specific-terminology)

You can also access some of these question from the Prompt guide that appears when you select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) in the Copilot side pane or Copilot page.

### Chat with Copilot using predefined prompts

Use predefined prompts to get the most out of Copilot. The following table includes some of the predefined prompts that you can use to get information, ask questions, and stay ahead with Copilot. More prompts are added regularly to help you be more productive and efficient in your daily work.

For a list of predefined prompts, see [Copilot prompt guide reference](copilot-prompt-guide.md).

### See also

- [Get information from Copilot](copilot-get-information.md)
- [Ask questions to Copilot](copilot-ask-questions.md)
- [Stay ahead with Copilot](copilot-stay-ahead.md)
