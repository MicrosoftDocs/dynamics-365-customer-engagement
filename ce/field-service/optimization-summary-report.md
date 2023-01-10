---
title: Reports in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about how to use work order summary reports in Dynamics 365 Field Service.
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

# Optimization summary reports

The optimization summary analyzes the automatically scheduled bookings and the effect this has on the business, such as an analysis of minimized travel time.

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource scheduling optimization summary report.](./media/scheduling-analytics-rso-summary.png)

| Visuals |	Description | 
| --- | --- |
| Booking scheduled |	The total number of bookings scheduled in given schedule requests. | 
| Resource allocated |	The total number of resources allocated in given schedule requests. | 
| Work time allocated (hrs.) |	The total work time allocated in given schedule requests. |
| Travel time allocated (hrs.) |	The total travel time allocated in given schedule requests. |
|Total time allocation (hrs.) |	The breakdown percentage and value between work time and travel time. |
| Resource time allocation |	Within an optimization request, understand each resource's scheduled bookings, locked bookings, work time, and travel time. Overbooked resources are highlighted too. |
| Least allocated resource |	Ranks resources by lowest utilization. This can help dispatchers assign new emergency jobs accordingly. |
|Territory summary |	Displays optimized territories on a map, with the ability to drill down. |
| Booking metrics by territory | 	Shows scheduled bookings, work time allocated, and total travel time allocated for each territory. |

## Share reports

By default, the tenant administrator will be able to view all the reports. With the following steps, the reports can be shared with other users.

1.	Select **Share** in the top-right corner of the report.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of the share option in the report.](./media/scheduling-analytics-share1.png)

2.	Select the reports.
 
 > [!div class="mx-imgBorder"]
> ![Screenshot of the report selection list.](./media/scheduling-analytics-share2.png)
 
3.	Select **Share**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the share option in the menu.](./media/scheduling-analytics-share3.png)

4.	Select **Add User/Team** and select the user you want to give access to.
 
 > [!div class="mx-imgBorder"]
> ![Screenshot of the share data analytics report window with attention to the add user/team option.](./media/scheduling-analytics-share4.png)

5.	Make sure the **Read** access is selected and select **Share**.
  
  > [!div class="mx-imgBorder"]
> ![Screenshot of the share data analytics report window with the read box checked.](./media/scheduling-analytics-share5.png)

The user will now be able to access the report.

In order to share the resource and utilization reports, follow steps 1 through 5 in Field Service. Note that you need to select resource and utilization reports in Field Service.