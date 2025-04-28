---
title: Use Copilot to summarize cases
description: Learn how agents can use Copilot to summarize cases in Customer Service workspace.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 05/02/2025
ms.custom: bap-template 
---

# Summarize cases

[!INCLUDE[cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]


Copilot case summaries help you quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.


## Prerequisites

Your administrator has enabled the [Copilot case summary](/dynamics365/contact-center/administer/copilot-enable-summary) feature.

## View case summary

In Customer Service workspace, navigate to a case to view the case summary card.

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default so that your screen isn't cluttered with information. Select the card to expand the summary. The summary card you see on your case form is based on the case form you are using. Learn more in [Use Copilot case summary in model-driven apps](/power-apps/user/copilot-case-summary).

:::image type="content" source="../media/copilot-case-summary.png" alt-text="Screenshot of a Copilot case summary.":::

You can copy the summary, refresh it, and provide feedback.

> [!NOTE]
> - You can also generate a case summary for cases that are resolved or canceled.
> - A case summary isn't generated if the descriptions added in the source case fields that Copilot uses are less than 38 words in English, without counting spaces.

Alternatively, you can also generate a case summary from the **Ask a question** tab in the Copilot help pane. Learn more in [Summarize cases and ask about case data](/dynamics365/contact-center/use/use-ask-a-question#summarize-cases-and-ask-about-case-data).


## View related record summaries

In the case or custom record summary card, you can view the primary record summary at the top. This summary contains all standard information for the main case or record. Below the primary record summary, you can see a section with the related record summaries. Each related record is displayed using a configured header (such as the record ID or title) along with a detailed summary of its content.
The application automatically displays the two most recent or most relevant related records first, based on the configured prioritization field.

You can do the following:

- Select **Show more related records** to view all related records to load two additional summaries at a time, repeating the process until all related records are displayed.
- Select the record ID or header to open the full record in a new view.
This functionality helps you access all relevant information efficiently, make better decisions, and provide stronger service without having to manually navigate across multiple records.


## Next steps

[Use Copilot to solve customer issues](/dynamics365/contact-center/use/use-copilot-features)
