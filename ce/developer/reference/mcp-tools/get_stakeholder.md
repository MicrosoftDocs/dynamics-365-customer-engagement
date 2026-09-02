---
title: Get stakeholders
description: Learn how to use the Get stakeholders capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get stakeholders

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to see the stakeholders connected to an opportunity or account.

## What it does

The assistant lists the stakeholders—the contacts and their connection roles—linked to a Dynamics 365 opportunity or account, and returns a text response with structured content for agent orchestration.

## Try prompts like

- Who are the stakeholders on this opportunity?
- Show me the buying group for this account.
- List the key contacts on this deal.
- Who influences this opportunity?

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous record names before calling tools that require identifiers.
- Use `update_stakeholder` to add a contact as a stakeholder or change a stakeholder's role.
- Use related record-view tools when you need to inspect the full Dataverse form.

## What happens next

After the response appears, you can continue with prompts like:

- Add a stakeholder to this opportunity.
- Schedule a meeting with these stakeholders.
- Draft a follow-up email.
- Open this opportunity.

## Does this change data?

**No, get_stakeholder doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales records and connections for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get stakeholders |
| Internal tool name | `get_stakeholder` |
| Purpose | lists the stakeholders connected to an opportunity or account. |

## Tool behavior

The tool reads the `connection` records that link the host opportunity or account to contacts, and returns each stakeholder's name, connection role, email, and job title. It is text-only and returns structured content for the requested Sales operation.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Sales context

| Input | Description | Required |
|---|---|---|
| `recordId` | Resolved GUID of the opportunity or account whose stakeholders you want to list. Resolve names before calling this tool. | Yes |
| `entityLogicalName` | Host record type: `opportunity` (default) or `account`. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content for the requested sales operation.

## Routing notes

Use `get_stakeholder` when the user asks who the stakeholders, buyers, or key contacts on an opportunity or account are. Don't use `get_stakeholder` to add or change a stakeholder—use `update_stakeholder` for that.

## Related tools

| Tool | Relationship |
|---|---|
| [`update_stakeholder`](update_stakeholder.md) | Adds a contact as a stakeholder or updates a stakeholder's role |
| [`schedule_meeting`](schedule_meeting.md) | Books a meeting with the stakeholders |
| [`get_entity_record`](get_entity_record.md) | Opens the full Dataverse record form |

## Data mutation classification

Read-only.
