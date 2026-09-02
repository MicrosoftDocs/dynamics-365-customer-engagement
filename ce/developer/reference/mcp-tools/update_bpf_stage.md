---
title: Update business process flow stage
description: Learn how to use the Update business process flow stage capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Update business process flow stage

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller wants to advance a record through its business process flow, such as moving an opportunity to the next sales stage.

## What it does

The assistant sets the active stage on a record's business process flow instance. You provide the business process flow entity logical name, the BPF instance record GUID, and the target stage GUID. The target stage is validated against the instance's process, and the traversal history is derived server-side.

## Try prompts like

- Move this opportunity to the Propose stage.
- Advance the deal to the next sales stage.
- Set the business process flow stage.
- Move this lead to Qualify.

## What you'll see in chat

The assistant displays a text response confirming that the stage was updated. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- For an opportunity, resolve the business process flow instance and target stage GUIDs with [`get_opportunity_bpf`](get_opportunity_bpf.md).
- For a lead, use [`get_lead_bpf`](get_lead_bpf.md), and select only a stage whose participating entity is `lead`. In the out-of-the-box flow, Develop and later stages belong to the opportunity created by lead qualification.
- Confirm the target stage with the seller before moving the record.
- The target stage must belong to the instance's process; the ordered list of visited stages is recorded automatically.

## What happens next

- Summarize this opportunity.
- Add products to the deal.
- Draft a next-step email.
- Review the activity timeline for this deal.

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires permission to write the business process flow instance record in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Update business process flow stage |
| Internal tool name | `update_bpf_stage` |
| Purpose | Set the active stage on a record's business process flow. |

## Tool behavior

The tool updates the active stage lookup on the specified business process flow instance and records a server-derived traversal history (built from the instance's current stage and existing path plus the validated target). It doesn't move the underlying record's other fields or validate stage-entry business rules beyond what Dataverse enforces.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | This tool doesn't perform destructive changes. |
| `idempotentHint` | `true` | Setting the same active stage again leaves the same stage. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Business process flow

| Input | Description | Required |
|---|---|---|
| `bpfEntityLogicalName` | Logical name of the business process flow entity, such as `opportunitysalesprocess` or `leadtoopportunitysalesprocess`. | Yes |
| `bpfInstanceId` | Dataverse GUID of the active business process flow instance record. | Yes |
| `targetStageId` | Dataverse GUID of the process stage to make active. Must belong to the instance's process. | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `update_bpf_stage` when the user wants to move a record through its business process flow. Don't use `update_bpf_stage` to update ordinary fields (use `update_entity_record`) or to close or reopen a deal.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_opportunity_bpf`](get_opportunity_bpf.md) | Resolves an opportunity's active business process flow instance and its stage GUIDs — the preferred way to obtain `bpfInstanceId` and `targetStageId` for an opportunity. |
| [`get_lead_bpf`](get_lead_bpf.md) | Resolves a lead's active BPF instance and identifies which stages participate in the lead versus the resulting opportunity. |
| [`get_entity_record`](get_entity_record.md) | Reads the BPF instance and stage records to resolve GUIDs for record types other than opportunity. |
| [`list_entity_records`](list_entity_records.md) | Finds the business process flow instance for a record. |
| [`update_entity_record`](update_entity_record.md) | Updates non-stage fields on the record. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it sets the active stage on a business process flow instance. Repeating the same stage update is idempotent.
