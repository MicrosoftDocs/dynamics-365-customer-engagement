---
title: Remove DV QnA tables
description: Learn how to use the Remove DV QnA tables capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove DV QnA tables

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to remove one or more customer-added Dataverse tables from Customer Service DV QnA.

## What it does

The assistant removes the tables you select from the Customer Service DV QnA scope so the skill no longer answers questions from them. It's normally run for you from the table-management panel after you select tables and confirm. Built-in tables are protected and can't be removed.

## Try prompts like

- Remove a table from DV QnA.
- Stop DV QnA from answering from my callback queue table.
- Take cr4ae_orders out of Customer Service DV QnA.

## What you'll see in chat

The table-management panel confirms how many tables were removed and refreshes the list of tables in scope. If some tables couldn't be removed (for example, a built-in table), the panel reports the partial outcome so you know what changed.

## Helpful tips

- Only tables you added can be removed; built-in tables are locked.
- You can select and remove several tables at once from the panel.
- Removing a table doesn't delete the table or its records—it only takes the table out of the DV QnA scope.

## What happens next

After tables are removed, continue with:

- Which tables can DV QnA answer from?
- Add a table to DV QnA.

## Does this change data?

**Yes. Removing a table changes your environment's configuration.** It deletes the binding so the skill no longer answers from that table. It doesn't delete the table or its records.

## Prerequisites

This tool requires the following:

- Dynamics 365 Customer Service MCP server to be configured. Makers using this tool need the `prvmsdyn_ServiceAgentMakerCustomize` privilege.
- The `CustomerServiceQnA` Dataverse search skill provisioned in the environment.

Learn more in [Connect to Dynamics 365 Customer Service MCP Server](/dynamics365/customer-service/administer/configure-customer-service-mcp-server).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Remove DV QnA tables |
| Internal tool name | `remove_dv_qna_table` |
| Purpose | Removes one or more customer-added Dataverse tables from the CustomerServiceQnA skill scope |

## Tool behavior

Processes a batch of `dvtablesearchentityid` values, removing each binding fail-soft so one bad id can't abort the batch. Each id is guarded: out-of-the-box (managed) rows are refused, and rows belonging to a different skill are refused. Returns a per-id result list so the widget can report partial outcomes. The management widget chunks larger selections into batches within the supported size.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | The tool deletes the binding rows. |
| `idempotentHint` | `false` | Removing an already-removed binding is not a no-op. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Binding ids

| Input | Description | Required |
|---|---|---|
| `ids` | One or more `dvtablesearchentityid` values to unbind, 1-25 items per call. | Yes |

## Response and UI behavior

### Response type

Text (consumed by the table-management widget)

Returns `success` plus a `results` array with a per-id outcome (`deleted` true or false and, on failure, an error code such as `ManagedRowProtected` or `WrongSkillScope`). The widget refreshes the list and reports an aggregate success or partial-removal count; it doesn't surface individual per-id error codes.

## Routing notes

Use `remove_dv_qna_table` when:

- A maker selects added tables to remove from the DV QnA scope (typically invoked by the management widget after a confirmation dialog).

Don't use `remove_dv_qna_table` when:

- The target is a built-in (managed) table. Those are protected and can't be removed.

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Opens the widget that invokes this tool |
| [`add_dv_qna_table`](add_dv_qna_table.md) | Adds tables to the scope |

## Data mutation classification

Delete.

Removes `dvtablesearchentity` binding rows. It doesn't delete the underlying tables or their records.
