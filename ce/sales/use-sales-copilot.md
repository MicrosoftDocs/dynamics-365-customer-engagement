---
title: Ask Copilot questions
description: Learn how to use Copilot in Dynamics 365 Sales to summarize sales records, catch up on recent changes, prepare for meetings, and answer sales-related questions.
ms.date: 01/28/2025
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
 - ignite-2024
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Ask Copilot questions

Copilot in Dynamics 365 Sales can summarize information about your leads and opportunities, help you catch up on recent changes to your records, prepare for meetings, read the latest news about your accounts, and enrich your leads with information from other sources. You can chat with Copilot in natural language or use predefined prompts to ask questions.

## License and role requirements

| Requirement type | You must have |
|------------------|---------------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role, such as Salesperson or Sales Manager](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Your admin turned on and set up Copilot in your sales app. "Sales app" refers to apps that have lead and opportunity tables and aren't on the [exclusion list](sales-copilot-faq.md#are-there-any-applications-where-copilot-in-dynamics-365-sales-cant-be-used).

## Open Copilot in your sales app

You can open Copilot in a side pane to view it side-by-side with a record such as an opportunity or a lead, or in an immersive, full-screen view.

[Open the Copilot side pane](#chat-with-copilot-in-a-side-pane) when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings without leaving the current page. You can open the Copilot side pane from any page in your app except the **Copilot** page.

[Open the Copilot page in a full-screen view](#chat-with-copilot-in-full-screen-view-preview) when you want more space to focus on your chat with Copilot.

<a name=open-copilot-sidepane></a>

### Chat with Copilot in a side pane

Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the right side of your app.

:::image type="content" source="media/view-prompts.png" alt-text="Screenshot of the prompt guide in the Copilot side pane in Dynamics 365 Sales, with the notebook icon highlighted.":::

<a name=open-copilot-immersive></a>

### Chat with Copilot in full-screen view (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Select **Copilot** in your app's site map.

If Copilot isn't there, ask your admin to turn on Copilot preview features. If you're using a custom app, ask your admin to add the Copilot page to your app's site map.

:::image type="content" source="media/copilot-immersive.png" alt-text="Screenshot of the Copilot page in Dynamics 365 Sales showing suggested requests, with the Copilot icons in the left and right side panes highlighted.":::

## Interact with Copilot

Whether you're using Copilot in a side pane or in full-screen view, you can interact with it in the following ways:

- [Ask a question in natural language](#chat-with-copilot-in-NL) in the Copilot chat box.
- Select one of the suggestions.
- To get a list of predefined requests, or *prompts*, that Copilot can help you with, select the notebook icon (Copilot side pane) or **View Prompts** (full-screen view) above the Copilot chat box. [Learn more about predefined prompts](copilot-prompt-guide.md).

## Turn off Bing search

If Bing search is turned on for your organization, an option to turn it off is displayed at the bottom of the Copilot side pane and Copilot page. Copilot uses Bing search only to provide news about your accounts. If you turn it off, the **Get latest news for accounts** prompt doesn't return any results.

<a name=chat-with-copilot-in-NL></a>

## Natural language chat

When you chat with Copilot in natural language, Copilot looks for answers in the data stored in Dataverse (the underlying data platform for Dynamics 365) first. If the answer isn't available in Dataverse, Copilot displays a follow-up prompt to search for the answer in SharePoint.

You can ask the following types of questions:

- **Questions about sales data** are straightforward requests for data, such as "What's Contoso's annual revenue?" or "Show me all my opportunities that are closing this month." You can find more examples of the kinds of questions you can ask in [Questions about sales data](faqs-sales-copilot-natural-language.md#questions-about-sales-data).

- **Questions with sales-specific terminology** are based on terms that are specific to sales organizations. You can ask questions about your sales pipeline ("Show my pipeline with deals closing in the next 30 days"), deal cycle ("What's the average deal cycle for my opportunities?"), conversion rates ("What's my lead conversion rate for the last quarter?"), and deal sizes and values ("Display open deals with deal size greater than 10000"). You can find more examples of the kinds of questions you can ask in [Questions with sales-specific terminology](faqs-sales-copilot-natural-language.md#questions-with-sales-specific-terminology).

  If your organization uses different sales terminology or custom fields, reach out to your Dynamics 365 admin to add those terms to the glossary to help Copilot better understand the context of your questions.

Some of these questions are also available as suggestions or in the list of predefined prompts that appears when you select the notebook icon (Copilot side pane) or **View Prompts** (full-screen view) above the chat box.

## Related information

- [Get information from Copilot](copilot-get-information.md)
- [Ask Copilot about recent changes to your sales records](copilot-ask-questions.md)
- [Stay ahead with Copilot](copilot-stay-ahead.md)
