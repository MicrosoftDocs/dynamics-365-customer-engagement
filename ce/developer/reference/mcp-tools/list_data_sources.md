---
title: List data sources
description: Learn how to use the List data sources capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# List data sources

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to know which data sources feed your Customer Insights environment.

## What it does

This capability lists the distinct data sources ingested into Customer Insights. For each source it shows the source entity, how many records it contributed, and whether the unified profile carries columns from that source. Use it to understand what data feeds Customer Insights, which upstream systems are connected, or why a particular source's fields are missing from profiles.

If a source resolved no profile columns, the assistant flags it with a warning so you can follow up.

## Try prompts like

- Which data sources are ingested into Customer Insights?
- List the Customer Insights data sources feeding this environment.
- What upstream systems feed data into our Customer Insights instance?
- How many records did each data source contribute?
- Which sources aren't contributing any profile columns?

## What you'll see in chat

The assistant replies with a text list of the ingested data sources, each with its source entity, record count, and whether it contributes profile columns. Any source that resolved no profile columns is called out as a warning.

## Helpful tips

- This capability needs no inputs—just ask what feeds Customer Insights.
- A warning that a source has no profile columns often explains why that source's fields are missing from unified profiles.
- Use a source entity name from the list with `get_customer_by_source_id` to resolve a specific record to its unified customer.

## What happens next

From the source list you can continue with prompts like:

- Resolve a source record to its unified Customer Insights customer.
- Show me everything Customer Insights knows about a customer.
- Which segments is a customer in?

## Does this change data?

**No, listing data sources doesn't change data.**

This capability only reads the ingested-source information from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with data sources ingested, and you need permission to read the source-key mapping and unified profile metadata.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List Data Sources |
| Internal tool name | `list_data_sources` |
| Purpose | Lists the data sources ingested into Customer Insights with record counts and profile-column coverage |

## Tool behavior

Lists the distinct data sources ingested into Customer Insights (derived from `msdynci_alternatekey`), each with its source entity, record count, and whether the unified profile carries columns from that source. Returns warnings for sources that resolved no profile columns. Takes no inputs.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Customer Insights through Dataverse). |

## Input concepts

### Inputs

This tool takes no inputs. Just ask which data sources feed Customer Insights.

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Text list of data sources.

Each entry shows the source entity, record count, and whether it contributes profile columns, with warnings for sources that resolved no profile columns.

## Routing notes

Use `list_data_sources` for:

- A request about what data feeds Customer Insights, which sources are connected, or why a source's fields are missing from profiles.

Don't use `list_data_sources` when:

- The prompt wants a specific customer's data—route to `get_customer_details` or a specialist reader.
- The prompt provides a source record ID to resolve—route to `get_customer_by_source_id`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_by_source_id`](get_customer_by_source_id.md) | Resolves a record from one of these sources to a unified customer |
| [`get_customer_details`](get_customer_details.md) | Shows which sources stitched into one customer's profile |
| [`find_customer`](find_customer.md) | Finds a specific customer by name |

## Data mutation classification

Read-only.

This tool only reads ingested-source information from Customer Insights and never changes data.
