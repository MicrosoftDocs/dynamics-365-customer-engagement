---
title: View a work order (preview)
description: Open one Dynamics 365 Field Service work order as a card with its status, customer, booking time, and maker-configured form.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# View a work order (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Open a work order in chat to check the job details, current status, customer, and booking time before your visit or next action.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Your security role must allow you to read the work order and its bookings. You see only the fields you're allowed to read.
- Timeline actions depend on the actions available in your environment and your permissions.

## Try prompts like

- Open work order 00123.
- Show me the work order for my next job.
- Summarize work order 00123.
- What's the status of the Contoso work order?
- What's the estimated cost on work order 00123?

## What you can do

1. Name the work order by its number, customer, or booking name. Choose the correct match if several work orders are found.
2. Review the card and short summary of the problem, planned work, status, and customer. Ask about estimated or actual cost and selling price when needed.
3. Expand **Work order details** to view the form configured by your organization.
4. Open **Timeline** to review activities and notes. Select a related record in the form to open it.
5. Refresh the card for current details, use full screen, or open the work order in Dynamics 365.

The card shows one booking's time and indicates other unfinished visits. Name the booking when you need a specific visit. Otherwise, it shows a current, overdue, or next booking, favoring your own bookings when available.

## Data changes

Viewing or refreshing a work order doesn't change records. The work order form fields are read-only; ask to update the work order when you need to change them.

Timeline actions are separate. Depending on what's available and your permissions, you can create activities and create, update, or delete notes. Opening the form or Timeline doesn't perform those changes.

## Tips and limitations

- A work order number is the clearest way to identify a job.
- If a booking has no work order, the reply explains this and shows the booking's status.
- A warning identifies related information that couldn't be loaded. Don't treat missing information as proof that no related records exist.
- For earlier visits or recurring problems, investigate work history rather than relying on the current job summary.

## Related information

- [Update a work order](update_work_order.md)
- [List work order service tasks](list_work_order_service_tasks.md)
- [List work order products and services](list_work_order_lines.md)
- [Investigate work history](investigate_work_history.md)
- [List customer work orders](list_customer_work_orders.md)
