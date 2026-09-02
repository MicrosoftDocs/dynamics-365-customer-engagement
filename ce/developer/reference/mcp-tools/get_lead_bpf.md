---
title: Get Lead Business Process Flow
description: Learn how to read the business process flow stages on a Dynamics 365 Sales lead.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get Lead Business Process Flow

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller wants to know a lead's current sales-process stage or which lead-owned stage can be selected next.

## What it does

The assistant reads the active business process flow for a lead: the BPF instance id, current stage, and every stage on the active path with its id, name, category, and participating entity.

The participating entity is important for cross-table flows. In the out-of-the-box Lead to Opportunity Sales Process, Qualify belongs to the lead, while Develop and later stages belong to the opportunity created when the lead is qualified.

## Try prompts like

- What stage is this lead in?
- Show the business process flow for this lead.
- Which stages in this process belong to the lead?

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips

- Use only a returned stage whose `entityLogicalName` is `lead` when updating an unqualified lead.
- Qualify the lead before trying to use an opportunity-owned stage such as Develop or Propose.

## What happens next

Use `update_bpf_stage` with the returned `bpfInstanceId` and an eligible lead stage id, or use `qualify_lead` to create the opportunity before continuing through opportunity-owned stages.

## Does this change data?

**No.** This tool is read-only.

## Prerequisites

This tool requires read access to Dynamics 365 Sales leads and their business process flows.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Lead Business Process Flow |
| Internal tool name | `get_lead_bpf` |
| Purpose | Read a lead's BPF instance, stages, and participating entities. |

## Tool behavior

The tool returns the active BPF instance for the lead and its ordered stages, or an empty instance when there is no active BPF.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool does not modify data. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `leadId` | Resolved lead GUID. | Yes |

## Related tools

| Tool | Relationship |
|---|---|
| [`update_bpf_stage`](update_bpf_stage.md) | Moves the BPF instance to an eligible lead-owned stage. |
| [`qualify_lead`](qualify_lead.md) | Qualifies the lead and can create the opportunity needed for opportunity-owned stages. |
| [`get_opportunity_bpf`](get_opportunity_bpf.md) | Reads the resulting opportunity's active process and stage ids. |

## Routing notes

Use `get_lead_bpf` to inspect a lead's process. Use `get_lead_summary` for lead context, and use `qualify_lead` when the seller asks to qualify or disqualify the lead.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Read-only.
