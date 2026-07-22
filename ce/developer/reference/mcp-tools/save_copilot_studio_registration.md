---
title: Save MCS Agent Registration
description: Learn how to use the Save MCS Agent Registration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save MCS Agent Registration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you add or edit a Copilot Studio agent registration from the registration management widget.

## What it does
When you fill out the registration form in the Copilot Studio agent management widget and select Save, this tool persists the registration to your Dynamics 365 environment. It handles both creating new registrations and updating existing ones.

The tool validates the bot identity and schema name, enforces the registration cap (10 per environment), and prevents duplicate bot IDs or schema names. On success, it stores the registration and refreshes the Service Agent's tool list so the new agent delegation becomes available.

## Try prompts like
Not applicable. This tool is called automatically when you save a registration from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget updates to confirm the save succeeded, showing the registration ID and whether it was created or updated. If validation fails (for example, a duplicate bot ID or schema name), the widget displays an error message explaining what to fix.

## Helpful tips
- You must run Test Connection before saving a new registration. The bot metadata from the test is used to populate required fields.
- Each bot can only be registered once. Remove the existing registration first if you need to re-register the same bot.
- The description you provide is what the Service Agent sees when deciding whether to delegate a question to this agent. Make it clear and specific.
- Schema names must be unique across all Copilot Studio registrations in your environment.

## What happens next
After saving, the registration widget returns to the list view. You can:

- "Test the connection again"
- "Edit the registration I just saved"
- "Add another Copilot Studio agent"

## Does this change data?
**Yes, this changes data.**

Saving a registration creates or updates a configuration record in your Dynamics 365 environment and refreshes the Service Agent's available tool list.

## Prerequisites
This tool requires the following:

- Copilot extensibility with Copilot Studio to be configured. Requires the System Administrator or Copilot Service administrator role

Learn more in [Extend Copilot with Copilot Studio](/dynamics365/customer-service/administer/extend-copilot-with-copilot-studio).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Save MCS Agent Registration |
| Internal tool name | `save_copilot_studio_registration` |
| Purpose | Persists a new or updated Copilot Studio (MCS) agent registration |

## Tool behavior
Persists a new or updated Copilot Studio (MCS) agent registration. This is a widget support tool invoked automatically when users interact with the extensibility registrations widget. It is not intended for direct invocation by the model.

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
| `botId`, `name`, `displayName`, `description`, `inputParameters`, `environmentId`, `schemaName`, `m365AppId` | Contains the agent registration details including `botId` (Dataverse bot GUID), `name` (unique identifier), `displayName`, `description`, `inputParameters`, `environmentId` (Power Platform environment), `schemaName`, and `m365AppId`. | No |

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
This tool is exclusively called by the `manage_copilot_studio_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | The launcher tool that opens the registration widget |
| [`delete_copilot_studio_registration`](delete_copilot_studio_registration.md) | Removes an agent registration |
| [`test_copilot_studio_registration_connection`](test_copilot_studio_registration_connection.md) | Tests agent reachability before saving |
| [`list_copilot_studio_registration_bots`](list_copilot_studio_registration_bots.md) | Lists available bots for the bot picker |

## Data mutation classification
**Write (upsert).** Creates or updates a Copilot Studio agent registration in the org-scoped registration store.
