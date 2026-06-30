---
title: Query Dataverse Data
description: Learn how to use the Query Dataverse Data capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Query Dataverse Data

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to ask ad-hoc questions about your Dynamics 365 data when no other specific capability covers your question.

## What it does
The assistant translates your natural-language question into a database query and returns the answer from your Dynamics 365 data. This works for ad-hoc lookups, counts, filtered queries, and questions that span multiple related records.

This is a general-purpose fallback - the assistant tries more specific capabilities first (like case lookup, email search, or knowledge base search). It uses this when your question doesn't fit neatly into a specific tool.

## Try prompts like
- "What is the origin of case CAS-01010-A0A0A0?"
- "How many active cases were created this week?"
- "What is the SLA status for this case?"
- "List contacts on account Contoso"
- "How many cases have priority high and status active?"
- "What custom field values are set on this case?"
- "Show me cases linked to this email"
- "What is the severity code for this case?"

## What you see in chat
The assistant returns the answer as text in the chat based on the query results. Depending on the question, you might see a single value, a count, or a list of records.

## Helpful tips
- Be specific in your question. Include entity names and relationship details when relevant (for example, "contacts on account Contoso" rather than just "contacts").
- For case lookups, priority values are `High`, `Normal`, or `Low`. If you say "critical," the assistant interprets that as severity, not priority.
- If you get unexpected results, try rephrasing your question with more context.
- For common queries (listing cases, searching emails, finding knowledge articles), use the dedicated capabilities instead - they return richer results with interactive components.

> [!TIP]
> This capability works best for questions that other tools can't answer, such as looking up custom fields, counting records across entities, or querying relationships between different record types.

## What happens next
After receiving the answer, you can continue with prompts like:

- "Tell me more about that record"
- "Open case CAS-01010-A0A0A0"
- "Show me the timeline for that account"
- "Update the priority to high"

## Does this change data?
No. This doesn't change data.

This capability only reads data from Dynamics 365. It can't create, update, or delete records.

## Prerequisites
This tool requires the following:

- Ask a question capability to be enabled in the Copilot help pane. Without the CustomerServiceQnA skill configured, ad-hoc Dataverse queries will fail

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features), and [Enable features in Copilot pane](/dynamics365/contact-center/administer/copilot-enable-help-pane).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Query Dataverse Data |
| Internal tool name | `answer_service_question` |
| Purpose | Answers natural-language questions about Dataverse data by translating the question into FetchXML and executing it via the CustomerServiceQnA skill |

## Tool behavior
Answers natural-language questions about Dataverse data by translating the question into FetchXML and executing it via the CustomerServiceQnA skill. This is a fallback tool with the lowest routing priority - it handles ad-hoc field lookups, counts, filtered queries, and relationship-traversal queries that dedicated tools cannot cover.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool queries Dataverse data without modification. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Query

| Input | Description | Required |
|---|---|---|
| `queryText` | `queryText` (required, 1-2000 characters). Natural-language question to answer from Dataverse data. Phrase the question clearly, including entity names and relationship context. | Yes |

### Execution options

| Input | Description | Required |
|---|---|---|
| `options` | `options` (optional). Array of execution modes. `ExecuteFetchXML` (default) generates and executes the query. Omit for dry-run mode. | No |

### Page context

| Input | Description | Required |
|---|---|---|
| `currentPageContext` | `currentPageContext` (optional). JSON object string with the user's current view context (entity, record ID, filters, view name, selected IDs). Include every piece of context available for more accurate query generation. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool translates the natural-language question into FetchXML, executes it via the Dataverse Copilot endpoint (`POST /api/copilot/v1.0/queryskillstructureddata` with skill `CustomerServiceQnA`), and returns the query results as text. The `structuredContent` includes up to 10 result rows; the full result set (up to 30 rows) is included in the model narration.

## Routing notes
`answer_service_question` has the **lowest routing priority**. Always prefer dedicated tools first:

- `get_case`, `list_cases`, `search_cases` for case queries
- `get_activity_timeline` for activity history
- `list_emails` for email queries
- `search_knowledge_articles` for knowledge base queries
- `summarize_account`, `summarize_contact` for account/contact details
- `search_entities` for entity lookup

Use `answer_service_question` **only** when:

- No dedicated tool covers the specific query (ad-hoc field lookups, custom fields, counts)
- The query involves relationship traversal that dedicated tools cannot expand
- The user asks about entity fields or metadata not exposed by other tools

**Vocabulary note:** Priority values are `High`, `Normal`, `Low`. "Critical" maps to `severitycode`, not priority.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_cases`](list_cases.md) | Preferred for case listing and filtering |
| [`get_case`](get_case.md) | Preferred for single-case detail |
| [`search_cases`](search_cases.md) | Preferred for full-text case search |
| [`get_activity_timeline`](get_activity_timeline.md) | Preferred for activity history |
| [`list_emails`](list_emails.md) | Preferred for email queries |
| [`search_knowledge_articles`](search_knowledge_articles.md) | Preferred for knowledge base queries |
| [`search_entities`](search_entities.md) | Preferred for entity lookup |

## Data mutation classification
Read-only.

Queries Dataverse data without modification. The tool sends a `POST` to the Dataverse Copilot `queryskillstructureddata` endpoint, which internally generates and executes FetchXML. The only privilege required is `prvReadIncident` as a discovery floor; the CustomerServiceQnA skill enforces fine-grained entity-level read privileges at call time. The tool doesn't support creating or updating records.
