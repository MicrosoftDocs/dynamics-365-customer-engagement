---
title: Update a work order (preview)
description: Update Field Service work order details, custom fields, status, or substatus directly in chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Update a work order (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Change details, custom fields, or status on an existing work order in chat. Use the field labels your organization shows in Dynamics 365.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your security role must allow you to read and update work orders and read work order substatuses and bookings.
- Changing a field that refers to another record also requires access to that record.
- Field-level security and your organization's business rules still apply. Only fields you're allowed to read and update can be changed.

## Try prompts like

- Change work order 13729 to High priority.
- Set the gate access code to 4182.
- Mark this work order as awaiting parts.
- Clear the secondary contact.
- Complete this work order.

## What you can do

1. Identify the work order by its number, customer, or booking name among your current bookings. For other work orders, open or identify the exact work order or booking first.
2. State the fields and new values, or name the desired status or substatus. Standard and customer-added fields are supported when your organization allows updates.
3. Clarify any work order, field, choice, related record, or substatus that matches more than one possibility.
4. Read the text result, including previous and applied values and any status changes made by Field Service. No separate editing form opens.

Text updates replace existing text. If you want to add information, explicitly ask to keep the current text and add yours.

## Save and confirm changes

Ordinary field and supported open-status updates apply directly. Completing a work order requires a preview first. Review it and confirm in a later reply before completion is applied.

A work order can't be completed while it has unfinished bookings, or when their completion can't be verified. Complete or cancel those bookings first. Alternatively, describe the visit and job completion together to review one work progress plan.

If someone else changed the work order, review its current values before trying again. If an update was accepted but its final values can't be confirmed, reopen the work order before repeating it.

## Tips and limitations

- Choose an active substatus by its exact name. For a non-completion substatus, its system status must match the work order's current status; choosing it doesn't move the work order to make it fit.
- Posting, canceling, and reassigning work order ownership aren't supported here. Use the Field Service app.
- Tasks, parts, bookings, services, and notes are separate actions. This update changes only the work order itself and doesn't delete records.

## Related information

- [View a work order](get_work_order.md)
- [Capture work progress](capture_work_progress.md)
- [Choose a booking status](get_booking_status_panel.md)
- [Update a work order service task](update_work_order_service_task.md)
- [Update a work order product](update_work_order_product.md)
