Dispatchers and service managers use the resource utilization metric to identify underutilized and overbooked resources. Resource utilization is the amount of time a dispatcher schedules a resource to work. It's the percentage of booked time versus working hours.

 On the schedule board, resource utilization shows next to a resource's name. Review resource utilization to help balance workloads, improve resource efficiency, and identify available capacity for additional work.

## Calculate resource utilization

Utilization is based on booked time and working hours in a selected date range. Resource capacity and requirement effort aren't considered in utilization calculations.

**Formula**: Utilization (%) = (Total booked hours ÷ Total available working hours) × 100

- **Total Booked Hours** is the sum of the hours booked to the resource for bookings in a *Committed* status.

- **Total Working Hours** is the sum of the resource's working hours. A setting on the *Bookable Resource* record defines the working hours. For more information, see [Set up bookable resources](../../field-service/set-up-bookable-resources.md).

### Example

A resource works an eight-hour shift, Monday to Friday. The date range on the schedule board shows a seven-day week, Monday to Sunday. The dispatcher books the resource for 10 hours throughout the work week.

| Measure               | Value |
| --------------------- | ----- |
| Working hours per day | 8     |
| Working days per week | 5     |
| Total available hours (8 hours x 5 days) | 40    |
| Booked hours          | 10    |
| Utilization (10 ÷ (8 x 5) x 100) | 25%   |

### Booking status influence on utilization

Your [business processes can use several booking statuses](../../field-service/set-up-booking-statuses.md), such as traveling, in progress, on break, and completed. Each status maps to a booking status category of either *Committed*, *Proposed*, or *Canceled*.

- *Committed*: The work is scheduled and counts toward the resource's utilization.
- *Proposed*: The work is tentative or unconfirmed and doesn't count toward utilization.
- *Canceled*: The work is no longer scheduled and doesn't count toward utilization.
