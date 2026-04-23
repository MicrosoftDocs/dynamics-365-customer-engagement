---
title: Manually schedule from the schedule board
description: Learn how to manually create bookings from the schedule board in Dynamics 365 Field Service.
ms.date: 03/26/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

<!-- IMPORTANT: Content in this article overlaps with ../shared/urs/use-schedule-board.md and ../shared/urs/schedule-assistant.md. If you update this article, make sure you also update the relevant sections in those shared files, and vice versa. -->

# Manually schedule from the schedule board

Use the [schedule board](work-with-schedule-board.md) to manually create bookings when you need full control over resource assignments. Manual scheduling is useful for emergency work or requirements with limited complexity.

## Create a manual booking

Select **Book** on the schedule board. Select a requirement and a resource, start date/time, end date/time, booking status, and booking method.

> [!IMPORTANT]
> Manual bookings don't validate constraints like availability, characteristics, or location. Use the [schedule assistant](schedule-assistant.md) if you want the system to honor constraints of a booking.

## When to use manual scheduling

Manual scheduling on the schedule board works well for:

- **Emergency work** that needs immediate assignment regardless of optimization
- **Simple requirements** with limited constraints
- **Overrides** when you need to schedule outside of normal rules

For requirements where you want the system to match resources based on skills, availability, and travel time, use the [schedule assistant](schedule-assistant.md) or [quick scheduling](quick-scheduling.md) instead.

## Rebook a scheduled requirement

To rebook a requirement that's already scheduled:

1. Go to the schedule board, right-click a booking, and then select **Rebook**.
1. The schedule assistant opens with the requirement details pre-filled.
1. Select a new resource and time slot, then select **Book** to reassign.

## Book the same work order to multiple resources

You can schedule the same job to multiple resources with the schedule assistant. Trigger the schedule assistant for a given work order and book it to a resource's time slot. Before exiting the search, select another resource's time slot and select **Book** again.

## Next steps

- [Filter resources and requirements on the schedule board](schedule-board-filtering.md)
- [Drag and drop to schedule on the board](schedule-board-drag-drop.md)
- [Launch the schedule assistant from the Book button](schedule-assistant-book-button.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
