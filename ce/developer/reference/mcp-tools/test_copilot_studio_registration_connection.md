---
title: Test MCS Agent Connection
description: Learn how to use the Test MCS Agent Connection capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Test MCS Agent Connection

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you test connectivity to a Copilot Studio agent from the registration management widget.

## What it does
When you select Test Connection in the Copilot Studio agent registration form, this tool verifies that the Service Agent can reach the selected bot. It performs a three-stage check: fetching the bot's identity and metadata from Dataverse, resolving the Power Platform environment, and verifying reachability via the Agents SDK.

If the connection succeeds, the tool returns the bot's metadata snapshot including its display name, description, instructions, schema name, and environment ID. This metadata is used to populate the registration form. If the connection fails, the tool returns a staged error indicating exactly which step failed (for example, bot not found, bot inactive, environment not resolved, or SDK unreachable).

## Try prompts like
Not applicable. This tool is called automatically when you test a connection from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget shows the test result inline. On success, you see the bot's metadata pre-filled in the registration form, including its display name, schema name, and a read-only view of the bot's description and instructions. On failure, you see a specific error message describing which stage of the connection test failed.

## Helpful tips
- Always test before saving. The bot metadata from a successful test populates required fields in the registration form.
- If the test fails at the "bot not found" stage, verify the bot ID is correct and the bot has been published in Copilot Studio.
- If the test fails at the "bot inactive" stage, re-publish the bot in Copilot Studio to activate it.
- If the test fails with a consent or permission error, check that the required Power Platform permissions are in place for your user account.
- The test has a timeout limit. If the Agents SDK is slow to respond, the test may fail even if the bot is technically reachable.

## What happens next
After a successful test, you can:

- "Save this registration"
- "Review the bot metadata"
- "Write a description for this agent"

## Does this change data?
**No, this does not change data.**

Testing a connection is read-only. It fetches metadata and verifies reachability but does not modify any configuration.

## Prerequisites
This tool requires the following:

- Copilot extensibility with Copilot Studio

Learn more in [Extend Copilot with Copilot Studio](/dynamics365/customer-service/administer/extend-copilot-with-copilot-studio).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Test MCS Agent Connection |
| Internal tool name | `test_copilot_studio_registration_connection` |
| Purpose | Fetches a Copilot Studio bot's identity, description, and instructions from Dataverse and verifies reachability via the Agents SDK |

## Tool behavior
Fetches a Copilot Studio bot's identity, description, and instructions from Dataverse and verifies reachability via the Agents SDK. Returns the metadata snapshot that `save_copilot_studio_registration` persists. This is a widget support tool invoked automatically from the registration management widget.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse + Power Platform). |

## Input concepts
### Bot ID

| Input | Description | Required |
|---|---|---|
| `botId` | `botId` (UUID, required). The Dataverse `bot.botid` of the Copilot Studio bot to test. | Yes |

### Environment ID

| Input | Description | Required |
|---|---|---|
| `environmentId` | `environmentId` (UUID, optional). The Power Platform environment GUID. When supplied, skips the environment-resolver API call. | No |

### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget update with connection test results

Returns the bot's metadata snapshot (name, description, instructions, schema name) and connection status. The widget displays success or a classified error.

## Routing notes
This tool is exclusively called by the `manage_copilot_studio_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | The launcher tool that opens the registration widget |
| [`save_copilot_studio_registration`](save_copilot_studio_registration.md) | Saves the registration with the tested metadata |
| [`list_copilot_studio_registration_bots`](list_copilot_studio_registration_bots.md) | Lists available bots for the bot picker |
| [`delete_copilot_studio_registration`](delete_copilot_studio_registration.md) | Removes an agent registration |

## Data mutation classification
**Read-only.** Tests connectivity and fetches metadata without modifying any data.
