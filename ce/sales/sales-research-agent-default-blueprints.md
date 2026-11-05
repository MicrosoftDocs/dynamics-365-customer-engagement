---
title: Default blueprints overview (preview)
description: Explore how default blueprints keep Sales Research Agent answers consistent across users without storing static results. Learn when to use them.
ms.date: 11/02/2026
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Default blueprints overview (preview)


[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

A *default blueprint* is an authored answer layout attached to a starter prompt. When a user runs the starter prompt, Sales Research Agent answers in that layout: same key numbers at the top, summary, charts in the same order, and outside research, generated from the user's own data.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Why use default blueprints

Without a default blueprint, Sales Research Agent decides the shape of every answer as it goes. That's right for open-ended research. For the questions your organization asks over and over, such as a portfolio review or an executive overview, it means every user gets a differently shaped answer. Each answer might be factually correct, but the answers can't be compared, rolled up, or reviewed the same way.

A default blueprint fixes the shape of the answer, once, for everyone who asks that question.

## What a default blueprint contains

A default blueprint is made of *blocks*:

| Block | What it shows |
|---|---|
| **Summary** | Headline metrics and a written analysis with optional recommendations. You control its tone, length, and which blocks it reads from. |
| **Chart block** | A visualization you describe in plain language. The agent writes the query through the business function. |
| **Web research** | Research from outside your CRM, such as market sentiment or competitor activity, with optional source citations and limits on where it searches. |

You can resize, reorder, and remove blocks, and add new ones. See [Create a default blueprint](sales-research-agent-default-blueprints-author.md).

:::image type="content" source="media/default-blueprint-editor.png" alt-text="Screenshot of a default blueprint in the editor, with key metrics, a written analysis, and charts.":::

## The structure is fixed, the content isn't

A default blueprint isn't a static report and doesn't store results. It stores the structure and the instructions for each block. Every time a user runs the starter prompt:

- Every block is generated fresh from that user's data, at that moment.
- Every query goes through the same business function, so it follows the same rules and definitions you evaluated.
- The summary is rewritten from the current content of the blocks it reads.

## How default blueprints are created

You don't start from a blank page. When you select **Create default blueprint** for a starter prompt, the agent researches the question against your data and drafts a layout, including the metrics, charts, and analysis it thinks answer the question best. You then author the draft. You stay in control: keep what works, change what doesn't, and add what's missing.

> [!NOTE]
> On the Sales Research Agent home page, starter prompts that have a default blueprint are labeled **Uses custom blueprint**.

## Roles for default blueprints

| Role | What they do |
|---|---|
| **Maker** (sales operations, revenue operations, or an admin) | Creates the business function, evaluates it, promotes starter prompts, and authors default blueprints. |
| **User** (seller, account manager, or sales leader) | Selects the business function and starter prompt, and gets the answer in the authored layout. No configuration needed. |

## Related information

- [Business function overview](sales-research-agent-business-function-builder.md)
- [Create and manage starter prompts (preview)](sales-research-agent-starter-prompts.md)
- [Create a default blueprint (preview)](sales-research-agent-default-blueprints-author.md)
- [Run a starter prompt with a default blueprint (preview)](sales-research-agent-default-blueprints-use.md)
