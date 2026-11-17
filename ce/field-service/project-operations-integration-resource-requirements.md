---
title: Resource requirements in Field Service and Project Operations
description: Resource requirements define the work, timing, location, and skills needed for service jobs. See how Project Operations adds assignment details.
ms.date: 11/10/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wendysmith
---

# Resource requirements in Field Service and Project Operations

A resource requirement defines what needs to be done and what kind of resource can do the work. It captures how much work is needed, when and where it can happen, and what type of resource can do it. The scheduling engine uses the requirement to find suitable resources.

When you create a work order in Field Service, Field Service automatically creates a primary resource requirement. However, more complex service engagements often require multiple resources, each with different roles, planned effort, and scheduling needs.

The Field Service and Project Operations integration allows multiple resource requirements on a single work order, driven by project resource assignments. This connection brings resource planning in Project Operations directly to scheduling and execution in Field Service.

For example, a job might need a lead technician, an electrician, and a safety specialist, each responsible for different aspects of the same work order.

When the work order is linked to a project task, the integration automatically creates or reuses a resource requirement for each eligible project resource assignment. This eliminates the need to manually recreate scheduling demand in Field Service and helps keep resource requirements aligned with the project plan until bookings are created.

## Project resource assignments create and update requirements

When a Field Service work order is linked to a project task in Project Operations, the integration evaluates the resource assignments associated with that task.

Each eligible resource assignment with more than zero hours of planned effort is represented by its own resource requirement on the linked work order. Assignments without a named resource or a role can also create requirements.

The integration uses information from the project resource assignment and its related project task and team member to define scheduling demand, including:

- Assignment name and planned effort
- Assignment start and finish calendar dates
- Assignment calendar
- Project team member's role
- Named resource, if one is assigned
- Project task's promised start and finish

Project Operations remains the source of the project plan. Changes made directly to a projected resource requirement don't update the project resource assignment.

### Reuse existing resource requirements

Field Service normally creates a primary resource requirement when you create a work order. When you link the work order to a project task, the integration evaluates existing resource requirements before creating more.

The integration reuses a compatible requirement that's associated with the project team member or an eligible primary requirement on the work order. The requirement must be active and compatible with the same project and work-order context.

The integration doesn't reuse a requirement that:

- Is a child of a requirement group
- Has active bookings
- Contains any resource requirement details
- Is already associated with another project resource assignment

This behavior helps prevent duplicate scheduling demand while preserving existing requirement groups and scheduling details.

### Keep resource requirements aligned while protecting bookings

After you create requirements, the integration continues to synchronize supported changes from project resource assignments.

For example, if a project manager changes an assignment's planned effort from 8 hours to 12 hours before a booking is created, the integration updates the corresponding Field Service resource requirement.

If a change would alter the scheduling shape of a requirement that has an active booking, the integration preserves its existing availability dates, duration, calendar, allocation method, and scheduling details. Project task promise windows can still be updated.

Existing bookings aren't automatically moved to match a changed project plan. Dispatchers must deliberately revise or remove committed bookings when scheduling changes are needed. After active bookings are cleared, a later synchronization can apply the updated scheduling shape.

This process allows project managers to refine resource plans while protecting work already scheduled in Field Service.

## Example: Schedule multiple resources for equipment modernization

The project manager creates a project task in Project Operations and defines the resources needed to complete the work. The project task includes three resource assignments:

| Resource assignment | Planned effort | Resource |
| --- | --- | --- |
| Lead technician | 8 hours | A. Morgan |
| Electrician | 8 hours | J. Patel |
| Safety specialist | 4 hours | Not yet assigned |

When a Field Service work order is linked to the project task, the integration creates or reuses three resource requirements associated with the same work order. Each requirement represents the planned effort and scheduling needs of its corresponding project assignment.

For assignments with a named resource, the integration uses a resource preference to indicate who is intended to perform the work. The named resource isn't automatically booked. The dispatcher can schedule A. Morgan and J. Patel while leaving the safety specialist requirement open until an appropriate resource becomes available.

If the project manager changes the safety specialist's planned effort from 4 hours to 6 hours before a booking is created, the corresponding resource requirement is updated.

The result: The project manager manages planned resource needs in Project Operations, while dispatchers coordinate scheduling and resource commitments in Field Service. Multiple resource assignments remain connected to a single work order without requiring separate work orders for each resource.

## Project assignment scheduling mode

In the Field Service and Project Operations integration, when a project task is linked to a work order, the system needs to know how the effort on a project assignment is distributed. The **Project assignment scheduling mode** determines how planned effort from a Project Operations resource assignment becomes scheduling demand in Field Service.

| Option | How it works | Use it when |
| --- | --- | --- |
| [**Flexible Field Service scheduling**](#flexible-field-service-scheduling) | Creates a requirement with the total planned effort and an availability window. The scheduling engine spreads the work within that window based on resource availability. | Dispatchers need flexibility to determine when work is performed, and the total effort matters more than following the exact work pattern defined in Project Operations. |
| [**Project work pattern scheduling**](#project-work-pattern-scheduling) | Creates detailed scheduling intervals based on the planned work pattern of the resource assignment in Project Operations. The scheduling engine uses these planned scheduling intervals. Bookings can't exceed their capacity. | Dispatchers need visibility into the project's planned work distribution and capacity checks for bookings within its projected intervals. |

An administrator sets the [default project assignment scheduling mode](project-operations-integration-setup.md#configure-the-project-assignment-scheduling-mode) for the organization. You can override the default at the task level when [creating or associating a work order in Project Operations](/dynamics365/project-operations/field-service-integration/project-operations-integration-po-work-order-task). The override applies to the individual project task without changing the organization's default setting.

### Flexible Field Service scheduling

In this mode, the system creates a requirement with the total planned effort and an availability window. The dispatcher can schedule the work across the available days without needing to follow the exact daily distribution in the project plan.

For example, a project resource assignment requires 16 hours of work within a five-day window. The dispatcher can schedule the work across the available days without needing to follow the exact daily distribution in the project plan. The 16 hours might be scheduled as 4 hours Monday, 6 hours Tuesday, and 6 hours Wednesday based on resource availability and scheduling constraints.

### Project work pattern scheduling

In this mode, the system creates detailed scheduling intervals based on the planned work pattern of the resource assignment in Project Operations. Instead of using only the total effort and availability window, the integration reflects the planned distribution of work.

For bookings entirely within one projected interval, total active, non-canceled work can't exceed the interval's projected capacity. Capacity reflects planned effort, not necessarily the interval's duration.

Bookings outside the projected intervals are permitted and don't consume those intervals' capacity. This mode doesn't enforce a universal restriction that all bookings must occur within the project's planned working times.

Canceled bookings release interval capacity. Completed bookings continue to consume capacity while their booking records remain active.

For example, a project assignment requires 16 hours of work, planned as follows:

- Monday: 8:00 AM to 4:00 PM (8 hours)
- Tuesday: 8:00 AM to 4:00 PM (8 hours)

[!INCLUDE[footer-include](../includes/footer-banner.md)]