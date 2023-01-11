---
title: Optimization summary report
description: This article contains information about the optimization summary report and the charts it contains.
author: FeifeiQiu
ms.author: feiqiu
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.subservice: resource-scheduling-optimization
ms.topic: conceptual 
ms.date: 01/11/2023
ms.custom: bap-template 
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
search.app: 
  - D365CE
  - D365FS
---

# Optimization summary report

The optimization summary is available in the Resource Scheduling Optimization add-in. It analyzes the automatically scheduled bookings in the and the effect this has on the business, such as an analysis of minimized travel time.

In the **Resource Scheduling Optimization** add-in, go to **Analytics** > **Reports** > **Optimization Summary** to see the report.

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
