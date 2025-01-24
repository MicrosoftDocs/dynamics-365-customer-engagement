---
title: Track time expenditure with time entries
description: Discover how to manage time entry in Dynamics 365 Field Service.
ms.date: 05/23/2024
ms.topic: conceptual
author: anilmur
ms.author: anilmur
---

# Track time expenditure with time entries

Time entry capabilities help field service organizations better track the time that technicians spend on a job. They're often used for reporting, invoicing, and billing for the provided services.

For a guided walkthrough, check out the following video.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=881e6a12-aca1-43ec-9a7d-5cb5ea876e22]

## Automatic time entries

The system creates time entries automatically for time-off requests and in the work order process. If you don't want time entries created automatically for the work order process, go to **Settings** > **Field Service Settings** and set the **Time Entry Generation Strategy** to **Manual**. For more information, see [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md).

### Work order process

When the *booking status* for a work order changes, the system logs [booking timestamps](booking-timestamps.md). When a work order is completed, the system creates time entries based on the booking timestamps. If another user updates the booking status to *Completed* on behalf of a technician, the booking’s end time preserves the previous end time value.

:::image type="content" source="media/work-order-time-entry.png" alt-text="Screenshot of a list of time entries.":::

When the *work order system status* changes to *Closed-Posted*, the system creates records for *actuals* based on the time entries. These records represent the internal cost of the technician's time.

:::image type="content" source="media/work-order-time-entry-actuals.png" alt-text="Screenshot of a list of active actuals.":::

Time entries are only automatically created for work order bookings and not for independent bookings or bookings related to other tables.

### Time off requests

Time off requests are automatically recorded as time entries. Depending on the settings for the bookable resource record, someone might need to approve the request. The system automatically creates a time entry record with the type *Vacation*. Changing the duration of the time entry updates the time off request and vice versa.

## Manual time entry

Time entries can also be created manually in the Field Service web app and on the mobile app. Add a start time, end time or duration, and the bookable resource.

You can define a relationship from the time entry to other records like work orders and bookings.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
