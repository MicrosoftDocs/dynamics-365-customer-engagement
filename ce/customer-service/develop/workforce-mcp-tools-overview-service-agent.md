---
title: Overview of Dynamics 365 Workforce Management MCP tools
description: Learn what Dynamics 365 Workforce Engagement Management MCP tools do, who uses them, and which workforce request scenarios they support.
ms.date: 08/18/2026
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: mgandham
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.custom: bap-template
---
# Overview of Dynamics 365 Workforce Engagement Management MCP tools

Dynamics 365 Workforce Engagement Management (WEM) Model Context Protocol (MCP) tools provide standardized workforce actions that AI-powered experiences can use to retrieve and manage scheduling requests. These tools connect a conversational experience, such as Service Agent, with Dynamics 365 Customer Service and Dataverse so users can complete workforce management tasks through natural language.

Customer service representatives and supervisors don't typically use MCP tools directly. Instead, they interact with Service Agent. Service Agent determines which tool to use, invokes it in the background, and presents the result in the conversation. For example, a supervisor can ask for pending time-off requests, review a specific request, and approve or reject it without navigating to the workforce management application.

## Key uses

WEM MCP tools support the following scenarios:

- **Workforce request visibility**: List and filter time-off, shift swap, and shift bid requests. Results are scoped to the user's role. Supervisors can review open requests for their planning group, while customer service representatives can review their own submissions and current request status.
- **Request details and context**: Retrieve the full record for a specific time-off, shift swap, or shift bid request. The response can include the requesting representative, requested dates, current status, and related scheduling information needed to understand the request.
- **Supervisor decisions**: Approve or reject a pending time-off request directly in the conversation. A rejection must include a reason, which is saved with the request. The decision also records the reviewer and review time.
- **Role-aware responses**: Enforce existing Dynamics 365 role-based access controls. Supervisors can access records within their authorized planning group, and customer service representatives can access only their own records.

## Personas

### Customer service representatives

Customer service representatives use Service Agent to review their workforce requests without leaving the conversation. They can ask for their time-off, shift swap, or shift bid requests, check a request's status, and retrieve details about a specific submission.

### Supervisors

Supervisors use Service Agent to review workforce requests for their planning group. They can filter pending requests, inspect the details and scheduling context for an individual request, and approve or reject time-off requests when they have the required reviewer permission.

### MCP app developers and agent developers

MCP app developers and agent developers use the WEM tool catalog as reusable building blocks for conversational workforce experiences. They can combine request-list, request-detail, and decision capabilities into workflows that present workforce information and supported actions in chat.

## Privileges, access, and security considerations

Dynamics 365 and Dataverse security govern access to WEM MCP tools. Tool responses are limited to the records and actions the signed-in user is authorized to access. Supervisors can review requests for their planning group, while customer service representatives can review their own requests.

Approving or rejecting a time-off request changes data and requires reviewer permission. If a request is already decided, the decision tool doesn't overwrite the existing decision. The decision capability applies only to time-off requests; it doesn't approve or reject shift swap or shift bid requests.

## Available tools

The following WEM tools support workforce request scenarios.

| Tool | Capability | What it does |
| --- | --- | --- |
| `list_wem_requests` | List workforce requests | Lists and filters time-off, shift swap, and shift bid requests within the user's authorized scope. |
| `get_wem_request_details` | Get request details | Retrieves the details and scheduling context for a specific workforce request. |
| `decide_wem_time_off_request` | Approve or reject time-off requests | Approves or rejects a pending time-off request, records the reviewer and review time, and saves the reason for a rejection. |
