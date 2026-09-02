---
title: Account hierarchy
description: Learn how to use the Account hierarchy capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Account hierarchy

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to understand child accounts under a Dynamics 365 account.

## What it does

The assistant lists active child accounts under a requested account, including parent relationship, depth, and account planning fields such as industry, revenue, employee count, and city when available.

## Try prompts like

- Show me the account hierarchy for Northpeak Manufacturing.
- Which child accounts sit under this account?
- Map the subsidiaries for this account.
- Show related accounts under this parent account.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous account names before calling tools that require identifiers.
- Use `map_account_org_chart` when you need contacts, decision makers, or stakeholder roles inside one account.
- Use account form tools when you need to inspect or edit account fields.

## What happens next

After the response appears, you can continue with prompts like:

- Map the organization chart for this account.
- Open this child account.
- Summarize this account.
- Show active opportunities for this account.

## Does this change data?

**No, get_account_hierarchy doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales account records for the selected environment.

## Tool summary

| Property           | Value                                                |
| ------------------ | ---------------------------------------------------- |
| User-facing name   | Account hierarchy                                    |
| Internal tool name | `get_account_hierarchy`                              |
| Purpose            | lists child accounts beneath a Dynamics 365 account. |

## Tool behavior

The tool reads account parent-child relationships from Dataverse and returns a text-only response with structured content for agent orchestration.

## Annotations

| Annotation        | Value   | Meaning                           |
| ----------------- | ------- | --------------------------------- |
| `readOnlyHint`    | `true`  | This tool doesn't modify data.   |
| `destructiveHint` | Not set | Not applicable.                   |
| `idempotentHint`  | Not set | Not applicable.                   |
| `openWorldHint`   | Not set | Uses default (queries Dataverse). |

## Input concepts

### Account hierarchy context

| Input       | Description                                                                                           | Required |
| ----------- | ----------------------------------------------------------------------------------------------------- | -------- |
| `accountId` | Resolved account GUID whose child hierarchy should be listed. Resolve names before calling this tool. | Yes      |
| `maxDepth`  | Maximum number of child-account levels to traverse. Defaults to 3; maximum is 5. Use `0` to resolve only the root account without reading any children. | No       |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

### Response type

Text narrative

The response includes structured content with the root account, child-account nodes, depth, count, truncation state, and Dynamics links when available.

### Result limits

Results are bounded so a large account hierarchy can't overload the request:

| Bound | Value |
|---|---|
| Default depth | 3 child-account levels |
| Maximum depth | 5 (use `maxDepth: 0` for the root account only) |
| Child accounts read per parent | 50 |
| Total accounts returned | 200 |

When any bound is reached, `truncated` is `true` and the response says the results are incomplete. Treat a truncated result as a partial view—don't read whitespace or coverage conclusions from it without narrowing the request.

## Routing notes

Use `get_account_hierarchy` when the user asks for account hierarchy, child accounts, subsidiaries, parent-child account structure, or related account planning context. Don't use it for contact organization charts; use `map_account_org_chart` for people and stakeholder roles.

## Related tools

| Tool                                                | Relationship                                           |
| --------------------------------------------------- | ------------------------------------------------------ |
| [`get_account`](get_account.md)                     | Opens the full Dataverse account form                  |
| [`map_account_org_chart`](map_account_org_chart.md) | Maps contacts and stakeholder roles inside one account |
| [`get_account_summary`](get_account_summary.md)     | Provides a concise account brief                       |

## Data mutation classification

Read-only.
