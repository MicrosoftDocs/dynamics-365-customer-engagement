---
title: Close Case
description: Learn how to use the Close Case capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Close Case

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you resolved a customer's issue and want to close the case with a resolution note.

## What it does
The assistant closes a case by marking it as resolved in Dynamics 365. You provide a brief note explaining how the issue was resolved, and the assistant creates a resolution record on the case. You can optionally provide a subject line for the resolution.

## Try prompts like
- "Close case CAS-01010-A0A0A0 with resolution: password reset completed"
- "Resolve this case - issue was a configuration error"
- "Close this case, the customer confirmed the problem is fixed"
- "Mark this ticket as resolved - applied the hotfix"
- "Close this case with note: duplicate of CAS-01002-X1Y2Z3"

## What you'll see in chat
The assistant confirms the case has been closed with a text response. No interactive component is displayed.

## Helpful tips
- You must include a resolution note that describes how the issue was resolved. The assistant asks for one if you don't provide it.
- You can refer to the case by number (CAS-01010-A0A0A0) or use the case you're currently working with.
- If you want to close the case and immediately start working on the next one from your queue, say "resolve and go next" instead.
- Use "summarize the actions taken on this case" before closing to help you write a good resolution note.

> [!TIP]
> The resolution note becomes part of the case history. Use it to document what worked so other agents can learn from it.

## What happens next
After closing the case, you can continue with prompts like:

- "Pick the next case from my queue"
- "Show my active cases"
- "Show my inbox"

## Does this change data?

Yes. This changes data.**

The case is resolved in Dynamics 365 and a resolution activity record is created.

## Prerequisites
This tool requires the following:

- Customer service representative role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Close Case |
| Internal tool name | `close_case` |
| Purpose | Resolves and closes a support case using the Dataverse CloseIncident action |

## Tool behavior
Resolves and closes a support case using the Dataverse CloseIncident action. Requires a resolution note describing how the issue was resolved. Use this tool for standalone case closure without immediately moving to the next case in the queue.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | The case is resolved, not deleted. |
| `idempotentHint` | `false` | Closing an already-closed case may fail or create a duplicate resolution record. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Resolution details

| Input | Description | Required |
|---|---|---|
| `resolutionNote` | `resolutionNote` (required string) - brief description of how the issue was resolved. `resolutionSubject` (optional string) - subject line for the resolution record, defaults to "Case Resolved". | Varies |

## Response and UI behavior
### Response type

Text-only

Returns a text confirmation that the case was closed. No interactive component is rendered.

## Routing notes
Use `close_case` when:

- The user wants to close or resolve a single case without immediately picking up the next one.
- The user explicitly says "close", "resolve", "mark as resolved".

Don't use `close_case` when:

- **Resolving and immediately picking the next case** - route to `resolve_case_and_pick_next` (combines both operations)
- **Updating a field** (e.g. status reason without resolution) - route to `update_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`resolve_case_and_pick_next`](resolve_case_and_pick_next.md) | Resolves the case AND claims the next one from the queue in a single operation |
| [`update_case`](update_case.md) | Updates fields on a case without closing it |
| [`get_case`](get_case.md) | Opens the case form to review before closing |
| [`summarize_case`](summarize_case.md) | Generates an AI summary to review before closing |
| [`summarize_case_actions`](summarize_case_actions.md) | Lists resolution steps taken - useful for drafting the resolution note |

## Data mutation classification
Write / mutation.

Closes the case using the Dataverse CloseIncident action, creating a resolution activity record. The case state transitions to **Resolved**.
