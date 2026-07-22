---
title: Match Cases to Email
description: Learn how to use the Match Cases to Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Match Cases to Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you have an incoming email and want to check if it matches an existing case before deciding whether to link it or create a new one.

## What it does
The assistant analyzes an email's subject and body and uses relevance search to find up to 5 existing cases that may be related. Each candidate is shown with a match score, case number, title, and status. This helps you decide whether to link the email to an existing case or create a new case from it.

## Try prompts like
- "Does this email match an existing case?"
- "Find cases related to this email"
- "Check if there's already a case for this email"
- "Match this email to existing cases"
- "Which case does this email belong to?"

## What you see in chat
The assistant shows a text list of up to five candidate cases with match scores, case numbers, titles, and statuses.

## Helpful tips
- This tool works with a specific email that's already in Dynamics 365. The assistant uses the email's content to search for matching cases.
- High match scores indicate a strong relevance match. Low scores suggest a weak or coincidental match.
- After seeing matches, you can link the email to one of the listed cases or create a new case from the email.
- If no matches are found, consider creating a new case from the email.

> [!TIP]
> After finding a match, prompt with "link this email to case CAS-01010-A0A0A0" to associate them, or "create a case from this email" if none match.

## What happens next
After seeing the matches, you can continue with prompts like:

- "Link this email to the first case"
- "Create a case from this email"
- "Summarize case CAS-01010-A0A0A0"
- "Open the first matching case"

## Does this change data?

No. Matching cases doesn't change data.

The match uses existing search indices and doesn't modify any records. Linking or creating a case from the email are separate actions.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. Review the availability note at the top of this article for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Match Cases to Email |
| Internal tool name | `match_cases` |
| Purpose | Finds existing cases that may match an incoming email using Dataverse Relevance Search on the email subject and body |

## Tool behavior
Finds existing cases that may match an incoming email using Dataverse Relevance Search on the email subject and body. Returns the top 5 candidate cases with match scores, enabling the user to decide whether to link the email to an existing case or create a new one.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Email identifier

| Input | Description | Required |
|---|---|---|
| `activityId` | `activityId` (GUID, required). The Dataverse email activity GUID to match against existing cases. | Yes |

## Response and UI behavior
### Response type

Text-only

Returns a text list of up to 5 candidate cases with match scores, case number, title, and status. No interactive component is rendered.

## Routing notes
Use `match_cases` when:

- The user wants to know whether an incoming email already has a matching case
- The user is triaging an email and needs to decide between linking to an existing case or creating a new one
- Part of the email-to-case workflow

Don't use `match_cases` when:

- **General keyword search across cases** - route to `search_cases`
- **Listing cases by filters** - route to `list_cases`
- **Linking an email to a known case** - route to `link_email_to_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`link_email_to_case`](link_email_to_case.md) | Links the email to a case after the user selects a match |
| [`search_cases`](search_cases.md) | General keyword search across cases (not email-based) |
| [`list_cases`](list_cases.md) | Lists cases with filters and grid |
| [`view_email`](view_email.md) | Opens the email to review before matching |

## Data mutation classification
Read-only.

The tool queries Relevance Search indices without modifying any data.
