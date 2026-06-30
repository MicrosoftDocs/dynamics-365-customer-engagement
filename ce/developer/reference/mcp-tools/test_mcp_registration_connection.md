---
title: Test External MCP Connection
description: Learn how to use the Test External MCP Connection capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Test External MCP Connection

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability works behind the scenes when you test connectivity to an external MCP tool server from the registration management widget.

## What it does
When you select Test Connection in the MCP server registration form, this tool verifies that the Service Agent can reach the external server endpoint. It performs a security check on the URL, obtains an authentication token using the configured scope, and sends a tools/list request to the server.

If the connection succeeds, the tool returns the list of tools the server exposes. This tool snapshot is what gets saved with the registration. If the connection fails, the tool returns a detailed error indicating what went wrong (for example, an unreachable endpoint, authentication failure, or invalid response).

## Try prompts like
Not applicable. This tool is called automatically when you test a connection from the management widget. It is not invoked by typing a prompt.

## What you'll see in chat
The registration widget shows the test result inline. On success, you see a list of available tools from the server with their names and descriptions. On failure, you see an error message describing the connectivity issue.

## Helpful tips
- Always test before saving. The tool snapshot from a successful test is required for new registrations.
- The test has a 15-second timeout. If the server is slow to respond, it may fail even if the server is technically reachable.
- Authentication failures usually mean the configured auth scope does not match the server's Entra app registration.
- If a test succeeds, it also stamps a "last tested" timestamp on the registration record.

## What happens next
After a successful test, you can:

- "Save this registration"
- "Review the tools this server provides"

## Does this change data?
**Yes, this can change data.**

A successful test stamps a "last tested" timestamp on the registration record. It does not modify the registration's configuration.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Test External MCP Connection |
| Internal tool name | `test_mcp_registration_connection` |
| Purpose | Tests connectivity to an external MCP server endpoint before saving a registration |

## Tool behavior
Tests connectivity to an external MCP server endpoint before saving a registration. Validates the endpoint URL against SSRF restrictions, acquires an OBO token using the specified auth scope, and issues a `tools/list` request to verify the server responds. This is a widget support tool invoked automatically from the registration management widget.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | May stamp `lastTestedAt` on the registration when `registrationId` is provided. |
| `destructiveHint` | `false` | Testing does not remove or corrupt data. |
| `idempotentHint` | `true` | Repeated tests produce the same result for a given endpoint state. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Endpoint

| Input | Description | Required |
|---|---|---|
| `endpoint` | `endpoint` (HTTPS URL, required). The MCP server URL to test. | Yes |

### Auth scope

| Input | Description | Required |
|---|---|---|
| `authScope` | `authScope` (string, required). The Entra OBO target scope for token acquisition (e.g. `api://contoso-app/.default`). | Varies |

### Registration ID

| Input | Description | Required |
|---|---|---|
| `registrationId` | `registrationId` (UUID, optional). When provided, stamps `lastTestedAt` on the registration record upon successful test. | No |

### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget update with test results

Returns the discovered tool count and connection status. The widget displays success or a classified error (SSRF blocked, auth failure, timeout, server error).

## Routing notes
This tool is exclusively called by the `manage_mcp_registration` widget. Do not invoke it directly.

## Related tools
| Tool | Relationship |
|---|---|
| [`manage_mcp_registration`](manage_mcp_registration.md) | The launcher tool that opens the registration widget |
| [`save_mcp_registration`](save_mcp_registration.md) | Saves the registration after a successful test |
| [`delete_mcp_registration`](delete_mcp_registration.md) | Removes a registration |

## Data mutation classification
**Mostly read-only with optional side effect.** The connectivity test itself is read-only. When `registrationId` is provided and the test succeeds, it stamps `lastTestedAt` on the registration record.
