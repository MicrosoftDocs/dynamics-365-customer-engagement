---
title: Update a booking status (preview)
description: Apply a booking status you confirmed for a Field Service booking, such as traveling, in progress, on break, completed, or canceled.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Update a booking status (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Apply the booking status you've reviewed and confirmed. Keep the visit's progress current as you travel, work, take a break, or finish the visit.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your security role must allow you to update bookable resource bookings and read booking statuses.
- Start with the booking status panel to identify the exact booking and review the proposed status.
- The status must be active, have a name, and have a configured Field Service status value. Eligible custom statuses are supported.

## Try prompts like

- Yes, update it.
- Confirm, set it to In Progress.
- Yes, mark it completed.
- Go ahead and cancel the booking.

These are replies to a change you've already reviewed. To start a new change, say what you're doing, such as "I've arrived," then review the booking status panel first.

## What you can do

1. Check that the booking and proposed status are correct.
2. Confirm in a later chat reply or select **Update status** in the panel.
3. For Completed or Canceled, review the additional confirmation before applying the change. These statuses can close downstream work.
4. Check the result. Chat confirmation produces a text reply with the booking and previous and new statuses. A panel update shows the verified result in the panel instead.

No separate editing form opens for a chat confirmation. After saving, continue with another task, such as reviewing the next booking or the work order's service tasks.

## Save and confirm changes

This action changes the status of one booking. It doesn't delete records.

Completed, Canceled, and statuses whose Field Service category can't be determined require additional review. In chat, your first confirmation opens the final preview; confirm that preview in another reply to apply it. In the panel, respond to the confirmation dialog.

If the panel already verified a saved change, don't confirm it again in chat. Panel saves don't send an automatic follow-up chat message.

## Tips and limitations

- The booking and status are checked again before saving. If someone changed the booking, review the current values before confirming again.
- If your selected status is no longer available, review the current choices and confirm a new one. The assistant doesn't silently switch to another status, even one with the same name.
- If the current status or available choices can't be verified, the change isn't applied.
- Dataverse and Field Service rules can prevent a status transition. Follow the explanation instead of repeating the same request blindly.

## Related information

- [Choose a booking status](get_booking_status_panel.md)
- [Plan your work day](plan_work_day.md)
- [View a work order](get_work_order.md)
- [Capture work progress](capture_work_progress.md)
