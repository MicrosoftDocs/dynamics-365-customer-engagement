
Requirements can be scheduled across multiple days and weeks. Dispatchers can schedule multi-day work in between existing bookings, by double-booking existing schedules, or as a continuous block of time.

When scheduling multi-day requirements, dispatchers can choose an [allocation method](/dynamics365/project-operations/psa/FAQ-allocation-methods) that defines how to split the duration over multiple days.

> [!TIP]
> If the work you wish to schedule spans multiple weeks or has dependencies on previous steps and milestones, consider using [Dynamics 365 Project Service with Gantt chart functionality](/dynamics365/project-operations/psa/schedule-project-work-breakdown-structure).

## Schedule a multi-day requirement manually on the schedule board

1. Open the schedule board on the hourly view and select a multi-day requirement in the requirements pane.

1. Then, select a resource on the board for which you would like to schedule the multi-day work order requirement and select **Book**.

    <!--needs better screenshot-->

    :::image type="content" source="../../field-service/media/scheduling-board-multi-day-booking.png" alt-text="Screenshot of the scheduling board with a multi-day requirement.":::

    > [!CAUTION]
    > Don't drag and drop multi-day requirement to a resource on the hourly board view. It will create a long continuous booking through non-working hours.

1. In the **Create Booking** pane, review and update the values as needed. Choose the **Booking Method** to define how to spread the requirement over multiple days.

    - Full Capacity: Books the resource’s full capacity for the specified from and to dates without regard to the resource's remaining capacity.
    - Remaining Cpacity: Books the resource’s available capacity within the specified date range.
    - Percentage Capacity: Books the resource for a percentage of capacity for the specified from and to dates.
    - Evenly Distribute Hours: Books the resource for a specified number of hours, distributing the time evenly per day over the specified from and to dates.
    - Front Load Hours: Books the resource for a specified number of hours, front-loading the per-day hours over the specified from and to dates. The front load method considers existing bookings and available capacity.
    - Fixed Time: Books the resource regardless of working hours for the time frame you define when creating the booking.

    > [!NOTE]
    > Full Capacity, Percentage Capacity, Evenly Distribute Hours, and Fixed time can lead to overbooking.

1. Select **Book** and the system creates multiple bookings across multiple days.

## Schedule a multi-day requirement with the schedule assistant

> [!Note]
> This scenario schedules a requirement without a related work order. To schedule a multi-day work order with the schedule assistant, you'll need to manually add a related requirement with an allocation method to a work order and delete or disregard the automatically created one. Alternatively, you can manually create requirement detail records with **Specify Pattern** for the auto-created requirement. This is because you need to set an allocation method before saving and the requirements that are automatically created by work orders have an allocation method of **None** by default.

1. Create a multi-day requirement record with an allocation method set. Provide details such as skills, roles, resource preferences, and service territory to define the eligible resources.

1. On the requirement records, go to **Related** > **Requirement Details**.

<!-- don't understand how the splitting happens and responds to calendar change, this seems a bit confusing.-->

Requirement details are automatically created to split up the requirement into time segments and are based on the duration and the allocation method. In our example in the following screenshot, a 30-hour requirement split up between 5 days is 6 hours, or 360 minutes each day.  

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource requirement details.](../../field-service/media/scheduling-multi-day-requirement-30-requirement-details.png)

The requirement details are based on the requirement's calendar, which you can edit by selecting **Modify Calendar** in the top ribbon of the requirement.

Then select **Book** to trigger the schedule assistant for this multi-day requirement.

Resources with availability and that meet the other attributes will show as results. Simply select a resource, the dates, and then **Book**. This will create multiple bookings across the date range according to the pattern of the allocation method.

## Schedule a multi-day requirement to multiple resources

First, need to manually create a multi-day requirement. The requirement can exist on its own or be related to a work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource requirement window with multiple days selected.](../../field-service/media/scheduling-multi-2-person-requirement.png)

From the newly created requirement, go to **Related** > **Requirement Details** then choose **Specify Pattern** from the top ribbon. 

This allows you to edit and override the requirement details pattern created by the allocation method.

Select **Book**.

Select a resource and specific days for just that resource, then choose **Book** (*not* **Book & Exit**, as that will close the schedule assistant)

Then choose another resource and specific days for only that resource. Then choose **Book** again.

Bookings are created for each resource on the days selected. Availability for each scheduled resource is updated as well.

## Configuration considerations

- Each requirement has its own calendar that you can view and edit from the **Modify Calendar** option in the top ribbon menu. The calendar is important because it allows you to edit the time zone of the requirement and how the schedule assistant results should be displayed.

> [!div class="mx-imgBorder"]
> ![Screenshot of the modify calendar window.](../../field-service/media/scheduling-multi-day-requirement-30-modify-calendar.png)

- Availability does not need to be continuous. For example, if a dispatcher needs to schedule a resource for 4 hours one day, that resource will show as available as long as there is 4 total hours of availability, not necessarily in a single block. 
- You can manually create requirement details as needed to schedule multi-day work according to a custom pattern. 

## Additional notes
- Requirement groups cannot be scheduled for multiple days. 
- The schedule assistant will filter available resources for multi-day work by their location, but travel time will not be calculated and added to the resulting bookings.

### Next steps

- [Allocation methods](/dynamics365/project-operations/psa/FAQ-allocation-methods)
- [Multi-resource scheduling](../../field-service/multi-resource-scheduling-requirement-groups.md)
