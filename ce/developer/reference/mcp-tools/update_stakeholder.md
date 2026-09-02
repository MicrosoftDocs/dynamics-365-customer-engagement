---
title: Update stakeholder
description: Learn how to use the Update stakeholder capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Update stakeholder

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to add a contact as a stakeholder or change a stakeholder's role on an opportunity or account.

## What it does

The assistant adds a contact as a stakeholder on a Dynamics 365 opportunity or account, or updates the connection role of an existing stakeholder, and returns a text response with structured content for agent orchestration.

## Try prompts like

- Add Jordan Reyes as a decision maker on this opportunity.
- Record this contact as a technical buyer on the account.
- Make Sarah a stakeholder on this deal.
- Change this stakeholder's role to champion.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve the contact name to its contactId before calling this tool.
- Use `get_stakeholder` to review the current stakeholders before adding or updating one.
- Confirm write actions before changing opportunity or account relationships.

## What happens next

After the response appears, you can continue with prompts like:

- Show the stakeholders on this opportunity.
- Schedule a meeting with this stakeholder.
- Draft an introduction email.
- Open this opportunity.

## Does this change data?

**Yes, update_stakeholder changes data.**

This tool creates or updates a connection between the host record and a contact. Confirm the contact and role before running it.

## Prerequisites

This tool requires create and write access to Dynamics 365 connections, plus append access to the host opportunity or account and the contact, for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Update stakeholder |
| Internal tool name | `update_stakeholder` |
| Purpose | adds or updates a stakeholder connection on an opportunity or account. |

## Tool behavior

The tool creates a `connection` linking the host opportunity or account to the contact, or updates the connection role when the contact is already a stakeholder. When a role name is supplied, it is resolved to a `connectionrole`; an unresolved role is reported without failing the connection. It is text-only and returns structured content for the requested Sales operation.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | This tool modifies data. |
| `destructiveHint` | `false` | Adds or updates a relationship; doesn't delete records. |
| `idempotentHint` | `false` | Re-running with a new role updates the existing connection. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Sales context

| Input | Description | Required |
|---|---|---|
| `recordId` | Resolved GUID of the opportunity or account the stakeholder belongs to. | Yes |
| `contactId` | Resolved GUID of the contact to add or update as a stakeholder. | Yes |
| `entityLogicalName` | Host record type: `opportunity` (default) or `account`. | No |
| `role` | Connection-role name for the stakeholder, such as Decision Maker or Stakeholder. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content for the requested sales operation.

## Routing notes

Use `update_stakeholder` when the user wants to add a contact to a deal's stakeholders or change a stakeholder's role. Don't use `update_stakeholder` to change record ownership (use `assign_entity`) or to edit scalar fields (use `update_entity_record`).

## Related tools

| Tool | Relationship |
|---|---|
| [`get_stakeholder`](get_stakeholder.md) | Lists the current stakeholders on the record |
| [`schedule_meeting`](schedule_meeting.md) | Books a meeting with the stakeholders |
| [`get_entity_record`](get_entity_record.md) | Opens the full Dataverse record form |

## Data mutation classification

Write—creates or updates a stakeholder connection.
