---
title: Choose a booking status (preview)
description: Find a Dynamics 365 Field Service booking and propose a new status such as traveling, in progress, on break, or completed, then confirm it from chat.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Choose a booking status (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Choose a status when you start travel, arrive on site, take a break, finish a job, or cancel a visit. Review the booking and proposed status before applying the change.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- To find your own bookings by name or use "my next job," your Dynamics 365 user must be linked to an active bookable resource.
- Your security role must allow you to read bookings, booking statuses, work orders, accounts, and bookable resources. Applying a status also requires permission to update bookings.
- Dispatchers can choose another resource's booking only within their existing access. They don't need their own bookable resource link.

## Try prompts like

- I'm heading to my next job.
- I've arrived at work order 00123.
- I'm taking a break.
- Mark the booking for work order 00123 as completed.
- Set Jordan Reyes's booking for work order 00123 to In Progress.

## What you can do

1. Identify the booking by its name, work order number, or customer. "My next job" looks for your Scheduled bookings later today. Choose a booking if several match.
2. Review the booking name, work order, customer, current status, and proposed status in the panel. Bookings outside today's schedule include their date.
3. Choose from **Booking status** if you want a different status. You can use eligible custom names or standard statuses such as Traveling, In Progress, On Break, Completed, or Canceled. Resuming after a break means In Progress.
4. Select **Update status**, then confirm if prompted.
5. Check the verified result and next-step guidance in the panel.

To change someone else's booking, name both the booking and assigned technician. Choose the exact booking from the results before continuing.

## Save and confirm changes

Opening the panel doesn't change data. **Update status** changes the booking after any required confirmation. Completed and Canceled always require an additional confirmation because they can close downstream work. Choose **Keep current status** to stop. A status whose category can't be determined also requires confirmation.

You can confirm the proposed change in a later chat reply instead. For Completed, Canceled, or another status requiring extra review, that reply opens a final preview; confirm again in another reply to apply it.

Panel saves show their outcome in the panel. No automatic chat message follows, and you don't need to confirm an already saved change again in chat.

## Tips and limitations

- Only active, named statuses with a configured Field Service status value are offered.
- If the booking changed or the selected status is no longer available, refresh and review the current options. A different status isn't substituted automatically.
- A booking already Completed or Canceled is shown as closed, without a new status proposed.
- To check status without changing it, view the work order for the booking.

## Related information

- [Update a booking status](update_booking_status.md)
- [Plan your work day](plan_work_day.md)
- [View a work order](get_work_order.md)
- [Capture work progress](capture_work_progress.md)
