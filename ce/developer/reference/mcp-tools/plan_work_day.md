---
title: Plan your work day (preview)
description: Get a Dynamics 365 Field Service resource's bookings for one day or up to 14 days, including active, upcoming, and completed jobs and the recommended next job.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Plan your work day (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

See your schedule and recommended next job at the start of the day or between visits. Plan today, another day, or a range of up to 14 days.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- For your own schedule, your Dynamics 365 user must be linked to exactly one active bookable resource of type User. Ask your administrator to correct a missing or duplicate link.
- To plan a named resource's day, you need read access to that active resource, but you don't need your own resource link.
- Your security role must allow you to read bookings, resources, booking statuses, work orders, and related accounts and priorities.

## Try prompts like

- What's on my plate today?
- What should I do next?
- How does my week look?
- What's on my schedule for the next 3 days?
- Plan Jordan Reyes's day tomorrow.

## What you can do

1. Ask for your schedule, or name another resource, day, or date range. Named resources can include crews, facilities, and equipment. Choose the correct resource if several names match.
2. Review the agenda and counts of active, remaining, completed, and total bookings. Proposed or unconfirmed bookings appear separately.
3. Check each booking's time, duration, status, customer, and work order. Flags can highlight overdue work, tight turnarounds, or bookings without a work order.
4. Find the **Recommended** job. Hover over or focus its tag to see why it was recommended. Work already underway is considered before later scheduled work.
5. Select a booking card or **Open work order** to review that job in chat.

Use **Show completed** or **Show canceled** to include finished bookings. Expand longer plans with **Show _n_ more days** or **Show _n_ more bookings**. On a clear day, use **Show the next 3 days** or **Choose another day**, when offered.

## Data changes

The day plan is read-only. Viewing bookings, showing more days, and opening a work order don't reschedule work or change records. Ask separately to update a booking status or find availability.

## Tips and limitations

- Schedule-day boundaries use the time zone reported by your Copilot app, or your Dynamics 365 time zone when the app doesn't report one.
- Displayed booking times use your viewing device's time zone, even for another resource. When the zones differ, check the schedule-day zone in the header and the dates beside booking times.
- Completed and canceled bookings are counted but hidden by default. Ask for an end-of-shift view to include them.
- A booking without a work order remains visible but isn't recommended as your next job.
- If results might be partial, narrow the date range. The plan shows bookings, not shift hours, route optimization, or reassignment.

## Related information

- [View a work order](get_work_order.md)
- [Choose a booking status](get_booking_status_panel.md)
- [Find available booking slots](search_resource_availability.md)
- [List work order service tasks](list_work_order_service_tasks.md)
