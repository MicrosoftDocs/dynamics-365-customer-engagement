---
title: Delete External MCP Registration
description: Learn how to use the Delete External MCP Registration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Delete External MCP Registration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you remove an external MCP tool server registration from the registration management widget.

## What it does
When you select Delete on an existing MCP server registration in the management widget, this tool removes it from your Dynamics 365 environment. The server's tools are immediately unregistered and are no longer available to the Service Agent.

The deletion also clears cached proxy connections to the removed server, so no further calls are routed to it.

## Try prompts like
Not applicable. This tool is called automatically when you delete a registration from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget updates to confirm the deletion succeeded and removes the entry from the list. If the deletion fails (for example, the registration was already removed), the widget displays an error message.

## Helpful tips
- Deletion is immediate and permanent. There is no undo.
- After deleting a registration, the Service Agent can no longer invoke tools from that server.
- Deleting a registration frees up a slot toward the 20-registration cap for your environment.

## What happens next
After deleting, the registration widget returns to the list view. You can:

- "Add a new MCP server"
- "Manage my remaining registrations"

## Does this change data?
**Yes, this changes data.**

Deleting a registration permanently removes a configuration record from your Dynamics 365 environment.

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete External MCP Registration |
| Internal tool name | `delete_mcp_registration` |
| Purpose | Removes an external MCP server registration by ID |

## Tool behavior
Removes an external MCP server registration by ID. This is a widget support tool invoked automatically when users interact with the extensibility registrations widget. It is not intended for direct invocation by the model.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool deletes registration data. |
| `destructiveHint` | `true` | Permanently removes the registration. |
| `idempotentHint` | `true` | Deleting an already-deleted registration is a no-op. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Registration ID

| Input | Description | Required |
|---|---|---|
| `id` | `id` (UUID, required). The unique identifier of the registration to delete. | Yes |

### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget update

The widget refreshes to reflect the removal.

## Routing notes
This tool is exclusively called by the `manage_mcp_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_mcp_registration`](manage_mcp_registration.md) | The launcher tool that opens the registration widget |
| [`save_mcp_registration`](save_mcp_registration.md) | Creates or updates a registration |
| [`test_mcp_registration_connection`](test_mcp_registration_connection.md) | Tests connectivity to a server |

## Data mutation classification
**Write (destructive delete).** Permanently removes an external MCP server registration from the org-scoped registration store.
