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

## Customize start and end date fields

You can customize which fields serve as the start and end dates for the related requirement in the booking setup metadata. In the Resources area, under **Administration**, select **Booking Setup Metadata**. Select the entity name and go to the **Attribute Mapping** section to choose any date/time field you want to use.

## Next steps

- [Define intervals and time groups with fulfillment preferences](../../field-service/set-up-time-groups.md)
- [Set up booking rules](../../field-service/set-up-booking-rules.md)