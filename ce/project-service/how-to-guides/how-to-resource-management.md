---
title: How to use new resource management features for Dynamics 365 for Project Service (version 3.x)
description: An English-language guide to new resource management capabilities in Project Service Automation for Dynamics 365
author: jburrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 11/15/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Resource your project in the Project Service app  

[!INCLUDE[cc-applies-to-psa-app-3.x](../../includes/cc-applies-to-psa-app-3x.md)]

You can staff your project with a team of generic or real resources in Dynamics
365 for Project Service Automation. Here are the various methods you can use to add and
assign team members and manage their bookings and assignments.

## Booking and assigning a “named” bookable resource on a task and project team

You can directly add a real or named resource to your project by booking them
directly.

![](media/2f262714c96c7325abd1e2d2007184f7.png)

To do this, select New on the Team tab of your project.

![](media/2f262714c96c7325abd1e2d2007184f7.png)

Select the bookable resource. The role will be populated with their default role
(if they have one), but you can change it if needed. Select the from and to
dates for the resource. Select the allocation method of the resource’s capacity:

-   Full capacity

-   Percentage capacity

-   By hours – distribute evenly

-   By hours – front load

Select if you want the team member to be an approver for the project. Selecting
yes, means that they can approve submitted time or expense entries for this
project.

Once the resource is part of the team, you can switch to the schedule tab and
assign them to tasks. The resource picker that is launched from the task grid
will show the team members for the project under Team Members.

Resource bookings and task assignments are not tightly coupled. This means that
when you use the resource picker in the schedule, you can assign tasks to team
members more than their bookings on the project.

![](media/30219f2698badeaeab18b800bc7c5da1.png)

You can see differences in team member bookings and assignments in either the
team tab or the reconciliation tab, where you can reconcile differences between
bookings and assignments for resources at a detailed level.

You can also use the resource picker in the schedule tab to select resources
that are not already part of the team. They show on the resource pickers as
Other Resources

![](media/376961383a6b6f866f04f63f6207211d.png)

When you do this, the resource is added to the project team, but no bookings are
made for them.

![](media/30219f2698badeaeab18b800bc7c5da1.png)

You can use the reconciliation tab’s extend bookings capability or the schedule
board to book the resource’s capacity to the project.

![](media/94d4a65675b02692180f948651b7ae34.png)

Once a team member is booked on your project, you can either use maintain
bookings or use the Schedule Board directly to manage their bookings.

![](media/0c76de23ef9cd384f3272be217887e7b.png)

