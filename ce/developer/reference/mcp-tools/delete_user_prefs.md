---
title: Delete My Preference
description: Learn how to remove a personal layout preference and return to the default view.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Delete My Preference

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to remove a personal layout preference and revert to the org or profile default.

## What it does
The assistant removes one of your personal layout preferences by its scope key. After removal, the affected grid, form, or timeline reverts to the profile-level configuration (if one exists), the org-level configuration, or the system default. This action requires confirmation.

## Try prompts like
- "Remove my personal case grid layout"
- "Reset my saved preference for the case form"
- "Forget my customization on the timeline"
- "Delete my preference for cases"

## What you'll see in chat
The assistant asks for confirmation before removing the preference. After you confirm, it reports which preference was removed.

## Helpful tips
- Use `list_user_prefs` first to see your active preferences and their scope keys.
- Removal is permanent. The preference cannot be recovered after deletion.
- Only your personal preferences are affected. Org-level and profile-level configurations remain unchanged.

## What happens next
- "Show my preferences" to verify the removal
- "Save a new preference" to create a replacement customization
- "What are the org-level configurations?" to see what you'll fall back to

## Does this change data?
**Yes, this can change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete My Preference |
| Internal tool name | `delete_user_prefs` |
| Purpose | Removes a personal layout preference by scope key |

## Tool behavior
Removes a personal layout preference by scope key. Use when the user asks to remove their own saved layout, reset a personal preference, or forget a previously saved customization. Requires explicit confirmation to prevent accidental deletions.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool permanently removes preference data. |
| `idempotentHint` | `true` | Deleting an already-removed scope has no additional effect. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Scope key

| Input | Description | Required |
|---|---|---|
| `scope` | `scope` (string, required). The scope key to remove (e.g., `grid:incident:*`). Use `list_user_prefs` to discover existing scope keys. | Yes |

### Confirmation

| Input | Description | Required |
|---|---|---|
| `confirm`, `true` | `confirm` (literal `true`, required). Must be explicitly set to `true` to confirm the deletion. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the preference was removed, or an error if the scope key was not found.

## Routing notes
Use `delete_user_prefs` when:

- The user asks to remove or reset a personal preference
- The user says "forget my", "reset my", "remove my preference"
- Always call `list_user_prefs` first if the user hasn't specified a scope key

Don't use `delete_user_prefs` when:

- The user wants to remove an org-level configuration. Use `delete_agent_config` instead.
- The user wants to remove a profile-level configuration. Use `delete_profile_config` instead.
- The user wants to modify (not remove) a preference. Use `save_user_prefs` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_user_prefs`](list_user_prefs.md) | Lists existing preferences to identify scope keys |
| [`save_user_prefs`](save_user_prefs.md) | Creates or updates personal preferences |
| [`delete_agent_config`](delete_agent_config.md) | Removes org-level configurations |
| [`delete_profile_config`](delete_profile_config.md) | Removes profile-level configurations |

## Data mutation classification
Write (destructive).

Permanently removes a personal layout preference for the current user. Does not affect other users or org/profile configurations. The assistant asks for confirmation before executing.
