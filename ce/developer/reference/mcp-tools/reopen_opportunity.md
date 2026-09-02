---
title: Reopen opportunity
description: Learn how to use the Reopen opportunity capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Reopen opportunity

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a closed deal becomes active again and the seller wants to continue working it.

## What it does

The assistant returns a closed (won or lost) Dynamics 365 Sales opportunity to the Open state so the seller can keep working it. You provide the opportunity GUID; optionally you can set the open status reason.

## Try prompts like

- Reopen this opportunity.
- The customer is back—reactivate this deal.
- Move this closed opportunity back to open.
- Reopen the deal as on hold.

## What you'll see in chat

The assistant displays a text response confirming that the opportunity was reopened. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Confirm with the seller before reopening a closed deal.
- Provide `statusCode` only when a specific open status (such as On Hold) is needed; otherwise the deal reopens as In Progress.
- Resolve the opportunity to its GUID before calling this tool.

## What happens next

- Summarize this opportunity.
- Add or update products on the deal.
- Draft a re-engagement email.
- Update the sales stage.

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires permission to write the opportunity in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Reopen opportunity |
| Internal tool name | `reopen_opportunity` |
| Purpose | Return a closed opportunity to the Open state. |

## Tool behavior

The tool sets the opportunity's state back to Open with the requested open status reason, defaulting to In Progress. It doesn't change products, revenue, or other opportunity fields.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | This tool doesn't perform destructive changes. |
| `idempotentHint` | `true` | Reopening an already-open opportunity leaves it open. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Opportunity

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Dataverse GUID of the closed opportunity to reopen. | Yes |
| `statusCode` | Optional open status reason (for example, 1 for In Progress, 2 for On Hold). Defaults to In Progress. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `reopen_opportunity` when the user wants to reactivate a closed deal. Don't use `reopen_opportunity` to close a deal or to update non-status fields (use `update_entity_record`).

## Related tools

| Tool | Relationship |
|---|---|
| [`get_opportunity_summary`](get_opportunity_summary.md) | Reviews the deal before or after reopening. |
| [`update_entity_record`](update_entity_record.md) | Updates other opportunity fields. |
| [`update_bpf_stage`](update_bpf_stage.md) | Moves the reopened deal to the right sales stage. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it returns the opportunity to the Open state. Repeating the same reopen is idempotent.
