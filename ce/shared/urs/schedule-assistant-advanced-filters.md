The schedule assistant includes advanced filters that provide more granularity for scheduling needs.

> [!div class="mx-imgBorder"]
> ![Screenshot of the advanced filters exposed in the schedule assistant.](../../field-service/media/scheduling-schedule-assistant-advanced-filters.png)

<!-- keep videos that show old SB?-->

For more information, see the video ![Video symbol](../../field-service/media/video-icon.png "Video symbol") [Schedule Assistant: advanced filters](https://youtu.be/s6yvVv99Bnw).

## Real time mode

Helps find the closest possible resource to arrive onsite more quickly.

The schedule assistant will use the location of the technician's mobile device when calculating the estimated travel time to arrive at the work order location. A truck icon represents the technician's location on the schedule board map.
<!--
> [!div class="mx-imgBorder"]
> ![Screenshot of the hourly view of the filter and map view, showing a truck icon on the map.](../../field-service/media/scheduling-schedule-assistant-real-time-mode.png)

 is that Field Service > Settings > Geolocation settings > Refresh interval? and should the link go to the article on how to set up location tracking? -->

The mobile device sends location information from the last sync to a defined threshold in the past. Define the time threshold in the **Geo Location Expires After X Minutes** field found in **Resource Scheduling app** > **Settings** > **Administration** > **Scheduling parameters**.

See the article on [geofencing](../../field-service/geofencing.md) to learn how to set up location auditing and sharing.

## Ignore travel time

Ignores the estimated travel time and only checks if a resource has enough time available in their schedule.

## Ignore duration

Ignores the requirement duration when determining if a resource has enough time available in their schedule.

## Ignore proposed bookings

Ignores bookings with a **Proposed** booking status and the time slot as available.

Some organizations use the proposed status for bookings until their customer confirms the schedule. Dispatchers could use those time slots to expedite committed work.

## Allow overlapping

Shows bookings that with the **Allow Overlap** field set to **Yes** on the bookable resource booking form.

<!-- can we drop this and explain customizations as part of SB settings?>

## Configuration considerations

### Default values and sorting

When the schedule assistant is triggered, you'll see that some fields have default values. For example, schedule assistant search results are listed in alphabetical order by default. These default values can be changed in the **Schedule Assistant Retrieve Constraints Query**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Schedule Assistant Retrieve Constraints Query.](../../field-service/media/scheduling-schedule-assistant-retreive-resources-query.png)

To get there, double-click on the schedule board tab. Open default settings in the top right. Under the schedule types section, select the gear icon next to **Default Retrieve Constraints Query**.

From here, you can edit the XML to define how the schedule assistant searches for each entity that is available for scheduling.

## Additional notes

Do not edit the schedule assistant **Retrieve Constraints Query** for the territory shown below. It can damage the schedule assistant logic.

```<Territories ufx:select="lookup-to-list(Requirement/msdyn_territory)" />```
