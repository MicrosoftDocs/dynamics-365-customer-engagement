The schedule assistant is a semi-automated feature that helps dispatchers assign requirements to ideal resources.

The schedule assistant recommends resources that match criteria, like availability or skills, for requirements. The system also estimates travel time for the recommended resources, which helps dispatchers plan work accordingly.

When the dispatcher identifies the right resource for the job, they book the resource.

## Launch the schedule assistant

If a requirement is ready for scheduling, you can launch the schedule assistant from various areas.

- Directly from the schedule board: Open the requirements pane, choose a requirement and select **Find availability**.

:::image type="content" source="../../field-service/media/scheduling-assistant-find-availability.png" alt-text="Screenshot showing how to launch the schedule assistant from the schedule board.":::

Select the **Book** option:

- On the record form of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md).
- On the *resource requirement* form.
- On the *[requirement group](../../field-service/multi-resource-scheduling-requirement-groups.md)* form.
- From list view of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md), after selecting a record.

## Schedule assistant filters

After launching the schedule assistant, it populates filters based on criteria like work location, characteristics, territory, resource types, and more. Dispatchers can refine results by adjusting filters to meet their scheduling needs and find the right resource.

<!-- add details for every filter and merge with advanced filters article? -->

## Time zone for schedule assistant search results

View and change the time zone in the **Board view settings** after launching the schedule assistant.

:::image type="content" source="../../field-service/media/schedule-assistant-timezone.png" alt-text="Screenshot of the time zone setting in the schedule assistant.":::

The system derives time zone value from the time zone on the requirement. Open the requirement and select **Modify Calendar** to view and edit the requirement time zone.

## Reschedule bookings

To rebook requirements, you have several options.

- On the schedule board, right-click a booking and select **Rebook**.

:::image type="content" source="../../field-service/media/schedule-assistant-rebook.png" alt-text="Screenshot of the schedule board, showing the rebook option.":::

Select the **Rebook** option:

- On the record form of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md).
- On the *resource requirement* form.
- On the *[requirement group](../../field-service/multi-resource-scheduling-requirement-groups.md)* form.
- From list view of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md), after selecting a record.

## Book the same work order again

You can also schedule the same job to multiple resources with the schedule assistant.

Trigger the schedule assistant for a given work order and book it to a resource's time slot; however, before exiting the search, select another resource's time slot and select **Book** again.

## Next steps

- [Schedule with travel time and distance](/dynamics365/field-service/schedule-with-travel-time)
- [Schedule within time constraints](/dynamics365/field-service/schedule-time-constraints)
- [Schedule work over multiple days](/dynamics365/field-service/schedule-multi-day-work)
