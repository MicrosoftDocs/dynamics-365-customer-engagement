---
title: Case — Pick from Queue
description: Learn how to pick the next available case from a queue in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case — Pick from Queue

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you're ready to start working on a new case and want the assistant to grab the next one from the queue for you.

## What it does
The assistant picks the next unassigned case from any queue you have access to, including public queues, private queues you're a member of, and your personal default queue. The case is claimed and assigned to you. The assistant tells you the case details and which queue it came from.

## Try prompts like
- "Give me a case to start"
- "Pick a case from my queue"
- "Go next"
- "What should I work on next?"
- "Get me the next case"
- "Pick one from the queue"

## What you see in chat

The assistant shows the case that was picked, including the case number, title, priority, and which queue it came from. This is a text response.

## Helpful tips
- You don't need to specify which queue. The assistant checks all queues you have access to.
- If no unassigned cases are available, the assistant lets you know.
- After picking a case, you can ask for a summary to start triaging it.
- If you want to see your already-assigned cases instead, say "show my inbox" or "show my work items."

> [!TIP]
> After picking a case, say "summarize this case" to get a quick overview before you start working on it.

## What happens next
After picking a case, you can continue with prompts like:

- "Summarize this case"
- "What changed on this case since yesterday?"
- "What's the SLA status?"
- "Draft a reply to the customer"

## Does this change data?

Yes. This changes data.

The case is claimed and assigned to you in Dynamics 365. The queue item is updated with your worker ID.

## Prerequisites
This tool requires the following:

- At least one active queue with cases

Learn more in [Create and manage queues for unified routing](/dynamics365/customer-service/administer/queues-omnichannel).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case — Pick from Queue |
| Internal tool name | `pick_case_from_queue` |
| Purpose | Picks the next unassigned case from any queue the agent can access, including public queues, private queues the agent is a member of, and the agent's personal default queue |

## Tool behavior
Picks the next unassigned case from any queue the agent can access, including public queues, private queues the agent is a member of, and the agent's personal default queue. Claims the case by assigning the worker ID and ownership, and returns the case details along with the source queue name.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data (claims a case). |
| `destructiveHint` | `false` | The case is claimed, not deleted. |
| `idempotentHint` | `false` | Each call may pick a different case from the queue. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
### Response type

Text-only

Returns a text response with the claimed case details (case number, title, priority, source queue name). No interactive component is rendered.

## Routing notes
Use `pick_case_from_queue` when:

- The user says "go next", "give me a case", "pick a case from my queue", "what should I work on next"
- The user wants to claim a new case from the queue without specifying a particular case

Don't use `pick_case_from_queue` when:

- **Listing cases by criteria** - route to `list_cases`
- **Viewing already-assigned cases** ("my cases", "my work items") - route to `list_case_inbox_workitems`
- **Resolving a case AND picking the next** - route to `resolve_case_and_pick_next`

## Related tools
| Tool | Relationship |
|---|---|
| [`resolve_case_and_pick_next`](resolve_case_and_pick_next.md) | Resolves the current case and picks the next one in a single operation |
| [`list_case_inbox_workitems`](list_case_inbox_workitems.md) | Shows the agent's personal inbox of already-assigned cases |
| [`list_cases`](list_cases.md) | Lists and filters cases by criteria |
| [`summarize_case`](summarize_case.md) | Opens the picked case with an AI summary for triage |

## Data mutation classification
Write / mutation.

Claims a queue item by assigning the worker ID and case ownership in Dataverse. The case moves from unassigned to assigned.
