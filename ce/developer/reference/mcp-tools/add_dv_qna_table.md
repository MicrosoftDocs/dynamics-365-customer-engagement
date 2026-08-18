---
title: Add DV QnA table
description: Learn how to use the Add DV QnA table capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Add DV QnA table

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to add a Dataverse table to Customer Service DV QnA so the skill can answer questions from it.

## What it does

The assistant binds a custom Dataverse table to the Customer Service DV QnA skill so the skill can answer questions about that table's records. It's normally run for you from the table-management panel after you validate the table. Adding a table that's already in scope succeeds without creating a duplicate.

## Try prompts like

- Add cr4ae_callbackqueue to DV QnA.
- Let DV QnA answer from my callback queue table.
- Bind cr4ae_orders to Customer Service DV QnA.

## What you'll see in chat

The table-management panel confirms the table was added and refreshes the list of tables in scope. If the table is already in scope, you see a message that it's already added. If the skill is at or over the soft cap of 25 tables, the panel asks you to confirm before adding more.

## Helpful tips

- Validate the table first—a table that isn't enabled for the Dataverse search index can't be added.
- Use the table's logical name with its publisher prefix, for example `cr4ae_callbackqueue`.
- Keeping the scope at or under 25 tables helps DV QnA stay accurate; you can add beyond that after acknowledging the warning.

## What happens next

After a table is added, continue with:

- Which tables can DV QnA answer from?
- Remove a table from DV QnA.

You can then ask DV QnA questions that draw on the newly added table.

## Does this change data?

**Yes. Adding a table changes your environment's configuration.** It creates a binding so the skill can answer from the table. It doesn't change the table's own records.

## Prerequisites

This tool requires the following:

- Dynamics 365 Customer Service MCP server to be configured. Makers using this tool need the `prvmsdyn_ServiceAgentMakerCustomize` privilege.
- The `CustomerServiceQnA` Dataverse search skill provisioned in the environment, and the target table enabled for the Dataverse search index.

Learn more in [Connect to Dynamics 365 Customer Service MCP Server](/dynamics365/customer-service/administer/configure-customer-service-mcp-server).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Add DV QnA table |
| Internal tool name | `add_dv_qna_table` |
| Purpose | Binds a Dataverse table to the CustomerServiceQnA skill so DV QnA can answer questions from it |

## Tool behavior

Resolves the skill, re-checks that the table is enabled for the search index (defense in depth), and creates a `dvtablesearchentity` row binding the table to the skill. The operation is idempotent—re-adding an existing table returns success without creating a duplicate. When the scope is at or over the soft cap (25 tables), the call returns a cap warning that the widget surfaces for explicit acknowledgement before proceeding.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | The tool creates a binding; it doesn't delete data. |
| `idempotentHint` | `true` | Re-adding an existing table has no additional effect. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Logical name

| Input | Description | Required |
|---|---|---|
| `logicalName` | The Dataverse table logical name with publisher prefix, 1-128 characters. | Yes |

### Cap acknowledgement

| Input | Description | Required |
|---|---|---|
| `acknowledgeCapWarning` | Set to `true` to proceed when the scope already has 25 or more tables. Defaults to `false`. | No |

## Response and UI behavior

### Response type

Text (consumed by the table-management widget)

Returns `success: true` with the new binding id, or `alreadyExists: true` when the table is already bound. Returns an error code for failures: `NotSearchIndexed`, `CapWarning`, `SkillNotFound`, or `InvalidLogicalName`.

## Routing notes

Use `add_dv_qna_table` when:

- A maker confirms a validated table should be added to the DV QnA scope (typically invoked by the management widget).

Don't use `add_dv_qna_table` when:

- The table hasn't been validated yet—use `test_dv_qna_table` first.
- The user wants to create the table itself. That is done in the maker portal.

## Related tools

| Tool | Relationship |
|---|---|
| [`test_dv_qna_table`](test_dv_qna_table.md) | Validates the table before it is added |
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Opens the widget that invokes this tool |
| [`remove_dv_qna_table`](remove_dv_qna_table.md) | Reverses the binding |

## Data mutation classification

Create (idempotent).

Creates a `dvtablesearchentity` binding row. It doesn't modify the bound table's own records.
