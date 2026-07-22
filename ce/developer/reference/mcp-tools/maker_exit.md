---
title: Exit Configuration Mode
description: Learn how to exit maker configuration mode and return to the default Dynamics 365 agent tool set.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Exit Configuration Mode

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
## Try prompts like
- "I'm done configuring"
- "Exit configuration mode"
- "Go back to normal"
- "Done with setup"
- "Return to agent mode"

## What you'll see in chat
The agent confirms that configuration mode has been exited and that the standard tool set will be restored on the next turn.

## Helpful tips
- You can re-enter configuration mode at any time by asking the agent to configure or manage tools.
- Changes you made in configuration mode (such as enabling or disabling tools) take effect immediately for the agent.
- If the agent still shows configuration tools after exiting, send one more message to trigger the tool-cache refresh.

## What happens next
After exiting configuration mode:

- "Show my cases"
- "What's in my inbox?"
- "Summarize this case"

## Does this change data?
**No, this does not change Dynamics 365 data.**

It exits the current configuration session only. No records in Dynamics 365 are modified.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Exit Configuration Mode |
| Internal tool name | `maker_exit` |
| Purpose | Exits maker/admin configuration mode and returns to the default agent tool set |

## Tool behavior
Exits maker/admin configuration mode and returns to the default agent tool set. Call this when the user signals they are finished with configuration tasks.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | `true` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | `false` | Does not call external systems outside the configured Dynamics 365 scope. |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns a confirmation message that configuration mode has been exited and all standard agent tools are now available.

## Routing notes
Use `maker_exit` when:

- The user says 'I'm done configuring', 'exit configuration', 'go back to normal', or otherwise signals they are finished with configuration tasks

Don't use `maker_exit` when:

- The user is still working on configuration tasks

## Related tools
| Tool | Relationship |
|---|---|
| [`browse_agent_config_options`](browse_agent_config_options.md) | Entry point for configuration discovery. Use before exiting |
| [`save_agent_config`](save_agent_config.md) | Saves org-level configuration. Can be used before exiting |
| [`save_profile_config`](save_profile_config.md) | Saves profile-scoped configuration. Can be used before exiting |

## Data mutation classification
**Read-only for Dynamics 365 data.** Clears the maker/admin mode flag for the current session state.
