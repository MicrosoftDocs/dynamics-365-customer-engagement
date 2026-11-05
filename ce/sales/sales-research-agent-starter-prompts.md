---
title: Create and manage starter prompts (preview)
description: Create starter prompts from evaluated test questions, organize them for a business function, and attach default blueprints. Learn how to get started.
ms.date: 11/02/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Create and manage starter prompts (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Starter prompts are the ready-made questions users see when they select a business function in Sales Research Agent. Good starter prompts help users get to a useful answer with one selection, and they're the entry point for [default blueprints](sales-research-agent-default-blueprints.md), which give every user the same answer layout.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- You [created a business function](sales-research-agent-business-function-builder-create.md) and have permission to edit it.
- We recommend that you [evaluate the business function](sales-research-agent-business-function-builder-evaluate.md) first, so starter prompts are based on questions you know it answers well.

## Promote a test question to a starter prompt

Evaluation test questions often match the questions users ask. You can promote them directly:

1. Open the business function and select the **Evaluation** tab.
2. In the **Actions** column, select the star next to a question (**Save as starter prompt**). The star fills in to show the question is now a starter prompt.
3. To remove it, select the filled star again (**Already a starter prompt, select to remove**).

:::image type="content" source="media/starter-prompts-evaluation-test-questions.png" alt-text="Screenshot of the Evaluation tab with test questions starred as starter prompts and a tooltip for an existing starter prompt.":::

## Manage starter prompts

Select the **Starter prompts** tab to see every starter prompt for the business function.

:::image type="content" source="media/starter-prompts-tab.png" alt-text="Screenshot of the Starter prompts tab with Create default blueprint buttons and prompts that already have a default blueprint.":::

From this tab you can:

| Action | How |
|---|---|
| Add a starter prompt | Select **Add starter prompt** and enter a title and the prompt text. |
| Edit a starter prompt | Select the edit icon. |
| Change the order | Use the up and down arrows. |
| Delete a starter prompt | Select the delete icon. |
| Create a default blueprint | Select **Create default blueprint**. See [Create a default blueprint](sales-research-agent-default-blueprints-author.md). |
| View, edit, or remove a default blueprint | For starter prompts that have one, select **Show default blueprint**, **Edit blueprint**, or **Remove blueprint**. |
| Link starter prompts into a journey | Select **Link the starter prompts sequentially to provide a step-by-step journey** to present the starter prompts as ordered steps. |

Select **Save** to save your changes to the business function.

## Write good starter prompts

- Use the words your users use. A starter prompt like *Portfolio Pulse* or *Which strategic accounts have the largest whitespace?* is easier to recognize than a technical description.
- Keep the title short and put detail in the prompt text.
- Start with the questions that matter most for consistency, such as portfolio reviews, executive overviews, or pipeline health, and give those a default blueprint.

## Related information

- [Business function overview](sales-research-agent-business-function-builder.md)
- [Default blueprints overview (preview)](sales-research-agent-default-blueprints.md)
- [Create a default blueprint (preview)](sales-research-agent-default-blueprints-author.md)
- [Run a starter prompt with a default blueprint (preview)](sales-research-agent-default-blueprints-use.md)
