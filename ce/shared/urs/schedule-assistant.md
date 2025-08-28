The schedule assistant helps dispatchers assign requirements to ideal resources.

It recommends resources that match criteria, like availability or skills, for requirements. The system also estimates travel time for the recommended resources, which helps dispatchers plan work accordingly.

When the dispatcher identifies the right resource for the job, they book the resource.

## Launch the schedule assistant

If a requirement is ready for scheduling, you can launch the schedule assistant from various areas.

- Directly from the schedule board: Open the requirements pane, choose a requirement, and select **Find availability**. Using the schedule assistant on the schedule board lets you [configure your schedule board](../../field-service/work-with-schedule-board.md) view to your needs.

  :::image type="content" source="../../field-service/media/scheduling-assistant-find-availability.png" alt-text="Screenshot showing how to launch the schedule assistant from the schedule board.":::

- Select the **Book** option from one of the following areas:

  - The record form of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md). Schedule assistant uses that entity's associated time zone. You can view or change the time zone by opening the entity and selecting **Modify Calendar** in the command bar.
  - The *resource requirement* form.
  - The *[requirement group](../../field-service/multi-resource-scheduling-requirement-groups.md)* form.
  - The list view of a [scheduling-enabled entity](../../field-service/schedule-new-entity.md), after selecting a record.

## Schedule assistant filters

After launching the schedule assistant, the Schedule Assistant Filter pane displays. Refine results to find the right resource using the filters like work location, characteristics, territory, resource types, and more. 

By default, the search range filter is set to match the requirement's **From Date** and **To Date**, which can be adjusted. For multiday requirements, ensure that each requirement detail that needs to be booked is within schedule assistant's start and end dates.

> [!NOTE]
> Using customizations to change the From and To Date fields or otherwise modifying these time components with custom plugins isn't supported and might cause errors.

The default limit for searching resource availability is 100 entries, but it can be increased up to a maximum of 1,000. For organizations with a large number of resources, this default might result in incomplete search results. To increase the limit, adjust the *Resource Availability Retrieval Limit* in [*Booking Setup Metadata*](../../field-service/schedule-new-entity.md#edit-settings-for-enabled-entities). Increasing the limit might affect search performance.

If you book outside Schedule Assistant's recommended slots, constraints such as capacity, work hours, and time windows aren't verified or enforced.

## Time zone for schedule assistant search results

View and change the time zone in the **Board view settings** after launching the schedule assistant.

:::image type="content" source="../../field-service/media/schedule-assistant-timezone.png" alt-text="Screenshot of the time zone setting in the schedule assistant.":::

The system derives the time zone value from the time zone on the requirement when launched from the schedulable entity. Open the requirement and select **Modify Calendar** to view and edit the requirement time zone. When launched from the schedule board with **Find availability**, the system derives the time zone value from the schedule board settings record.

## Reschedule bookings

To rebook a requirement:

1. Go to the schedule board, right-click a booking, and then select **Rebook**.

   :::image type="content" source="../../field-service/media/schedule-assistant-rebook.png" alt-text="Screenshot of the schedule board, showing the rebook option.":::

1. Select the **Rebook** option after selecting a record.

## Book the same work order again

You can also schedule the same job to multiple resources with the schedule assistant.

Trigger the schedule assistant for a given work order and book it to a resource's time slot; before exiting the search, select another resource's time slot and select **Book** again.

## Next steps

- [Schedule with travel time and distance](/dynamics365/field-service/schedule-with-travel-time)
- [Schedule within time constraints](/dynamics365/field-service/schedule-time-constraints)
- [Schedule work over multiple days](/dynamics365/field-service/schedule-multi-day-work)
