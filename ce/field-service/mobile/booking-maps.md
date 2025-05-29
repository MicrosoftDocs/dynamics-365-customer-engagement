---
title: View daily bookings on a map
description: Learn how to set up booking maps for frontline workers in the Dynamics 365 Field Service mobile app.
ms.subservice: field-service-mobile
ms.topic: how-to
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

# View daily bookings on a map

Frontline workers can view their scheduled work orders on a map from the Field Service mobile app. Seeing their work on the map helps frontline workers plan their day and provides an easy way to trigger travel directions or contact the customer. The booking map works when the mobile app is running offline *with* internet access. In this case, the device is connected to the internet while using downloaded data.

## Prerequisites

To use booking maps, [enable booking maps for mobile in the **Work Order/Booking** section of the **Field Service Settings** page](../configure-default-settings.md#work-order--booking-settings).

To see bookings on the map, schedule work orders for a resource. Booking maps show bookings that are related to a work order.

## View booking map on mobile app

1. Sign in to the mobile app and go to **Bookings**.

1. Select **Agenda** in the upper-right of the bookings view, and then choose **Map**.

   :::image type="content" source="../media/booking-maps-option-wf.png" alt-text="Screenshot of the map view in the Field Service mobile app.":::

1. Select a day to see the map of scheduled bookings for the day.

Pin colors represent the Field Service status of the booking status. For more information, see [work order and booking statuses](../work-order-status-booking-status.md).

Tap a booking pin to get directions or call the customer. Select **View Details** to open the booking and work order. The location is the address of the related work order. The phone number belongs to the primary contact for the related work order.

[!INCLUDE [footer-banner](../../includes/footer-banner.md)]
