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


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)




they are important because 

- reporting
- time keeping
- booking journals


## Prerequisites


> [!Note]
>

First verify that you have booking statuses For more information on booking statuses see the topic on [work order lifecycle and statuses](./work-order-status-booking-status.md).


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses.png)


Next choose how you want booking timestamps to be created.  

you have two options for how timestamps are created

Go to **Field Service > Settings > Work Order/Booking section > Timestamp Frequency** 

1. **Per Field Service Status Change** (default) - choose if you just want timestamps for booking statuses that change the major work order milestones - Scheduled, Traveling, In Progress, Completed
2. **Per Booking Status Change** - choose if you want more granularity and detail especially for custom statuses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-frequency-setting.png)


## Create timestamps

Timestamps are created when a booking status is updated. This happens most often when field technicians update the sattus of their bookings from the Field Service Mobile app, though booking statuses can also be updated in the back office by dispatchers for example.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-mobile-status.png)

> [!Note]
> **Booking timestamps work when Field Service Mobile is in offline mode** without internet access. This means that every time a technician changes his or her booking status, whether to "traveling", "In progress" or a custom booking status, the timestamp documenting the status change is saved locally to the device, and synced to the server when internet access is resumed.

### Per Field Service Status

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)

### Per Booking Status

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-booking.png)


## Configuration considerations


## Additional Notes
- booking journals 