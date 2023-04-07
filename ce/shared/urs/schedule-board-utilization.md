Dispatchers and service managers need use the resource utilization metric to make informed scheduling decisions. Such decisions entail assigning work orders to field technicians or reserving equipment for jobs.

Utilization is the amount of time a dispatcher schedules a resource to work. The metric is the percentage of booked time versus working hours. On the schedule board, resource utilization shows next to a resource's name.

## Calculate resource utilization

> [!NOTE]
> Resource capacity and requirement effort are not considered in utilization calculations.

Utilization percentage derives from **Total Booked Hours** divided by **Total Working Hours** in the selected date range.

Formula: ((Total booked hours  in date range)/(Total working hours x days in date range)) x 100

- **Total Booked Hours** is the sum of the hours booked to the resource for bookings in a *Committed* status.

- **Total Working Hours** is the sum of the resource's working hours. A setting on the *Bookable Resource* record defines the working hours. For more information, see [Set up bookable resources](../../field-service/set-up-bookable-resources.md).

### Example

A resource works an eight-hour shift, Monday to Friday. The date range on the schedule board shows a seven-day week, Monday to Sunday.

Total working hours are 40 hours (5 x 8 hours).

If the dispatcher books the resource for 10 hours throughout the work week, their total working hours are 10.

So the resource has a utilization of 25% ((10 / (5 x 8)) x 100)).

### Booking status influence on utilization

Your [business processes can use several booking statuses](../../field-service/set-up-booking-statuses.md), such as traveling, in progress, on break, and completed. Each of them maps to a booking status of either *Committed*, *Proposed*, or *Canceled*. Bookings map to the *Committed* status when confirmed and a resource will complete the work. The *Proposed* status suggests unconfirmed work. The *Canceled* status notifies stakeholders that the booking is no longer scheduled.

The utilization metric ignores bookings with a *Proposed* or *Canceled* booking status.

## Next steps

- [Resource and utilization report](../../field-service/resource-utilization-report.md)
