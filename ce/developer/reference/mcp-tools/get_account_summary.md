---
title: Get an account summary
description: Learn how to get an account summary in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get an account summary

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to summarize one account as a concise account brief.

## What it does

The assistant summarizes one account as a concise account brief and returns a text response with structured content for agent orchestration.

## Try prompts like

- Summarize the Northpeak Manufacturing account.
- Give me an overview of this account before my QBR.
- Brief me on the account's current status and relationship signals.
- Show me the account summary for Contoso.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve ambiguous record names before calling tools that require identifiers.
- Use related record-view tools when you need to inspect the full Dataverse form.
- Confirm write actions before changing account or sales record data.

## What happens next

After the response appears, you can continue with prompts like:

- Open this account.
- Catch me up on recent account activity.
- Add a note.
- Draft a follow-up email.

## Does this change data?

**No, get_account_summary doesn't change data.**

This tool is read-only and doesn't modify records.

## Prerequisites

This tool requires access to Dynamics 365 Sales records for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Account summary |
| Internal tool name | `get_account_summary` |
| Purpose | summarizes one account as a concise account brief. |

## Tool behavior

The tool summarizes one account as a concise account brief. It is text-only and returns structured content for the requested Sales operation.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Sales context

| Input | Description | Required |
|---|---|---|
| `accountId` | Resolved account GUID to summarize. Resolve names before calling this tool. | Yes |
| `appId` | Model-driven app ID for the SalesRecordSummary custom API. Optional—when omitted, the server uses the configured Sales app context and otherwise falls back to the Dataverse default app. Prefer the caller's current app context; don't hardcode Sales Hub. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content from the SalesRecordSummary custom API.

## Routing notes

Use `get_account_summary` when the user asks for this specific Sales capability. Don't use `get_account_summary` for support case workflows or unrelated customer-service records.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_account`](get_account.md) | Opens the full Dataverse account form |
| [`list_entity_records`](list_entity_records.md) | Finds sales records by entity type |
| [`get_account_catchup`](get_account_catchup.md) | Provides recent account context when the seller asks what changed |

## Data mutation classification

Read-only.
