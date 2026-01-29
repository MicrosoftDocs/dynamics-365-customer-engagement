---
title: Ask Copilot questions
description: Learn how to use Copilot in Dynamics 365 Sales to summarize sales records, catch up on recent changes, prepare for meetings, and answer sales-related questions.
ms.date: 01/29/2026
ms.update-cycle: 180-days
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

## Prerequisites

Your admin turned on and set up Copilot in your sales app. "Sales app" refers to apps that have lead and opportunity tables and aren't on the [exclusion list](sales-copilot-faq.md#are-there-any-applications-where-copilot-in-dynamics-365-sales-cant-be-used).

<a name="open-copilot"></a>

## Open Copilot in your sales app

Open Copilot in a side pane to view it side-by-side with a record (opportunity or lead) or view summary in full-screen.

[Open the Copilot side pane](#chat-with-copilot-in-a-side-pane) when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings without leaving the current page. You can open the Copilot side pane from any page in your app except the **Copilot** page.

<a name=open-copilot-sidepane></a>

### Chat with Copilot in a side pane

Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the right side of your app.

:::image type="content" source="media/view-prompts.png" alt-text="Screenshot of the prompt guide in the Copilot side pane in Dynamics 365 Sales, with the notebook icon highlighted.":::

## Interact with Copilot

You can interact with Copilot through the side pane in the following ways:

- [Ask a question in natural language](#chat-with-copilot-in-NL) in the Copilot chat box.
- Select one of the suggestions from the card. 
- To get a list of predefined requests, or *prompts*, that Copilot can help you with, select **View Prompts** (notebook icon) above the Copilot chat box. [Learn more about predefined prompts](copilot-prompt-guide.md).

## Turn off Bing search

If Bing search is turned on for your organization, an option to turn it off is displayed at the bottom of the Copilot side pane and Copilot page. Copilot uses Bing search only to provide news about your accounts. If you turn it off, the **Get latest news for accounts** prompt doesn't return any results.

:::image type="content" source="media/bing-consent-seller.png" alt-text="Screenshot of the Copilot side pane in Dynamics 365 Sales, with the Bing consent option highlighted.":::

<a name=chat-with-copilot-in-NL></a>

## Natural language chat

When you chat with Copilot in natural language, Copilot looks for answers in the data stored in Dataverse (the underlying data platform for Dynamics 365) first. If the answer isn't available in Dataverse, Copilot displays a follow-up prompt to search for the answer in SharePoint.

You can ask the following types of questions:

- **Questions about sales data** are straightforward requests for data, such as "What's Contoso's annual revenue?" or "Show me all my opportunities that are closing this month." You can find more examples of the kinds of questions you can ask in [Questions about sales data](faqs-sales-copilot-natural-language.md#questions-about-sales-data).

- **Questions with sales-specific terminology** are based on terms that are specific to sales organizations. You can ask questions about your sales pipeline ("Show my pipeline with deals closing in the next 30 days"), deal cycle ("What's the average deal cycle for my opportunities?"), conversion rates ("What's my lead conversion rate for the last quarter?"), and deal sizes and values ("Display open deals with deal size greater than 10000"). You can find more examples of the kinds of questions you can ask in [Questions with sales-specific terminology](faqs-sales-copilot-natural-language.md#questions-with-sales-specific-terminology).

  If your organization uses different sales terminology or custom fields, reach out to your Dynamics 365 admin to add those terms to the glossary to help Copilot better understand the context of your questions.

For more such questions, see [Questions about sales data](faqs-sales-copilot-natural-language.md#questions-about-sales-data).

- **Questions with sales-specific terminology:** Questions that are based on terms specific to Sales organizations. By default, questions around the following topics are supported:

  - **Conversion rates**. For example, what is my lead conversion rate for the last quarter?

  - **Deal cycle**. For example, what is the average deal cycle for my opportunities?
  - **Pipeline with filters**. For example, show my pipeline with deals closing in next 30 days.
  - **Deal sizes and values**. For example, display open deals with deal size greater than 10000.
  
For a list of sample questions, see [Questions with sales-specific terminology](faqs-sales-copilot-natural-language.md#questions-with-sales-specific-terminology). If your organization uses a different sales terminology or uses custom fields, reach out to your Dynamics 365 admin to [add those terms to the glossary](extend-copilot-chat.md#add-glossary). The glossary helps Copilot understand the context of your questions better.

These questions are first answered using the data stored in Dataverse, which is the underlying data platform for Dynamics 365 Sales. If the answer isn't available in Dataverse, Copilot displays a follow-up prompt to search for the answer in SharePoint.  

You can also access some of these question from the Prompt guide that appears when you select **View Prompts** above the chat box in the Copilot side pane or Copilot page.

## Related information

- [Get information from Copilot](copilot-get-information.md)
- [Ask Copilot about recent changes to your sales records](copilot-ask-questions.md)
- [Stay ahead with Copilot](copilot-stay-ahead.md)
