---
title: Schedule a booking (preview)
description: Book a Dynamics 365 Field Service work order into a selected technician time slot, with availability rechecked before the booking is created.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Schedule a booking (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Book a work order after choosing an available resource and time. Use a suggested slot or state the exact resource, day, arrival time, and end time you need.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Universal Resource Scheduling must be configured for Field Service.
- The work order must have a current, active resource requirement.
- At least one active booking status must have a Field Service status of Scheduled.
- Your role must allow you to create and delete bookings and read the related work order, scheduling requirements, resources, bookings, and statuses. Delete permission is used only to try to remove a booking just created by this action if a follow-up check fails.

## Try prompts like

- Book the first option.
- Book the selected slot.
- Confirm the 2 PM slot with Jordan Reyes.
- Book work order 00051 with Jordan Reyes on Friday from 1 PM to 3 PM.
- Book that slot as Scheduled - Confirmed.

## What you can do

1. Choose a slot from an availability search. If none has been offered, search for available booking slots first.
2. Check the resource, day, arrival and end times, and travel details. Suggested options remain valid for 15 minutes.
3. Choose an eligible Scheduled status in **Booking status**, then select **Book**. You can also tell the assistant which offered option to book.
4. Alternatively, name the resource and exact day and times in chat. Your requested start means arrival on site, not the start of travel. If travel prevents arrival at that exact time, nothing is booked.
5. Review the confirmation and booking details. Select **Open booking** or **Open work order** to check the records in Dynamics 365.

Availability is checked again before creation, including the current work order requirement, resource schedule, visible overlaps, and travel. If the requirement changed or the slot is no longer available, search again.

## Save and confirm changes

Booking creates one booking linked to the work order. It doesn't reschedule or delete existing bookings.

While creation is underway, **Book** is unavailable. If the outcome can't be confirmed, check the work order's current bookings before retrying or selecting another slot.

If a check immediately after creation fails, the action tries to remove only the booking it just created. Removal isn't guaranteed. An uncertain outcome can mean the booking remains; check for it and resolve any extra booking before booking again.

## Tips and limitations

- Availability checks don't guarantee that simultaneous scheduling requests can't produce overlaps. Check current bookings when another dispatcher is scheduling the same resource.
- Past travel starts or arrivals can't be booked, even after a historical availability search.
- Give a time zone when needed, and check the confirmation's dates and times. Don't proceed if they don't match your intended local time.
- If an offered slot expires or its start passes, search again.

## Related information

- [Find available booking slots](search_resource_availability.md)
- [Plan your work day](plan_work_day.md)
- [Choose a booking status](get_booking_status_panel.md)
- [View a work order](get_work_order.md)
