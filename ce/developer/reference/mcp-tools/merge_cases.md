---
title: Merge duplicate cases
description: Merge duplicate support cases into one surviving case in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Merge duplicate cases

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when a customer's issue is tracked across two or more duplicate cases and you want to combine them into one case.

## What it does

The assistant merges duplicate cases into a single surviving case that you choose. Each of the other cases is cancelled with the status "Merged", and its activities, emails, and attachments move to the surviving case, so the full history lives on one record.

Because merging can't be undone, the assistant first shows a preview of exactly what moves and warns you if any case belongs to a different customer. Nothing changes until you confirm.

## Try prompts like

- These two cases are duplicates—merge CAS-01010-A0A0A0 into CAS-01008-B2B2B2.
- Fold case CAS-01010-A0A0A0 into CAS-01008-B2B2B2.
- Merge these cases, keep CAS-01008-B2B2B2 as the main one.
- Combine CAS-01010-A0A0A0 and CAS-01011-C3C3C3 into CAS-01008-B2B2B2.

## What you'll see in chat

First, the assistant shows a text preview: which case survives, and for each case being merged, how many activities and notes move. If any case belongs to a different customer, the preview flags it. After you confirm, the assistant returns a text summary of which cases merged and any that couldn't. No interactive component is displayed.

## Helpful tips

- Tell the assistant which case should survive. It won't guess for you.
- Review the preview before you confirm—merging can't be undone.
- Watch for a different-customer warning. Merging cases from different customers is allowed but is usually a mistake.
- You can merge several cases into one surviving case in a single request.

> [!TIP]
> If you only want to note that cases are related without cancelling any of them, ask to link the cases instead of merging them.

## What happens next

After merging, you can continue with prompts like:

- Show the surviving case.
- Summarize this case.
- What changed on this case?
- Reassign this case to Alex.

## Does this change data?

**Yes, this changes data, and it can't be undone.**

Each merged case is cancelled with the status "Merged", and its activities, emails, and attachments are re-parented to the surviving case. The assistant always shows a preview and asks you to confirm before any case is merged.

## Prerequisites

This tool requires the following:

- User must have read and write (merge) privileges on cases.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Merge cases |
| Internal tool name | `merge_cases` |
| Purpose | Merges duplicate cases into one surviving case, cancelling the others as "Merged" and re-parenting their history |

## Tool behavior

Merges duplicate cases into a surviving case by using the Dataverse Merge action. Runs in two phases: without `confirmed` (or `confirmed: false`), it returns a read-only preview of the records that move and flags any cross-customer case; with `confirmed: true`, it merges each case independently and returns a per-case outcome. Each merge is applied one case at a time; a failure on one case is reported without stopping the others.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | Merged cases are cancelled as "Merged"—the operation is irreversible. |
| `idempotentHint` | `false` | Re-running doesn't repeat cleanly; an already-merged case is inactive and can't be merged again. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Surviving case

| Input | Description | Required |
|---|---|---|
| `survivingCaseId` | The case that stays active and receives the merged history. GUID or case number (for example, CAS-01010-A0A0A0). The user must choose this—the assistant doesn't infer it. | Yes |

### Cases to merge

| Input | Description | Required |
|---|---|---|
| `mergedCaseIds` | One or more cases to merge into the surviving case. Each is cancelled as "Merged". GUIDs or case numbers. Up to nine (the platform allows ten cases per merge, including the survivor). | Yes |

### Confirmation and options

| Input | Description | Required |
|---|---|---|
| `confirmed` | `confirmed` (boolean): omit or set false for a read-only preview; set true only after the user confirms. | No |

## Response and UI behavior

### Response type

Text-only

Returns a text preview before confirmation and a text per-case outcome (merged and failed) after confirmation. No interactive component is rendered.

## Routing notes

Use `merge_cases` when:

- The user says "these are duplicates", "merge these cases", or "fold case X into case Y".
- Two or more cases track the same issue and should become one record.

Don't use `merge_cases` when:

- **The user wants to relate cases without cancelling any**—route to the case-linking tool.
- **Updating case fields** (priority, status)—route to `update_case`.
- **Closing a single case**—route to `close_case`.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_cases`](list_cases.md) | Lists cases to find the duplicates to merge |
| [`get_case`](get_case.md) | Opens a case form to review before merging |
| [`search_cases`](search_cases.md) | Finds candidate duplicate cases by keyword |
| [`reassign_case`](reassign_case.md) | Reassigns a case instead of merging it |
| [`close_case`](close_case.md) | Resolves and closes a single case |

## Data mutation classification

Write / mutation (irreversible).

Cancels each merged case as "Merged" and re-parents its activities, emails, and attachments to the surviving case in Dataverse.
