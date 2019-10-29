---
title: Key concepts
description: This topic provides information about the key concepts for resource management in Project Service Automation.
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/28/2019
ms.topic: article
ms.prod: 
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

# Key concepts

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

The following table defines key concepts that are used in the Dynamics 365 Project Service Automation app.

| Concept                    | Definition |
|----------------------------|------------|
| Project team member        | As part of the project team, a project team member can be a named resource that has bookings, a named resource that doesn't have bookings, or a generic resource. Generic resources don't have bookings, are local to the project, and don't have capacity constraints across projects. |
| Project generic resource   | A resource placeholder that lets you form a team and staff a project plan without having to know the named resource. The project calendar is used as the generic resource's calendar. Generic resources can be added to a project team and assigned to tasks. |
| Booked hours               | Resource hours are hard-booked against a project to help guarantee that the project work is completed. Booked hours are consumed from the resource's overall capacity. Bookings are against named resources only, not against generic resources. |
| Assigned hours             | Resource hours are assigned to tasks in the project schedule. Assignments can be against either named resources or generic resources. Assignments can be independent of bookings. |
| Required hours             | The capacity that is required, but that isn't yet fulfilled by a named resource. Required hours are relevant only for generic team members that have generated resource requirements. |
| Demand                     | The current and incoming workload. In Project Service Automation, demand is shown as resource requirements or resource requests. |
| Resource requirement       | An entity that is used to capture required hours, start and end dates, skills, geography, and other pricing dimensions for the required resources. Resource requirements are either generated from project team members or individually created. |
| Resource request           | An entity that is used as an "envelope" to carry the resource requirement that must be fulfilled by a resource manager. |
| Resource default role      | The role that a resource is grouped under for utilization calculation. The resource is assumed to have the required skills for the role and to meet the target utilization for that role. |
| Resource organization unit | The organizational unit that a resource is assigned to. |
| Contour                    | Task, requirement, or assignment hours as they are broken down into a daily distribution. For example, a five-day, 40-hour task can be contoured into eight hours per day over five days. |
| Reconciliation view        | A view that shows the bookings and assignments for each project team member. This view lets the project manager look for any mismatch between bookings and assignments, and to take corrective action if any mismatch occurs. |
| Work hours                 | An entity that is used to identify resource capacity, and working and non-working hours. This entity is also referred to as the resource calendar. |
