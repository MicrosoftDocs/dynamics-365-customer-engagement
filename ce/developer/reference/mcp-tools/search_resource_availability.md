---
title: Find available booking slots (preview)
description: Find technicians and time slots that can take a Field Service work order, then pick a slot to book from chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Find available booking slots (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Find resources and time slots for a work order, compare the options, and choose a visit that fits the customer's needs. Searching doesn't reserve a slot.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Universal Resource Scheduling must be configured for Field Service, with resources that can take the work.
- Your role must allow you to read work orders, resource requirements and their scheduling criteria, resources, bookings, and booking statuses.
- An active resource requirement is needed to book. You can search without one, but can't book an option until a current requirement is available.

## Try prompts like

- Schedule work order 00051.
- Find technician time for WO 00051.
- Who can take work order 00051 on Friday between noon and 4?
- Find a slot tomorrow morning, Pacific time.
- Find the first three options for work order 00051 within 10 miles.

## What you can do

1. Identify the work order. Review candidate work orders if the match is partial or ambiguous.
2. State the day and time range in your local time, or name another time zone. You can adjust the work duration or travel radius.
3. Compare slots grouped by day. Check the resource, arrival time, work duration, end time, travel details, and location. Review any **Outside requested window** label because travel or work can extend beyond your requested times.
4. Select a slot. Use **_n_ more** to show the rest of a day's options or **Fewer** to collapse them. Expand **Existing bookings** to review visits already on the work order.
5. When ready, choose an eligible Scheduled status in **Booking status** and select **Book**. If **Book** isn't available in your Copilot app, tell the assistant the resource and time you chose.

The search considers required duration, territory, characteristics, roles, resource preferences, existing bookings, and travel. Outlook free/busy is considered unless you ask otherwise. Onsite searches use a 20-mile travel radius by default.

## Data changes

Finding availability only reads data. Selecting an option doesn't reserve it. **Book** is a separate action that creates a booking after checking availability again.

Suggested options expire after 15 minutes. Search again if an option expires or becomes unavailable. Availability checks don't guarantee that simultaneous scheduling requests can't create overlaps.

If a booking's outcome can't be confirmed, inspect the work order's current bookings before trying again. Don't assume an error means nothing was created.

## Tips and limitations

- Searches and displayed times use your Dynamics 365 time zone unless you name another.
- Without a requested window, the search uses the requirement's date range or the next seven days. A search can cover up to 31 days.
- An empty result doesn't prove no availability exists; results are limited. After an unconstrained empty search, **Expand search**, when offered, searches up to seven more days with the same filters. Otherwise, ask for a different window or radius.
- A period you specified isn't silently widened.
- Historical results are for review only. Past travel starts or arrivals can't be booked.

## Related information

- [Schedule a booking](schedule_booking.md)
- [Plan your work day](plan_work_day.md)
- [View a work order](get_work_order.md)
- [List customer work orders](list_customer_work_orders.md)
