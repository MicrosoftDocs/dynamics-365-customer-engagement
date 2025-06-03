Requirements can be scheduled across multiple days and weeks. Dispatchers can schedule multi-day work in between existing bookings, by double-booking existing schedules, or as a continuous block of time.

> [!TIP]
> If the work you wish to schedule spans multiple weeks or has dependencies on previous steps and milestones, consider using [Dynamics 365 Project Service with Gantt chart functionality](/dynamics365/project-operations/psa/schedule-project-work-breakdown-structure).

## Schedule a multi-day requirement manually on the schedule board

Manually scheduling a multi-day requirement on the schedule board allows you to choose the allocation method to determine the breakdown of the bookings created when scheduling.

If you're using requirement details to define the allocation method, manually scheduling the requirement on the schedule board ignores them. Use the [schedule assistant](#schedule-a-multi-day-requirement-with-the-schedule-assistant) instead.

1. Create a multi-day requirement record. Provide details such as skills, roles, resource preferences, and service territory to define the eligible resources, if applicable.

1. Go to **Resource Scheduling** > **Schedule Board**.

1. Change the view to daily, weekly, or monthly.

   > [!CAUTION]
   > Don't drag and drop multi-day requirement to a resource on the hourly board view. It creates a long continuous booking through nonworking hours.

1. Select the multi-day requirement in the requirements pane.

1. Select a resource on the board for which you would like to schedule the multi-day work order requirement and select **Book**.

    :::image type="content" source="../../field-service/media/scheduling-board-multi-day-booking.png" alt-text="Screenshot of the scheduling board with a multi-day requirement.":::

1. In the **Create Booking** pane, review and update the values as needed. Choose the **Booking Method** to define how to spread the requirement over multiple days. For more information, go to [booking allocation method](/dynamics365/project-operations/psa/FAQ-allocation-methods).

    - Full capacity: Books the resource’s full capacity for the specified from and to dates without regard to the resource's remaining capacity or the duration of the requirement.
    - Remaining capacity: Books the resource's remaining capacity for the specified from and to dates.
    - Percentage capacity: Books the resource for a percentage of capacity for the specified from and to dates.
    - Evenly Distribute Hours: Books the resource for a specified number of hours, distributing the time evenly per day over the specified from and to dates.
    - Front Load Hours: Books the resource for a specified number of hours, front-loading the per-day hours over the specified from and to dates. The front load method considers existing bookings and available capacity.

    > [!NOTE]
    > Full Capacity, Percentage Capacity, and Evenly Distribute Hours can lead to overbooking.

1. Select **Book** and the system creates multiple bookings across multiple days.

## Schedule a multi-day requirement with the schedule assistant

This scenario schedules a requirement *without* a related work order. The requirement needs an allocation method set before saving and the requirements that are automatically created by schedulable entities such as work orders have an allocation method of **None** by default.

> [!NOTE]
> To schedule a multi-day work order with the schedule assistant, manually add a related requirement with an allocation method and delete or disregard the automatically created ones. Alternatively, you can manually [create requirement detail records with **Specify Pattern**](#specify-patterns-for-requirements).

1. Create a multi-day requirement record with an allocation method set. Provide details such as skills, roles, resource preferences, and service territory to define the eligible resources.

1. On the requirement record, select **Related** > **Requirement Details**.

   The system automatically creates requirement details and splits them into segments based on the duration and the allocation method. The requirement details are based on the requirement's calendar. Edit them by selecting **Modify Calendar** on the resource requirement record.

    :::image type="content" source="../../field-service/media/scheduling-multi-day-requirement-30-requirement-details.png" alt-text="Screenshot of resource requirement details.":::

1. Select **Book** to launch the schedule assistant for the multi-day requirement.

1. Resources with availability that also meet the other attributes show as results. Choose a resource, the dates, and select **Book** to create multiple bookings according to the pattern of the allocation method.

Alternatively, you can set up a work hours template, which you can assign to a resource requirement. The system generates resource requirements details based on the work hours template.

## Specify patterns for requirements

You can define how to split a long-running requirement into individual bookings. With patterns, you can customize the requirement details beyond the default allocation methods.

### Create patterns for requirements

1. Create a multi-day requirement record. Provide details such as skills, roles, resource preferences, and service territory to define the eligible resources. Select **Save**.

1. Select **Specify Pattern**. Then, select **Add detail**.

1. Choose the requirement and set the duration, start time, and end times for the time window. Then select **Apply**.

   For example, the time window is from 9 AM to 5 PM with a three hour duration. When you schedule that requirement detail, the system books a resource for three hours between 9 AM and 5 PM. The duration must be shorter than the time window.

1. Add as many detail records as needed. Then select **Save**.

1. Use the schedule assistant to book the requirement.

### Edit patterns for requirements

To edit existing requirement details made with patterns, select the requirement and then **Specify Pattern**.

1. To edit one requirement detail, select it. The **Edit detail** pane appears. Change the duration or time window and save the changes.

   To edit multiple details at once, select the requirement and select **Edit all within range** on the details pane.

1. Under **Duration summary**, each date range that has at least one detail shows. Adjust the allocated duration where needed. To delete, select the ellipsis (**&hellip;**) to the left of duration and then select **Delete**.

   :::image type="content" source="../../field-service/media/scheduling-multi-day-requirement-edit-pattern.png" alt-text="Screenshot of Edit details pane for Specify Pattern.":::

1. Use the settings under **Duration allocation** to control how to distribute the changed durations across multiple details.

   When decreasing duration, there are two options:

   - **Proportionally distributed**: The decrease in duration is split among all contained details in proportion to their respective durations, so that all decrease by the same percentage.
   - **Subtracted from total**: The decrease is subtracted from the total length of all contained details. This new total is then evenly distributed among contained details.

   When increasing duration, there are four options:

   - **Proportionally distributed**: The increase in duration is split among all contained details in proportion to their respective durations, so that all increase by the same percentage.
   - **Front loaded**: The increase in duration is added to the first contained detail until it hits capacity. Then it's added to the next detail and so on.
   - **Distributed evenly**: The increase is split evenly among all contained details.
   - **Added to total**: The increase is added to the total length of all contained details. This new total is then evenly distributed among all contained details.

1. Use the schedule assistant to book the requirement.

## Schedule a multi-day requirement to multiple resources

1. From a multi-day resource requirement, go to **Related** > **Requirement Details** and select **Specify Pattern**. Edit and override the requirement details pattern created by the allocation method.

1. Select **Book**.

1. Choose a resource and specific days for just that resource, then select **Book** (*not* **Book & Exit**).

1. Then, choose another resource and specific days for only that resource and select **Book** again.

1. The system creates bookings for each resource on the days selected.

> [!NOTE]
>
> - Resources don't need continuous availability in a single block. For example, if the requirement is a resource for five hours in a day, resources with five total hours of availability show in schedule assistant results.
>
> - The system can't schedule requirement groups for multiple days.

## Next steps

- [Allocation methods](/dynamics365/project-operations/psa/FAQ-allocation-methods)
- [Multi-resource scheduling](../../field-service/multi-resource-scheduling-requirement-groups.md)
