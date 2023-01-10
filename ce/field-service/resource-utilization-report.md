---
title: 
description: 
ms.date: 10/01/2020
ms.reviewer: mhart

ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

## Resource and utilization reports

Resource managers can use the resource and utilization report to perform the following tasks:  

- Monitor metrics across resource and utilization, time spent on bookings, and miles on truck rolls.   
- Unpack information on the territory as a whole, such as:
  - What's the allocation of bookings? 
  - Is there any territory imbalance between demand and supply? 
  - What's the estimated travel time versus the actual travel time?  
- Understand how an individual resource is using their time to react and resolve, and whether an individual resource is under- or over-utilized compared to others.  

Go to **Field Service** > **Resources** and find **Reports** under the **Analytics** section. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource and utilization report.](./media/scheduling-analytics1.png)

Let's take a look at what each of these metrics are reporting. 

| Visuals |	Description |
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

