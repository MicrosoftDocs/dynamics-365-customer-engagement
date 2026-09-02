---
title: Contact summary
description: Learn how to use the Contact summary capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: rajsp
ms.author: rajsp
ms.reviewer: tmanchanda
---

# Contact summary

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs a concise briefing about one contact's role and relevance.

## What it does

The assistant calls the Dataverse `AISummarizeRecord` action for the supplied contact GUID. If the summary action fails or returns an unusable response, the assistant reports that the summary is unavailable without returning raw contact fields. It doesn't search for contacts by name.

## Try prompts like

- Summarize contact c49f9900-fe78-f111-ab0f-000d3a339c63
- Brief me on contact c49f9900-fe78-f111-ab0f-000d3a339c63 before I call
- Recap contact c49f9900-fe78-f111-ab0f-000d3a339c63 and why they matter
- Give me relationship context for contact c49f9900-fe78-f111-ab0f-000d3a339c63

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Provide the contact's Dataverse GUID. The tool doesn't resolve names or perform contact searches.
- Use `get_contact` when you need the complete editable contact record.
- Use `validate_contact` when you need to confirm contact existence and email or phone presence.

## What happens next

- Open the contact record.
- Validate the contact's data quality.
- Map the buying group for the contact's opportunity or account.
- Draft seller follow-up.

## Does this change data?

**No, get_contact_summary does not change data.**

## Prerequisites

The user needs read access to the contact. The tool attempts the AI summary without requiring the user to verify environment feature settings first. If the summary cannot be retrieved, it returns an unavailable-summary result.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Contact summary |
| Internal tool name | `get_contact_summary` |
| Purpose | Returns an AI contact briefing or reports that the summary is unavailable. |

## Tool behavior

The tool calls `AISummarizeRecord` directly with one contact GUID. Any action failure, declined result, partial result, or malformed response returns `summarySource: unavailable` without a second Contact read.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `contactId` | Dataverse contact GUID. | Yes |

## Response and UI behavior

The text-only response includes the contact GUID and source (`ai` or `unavailable`). A successful AI response includes the summary and contact deep link. An unavailable response doesn't claim that the contact exists and doesn't include a deep link or raw contact fields.

## Routing notes

Use `get_contact_summary` for a concise contact briefing or relationship recap. Use `get_contact` for raw fields and `validate_contact` for direct-record completeness checks.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_contact`](get_contact.md) | Returns the full contact record. |
| [`validate_contact`](validate_contact.md) | Checks contact existence and email or phone presence. |
| [`update_stakeholder`](update_stakeholder.md) | Adds a stakeholder or updates an existing stakeholder role. |

## Data mutation classification

Read-only.
