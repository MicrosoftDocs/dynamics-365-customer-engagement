Field service organizations often send technicians to various customer sites. Optimizing routes and minimizing travel time saves valuable resources. Dynamics 365 Field Service calculates the driving time and distance as technicians travel.

## Prerequisites

- [Enable location and map settings in Dynamics 365 Field Service](../../field-service/field-service-maps-address-locations.md).

- [Turn on auto geocoding to calculate estimated travel time](../../field-service/turn-on-auto-geocoding.md). If enabled, the system takes the current location of a technician from the [location of the mobile device](../../field-service/mobile-powerapp-location-auditing.md).

- Ensure you [configured resources](../../field-service/set-up-bookable-resources.md) with start and end locations.

> [!NOTE]
> Travel time is only calculated when all of the following criteria are met:
>
> - Requirement is on site.
> - Booking falls within the resource's working hours.
> - If it's the first booking of the day, the resource is on site and has a valid location.
> - If it's not the first booking of the day, the preceding booking is on site and has a valid location OR the resource is on site and has a valid location.
>
> Travel time and routes only supports driving and no other means of transport.

## Visualize travel time on the schedule board

When a dispatcher schedules a requirement to a resource, the booking appears on the schedule board, including the travel time.

While technicians drive to the customer location, the system updates the booking status to indicate they're traveling. It tracks the actual travel duration for invoicing based on that status. Upon arrival, they update the booking status to indicate work started. The system tracks the duration in this status and updates the booking when the technician completes the work.

## Add travel time with manual scheduling

By default, manually scheduling a requirement by dragging and dropping on the schedule board doesn't calculate travel time and distance.

To enable the travel time calculation for manually scheduled requirements, go to **Resource Scheduling > Settings > Administration > Scheduling Parameters** and set **Auto Update Booking Travel** to **Enabled**. The system adds auto-updated travel time before the actual booking start time if it knows a start and end location.

> [!div class="mx-imgBorder"]
> ![Screenshot of auto update booking travel.](../../field-service/media/scheduling-manual-travel-update-enable.png)

> [!TIP]
> In some scenarios, technicians create bookings on the mobile app. To auto-calculate the travel time and distance, set the *msdyn_ursinternalflags* field on the booking form to `{"AutoUpdateBookingTravel":true}`.

> [!NOTE]
> When you add and reorder subsequent bookings on the schedule board, only travel time gets updated. The start time of a booking won't change automatically. To ensure that the remaining bookings cascade, correct overlapping times, and fit inside working hours after changes, organizations should consider using the [Resource Schedule Optimization add-in](../../field-service/rso-overview.md).

## Add travel time with schedule assistant

The schedule assistant is designed to help dispatchers make better scheduling decisions based on travel times and distances. When you book a requirement with the schedule assistant, the system considers travel time.

> [!NOTE]
> If the work order requirement is location agnostic, resources without locations also show in the results and the booking will not calculate travel time.

## Consider traffic when scheduling

To help with scheduling decisions, show the current traffic patterns on the schedule board map. Open the **View settings** on the map and select **Traffic**.

> [!NOTE]
> Travel time calculations don't take traffic patterns or historical travel times into account.

Scheduling based on real-time traffic isn't applicable because most organizations schedule days or weeks in advance, and you can't predict real-time traffic ahead of time.

## Predictive travel times with historical traffic information

The Resource Scheduling Optimization add-in takes [historical traffic information into account to better plan for travel times](../../field-service/rso-optimization-goal.md).

## Estimated travel time and booking fulfilled duration

in the **Fulfilled Duration** field on a scheduled requirement, the estimated travel time is automatically deducted from the total time allocated to the requirement in any associated bookings. This allows users to quickly see the total duration fulfilled for active work on the requirement regardless of the associated travel time.

## Next steps

- [Add travel charges in Field Service](../../field-service/travel-charges.md)
- [Get Resource Scheduling Optimization](../../field-service/rso-get-install.md)
