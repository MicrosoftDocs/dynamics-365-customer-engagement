---
title: Set up a proof of concept for Resource Scheduling Optimization
description: Learn how to set up a proof of concept for the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 07/18/2024
ms.subservice: resource-scheduling-optimization
ms.topic: conceptual
author: AnilMur
ms.author: anilmur
---

# Set up a proof of concept for Resource Scheduling Optimization

This article lists guides you through a proof-of-concept (POC) implementation for the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.

## Define requirements and expectations

In the discovery phase of the POC, you focus on understanding requirements define success criteria.

### Understand requirements and business needs

No two organizations run the exact same way, so understanding how to use data is critical for successful POC. Make sure to understand *how* the organization uses their data and for what business reasons.

Resource Scheduling Optimization is most applicable to onsite service scenarios where resources perform work at multiple customer locations. A key benefit of the add-in is minimizing travel time and maximize resource utilization. This guide focuses on that scenario. However, Resource Scheduling Optimization can optimize any scheduling-enabled entity because it builds on Universal Resource Scheduling, a framework that schedules the requirements for resources. Even if you schedule cases or work orders, they result in a requirement record eventually. For more information, see [Universal Resource Scheduling for Field Service](universal-resource-scheduling-for-field-service.md).

Here are a few questions to help with gathering requirements:

- How many resources and what types of resources (people, equipment, facilities, etc.) are there?
- How frequently are resources scheduled?
- Where do resources start and end their days?
- How many territories do resources work within?
- What types of skills or characteristics are important for resources?
- How does the organization respond to unforeseen high-priority work?
- How are resource priorities defined and managed?

### Define success criteria

Determine how measurable success looks like. While it's tempting to declare that improved travel times or decreased overtime are successes, they aren't specific or measurable enough. Define *measurable* success criteria, such as *reduce travel time by 10%* or *schedule no overtime for maintenance work* and make sure the system actually provides way to gather the related metrics.

You often get a data set from prior periods to compare outcome of the POC with the factual data retrospectively. This is difficult because Resource Scheduling Optimization can't schedule before the current time. If you change the dates on historical data, keep in mind that a weekday in September might be a weekend in December and tweak the data accordingly.

Organizations often use service level agreements (SLAs) or response times as success metrics. You'll often see examples such as "next day before 12:00 PM" for SLAs. Ensure you map SLAs to **Time From Promised** and **Time To Promised** fields on the work order, which populate the start and end date on a requirement.

## Configure sample data

To configure the sample data and get the POC up and running, create records for your scenario as listed in the following sections.

### Accounts

Account information is helpful when dealing with work orders, since **Service Account** is a required field. The account information can typically be derived from the work order data if an address or longitude and latitude are provided.

### Addresses

[Enable location and map settings](field-service-maps-address-locations.md) to turn addresses into latitude and longitude values.

### Territories

Resource Scheduling Optimization needs at least [one territory to operate](set-up-territories.md). Multiple territories allow more flexibility and let you define more optimization schedules, which can run simultaneously.

### Bookable resources

[Set up bookable resources](set-up-bookable-resources.md) for the purposes of this POC. Working with real data makes it easier to drill into specific use cases and also limits the related data required for resources, such as work hours, resource territories, or characteristics. Relate resources to contacts to ensure they're separate from the service accounts. Be sure to set the proper time zone on the resource because it impacts the work hours. On the bookable resource record, go to the **Resource Scheduling Optimization** tab and set the **Optimize Schedule** to **Yes** to enable it or Resource Scheduling Optimization.

### Characteristics

[Resource skills and characteristics](set-up-characteristics.md) can be used as filter criteria, as well as in the goals and objectives setups.

### Work hours

[Set up work hours](set-work-hours-resource.md) to have Resource Scheduling Optimization consider a resource for scheduling.

### Priorities

[Priorities provide filter dimensions](set-priorities.md) to a Resource Scheduling Optimization run. Using high priority requirements as a constraint gives control over those more urgent requirements.

### Work orders or other transactional data

This data represents what you're trying to schedule, typically in the form of work orders. However, you can also [enable other tables for scheduling](schedule-new-entity.md). Set the **Scheduling Method** field on the related requirement to **Optimize**.

### Time off

You can [create time-off entries](submit-approve-time-off-requests.md) to make a resource unavailable for a specific period of time. Resource Scheduling Optimization treats time off like time outside of work hours and schedules resources according to the *Schedule within Work Hours* and *Scheduling Windows* constraints.

If your requirements for time off are more complex, you can create a custom time-off entity as a schedulable entity and set the related requirement to optimize. This would allow you to create more robust time off entries.

## Running simulations

The Resource Scheduling Optimization engine schedules requirements from the current point in time as far in the future as you specify using the **Range Offset** and the **Range Durations** values [defined in the optimization scope](rso-optimization-scope.md).

### Accommodate disruptions

To simulate a typical service organization's activity, incorporate unexpected service calls in your POC. Consider creating a separate scope to accommodate quick changes to a schedule.

### Define views and schedules

Create views that are used by Resource Scheduling Optimization to filter the [data in the optimization scope](rso-optimization-scope.md). For example, a rural area might optimize once a week, whereas a more congested area might optimize on an hourly basis.

### Defining goals with specific constraints and objectives

You can also define how bookings should be optimized. The goal of the Resource Scheduling Optimization engine is to process a list of resources and a list of resource requirements, along with existing bookings, to create the optimal route and list of bookings for the resources. For more information about settings constraints and objectives, see [Optimization goals in Resource Scheduling Optimization](rso-optimization-goal.md).

### Simulations

Resource Scheduling Optimization lets you [run simulations and create soft bookings](rso-simulation.md). They can then be turned into hard bookings should a simulation meet specific requirements and it's deemed the best option.

## Review routes and booking details

Reviewing specific routes with helps drill into the differences achieved with different goals and objectives. Select a couple of resources and optimize them with different goals and constraints to review the outcome.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
