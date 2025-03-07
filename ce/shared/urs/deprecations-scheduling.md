Features that are deprecated in Universal Resource Scheduling are listed in this article.

> [!IMPORTANT]
> A deprecated feature or capability gets removed in an upcoming major release. It continues to work and is fully supported until officially removed. A deprecation notification will span at least six months. These notifications help you plan updates to your code or business processes before the feature or capability is removed. After removal, the feature or capability will no longer work.

## Deprecated: Legacy schedule board control

Effective from 1 April 2023, the legacy schedule board control is deprecated and replaced with an updated schedule board control (located in the Resource Scheduling Controls solution).

Users who previously accessed the schedule board through a hardcoded URL can add the *Schedule Board Setting* entity list view to their site map to launch the schedule board control by [editing a site map](/power-apps/maker/model-driven-apps/create-site-map-app#add-a-subarea-to-a-group-in-the-site-map). On Power Apps, navigate to your solution and open the site map. In the site map control, add a new subarea to a group and set that subarea's **Type** to *URL* set the **URL** to */main.aspx?pagetype=entitylist&etn=msdyn_scheduleboardsetting*. **Title** can be set to *Schedule Board* or any other descriptive name. After you save the site map, it links to the new component to access the schedule board. 

> [!NOTE]
> The harcoded URL to access the legacy schedule board, */main.aspx?pagetype=webresource&webresourceName=msdyn_/fps/ScheduleBoard/ScheduleBoard.html*, will no longer be supported effective October 1 2024. When creating the new site map access point, do not use this URL.

## Deprecated: Configuration to automatically create a booking when an appointment is created

Effective from April 01, 2021, the configuration to automatically create a booking when an appointment is created is deprecated. Customers who already use the new schedule board should start moving to the improved way of [including appointments without needing corresponding bookings](../../field-service/appointment-scheduling.md). Those customers who rely on functions of the old schedule board that aren't in the new schedule board (such as assisted scheduling / **Find Availability**) should note that parity between the old and new schedule board is planned for October 2021. End of life for the deprecated configuration that handles appointments through bookings is planned for April 2022. Plan accordingly to migrate to the new functionality that directly includes appointments.
