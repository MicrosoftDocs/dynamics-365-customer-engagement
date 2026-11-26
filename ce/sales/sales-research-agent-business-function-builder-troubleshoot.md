---
title: Troubleshoot business functions (preview)
description: Learn how to resolve common issues with Business Function Builder in Sales Research Agent.
ms.date: 07/29/2026
ms.topic: troubleshooting
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Troubleshoot business functions (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## The business function isn't available in the expected environment

Verify that you're signed in to the target environment. With environment routing enabled, a business function created in one environment might not appear in another.

## The builder can't generate a draft

Make sure that:

- You entered a description or referenced at least one table.
- You have access to the Dynamics 365 Sales environment.
- The environment has schema metadata available.

## Evaluation or discovery fails during a long-running operation

Refresh the page, verify that you're still signed in, and retry the operation.

## Engagement analysis doesn't use the expected activity data

Review whether your organization uses activity pointer tables, standard activity tables, or custom activity tables. Add data instructions that describe how the agent should interpret engagement data.

## Related information

- [Business Function Builder overview](sales-research-agent-business-function-builder.md)
- [Create and share business functions with Business Function Builder](sales-research-agent-business-function-builder-create.md)
- [Sales Research Agent overview](sales-research-agent.md)
- [Analyze your sales performance using the Sales Research Agent](use-sales-research-agent.md)
