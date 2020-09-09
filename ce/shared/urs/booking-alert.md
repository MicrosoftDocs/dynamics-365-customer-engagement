While managing resources and scheduling, dispatchers must be aware of important updates and status changes to ensure accurate schedules and timely job completion. For example, a dispatcher needs to know if a field technician is running late or that prerequisites for a job have not been met so that they can take appropriate actions. Beyond scheduling, dispatchers may also need to ensure billing and customer satisfaction concerns are handled.

In Dynamics 365 Field Service and in Universal Resource Scheduling, **Booking Alerts** bring attention to important notifications so that dispatchers can schedule with confidence. Booking alerts display notes and reminders on the schedule board, and can relate to bookings, work orders, users, and other entities. They can be triggered based on timers, set alarms, or workflows.

> [!div class="mx-imgBorder"]
> ![Screenshot of full schedule board showing booking alert](../../field-service/media/scheduling-booking-alert-schedule-board.png)

There are three significant additional benefits: 

1. A booking alert has a start time after which it will be shown.
2. A booking alert can be assigned to one or many users.
3. By using the **Snooze** button, the alert will disappear and re-appear after the desired time. This helps dispatchers handle multiple issues in parallel.

Though the goal of a modern business application is to introduce automation for routine tasks, booking alerts can help remind dispatchers to perform the remaining manual processes - or notify them of automated process that have taken place.

In this article, we'll take a look at how to create and view booking alerts.

## Prerequisites

- Field Service v6.1+
- **Field Service - Dispatcher** security privileges


## Create a booking alert

Let's say a dispatcher wants to set herself a reminder. On the schedule board, select the **Actions** button and select **New Booking Alert**. See the following screenshot for reference.


> [!div class="mx-imgBorder"]
> ![Screenshot of manual creation of a booking alert](../../field-service/media/manual-creation-of-a-booking-alert.png)

The **New Booking Alert** window pops up.

> [!div class="mx-imgBorder"]
> ![Screenshot of booking alert](../../field-service/media/booking-alert.png)
 
- **Subject** and **Description** define the message that appears on the alert. 

- **Priority** can be used for additional logic, but won't trigger any specific behavior. 

- **Regarding** allows the user to link the alert to a specific record. For any entity, the booking alert will immediately show up on the record's timeline. However, only upon reaching the **Due Date**, the alert will also show up on the schedule board's detail pane **Alerts** tab. 

- **Assignees** is the field where you can assign one or more people. Each assignee can choose to snooze or dismiss the alert.

> [!Note]
> When setting the **Regarding** field, pay attention to the entity type that you select. By default, the work order, the associated resource requirement, and the booking have the same name. On top of the **Regarding** field, you can use a filter to limit results to the desired entity.

## View the booking alert

Once the due date is reached and the alert appears on the schedule board side pane, here is what the alert will look like and how a dispatcher can put an alert on hold by selecting **Snooze**. The dispatcher can also select how long the snooze should last. 


> [!div class="mx-imgBorder"]
> ![Screenshot of Alert - Snooze](../../field-service/media/alert-snooze.png)
 
### Booking alerts for bookings

Alerts for **Bookable Resource Bookings** will not only appear in the booking’s timeline and the details panel, but also in the schedule board alongside a booking time slot, specifically in the upper left-hand corner of the booking. See the following screenshot for reference.

 
> [!div class="mx-imgBorder"]
> ![Screenshot of Booking alert on the schedule board](../../field-service/media/booking-alert-on-the-schedule-board.png)

The icon indicates the number of active alerts for that booking; clicking it expands or collapses the details. **Snooze** and **Dismiss** work the same way as in the panel.
 

## Additional notes

- By creating the booking alert, the system automatically creates one **Booking Alert Status** record for every assignee. This allows the affected users to individually snooze (there is a field called **Next Time To Show**) or dismiss alerts. When a user dismisses the alert, the **Booking Alert Status** records are deactivated. When every assignee dismisses the alert, its **Activity Status** field is set to **Completed**.

- In most situations, the user will not create the alert manually. Instead, Power Automate or a workflow can be used to automate the record creation upon certain events.

- When deleting records, keep the relationship **Booking – Booking Alert – Booking Alert Status** in mind. By default, you can't remove a booking that has booking alerts associated to it.

- You can edit the fields inside a booking alert by editing the **Booking Alert Template** in the schedule board tab settings. For more information, visit the topic on [schedule board tab settings](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/schedule-board-tab-settings#other-settings).


