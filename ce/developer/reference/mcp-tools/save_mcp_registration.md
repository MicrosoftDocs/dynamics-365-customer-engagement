---
title: Save External MCP Registration
description: Learn how to use the Save External MCP Registration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save External MCP Registration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you add or edit an external MCP tool server registration from the registration management widget.

## What it does
When you fill out the registration form in the MCP server management widget and select Save, this tool persists the registration to your Dynamics 365 environment. It handles both creating new registrations and updating existing ones.

The tool validates the endpoint URL for security, checks that the authentication scope is allowed, enforces the registration cap (20 per environment), and prevents duplicate endpoints or tool prefixes. On success, it stores the registration and refreshes the Service Agent's tool list so the new server's tools become available.

## Try prompts like
Not applicable. This tool is called automatically when you save a registration from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget updates to confirm the save succeeded, showing the registration ID and whether it was created or updated. If validation fails (for example, a duplicate endpoint or a reserved tool prefix), the widget displays an error message explaining what to fix.

## Helpful tips
- You must run Test Connection before saving a new registration. The tool snapshot from the test is what gets persisted.
- Each server endpoint can only be registered once. Remove the existing registration first if you need to re-register the same URL.
- Tool prefixes must be unique across all registrations in your environment.
- Saving a registration invalidates the tool cache, so the updated tools take effect on the next conversation.

## What happens next
After saving, the registration widget returns to the list view. You can:

- "Test the connection again"
- "Edit the registration I just saved"
- "Add another MCP server"

## Does this change data?
**Yes, this changes data.**

Saving a registration creates or updates a configuration record in your Dynamics 365 environment and refreshes the Service Agent's available tool list.

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Save External MCP Registration |
| Internal tool name | `save_mcp_registration` |
| Purpose | Persists a new or updated external MCP server registration |

## Tool behavior
Persists a new or updated external MCP server registration. This is a widget support tool invoked automatically when users interact with the extensibility registrations widget. It is not intended for direct invocation by the model.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates or updates registration data. |
| `destructiveHint` | `false` | Updates are non-destructive (upsert pattern). |
| `idempotentHint` | `true` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Registration object

| Input | Description | Required |
|---|---|---|
| `displayName`, `name`, `endpoint`, `authScope`, `mode`, `toolPrefix`, `tools` | Contains the server registration details including `displayName`, `name` (unique identifier), `endpoint` (HTTPS URL), `authScope` (Entra OBO target scope), `mode`, `toolPrefix`, and `tools` array. | No |

### Registration ID

| Input | Description | Required |
|---|---|---|
| `id` | `id` (optional). When provided, updates an existing registration; when omitted, creates a new one. | No |

### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget update

The widget refreshes to show the saved registration.

## Routing notes
This tool is exclusively called by the `manage_mcp_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_mcp_registration`](manage_mcp_registration.md) | The launcher tool that opens the registration widget |
| [`delete_mcp_registration`](delete_mcp_registration.md) | Removes a registration |
| [`test_mcp_registration_connection`](test_mcp_registration_connection.md) | Tests connectivity before saving |

## Data mutation classification
**Write (upsert).** Creates or updates an external MCP server registration in the org-scoped registration store.
