---
title: "Booking timestamps | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/15/2020
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

# Booking timestamps

Booking Timestamps are..

- date and time of a booking status change

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)


they are important because 

- reporting
- time keeping
- booking journals

While Dynamics 365 Field Service has always supported capture of booking timestamps when the underlying Field Service setting is changed, many customers extend or change our solution to enable capture of timestamps at the increased frequency of the change of booking status. They use this to drive increased accuracy of costing, to drive deeper understanding of where time goes on each booking and work order, and to drive other extension scenarios.

For customers, changing this logic is complex and often leads to challenges or a redundant set of customer records. It can be challenging to correctly handle in offline scenarios. Field Service has introduced this configuration to simplify implementations for Field Service customers and to allow customers the flexibility of deciding what level of detail they wish to capture when performing work.

This includes:

- Define in Field Service settings the frequency at which timestamps will be captured for each booking.
- Enabling the system to respect that setting regardless of whether the booking status change occurs on the mobile device or via a web browser.
- Capturing appropriate details on the relevant timestamps.
- When a time entry is created from a timestamp, ensure that the time entry holds the right level of detail depending on the org's setting."


## Prerequisites

First verify you have booking statuses in the system that correspond with your business needs. Many booking statuses exist by default and correspond with the work order process. These booking statuses have an associated Field Service Status. For example, the out-of-the-box "In progress" booking status has a Field Service Status of "In progress" and this changes the related work order system status to "Open-In Progress" automatically. To understand how booking statuses and work orders effect each other, see the topic on [work order lifecycle and statuses](./work-order-status-booking-status.md). 

You can create custom booking statuses that work the same way. As an example, the "Arrived On Site" booking status in the image below is a custom creation that is also related to the "In progress" Field Service Status. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses.png)

However, not all booking statuses need to have a Field Service Status and relate to work orders. Imagine a booking status for a booked case.

Next choose how you want booking timestamps to be created.  

Go to **Field Service > Settings > Work Order/Booking section > Timestamp Frequency** 

you have two options for how timestamps are created

1. **Per Field Service Status Change** (default) - choose if you just want timestamps for booking statuses that change the major work order milestones - Scheduled, Traveling, In Progress, Completed
2. **Per Booking Status Change** - choose if you want more granularity and detail especially for custom statuses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-frequency-setting.png)


## Create timestamps

Timestamps are created when a booking status is updated. This happens most often when field technicians update the status of their bookings from the Field Service Mobile app, though booking statuses can also be updated in the back office by dispatchers.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-mobile-status.png)

> [!Note]
> **Booking timestamps work when Field Service Mobile is in offline mode** without internet access. This means that every time a technician changes his or her booking status, whether to "traveling", "In progress" or a custom booking status, the timestamp documenting the status change is saved locally to the device, and synced to the server when internet access is resumed.

You can then view the timestamps by going to the **booking (entity name bookableresourcebooking) > Related > Booking Timestamps** where you can see:


**Booking Status** - status changed to

**System Status** - related field service status for work order process if applicable

**Timestamp Time** - date and time of status change

**Timestamp Source** - interface the booking status was changed from. Typically "Mobile" when technicians change the status from Field Service Mobile and "Desktop" if dispatchers change the status from the schedule board. 


### Per Field Service Status

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)

### Per Booking Status

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-booking.png)


## Configuration considerations


## Additional Notes
- booking journals 