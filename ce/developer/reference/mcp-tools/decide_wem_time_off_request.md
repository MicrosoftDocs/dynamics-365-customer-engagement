---
title: Approve or reject time-off requests
description: Use the WEM agent to approve or reject a Workforce Engagement Management time-off request directly in chat.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=wem
ms.service: dynamics-365-customer-service
author: prashas
ms.author: prashas
ms.reviewer: laalexan
---

# Approve or reject time-off requests

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you're a supervisor deciding a pending Workforce Engagement Management (WEM) time-off request and want to approve or reject it directly in chat.

## What it does

The assistant updates a single WEM time-off request to approved or rejected and records you as the reviewer. You identify the request by its exact name, by the agent who submitted it plus the date, or by its record ID. When you reject a request, you provide a short reason that's saved as the reviewer note.

The assistant only acts on time-off requests—it refuses shift-bid and shift-swap records. It never overwrites a decision another reviewer already made, and if your reference matches more than one pending request, it lists the matches and asks you to be more specific instead of guessing.

## Try prompts like

- Approve agent1's time off on 2027-01-01.
- Reject the 'Time off on 1/1/2027' request—reason: insufficient coverage.
- Approve this pending time-off request.
- Reject Alex's time off next Friday because the team is short-staffed.

## What you'll see in chat

The assistant confirms the decision with a text response—for example, that the request was approved or rejected and that you were recorded as the reviewer. No interactive component is displayed.

## Helpful tips

- A rejection reason is required to reject a request. The assistant asks for one if you don't provide it.
- The easiest way to pick the right request is to name the agent and the date, or use the exact request name.
- Use "show my pending time-off approvals" first (through the WEM request list) to see what's waiting on you.
- This tool decides time-off requests only. For shift-bid or shift-swap requests, use the request list and detail views to review them.

> [!TIP]
> The rejection reason becomes the reviewer note on the request. Use it to explain the decision so the agent understands why.

## What happens next

After the decision is recorded, you can continue with prompts like:

- Show my remaining pending time-off approvals.
- Approve the next one.
- List this week's time-off requests.

## Does this change data?

**Yes, this changes data.**

The time-off request's status is updated to approved or rejected in Dynamics 365, and you are recorded as the reviewer. A rejection also saves your reason as the reviewer note.

## Prerequisites

This tool requires the following:

- Supervisor or reviewer access to Workforce Engagement Management time-off requests.
- Workforce Engagement Management enabled in the environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Approve or reject time-off requests |
| Internal tool name | `decide_wem_time_off_request` |
| Purpose | Updates a Workforce Engagement Management time-off request to approved or rejected and records the reviewer |

## Tool behavior

Updates a single Dataverse `msdyn_wemrequest` time-off record to approved or rejected. You identify the record by `requestId` (its GUID), by `requestName` (its exact name), or by `agentName` plus `date`. The tool refuses non-time-off records, enforces optimistic concurrency so it never overwrites another reviewer's decision, and returns candidate matches when a name or agent reference is ambiguous. A rejection requires `rejectionReason`, which is saved as the reviewer note. This tool is text-only and renders no widget.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | The request is updated, not deleted. |
| `idempotentHint` | `true` | Re-deciding an already-decided request is rejected rather than applied twice. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Request identifier

Provide one of the following ways to identify the request.

| Input | Description | Required |
|---|---|---|
| `requestId` | The Dataverse `msdyn_wemrequestid` (GUID) of the request. The most precise identifier. | No* |
| `requestName` | The exact name of the time-off request, for example, "Time off on 1/1/2027". Used when `requestId` is omitted. | No* |
| `agentName` | The name of the agent who requested the time off, for example, "agent1". Combine with `date` to pick one request. | No* |
| `date` | The date of the time off (YYYY-MM-DD or M/D/YYYY), used with `agentName` to disambiguate. | No* |

\* Provide `requestId`, or `requestName`, or `agentName` with `date`. If the reference matches more than one pending request, the tool returns the candidates so you can choose.

### Decision

| Input | Description | Required |
|---|---|---|
| `decision` | Whether to `approve` or `reject` the request. | Yes |
| `rejectionReason` | Short reason saved as the reviewer note. Required when `decision` is `reject`; ignored when approving. | Varies |

## Response and UI behavior

### Response type

Text-only

Returns a text confirmation of the decision. No interactive component is rendered. When a reference is ambiguous, the response lists candidate requests so you can pick one.

## Routing notes

Use `decide_wem_time_off_request` when:

- A supervisor asks to approve, reject, or decide a pending time-off request.

Don't use `decide_wem_time_off_request` when:

- **Listing or browsing requests**—route to `list_wem_requests`.
- **Opening a single request to review its details**—route to `get_wem_request_details`.
- **Deciding a shift-bid or shift-swap request**—this tool handles time-off requests only.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_wem_requests`](list_wem_requests.md) | Lists WEM requests; use it to find pending time-off approvals |
| [`get_wem_request_details`](get_wem_request_details.md) | Opens a single WEM request to review before deciding |

## Data mutation classification

Write / mutation.

Updates the `msdyn_wemrequest` time-off record's status to approved or rejected and records the reviewer. A rejection also saves the reviewer note. The tool refuses non-time-off records and won't overwrite a decision already made by another reviewer.
