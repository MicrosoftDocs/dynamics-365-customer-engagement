---
title: Delete registration
description: Learn how to use the Delete registration capability in Dynamics 365 Customer Service.
ms.date: 08/07/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Delete registration

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

This capability removes an external MCP server registration or a Copilot Studio MCS agent registration from the registration-management widgets. It isn't invoked directly from chat.

## What it does
The registration-management widget calls this capability with the registration ID and an explicit type: `mcp` for an external MCP server or `mcs` for a Copilot Studio agent. After removal, the registration and its associated tools are no longer available.

## Try prompts like
Not applicable. Open the appropriate registration-management widget and use its delete action.

## What you'll see in chat
The management widget asks for confirmation before deleting the registration, then shows whether the operation succeeded.

## Helpful tips
- Use `manage_mcp_registration` first to see active registrations and their IDs.
- Use `manage_copilot_studio_registration` to manage Copilot Studio agent registrations.
- Removal is permanent. The registration cannot be recovered after deletion.
- Removing a registration stops the associated tools from being available.
- You need the appropriate administrator role to remove registrations.

## What happens next
After removal, the management widget refreshes its registration list. You can add a replacement registration from the same widget.

## Does this change data?
**Yes, this removes registration data.** The registration record is permanently deleted.

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete Registration |
| Internal tool name | `delete_registration` |
| Purpose | Removes an external MCP server or Copilot Studio MCS agent registration by ID |

## Tool behavior
Removes a registration by its ID. The calling widget must pass `type` to specify whether the registration is an external MCP server (`mcp`) or a Copilot Studio MCS agent (`mcs`). Confirmation is handled by the widget before it calls this tool.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool permanently removes registration data. |
| `idempotentHint` | `true` | Repeating the delete makes no additional data change, but the tool returns a not-found error when the registration is already removed. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Registration ID
The unique identifier of the registration to remove.

### Type
Whether the registration is an external MCP server (`mcp`) or a Copilot Studio MCS agent (`mcs`). This value is required.

## Response and UI behavior

### Response type

Widget action response

On success, the tool returns the deleted registration ID and type to the invoking registration-management widget. The widget then refreshes its registration list. If the registration isn't found or the operation fails, the response contains an error and the widget keeps the existing list state.

## Routing notes

This tool is invoked by registration-management widgets after an administrator confirms deletion. Don't invoke `delete_registration` directly from chat.

- Use `type: "mcp"` for an external MCP server registration.
- Use `type: "mcs"` for a Copilot Studio agent registration.
- Use the registration ID returned by the corresponding management widget.

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_mcp_registration`](manage_mcp_registration.md) | Opens or lists external MCP server registrations and invokes deletion with `type: "mcp"` |
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | Opens or lists Copilot Studio agent registrations and invokes deletion with `type: "mcs"` |
| [`save_mcp_registration`](save_mcp_registration.md) | Creates or updates an external MCP server registration |
| [`save_copilot_studio_registration`](save_copilot_studio_registration.md) | Creates or updates a Copilot Studio agent registration |

## Data mutation classification

Write operation (destructive, idempotent).

This tool permanently removes the selected registration. Repeating a successful deletion makes no additional data change; the tool reports an error when the registration no longer exists.
