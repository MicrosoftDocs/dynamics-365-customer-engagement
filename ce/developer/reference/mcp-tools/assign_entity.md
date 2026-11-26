---
title: Assign entity
description: Learn how to use the Assign entity capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Assign entity

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you need to assign a Dataverse record to another owner or route it to a queue.
The tool supports generic records such as accounts, contacts, opportunities, leads, cases, and custom tables.

## What it does

The assistant updates record ownership for user or team targets by using the Dataverse assign operation. For queue targets, it routes the record to a queue when the table supports queue routing.

Before it makes a change, the assistant checks the table's Dataverse metadata when that metadata is available. If the table is organization-owned (its records have no owner), or if you ask to route a record from a table that isn't enabled for queues, the assistant returns a clear explanation instead of attempting an operation that Dataverse would reject. If the metadata can't be read, Dataverse remains the source of truth and the operation proceeds to the platform check.

If the target name is ambiguous, the assistant returns matching candidates so you can choose the correct user, team, or queue before the record is changed.

## Try prompts like

- Assign this opportunity to me.
- Route this lead to the enterprise sales queue.
- Assign this account to Jordan Reyes.
- Move this custom record to the renewal team.

## What you'll see in chat

The assistant displays a text response confirming the assignment result, or asks you to choose from candidate targets when a display name matches more than one user, team, or queue. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Use record-specific tools when they have extra business requirements. For example, use `reassign_case` for support cases that require a handover note.
- Use exact target names, email addresses, or GUIDs when possible to avoid ambiguous matches.
- Use `targetId` value `me` only when assigning to the current user and `targetType` is `user`.

## What happens next

- Open the record.
- Show recent activity.
- Add a note about the handoff.

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires permission to read and assign the requested Dataverse record and permission to assign to the requested target. Queue routing requires the table to support queues and the target queue to be accessible.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Assign entity |
| Internal tool name | `assign_entity` |
| Purpose | Assign a Dataverse record to a user or team, or route it to a queue. |

## Tool behavior

The tool changes a record's owner for user and team targets. For queue targets, it adds the record to the specified queue when Dataverse supports queue routing for that table. It doesn't create handover notes or perform domain-specific workflow steps.

Before it assigns or routes a record, the tool reads the table's `OwnershipType` and `IsValidForQueue` metadata from Dataverse. It returns a clear pre-flight message when an assignment can't succeed—for example, when the table is organization-owned and has no owner to change, or when the table isn't enabled for queues. If that metadata can't be read, the tool proceeds and lets Dataverse enforce the rule.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | This tool doesn't perform destructive changes. |
| `idempotentHint` | `false` | Repeated calls are not guaranteed to be equivalent—queue routing adds a queue item each time. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Record and target

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | Dataverse logical name for the record to assign, such as `account`, `opportunity`, `lead`, or `incident`. | Yes |
| `recordId` | Dataverse GUID for the record to assign. | Yes |
| `targetType` | Assignment target type: `user`, `team`, or `queue`. | Yes |
| `targetId` | Target user, team, or queue GUID; `me` for the current user; an email address where supported; or a display name. | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `assign_entity` when the user wants to:

- assign a generic Dataverse record to a user or team.
- route a supported record to a queue.
- change ownership for a record type that doesn't have a more specific assignment tool.

Don't use `assign_entity` when the user wants to:

- add a handover note while transferring a support case; use `reassign_case`.
- update a regular field value; use `update_entity_record`.
- create a task or timeline activity; use `create_activity`.

## Related tools

| Tool | Relationship |
|---|---|
| `reassign_case` | Use for support-case transfers that need a handover note. |
| `update_entity_record` | Use for field updates that are not owner or queue assignments. |
| `get_entity_record` | Use to inspect the record before or after assignment. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it successfully assigns ownership or routes a record to a queue. Repeating the same owner assignment (user or team) to the same target is idempotent, but repeating a queue route can add another queue item, so the tool is not marked idempotent overall.
