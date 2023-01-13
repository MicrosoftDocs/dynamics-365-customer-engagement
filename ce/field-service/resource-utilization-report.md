---
title: Resource and utilization report
description: This article explains the resource and utilization report in Field Service and the charts and visual used in that report.
ms.date: 01/13/2023
author: jshotts
ms.author: jasonshotts
ms.reviewer: mhart
ms.topic: conceptual
ms.custom: bap-template
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
search.app: 
  - D365CE
  - D365FS
---

# Resource and utilization report

Resource managers can use the resource and utilization report to gather information that helps them ensure efficient use of resources. They can monitor key information like time spent on bookings, allocation of bookings across territories, or how individual resources are allocated.

To access the report, open the **Field Service** app, change to the **Resources** area, and go to **Analytics** > **Reports**.

## Filters and slicers

- **Date range**: A [relative date range](/power-bi/visuals/desktop-slicer-filter-date-range).
- **Resource type**: <!--add-->
- **Resource**: [Active bookable resources](set-up-bookable-resources.md).
- **Booking status**: Available [Booking statuses](set-up-booking-statuses.md).

## Report metrics

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource and utilization report.](./media/scheduling-analytics1.png)

### Avg. work time per day (hrs.)

Average number of hours per day that the selected resources worked on a bookings in the selected time range.

**Formula**

(Total work time of the selected resources + Estimated travel time of the bookings in the selected time range) / Number of days of the bookings



| Visual/Chart |	Description |
| --- | --- |
| Avg. work time per day (hrs.)  |	Average length of time per day that a technician(s) works at the customer site. Total length of work time per count of days in the given time range. |
| Avg. travel time per day (hrs.) |	Average length of time per day that a technician(s) spends on travel. Total length of travel time per count of days in the given time range. 
| Total miles traveled |	Total miles on truck rolls in the given time range.  |
| Avg. miles traveled per day |	Average miles on truck rolls per day. |
| Utilization rate |The percentage of time a resource spends on work and travel in the given period from slicer. (Work duration plus travel duration) per available time on the calendar rule. Note: if the user does not set up the available time on the calendar then the default available time is 24 hours |
| Late arrival rate |	For all in-progress or completed bookings, the percentage of bookings where technician arrives later than the “Time to Promise” or “Estimated arrival time,” if “Time to Promise” is not enabled in the implementation.  |
|Booking cancellation rate |	For all in-progress or completed bookings, the percentage of bookings that have been canceled in the given time range. |
| Resource utilization breakdown  |	The visual shows the percentage of time on work, travel, break, and idle time over a period. It can break via booking status slicer, such as in progress job or completed job. Each bar in the chart shows the relative percentage of duration types in stacked columns, where the total of stacked columns always equals 100 percent. It doesn't show overtime values of any duration types. |
| Duration breakdown |	The graph shows the trend of total work time, travel time, break time, and idle time. You can also drill in to the information to see specific information for in-progress jobs or completed jobs. |



> [!div class="mx-imgBorder"]
> ![Screenshot of additional sections on the resource and utilization report.](./media/scheduling-analytics2.png)

| Visuals |	Description | 
| --- | --- |
| Bookings by territory  |	Shows a map with color indicators for bookings in each territory. By hovering over a territory, you can see number of bookings, total work time, travel time, and break time. In order for this to render correctly, the territory must be a physical geographic location.  |
| Variance to estimated travel time |	Shows the variance by region between estimated travel times and actual travel times. |
| Requirement duration % vs. allocated resource duration % |	Gauge whether the total number of requirements in each territory is balanced with the total number of resources allocated to that territory. The resulting analysis shows the percentage of requirement duration versus percentage value of allocated resource duration.  |
| Miles traveled |	Shows the trend of total miles traveled per month. |
| Resource work time quartile analysis  |	Compares each resource's travel time to work time and ranks them into relative quartiles.  |
| Resource metrics |	Shows the breakdown of KPIs for each resource, including number of bookings, utilization percentage, year over year percentage change in utilization, work time, travel time, break time, and idle time. Sort the resources by number of bookings, or by year, month, week, or day. | 

