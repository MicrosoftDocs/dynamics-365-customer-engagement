---
title: Account organization chart
description: Learn how to use the Account organization chart capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Account organization chart

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to understand contacts, roles, and relationship coverage for a Dynamics 365 account.

## What it does

The assistant maps active contacts for one account and enriches them with job titles, departments, managers, account roles, email or phone fields, and stakeholder connection roles when available.

## Try prompts like

- Map the organization chart for Northpeak Manufacturing.
- Who are the decision makers and influencers at this account?
- Show me the buying center for this account.
- Where do we have relationship gaps in this account?

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous account names before calling tools that require identifiers.
- Use `get_stakeholder` when you only need the connected stakeholder list for an account or opportunity.
- Use `update_stakeholder` when the seller asks to add or change a stakeholder role.

## What happens next

After the response appears, you can continue with prompts like:

- Add this contact as a decision maker.
- Draft a follow-up email to the champion.
- Show account hierarchy.
- Open this contact.

## Does this change data?

**No, map_account_org_chart doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales account, contact, and connection records for the selected environment.

## Tool summary

| Property           | Value                                                                          |
| ------------------ | ------------------------------------------------------------------------------ |
| User-facing name   | Account organization chart                                                              |
| Internal tool name | `map_account_org_chart`                                                        |
| Purpose            | maps account contacts and stakeholder roles for account relationship planning. |

## Tool behavior

The tool reads contacts and connection role data from Dataverse and returns a text-only response with structured content for agent orchestration.

## Annotations

| Annotation        | Value   | Meaning                           |
| ----------------- | ------- | --------------------------------- |
| `readOnlyHint`    | `true`  | This tool doesn't modify data.   |
| `destructiveHint` | Not set | Not applicable.                   |
| `idempotentHint`  | Not set | Not applicable.                   |
| `openWorldHint`   | Not set | Uses default (queries Dataverse). |

## Input concepts

### Account relationship context

| Input       | Description                                                                                                          | Required |
| ----------- | -------------------------------------------------------------------------------------------------------------------- | -------- |
| `accountId` | Resolved account GUID whose contacts and stakeholder roles should be mapped. Resolve names before calling this tool. | Yes      |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

### Response type

Text narrative

The response includes structured content with contact nodes, stakeholder connection roles, count, truncation state, and Dynamics links when available.

### Result limits

The contact and stakeholder-connection reads each return up to 50 rows. When either hits that cap, `truncated` is `true` and the response says the results are incomplete—the account has more contacts or connections than were returned. Stakeholder connections are reconciled against the returned contacts, so every entry in `connections` refers to a contact present in `contacts`.

## Routing notes

Use `map_account_org_chart` when the user asks for an account organization chart, decision makers, influencers, buying center, relationship map, or whitespace in account coverage. Don't use it for account-to-account hierarchy; use `get_account_hierarchy` for parent-child account structure.

## Related tools

| Tool                                                | Relationship                                               |
| --------------------------------------------------- | ---------------------------------------------------------- |
| [`get_account_hierarchy`](get_account_hierarchy.md) | Lists parent-child account hierarchy                       |
| [`get_stakeholder`](get_stakeholder.md)             | Lists connected stakeholders for an account or opportunity |
| [`update_stakeholder`](update_stakeholder.md)       | Adds or updates stakeholder roles                          |

## Data mutation classification

Read-only.
