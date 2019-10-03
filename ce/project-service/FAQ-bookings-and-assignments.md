---


title: Resource bookings and how they relate to task assignments
description: This topic provides information about how to manage named resources, resource bookings and task assignments and how they relate to each other.
author: ruhercul   
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 9/27/2019
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Resource bookings and how they relate to task assignments


There are two ways that named resources can be booked to a project team and assigned project tasks:

- The resource can be directly booked onto a project, and then assigned to project tasks.
- The tasks can be assigned to a generic resource, which is then used to find and replace the generic with a named resource. 

In both cases, the act of booking the resource reserves the resource’s capacity.

The project manager who is planning the project owns the project plan and the schedule. By using the generic resource for the assignment and then generating a resource request from it, the project manager can book resources onto the project with contours specified in the project plan. They can book resources to a project and then assign them to tasks, however there is no way to align the booking contours with the contours of the tasks. Bookings don't affect the project schedule.

Consider a complex project with multiple overlapping tasks where multiple resources of the same type need to work concurrently. If a resource is given a contour that differs from that of the aggregate of their assignments, it’s difficult to modify the tasks to fit the contour of the bookings to their discrete tasks and their original contours.

In the example below, the total effort required by the same resource from a set of four tasks is 62 hours over a two-week period and there is a specific contour. If the resource Bob is booked for 62 hours during the same two weeks but with a different contour, the requirement and bookings are in alignment.

| **Task contours**    | **Total hours** | Mo 6/4 | Tu 6/5 | We 6/6 | Th 6/7 | Fr 6/8 | Sa 6/9 | Su 6/10 | Mo 6/11 | Tu 6/12 | We 6/13 | Th 6/14 | Fr 6/15 |
|----------------------|-----------------|--------|--------|--------|--------|--------|--------|---------|---------|---------|---------|---------|---------|
| Task 1               | 24              | 8      | 8      | 4      |        |        |        |         |         |         | 4       |         |         |
| Task 2               | 16              |        |        | 4      | 4      |        |        |         | 8       |         |         |         |         |
| Task 3               | 10              |        |        |        |        | 4      |        |         |         | 4       |         | 2       |         |
| Task 4               | 12              |        |        |        |        |        |        |         |         |         | 4       |         | 8       |
|                      |                 |        |        |        |        |        |        |         |         |         |         |         |         |
| **Totals**           | 62              | 8      | 8      | 8      | 4      | 4      |        |         | 8       | 4       | 8       | 2       | 8       |
|                      |                 |        |        |        |        |        |        |         |         |         |         |

### Bob's availability
| **Resource   booking** | **Total hours** | Mo 6/4 | Tu 6/5 | We 6/6 | Th 6/7 | Fr 6/8 | Sa 6/9 | Su 6/10 | Mo 6/11 | Tu 6/12 | We 6/13 | Th 6/14 | Fr 6/15 |
|------------------------|-----------------|--------|--------|--------|--------|--------|--------|---------|---------|---------|---------|---------|---------|
| Bob                    | 62              | 4      | 4      | 8      | 8      | 8      |        |         | 4       | 4       | 8       | 8       | 6       |

However, there is no systematic way to assign the booked hours contour to tasks on a per-day basis. If the project manager is willing to change the project schedule to meet the availability of the resource, then they’ll have to remove the assignment and revise all the tasks to match the booking contours.

In the case where an organization has given the task of project planning to both a project manager and a resource manager, the project manager sets the schedule, and that includes contouring of the work required. The resource manager shouldn’t be able to affect the schedule without the project manager’s knowledge by changing effort contours while booking real resources. If the resource manager is fulfilling something different from what the project manager requested, they need to come to agreement about what changes are needed in the project schedule.

Since bookings and assignments are not tightly coupled, it’s possible to book contours that are different than the task contours or change the assignments to result in circumstances where bookings and assignments are out of alignment.

The **Reconciliation View** allows the project manager to see the bookings and assignments for each project team member. The view uses colors and shading to show where there is a mismatch between a team members bookings and assignments. Based on this information, the project manager can take corrective action to either extend resource bookings for cases where there are assignments and no bookings or cancel bookings where resources are booked but have no assignments.

> [!NOTE]
> If you move a task that you have contoured yourself, these contours aren’t maintained. The contours are regenerated according to the project calendar to account for changes in work hours and holidays. This is by design because the system doesn’t know the intent of the original contour and can’t determine whether it makes sense to retain that contour in a new time period. Because bookings and assignments are disconnected, the bookings retain the original booking contours. In this case, you’ll need to cancel and rebook to the new assignment contour.

