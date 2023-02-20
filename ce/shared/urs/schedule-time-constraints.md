When scheduling an entity enabled for scheduling, set date and time parameters to control when to book the requirement.

The time parameter fields **Time From/To Promised** and **Time Window Start/End** all exist on the resource requirement entity. Use these fields when scheduling entities other than work orders.

> [!NOTE]
> Field Service doesn't support variable calendars, which limit scheduling to certain days and times. For example, if a customer requests completion of the work order on Monday, Wednesday, or Friday between 12:00 PM and 5:00 PM.  As a workaround, use notes to inform the dispatcher of the customer's preferences or [create booking rules](../../field-service/set-up-booking-rules.md) that use custom logic with JavaScript.

## Schedule a requirement in a time frame

Schedule a requirement to between a start and end date and time.

On the **Settings** tab of a work order, set the **Time From/To Promised** fields to define the date window in which a resource must arrive and complete the work. These values automatically populate the corresponding fields on the related resource requirement and vice versa.

:::image type="content" source="../../field-service/media/work-order-time-window.png" alt-text="Screenshot of the time window preferences on a work order form.":::

When searching for suitable resources to work on the requirements, the schedule assistant populates the filters accordingly. Resources available for the entire duration show as options.

> [!TIP]
> Use [service level agreements (SLAs) for work orders](../../field-service/sla-work-orders.md) to automatically populate promised time and help dispatchers schedule to meet the SLAs.

## Set a time zone for the requirement

Define a time zone on the requirement to help dispatchers view schedule assistant results in the time zone of the customer. On a requirement, select **Modify Calendar** and choose a time zone from the dropdown.

When you book the requirement, the start times of the schedule results will reflect the selected time zone.

<!-- do we want to keep this information for RSO and move it to their docs?

## Scenario 3: Automated scheduling with time parameters (RSO)

In our next scenario, an inspection work order needs to automatically be scheduled in the afternoon within a date range.

To automatically schedule work orders and other entities, you must use the Resource Scheduling Optimization app (RSO). Unlike the schedule assistant and the schedule board, RSO will consider all 3 time parameters when automatically booking work orders to resources.

First, on the work order, set a date range in the **Date Window Start** and **Date Window End**. 

Next, set a **Time Window Start** and **Time Window End** that represents a time of day the work order should be automatically scheduled.

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order set to Active for fifty seven minutes.](../../field-service/media/scheduling-time-constraint-work-order-rso-window.png)

> [!Note]
> For this scenario, we recommend using **Date Window** along with **Time Window** rather than **Time Promised**, as **Time Promised** will take priority over the other parameters during optimization.

When setting up RSO, make sure **Scheduling Windows** is a constraint in the optimization goal you are running RSO with. For more information, see the [topic on RSO configuration](../../field-service/rso-configuration.md). If you're new to RSO, see the [RSO quickstart guide](../../field-service/rso-quickstart.md).


> [!div class="mx-imgBorder"]
> ![Screenshot of a scheduling optimization goal, highlighting the scheduling windows constraint.](../../field-service/media/scheduling-time-constraint-work-order-rso-goal.png)

After running RSO, you'll see the results on the schedule board. In our example, the work order could have been scheduled for either 9/12 or 9/13 based on the date window of the work order; whichever day it is scheduled, it should be scheduled in the afternoon between 12:00 PM and 5:00 PM. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, with an arrow pointing to the correct time.](../../field-service/media/scheduling-time-constraint-work-order-rso-schedule-board.png) -->

## Customize start and end date fields

You can customize which fields serve as the start and end dates for the related requirement in the booking setup metadata. In the Resources area, under **Administration**, select **Booking Setup Metadata**. Select the entity name and go to the **Attribute Mapping** section to choose any date/time field you want to use.

:::image type="content" source="../../field-service/media/scheduling-customize-booking-dates.png" alt-text="Screenshot of the attribute mapping section in the booking setup metadata entity with callouts on the date fields.":::

## Next steps

- [Define intervals and time groups with fulfillment preferences](../../field-service/set-up-time-groups.md)
- [Set up booking rules](../../field-service/set-up-booking-rules.md)