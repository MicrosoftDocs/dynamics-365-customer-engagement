---
title: Schedule assistant overview
description: Learn about the schedule assistant in Dynamics 365 Field Service, which helps dispatchers match jobs with the right resources.
ms.date: 03/26/2026
ms.custom: bap-template
ms.topic: overview
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: v-wendysmith
---

<!-- IMPORTANT: This article was previously an include of ../shared/urs/schedule-assistant.md. Content overlaps with that shared file. If you update this article, make sure you also update the relevant sections in the shared file, and vice versa. -->

# Schedule assistant overview

The schedule assistant helps dispatchers assign requirements to ideal resources. It recommends resources that match criteria like availability, skills, and location. The system also estimates travel time for the recommended resources, which helps dispatchers plan work accordingly.

When the dispatcher identifies the right resource for the job, they book the resource.

## When to use the schedule assistant

The schedule assistant is best suited for semi-automated scheduling where a dispatcher reviews suggestions and makes the final decision. Use it when:

- The requirement has constraints like skills, territories, or time windows that need to be honored.
- You want the system to estimate travel time and rank resources.
- You need to find availability across many resources quickly.

For simple assignments or emergency work, consider [manual scheduling](schedule-board-manual-scheduling.md). For fully automated scheduling, consider the [Resource Scheduling Optimization add-in](rso-overview.md) or the [Scheduling Operations Agent](soa-overview.md).

## Schedule assistant filters

After launching the schedule assistant, the Schedule Assistant Filter pane displays. Refine results to find the right resource using filters like work location, characteristics, territory, resource types, and more.

By default, the search range filter is set to match the requirement's **From Date** and **To Date**, which can be adjusted. For multiday requirements, ensure that each requirement detail that needs to be booked is within the schedule assistant's start and end dates.

The default limit for searching resource availability is 100 entries, but it can be increased up to a maximum of 1,000. For organizations with a large number of resources, this default might result in incomplete search results. To increase the limit, adjust the *Resource Availability Retrieval Limit* in [*Booking Setup Metadata*](schedule-new-entity.md#edit-settings-for-enabled-entities). Increasing the limit might affect search performance.

> [!NOTE]
> If you book outside the schedule assistant's recommended slots, constraints such as capacity, work hours, and time windows aren't verified or enforced.

## Time zone for search results

View and change the time zone in the **Board view settings** after launching the schedule assistant.

The system derives the time zone value from the time zone on the requirement when launched from the schedulable entity. Open the requirement and select **Modify Calendar** to view and edit the requirement time zone. When launched from the schedule board with **Find availability**, the system derives the time zone value from the schedule board settings record.

## Reschedule bookings

To rebook a requirement:

1. Go to the schedule board, right-click a booking, and then select **Rebook**.
1. The schedule assistant opens with the requirement details pre-filled.
1. Select a new resource and time slot to reassign.

## Book the same work order again

You can schedule the same job to multiple resources with the schedule assistant. Trigger the schedule assistant for a given work order and book it to a resource's time slot. Before exiting the search, select another resource's time slot and select **Book** again.

## Next steps

- [Launch the schedule assistant with the Book button](schedule-assistant-book-button.md)
- [Quick scheduling](quick-scheduling.md)
- [Advanced filters for the schedule assistant](schedule-assistant-advanced-filters.md)
- [Schedule with travel time and distance](schedule-with-travel-time.md)
- [Schedule assistant in Universal Resource Scheduling](/dynamics365/common-scheduler/schedule-assistant)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
