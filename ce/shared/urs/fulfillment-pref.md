Fulfillment preferences customize how the schedule assistant will display results for single-day requirements. By default, the schedule assistant shows results based on resource schedules and the earliest available time. Fulfillment preferences include intervals and time groups, or a combination of them.

## Intervals

Intervals define the length of the times slots the schedule assistant results will be displayed in, and the start time for subsequent bookings. For example, with 30-minute intervals, the schedule assistant will display a resource available at 9:27 AM as available at 9:30 AM and will book the start time (arrival time) for 9:30 AM. This includes travel time for onsite requirements and work orders, meaning travel time will begin before 9:30 AM, and a field resource will arrive and start work at 9:30 AM.

## Time groups

Time groups enable schedulers to search and view results as blocks of time when using the schedule assistant. Unlike intervals, time groups don't influence the start time of subsequent booking. Unlike intervals, time groups **do not dictate the start time of subsequent bookings**. Time groups organize results, but leave the start time/arrival time as-is, based on the particular resource's schedule.

For example, a heating and cooling company wants to group air-conditioning installations in two blocks. They create morning (8:00 AM to 12:00 PM) and afternoon (1:00 PM to 5:00 PM) blocks, with a 1-hour break for lunch in between. They communicate a morning or afternoon time range to customers for when the installation crew arrives.

## Create a fulfillment preference

1. In Universal Resource Scheduling, open the Settings area. Under **Scheduling**, select **Fulfillment Preferences** and select **New**.

1. Enter a **Name** and **Save** the record.

1. To define an interval, go to the **Interval** tab.
   - Choose an **Interval** to define the duration between two available time slots. 
   - Set the time for **Intervals begin** to define the start time for when options are available, depending on resource availability and working hours. 
   - Enter the number of **Results per Interval** to limit how many options the system presents for a time slot.

   :::image type="content" source="../../field-service/media/fulfillment-preferences-interval.png" alt-text="Screenshot fo a fulfillment preferences record on the Intervals tab.":::

1. To add a time group, go to the **Details** tab and select **New Time Group Detail**. Enter a **Name** and choose a **Start Time** and **End Time**.

   :::image type="content" source="../../field-service/media/fulfillment-preferences-time-group.png" alt-text="Screenshot of a time group record.":::

### Associate fulfillment preference to a requirement or requirement group

Open a requirement and go to the **Schedule** tab to choose the **Fulfillment Preference**. For a requirement groups, you can choose it in the **Fulfillment Preference** column.

### Book a requirement

Open a resource requirement and select **Book** to schedule the requirement. You'll notice that the start and end times match the fulfillment preference you defined for the requirement.

## Using intervals and time groups together

You can add both an interval and a time group to the same fulfillment preference, but this requires a few important considerations.

- Don't add a value for **Interval Begins**. The interval will begin at the time of the earliest time group.

- If the **Reset Interval per Time Group Detail** option is set to **Yes**, the intervals will reset once a new time group detail overlaps with an interval.

  For example, a business offers appointments every 90 minutes, so intervals are set to 90 minutes. Additionally, they separate into morning and afternoon time groups of 8:00 AM to 12:00 PM and 1:00PM to 5:00 PM, with a 1-hour lunch in between.

  - If the **Reset Interval per Time Group Detail** is set to **No**, the appointments would be:

    8:00 AM, 9:30 AM, 11:00 AM (not 12:30 PM because this is blocked for lunch), 2:00 PM, and 3:30 PM.

  - If the **Reset Interval per Time Group Detail** is set to **Yes**, the appointments would be:

    8:00 AM, 9:30 AM, 11:00 AM, (not 12:30 PM because this is blocked for lunch), **1:00 PM** (resetting for the next time group detail), 2:30 PM, and 4:00 PM.
