---
title: Changes in the Resource Management area (Project Service 3.0)
description: This topic describes solution changes for Project Service 3.0 in the Resource Management area
author: makk
manager: rchawla
ms.custom:
  - dyn365-projectservice
ms.date: 12/14/2018
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

# Changes in the Resource Management area (Project Service 3.0)

## Project estimates
Starting Project Service 3.0, estimates will be based on **msdyn_resourceassignment** (Resource Assignment), instead of being based on the **msdyn_projecttask** (Project Task). The Assignments have become the source of truth for the task schedule and pricing. 

## Line tasks
- Line tasks are deprecated since Project Service 3.0
- Assignments now point to the task itself instead of line tasks

*Scenario*: Assign a task "Test task" to team members A and B  

- Old structure:

      Test task
        Test task - Line task 1
            Assignment to A
        Test task - Line task 2
            Assignment to B

- New structure:

      Test task
        Assignment to A
        Assignment to B

## Unassigned assignment
- New since Project Service 3.0
- Unassigned assignment is an assignment that is assigned to NULL team member and NULL resource
- When a task is created and is not assigned to any team member, an unassigned assignment is always created
- When all assignees on a task are removed, the unassigned assignment is recreated for that task

## Scheduling fields of the Project Task entity
These fields in **msdyn_projecttask** are deprecated, or moved to **msdyn_resourceassignment**, or referenced from **msdyn_projectteam** entity.

Deprecated field on **msdyn_projecttask** (Project Task) | New field on **msdyn_resourceassignment** (Resource Assignment) | Comment
--- | --- | ---
msdyn_assignedresources | - |
msdyn_assignedteammembers |	- |
msdyn_numberofresources | - | 
msdyn_scheduledhours | - | 
msdyn_effortcontour | msdyn_plannedwork | Format of the **JSON** data structure stored in the field has been changed

## More details on the new structure for Schedule contour (**msdyn_plannedwork** field on **msdyn_resourceassignment** entity)
The schedule contour is stored in Planned Work field (**msdyn_plannedwork**) of each Reasource Assignment entity (**msdyn_resourceassignment**)   

### Structure
New schedule contour consists of array of flexible time slices defined for each day of the schedule.
Each time slice has the following properties:
- **Start** - start of working hours for that day, according to project calender
- **End** - end of working hours for that day, according to project calendar
- **Hours** - number of hours assigned on that day

The following example uses a project calendar with **9 AM** - **5 PM** workday in **UTC -8** timezone:  

    [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

### Auto / Manual scheduling
If a task is auto scheduled, the hours will be front loaded and the task duration might shrink.  

*Example:*  
* **Task 1**: 12/3/2018 to 12/5/2018 (3 days) - 18 hours - auto scheduled:             
     
        [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

If a task is manual scheduled, the hours will be evenly distributed to all the dates.  

*Example:*  
* **Task 2**: 12/3/2018 to 12/5/2018 (3 days) - 18 hours - manual scheduled:   

        [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":6},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":6},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":6}]

### Assignment unit
- Assignment unit is deprecated since Project Service 3.0
- The task effort hours are divided equally per day for all the assigned resources.  
        
*Example:*
* **Task 1**: 12/3/2018 to 12/5/2018 (3 days) - assigned to 2 resources - 36 hours - auto scheduled:
    - Assignment 1:  

            [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]  

    - Assignment 2:  

            [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]

# Pricing and estimation fields of the Project Task entity
## Pricing dimensions

- Resource specific pricing dimension fields (like Role and Organizaitonal Unit) are deprecated on **msdyn_projecttask**.
- Resource specific pricing dimensions are now retrieved from the corresponding Team Member (**msdyn_projectteam**) of the Resource Assignment (**msdyn_resourceassignment**) when project estimates are generated
- **msdyn_organizationalunit** is also a new field on the **msdyn_projectteam** entity

Deprecated field on **msdyn_projecttask** (Project Task) | Field from **msdyn_projectteam** (Project Team Member) that is used instead
--- | --- 
msdyn_resourcecategory | msdyn_resourcecategory
msdyn_organizationalunit | msdyn_organizationalunit

## Countours
Pricing and estimation contour fields are deprecated on **msdyn_projecttask** and moved to the **msdyn_resourceassignment** entity: 

Deprecated field on **msdyn_projecttask** (Project Task) | New field on **msdyn_resourceassignment** (Resource Assignment)
--- | --- | ---
msdyn_costestimatecontour | msdyn_plannedcostcontour
msdyn_salesestimatecontour | msdyn_plannedsalescontour

The following fields are added to **msdyn_resourceassignment** entity:
* msdyn_plannedcost
* msdyn_plannedsales

Field for planned / actual / remaining cost and sales remain unchanged on **msdyn_projecttask** entity:
* msdyn_plannedcost
* msdyn_plannedsales
* msdyn_actualcost
* msdyn_actualsales
* msdyn_remainingcost
* msdyn_remainingsales


