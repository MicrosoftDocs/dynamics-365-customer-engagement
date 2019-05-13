Field Service organizations often perform preventative maintenance, inspections, repairs, and other types of service by sending field technicians to multiple customer sites, and must actively manage locations and routes. This makes understanding and minimizing travel time critical for a field service organization's success.

Using Bing Maps API by default, Dynamics 365 for Field Service calculates the driving travel time and distance as field technicians travel:

1. from their personal address to a work order location
2. from a company address to a work order location
3. from their current work order location to the next work order location
4. from their current location to a work order location (typically for high priority emergencies)

In this topic, we will explore how travel time and distance are calculated and visualized for dispatchers during manual scheduling, semi-automated scheduling with the schedule assistant, and automated scheduling with Resource Scheduling Optimization (RSO).

## Prerequisites
1. Connect your Dynamics 365 environment to Bing Maps. For more information, see [our topic on setting this up](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling). This allows you to locate resources (field technicians) and work orders, and later calculate the travel time and distances between them.
   
2. Set auto geo code addresses to **yes**. For more information, see [our topic on setting this up](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings). This allows you to automatically geo code accounts and work orders when addresses are entered. Geo coding an account or work order record populates latitude and longitude values, which are required for travel time and distance calculations.

3. After connecting your environment to Bing Maps, make sure your resources have defined starting and ending locations. Resources must have geo coded start and end locations in order to calculate travel times and distances. See the topics on [setting up bookable resources](../field-service/set-up-bookable-resources.md) and [using resource types to locate resources](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/set-up-bookable-resources#configuration-considerations).

4. Understand that only requirements where **Work Location = Onsite** and have **latitude and longitude values** are eligible for travel time calculations. 

In the following screenshot, a work order has **Work Location** set to **Onsite**; this is passed to the related work order requirement. When that work order requirement is scheduled to a resource, the system will look at the work location field, the location of the requirement, and the location of the resource in order to calculate travel time.

> [!div class="mx-imgBorder"]
> ![Screenshot of work order settings tab showing work location of on site](../field-service/media/scheduling-work-order-location-onsite.png)


## Visualize travel time on the schedule board

After a requirement is scheduled to a resource, the booking appears on the schedule board and, if applicable, travel time displays preceding the booking.

In the following screenshot, the travel time to the customer's location is 23 minutes, and the estimated duration of the work order is 2 hours, giving the booking a total duration of 2 hours and 23 minutes.
> [!div class="mx-imgBorder"]
> ![Screenshot of travel time visualization in front of booking](../field-service/media/scheduling-booking-travel-time.png)


If you don't want travel time displayed as separate from the working duration, deselect **Show Travel Duration** in the schedule board configuration. This makes it so the travel time and working duration appear as a single solid block, as seen in the following screenshot. 

> [!div class="mx-imgBorder"]
> ![Screenshot of schedule board setting to show or hide travel duration](../field-service/media/scheduling-board-show-travel-duration.png)

As a field technician completes work, he or she can update the booking status as **Traveling**. The system will track the time the booking status is set to traveling and update the **Actual Travel Duration** accordingly, though this will not be displayed on the schedule board.


> [!div class="mx-imgBorder"]
> ![Screenshot of changing booking status to traveling](../field-service/media/scheduling-board-travel-status.png)

When the field technician arrives on site, he or she can update the booking status to **In progress**, indicating work has begun. The system tracks the time the booking status is set to **in progress** and updates the **Total Duration In Progress** booking field. Finally, when the booking is complete (in other words, the booking status is set to **Completed**), the booking **End Time** is updated, and the booking length is updated visually on the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of changing booking status to completed](../field-service/media/scheduling-board-completed-status.png)

## Add travel time with manual scheduling

By default, manually scheduling a requirement by dragging and dropping on the schedule board will not calculate travel time and distance. This can be helpful for field service organizations that are not very concerned with managing or optimizing their field technicians' travel, but simply need to manage appointment start times. Imagine a scenario where an emergency work order arises and the dispatcher simply wants to communicate a time a field technician will arrive.


For example, a work order requirement that is manually scheduled to a resource at 9:00 AM implies the field technician should arrive at the customer's location at 9:00 AM; in this scenario, it's the field technician's responsibility to manage travel arrangements. In the following screenshot, an unscheduled work order requirement was dragged from the lower requirement pane to 9:00 AM for a resource. No travel time is calculated or added to the duration of the booking, implying all 4 hours are working duration.


> [!div class="mx-imgBorder"]
> ![Screenshot of manually scheduled work order with no travel calculation](../field-service/media/scheduling-board-manual.png)

Organizations that operate in small, contained geographic areas can add a generic 30 minutes to the work order durations either manually or by inflating the incident durations to roughly estimate travel but still utilize manual scheduling.

> [!Note]
> As of Field Service v8.6, travel time and distance calculations can be added to bookings that are **manually scheduled**. 

In addition to completing the mentioned earlier in this topic, you need to go to **Resource Scheduling > Settings > Administration > Scheduling Parameters** and set **Auto Update Booking Travel** to **Enabled**.

> [!div class="mx-imgBorder"]
> ![Screenshot of auto update booking travel](../field-service/media/scheduling-manual-travel-update-enable.png)

This will add a travel time to the booking visualization on the schedule board, displayed by a line preceding the booking, and populate the **Miles Traveled** booking field (though this is not visualized on the schedule board). 

In the following screenshot, an unscheduled work order requirement was dragged from the lower requirement pane to a resource at 10:00 AM. Similarly to before, this implies the field technician should arrive on site at 10:00 AM; the only difference is the travel time to get there from a home, office, or previous job location is displayed **before** that time.

> [!div class="mx-imgBorder"]
> ![Screenshot of travel time auto updated](../field-service/media/scheduling-manual-travel-update.png)


The auto-update booking travel feature will update travel time calculations as new bookings are made beyond the initial schedule. In the following screenshot, you will see two on site work order requirements scheduled back-to-back on the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of 2 onsite requirements](../field-service/media/scheduling-schedule-board-2-onsite-bookings.png)


If a third on site requirement is scheduled in between the original two, the travel time calculations are updated accordingly based on the new route order. The order of the bookings is decided by the estimated arrival time, not the travel start time.

> [!div class="mx-imgBorder"]
> ![Screenshot of scheduling an onsite booking between 2 onsite requirements](../field-service/media/scheduling-schedule-board-2-onsite-bookings-add-3rd.png)

> [!Note]
> When updates (like in the preceding screenshot) take place, the booking start and end times are not cascaded for the rest of the day, as evident by the overlap. Only the travel times and distances are updated. To have the remaining bookings cascade, correct the overlapping times, and fit inside working hours after changes, organizations should consider using Resource Schedule Optimization (RSO).


For more details on the auto-update booking travel feature, see the **Additional notes** section of this article.


## Add travel time with schedule assistant

The schedule assistant is designed to help dispatchers make better scheduling decisions, particularly based on travel times and distances.

Consider a scenario where a dispatcher wants to schedule a work order requirement to the field technician who is closest to the work order location based on travel time.

By triggering the scheduling assistant from the schedule board, the schedule assistant will show resources within the distance radius filter, along with the travel time estimates from their location (home, office, previous job, real time location) to the work order location.


> [!div class="mx-imgBorder"]
> ![Screenshot of schedule assistant travel time options](../field-service/media/scheduling-schedule-assistant-schedule-board.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of scheduled work order via schedule assistant with travel time](../field-service/media/scheduling-schedule-assistant-schedule-board-booked.png)

This is predicated on:

1. the work order requirement has a work location of **on site** 
2. the work order requirement has a location (latitude and longitude) 
3. the resources displayed have defined locations

This is also true when the schedule assistant is not triggered from the schedule board, but by the book button from a requirement.

In the following screenshot, travel time and distance calculations appear in the columns.

> [!div class="mx-imgBorder"]
> ![Screenshot of travel time calculations in grid view of schedule assistant](../field-service/media/scheduling-schedule-assistant-travel-times.png)

> [!NOTE]
> If the work order requirement has a work location of **Location Agnostic** or if the schedule assistant work location filter is changed to **Location Agnostic**, then resources without locations will also be displayed along with resources that do have locations, except the booking will not calculate travel time.

In the following screenshot, the work location is location agnostic and no travel times are displayed in results


> [!div class="mx-imgBorder"]
> ![Screenshot of booking a location agnostic requirement with no travel time](../field-service/media/scheduling-schedule-assistant-schedule-board-location-agnostic.png)

## Add travel time with Resource Scheduling Optimization

While the schedule assistant can help dispatchers make better scheduling decisions for individual requirements, Resource Scheduling Optimization (RSO) helps dispatchers make smarter scheduling decisions across many or all requirements at once. In regards to travel, this is the difference between reducing travel times and distances and **minimizing** them. 

When the optimization runs and automatically schedules work orders or other requirements, the travel times display on the schedule board the same as with other booking methods. See the following screenshot for reference.

> [!div class="mx-imgBorder"]
> ![Screenshot of optimized schedule board with resource schedule optimization](../field-service/media/rso-optimized-schedule-board.png)

However, to better understand how RSO minimizes overall travel time, each RSO run (called a "request") displays a graph comparing total working minutes scheduled to total travel minutes for those optimized bookings. This can be compared to the same graph for requirements manually scheduled or with the schedule assistant.

> [!div class="mx-imgBorder"]
> ![Screenshot of travel time graph](../field-service/media/rso-travel-time-graph.png)

> [!Note]
> If the RSO is set to schedule within working hours, it will calculate time to leave at the end of the day for resources to travel to their ending location, generally a home or office.

> [!div class="mx-imgBorder"]
> ![Screenshot of space for travel time home](../field-service/media/rso-optimized-schedule-board-time-at-end-of-day.png)

## Consider traffic when scheduling

To help with scheduling decisions, current traffic patterns and accidents can be displayed on the schedule board map alongside technician routes. To do this, select the traffic light icon at the top of the schedule board map. See the following screenshot for reference.


> [!div class="mx-imgBorder"]
> ![Screenshot of show traffic button on schedule baord map](../field-service/media/scheduling-schedule-board-traffic.png)

> [!Note]
> Travel time calculations do not reflect traffic patterns or historical travel times based on time of day or year.

Scheduling based on real-time traffic is generally not applicable since most organizations schedule days or weeks in advance and you cannot predict real time traffic ahead of time. 

Bing Maps and other mapping providers can provide real-time and historical travel time calculations, and this information can be called with [Microsoft Flow](https://flow.microsoft.com/galleries/public/templates/71e9c3773102499fafba51edf94ebbd7/get-travel-time-and-distance-in-current-traffic-to-reach-the-destination/) to calculate if the current travel time is greater than the estimated travel time and automatically update the booking status accordingly.

If a field technician begins travel to his or her next work order and sees the travel time is much longer than estimated by the system, then he or she should indicate this with a custom booking status of "running late" so dispatchers can plan accordingly. 

## Configuration considerations

- By adding a travel charge to the service account of the work order, you can charge the customer a fee for travel time and distance as work orders are completed. See the topic on [adding account related details to work orders](../field-service/work-order-customer-account.md) for more details.
- A field technician's current location as derived from his or her mobile device running the Field Service Mobile app can be used for travel time and distance calculations with the scheduling assistant. This is called **Real Time Mode**. See the topic on [enabling and testing location auditing](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/geofencing#step-5-test-location-auditing) for more details.
- Field Service uses the Bing Maps API for travel time and distance calculations, but other APIs such as Google Maps can be utilized as well.
- By default, work order requirements have a work location of **Onsite**, but default work location can be edited for each scheduleable entity by going to **Resource Scheduling > Settings > Enable Resource Scheduling for Entities >** then double-clicking an **Enabled Entity**.  

## Additional notes

- The out-of-the-box functionality only supports travel time and distance calculations for driving, not walking or flying.

### Auto Update Booking Travel Field Service v8.6+**

The auto travel time update feature for manual scheduling needs two locations to work. For example, if a resource has a starting location and the first requirement scheduled to the resource has a location (for instance, work location is **On site**), then the travel time will be calculated and visualized. If the resource does not have a starting location (for instance, resource start location is **Location Agnostic**), the first on site requirement scheduled will not have a travel time. However, if an on site requirement is scheduled after another on site requirement, then the feature has two known locations and the travel time between the two requirements will be calculated, **even if the resource is location agnostic**.

Here are a few more notes about the Auto Update Booking Travel feature:

- The feature cannot be enabled or disabled based on specific users, schedule board tabs, or specific scheduleable entities. 

- The feature only applies to the Hours view of the schedule board and travel time and distances will not be updated if the bookable resource booking form is edited manually, edited with a workflow, or if the bookings are imported.

- If you have an on site booking, the subsequent on site booking will calculate travel time from the previous booking up until the beginning of the next day's working hours, even if there are multiple hours in between the two on site bookings.
  
- The time the requirement is dragged to the schedule board is the time the resource will arrive on site and the travel time is added **before** that time. This is not configurable. For example, if you schedule an on site work order requirement at 10:00 AM by dragging the mouse to the 10:00 AM time slot, and the feature calculates 20 minutes of travel time, then travel will begin at 9:40 AM and the resource will arrive by 10:00 AM.
