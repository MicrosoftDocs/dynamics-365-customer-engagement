---
title: Link Email to Case
description: Learn how to use the Link Email to Case capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Link Email to Case

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you have an email that should be associated with an existing case. Linking connects the email to the case so it appears on the case's timeline.

## What it does
The assistant links an email to a case by setting the email's "regarding" reference to the target case. Once linked, the email appears on the case's activity timeline alongside other emails, notes, and activities. This is useful for organizing unlinked emails or associating an email with the correct case.

## Try prompts like
- "Link this email to case CAS-01010-A0A0A0"
- "Associate the email with this case"
- "Connect the email to the case"
- "Attach the customer's email to the billing case"
- "Link it to the case we found"

## What you see in chat
The assistant shows a text confirmation that the email was successfully linked to the case. No interactive component appears.

## Helpful tips
- If you're not sure which case to link the email to, say "match this email to existing cases" first. The assistant finds cases that might be a good fit.
- Linking an email to a case is safe to repeat - linking the same email to the same case again doesn't create duplicates.
- If no existing case matches the email, say "create a case from this email" instead.

> [!TIP]
> A common workflow is: view email, match it to cases, then link it to the best match - or create a new case if none match.

## What happens next
After the email is linked, you can continue with prompts like:

- "Open the case"
- "Show the case timeline"
- "Summarize the case"
- "Are there more unlinked emails?"

## Does this change data?

Yes. This links the email to the case.

The email's regarding reference is updated in Dynamics 365 to point to the case. The assistant asks for confirmation before making the change.

## Prerequisites
This tool requires the following:

- Email

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Link Email to Case |
| Internal tool name | `link_email_to_case` |
| Purpose | Links an email activity to an existing case by setting the email's regarding object to the target case |

## Tool behavior
Links an email activity to an existing case by setting the email's regarding object to the target case. Use after `match_cases` when the agent selects an existing case to associate an unlinked email with.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data - Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Linking is not destructive (the email still exists). |
| `idempotentHint` | `true` | Re-linking the same email to the same case produces the same result - safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Email identifier

| Input | Description | Required |
|---|---|---|
| `activityId` | `activityId` (the Dataverse email activity GUID to link, required). | Yes |

### Target case

| Input | Description | Required |
|---|---|---|
| `incidentId` | `incidentId` (the target case GUID to link the email to, required). | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns a confirmation that the email was linked to the case.

## Routing notes
Use `link_email_to_case` for:

- "Link the email to this case", "associate the email with the case"
- After `match_cases` identifies an existing case for an unlinked email

Don't use `link_email_to_case` when:

- No existing case matches the email and a new case is needed - use `create_case_from_email`
- The user wants to find matching cases first - use `match_cases`

## Related tools
| Tool | Relationship |
|---|---|
| [`match_cases`](match_cases.md) | Finds existing cases that may match an email (called before linking) |
| [`create_case_from_email`](create_case_from_email.md) | Creates a new case when no existing case matches |
| [`view_email`](view_email.md) | Displays the email content before linking |

## Data mutation classification
Write / mutation.

This tool updates the email's regarding object reference in Dataverse. M365 Copilot prompts the user for confirmation. The operation is idempotent - re-linking the same email to the same case produces the same result.
