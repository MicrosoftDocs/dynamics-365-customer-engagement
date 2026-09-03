---
title: Opportunity summary
description: Learn how to use the Opportunity summary capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Opportunity summary

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to summarize one opportunity as a concise deal brief.

## What it does

The assistant summarizes one opportunity as a concise deal brief and returns a text response with structured content for agent orchestration.

## Try prompts like

- Opportunity summary.
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

**No, get_opportunity_summary doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales records for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Opportunity summary |
| Internal tool name | `get_opportunity_summary` |
| Purpose | summarizes one opportunity as a concise deal brief. |

## Tool behavior

The tool summarizes one opportunity as a concise deal brief. It is text-only and returns structured content for the requested Sales operation.

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
| `opportunityId` | Resolved opportunity GUID to summarize. Resolve names before calling this tool. | Yes |
| `appId` | Model-driven app ID for the SalesRecordSummary custom API. Optional—when omitted, the server uses the configured Sales app context and otherwise falls back to the Dataverse default app. Prefer the caller's current app context; don't hardcode Sales Hub. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content for the requested sales operation.

## Routing notes

Use `get_opportunity_summary` when the user asks for this specific Sales capability. Don't use `get_opportunity_summary` for support case workflows or unrelated customer-service records.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | Opens the full Dataverse record form |
| [`list_entity_records`](list_entity_records.md) | Finds sales records by entity type |
| [`get_opportunity_catchup`](get_opportunity_catchup.md) | Provides recent deal context when the seller asks what changed |

## Data mutation classification

Read-only.
