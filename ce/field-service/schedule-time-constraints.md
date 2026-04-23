---
title: Schedule bookings within time constraints
description: Learn how to schedule within time constraints and use promise windows in Dynamics 365 Field Service.
ms.date: 03/30/2026
ms.topic: how-to
ms.custom: bap-template
author: mkelleher-msft
ms.author: mkelleher
---

<!-- IMPORTANT: This article was previously an include of ../shared/urs/schedule-time-constraints.md. Content overlaps with that shared file. If you update this article, make sure you also update the relevant sections in the shared file, and vice versa. -->

# Schedule bookings within time constraints

When scheduling a requirement, set date and time parameters to control when to book the requirement. Use promise windows when you commit to a customer that service happens within a specific window - for example, "between 9 AM and 12 PM."

> [!NOTE]
> Field Service doesn't support variable calendars, which limit scheduling to certain days and times. For example, if a customer requests completion of the work order on Monday, Wednesday, or Friday between 12:00 PM and 5:00 PM. As a workaround, use notes to inform the dispatcher of the customer's preferences or [create booking rules](set-up-booking-rules.md) that use custom logic with JavaScript.

## Schedule a requirement within a time frame

1. In Field Service, open a work order.

1. Set the **Promised window** fields to define the time window in which a resource must arrive and start the work. These values automatically populate the corresponding fields on the related resource requirement and vice versa.

   :::image type="content" source="media/work-order-time-window.png" alt-text="Screenshot of the time window preferences on a work order form.":::

1. Select **Save & Close**.

When searching for suitable resources to work on the requirements, the schedule assistant populates the filters accordingly. Resources available for the entire duration show as options. The time promised window needs to be within the search range (search start and search end) to show as a search result. If a value of the time promised window is missing, the system uses the other value. To return such results when searching, make sure the search range includes the time from promised plus the expected duration. If no value for the promised time value is provided, the fields are ignored when searching in the schedule assistant.

## Promise window fields

The resource requirement has two pairs of fields for promise windows:

| Fields | Purpose |
|---|---|
| **Time From Promised / Time To Promised** | The time window when the resource should arrive. The schedule assistant shows these fields as preferred time slots. |
| **Time Window Start / Time Window End** | Alternative fields that behave the same way. If one pair is missing, the system uses the other. |

These fields auto-populate between the work order and its resource requirement. You can also set them manually on the requirement.

> [!IMPORTANT]
> The search range in the schedule assistant must cover the full promise window plus the job duration. For example, if the promise window is 9 AM–12 PM and the job takes 2 hours, the search range must extend to at least 2 PM.

## Promise windows vs. fulfillment preferences

Promise windows and [fulfillment preferences](set-up-time-groups.md) both affect how the schedule assistant displays time slots, but they serve different purposes:

| | Promise windows | Fulfillment preferences |
|---|---|---|
| **Set on** | Individual requirement | Fulfillment preference record (reusable) |
| **Purpose** | Hard constraint - resource must arrive in this window | Display preference - how time slots are grouped and presented |
| **Effect** | Filters out slots outside the window | Groups available slots into intervals or time blocks (for example, morning/afternoon) |
| **Example** | "Arrive between 9 AM and 12 PM" | "Show availability in 30-minute intervals" or "Show morning/afternoon blocks" |

You can use both together. The promise window restricts the overall range, and fulfillment preferences control how results within that range are displayed.

## Set a time zone for the requirement

Define a time zone on the requirement to help dispatchers view schedule assistant results in the time zone of the customer.

1. Open a requirement.

1. Select **Modify Calendar** and choose a time zone from the dropdown.

1. Select **Save & Close**.

When you book the requirement, the start times of the schedule results reflect the selected time zone.

## Customize start and end date fields

You can customize which fields serve as the start and end dates for the related requirement in the booking setup metadata.

1. In the Resources area, under **Administration**, select **Booking Setup Metadata**.

1. Select the entity name and go to the **Attribute Mapping** section to choose any date/time field you want to use.

1. Select **Save & Close**.

## Next steps

- [Fulfillment preferences](set-up-time-groups.md)
- [Requirement types for scheduling](scheduling-requirement-types.md)
- [Set up booking rules](set-up-booking-rules.md)
- [Time constraints in Universal Resource Scheduling](/dynamics365/common-scheduler/schedule-time-constraints)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
