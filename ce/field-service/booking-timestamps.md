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


they are importqant because 

you have two options for how timestamps are created

1. Per Field Service Status Change (default) - choose if you jsut want timestamps on the major work order milestones - Scheduled, Traveling, In Progress, Completed
2. Per Booking status change - choose if you want more granularity and detail especially for custom statuses.

## Prerequisites


> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses.png)


First choose how you want booking timestamps to be created.  

Go to **Field Service > Settings > Work Order/Booking section > Timestamp Frequency** 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-frequency-setting.png)





> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-mobile-status.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-fs-status.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-timestamps-booking-statuses-per-booking.png)


## Configuration considerations
- works offline

## Additional Notes
- booking journals 