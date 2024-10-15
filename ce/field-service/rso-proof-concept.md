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

This article guides you through the implementation of a proof of concept (POC) for the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.

## Define requirements and expectations

During the discovery phase for the POC, you focus on understanding requirements and defining success criteria.

### Understand requirements and business needs

No two organizations run in exactly the same way. Therefore, to ensure a successful POC, it's critical that you understand how the organization uses its data and for what business reasons.

Resource Scheduling Optimization is most applicable to onsite service scenarios where resources perform work at multiple customer locations. (This article is focused on this type of scenario.) A key benefit of the add-in is that it minimizes travel time and maximizes resource utilization. However, Resource Scheduling Optimization can optimize any scheduling-enabled entity, because it builds on Universal Resource Scheduling, a framework that schedules the requirements for resources. Even if you schedule cases or work orders, the eventual result is a requirement record. Learn more in [Universal Resource Scheduling for Field Service](universal-resource-scheduling-for-field-service.md).

Here are a few questions that can help you gather requirements:

- How many resources are there, and of what types (people, equipment, facilities, and so on)?
- How often are resources scheduled?
- Where do resources start and end their days?
- How many territories do resources work within?
- What types of skills or characteristics are important for resources?
- How does the organization respond to unforeseen high-priority work?
- How are resource priorities defined and managed?

### Define success criteria

Determine what success looks like. Although it can be tempting to declare that improved travel times or decreased overtime are successes, they aren't specific or measurable enough. Define *measurable* success criteria, such as *reduce travel time by 10%* or *schedule no overtime for maintenance work*, and make sure that the system provides a way to gather the related metrics.

You often get a data set from previous periods so that you can retrospectively compare the outcome of the POC with factual data. This approach is difficult because Resource Scheduling Optimization can't schedule before the current time. If you change the dates on historical data, keep in mind that a weekday in September might be a weekend in December. Therefore, adjust the data accordingly.

Organizations often use service level agreements (SLAs) or response times as success metrics. You might encounter examples such as *next day before 12:00 PM* for SLAs. Ensure that you map SLAs to the **Time From Promised** and **Time To Promised** fields on the work order, because these fields populate the start and end dates on a requirement.

## Configure sample data

To configure the sample data and get the POC up and running, create the following records for your scenario.

### Accounts

Account information is helpful when you handle work orders, because **Service Account** is a required field. The account information can typically be derived from the work order data if an address or longitude and latitude values are provided.

### Addresses

[Enable location and map settings](field-service-maps-address-locations.md) to turn addresses into latitude and longitude values.

### Territories

To work, Resource Scheduling Optimization needs at least [one territory](set-up-territories.md). Multiple territories allow for more flexibility. You can define more optimization schedules and run them simultaneously.

### Bookable resources

[Set up bookable resources](set-up-bookable-resources.md) for the purposes of this POC. When you work with real data, it's easier to drill into specific use cases. In addition, this approach limits the related data that is required for resources, such as work hours, resource territories, or characteristics.

> [!TIP]
> A location agnostic resource can only have bookings for which the *Resource Requirement* is also set to location agnostic. Resource Scheduling Optimization treats that resource like a remote worker who only gets scheduled for work that doesn't involve travel. Alternatively, you can [Enable a resource to travel outside working hours](rso-travel-outside-working-hours.md#enable-a-resource-for-scheduling-outside-of-working-hours) to work around this constraint.

Relate resources to contacts to ensure that they are separate from the service accounts. Be sure to set the correct time zone on the resource, because the time zone that is set affects the work hours. In the bookable resource record, on the **Resource Scheduling Optimization** tab, set the **Optimize Schedule** option to *Yes* to enable the resource for Resource Scheduling Optimization.

### Characteristics

[Resource skills and characteristics](set-up-characteristics.md) can be used as filter criteria. They can also be used in the setup of goals and objectives.

### Work hours

[Set up work hours](set-work-hours-resource.md) to have Resource Scheduling Optimization consider a resource for scheduling.

### Priorities

[Priorities provide filter dimensions](set-priorities.md) to a Resource Scheduling Optimization run. Using high-priority requirements as a constraint provides control over those more urgent requirements.

### Work orders or other transactional data

This data represents what you're trying to schedule, typically in the form of work orders. However, you can also [enable other tables for scheduling](schedule-new-entity.md). Set the **Scheduling Method** field on the related requirement to *Optimize*.

### Time off

You can [create time-off entries](submit-approve-time-off-requests.md) to make a resource unavailable for a specific period. Resource Scheduling Optimization treats time off like time outside of work hours. It schedules resources according to the *Schedule within Work Hours* and *Scheduling Windows* constraints.

If your requirements for time off are more complex, you can create a custom time-off entity as a schedulable entity and set the related requirement to optimize. In this way, you can create more robust time-off entries.

## Run simulations

The Resource Scheduling Optimization engine schedules requirements from the current point in time and as far into the future as you specify through the **Range Offset** and the **Range Durations** values that are [defined in the optimization scope](rso-optimization-scope.md).

### Accommodate disruptions

To simulate a typical service organization's activity, incorporate unexpected service calls into your POC. Consider creating a separate scope to accommodate quick changes to a schedule.

### Define views and schedules

Create views that Resource Scheduling Optimization uses to filter the [data in the optimization scope](rso-optimization-scope.md). For example, a rural area might optimize once a week, whereas a more congested area might optimize on an hourly basis.

### Define goals with specific constraints and objectives

You can define how bookings should be optimized. The goal of the Resource Scheduling Optimization engine is to process a list of resources and a list of resource requirements, together with existing bookings, to create the optimal route and list of bookings for the resources. Learn more about how to set constraints and objectives in [Optimization goals in Resource Scheduling Optimization](rso-optimization-goal.md).

### Simulations

Resource Scheduling Optimization enables you to [run simulations and create soft bookings](rso-simulation.md). If a simulation meets specific requirements and is deemed the best option, the soft bookings can then be turned into hard bookings.

## Review routes and booking details

A review of specific routes helps you drill into the differences that are achieved through different goals and objectives. Select a couple of resources, optimize them with different goals and constraints, and review the outcome.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
