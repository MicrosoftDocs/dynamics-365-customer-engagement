---
title: Booking lock options in Resource Scheduling Optimization | MicrosoftDocs"
ms.custom: dyn365-fieldservice
ms.date: 01/29/2019
ms.reviewer: krbjoran
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: activate-fs-mobile-app-license
ms.author: daclar
author: FieldServiceDave
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# Understanding the booking lock option

You can schedule lock options. There are four types:

1. **Time Range**: RSO is able to move bookings with this lock option within
    certain time ranges (ensure Estimated Arrival Time falls into this time
    range). RSO is also able to reassign bookings to other resources by
    respecting this time range and the following time-related fields.

   - If **Date Window Start** and **Date Window End** are set as 5/25/2018,
       this indicates you want RSO to reoptimize this booking on 5/25/2018 and
       time of day doesn’t matter.

     > [!div class="mx-imgBorder"]
     > ![](media/ff525574bddea8e5b50adbb2e1381267.png)

   - If **Time Window Start** and **Time Window End** are set as shown in the folloing
     screenshot, it indicates you want RSO to schedule the booking from 3 AM to 6
     AM and date doesn’t matter.

     > [!div class="mx-imgBorder"]
     > ![](media/79a74b15392b9d62cdef7c9334e65520.png)

   - If **Time From Promised** and **Time To Promised** are set as shown in the following
     screenshot, it indicates you want RSO to schedule a booking between 4 AM and
     10 AM on 5/24/2018 and it has to be within that specific date and specific
     time range.

     > [!div class="mx-imgBorder"]
     > ![](media/15e2c158dedd80554b7eb933d6c57122.png)

   - If **Date Window Start/End** and **Time From/To Promised** are set as shown
     in the following screenshot, it indicates you want RSO to schedule a booking between
     3 AM and 6 AM on 5/25/2018.

     > [!div class="mx-imgBorder"]
     > ![](media/1da5485805579d347ce208cdcde0a22c.png)

     > [!NOTE]
     > - If these fields conflict, RSO uses **Time From Promised** and **Time To
     Promised** first. Then it either uses one or a combination of the other
     fields.
     > - RSO will ensure that the estimated arrival time falls into the window
     specified previously. It does not guarantee that the booking’s end time will
     fall within the time window.

2. **Resource**: RSO is able to move bookings to other times, but has to keep
    the same resource.

3. **Time**: RSO is able to move bookings to other resources but has to keep
    the same estimated arrival time.

4. **Resource and Time**: RSO can’t move bookings to any other resource or any
    other time, but it can make some changes. RSO will preserve the estimated
    arrival time and assigned resource. The booking’s start time and estimated
    travel duration may be changed if RSO schedules a booking in a new location
    before this is a locked booking.
