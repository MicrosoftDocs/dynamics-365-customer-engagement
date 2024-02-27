---
title: Get information from Copilot
description: Learn how to use Copilot in Dynamics 365 Sales to get information about your pipeline, summarize leads and opportunities, and get the latest news about your accounts.
ms.date: 01/19/2024
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Get information from Copilot

Use Copilot to get information about your pipeline, summarize your opportunities and leads, and get the latest news about your accounts.

## Show my pipeline

Copilot can get you the list of open opportunities that are assigned to you, sorted by the estimated close date.

In the Copilot side pane, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::), select **Get info** > **Show my pipeline**, and select Enter.

## Summarize a lead or opportunity

1. In the Copilot side pane, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::), select **Get info** > **Summarize lead** or **Summarize opportunity**, and select Enter.

    - If you have a record open, Copilot summarizes it.
    - If you're in the grid view, Copilot lists the records you own. Hover over a record and select **Summarize**.

1. To get a list of changes for a specific lead or opportunity, type **/** after the prompt, and then start typing the name of the opportunity or lead.

    :::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary.":::

### Would you like to view a summary of different fields?

Copilot generates the summary from a set of predefined fields. Other fields might be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution might be the first things you look for in an opportunity. Work with your Dynamics 365 Sales administrator to [add those fields to the configuration](enable-setup-copilot.md#configure-fields-for-generating-summaries-and-recent-changes-list).

Keep in mind that the summary fields are configured at the organization level. Make sure that your entire sales team agrees on the **top 10** fields that are most relevant for your business.

### Get content recommendations from SharePoint (preview)
 
As a salesperson, you need to be aware of the latest product information, such as product brochures, pricing, sales pitch, and specifications, which are typically stored in SharePoint. You can ask Copilot to get you the list of SharePoint documents related to products in an opportunity.

> [!NOTE]
>- This feature is available only if your administrator has opted in to the [Copilot preview features](copilot-preview-features.md).
>- The documents are only fetched from the SharePoint site associated with your tenant.  

1. [Summarize an opportunity](#summarize-a-lead-or-opportunity).
    After the summary, Copilot displays a follow-up prompt **Get product-related files (preview)**. The prompt is displayed only if the opportunity has products associated with it. 

2. Select **Get product-related files (preview)**. 
   At the moment, this feature can be invoked only by selecting the prompt and not by typing in the Copilot chat. 

    If the opportunity has multiple products, Copilot lists the products.

3. Hover over a product and select **Get files**.

    Copilot displays related Microsoft Word, Excel, PowerPoint, and PDF files for the product. Copilot lists only those files that the user has access to in SharePoint.

    The documents are listed in the ranking order of SharePoint search results.

    :::image type="content" source="media/get-files-from-sharepoint.svg" alt-text="Screenshot of the list of files fetched from SharePoint.":::

### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts, based on the lead name, phone number, email address, and company name
- The latest news about the account, curated by Bing
- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-a-lead-or-opportunity).

    If Copilot finds possible matching records, it lists them after the summary.

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat pane, with a matching account highlighted.":::

1. After Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record.

    Copilot also lists the fields that can be updated with information from the connected record, such as the city, state, phone numbers, and postal code.

1. To update the lead record with the suggested values, select **Update all**.

## Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated by Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm they're from authentic sources and are indeed about your customer.

1. [Open Copilot](use-sales-copilot.md#open-copilot).

1. In the Copilot side pane, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::), select **Get info** > **Get latest news for account**, and select Enter.

    - If you have a record open, Copilot lists the news articles related to that account.
    - If you're in the grid view, Copilot lists news articles for the top 10 accounts you work with, sorted by the revenue associated with them.

1. To get the news articles for a specific account, type **/** and then start typing the name of the account.

### See also

- [Copilot overview](copilot-overview.md)
- [Enable and set up Copilot](enable-setup-copilot.md)
- [Chat with Copilot in natural language (preview)](use-sales-copilot.md#chat-with-copilot-in-natural-language-preview)

