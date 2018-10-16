---
title: "Single resource optimization | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/15/2018
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

# Single resource optimization

Single resource optimization provides a quick and simple way to re-optimize the schedules of a selected resource from the schedule board. This is done to ensure the resource continues to have an optimal schedule and route after schedule changes and cancellations occur during the day. For example, a resource may have overlapping bookings after getting assigned an emergency Work Order or arriving late due to traffic during the day.

>![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-1.png)


## Prerequisites:

• Resource Scheduling Optimization v2.8+

• Bookable Resource record must have **Optimize Schedules** set to **Yes**

• There must be a default goal in Resource Scheduling Optimization > Optimization Goals. Note that a default goal is created when optimization is deployed

There are two ways to use the single resource optimization feature from the schedule board:

(1) **One click with defaults:** Optimize the schedules for a single resource with one click using the default goal with a time range set to the end of the current day. Performed from any schedule board view.

**Note:** One click with defaults requires Field Service v8.0+

(2) **Advanced with edits:** Optimize the schedules for a single resource with the option to edit the goal and time range as well as the option to run as a simulation and apply or discard the results. This is only possible from the schedule board view related to your optimization scope.

(1) **Once click with defaults:**

a) From the schedule board, right click the Resource's name, then click Optimize Schedule to start optimization for a selected resource
>![Screenshot of triggering single resource optimization from schedule board](media/rso-single-resource-2.png)


b) Yellow line indicates default optimization range, from NOW to end of today (12am)

c) Gray mask indicates default optimization range, from NOW to end of today (12am)

d) Optimization Panel showing selected resource name, default range, default goal, and optimization request status
>![Screenshot of single resource optimization with range and goal](media/rso-single-resource-3.png)


(2) **Advanced with edits:**

a) Customize optimization range to any date/time as needed

b) Select different optimization goal as needed

c) **Run Now** will run the optimization and schedule bookings
>![Screenshot of single resource optimization pane with options](media/rso-single-resource-4.png)


d) **Run Simulation** will run the optimization and schedule simulated bookings shown as white. User can apply/discard simulation results. **Note:** Simulated bookings will not show on map with routes.

e) Optimization Panel showing optimization request status
>![Screenshot of running single resource optimization with simulation mode](media/rso-single-resource-5.png)

## Additional Notes

- A default goal is required for single resource optimization to work. A default goal is auto created when deploying optimization as seen in the image below.

- Single resource optimization will only re-optimize existing bookings and will not create new bookings.

- Single resource optimization can be applied to, and will re-optimize, bookings that were originally booked manually or via resource availability search as well as bookings from location agnostic requirements.

- This feature will show on the schedule board for all resources given optimization is deployed in the environment; however, it will only work if the selected Bookable Resource has Optimize Schedules set to Yes. This feature cannot be disabled or hidden.

>![Screenshot of default goal deployed with Resource Scheduling Optimization](media/rso-default-goal-2.png)
The above picture is the default goal Resource Scheduling Optimization creates when deployed and can be edited.
