---
title: Get information from Copilot
description: Use Copilot to summarize leads, enrich them with related information, and get the latest news about accounts.
ms.date: 10/23/2023
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
ms.reviewer: shujoshi
search.app: salescopilot-docs
---

# Get information from Copilot

Use Copilot to get information about your pipeline, summarize your opportunities and leads, and get the latest news about your accounts.

## Show my pipeline

Copilot can get you the list of the open opportunities that you own, sorted by the estimated close date. 

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Get info** > **Show my pipeline** and press **Enter** to view your opportunity pipeline. 


## Summarize a lead or opportunity

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **Summarize lead** or **Summarize opportunity**, and then press **Enter**. One of the following happens:
    
    - If you have a related record open, Copilot summarizes that record. For example, if you've opened an opportunity and selected **Summarize opportunity**, you'll see the summary of that opportunity.
    
    - If you're in the grid view or the Copilot page, you'll see a list of records that you own. Hover over the record and select **Summarize** to get a summary of the record.
    
To get the list of changes for a specific lead or opportunity, type **/** after the prompt, and then start typing the name of the opportunity or lead.

:::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary.":::


### Would you like to see a different set of fields summarized?

Copilot generates the summary from the first seven fields in the default opportunity or lead view. Other fields may be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution may be the first things you look for in an opportunity. Your administrator can create a view that contains those fields and tell Copilot to [generate the summary based on that view](./enable-setup-copilot.md#configure-record-summary-fields) instead.

Keep in mind that the summary fields are configured at the organization level. Make sure that your entire sales team agrees on the **top seven** fields that are most relevant for your business.


### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts, based on the lead name, phone number, email address, and company name.
- The latest news about the account, curated by Bing.
- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license.

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-an-opportunity-or-a-lead).

    If Copilot finds possible matching records, it lists them after the summary.

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat pane, with a matching account highlighted.":::

1. After Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record. Copilot also lists the fields such as the city, state, phone numbers, and zip/postal code, that can be updated from the connected record.  
1. Select **Update all** to update the lead record with the given values.


## Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated from Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm that they're from authentic sources and are indeed about your customer.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Get info** > **Get latest news for account** and press **Enter**. One of the following happens:
- If you're in the context of an account record, you'll see the list of news articles related to that account.  

- If you aren't, you'll see a list of news articles for the top 10 accounts that you work with, sorted by the revenue associated with the accounts.
    
To get the news articles for a specific account, type **/** and then start typing the name of the account.


### See also

- [Copilot overview](copilot-overview.md)  
- [How Copilot responds when in context and out of context](use-copilot-new.md)