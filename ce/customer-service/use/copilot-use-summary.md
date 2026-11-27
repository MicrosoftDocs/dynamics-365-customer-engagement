---
title: Use Copilot-generated case summaries
description: Learn how representatives can use Copilot-generated case summaries to address and resolve customer issues in Dynamics 365 Customer Service.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 11/26/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Use Copilot-generated case summaries

[!INCLUDE[cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

Copilot case summaries help you quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

## Prerequisites

- Your administrator has enabled the [Copilot case summary](/dynamics365/contact-center/administer/copilot-enable-summary) feature.
- Your administrator has enabled the [Related record summary](../administer/copilot-map-custom-fields.md#include-related-record-summary) feature.

<a name="view-case-summary"></a>

## View a case summary

Open a case in Copilot Service workspace, and select the case summary card to expand it. The card is collapsed by default. Its location depends on the case form, and its paragraph or structured format depends on your administrator's configuration. Learn more in [Use Copilot case summary in model-driven apps](/power-apps/user/copilot-case-summary).

### [Paragraph format](#tab/paragraphformat)

:::image type="content" source="../media/copilot-case-summary.png" alt-text="Screenshot of a paragraph Copilot case summary.":::

### [Structured format](#tab/summaryformat)


:::image type="content" source="../media/case-summary-structured.png" alt-text="Screenshot of a structured Copilot case summary.":::

---

You can copy the summary, refresh it, and provide feedback.

> [!NOTE]
> - You can also generate a case summary for cases that are resolved or canceled.
> - A case summary isn't generated if the descriptions added in the source case fields that Copilot uses are less than 38 words in English, without counting spaces.

You can also generate a case summary from the **Ask a question** tab in the Copilot help pane. Learn more in [Summarize cases and ask about case data](/dynamics365/contact-center/use/use-ask-a-question#summarize-cases-and-ask-about-case-data).


## View related record summaries

If your administrator enables related record summaries, they appear at the top of the case summary card or custom record summary card with the primary record summary.

You can do the following:

- View the related record summary, with the corresponding header such as record ID or title. Copilot displays two related record summaries by default.
- Select **Show more related records** to load two more summaries. Repeat to view more summaries.
- Select the record ID or header to open the full record in a new view.

## Related information

[Manage case and custom record summary](../administer/copilot-map-custom-fields.md)