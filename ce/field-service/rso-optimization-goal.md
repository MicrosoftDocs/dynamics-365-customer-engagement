---
title: Resource scheduling optimization goals - Dynamics 365 Field Service
description: Learn about how goals are used in resource scheduling optimization.
author: m-hartmann
ms.author: mhart
ms.reviewer: mhart
manager: shellyha
ms.date: 09/28/2022
ms.topic: article

ms.subservice: resource-scheduling-optimization
search.app: 
  - D365CE
  - D365FS
---

# Optimization goals in Resource Scheduling Optimization

An optimization goal defines conditions and expectations that Resource Scheduling Optimization should consider when performing an optimization.

The Resource Scheduling Optimization engine processes a list of resources and a list of resource requirements and existing bookings. It creates the optimal route or list of bookings for the resources. Bookings are considered optimally scheduled if they meet all constraints respect the importance of the listed objectives in the defined order.

## Create a scheduling optimization goal

Using the elements of a goal, you define how bookings should be optimized.

:::image type="content" source="media/scheduling-optimization-goal.png" alt-text="Screenshot of a Scheduling Optimization Goal record.":::

1. In Resource Scheduling Optimization, in the **Settings** section, go to **Optimization Goals**.

1. Enter a **Name** for the optimization goal.

1. Choose an **Engine Effort Level**. It defined the amount of effort that the system puts in to find the best combination of resources, route, and day or time. Higher effort levels mean that the optimization engine considers more possible combinations. The more combinations the system considers, the longer it takes to complete the calculations.

1. Choose the **Travel Time Calculation** option to specify the method of calculating travel distance between resources and requirements.

1. Select all **Constraints** for the optimization goal. [Constraints](#understand-constraints) are restrictions that are imposed on the bookings that the system creates.

1. Select **Save** to create the *Scheduling Optimization Goal* record.

1. In the **Objectives** section of the record, select an objective to change its properties. Select **New Scheduling Optimization Objective** to add more. [All objectives](#understand-objectives) are explained in detail below.

1. Select **Save & Close** to apply your changes.

## Understand constraints

Resource Scheduling Optimization works with a set of constraints that you can use to define an optimization goal.

### Schedule Within Working Hours

Creates the booking if the travel time to the work location and the work itself fit in a resource's working hours. It also includes travel time from the last booking to the resource's end location, although this travel time is not represented on the schedule board.

If the constraint is removed from the goal, work will still be scheduled within working hours, but travel to and from bookings *can* happen outside of the resource's working hours. It might not leave time at the end of the day to travel to the resource's end location. All bookings will end within a resource's working hours. For more information, go to [Allow travel time outside of working hours](rso-travel-outside-working-hours.md).

### Meets Required Characteristics

Ensures that a resource has all the required [characteristics and proficiency](set-up-characteristics.md) to complete a resource requirement.

### Meets Required Roles

Ensures that a bookable resource has the required roles to complete a resource requirement.If the resource requirement lists more than one role, the system will ensure one of the roles match.

### Scheduling Lock Options (deprecated)

The Scheduling Lock constraint is deprecated and will soon be removed as a constraint option. Selecting this option won't have any effect on subsequent Resource Scheduling Optimization runs. For more information on using and troubleshooting the updated booking lock options, go to [Understand the booking lock option in Resource Scheduling Optimization](booking-lock-options.md).

### Scheduling Windows

This constraint ensures that Resource Scheduling Optimization creates a booking within the time window of the resource requirement or booking record.

- **From/To Date** or **Date Window Start/End** set to the same date: Resource Scheduling Optimization schedules the booking on that day but the time of day doesn't matter.
- **Time Window Start** and **Time Window End** define a time frame: Resource Scheduling Optimization schedules the booking in that time frame but the date doesn't matter.
- **Time From Promised** and **Time To Promised** are set to a date and a time frame: Resource Scheduling Optimization schedules a booking on the selected date in the selected time range.
- **Date Window Start/End** and **Time Window Start/End** are set to a time frame on the same day: Resource Scheduling Optimization schedules a booking on the selected date in the selected time range.
- **Empty time values (v3.0+)**: Resource Scheduling Optimization will respect scenarios where either the start or end time is not defined.

  For example, if a requirement has only a time window start value, the system schedules the requirement after that time, regardless of date.

  This logic applies to the following fields on the *Resource Requirement* and *Resource Booking* entity:

  - **Time Window Start** and **Time Window End**
  - **Time From Promised** and **Time To Promised**
  - **From Date** and **To Date**

> [!NOTE]
> If time and date fields contain conflicting information, Resource Scheduling Optimization uses **Time From/To Promised** first.

### Meets Resource Preferences

You can add preferred resources to the requirement entity. For more information, go to [Resource preferences](resource-preferences.md).
Resource Scheduling Optimization respects three different types of resource preferences:

- **Preferred**: Scheduling preference for the defined resource, if available, but not guaranteed if a different resource better fits the optimal schedule.
- **Restricted**: The system won't schedule to the resources added to requirements with this resource preference.
- **Must choose from**: The defined resource gets scheduled if available during the time range. For multiple resources, the system will schedule the first that is available. If none of them are available, the requirement won't get scheduled.

### Matches Territories

Respect the [Territory field](set-up-territories.md) values on the requirement and resource records, and schedule bookings only when the territory values on both records match. A requirement can only belong to one territory, but resources can belong to multiple territories.

### Matches Resource Type

Resource types define how the resource relates to the organization. The system considers the [Resource Type field](set-up-bookable-resources.md#create-frontline-workers-and-other-bookable-resources-manually) values on the requirement and resource records. It schedules bookings only when the resource type values on both records match.

The following resource types are considered for optimization:

- Users
- Contacts
- Accounts
- Equipment
- Facility

## Understand objectives

Overall expectations from the resulting routes. Multiple objectives can be selected, but the order matters. The higher it is on the list, the more preference the system gives to the objective.

Add and rank the objectives of the Resource Scheduling Optimization goal by using the **Move Up** and **Move Down** buttons, as seen in the following screenshot. The higher an objective is on a list, the more important it is to Resource Scheduling Optimization. In this example, the most important objective is "Maximize Total Working Hours".

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two requirements_2.](./media/scheduling-rso-3-0-order-objectives.png)

### Maximize total working hours

Iteration with the total highest aggregate work time will best meet this objective. Aggregate work is calculated by taking all bookings that were created or updated during the optimization process.

### Minimize total travel time

Iteration with the total lowest aggregate travel time will best meet this objective. The travel time here is calculated based on the "Travel Type Calculation" method chosen above. It also takes into consideration the travel time for resource to get back to their end location after their last booking, although this travel time isn't shown on the schedule board.

> [!NOTE]
> This cannot be the first objective in the list. This is because, mathematically speaking, in order to truly minimize travel time, Resource Scheduling Optimization might not schedule any requirement that requires travel time (0 minutes travel) in order to meet the first objective.

### Locked bookings (deprecated)

The Locked bookings goal is deprecated and will soon be removed as a goal option. Selecting this option won't have any effect on subsequent Resource Scheduling Optimization runs. For more information on using and troubleshooting the updated booking lock options, go to [Understand the booking lock option in Resource Scheduling Optimization](booking-lock-options.md).

### High priority requirements 

Resource Scheduling Optimization will evaluate this objective and give priority to creating bookings for requirements with the highest score for priority. The priority is set on the resource requirement record and is an option set with weighted values. Resource Scheduling Optimization checks **Level of Importance** on priority to determine how important that priority is—for example, set **Level of Importance** = 10 for urgent priority and set **Level of Importance** = 1 for low priority. Mathematically speaking, when Resource Scheduling Optimization looks at the importance of one urgent requirement (Level of Importance: 10 x Number of requirements: 1) same as that of 10 low-priority requirements (Level of Importance: 1 x Number of requirements: 10).

> [!NOTE]
> This objective doesn't optimize to book all high priority requirements ahead of the others within the day. It only optimizes to ensure that the high priority requirements are booked to the earliest possible day, not the earliest possible time slot within the day. 

### Maximize Preferred Resources (v3.0+):  

Resource Scheduling Optimization will consider the list of preferred resources noted on related requirements. The optimizer will try to assign bookings to preferred resources first while meeting other constraints and objectives.

This is achieved by adding the "Maximize Preferred Resources" objective to your Resource Scheduling Optimization goal and adding a preferred resource(s) on the requirement that will be optimized.

> [!div class="mx-imgBorder"]
> ![Screenshot of maximize preferred resource objective in a goal.](./media/scheduling-rso-3-0-maximize-preferred-resources.png)

The following screenshot shows an example of adding a resource to a requirement (for example: Jorge Gault) as a preferred resource.
> [!div class="mx-imgBorder"]
> ![Screenshot of requirement with preferred resource.](./media/scheduling-rso-3-0-requirement-preferred-resources.png)

After running an optimization schedule, the requirement is scheduled to the preferred resource. In the following example, work order 00100 is scheduled to Jorge Gault.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two requirements_3.](./media/scheduling-rso-3-0-preferred-resource-optimized.png)

> [!NOTE]
> The Maximize Preferred Resources objective only applies to **preferred** resources.

### Best Matching Skill Level (v3.0+)

Resource Scheduling Optimization will consider the proficiency rating when matching characteristics required by requirements and the resources who possess those characteristics. This is dependent on the **Meets Required Characteristic** constraint within the optimization goal.

If the "Meets Required Characteristics" constraint **is checked**:

- Resources without the characteristic (skill) or lower-than-required proficiency ratings are not eligible at all
- Resources with the exact skill level (best matching) get the highest score
- The more overqualified a resource is, the lower score their score will be  

If the "Meets Required Characteristics" constraint **is unchecked**:

- Less qualified resources and resources without the skill can still be booked
- Overqualified resources get a higher score than less qualified resources
- The more overqualified a resource is, the lower their score will be
- The less qualified a resource is, the lower their score will be
- Resources without the skill get the lowest score

For example, if a characteristic (skill) rating model ranges from 1 to 10, and the requirement asks for a skill level of 4, the following example shows the score distribution based on skill level of the resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two requirements_4.](./media/scheduling-rso-3-0-characteristic-proficiency-chart.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two requirements_5.](./media/scheduling-rso-3-0-characteristic-proficiency-objective.png)

> [!NOTE]
> In the 2020 release wave 2 update, the **Best matching skill level** objective was enhanced to prioritize assigning jobs to resources with fewer skills first. This is valuable for organizations that have a workforce with varying skills. Assigning jobs to resources with fewer skills or more common skills first when there is more capacity than demand allows Resource Scheduling Optimization to reserve capacity for resources with multiple and unique skills for higher priority emergency situations. For example, imagine one resource has installation skills and another resource has installation _and_ repair skills. Resource Scheduling Optimization will initially schedule installation jobs to the first resource who only has installation skills. This is advantageous because if a repair job needs to be scheduled later, the second resource will have capacity; if all the installation jobs were scheduled to the second resource, then no one would be available for the repair job since the first resource does not have the skills for repairs. This improvement to the **Best Matching Skill** level objective requires no additional configuration.

### Schedule as soon as possible

Occasionally, there may be more resource capacity than there is demand for resources (for example, total time of work orders is less than total available time of resources). In these circumstances, there is a business decision about whether to fully book some resources or leave resources with some capacity as a contingency for emergency or unplanned work.

In order to effectively front-load optimized bookings, add the **Schedule As Soon As Possible** objective into your optimization goal in the corresponding order:

> [!div class="mx-imgBorder"]
> ![Screenshot of schedule as soon as possible constraint in correct order.](./media/rso-schedule-as-soon-as-possible-objective-order.png)

## Default optimization goal

When Resource Scheduling Optimization is deployed for the first time, the system automatically creates a default goal with some constraints and objectives enabled. Users can modify as needed or create a new optimization goal and associate it as a default goal.

> [!div class="mx-imgBorder"]
> ![Screenshot of default goal in scheduling parameters](media/rso-default-goal-1.png)

**Engine Effort Level** determines how much effort Resource Scheduling Optimization makes finding the best combination of resources, route, and day or time. The higher the effort, the longer Resource Scheduling Optimization takes to complete the execution. For example, the effort might be very light, light, moderate, intense, or very intense. The higher the intensity, the more iterations of possible combinations the Resource Scheduling Optimization engine considers.

> [!div class="mx-imgBorder"]
> ![Screenshot of default goal deployed with resource scheduling optimization_1](media/rso-default-goal-2.png)

The default goal is used when single resource optimization is selected from the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of default goal deployed with resource scheduling optimization_2](media/rso-single-resource-1.png)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
