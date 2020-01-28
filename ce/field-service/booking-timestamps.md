---
title: "Booking timestamps | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/03/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Booking timestamps in Dynamics 365 Field Service

In Dynamics 365 Field Service, booking timestamps record the date and time that the **Booking Status** changes on a work order. Booking timestamps are useful for: 

- Reporting, in order to see how technicians are spending their time
- Time-keeping, in order to provide a level of detail for invoicing
- Booking journals, in order to see a holistic view of time spent on any given work order

> [!div class="mx-imgBorder"]
> ![Screenshot of booking timestamps on a booking resource booking.](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)

To understand how booking timestamps are generated, it's important to distinguish between two status types: 

- **Booking Status**, which can be associated with a single Field Service Status
- **Field Service Status**, which can be associated with multiple Booking Statuses

By default, booking timestamps are generated when a **Field Service Status** changes. If you have associated several booking statuses with a single Field Service status, a timestamp will only generate by default when a booking status associated with a different Field Service status changes. 

To help illustrate, consider that you have three booking statuses: 

1. **In Transit**, associated with the Field Service status **In Progress**
2. **Wrench Time**, associated with the Field Service status **In Progress**
3. **Complete**, associated with the Field Service status **Complete**

When a technician updates their booking Status on Field Service Mobile to **In Transit**, a timestamp will be created. When they arrive onsite and begin work, they mark the booking status as **Wrench Time**. By default in Field Service, a new timestamp will *not* be created, as the associated Field Service status is still **In Progress**. When the booking status is updated to **Complete**, another timestamp will be created, as the associated Field Service status is different. 

In this topic, we'll look at how to configure booking timestamps. 

> [!Note]
> As of February 3, 2020, we've released into Public Preview functionality that lets you configure timestamps to generate each time a **Booking Status** is updated, regardless of the associated **Field Service Status**. This allows for more granularity in reporting, providing an additional level of detail. To find and configure this setting, go to **Field Service** > **Settings** > **Work Order/Booking section** > **Timestamp Frequency** to select either "Per Field Service Status" or "Per Booking Status." 

> [!div class="mx-imgBorder"]
> ![Screenshot of the timestamp frequency functionality in Field Service settings.](./media/scheduling-timestamps-frequency-setting.png)


## Prerequisites

In order to get the most out of booking timestamps:

  - Make sure you have booking statuses that match your business and reporting needs. Many booking statuses exist by default and correspond with the work order process. These booking statuses have an associated Field Service Status. For example, the out-of-the-box "In progress" booking status has a Field Service Status of "In progress" and this changes the related work order system status to "Open-In Progress" automatically. To understand how booking statuses and work orders effect each other, see the topic on [work order lifecycle and statuses](./work-order-status-booking-status.md). 

  You can create custom booking statuses that work the same way. For example, the "Arrived On Site" booking status in the following screenshot is a custom creation that is also related to the "In progress" Field Service Status. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of active booking statuses.](./media/scheduling-timestamps-booking-statuses.png)

- Make sure your booking statuses are associated with the appropriate Field Service Statuses, per your business needs.

> [!Note]
> Not all booking statuses need to be associated with Field Service Status, nor do they all need to relate to work orders.

## Create timestamps

**Timestamps are created when a booking status is updated**. This happens most often when field technicians update the status of their bookings from the Field Service Mobile app, though booking statuses can also be updated in the back office by dispatchers.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service Mobile on a tablet device, showing the booking status field.](./media/scheduling-timestamps-mobile-status.png)

> [!Note]
> Booking timestamps work when Field Service Mobile is in offline mode. This means that every time a technician changes their booking status, the timestamp documenting the status change is saved locally to the device, and synced to the server when internet access is resumed.

## View timestamps

You can see timestamps by going to the booking (entity name bookableresourcebooking), then **Related** > **Booking Timestamps**, where you can see:

- **Booking Status**: What the status changed to.

- **System Status**: The related Field Service status for work order process, if applicable.

- **Timestamp Time**: The date and time of status change.

- **Timestamp Source**: The device from which the status was changed. If the status was changed from Field Service Mobile, this will read **Mobile**. If the status was changed from the schedule board, it will read **Desktop**. 

Booking timestamps will generate differently based on the setting you chose for the **Timestamp Frequency** field in Field Service Settings.

>[!Note]
> The timestamp frequency setting is available in Public Preview as of February 3, 2020. 

Consider our example of two custom booking statuses, "Arrived on site" and "Wrench time." Both relate to a Field Service status of **In Progress**; assuming the technician first changes the booking status to "Arrived on site" and then "Wrench time," the timestamps will be generated according to the following timestamp frequency settings. 

### Per Field Service Status

> [!div class="mx-imgBorder"]
> ![Screenshot of booking timestamps on a bookable resource booking.](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)

Only the timestamp for "Arrived on site" is generated because with the **Per Field Service Status** setting, timestamps are created when there's a change in the Field Service status of a booking status, and in this example both are considered "In Progress."

### Per Booking Status

>[!Note]
> Available as Public Preview functionality as of February 3, 2020

With the **Per Booking Status** setting, a timestamp is created for all booking status changes regardless if it results in a field service status change.

> [!div class="mx-imgBorder"]
> ![Screenshot of booking timestamps on a bookable resource booking.](./media/scheduling-timestamps-booking-statuses-per-booking.png)

In our example, this means both "Arrived on site" and "Wrench time" are recorded. The main difference is how detailed an organization wants to be for reporting and integration purposes.


## Additional notes 
- Booking timestamps are used to calculate **Booking Journals** that calculate total travel time and working time for a specific booking. From the booking, go to **Related** > **Booking Journals** to see them. The **Timestamp Frequency** setting _does not_ affect how booking journals are created or calculated.