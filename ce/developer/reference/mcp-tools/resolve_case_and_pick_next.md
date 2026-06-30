---
title: Case — Resolve and Pick Next
description: Learn how to resolve a case and pick the next queue item in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case — Resolve and Pick Next

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you finish working on a case and want to close it and immediately start on the next one from the queue, all in one step.

## What it does
The assistant resolves your current case by marking it as **Problem Solved**, and immediately picks the next unassigned case from any queue you have access to. You get both the confirmation that the first case was closed and the details of the newly picked case, including which queue it came from. If no cases remain in the queue, the assistant lets you know.

## Try prompts like
- "Resolve this case and pick the next one"
- "Resolve and go next"
- "Close CAS-01010-A0A0A0 and give me the next case"
- "Done with this one, move to the next"
- "Finish this case and pick another from queue"

## What you see in chat

The assistant shows a text response with two parts: confirmation that the first case was resolved, and the details of the newly picked case (case number, title, priority, source queue). If no queue items remain, the assistant confirms that the queue is empty.

## Helpful tips
- This is the fastest way to move through a queue of cases. It combines two steps into one.
- The case is resolved as "Problem Solved." If you need to add a custom resolution note, use "close case" separately instead.
- If you just want to close a case without picking the next one, say "close this case."
- If you just want to pick a case without closing the current one, say "pick a case from my queue."

> [!TIP]
> Use this in a steady workflow: triage a case, take action, then "resolve and go next" to keep moving through your queue.

## What happens next
After the next case is picked, you can continue with prompts like:

- "Summarize this case"
- "What changed on this case?"
- "What's the SLA status?"
- "What should I do next on this case?"

## Does this change data?

Yes. This tool changes data.**

The first case is resolved in Dynamics 365, and the next case is claimed and assigned to you.

## Prerequisites
This tool requires the following:

- At least one active queue with cases to be configured. The pick-next step silently succeeds by not returning a new case if no queue items are available.

Learn more in [Create and manage queues for unified routing](/dynamics365/customer-service/administer/queues-omnichannel).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case — Resolve and Pick Next |
| Internal tool name | `resolve_case_and_pick_next` |
| Purpose | Resolves the specified case (marks as Problem Solved) and immediately picks the next active, unassigned case from any queue the agent can read, claiming it for the current user |

## Tool behavior
Resolves the specified case (marks as Problem Solved) and immediately picks the next active, unassigned case from any queue the agent can read, claiming it for the current user. Returns both the resolved case ID and the newly picked case details, or a narration if no queue items remain.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data (resolves one case, claims another). |
| `destructiveHint` | `false` | Cases are resolved and claimed, not deleted. |
| `idempotentHint` | `false` | Each call resolves a case and picks a different next case. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. Identifies the case to resolve. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

## Response and UI behavior
### Response type

Text-only

Returns a text response containing: the resolved case ID, the newly picked case details (case number, title, priority, source queue name), or a message indicating no queue items remain. No interactive component is rendered.

## Routing notes
Use `resolve_case_and_pick_next` when:

- The user says "resolve and go next", "resolve this and pick the next one", or similar compound intent
- Queue-based workflows where the agent continuously resolves and picks cases

Don't use `resolve_case_and_pick_next` when:

- **Closing a case without picking the next one** - route to `close_case`
- **Picking a case without resolving the current one** - route to `pick_case_from_queue`

## Related tools
| Tool | Relationship |
|---|---|
| [`close_case`](close_case.md) | Closes a case without picking the next one |
| [`pick_case_from_queue`](pick_case_from_queue.md) | Picks the next case without resolving the current one |
| [`list_case_inbox_workitems`](list_case_inbox_workitems.md) | Shows the agent's assigned cases |
| [`summarize_case`](summarize_case.md) | Opens the newly picked case with an AI summary for triage |

## Data mutation classification
Write / mutation.

Resolves the specified case via CloseIncident and claims the next queue item by assigning worker ID and case ownership.
