---
title: Revise Quote
description: Learn how to revise a Dynamics 365 Sales quote into a new draft revision.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Revise Quote

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller wants a new editable draft version of a quote during negotiation.

## What it does
The assistant revises the selected quote into a new editable draft revision, mirroring the Dynamics 365 Sales **Revise** command. An active quote is closed as *Revised* first and then revised; a closed quote is revised directly. The newly revised draft quote is returned.

## Try prompts like
- Revise this quote so I can update pricing.
- Create a new draft revision of quote QUO-000123.
- Make an editable revision of this active quote.

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- Confirm the exact quote before revising it.
- A draft (never-activated) quote can't be revised—activate it first.
- Use the returned revised quote link or ID for follow-up quote edits.

## What happens next
Continue negotiation work on the revised draft quote.

## Does this change data?
**Yes.** This tool creates a new draft quote revision and updates quote revision state through the Dynamics 365 Sales revise action (closing an active quote as revised when needed).

## Prerequisites
This tool requires read, write, and create access for quotes, plus record access to the quote being revised.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Revise Quote |
| Internal tool name | `revise_quote` |
| Purpose | Revise an active or closed quote into a new draft revision. |

## Tool behavior
The tool reads the quote state, then—for an active quote—closes it as *Revised* via `CloseQuote` and invokes `ReviseQuote`, or—for an already-closed quote—invokes `ReviseQuote` directly. It returns key fields for the revised quote, including ID, revision number, totals, and deep link when available.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool creates/updates quote data. |
| `destructiveHint` | `false` | It does not delete data. |
| `idempotentHint` | `false` | Repeating the call creates another revision. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `quoteId` | Active or closed quote GUID to revise into a new draft revision. | Yes |

## Related tools
| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | Opens a quote record when a generic form view is needed. |

## Routing notes
Use `revise_quote` for quote revision/version work. Use opportunity product tools for opportunity line changes before quote generation.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Creates a revised draft quote and updates quote revision state (may close the source quote as revised).
