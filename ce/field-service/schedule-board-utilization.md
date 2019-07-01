---
title: "Resource Utilization on the Schedule Board | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/01/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: dabur
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Resource utilization on the schedule board

It is important for dispatchers and service managers to understand resource utilization to make better scheduling decisions, whether it is assigning work orders to field technicians or reserving equipment for customer jobs.  

Utilization is defined as the proportion of time a resource is scheduled to work. More specifically, it is calculated as the percentage of booked time compared to working hours. In all schedule board views, utilization is automatically calculated and displayed in each resource's cell.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization.png)

Let's see how resource utilization is calculated and displayed in the Hours and Days views of the schedule board.

## Prerequisites

Utilization is calculated and displayed on the schedule board for all versions of Field Service

## Hours view

For each resource, utilization percentage (%) is derived from: **Total booked hours / Total working hours** 

**Total booked hours** = sum of the hours booked to the resource
**Total working hours** = sum of the resource's working hours

> [!Note]
> Working hours are defined on each Bookable Resource record. Go to **Resource Scheduling > Resources**. See the topic on [setting up bookable resources](../field-service/set-up-bookable-resources) for more details.

The above values will change based on how many hours, days, and weeks you are viewing, and these are edited by selecting a view, a date range, and how many days to display.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization-edit-time.png)

This is because as you view more days, the bookings and working hours will vary. 


In the Hourly view, the total working hours will be the sum of the hours seen on the Schedule Board as you scroll from the far left to the far right. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization-hourly-view.png)
 
In the example above, Matthew works a 12 hour shift from 9AM to 9PM, this shift is repeated for 5 days shown as the user scrolls from left to right across the schedule board.

Therefore, Matthew’s total working hours in this Hourly view are 12 X 5 = 60 hours.

If Matthew is booked a single 6 hour Work Order, then his utilization is 6 / 60 = 10%, as shown in his resource card.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization-hourly-view-booked.png)


If the duration of the Work Order is increased to 12 hours, then his utiliZation is 12 / 60 = 20%, as shown in his resource card below.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization-hourly-view-booked-more.png)

## Days view

In the Days view, the total working hours will be the sum of the hours seen on the Schedule Board.

In this case we see 10 days, so Matthew’s total working hours are 12 X 10 = 120 hours

Matthew already has a 12 hour booking for one day, so his utilization % becomes 12 / 120 = 10%
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedule-board-utilization-days-view.png)


## Configuration considerations
**Proposed bookings do not contribute to utilization**

- what about proposed bookings?
  - proposes bookings do not add to utilization

**Sort schedule assistant results by utilization**

- sort by utilization
## Additional Notes

