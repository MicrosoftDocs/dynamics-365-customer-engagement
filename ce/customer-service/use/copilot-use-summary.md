---
title: Use Copilot-generated case summaries
description: Learn how representatives can use Copilot-generated case summaries to address and resolve customer issues in Dynamics 365 Customer Service.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/14/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
---

# Use Copilot generated case summary

[!INCLUDE[cc-feature-availability-cs-only](../../includes/cc-feature-availability-cs-only.md)]

Copilot case summaries help you quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

## Prerequisites

- Your administrator has enabled the [Copilot case summary](/dynamics365/contact-center/administer/copilot-enable-summary) feature.
- Your administrator has enabled the [Related record summary](../administer/copilot-map-custom-fields.md#include-related-record-summary) feature.

## View case summary

In Copilot Service workspace, navigate to a case to view the case summary card.

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default so that your screen isn't cluttered with information. Select the card to expand the summary. The placement of the summary card you see is based on the case form you are using. Learn more in [Use Copilot case summary in model-driven apps](/power-apps/user/copilot-case-summary). Based on the administrator's configuration, the case summary is displayed in a paragraph format or as a structured format.

### [Paragraph format](#tab/paragraphformat)

:::image type="content" source="../media/copilot-case-summary.png" alt-text="Screenshot of a paragraph Copilot case summary.":::

### [Structured format](#tab/summaryformat)


:::image type="content" source="../media/case-summary-structured.png" alt-text="Screenshot of a paragraph Copilot case summary.":::

---

You can copy the summary, refresh it, and provide feedback.

> [!NOTE]
> - You can also generate a case summary for cases that are resolved or canceled.
> - A case summary isn't generated if the descriptions added in the source case fields that Copilot uses are less than 38 words in English, without counting spaces.

Alternatively, you can also generate a case summary from the **Ask a question** tab in the Copilot help pane. Learn more in [Summarize cases and ask about case data](/dynamics365/contact-center/use/use-ask-a-question#summarize-cases-and-ask-about-case-data).


## View related record summaries

If your administrator has enabled the related record summary, then the case summary card or custom record summary card displays the related record summaries at the top with the primary record summary.

You can do the following:

- View the related record summary, with the corresponding header such as record ID or title. Copilot displays two related record summaries by default.
- Select **Show more related records** to view all related records to load two additional summaries at a time, repeating the process until all related records are displayed.
- Select the record ID or header to open the full record in a new view.

### Related information

[Manage case and custom record summary](../administer/copilot-map-custom-fields.md)