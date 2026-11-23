---
title: List customer work orders (preview)
description: Retrieve a customer account's past Dynamics 365 Field Service work orders, with their incidents, products, services, and service tasks, in chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# List customer work orders (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Review a customer's past jobs before a visit or follow-up. See the work performed, parts recorded, and resolutions across the account's work orders.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Start from an account, work order, or customer asset already identified in the conversation.
- Your security role must allow you to read that starting record, work orders, and their related incidents, products, services, and service tasks. Contact your administrator if access is missing.

## Try prompts like

- What's the service history for this customer?
- Show past work orders for the customer on this work order.
- What work has been done at this site?
- List the last 10 work orders for this account.
- Which parts did we use on this customer's previous jobs?

## What you can do

1. Identify the account or refer to a work order or asset already in the conversation.
2. Ask for the account's history, or narrow it to a particular functional location.
3. Review the text summary, most recent work orders first. Each includes its status, incident type, completion date, resolution, and related incidents, products, services, and service tasks.
4. Ask a follow-up about a listed job, such as opening the most recent work order or reviewing its parts.

Starting from a work order uses its service account, or its billing account if no service account is set. That work order appears separately from the other history. Starting from an asset uses its account and returns account-wide history, not just work on that asset.

## Data changes

Listing customer work orders only reads data. It doesn't change jobs, parts, tasks, or customer records. Opening a listed work order doesn't change it either.

## Tips and limitations

- History includes work orders where the account is either the service account or billing account.
- The default list contains the 50 most recent work orders. Ask for a different number, up to 200.
- Each work order includes up to 20 related records of each type. Warnings identify potentially partial history or counts; older jobs and additional related records might exist.
- A limited list isn't proof that an event never happened. Narrow to a specific site when relevant.
- This list doesn't assess recurring issues or whether a fix worked. Investigate work history for evidence about a particular asset, problem, or site pattern.

## Related information

- [Investigate work history](investigate_work_history.md)
- [View a work order](get_work_order.md)
- [List work order products and services](list_work_order_lines.md)
