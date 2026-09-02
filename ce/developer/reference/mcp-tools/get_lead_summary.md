---
title: Lead summary
description: Learn how to use the Lead summary capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-sales
ms.custom: mcp-enabled-namespaces=sales
author: ladirohit
ms.author: ladirohit
ms.reviewer: tmanchanda
---

# Lead summary

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to understand a lead before qualification or outreach.

## What it does

The assistant summarizes one Dynamics 365 Sales lead as a concise brief with lead context, source, need, account fit, engagement signals, and next-step context.

## Try prompts like

- Summarize this lead
- Help me understand this lead before I qualify it
- What should I know about this lead?
- Review this lead's context

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Use this tool before `qualify_lead` when the seller asks for lead context or fit.
- Use `get_entity_record` when the seller wants the full Dataverse record instead of a concise brief.

## What happens next

- Qualify this lead
- Disqualify this lead
- Draft a follow-up email
- Open the lead record

## Does this change data?

**No, get_lead_summary does not change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires permission to read leads in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Lead summary |
| Internal tool name | `get_lead_summary` |
| Purpose | Summarize one lead before seller action. |

## Tool behavior

The tool invokes the SalesRecordSummary custom API for the lead record and returns a text-only summary. It doesn't create opportunities, change the lead status, or update ordinary lead fields.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `leadId` | Dataverse GUID of the lead to summarize. Resolve names before calling this tool. | Yes |
| `appId` | Optional model-driven app ID for the SalesRecordSummary custom API. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `get_lead_summary` when the user asks to understand, summarize, review, or prepare to act on a lead. Don't use `get_lead_summary` for qualification or disqualification actions (use `qualify_lead`), full-record opening (use `get_entity_record`), or ordinary field updates (use `update_entity_record`).

## Related tools

| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | Opens the full Dataverse record form. |
| [`list_entity_records`](list_entity_records.md) | Finds leads by entity type. |
| [`qualify_lead`](qualify_lead.md) | Qualifies or disqualifies a lead after seller confirmation. |

## Data mutation classification

Read-only.
