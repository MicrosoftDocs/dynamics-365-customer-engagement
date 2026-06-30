---
title: List Available MCS Bots
description: Learn how to use the List Available MCS Bots capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Available MCS Bots

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you browse available Copilot Studio bots from the registration management widget.

## What it does
When you open the bot picker in the Copilot Studio agent registration form, this tool queries your Dynamics 365 environment for published, active Copilot Studio bots. It returns the most recently published bots so you can select one to register as a Service Agent delegation.

The tool retrieves bot metadata including display name, schema name, and bot ID. This information is used to populate the registration form when you select a bot.

## Try prompts like
Not applicable. This tool is called automatically when you browse bots from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget displays a list of available bots in a picker within the registration form. Each bot shows its display name and schema name. If no published bots are found in your environment, the picker shows an empty state.

## Helpful tips
- Only published and active bots appear in the list. If you don't see a bot, verify it has been published in Copilot Studio.
- The list shows the most recently published bots first.
- Bots that are already registered do not appear twice, but you can still select a new bot and register it.

## What happens next
After selecting a bot, you can:

- "Test the connection to this bot"
- "Fill in a description and save the registration"

## Does this change data?
**No, this does not change data.**

Listing available bots is read-only. No configuration is modified.

## Prerequisites
This tool requires the following:

- Copilot extensibility with Copilot Studio

Learn more in [Extend Copilot with Copilot Studio](/dynamics365/customer-service/administer/extend-copilot-with-copilot-studio).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Available MCS Bots |
| Internal tool name | `list_copilot_studio_registration_bots` |
| Purpose | Returns up to 50 of the most recently published, active Copilot Studio bots in the maker's selected Dataverse environment |

## Tool behavior
Returns up to 50 of the most recently published, active Copilot Studio bots in the maker's selected Dataverse environment. This is a widget support tool used by the MCS registration form's bot picker. It is not intended for direct invocation by the model.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Power Platform). |

## Input concepts
### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget data (bot list for picker)

Returns bot metadata (ID, name, environment ID) for the widget's bot picker dropdown.

## Routing notes
This tool is exclusively called by the `manage_copilot_studio_registration` widget's bot picker. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | The launcher tool that opens the registration widget |
| [`save_copilot_studio_registration`](save_copilot_studio_registration.md) | Saves the selected bot as a registration |
| [`test_copilot_studio_registration_connection`](test_copilot_studio_registration_connection.md) | Tests bot reachability after selection |

## Data mutation classification
**Read-only.** Lists available Copilot Studio bots from Power Platform without modifying any data.
