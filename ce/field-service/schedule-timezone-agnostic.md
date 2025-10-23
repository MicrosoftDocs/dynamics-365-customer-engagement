---
title: Schedule resources across time zones
description: Learn how to simplify scheduling resources across different time zones by normalizing working hours to Coordinated Universal Time (UTC).
ms.date: 05/22/2025
ms.topic: how-to
author: ryanchen8
ms.author: chenryan
ms.custom: bap-template
---

# Schedule resources across time zones

Simplify time zone conversions and make it easier to schedule resources in different locations. When you normalize working hours to Coordinated Universal Time (UTC), time zone agnostic scheduling helps teams around the world work together smoothly.  

## Enable time zone agnostic scheduling

With admin permissions, [edit the booking settings](./schedule-new-entity.md#edit-settings-for-enabled-entities), and select **Yes** for **Ignore Time Zone in Schedule Assistant**.  

> [!NOTE]
> Time zone agnostic scheduling works only for resources and requirements that are set as location agnostic. It doesn't support scheduling facilities, crews, pools, requirement groups, promised time windows, or fulfillment preferences with time groups. It works only with the schedule assistant and doesn't work with the [quick scheduling](./quick-scheduling.md) or **Specify Pattern** control.

## Book using a time zone agnostic calendar

Follow these steps to book using a time zone agnostic calendar:

1. Select **Book** on a bookable entity, such as a work order, or **Find Availability** on the schedule board, to open the schedule assistant.
1. The schedule assistant automatically converts all start and end times for resources and requirements to UTC. It also shows these times in the Gantt chart, which is now always set to UTC.
   For example, two resources work from 9 AM to 5 PM. One resource works Eastern Time, and the other in Pacific Time. Both resource availabilities show as 9 AM to 5 PM UTC.
1. Book the requirement using the schedule assistant. You can move bookings within the schedule assistant Gantt view, or use the **Move to** option.
1. When you exit the schedule assistant, it converts the bookings back to the resource’s local time zone and shows them on the schedule board.