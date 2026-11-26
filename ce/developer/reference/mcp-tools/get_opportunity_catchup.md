---
title: Opportunity catch-up
description: Learn how to use the Opportunity catch-up capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Opportunity catch-up

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to catch up on recent opportunity context before action.

## What it does

The assistant catches the seller up on recent opportunity context before action and returns a text response with structured content for agent orchestration.

## Try prompts like

- Opportunity catch-up.
- Help me with this sales opportunity.
- Show the relevant sales data.
- Continue this Sales steel-thread workflow.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous record names before calling tools that require identifiers.
- Use related record-view tools when you need to inspect the full Dataverse form.
- Confirm write actions before changing opportunity or sales record data.

## What happens next

After the response appears, you can continue with prompts like:

- Open this opportunity.
- Show customer updates.
- Add a note.
- Draft a follow-up email.

## Does this change data?

**No, get_opportunity_catchup doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales records for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Opportunity catch-up |
| Internal tool name | `get_opportunity_catchup` |
| Purpose | catches the seller up on recent opportunity context before action. |

## Tool behavior

The tool catches the seller up on recent opportunity context before action. It is text-only and returns structured content for the requested Sales operation.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Sales context

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID to catch up on. Resolve names before calling this tool. | Yes |
| `since` | Optional ISO 8601 date-time with an explicit timezone offset (for example, `2026-07-01T00:00:00Z`). Bounds the catch-up to opportunity changes after that instant. When omitted, the catch-up covers the last 7 days. | No |

> [!NOTE]
> When you supply `since`, Dynamics 365 treats it as your last-seen point and phrases the response as changes "since you last logged in" rather than repeating the date. Omit `since` and the response is phrased as "for the last 7 days".

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content from the SalesOpportunityCatchup custom API.

## Routing notes

Use `get_opportunity_catchup` when the user asks for this specific Sales capability. Don't use `get_opportunity_catchup` for support case workflows or unrelated customer-service records.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | Opens the full Dataverse record form |
| [`list_entity_records`](list_entity_records.md) | Finds sales records by entity type |
| [`get_opportunity_summary`](get_opportunity_summary.md) | Provides a stable opportunity brief |

## Data mutation classification

Read-only.
