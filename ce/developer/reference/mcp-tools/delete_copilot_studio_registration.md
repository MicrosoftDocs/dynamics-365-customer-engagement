---
title: Delete MCS Agent Registration
description: Learn how to use the Delete MCS Agent Registration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Delete MCS Agent Registration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you remove a Copilot Studio agent registration from the registration management widget.

## What it does
When you select Delete on an existing Copilot Studio agent registration in the management widget, this tool removes it from your Dynamics 365 environment. The agent delegation is immediately unregistered and the Service Agent can no longer hand off questions to it.

The deletion refreshes the tool list so the removed agent's tool is no longer available in future conversations.

## Try prompts like
Not applicable. This tool is called automatically when you delete a registration from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget updates to confirm the deletion succeeded and removes the entry from the list. If the deletion fails (for example, the registration was already removed), the widget displays an error message.

## Helpful tips
- Deletion is immediate and permanent. There is no undo.
- After deleting a registration, the Service Agent can no longer delegate questions to that Copilot Studio agent.
- Deleting a registration frees up a slot toward the 10-registration cap for your environment.

## What happens next
After deleting, the registration widget returns to the list view. You can:

- "Add a new Copilot Studio agent"
- "Manage my remaining registrations"

## Does this change data?
**Yes, this changes data.**

Deleting a registration permanently removes a configuration record from your Dynamics 365 environment.

## Prerequisites
This tool requires the following:

- Copilot extensibility with Copilot Studio to be configured. Requires the System Administrator or Copilot Service administrator role

Learn more in [Extend Copilot with Copilot Studio](/dynamics365/customer-service/administer/extend-copilot-with-copilot-studio).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete MCS Agent Registration |
| Internal tool name | `delete_copilot_studio_registration` |
| Purpose | Removes a Copilot Studio (MCS) agent registration by ID |

## Tool behavior
Removes a Copilot Studio (MCS) agent registration by ID. This is a widget support tool invoked automatically when users interact with the extensibility registrations widget. It is not intended for direct invocation by the model.

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
| `id` | `id` (UUID, required). The unique identifier of the agent registration to delete. | Yes |

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
This tool is exclusively called by the `manage_copilot_studio_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | The launcher tool that opens the registration widget |
| [`save_copilot_studio_registration`](save_copilot_studio_registration.md) | Creates or updates an agent registration |
| [`test_copilot_studio_registration_connection`](test_copilot_studio_registration_connection.md) | Tests agent reachability |

## Data mutation classification
**Write (destructive delete).** Permanently removes a Copilot Studio agent registration from the org-scoped registration store.
