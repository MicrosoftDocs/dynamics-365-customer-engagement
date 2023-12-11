---
title: How Copilot responds when in context and out of context
description: Learn how Copilot responds to questions in context, or when you have a record open, and out of context, when you're viewing Copilot full-screen or in a table.
ms.date: 12/15/2023
ms.topic: conceptual
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

You can open Copilot in the side pane when you have a record like an opportunity or a lead open. We refer to this as using Copilot *in context*, because Copilot knows the specific record you're interested in. That is, when you open Copilot and a record side-by-side, Copilot has the context of the record. When you ask a question that's specific to that record type, Copilot gets the answer that's related to the record in context.

If your request is not about the record in context or you're in the grid view, Copilot doesn't have the exact context. For example, you have a lead record open but you're sending a request to summarize an opportunity. We refer to this as using Copilot *out of context*, because Copilot doesn't know which record you're interested in. In this case, Copilot lists the records that are relevant for your question and you can choose the record you want information about.

The following table lists the responses depending on whether you're using Copilot in context or out of context.

| Prompt | Out of context | In context |
|------------|------------------------------------|-----------------------------------|
| Get info > Show my pipeline | Lists all your open opportunities, sorted by the estimated close date. | Lists all your open opportunities, sorted by the estimated close date. |
| Get info > Summarize lead | Lists all your open leads, sorted by estimated revenue. | Summarizes the lead in context. |
| Get info > Summarize opportunity | Lists all your open opportunities, sorted by estimated revenue. | Summarizes the opportunity in context. |
| Get info > Get latest news for account | Lists all your accounts, sorted by estimated revenue. | Gets the latest news about the account in context. |
| Ask questions > What's new with my sales records | Lists your opportunities, leads, and accounts that were updated in the last seven days. | Lists your opportunities, leads, and accounts that were updated in the last seven days. |
| Ask questions > What's newly assigned to me | Lists the opportunities and leads that were assigned to you in the last 15 days. | Lists the opportunities and leads that were assigned to you in the last 15 days. |
| Ask questions > Get recent changes to a lead | Lists all your open leads that were updated in the last seven days. Hover over a lead and select **Get updates** to view the recent changes to the lead. | Displays the changes to the lead in context. |
| Ask questions > Get recent changes to an opportunity | Lists all your open opportunities that were updated in the last seven days. Hover over an opportunity and select **Get updates** to view the recent changes to the opportunity. | Displays the changes to the opportunity in context. |
| Stay ahead > Prepare for sales appointments | Lists meetings scheduled on your calendar in the next 24 hours. | Lists meetings scheduled on your calendar in the next 24 hours. |
| Stay ahead > Show emails that need follow up | Lists emails that you haven't replied to. | Lists emails that you haven't replied to. |
