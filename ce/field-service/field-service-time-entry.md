---
title: Track time expenditure with time entries
description: Discover how to manage time entry in Dynamics 365 Field Service.
ms.date: 01/24/2025
ms.topic: conceptual
author: anilmur
ms.author: anilmur
---

# Track time expenditure with time entries

Time entry capabilities help field service organizations better track the time that technicians spend on a job. Time entry can be tied to a work order or booking. They're often used for reporting, invoicing, and billing for the provided services and can be integrated with ERP systems. Other applications can also write to the Time Entry table in Dataverse.

Administrators determine the following settings:

- [**Timestamp Frequency**](configure-default-settings.md#work-order--booking-settings): Whether a timestamp is created per **Booking Status** or **Work Order System Status**.

- [**Time Entry Generation Strategy**](configure-default-settings.md#time-entry-settings): Automatic (default) or manual time entries.

- [**Time Cost Actuals Source**](configure-default-settings.md#time-entry-settings): Whether time cost actuals come from time entries or booking journals.

Manual time entries and time-off requests can be entered in the mobile app and the web app.

For a guided walkthrough of the automated and manual time entry process, check out the following video.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=881e6a12-aca1-43ec-9a7d-5cb5ea876e22]

## Automatic time entries

The system by default creates time entries automatically for time-off requests and in the work order process. You can view the time entries after the **Booking Status** is set to *Completed*.

### Work order process

When the **Booking Status** for a work order changes, the system logs [booking timestamps](booking-timestamps.md). When a work order is completed, the system creates time entries based on the booking timestamps. If another user updates the booking status to *Completed* on behalf of a technician, the booking's end time preserves the previous end time value.

:::image type="content" source="media/work-order-time-entry.png" alt-text="Screenshot of a list of time entries.":::

When the **Work Order System Status** changes to *Closed-Posted*, the system creates records for *actuals* based on the time entries. These records represent the internal cost of the technician's time.

:::image type="content" source="media/work-order-time-entry-actuals.png" alt-text="Screenshot of a list of active actuals.":::

Time entries are only automatically created for work order bookings and not for independent bookings or bookings related to other tables.

### Time off requests

[Time off requests](submit-approve-time-off-requests.md) are automatically recorded as time entries. Depending on the settings for the bookable resource record, someone might need to approve the request. The system automatically creates a time entry record with the type *Vacation*. The scheduling assistant doesn't recommend that resource for a job during that period. The time slots for that resource are grayed out on the schedule board to provide a visual notification to the dispatchers that the resource isn't available.

## Manual time entry

Time entries can also be created manually in the Field Service web app and on the mobile app from the main menu. Add a start time, end time or duration, and the bookable resource. If the time entry is related to a work order or booking, enter that information as well.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
