Field service organizations often send technicians to various customer sites. Optimizing routes and minimizing travel time contributes to an organization's success.

Dynamics 365 Field Service calculates the driving time and distance as field technicians travel.

Learn how the system calculates travel time and distance and how dispatchers see it.

## Prerequisites

- [Enable location and map settings in Dynamics 365 Field Service](../../field-service/field-service-maps-address-locations.md)

- [Turn on auto geocoding to calculate estimated travel time](../../field-service/turn-on-auto-geocoding.md)

- Ensure you [configured resources](../../field-service/set-up-bookable-resources.md) with start and end locations. If enabled, the system takes the current location of a technician from the [location of the mobile device](../../field-service/mobile-powerapp-location-auditing.md).

## Visualize travel time on the schedule board

After scheduling a requirement to a resource, the booking appears on the schedule board, including the travel time.

To show travel time and working time as one block instead of separately, turn off **Show travel duration** in the board view settings.

As field technicians drive to the customer location, they can update the booking status to indicate they're traveling. The system tracks the actual travel duration for invoicing based on that status.

When field technicians arrive, they update the booking status to indicate work has started. The system tracks the duration in this status and updates the booking when the technician completes the work.

## Add travel time with manual scheduling

By default, manually scheduling a requirement by dragging and dropping on the schedule board won't calculate travel time and distance.

To enable the travel time calculation for manually scheduled requirements, go to **Resource Scheduling > Settings > Administration > Scheduling Parameters** and set **Auto Update Booking Travel** to **Enabled**. The system adds auto-updated travel time before the actual booking start time if it knows a start and end location.

> [!div class="mx-imgBorder"]
> ![Screenshot of auto update booking travel.](../../field-service/media/scheduling-manual-travel-update-enable.png)

> [!TIP]
> In some scenarios, technicians create bookings on the mobile app. To auto-calculate the travel time and distance, set the *msdyn_ursinternalflags* field on the booking form to `{"AutoUpdateBookingTravel":true}`.

> [!NOTE]
> When you add and reorder subsequent bookings on the schedule board, only travel time gets updated. The start time of a booking won't change automatically. To ensure that the remaining bookings cascade, correct overlapping times, and fit inside working hours after changes, organizations should consider using the [Resource Schedule Optimization add-in](../../field-service/rso-overview.md).

## Add travel time with schedule assistant

The schedule assistant is designed to help dispatchers make better scheduling decisions based on travel times and distances.

When booking a requirement with the schedule assistant, the system considers travel times.

> [!NOTE]
> If the work order requirement is location agnostic, resources without locations also show in the results and the booking will not calculate travel time.

## Consider traffic when scheduling

To help with scheduling decisions, show the current traffic patterns on the schedule board map. alongside technician routes. Open the **View settings** on the map and select **Traffic**.

> [!NOTE]
> Travel time calculations don't take traffic patterns or historical travel times into account.

Scheduling based on real-time traffic is not applicable because most organizations schedule days or weeks in advance, and you can't predict real-time traffic ahead of time. 

Bing Maps and other mapping providers can provide real-time and historical travel-time calculations, and this information can be called with [Power Automate](https://flow.microsoft.com/galleries/public/templates/71e9c3773102499fafba51edf94ebbd7/get-travel-time-and-distance-in-current-traffic-to-reach-the-destination/) to calculate whether the current travel time is greater than the estimated travel time and automatically update the booking status accordingly.

If a field technician begins travel to their next work order and sees that the travel time is much longer than estimated by the system, they should indicate this with a custom booking status so dispatchers can plan accordingly.

## Predictive travel times with historical traffic information

The Resource Scheduling Optimization add-in takes [historical traffic information into account to better plan for travel times](../../field-service/rso-predictive-travel.md).

## Next steps

- [Add travel charges in Field Service](../../field-service/travel-charges.md)
- [Get Resource Scheduling Optimization](../../field-service/rso-get-install.md)
