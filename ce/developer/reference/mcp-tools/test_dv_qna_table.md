---
title: Test DV QnA table
description: Learn how to use the Test DV QnA table capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Test DV QnA table

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to validate that a Dataverse table exists, is accessible, and is enabled for the Dataverse search index before you add it to Customer Service DV QnA.

## What it does

The assistant checks a Dataverse table by its logical name and confirms three things: the table exists, you can access it, and it's enabled for the Dataverse search index. It's normally run for you from the table-management panel when you validate a table before adding it.

## Try prompts like

- Test the cr4ae_callbackqueue table for DV QnA.
- Can DV QnA use my orders table?
- Validate cr4ae_callbackqueue before adding it.
- Check that cr4ae_orders is ready for DV QnA.

## What you'll see in chat

The validation result appears in the table-management panel: a confirmation with the resolved display name when the table is valid and search-indexed, or a clear reason (for example, the table wasn't found, isn't accessible, or isn't enabled for search) when it can't be added yet.

## Helpful tips

- A table must be enabled for the Dataverse search index before it can be added; validation tells you when it isn't.
- Use the table's logical name with its publisher prefix, for example `cr4ae_callbackqueue`.
- Validation only checks the table—it doesn't add it. Use Add after a successful validation.

## What happens next

After a table validates successfully, continue with:

- Add cr4ae_callbackqueue to DV QnA.

If validation reports the table isn't search-indexed, enable it for the Dataverse search index first, then validate again.

## Does this change data?

**No. Validation is read-only.** It reads the table's metadata only and never changes data.

## Prerequisites

This tool requires the following:

- Dynamics 365 Customer Service MCP server to be configured. Makers using this tool need the `prvmsdyn_ServiceAgentMakerCustomize` privilege.
- The `CustomerServiceQnA` Dataverse search skill provisioned in the environment.

Learn more in [Connect to Dynamics 365 Customer Service MCP Server](/dynamics365/customer-service/administer/configure-customer-service-mcp-server).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Test DV QnA table |
| Internal tool name | `test_dv_qna_table` |
| Purpose | Validates that a Dataverse table exists, is accessible, and is enabled for the Dataverse search index before it is added to DV QnA |

## Tool behavior

Reads the table's metadata from the `EntityDefinitions` endpoint to confirm the table exists and is accessible under the caller's identity, and derives whether it is enabled for the Dataverse search index (change tracking on and synced to the external search index). This is a widget-invoked helper run before `add_dv_qna_table`.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Logical name

| Input | Description | Required |
|---|---|---|
| `logicalName` | The Dataverse table logical name with publisher prefix (for example, `cr4ae_callbackqueue`), 1-128 characters. | Yes |

## Response and UI behavior

### Response type

Text (consumed by the table-management widget)

Returns `ok: true` with the resolved display name, entity set name, and primary name attribute when the table is valid and search-indexed; otherwise `ok: false` with an error code (`TableNotFound`, `TableNotAccessible`, `NotSearchIndexed`, or `InvalidLogicalName`).

## Routing notes

Use `test_dv_qna_table` when:

- A maker is validating a table before adding it to the DV QnA scope (typically invoked by the management widget).

Don't use `test_dv_qna_table` when:

- The user wants to add the table directly—use `add_dv_qna_table`, which re-validates server-side.

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Opens the widget that invokes this validation |
| [`add_dv_qna_table`](add_dv_qna_table.md) | Binds the table after it validates |

## Data mutation classification

Read-only.

Validation reads metadata only and never changes data.
