---
title: Reassign Case
description: Learn how to use the Reassign Case capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Reassign Case

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to transfer a case to a different person, team, or queue with a handover note that explains why.

## What it does
The assistant reassigns a case to a different user, team, or queue. A handover note with your transfer reason is posted to the case timeline, so the next owner has context on why the case was transferred. You can identify the target by name, email address, or by saying "me" to assign it to yourself.

## Try prompts like
- "Reassign CAS-01010-A0A0A0 to Alex because they handle billing issues"
- "Transfer this case to the Tier 2 team - needs escalation"
- "Route this case to the billing queue"
- "Give this case to me"
- "Hand off this case to sarah@contoso.com - she has the domain expertise"
- "Reassign this to the support queue because I'm going on leave"

## What you see in chat

The assistant confirms the reassignment with a text response, including who the case was reassigned to and the reason. No interactive component displays.

## Helpful tips
- Always include a reason for the transfer. The assistant asks for one if you don't provide it. This becomes a note on the case timeline.
- You can identify the target by display name, email address, or "me" for yourself.
- If the assistant finds multiple people with the same name, it shows you the options and asks you to pick one.
- You can reassign to a user, a team, or a queue.

> [!TIP]
> A clear handover note saves the next agent time. Include what you already tried and what still needs to be done.

## What happens next
After reassigning, you can continue with prompts like:

- "Show my active cases"
- "Pick the next case from my queue"
- "Show my inbox"

## Does this change data?

Yes. This changes data.

The case ownership is updated in Dynamics 365, and a handover note is posted to the case timeline.

## Prerequisites
This tool requires the following:

- User must have the case reassign privilege.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Reassign Case |
| Internal tool name | `reassign_case` |
| Purpose | Reassigns a support case to a different user, team, or queue |

## Tool behavior
Reassigns a support case to a different user, team, or queue. Posts a handover note with the transfer reason to the case timeline, providing context for the next owner. The target can be specified by GUID, email address, display name, or "me" for the current user.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | The case is reassigned, not deleted. |
| `idempotentHint` | `true` | Reassigning to the same target produces the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Target

| Input | Description | Required |
|---|---|---|
| `targetType`, `user`, `team`, `queue`, `targetId` | `targetType` (required enum: `user`, `team`, `queue`) and `targetId` (required string). The `targetId` accepts a GUID, "me" (current user, only for `targetType: user`), an email address, or a display name. If multiple matches are found, the tool returns candidates for the user to pick. `targetName` is optional and used for narration. | Varies |

### Handover context

| Input | Description | Required |
|---|---|---|
| `reason` | `reason` (required string) - the transfer reason, which is posted as a handover note to the case timeline. | Yes |

## Response and UI behavior
### Response type

Text-only

Returns a text confirmation of the reassignment including the target name and reason. No interactive component is rendered.

## Routing notes
Use `reassign_case` when:

- The user says "reassign to X", "give this to Y", "route this case", "transfer this case"
- Ownership needs to change from one user/team/queue to another

Don't use `reassign_case` when:

- **Updating case fields** (priority, title, description) - route to `update_case`
- **Closing a case** - route to `close_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`update_case`](update_case.md) | Updates fields on a case without changing ownership |
| [`get_case`](get_case.md) | Opens the case form to review before reassigning |
| [`close_case`](close_case.md) | Resolves and closes a case |
| [`list_cases`](list_cases.md) | Lists cases to find the one to reassign |
| [`summarize_case`](summarize_case.md) | Generates an AI summary for context before reassigning |

## Data mutation classification
Write / mutation.

Updates the case owner in Dataverse and posts a handover note activity to the case timeline.
