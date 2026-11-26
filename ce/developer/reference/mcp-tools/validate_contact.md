---
title: Validate contact
description: Learn how to use the Validate contact capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: rajsp
ms.author: rajsp
ms.reviewer: tmanchanda
---

# Validate contact

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to confirm that a contact exists and has basic email and phone information.

## What it does

The assistant reads the supplied contact GUID directly. It reports whether the contact exists, whether any of the three Dataverse email fields (`emailaddress1`, `emailaddress2`, or `emailaddress3`) is populated, and whether `telephone1` or `mobilephone` is populated. It doesn't change Dataverse or perform additional searches.

## Try prompts like

- Validate contact c49f9900-fe78-f111-ab0f-000d3a339c63
- Does contact c49f9900-fe78-f111-ab0f-000d3a339c63 exist and have email and phone details?
- Check whether contact c49f9900-fe78-f111-ab0f-000d3a339c63 has any email address
- Does contact c49f9900-fe78-f111-ab0f-000d3a339c63 have a phone number?

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Provide the contact's Dataverse GUID. The tool doesn't resolve names or search for related records.
- Any non-empty value in `emailaddress1`, `emailaddress2`, or `emailaddress3` satisfies the email check.
- Use `get_contact` to open the contact record when more fields or an approved correction are needed.

## What happens next

- Review the email and phone presence results.
- Open the full contact record.
- Correct approved fields in the `get_contact` form.
- Re-run validation after cleanup.

## Does this change data?

**No, validate_contact does not change data.**

## Prerequisites

The user needs read access to contact records in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Validate contact |
| Internal tool name | `validate_contact` |
| Purpose | Confirms contact existence and email or phone presence. |

## Tool behavior

The tool performs one direct contact-record read and returns whether the contact exists,
plus `hasEmail` and `hasPhone` booleans. A missing contact is returned as
`exists: false`; permission and transport failures remain errors because the tool cannot
determine existence in those cases.

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

The text-only response includes the contact GUID, `hasEmail`, `hasPhone`, and, when the contact exists and a deep link can be built, a contact deep link.

## Routing notes

Use `validate_contact` only for contact existence and email or phone presence checks. Don't use it for broader data-quality scoring, active-state checks, contact searches, duplicate detection, relationship discovery, staleness judgments, or record updates.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_contact`](get_contact.md) | Returns the full contact record. |
| [`get_contact_summary`](get_contact_summary.md) | Provides a relationship-focused contact briefing. |
| [`update_stakeholder`](update_stakeholder.md) | Adds a stakeholder or updates an existing stakeholder role. |

## Data mutation classification

Read-only.
