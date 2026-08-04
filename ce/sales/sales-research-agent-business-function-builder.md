---
title: Business function overview
description: Learn what Business Function Builder is and how it helps you create business functions for Sales Research Agent.
ms.date: 07/29/2026
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Business functions overview

A business function gives Sales Research Agent the context and instructions it needs for a specific business use case, such as account planning, territory planning, pipeline review, or engagement analysis. Business Function Builder (preview) helps you create that configuration from your data, schema metadata, and optional reference content, so you don't have to author every field manually.

Use Business Function Builder (preview) to:

- Create a business function from a natural-language description of your use case.
- Let the agent discover the relevant tables, columns, and relationships in your data.
- Review, edit, and validate the generated business function.
- Share a validated business function with other users in your organization.

## How business functions work

A business function is a reusable configuration that tells Sales Research Agent how to interpret your organization's data and language for a specific use case. For example, a business function for account planning might include instructions to focus on the top 20 accounts, analyze revenue and product adoption, and consider support tickets and interaction history over the last 12 months. The business function also includes a glossary of terms, table and column hints, and any custom metrics or acronyms that are relevant to your organization.

Business Function Builder generates the full configuration for you from your description and your environment's schema, including the role, business context, data instructions, glossary, and table and column hints. You don't need to know or author these pieces manually. However, you must review the generated content and make any necessary edits so that the business function accurately reflects your organization's data, processes, and terminology.

## Best practices

- Scope each business function to one use case.
- Define custom metrics and acronyms explicitly.
- Add data instructions for custom tables, custom activity data, and nonstandard relationships.
- Validate before sharing.
- Revalidate after schema, business-rule, or prompt changes.

## Related information

- [Sales Research Agent overview](sales-research-agent.md)
- [Create and share business functions with Business Function Builder](sales-research-agent-business-function-builder-create.md)
- [Troubleshoot Business Function Builder](sales-research-agent-business-function-builder-troubleshoot.md)
- [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)
- [Connect the Sales Research Agent to a different data source](sales-research-agent-connect-data.md)
- [Provide context to enhance the Sales Research Agent](sales-research-agent-provide-context.md)
