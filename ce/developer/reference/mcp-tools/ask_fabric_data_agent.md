---
title: Ask Fabric data agent
description: Learn how to use the Ask Fabric data agent capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Ask Fabric data agent

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want analysis, trends, or a report over your own business records or quality-evaluation results. The assistant forwards your question to your organization's Microsoft Fabric data agent and returns its answer.

## What it does

The assistant sends your question to your organization's Microsoft Fabric data agent and returns the agent's answer directly in chat. Use it for highlights and lowlights, what improved or declined and why, emerging patterns, recommendations, or a forecast of future performance across a timeframe.

The Fabric data agent runs against your organization's own data in Microsoft Fabric. The assistant calls it on your behalf using your identity, so you only see results you're allowed to see.

## Try prompts like

- What are the highlights and lowlights of my cases this quarter?
- Show me quality-evaluation trends over the last 30 days.
- Which topics are driving the most escalations this month?
- What improved and what declined in my team's performance, and why?
- Forecast next month's case volume based on recent trends.
- Summarize emerging patterns in customer feedback this week.

## What you'll see in chat

The assistant returns the Fabric data agent's answer as text in the chat response. The answer is presented as received from the Fabric data agent, without an interactive widget.

## Helpful tips

- Be specific about the timeframe (for example, "last 30 days" or "this quarter") to get a focused answer.
- Ask one analytical question at a time for the clearest response.
- Results depend on the data your organization has published to its Fabric data agent.
- You normally don't need to provide an endpoint—the server resolves your organization's Fabric data agent automatically. Only paste a Fabric MCP URL if you're explicitly told to.

## What happens next

After the answer appears, you can continue with prompts like:

- Break that down by team.
- Compare this quarter to last quarter.
- What's driving that decline?
- Give me recommendations based on those trends.

## Does this change data?

**This step is read-only.**

The tool sends your question to the Fabric data agent and returns its answer. It doesn't create, update, or delete any records.

## Prerequisites

This tool requires the following:

- Your organization must have a Microsoft Fabric data agent published as an MCP endpoint. The server resolves that endpoint from, in order: an explicit `fabricMcpUrl` passed on the call, the `FABRIC_AGENT_MCP_URL` server environment variable, or the organization's `msdyn_GetQEAFabricConfiguration` configuration.
- The caller must hold the `prvReadmsdyn_dataanalyticsreport_qualityevaluationagent` privilege. This acts as a discovery gate; Microsoft Fabric enforces its own workspace access controls at call time.
- `AUTH_MODE=entra` with the first-party app pre-authorized for the Fabric data-agent scope. The on-behalf-of exchange to `https://api.fabric.microsoft.com/.default` runs automatically per request; no per-user setup is required.

Learn more in [Fabric data agent integration](/dynamics365/customer-service/administer/configure-customer-service-mcp-server).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Ask Fabric data agent |
| Internal tool name | `ask_fabric_data_agent` |
| Purpose | Forwards a user's analytical question to the organization's Microsoft Fabric data agent and returns its answer verbatim |

## Tool behavior

Forwards the user's question to the organization's Microsoft Fabric data agent over the Model Context Protocol and returns the agent's answer verbatim. The endpoint resolves from an explicit `fabricMcpUrl`, then the `FABRIC_AGENT_MCP_URL` server environment variable, then the organization's `msdyn_GetQEAFabricConfiguration` configuration. The call is authenticated with an on-behalf-of token for the caller against the Fabric scope, so the data agent sees only what the caller is entitled to.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | The tool only reads; it doesn't modify any records. |
| `openWorldHint` | `true` | The tool makes outbound network calls to the external Fabric data-agent endpoint. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |

## Input concepts

### Question

| Input | Description | Required |
|---|---|---|
| `userQuestion` | The user's question to send to the Fabric data agent. Must not be empty. | Yes |

### Endpoint override

| Input | Description | Required |
|---|---|---|
| `fabricMcpUrl` | The full HTTPS URL of the Fabric data-agent MCP endpoint. Omit in almost all cases—the server resolves the endpoint automatically. Set it only when the user explicitly pastes a Fabric MCP URL. | No |

## Response and UI behavior

This tool returns a text response containing the Fabric data agent's answer. It doesn't render an interactive app-in-chat component.

### Response type

Text

The chat response contains the Fabric data agent's answer as returned by the agent. If the agent returns no answer, the assistant reports that no result was available.

## Routing notes

Use `ask_fabric_data_agent` when:

- The user asks for analysis, trends, highlights and lowlights, patterns, recommendations, or a forecast over their own business records or quality-evaluation results.
- The question is analytical and spans a timeframe rather than a single record.

Don't use `ask_fabric_data_agent` when:

- The user wants a summary of one specific case, record, or timeline—route to the matching summarize tool.
- The user wants to read or list specific records—route to the matching query tool.
- The user wants to change data—route to the matching action tool.

## Related tools

| Tool | Relationship |
|---|---|
| [`summarize_entity_timeline`](summarize_entity_timeline.md) | Summarizes activity on a single record. Use `ask_fabric_data_agent` instead for cross-record analytics over a timeframe |
| [`get_case_highlights`](get_case_highlights.md) | Returns triage signals for a case. Complementary to organization-wide Fabric analytics |

## Data mutation classification

Read-only.

The tool sends the user's question to the Fabric data agent and returns its answer. It performs no create, update, or delete operations.
