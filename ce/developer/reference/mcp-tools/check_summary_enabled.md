---
title: Check whether AI summaries are enabled
description: Learn how to use the Check whether AI summaries are enabled capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Check whether AI summaries are enabled

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with check whether AI summaries are enabled from chat.

## What it does
Checks whether on-demand case summary and conversation summary features are enabled before selecting the correct summary path.

## Try prompts like
- "Can I summarize cases in this environment?"
- "Are conversation summaries enabled?"
- "Check summary settings"
- "Is on-demand summary turned on?"

## What you see in chat
The assistant receives the organization-level settings for case and conversation summaries.

## Helpful tips
- This is a pre-check for summary requests.
- If case summaries are off, use the text-only case summary fallback.
- If conversation summaries are off, the assistant tells the user the feature is disabled.

## What happens next
- "Summarize the case with the configured path"
- "Use the text-only fallback when case summaries are disabled"
- "Tell the user when conversation summaries are disabled"

## Does this change data?

No. Checking summary settings doesn't change data.

## Prerequisites
This tool requires the following:

- Copilot case summaries to be enabled

Learn more in [Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Check Summary Enabled |
| Internal tool name | `check_summary_enabled` |
| Purpose | Returns the org's on-demand summary settings |

## Tool behavior
Returns the org's on-demand summary settings. Pre-check this BEFORE calling `summarize_case` or `summarize_conversation`. `caseSummaryEnabled` gates `summarize_case` and `summarize_case_text`; `conversationSummaryEnabled` gates `summarize_conversation`. If a flag is false, do NOT call the corresponding summary tool.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
### Response type

Text-only

Returns a JSON-like structure with `caseSummaryEnabled` and `conversationSummaryEnabled` boolean flags. No interactive component is rendered.

## Routing notes
Use `check_summary_enabled` when:

- Starting any flow that may call `summarize_case` or `summarize_conversation`
- The assistant needs to determine which summary path to use

Do **not** call `check_summary_enabled` repeatedly in the same session; the flags are stable per org setting.

## Related tools
| Tool | Relationship |
|---|---|
| [`summarize_case`](summarize_case.md) | Case AI summary with widget. Requires `caseSummaryEnabled: true` |
| [`summarize_case_text`](summarize_case_text.md) | Text-only case summary fallback. Use when `caseSummaryEnabled: false` |
| [`summarize_conversation`](summarize_conversation.md) | Conversation summary. Requires `conversationSummaryEnabled: true` |

## Data mutation classification
**Read-only.** Reads org settings. Doesn't modify any records.
