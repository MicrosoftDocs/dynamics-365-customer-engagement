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

  
This Public preview contains three reports focused on different scenarios and user personas - “Resource and Utilization”, “RSO Admin” and “Optimization summary”. 

Resource Manager can use Resource and Utilization report to perform the following tasks:  

- Monitor metrics across resource and utilization, time spent on bookings and miles on truck rolls.   
- Unpack insights on the territory as a whole; what is the allocation of bookings, is territory imbalance between demand and supply, what is the estimated travel time versus the actual travel time?  
- Understand how individual resource is using their time to react and resolve and whether individual resource is under or over utilized comparing to others.  

Resource Manager can use RSO Admin and Optimization summary reports to perform the following tasks:     

- A post-analysis to provide recap of each optimization request such as number of requirements, number of bookings, allocated hours and least allocated resource.  

Note: Contact your system administrator, for configuration errors or if you are unable to view the dashboards.   


## Prerequisites
Public preview
> [!Note]
>
Install or upgrade field service to get Resource and Utilization Report


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-install-data-insights.png)

Verify the following prerequisites before you use the Resource Scheduling Reports: 

- For Resource and utilization, Field Service is provisioned, and the report is assigned to a role that wants to get the access by Administrator.   
- For RSO Admin and Optimization summary reports, RSO is provisioned and the report is assigned a role that wants to get the access by Administrator.   



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
| Bookings by Territory  |	Display a filled map for each territory and hover on a specific territory that will display no of bookings, total work time, travel time and break time. 
For territory, it is based on territory entity. So, to render this report properly, the territory needs to be a physical geo location rather a logical geo location.  |
| Variance to estimated travel time |	Calculate the variance between estimated travel time and actual travel time. Lump sum the variance by each territory and display the comparable result in a whole. |
| Requirement duration % vs. allocated resource duration % |	Gauge whether the total requirement in each territory is balanced with total resource allocated to that territory. 
The analysis is to display percentage value of requirement duration and compare with percentage value of allocated resource duration  |
| Miles travels by trend |	The visual displays the trend of total miles traveled per month |



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-rso-admin.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-analytics-rso-summary.png)

## Configuration considerations
## Additional Notes