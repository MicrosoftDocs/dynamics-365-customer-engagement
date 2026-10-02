---
title: Schedule resources across time zones
description: Learn how to simplify scheduling resources across different time zones by normalizing working hours to Coordinated Universal Time (UTC).
ms.date: 09/30/2026
ms.topic: how-to
author: ryanchen8
ms.author: chenryan
ms.reviewer: puneetsingh
ms.custom: 
 - bap-template
 - ai-gen-docs-bap
 - ai-seo-date: 05/08/2026
ai-usage: ai-assisted
---

# Schedule resources across time zones

Simplify time zone conversions and make it easier to schedule resources in different locations. When you normalize working hours to Coordinated Universal Time (UTC), time zone agnostic scheduling helps teams around the world work together smoothly.  

## Enable time zone agnostic scheduling

With admin permissions, [edit the booking settings](./schedule-new-entity.md#edit-settings-for-enabled-entities), and select **Yes** for **Ignore Time Zone in Schedule Assistant**.  

Time zone agnostic scheduling has the following limitations:

- It applies only to requirements with a **Work Location** of **Location Agnostic**.
- It doesn't support crews, pools, requirement groups, or promised time windows.
- It works only with the schedule assistant. It doesn't work with [quick scheduling](./quick-scheduling.md), the **Specify Pattern** control, or the `msdyn_SearchResourceAvailability` API.
- Appointments aren't adjusted to each resource's local time, so availability might not reflect them correctly.

## Book using a time zone agnostic calendar

Follow these steps to book using a time zone agnostic calendar:

1. Select **Book** on a bookable entity, such as a work order, or **Find Availability** on the schedule board, to open the schedule assistant.
1. The schedule assistant automatically converts all start and end times for resources and requirements to UTC. It also shows these times in the Gantt chart, which is now always set to UTC. While the schedule assistant is open, you can't change the time zone in the board settings.
   For example, two resources work from 9 AM to 5 PM. One resource works Eastern Time, and the other in Pacific Time. Both resource availabilities show as 9 AM to 5 PM UTC.
1. Book the requirement using the schedule assistant. You can move bookings within the schedule assistant Gantt view, or use the **Move to** option.
1. When you exit the schedule assistant, the schedule board returns to its previous time zone. Each booking keeps the resource's local start and end times, based on the time zone of the resource's calendar on the booking date. The schedule board shows the booking in the board time zone.

## Time zones and daylight saving time on the schedule board

The schedule board shows all bookings and working hours in one time zone so that you can compare resources in different locations. Use the following information to understand why a booking might appear at a different time than you expect.

- **Board time zone**: Each schedule board tab has its own time zone. The board shows bookings, the timeline, and today's date in this time zone. To change it, open the tab's [board view settings](./schedule-board-tab-settings.md#board-view-settings) and select a **Time Zone**.
- **Resource working hours**: Resource working hours use the time zone of the resource's calendar. For example, a resource who works 9 AM to 5 PM Eastern Time appears to work 6 AM to 2 PM on a board set to Pacific Time.
- **Daylight saving time**: The schedule board applies the daylight saving time rules for each booking's date. A resource who works 9 AM to 5 PM local time keeps those hours after a daylight saving time change. However, the difference between the resource's time zone and the board time zone can change when the two time zones switch on different dates or only one of them observes daylight saving time. During those periods, the resource's bookings and working hours appear to shift by one hour on the board.
- **Date and time format**: The date and time format comes from your personal settings, not the schedule board settings. Learn more in [Set personal options](/power-apps/user/set-personal-options).
- **Schedule assistant time zone**: When you select **Book** on a requirement, the schedule assistant uses the requirement's time zone. If the requirement doesn't have a time zone, it uses the time zone from your personal settings. When you select **Find Availability** on the schedule board, it uses the board time zone. If time zone agnostic scheduling is on, the schedule assistant uses UTC instead. Learn more in [Time zone for search results](./schedule-assistant.md#time-zone-for-search-results) and [Set a time zone for the requirement](./schedule-time-constraints.md#set-a-time-zone-for-the-requirement).

> [!TIP]
> If a booking appears at an unexpected time, compare the board time zone with the time zone of the resource's calendar.