The schedule assistant helps dispatchers assign requirements to ideal resources.

It recommends resources that match criteria, like availability or skills, for requirements. The system also estimates travel time for the recommended resources, which helps dispatchers plan work accordingly.

When the dispatcher identifies the right resource for the job, they book the resource.

## Launch the schedule assistant

If a requirement is ready for scheduling, you can launch the schedule assistant from various areas.

- Directly from the schedule board: Open the requirements pane, choose a requirement, and select **Find availability**. Using the schedule assistant on the schedule board lets you [configure your schedule board](../../field-service/work-with-schedule-board.md) view to your needs.

:::image type="content" source="../../field-service/media/scheduling-assistant-find-availability.png" alt-text="Screenshot showing how to launch the schedule assistant from the schedule board.":::

Select the **Book** option:

- On the record form of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md). Schedule assistant uses that entity's associated time zone. You can view or change the time zone by opening the entity and selecting **Modify Calendar** in the command bar.
- On the *resource requirement* form.
- On the *[requirement group](../../field-service/multi-resource-scheduling-requirement-groups.md)* form.
- From list view of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md), after selecting a record.

## Schedule assistant filters

After launching the schedule assistant, it populates filters based on criteria like work location, characteristics, territory, resource types, and more. Dispatchers can refine results by adjusting filters to meet their scheduling needs and find the right resource.

By default, the search range filter will be set to match the requirement's From Date and To Date. This can also be adjusted in the filters pane. For multiday requirements, ensure that each requirment detail that needs to be booked is within schedule assistant's start and end dates.

> [!NOTE]
> Using customizations to change the From and To Date fields or otherwise modifying these time components with custom plugins is not supported and may cause errors.   

The default search resource availability limit is 100 entries, which can be expanded to a maximum of 1,000 entries. For organizations with a large number of resources, search might be incomplete. You can customize the *Resource Availability Retrieval Limit* of *Booking Setup Metadata* to increase the limit. However, it can decrease the search performance.

> [!NOTE]
>  When booking outside Schedule Assistant's recommended slots, no constraints are verified or enforced including capacity, work hours, or time windows.

## Time zone for schedule assistant search results

View and change the time zone in the **Board view settings** after launching the schedule assistant.

:::image type="content" source="../../field-service/media/schedule-assistant-timezone.png" alt-text="Screenshot of the time zone setting in the schedule assistant.":::

The system derives time zone value from the time zone on the requirement. Open the requirement and select **Modify Calendar** to view and edit the requirement time zone.

## Reschedule bookings

To rebook requirements, you have several options.

- On the schedule board, right-click a booking and select **Rebook**.

:::image type="content" source="../../field-service/media/schedule-assistant-rebook.png" alt-text="Screenshot of the schedule board, showing the rebook option.":::

Select the **Rebook** option after selecting a record.

## Book the same work order again

You can also schedule the same job to multiple resources with the schedule assistant.

Trigger the schedule assistant for a given work order and book it to a resource's time slot; however, before exiting the search, select another resource's time slot and select **Book** again.

## Next steps

- [Schedule with travel time and distance](/dynamics365/field-service/schedule-with-travel-time)
- [Schedule within time constraints](/dynamics365/field-service/schedule-time-constraints)
- [Schedule work over multiple days](/dynamics365/field-service/schedule-multi-day-work)
