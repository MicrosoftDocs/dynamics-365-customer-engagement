---
title: How MCP tools support Field Service scenarios (preview)
description: Understand how Model Context Protocol tools connect Service Agent to Field Service data and actions across the technician job lifecycle.
ms.date: 11/23/2026
ms.topic: concept-article
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot
ai-usage: ai-generated
---

# How MCP tools support Field Service scenarios (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Service Agent uses Model Context Protocol (MCP) tools to retrieve Field Service information and complete supported actions. For example, a technician can review bookings, open a work order, and describe completed work in the same conversation.

Administrators and developers can use these tools as building blocks for conversational workflows. For an introduction for technicians, dispatchers, and service managers, see [Field Service capabilities in Service Agent](service-agent-overview.md).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

Field Service capabilities require [public preview enrollment](service-agent-preview.md), separately from the availability of other Service Agent or MCP offerings.

## How tools work

1. A user describes a task in natural language.
2. Service Agent selects an available tool and runs it with the user's permissions.
3. The result appears in the conversation. Supported clients can also show a form, list, or card for reviewing information or taking the next action.

Users can continue with related tasks without learning tool names or calling APIs directly.

## Field Service tools

Each guide explains when to use a tool, gives example requests, and describes what you see and how to review or save changes. The articles belong to the shared Service Agent collection.

| Scenario | Tool guides |
|---|---|
| Plan the day and understand a job. | [Plan your work day](../developer/reference/mcp-tools/plan_work_day.md) and [View a work order](../developer/reference/mcp-tools/get_work_order.md). |
| Review history and required work. | [Investigate work history](../developer/reference/mcp-tools/investigate_work_history.md), [List customer work orders](../developer/reference/mcp-tools/list_customer_work_orders.md), [List work order products and services](../developer/reference/mcp-tools/list_work_order_lines.md), and [List work order service tasks](../developer/reference/mcp-tools/list_work_order_service_tasks.md). |
| Capture and apply field updates. | [Prepare a field observation note](../developer/reference/mcp-tools/format_field_observation.md), [Capture work progress](../developer/reference/mcp-tools/capture_work_progress.md), and [Apply work progress](../developer/reference/mcp-tools/apply_work_progress.md). |
| Update bookings and work orders. | [Choose a booking status](../developer/reference/mcp-tools/get_booking_status_panel.md), [Update a booking status](../developer/reference/mcp-tools/update_booking_status.md), and [Update a work order](../developer/reference/mcp-tools/update_work_order.md). |
| Maintain tasks and parts. | [Update a work order service task](../developer/reference/mcp-tools/update_work_order_service_task.md), [Add a product line to a work order](../developer/reference/mcp-tools/create_work_order_product.md), and [Update a work order product](../developer/reference/mcp-tools/update_work_order_product.md). |
| Convert and schedule service work. | [Prepare a work order from a case](../developer/reference/mcp-tools/get_case_work_order_form.md), [Convert a case to a work order](../developer/reference/mcp-tools/convert_case_to_work_order.md), [Find available booking slots](../developer/reference/mcp-tools/search_resource_availability.md), and [Schedule a booking](../developer/reference/mcp-tools/schedule_booking.md). |

Shared tools also provide customer information, notes, activities, search, knowledge, and communications. Check each article's **Applies to** line and prerequisites.

## Access and data changes

Tools use the signed-in user's Dataverse permissions. Showing a tool doesn't grant access to records or bypass business validation.

Read-only tools retrieve information. Other tools save changes or prepare them for review. Each reference explains the required save or confirmation steps.

A work-progress plan is saved in Dataverse for review. The proposed changes to work orders, bookings, tasks, parts, and notes are applied in a separate step, after confirmation.

## Configure and extend Service Agent

Administrators and makers can configure supported layouts, choose which tools users see, and register approved extensions.

Organization-owned extensions can be available in other eligible Service Agent contexts in the environment. Review access and data-handling requirements before enabling them. See [Configure Service Agent capabilities for Field Service](configure-service-agent.md).

## Developer considerations

Discover available tools at runtime rather than hard-coding a fixed catalog. Names, inputs, metadata, and response formats can change.

Only offer tools that are available and authorized in the connected environment. Interactive components and supported preview scenarios can differ by client.

## Related information

- [Field Service capabilities in Service Agent](service-agent-overview.md).
- [Overview of Dynamics 365 Customer Service MCP tools](../customer-service/develop/mcp-tools-overview.md).
- [Data residency for agent capabilities in Dynamics 365](../developer/agent-capabilities-data-residency.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
