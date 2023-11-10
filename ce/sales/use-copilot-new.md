---
title: How Copilot responds when in context and out of context
description: Learn how to use Copilot to summarize your leads and opportunities records, catch up on updates, prepare for meetings, and enrich your leads with data from different sources.
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

# How Copilot responds when in context and out of context 

You can open Copilot as a side pane, in the context of a record, such as an opportunity or lead, or in a full-screen view. When you open Copilot and a record side-by-side, Copilot has the context of the record. Now, when you ask question specific to that record type, Copilot gets the answer related to the record in context. For example, if you ask Copilot to summarize a lead and you have a lead record open, Copilot summarizes the lead in context. However, if you're on the grid view, Copilot doesn't have the exact context.  

Similarly, when you open Copilot in a full-screen view, it doesn't have the context. Copilot lists the records that are relevant for your question, in this case. For example, if you ask Copilot to summarize a lead, Copilot lists all your open leads, sorted by estimated revenue. You can then choose the lead for which you want information.

The following table lists the prompts that Copilot can help you with.

| **Prompt** | **Copilot page or grid** | **Copilot side pane, in context** |
|------------|------------------------------------|-----------------------------------|
| Get info &gt; Show my pipeline     | Lists all your open opportunities, sorted by the estimated close date                     | Lists all your open opportunities, sorted by the estimated close date   |
| Get info &gt; Summarize lead       | Lists all your open leads, sorted by estimated revenue.          | Summarizes the lead in context.                    |
| Get info &gt; Summarize opportunity                     | Lists all your open opportunity, sorted by estimated revenue. | Summarizes the opportunity in context.             |
| Get info &gt; Get latest news for account               | Lists all your accounts, sorted by estimated revenue. | Gets the latest news about the account in context. |
| Ask questions &gt; What's new with my sales records     | Lists your opportunities, leads, and accounts that have been updated in the last seven days.                   | Lists your opportunities, leads, and accounts that have been updated in the last seven days. |
| Ask questions &gt; What's newly assigned to me          | Lists the opportunities, leads that were assigned to you in the last 15 days | List the opportunities, leads that were assigned to you in the last 15 days |
| Ask questions &gt; Get recent changes to a lead         | Lists all your open leads that have been updated in the last 7 days. Hover over a lead and select Get updates to view the recent changes for the lead.   | Displays the changes to the lead in context.       |
| Ask questions &gt; Get recent changes to an opportunity | Lists all your open opportunities that have been updated in the last 7 days. Hover over an opportunity and select Get updates to view the recent changes for the opportunity. | Displays the changes to the opportunity in context.                     |
| Stay ahead &gt; Prepare for sales appointments          | Lists meetings scheduled on your calendar for the next 24 hours. | Lists the meetings scheduled on your calendar for the next 24 hours.    |
| Stay ahead &gt; Show emails that need follow up         | Lists emails that you haven't replied to.  | Lists emails that you haven't replied to.          |
