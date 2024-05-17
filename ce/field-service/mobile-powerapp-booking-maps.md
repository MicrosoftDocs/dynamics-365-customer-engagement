---
title: Booking maps in Dynamics 365 Field Service
description: Learn about how to set up booking maps for frontline workers in Dynamics 365 Field Service.
ms.date: 05/17/2024
ms.subservice: field-service-mobile
ms.topic: conceptual
author: JonBaker007
ms.author: jobaker
---

# Booking maps in Dynamics 365 Field Service

Frontline workers can view their scheduled work orders on a map from the Field Service mobile app. Seeing their work on the map helps frontline workers plan their day and provides an easy way to trigger travel directions or contact the customer. The booking map works when the mobile app is running offline _with_ internet access. In this case, the device is connected to the internet while using downloaded data.

> [!div class="mx-imgBorder"]
> ![Device render of Field Service mobile, showing the map view with one day of the week selected.](./media/bookable-maps-pins3-wf.png)

## Prerequisites

To use booking maps, your administrator must [enable booking maps for mobile in the **Work Order/Booking** section of the **Field Service Settings** page](configure-default-settings.md#work-order--booking-settings).

## Schedule work orders

To see bookings on a map, you first need to schedule work orders.

Go to the schedule board and schedule work orders to a frontline worker that has mobile access.

> [!NOTE]
> Booking maps only display bookings related to work orders, and not bookings for other record types (entities).

## View booking map on mobile app

1. Sign into the mobile app and go to **Bookings**.

1. Select **Agenda** in the top-right of the bookings view, choose **Map**.

> [!div class="mx-imgBorder"]
> ![Field Service mobile, open on the map view.](./media/booking-maps-option-wf.png)

For each day, the frontline worker sees a map view of their bookings.

Pin colors represent the Field Service status of the booking status. For more information, see [work order and booking statuses](work-order-status-booking-status.md).

Tap a booking pin to get directions or call the customer. Select **View Details** to open the booking and work order. The locations comes from the related work order address. The phone number belongs to the primary contact for the related work order.
