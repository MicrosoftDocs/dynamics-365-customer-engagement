---
title: Get opportunity business process flow
description: Learn how to read the business process flow stages on a Dynamics 365 Sales opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get opportunity business process flow

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller wants to know the current sales-process stage, or before moving the deal to a new stage.

## What it does
The assistant reads the active business process flow for an opportunity — the BPF instance id, the current stage, and every stage with its id, name, category, and participating entity. It handles both the out-of-the-box Opportunity Sales Process and opportunities running a custom business process flow, and reports which business process flow entity holds the active instance so the stage can then be advanced.

## Try prompts like
- What stage is this opportunity in?
- Show the sales process stages for this deal.
- What are the next stages I can move this opportunity to?

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- The returned stage ids and BPF instance id are what `update_bpf_stage` needs to move the deal forward.

## What happens next
Use `update_bpf_stage` with the returned `bpfInstanceId` and a stage id to advance the opportunity.

## Does this change data?
**No.** This tool is read-only.

## Prerequisites
This tool requires read access to Dynamics 365 Sales opportunities and their business process flows.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Get Opportunity Business Process Flow |
| Internal tool name | `get_opportunity_bpf` |
| Purpose | Read an opportunity's BPF instance and stages. |

## Tool behavior
The tool returns the active BPF instance for the opportunity and its ordered stages, or an empty instance when there is no active BPF.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool does not modify data. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID. | Yes |

## Related tools
| Tool | Relationship |
|---|---|
| [`update_bpf_stage`](update_bpf_stage.md) | Advances the opportunity using the returned ids. |

## Routing notes
Use `get_opportunity_bpf` to read the current stage and resolve stage ids, then `update_bpf_stage` to move the opportunity.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Read-only.
