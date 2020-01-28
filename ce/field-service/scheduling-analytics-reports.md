---
title: "Resource scheduling and optimization analytics dashboard | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/22/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Resource scheduling and optimization analytics dashboard

Resource manager or operation manager are responsible for managing the resources who work onsite to provide support on customer needs no matter it is a break-fix or a regular maintenance ask.  They need to be able to monitor key operational metrics to gauge resource and scheduling performance. The reports can uncover business questions as whether resources are being effectively utilized over a period time and, as a whole, what is the variance between estimated and actual time and whether requirements and allocated resource are balanced.  So, they can fine turn the resource scheduling strategy and provide appropriate guidance to resources, and ultimately that will lead to savings in time, money and continues improvement on customer experience. 

Field Service and Resource Scheduling Optimization (RSO) cotnain three reports focused on different scenarios and user personas - “Resource and Utilization”, “RSO Admin” and “Optimization summary”. 

1. Resource and utilization (included with Field Service)
2. RSO Admin (included with RSO)
3. Optimization summary (included with RSO)
  


## Prerequisites
This feature is in public preview.

To get the Resource and utilization report: 

1. Install or upgrade Field Service
2. Install the Data Insights and Analytics for Resource Scheduling solution in your instance.
3. The Resource and utilization report will appear in the Field Service app for users with **System Administrator** or **Field Service-Administrator** security roles. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-install-data-insights.png)

To get the Resource Scheduling Optimization reports:

1. Install or upgrade Field Service
2. Install or upgrade Resource Scheduling Optimization 
3. Install the Data Insights and Analytics for Resource Scheduling solution in your instance.
4. The RSO Admin Optimization summary reports will appear in the Resource Scheduling Optimization app for users with **System Administrator** or **Field Service-Administrator** security roles. 


## Resource Scheduling analytics

Resource Manager can use Resource and Utilization report to perform the following tasks:  

- Monitor metrics across resource and utilization, time spent on bookings and miles on truck rolls.   
- Unpack insights on the territory as a whole; what is the allocation of bookings, is territory imbalance between demand and supply, what is the estimated travel time versus the actual travel time?  
- Understand how individual resource is using their time to react and resolve and whether individual resource is under or over utilized comparing to others.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics1.png)

| Visuals |	Description |
| --- | --- |
| Avg work time per day (hrs.)  |	Average length of time per day that a technician(s) takes to work at the customer site. Total length of work time/ count of days in the given period from slicer |
| Avg travel time per day (hrs.) |	Average length of time per day that a technician(s) takes on travel. Total length of travel time/ count of days in the given period from slicer Total miles traveled 	Total miles on truck rolls in the given period from slicer.  |
| Avg miles traveled per day |	Average miles on truck rolls per day. Total miles/count of days in the given period from slicer |
| Utilization rate | The percentage of time a resource spends on work and travel in the given period from slicer. (work duration +travel duration)/available time on the calendar rule  |
| Late arrival rate |	For all in progress or completed bookings, the percentage of bookings where technician arrives later than the “Time to Promise” or “Estimated arrival time” if “Time to Promise” is not enabled in the implementation.  |
|Booking Cancellation rate |	For all in progress or completed bookings, the percentage of bookings that have been cancelled in the given period from slicer. |
| Resource utilization breakdown  |	The visual displays the percentage of time on work, travel, break and idle time over a period.  It can break via booking status slicer such as in progress job or completed job. |
| Duration break down |	The visual displays the trend of total work time, travel time, break time and idle time. It can drill by booking status slicer such as in progress job or completed job. |



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics2.png)

| Visuals |	Description | 
| --- | --- |
| Bookings by Territory  |	Display a filled map for each territory and hover on a specific territory that will display no of bookings, total work time, travel time and break time. For territory, it is based on territory entity. So, to render this report properly, the territory needs to be a physical geo location rather a logical geo location.  |
| Variance to estimated travel time |	Calculate the variance between estimated travel time and actual travel time. Lump sum the variance by each territory and display the comparable result in a whole. |
| Requirement duration % vs. allocated resource duration % |	Gauge whether the total requirement in each territory is balanced with total resource allocated to that territory. The analysis is to display percentage value of requirement duration and compare with percentage value of allocated resource duration  |
| Miles travels by trend |	The visual displays the trend of total miles traveled per month |

| Visuals |	Description | 
| --- | --- |
| Resource work time quartile analysis  |	Display the work time and travel time per resource given the period from slicer. Segment individual resource compared with the work time quartile.  Work time quartile: <1st quartile (25%), Between 1st -2nd quartile (25%-50%), Between 2nd to 3rd quartile (50%-75%), >3rd quartile (>75%)  |
| Resource metrics |	Show the breakdown of KPIs for each resource that include no of bookings, % utilization, Year on Year % change of utilization, work time, travel time, break time and idle time. Rank the resource by no of bookings. Drill by the column to view the data by year, month, week and day. | 

## Resource Scheduling Optimization analytics



### RSO Admin

The RSO admin report analyzes when and how RSO runs, but not the actual booking results.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-rso-admin.png)


| Visuals |	Description | 
| --- | --- |
| Avg bookings |	The average number of bookings in given schedule requests.  |
|Avg Requirements |	The average number of requirements in given schedule requests. |
|Avg Resources |	The average number of schedulable resources in given schedule requests. |
|Optimization E2E time |	This metric will define the optimization execution time |
| Number of failed optimization request |	The number of failed optimization request in the given schedule requests. |

### Optimization summary

The optimization summary analyzes the automatically scheduled bookings and the effect this has on the business such as an analysis of minimized travel time.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-rso-summary.png)

| Visuals |	Description | 
| --- | --- |
| Booking scheduled |	The total number of bookings scheduled in given schedule requests. | 
| Resource allocated |	The total number of resources allocated in given schedule requests. | 
| Work time allocated (hrs.) |	The total work time allocated in given schedule requests. |
| Travel time allocated (hrs.) |	The total travel time allocated in given schedule requests. |
|Total time allocation (hrs.) |	The break down percentage and value between work time and travel time |
| Resource time allocation |	Uncover RSO reports of the booking scheduled, locked bookings, work time and travel time per individual resource in given schedule requests.  Hight light the overloaded resource with color coding. |
| Least allocated resource |	Rank the resource based on the utilization so the planner can squeeze new emergency to least allocated resource |


| Visuals |	Description | 
| --- | --- | 
|Territory summary |	Show the filled map for each territory and you can filter the data by selecting one of Territory |
| Booking metrics by territory | 	 The scheduled bookings, worktime allocated, and total travel time allocated for each territory. |


## Configuration considerations

- Other than editing filters and the ability to drill down, the reports are not configurable or customizable. 


## Additional Notes

- The reports are built on PowerBI

### How to share the reports:
By default, the Tenant administrator will be able to view all the reports, but by following the below steps, he/she can share the reports to the users.

Go to advanced find and search the Data Analytics Reports entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-share.png)

Each report will show as a record, select the report you would like to share and click **Share** at the top.

Then add the users or teams you want to give access to. Make sure the Read access is selected and click the Share button.

Users or teams the report is shared with will be able to view the report when they log in.

