---
title: "Predictive travel times for resource scheduling optimization| MicrosoftDocs"
description: Learn how to use predictive travel times for resource scheduling optimiation in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/01/2020
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
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Predictive travel times for resource scheduling optimization

In order to predict accurate travel times for technicians, it's important to remember that travel times can vary because of traffic conditions.

Resource scheduling optimization can use historic traffic information in order to predict more accurate travel times for technicians. Better travel time predictions mean more accurate and realistic scheduling for dispatchers and technicians alike.

## Prerequisites

- **Connect to Maps** must be set to **Yes**. Go to **Resource Scheduling App** > **Settings** > **Administration** > **Scheduling Parameters** to make sure.
- Predictive travel times that use historical data is only available for scheduling with resource scheduling optimization (RSO); the feature is not currently supported for the schedule assistant or manual scheduling.
- Resource scheduling optimization v3.2.0.4+.

## Set travel time calculation on optimization goal

To turn on predictive travel time calculations, go to a resource scheduling optimization goal.

For the field **Travel Time Calculation**, select **Bing Maps with historical traffic**.

Save and publish.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-predictive-travel-flag.png)

## Set range duration to one day or less on optimization scope

On a scheduling optimization scope, go to the section **Optimization Range Settings**. 

Set **Range Duration** to **1 day** or less.
Set **Range Reference** and **Range Offset** based on your business needs. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a scheduling optimization scope.](./media/rso-predictive-travel-range.png)

## Run resource scheduling optimization

After adding predictive travel to the optimization goal and adjusting the optimization scope to be less than or equal to 1 day, the next step is to run the optimization  manually, through a schedule, or via a workflow.

Without predictive travel times, resource scheduling optimization will calculate the travel time between two locations as the same, no matter the time of day the work is scheduled.

> [!div class="mx-imgBorder"]
> ![Screenshot of a schedule with no predictive travel.](./media/rso-predictive-travel-schedule-without.png)

With predictive travel enabled, the estimated travel times are recalculated based on the time of day, season, and other historical factors. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a schedule with predictive travel times.](./media/rso-predictive-travel-schedule-with.png)

> [!Note]
> Running an optimization with predictive travel time may change the order of the bookings to optimize objectives and constraints. Additionally, it may increase the runtime for the engine to optimize the requirements and bookings.

## Configuration considerations

- Predictive travel times that use historical data is a feature only available for scheduling with resource scheduling optimization. Predictive travel is not currently supported for the schedule assistant or manual scheduling.

- Since optimizations can take longer when considering historical traffic information, use predictive travel times for [automated overnight scheduling](rso-overnight-scheduling.md) where the optimization runs during non-working hours for the following working day.

- Predictive travel time can only be applied to optimization scopes with fewer than 500 requirements _and_ 500 resources during early access. If your optimization scope exceeds this threshold, the optimization will still run but without predictive travel times. If you have more resources or requirements, consider splitting the scope into smaller scopes and apply predictive travel time to each related optimization goal.

- We don't recommend using predictive travel with [single resource optimization](rso-single-resource-optimization.md), but it is possible. To use predictive travel with single resource optimization, add the travel time calculation to the default goal for single resource optimization.

- Predictive travel time is only available for Bing Maps.

## Additional Notes

- Running resource scheduling optimization with predictive travel times can result in different travel times and different sequences of schedules.

- Predictive travel time is not real-time traffic, so they will not reflect one-time events like traffic accidents or road closures. Instead, this feature will take into account general traffic patterns like high volumes of cars in the morning when many people are commuting to work.
