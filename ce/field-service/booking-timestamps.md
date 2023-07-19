---
title: Booking timestamps and booking journals
description: Learn about booking timestamps in Dynamics 365 Field Service.
ms.date: 06/20/2023
ms.topic: how-to
author: clearab
ms.author: anclear
---

# Booking timestamps and booking journals

Booking timestamps record the date and time that a *Booking Status* changes. They log how technicians spend their time, provide details for invoicing, and enable booking journals.

- Reporting, in order to see how technicians are spending their time
- Time-keeping, in order to provide a level of detail for invoicing
- Booking journals, in order to see a holistic view of time spent on any given work order

:::image type="content" source="media/scheduling-timestamps-booking-statuses-per-fs-status.png" alt-text="Screenshot of booking timestamps on a booking resource booking":::

> [!TIP]
> You can use booking timestamps to automatically generate [time entries](field-service-time-entry.md). To enable that feature, [set the Field Service setting](configure-default-settings.md#time-entry-settings) **Time Entry Generation Strategy** to *Auto Generate from Booking Timestamps*.

## Prerequisites

Create or customize [booking statuses](set-up-booking-statuses.md) that match your business and reporting needs. Booking statuses map to your [work order lifecycle and statuses](work-order-status-booking-status.md).

## Create timestamps

By default, the system creates timestamps automatically when the booking status on an entity changes the related Field Service status. Admins can [change this behavior on the Field Service Settings](configure-default-settings.md#work-order--booking-settings) in the **Timestamp Frequency** field.

Think of a default work order process.

1. A dispatcher schedules a work order to a technician. When scheduling the booking, it's booking status changes to *Scheduled*.
1. The technician sees the work order on their mobile device and updates the booking status to reflect progress. While driving to the work site, they set it to *Traveling*.
1. When the work starts, the update it to *In Progress*.
1. After completing the work, they set the booking status to *Completed*.

The system saves every change of the booking status to keep a track record.

> [!TIP]
> Bookings have a duration of at least one minute.

## View timestamps

To view timestamps, open a bookable resource booking and select **Related** > **Booking Timestamps**.

Each booking timestamp includes the following information:

- **System Status**: The related Field Service Status for the work order process.
- **Booking Status**: Booking status of the bookable resource booking.
- **Timestamp Time**: The date and time of status change.
- **Timestamp Source**: The device type originating the status change. When updating from the Field Service (Dynamics 365) mobile app, the timestamp source is *Desktop* if the changes occurred while the app is running in online mode, and *Mobile* when the app is running in offline mode.

## Generate booking journals

Booking journals calculate total travel time and working time for a booking. When a bookable resource booking status changes to *Completed*, the system creates booking journals per the booking timestamps. *Canceled* bookings won't have any booking journal records.

There are a few types of booking journals:  

- **Travel**: Duration when the resource is traveling to the site.
- **Working Hours**: Duration when the booking is in progress during the resource's work hours.
- **Break**: Duration when the resource is on break.
- **Overtime**: Duration when the booking is in progress outside of the resource's work hours.
- **Business Closure**: Duration when the booking is in progress business closure hours.

### Example of a booking journal

A resource's work hours are 8 AM to 3 PM. While completing a work order, they go through the following sequence.  

|         Booking status  |            Time stamp        |
|-------------------------|------------------------------|
|         Scheduled       |            8:00 AM         |
|         Traveling       |            9:00 AM         |
|         In Progress     |            10.30 AM        |
|         On Break        |            12:00 PM         |
|         In Progress     |            1:00 PM         |
|         Completed       |            4:00 PM         |

Based on these time stamps, the system creates the corresponding booking journals.

|         Time frame                                                    |            Duration     |            Booking journal type         |
|-----------------------------------------------------------------------|-------------------------|---------------------------------|
|         Travel (9 AM - 10:30 AM)                                  |            90 minutes   |            Travel               |
|         In Progress (10:30 AM - 12 PM)                            |            90 minutes   |            Working Hours        |
|         On Break (12 PM - 1:00 PM)                                |            60 minutes   |            Break                |
|         In Progress (1:00 PM - 3:00 PM)                           |            120 minutes  |            Working Hours        |
|         Exceeded working hours of resource (3:00 PM - 4:00 PM)    |            60 minutes   |            Overtime             |

## View booking journals

To view booking journals, open a bookable resource booking record and select **Related** > **Booking Journals**.

## Next steps

- [Work order summary report](work-order-summary-report.md)
- [Resource preferences](resource-preferences.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
