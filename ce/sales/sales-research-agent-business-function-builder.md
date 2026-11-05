---
title: Business function overview (preview)
description: Learn how business functions, evaluation, starter prompts, and default blueprints work together to provide consistent, grounded answers from Sales Research Agent.
ms.date: 11/02/2026
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Business function overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

A business function tells Sales Research Agent how your organization works for one use case, such as account planning, territory planning, pipeline review, or engagement analysis. It holds the tables and relationships that matter, the business rules and metric definitions the agent follows, and the questions users ask most. Business Function Builder (preview) creates a business function from a plain-language description, your environment's schema, and optional reference content, so you don't have to write it field by field.

Business functions work together with evaluation, starter prompts, and default blueprints. Together, they let you decide how your organization answers its most important questions, and give every user the same answer structure, filled in with their own data.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Why consistency matters

On a large sales team, two people who ask the same question can get answers that use different structures and highlight different metrics. Each answer can be correct and still be hard to compare with the others. Business Function Builder addresses this problem in three layers:

| Layer | What it does | Where you set it up |
|---|---|---|
| **Context** | Teaches the agent your business: which tables matter, how they relate, how metrics such as attainment are calculated, and which statuses count as active. | [Create business functions](sales-research-agent-business-function-builder-create.md) |
| **Evaluation** | Tests the business function against your data before you share it, and shows which answers are wrong and why. | [Evaluate a business function](sales-research-agent-business-function-builder-evaluate.md) |
| **Consistent output** | Turns common questions into starter prompts. A starter prompt can have a default blueprint: a set answer layout that's filled in with each user's data. | [Create and manage starter prompts](sales-research-agent-starter-prompts.md) |

## What you can do with Business Function Builder

- Create a business function from a plain-language description of your use case.
- Let the builder find the relevant tables, columns, and relationships in your data, including custom tables.
- Review and edit the instructions the agent follows.
- Evaluate the business function against your data and refine it based on the results.
- Save test questions as starter prompts that users can run with one selection.
- Create a default blueprint for a starter prompt, and optionally add charts, configure the summary, and add web research.
- [Share the business function](sales-research-agent-business-function-builder-share.md) with other users in your organization.

## Who does what

| Role | What they do |
|---|---|
| **Maker** (sales operations, revenue operations, or an admin who knows your Dynamics 365 data) | Creates the business function, evaluates it, adds starter prompts, authors default blueprints, and shares the business function. |
| **User** (seller, account manager, or sales leader) | Selects a business function and a starter prompt, and gets an answer from their own data. No setup needed. |

## How business functions work

A business function is a reusable set of instructions that tells Sales Research Agent how to read your data and your terms for one use case. For example, an account planning business function might tell the agent to focus on each seller's top 20 accounts, look at revenue and product adoption, and include support cases and interactions from the last 12 months. It also defines your custom metrics, acronyms, and status rules.

Business Function Builder drafts the whole business function from your description and your schema:

- **Instructions:** purpose and scope, business ontology (core entities and roles), business rules and status logic, process map, key metrics and measures, temporal lifecycle, analytics guidance, and data caveats.
- **Tables and columns:** the tables, columns, and relationships the agent uses.
- **Evaluation:** test questions grounded in your schema and data.
- **Starter prompts:** the questions users see when they select the business function.

You don't have to write any of this yourself, but you do need to review it. The instructions are in plain language so you can check that they match your data, processes, and terms before anyone relies on them.

## How business functions, evaluation, and blueprints fit together

1. **Describe.** The maker describes the use case, such as strategic account planning that covers account health, relationships, engagement, and quota against plan. The builder finds the data and drafts the business function.
2. **Evaluate.** The builder generates test questions, runs them against your data, and grades each answer. The maker reviews the failures, gives feedback, and refines the business function.
3. **Add starter prompts.** The maker saves the test questions users ask most as starter prompts.
4. **Create default blueprints.** For a starter prompt, the agent researches the question and drafts an answer layout. The maker can resize blocks, add charts, configure the summary, and add web research.
5. **Share.** The maker [shares the business function](sales-research-agent-business-function-builder-share.md) with a team, a security role, or a business unit.
6. **Run.** A user selects the business function and a starter prompt. The answer follows the authored layout and is generated from that user's data each time they run it.

Sales Research Agent includes built-in business functions and starter prompts. They're built with the same capabilities described in this article, so you can use them as examples.

## Default blueprints aren't static reports

A default blueprint sets the *structure* of an answer: the numbers at the top, the charts that follow, how the summary reads, and any web research. It doesn't store an answer. Each time a user runs the starter prompt, Sales Research Agent generates the numbers, charts, and summary from that user's data, using the business function you evaluated.

## Best practices

- Scope each business function to one use case.
- Define custom metrics and acronyms explicitly.
- Add data instructions for custom tables, custom activity data, and nonstandard relationships.
- Evaluate before you add starter prompts or share the business function.
- Create default blueprints for the starter prompts where a consistent answer matters most, such as portfolio reviews or executive overviews. Not every starter prompt needs one.
- Evaluate again after you change the instructions, the tables, your business rules, or your schema.
- Have a few makers build and share business functions, rather than asking every user to build their own.

## Related information

- [Sales Research Agent overview](sales-research-agent.md)
- [Create business functions with Business Function Builder](sales-research-agent-business-function-builder-create.md)
- [Evaluate a business function](sales-research-agent-business-function-builder-evaluate.md)
- [Create and manage starter prompts](sales-research-agent-starter-prompts.md)
- [Default blueprints overview](sales-research-agent-default-blueprints.md)
- [Share business functions](sales-research-agent-business-function-builder-share.md)
- [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)
- [Connect the Sales Research Agent to a different data source](sales-research-agent-connect-data.md)
- [Provide context to enhance the Sales Research Agent](sales-research-agent-provide-context.md)
