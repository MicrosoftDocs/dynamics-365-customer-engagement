Dispatchers need to be aware of important updates and status changes to ensure accurate schedules and timely job completion. Beyond scheduling, dispatchers might need to ensure billing and customer satisfaction concerns are handled.

**Booking alerts** bring attention to important notifications so that dispatchers can schedule with confidence. Booking alerts display notes and reminders on the schedule board, and can relate to bookings, work orders, users, and other entities. They can be triggered based on timers, set alarms, or workflows.

## Create a booking alert

Booking alerts are often created through automation - either a flow, plugin or through an integration with an external system. They can also be manually created from the schedule board.

1. Open the schedule board, select the **Booking Alerts** icon and select **New Booking Alert**.

   :::image type="content" source="../../field-service/media/create-booking-alert.png" alt-text="Screenshot with callout on the Booking Alerts icon in the schedule board actions section.":::

1. On the **Booking Alert** form, enter **Subject** and **Description** to define the message that appears on the alert.

1. Set the **Due Date** for when the alert shows.

1. Choose a related record in the **Regarding** field to show the alert in the related record's timeline.

1. Choose at least one system user in the **Assignees** field. Each assignee can choose to snooze or dismiss the alert individually.

1. Select **Save & Close**.

You can edit the fields inside a booking alert by editing the **Booking Alert Template** in the schedule board tab settings. For more information, see [schedule board tab settings](/dynamics365/field-service/schedule-board-tab-settings#other-settings).

## View the booking alert

When the due date is reached, the alert appears on the **Booking Alerts** side pane on the schedule board. Assignees can view or snooze the active alert. Assignees can set the snooze time. Assignees can dismiss all alerts.

Alerts for **Bookable Resource Bookings** also show in the schedule board alongside a booking time slot.

When you create a booking alert, the system automatically creates one *Booking Alert Status* record for every assignee so every user can snooze or dismiss alerts individually. When deleting records, keep the relationship *Booking > Booking Alert > Booking Alert Status* in mind.
