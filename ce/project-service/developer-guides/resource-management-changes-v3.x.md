---
title: Resource management changes (Project Service 3.x)
description: This topic provides information about the changes to the Resource management area in Microsoft Dynamics 365 for Project Service Automation 3.x.
author: makk
manager: kfend
ms.custom:
  - dyn365-projectservice
ms.date: 03/18/2019
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: makk
audience: admin
search.audienceType: 
  - admin
  - customizer
search.app: 
    - D365PS
---

# Resource management changes (Project Service 3.x)
The sections in this topic provide information about the changes that have been made to the Resource management area of Microsoft Dynamics 365 for Project Service Automation (PSA) v3.x.

## Project estimates
Instead of being based on the **msdyn_projecttask** (Project Task), project estimates are based on **msdyn_resourceassignment** (Resource Assignment). The resource assignments have become the source of truth for task schedule and pricing. 

## Line tasks
In PSA v3.x, line tasks have been deprecated. Assignments now point to the whole task instead of the line tasks.

For example, assigning the task, "Test task" to team members A and B:  

- Prr-PSA v3.x:

      Test task
        Test task - Line task 1
            Assignment to A
        Test task - Line task 2
            Assignment to B

- PSA v3.x:

      Test task
        Assignment to A
        Assignment to B

## Unassigned assignment
In PSA 3.x, an unassigned assignment is an assignment that is assigned to **NULL** team member and **NULL** resource. Unassigned assignments can happen in a couple of scenarios:

- When a task is created but not assigned to any team member, an unassigned assignment is always created. 
- When all assignees on a task are removed, an unassigned assignment is recreated for that task.

## Scheduling fields on the Project task entity
The fields in **msdyn_projecttask** have been deprecated or moved to **msdyn_resourceassignment** or, are now referenced from **msdyn_projectteam** entity.

Deprecated field on **msdyn_projecttask** (project task) | New field on **msdyn_resourceassignment** (resource assignment) | Comment
--- | --- | ---
msdyn_assignedresources | - |
msdyn_assignedteammembers |	- |
msdyn_numberofresources | - | 
msdyn_scheduledhours | - | 
msdyn_effortcontour | msdyn_plannedwork | The format of the **JSON** data structure stored in the field has been changed.

## Schedule contour 
The schedule contour is stored in the **Planned Work** field (**msdyn_plannedwork**) of each **Reasource Assignment** entity (**msdyn_resourceassignment**).

### Structure
The new schedule contour structure consists of flexible time slices that are defined for each day of the schedule.
Each time slice has the following properties:

- **Start** - Start of working hours for the day, according to the project calender.
- **End** - End of working hours for the day, according to the project calendar.
- **Hours** - The number of hours assigned on the day.

The following example uses a project calendar with **9 AM** - **5 PM** workday in **UTC -8** timezone:  

    [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

### Auto- and manual scheduling
If a task is auto-scheduled, the hours will be front loaded and the task duration may shrink.  

*Example:*  

- **Task 1**: 12/3/2018 to 12/5/2018 (three days) - 18 hours - auto scheduled:             
     
        [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

If a task is manually scheduled, the hours will be evenly distributed to all the dates.  

*Example:*  

- **Task 2**: 12/3/2018 to 12/5/2018 (three days) - 18 hours - manual scheduled:   

        [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":6},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":6},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":6}]

### Assignment unit
The Assignment unit has been deprecated in PSA 3.x. The task effort hours are now divided equally per day for all of the assigned resources.  
        
*Example:*

- **Task 1**: 12/3/2018 to 12/5/2018 (three days) - assigned to two resources - 36 hours - auto-scheduled:
    - Assignment 1:  

            [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]  

    - Assignment 2:  

            [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

## Pricing dimensions
In PSA 3.x, resource-specific pricing dimension fields (like **Role** and **Organizaitonal Unit**) have been removed from  **msdyn_projecttask** and can now be retrieved from the corresponding team member (**msdyn_projectteam**) of the resrouce assignment (**msdyn_resourceassignment**) when project estimates are generated. A new field, **msdyn_organizationalunit** has been added to the **msdyn_projectteam** entity.

Deprecated field on **msdyn_projecttask** (project task) | Field from **msdyn_projectteam** (project team member) that is used instead
--- | --- 
msdyn_resourcecategory | msdyn_resourcecategory
msdyn_organizationalunit | msdyn_organizationalunit

## Countours
The pricing and estimation contour fields have been deprecated on **msdyn_projecttask** and moved to the **msdyn_resourceassignment** entity.

Deprecated field on **msdyn_projecttask** (Project Task) | New field on **msdyn_resourceassignment** (Resource Assignment)
--- | --- 
msdyn_costestimatecontour | msdyn_plannedcostcontour
msdyn_salesestimatecontour | msdyn_plannedsalescontour

The following fields are added to **msdyn_resourceassignment** entity:
* msdyn_plannedcost
* msdyn_plannedsales

Field for planned, actual, and remaining cost and sales, are unchanged on the entity, **msdyn_projecttask**:
* msdyn_plannedcost
* msdyn_plannedsales
* msdyn_actualcost
* msdyn_actualsales
* msdyn_remainingcost
* msdyn_remainingsales


