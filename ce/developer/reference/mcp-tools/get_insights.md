---
title: Get insights
description: Learn how to use the Get insights capability in Dynamics 365 Customer Service.
ms.date: 09/10/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: ahedau
ms.author: ahedau
ms.reviewer: laalexan
---

# Get insights

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want the assistant to show AI-generated insights about a contact or account from chat.

## What it does

Returns the AI-generated insights your organization has configured for a contact or an account—signals such as engagement, competitor risk, and service health—and renders them as cards in chat.

Your administrator decides which insights exist and which tables they apply to. This capability serves the Customer Service audience, so it returns only insight definitions your administrator tagged for service. Definitions tagged for another audience—such as sales—and definitions left untagged aren't returned here. Up to 50 insights are shown at once; if more apply to the record, the assistant says how many it's showing out of the total. Name a single insight to see just that one.

## Try prompts like

- Get me insights about account Contoso.
- Show insights for the contact Maria Campbell.
- Just the engagement insight for account Fabrikam.
- What is the competitor risk for Contoso?

## What you'll see in chat

An insights component with a header for the contact or account, followed by cards. Depending on how each insight is configured, a card can show a KPI value, a trend, a health signal, an alert, or a short written summary.

If you asked for one named insight, only that card is shown.

## Helpful tips

- Say whether you mean a contact or an account when the name could be either.
- If several records share a name, give the full name or open the record first so the assistant can use it.
- To narrow a long list, name the insight you want—for example, "just the engagement insight."
- Insights are read from what your administrator configured. If a card you expect is missing, it usually isn't set up for that table yet, or it's tagged for a different audience than customer service.

## What happens next

- Ask for a single insight by name to focus the view.
- Ask for the same insights on a different contact or account.
- Open the record to act on what an insight surfaced.

## Does this change data?

**No, getting insights doesn't change data.**

## What you can do from the app-in-chat component

From the insights component in chat, you can:

- Review the entity header confirming which contact or account the insights belong to.
- Read each insight card, including KPI values, trends, health signals, and alerts.
- Compare several insights side by side without leaving chat.
- Ask a follow-up prompt to narrow to one insight by title.

## Prerequisites

This tool requires the following:

- CE Foundation insights installed and turned on for your organization.
- At least one insight definition that is active, enabled, and provisioned for the table you're asking about (`contact` or `account`), **and tagged for the service audience**.

If no provisioned, service-tagged insight definition exists for the table, the Insights tab isn't offered on the record view, and the assistant doesn't return insight cards. A table whose only definitions are tagged for another audience, or left untagged, is treated the same way as a table with no definitions at all.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Insights |
| Internal tool name | `get_insights` |
| Purpose | Fetches AI-generated insights about a specific contact or account from the CE Foundation insights service and renders them as cards |

## Tool behavior

Fetches AI-generated insights about a specific contact or account from the Insights service. Use it whenever the user asks for insights, signals, competitor risk, engagement, service health, analysis, or trends about a named contact or account, in preference to generic summaries. Provide `entityType` and either `entityName` to look up or `entityId` when the GUID is already known. CE Foundation resolves which service-tagged insights apply to the record; definitions tagged for another audience and untagged definitions are excluded. Up to 50 insights are returned, and the response reports how many were shown out of the total when more matched. Set `insightTitle` to narrow the response to a single named insight.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Entity type

| Input | Description | Required |
|---|---|---|
| `entityType` | `entityType` (required). Whether the insight target is a `contact` or an `account`. | Yes |

### Subject identifier

Provide one of the following. If both are omitted, the tool returns a validation error asking for a name or a GUID.

| Input | Description | Required |
|---|---|---|
| `entityName` | `entityName` (optional). The contact or account name to look up. Provide this or `entityId`. | No |
| `entityId` | `entityId` (optional). The contact or account GUID, if already known. Provide this or `entityName`. | No |

### Insight title

| Input | Description | Required |
|---|---|---|
| `insightTitle` | `insightTitle` (optional). Fetch a single insight by partial title, for example `Engagement`. When set, only the matching insight is returned. | No |

## Response and UI behavior

### Response type

Interactive component

Renders the insights component: an entity header for the resolved contact or account, followed by insight cards. When `insightTitle` matches, a single card is rendered instead of the full set.

## Routing notes

Use `get_insights` when:

- The user asks for **insights, signals, competitor risk, engagement, service health, or trends** about a named contact or account.
- The user asks for one named insight on a record, such as "just the engagement insight."

Don't use `get_insights` when:

- The user wants a **general summary** of an account or contact—route to `summarize_account` or `summarize_contact`.
- The user wants the **record's own fields**—route to `get_account` or `get_contact`.
- The user wants to **find records**—route to `list_accounts`.

## Related tools

| Tool | Relationship |
|---|---|
| [`summarize_account`](summarize_account.md) | Summarizes an account's own data. Use for a general summary; use `get_insights` for configured insight signals |
| [`summarize_contact`](summarize_contact.md) | Summarizes a contact's own data |
| [`get_account`](get_account.md) | Retrieves the account record's fields |
| [`get_contact`](get_contact.md) | Retrieves the contact record's fields |
| [`list_accounts`](list_accounts.md) | Finds accounts when the subject record isn't known yet |

## Data mutation classification

**Read-only.** doesn't create or modify any records.
