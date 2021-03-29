---
title: "Predictive travel times for resource scheduling optimization | MicrosoftDocs"
description: Learn how to use predictive travel times for resource scheduling optimization in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/01/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Predictive travel times for resource scheduling optimization

In order to predict accurate travel times for technicians, it's important to remember that travel times can vary because of traffic conditions.

Resource scheduling optimization can use historical traffic information in order to predict more accurate travel times for technicians. Better travel time predictions mean more accurate and realistic scheduling for dispatchers and technicians alike.

## Prerequisites

- **Connect to Maps** must be set to **Yes**. Go to **Resource Scheduling App** > **Settings** > **Administration** > **Scheduling Parameters** to make sure.
- Predictive travel times that use historical data is only available for scheduling with resource scheduling optimization; the feature is not currently supported for the schedule assistant or manual scheduling.
- Resource scheduling optimization v3.2.0.4+.

## Set travel time calculation on optimization goal

To turn on predictive travel time calculations, go to a resource scheduling optimization goal.

For the field **Travel Time Calculation**, select **Bing Maps with historical traffic (Preview)**.

Save and publish.

> [!div class="mx-imgBorder"]
> ![Screenshot of a scheduling optimization goal with predictive travel.](./media/rso-predictive-travel-flag-goal.jpg)

## Run resource scheduling optimization

After adding predictive travel to the optimization goal, set up your optimization scope according to your business needs, and run the optimization manually, through a schedule, or via a workflow.

Without predictive travel times, resource scheduling optimization will calculate the travel time between two locations as the same, no matter the time of day the work is scheduled.

> [!div class="mx-imgBorder"]
> ![Screenshot of a schedule with no predictive travel.](./media/rso-predictive-travel-schedule-without.png)

With predictive travel enabled, resource scheduling optimization will generate a schedule that uses time-of-day dependent travel time that takes into account historical traffic.

> [!div class="mx-imgBorder"]
> ![Screenshot of a schedule with predictive travel times.](./media/rso-predictive-travel-schedule-with.png)

> [!Note]
> Running an optimization with predictive travel time may change the order of the bookings to optimize objectives and constraints. Additionally, it may increase the runtime for the engine to optimize the requirements and bookings.

## Tell apart bookings with predictive travel times

> [!Note]
> This enhancement was added in April Wave 1 2021 and requires Dynamics 365 Field Service 8.8.40.x+ and Resource Scheduling Optimization 3.3.0.105+

Schedulers can tell apart bookings with predictive travel times (that are more accurate as they include historical traffic) through the presence of the blue dot indicator on the line representing travel time. Hovering on a booking with predictive travel time will also show this indicator in the booking card in the **Estimated Travel Duration** field along with a _(with historical traffic)_ suffix and informational link. The legend explains this indicator as well.

> [!div class="mx-imgBorder"]
> ![Screenshot of predictive travel time indicator on booking and booking card.](./media/PredictiveTravel-UX1-ScheduleBoard.png)

The booking form includes a **Travel Time Calculation** field in the Resource Scheduling Optimization tab which is set to _Bing Maps with historical traffic_ for bookings with predictive travel times. Resource scheduling optimization administrators can use this to quantify volume of bookings that did/did not use historical traffic and refine scopes accordingly to improve overall business metrics. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Booking form with Travel Time Calculation field.](./media/PredictiveTravel-UX2-BookingForm.png)


## Configuration considerations

- Predictive travel times that use historical data is a feature only available for scheduling with resource scheduling optimization. Predictive travel is not currently supported for the schedule assistant or manual scheduling.

- Since optimizations can take longer when considering historical traffic information, use predictive travel times for [automated overnight scheduling](rso-overnight-scheduling.md) where the optimization runs during non-working hours for the following working day.

- Predictive travel time can only be applied to optimization scopes with fewer than 500 requirements _and_ 500 resources. If your optimization scope exceeds this threshold, the optimization will still run but without predictive travel times. If you have more resources or requirements, consider splitting the scope into smaller scopes and apply predictive travel time to each related optimization goal.

- [Single resource optimization](rso-single-resource-optimization.md) does not currently support predictive travel times.

- Predictive travel time is only available for Bing Maps.

## Additional notes

- Running resource scheduling optimization with predictive travel times can result in different travel times and different sequences of schedules.

- Predictive travel time is not real-time traffic, so they will not reflect one-time events like traffic accidents or road closures. Instead, this feature will take into account general traffic patterns like high volumes of cars in the morning when many people are commuting to work.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
