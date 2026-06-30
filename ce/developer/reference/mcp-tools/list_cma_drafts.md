---
title: Cases with Emails Drafted for Review
description: Learn how to use the Cases with Emails Drafted for Review capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Cases with Emails Drafted for Review

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "What emails has the AI drafted for this case?"
- "Show draft emails awaiting my review"
- "List AI-drafted emails for this ticket"

## What you'll see in chat
If drafts are available, the assistant displays an interactive selection grid as an app-in-chat component, showing the subject, recipient, and creation date of each draft. If no drafts exist for the case, the assistant tells you so in a text response.

## Helpful tips
- You need to specify which case you want to check. Use the case number (CAS-01010-A0A0A0) or the case you're already working with.
- Drafts are created by the Case Management Agent in the background. If none appear, CMA hasn't drafted anything for this case yet.
- After selecting a draft, you can review the full email content and decide whether to approve and send it.
- If you want to see all cases with CMA suggestions (not just email drafts), ask for "cases with suggested actions."

> [!TIP]
> Review CMA drafts before sending. The AI drafts are a starting point - you can edit the content before approving.

## What happens next
After selecting a draft, you can continue with prompts like:

- "Show me this draft"
- "Edit and send this email"
- "Summarize this case"
- "What else has the AI suggested for this case?"

## Does this change data?
**No, viewing email drafts does not change data.**

The drafts are retrieved in read-only mode. Approving or sending a draft is a separate action.

## What you can do from the app-in-chat component
When drafts are found, you can:

- Browse available email drafts in a sortable grid
- See the subject, recipient, and creation date of each draft
- Select a draft to open it for review

## Prerequisites
This tool requires the following:

- Case Management Agent in semi-autonomous mode to be configured. Without Case Management Agent enabled, no AI-drafted emails are created
- This tool always returns an empty result

Learn more in [Configure Case Management Agent](/dynamics365/customer-service/administer/case-management-global-settings).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Cases with Emails Drafted for Review |
| Internal tool name | `list_cma_drafts` |
| Purpose | Retrieves AI-generated email drafts that the Case Management Agent (CMA) has prepared on a case for the user to review and approve |

## Tool behavior
Retrieves AI-generated email drafts that the Case Management Agent (CMA) has prepared on a case for the user to review and approve. Returns draft summaries including subject, recipient, snippet, and draft ID. Renders a selection grid when drafts are found; the user picks a draft to open and review it.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

## Response and UI behavior
The response depends on the number of drafts found:

- **0 drafts**: text-only response indicating no drafts are available. No widget is rendered.
- **1 or more drafts**: renders an interactive selection grid.

This MCP tool is supported by an MCP App. 

### Response type

Interactive selection grid (app-in-chat) when drafts exist

## Routing notes
Use `list_cma_drafts` when:

- The user asks about "cases with emails drafted for review", "drafted emails awaiting review", "pending CMA email drafts"
- The user wants to see what emails the AI has drafted on a specific case

Don't use `list_cma_drafts` when:

- **Viewing a specific email** - route to `view_email`
- **Drafting a new reply** - route to the email drafting tool
- **Cases with CMA suggested actions** (not specifically drafts) - route to `list_case_suggested_actions`

## Related tools
| Tool | Relationship |
|---|---|
| [`view_email`](view_email.md) | Opens a specific draft email for review |
| [`list_case_suggested_actions`](list_case_suggested_actions.md) | Lists all cases with CMA-suggested next actions (broader than just drafts) |
| [`summarize_case`](summarize_case.md) | Opens the case with an AI summary |
| [`list_cma_escalated_cases`](list_cma_escalated_cases.md) | Lists cases where CMA has escalated to a human |

## Data mutation classification
Read-only.

The tool retrieves existing CMA draft metadata without modifying any data. Approving or sending a draft is a separate action.
