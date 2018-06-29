---

title: Schedule optimization
author: shellyhaverkamp
manager: shellyha
ms.date: 06/08/2018
ms.topic: article
ms.custom:
  - dyn365-fieldservice
ms.service: dynamics-365-customerservice
ms.author: shellha

---

Schedule optimization
=====================

Publishing schedules
--------------------

### Optimization status code 

- **Unpublished**: Default status when a schedule is created or after a reset.

- **Publishing**: The system is trying to publish schedules.

- **Published**: The system published a schedule and it’s good to run.

- **Out of Sync**: Changes made against the schedule require it to be
    published again.

- **Under Maintenance**: Indicates someone is upgrading the RSO to a newer
    version.

- **Failed**: System failed to publish schedules for various reasons.

    - The user is able to see the error details on the form of the schedule.

    - A typical error would be that the SASKey has not been configured,
        meaning RSO Azure resources are not set up correctly.

      > [!div class="mx-imgBorder"]
      > ![](media/6e42a1e32814b0bb5fd4e39134c5b5a1.png)

### Buttons and functions for optimization schedules 

- **PUBLISH**: After creating and saving the schedules, you need to publish
    them. Notice the **Status** in this screenshot is **Unpublished**. To
    publish, click **Publish** in the upper left.

    > [!div class="mx-imgBorder"]
    > ![](media/bbe38ac8b3f58d5e4efa2ba02569aedd.png)

- **PUBLISH ALL**: Publishes all schedules.

- **RESET RESOURCE SCHEDULING OPTIMIZATION**: Cancels all pending RSO jobs and
    unpublishes all schedules.

The next screenshot shows the publish status of the schedule, the date it was last modified, and the next scheduled run date and time.

> [!div class="mx-imgBorder"]
> ![](media/23236bac372efcec3f509581b6eeb026.png)

- **RUN NOW**: Run RSO on demand, regardless of the timer setting.

  > [!NOTE]
  > RUN NOW is also an API. The user can call this API to run RSO per their business needs. For example, whenever there is a P1 work order requirement, you can re-run RSO right away.

  > [!div class="mx-imgBorder"]
  > ![](media/aca2f6dd56b36554da71ec18db377610.png)

Monitoring optimization requests
--------------------------------

Once a schedule has been published, you can open it and monitor the scheduling optimization requests (RSO jobs). You can drill into each of these to see the bookings associated with that RSO job run.

> [!div class="mx-imgBorder"]
> ![](media/98f6a265bb86b85773c06dcb989447f1.png)

1. You can see which resources are being optimized, and which are not (and for
    what reason).  
    
    > [!div class="mx-imgBorder"]
    > ![](media/6de4990e642d4562abf53d7d7c611ae4.png)
 
    > [!div class="mx-imgBorder"]
    > ![](media/1df29d0660d6ec43db91d6225ebed17a.png)

2. You can view booking details as well as analytic charts showing how many
    hours of travel time versus how many work hours are scheduled for this run.

    > [!div class="mx-imgBorder"]
    > ![](media/90184c1cc8f19a3d3bb9aeea31eed69d.png)

Leveraging the schedule board to review optimization results 
-------------------------------------------------------------

With schedule board integration, you can:

- Better understand the optimization scope.
- View optimization results in a visualized way.
- More easily analyze failed optimization requests.
- Create a new schedule on the fly.

**How to get there:** Navigate to your Optimization Schedules, select your schedule, and click **SCHEDULE BOARD** on the grid view, or open the Optimization Schedules record form and click **SCHEDULE BOARD** on the form.

> [!div class="mx-imgBorder"]
> ![](media/c7f68e46401aff45535576fb1176baf7.png)

</br>

> [!div class="mx-imgBorder"]
> ![](media/0cf8f7f1138f3f06eed053bb175a2412.png)

</br>

**Feature Details**: After clicking **SCHEDULE BOARD**, you will see the
following:

> [!div class="mx-imgBorder"]
> ![](media/103235c890fd2d8b65bf7ab21e067400.png)

1. In the Filter section, the system prepopulated filters match **Scope** \>
    **Resource** view.

2. The **Open and eligible for optimization** tab shows all eligible
    unscheduled requirements that match scope definition, requirement range, and
    requirement state setting.

3. The **Eligible for optimization** tab shows all eligible unscheduled
    requirements as well as any eligible bookings to be re-optimized that match
    scope definition, requirement range, and requirement state setting.

4. The **Excluded from optimization** tab shows any eligible requirements or
    bookings that fail to be optimized for certain reasons (such as invalid
    longitude/latitude).

5. The icon and tooltip indicate resources not in the optimization scope.

    > [!div class="mx-imgBorder"]
    > ![](media/788cb6d9aafe0054cc7f80104b1c9118.png)

6. The lock icon and tooltip indicate that the booking has been locked.

    > [!div class="mx-imgBorder"]
    > ![](media/bc24e45a8cb7c5b1abbe5bcf1dc9582c.png)

7. Yellow lines indicate the start and end time for the optimization range.

    > [!div class="mx-imgBorder"]
    > ![](media/9d7bade5e07d6be6a9de9eb71f0767fb.png)

8. **From** / **To** date and time match the time range defined in the
    optimization scope. You can continue to modify and save the changes back to
    the original scope. If the same scope is being referenced by multiple
    optimization schedules, the change will apply to all of these schedules with
    the same scope.

    > [!div class="mx-imgBorder"]
    > ![](media/bb08f80f5a17873c061505d0f5b805cd.png)

9. Select a goal and click **Run Now** to trigger an on-demand optimization
    request.

    > [!div class="mx-imgBorder"]
    > ![](media/2a968cbadafd96d1881d1e01053b8680.png)

10. The optimization request will show the status and details. If an exception
    occurs, select a specific optimization request to open it. You can view
    booking details as well as analytic charts showing how many hours of travel
    time versus how many work hours are scheduled for this run.

Understanding the booking lock option 
--------------------------------------

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

    - If **Time Window Start** and **Time Window End** are set as shown in this
    screenshot, it indicates you want RSO to schedule the booking from 3 AM to 6
    AM and date doesn’t matter.

    > [!div class="mx-imgBorder"]
    > ![](media/79a74b15392b9d62cdef7c9334e65520.png)

    - If **Time From Promised** and **Time To Promised** are set as shown in this
    screenshot, it indicates you want RSO to schedule a booking between 4 AM and
    10 AM on 5/24/2018 and it has to be within that specific date and specific
    time range.

    > [!div class="mx-imgBorder"]
    > ![](media/15e2c158dedd80554b7eb933d6c57122.png)

    - If **Date Window Start/End** and **Time From/To Promised** are set as shown
    in this screenshot, it indicates you want RSO to schedule a booking between
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
