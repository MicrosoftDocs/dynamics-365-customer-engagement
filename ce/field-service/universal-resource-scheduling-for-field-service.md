---
title: Universal Resource Scheduling for Dynamics 365 Field Service overview
description: Learn all about Universal Resource Scheduling for Dynamics 365 Field Service
ms.date: 03/08/2023
ms.custom: bap-template
ms.topic: overview
author: clearab
ms.author: anclear
---


# Universal Resource Scheduling for Dynamics 365 Field Service overview

This article describes how Dynamics 365 Field Service uses [Universal Resource Scheduling](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

Field service organizations often book technicians to complete work orders. Efficiently scheduling resources to requirements helps reduce travel time and costs.

## Universal Resource Scheduling and Field Service work orders

When [installing Field Service](install-field-service.md), Universal Resource Scheduling gets added automatically.

Work orders and related entities are a part of Field Service and work seamlessly with resources, requirements and bookings of Universal Resource Scheduling.

In other words, Field Service defines **what** needs to be done and **where**, while Universal Resource Scheduling defines **who** can perform the work and **when**.

### Generate requirements from a work order

For every work order, the system creates a related requirement. It outlines the specific details for resources that can perform the work order. Requirements will be scheduled to resources and reference the work order.

By default, the system created one requirement for each work order. However, a work order can have multiple requirements or a requirement group with multiple requirements. [Create incident types to configure templates for work order](configure-incident-types.md).

Requirements inherit attributes from the work order, such as name, location, duration, and more. Updating work order attributes will update requirement attributes. Manual edits to requirements can be made before scheduling, too.

> [!CAUTION]
> Manually created requirements for work order don't synchronize automatically.

### Book a resource for a requirement

After a work order and related requirement are ready for scheduling, dispatchers book the requirement to the most appropriate resource.

Booking a requirement related to a work order creates a bookable resource booking record that keeps track of which resource will perform the work, the status of the booking, travel time, and start/end times.

## Scheduling personas

Learn about the scheduling roles that are common in a typical field service organization.

### Dispatcher or scheduler

The dispatcher or scheduler matches requirements with the right resources to create bookings. Common job titles for this role include service managers, customer service reps, or traditional dispatchers. Their responsibilities can range between manually assigning all requirements, having the system automatically schedule all requirements and simply managing exceptions, or somewhere in between.

Even with a high level of automation, schedulers often manage exceptions and help ensure optimization and automation meet business objectives.

### Scheduling analyst

The scheduling analyst is an emerging role as organizations adopt advanced scheduling functions like optimization, automated scheduling, and analytics. The ideal scheduling analyst has a healthy mix of scheduling, analytics, and optimization knowledge.

This role owns optimization schedules, along with accompanying scope, goals, and parameters.

## Main scheduling capabilities

Dynamics 365 Field Service includes a broad set of scheduling capabilities.

### Manual scheduling on the schedule board

The schedule board plays an important role across all types of scheduling You can configure it ot meet your scheduling requirements. For basic service scheduling, match a requirement to a resource in a particular time slot on the schedule board.

Manual scheduling wih the schedule board works especially well for emergency work or requirements with limited complexity.

### Semi-automated scheduling with the schedule assistant

The schedule assistant uses requirement details to recommend times and resources for bookings. A dispatcher then chooses the best option for the booking and assigns the requirement.

You can launch the schedule assistant from the **Book** button on the ribbon from work orders, requirements, and also directly on the schedule board. Similar to the schedule board, it's customizable and you can also use it on other forms as needed.

### Automated scheduling with the Resource Scheduling Optimization add-in

Resource Scheduling Optimization is an add-in for Dynamics 365 Field Service, which requires a separate license. It includes capabilities to automatically schedule requirements and optimize resource utilization based on custom logic. The add-in plays well with manual or semi-automated scheduling scenarios.

## Enable Universal Resource Scheduling for Field Service

There are a few things you'll need to configure to enable Universal Resource Scheduling for Field Service.

1. [Enable Resource scheduling](schedule-new-entity.md) for the *msdyn_workorder* entity.

1. [Enable location and map settings](field-service-maps-address-locations.md).

1. [Configure booking statuses](set-up-booking-statuses.md) to let field technicians communicate the progress of their work to stakeholders.

1. [Enable auto-geocoding](turn-on-auto-geocoding.md) to account for start and end location of resources.

  > [!TIP]
  > Work orders or requirements without location are treated as location-agnostic and the system doesn't consider the location during scheduling.

## Measure scheduling effectiveness

[Look at pre-built reports and relevant KPIs](reports.md) to measure how scheduling influences your defined business objectives over time.

Take a staggered approach to implement scheduling processes in your organization.

1. Start with [manual scheduling using the schedule board](preview-schedule-board.md) to familiarize with the system logic and establish business processes.
1. Move to [semi-automated scheduling with the schedule assistant](schedule-assistant.md) to find resources that match the requirements faster.
1. Consider using the R[esource Scheduling Optimization add-in](rso-overview.md) to enable more automation for your scheduling needs. Kick it off with [single resource optimization](single-resource-optimization.md) before rolling out [automation for your entire scheduling process.](rso-schedule-optimization.md)
  
## Next steps

- [Use and configure the schedule board in Dynamics 365 Field Service](configure-schedule-board.md)
- [Overview of the schedule assistant](schedule-assistant.md)
- [Get Resource Scheduling Optimization](rso-get-install.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
