---
title: Track time expenditure with time entries
description: Discover how to manage time entry in Dynamics 365 Field Service.
ms.date: 03/13/2026
ms.topic: article
author: ryanchen8
ms.author: chenryan
---

# Track time expenditure with time entries

Time entry capabilities help field service organizations better track the time that technicians spend on a job. You can tie time entry to a work order or booking. Use time entries for reporting, invoicing, and billing for the provided services. You can also integrate them with ERP systems. Other applications can write to the [Time Entry table](./developer/reference/entities/msdyn_timeentry.md) in Dataverse.

Administrators determine the following settings:

- [**Timestamp Frequency**](configure-default-settings.md#work-order--booking-settings): Whether to create a timestamp based on a change in **Booking Status** or **Work Order System Status**.

- [**Time Entry Generation Strategy**](configure-default-settings.md#time-entry-settings): Automatic (default) or manual time entries.

- [**Time Cost Actuals Source**](configure-default-settings.md#time-entry-settings): Whether time cost actuals come from time entries or booking journals.

Frontline workers can enter manual time entries and time-off requests in the mobile app and the web app.

For a guided walkthrough of the automated and manual time entry process, see the following video.

> [!VIDEO 3459f683-d0d2-48de-a0bb-691d3bde4b79]

## Automatic time entries

By default, the system automatically creates time entries for time-off requests and in the work order process. You can view the time entries after a technician sets the **Booking Status** to *Completed*.

### Work order process

When the **Booking Status** for a work order changes, the system logs [booking timestamps](booking-timestamps.md). When the technician completes a work order, the system creates time entries based on the booking timestamps. If another user updates the booking status to *Completed* on behalf of a technician, the booking's end time keeps the previous end time value.

:::image type="content" source="media/work-order-time-entry.png" alt-text="Screenshot of a list of time entries.":::

When the **Work Order System Status** changes to *Closed-Posted*, the system creates records for *actuals* based on the time entries. These records represent the internal cost of the technician's time.

:::image type="content" source="media/work-order-time-entry-actuals.png" alt-text="Screenshot of a list of active actuals.":::

The system only automatically creates time entries for work order bookings, not for independent bookings or bookings related to other tables.

### Time off requests

The system automatically records [time off requests](submit-approve-time-off-requests.md) as time entries. Depending on the settings for the bookable resource record, someone might need to approve the request. The system automatically creates a time entry record with the type *Vacation*. The scheduling assistant doesn't recommend that resource for a job during that period. The time slots for that resource are grayed out on the schedule board to provide a visual notification to the dispatchers that the resource isn't available.

## Manual time entry

Frontline workers can also create time entries manually in the Field Service web app and on the mobile app from the main menu. Add a start time, end time, or duration, and the bookable resource. If the time entry is related to a work order or booking, enter that information as well.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
