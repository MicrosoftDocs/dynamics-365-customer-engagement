---
title: Resource management changes (Project Service Automation 3.x)
description: This topic provides information about the changes to the Resource management area.
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

# Resource management changes (Project Service Automation 3.x)

The sections of this topic provide information about the changes that have been made to the Resource management area of Dynamics 365 Project Service Automation version 3.x.

## Project estimates

Instead of being based on the **msdyn\_projecttask** entity (**Project Task**), project estimates are based on the **msdyn\_resourceassignment** entity (**Resource Assignment**). Resource assignments have become the "source of truth" for task scheduling and pricing.

## Line tasks

In PSA 3.x, line tasks are obsolete (deprecated). Assignments now point to the whole task instead of the line tasks.

The following example shows how a task that is named "Test task" is assigned to team members A and B in earlier versions of PSA and in PSA 3.x.

- **Before PSA 3.x:**

    - Test task

        - Test task – Line task 1

            - Assignment to A

        - Test task – Line task 2

            - Assignment to B

- **PSA 3.x:**

    - Test task

        - Assignment to A
        - Assignment to B

## Unassigned assignment

In PSA 3.x, an unassigned assignment is an assignment that is assigned to a **NULL** team member and a **NULL** resource. Unassigned assignments can occur in a couple of scenarios:

- If a task has been created, but it hasn't yet been assigned to any team member, an unassigned assignment is always created. 
- If all assignees on a task are removed, an unassigned assignment is re-created for that task.

## Scheduling fields on the Project Task entity

The fields on the **msdyn\_projecttask** entity have been deprecated or moved to the **msdyn\_resourceassignment** entity, or they are now referenced from the **msdyn\_projectteam** entity (**Project Team Member**).

| Deprecated field on msdyn\_projecttask (Project Task) | New field on msdyn\_resourceassignment (Resource Assignment) | Comment |
|---|---|---|
| msdyn\_assignedresources | None | |
| msdyn\_assignedteammembers | None | |
| msdyn\_numberofresources | None | |
| msdyn\_scheduledhours | None | |
| msdyn\_effortcontour | msdyn\_plannedwork | The format of the JavaScript Object Notation (JSON) data structure that is stored in the field has been changed. |

## Schedule contour

The schedule contour is stored in the **Planned Work** field (**msdyn\_plannedwork**) of each **Resource Assignment** entity (**msdyn\_resourceassignment**).

### Structure

The new structure of the schedule contour consists of flexible time slices that are defined for each day of the schedule. Each time slice has the following properties:

- **Start** – The start of the working hours for the day, according to the project calendar.
- **End** – The end of the working hours for the day, according to the project calendar.
- **Hours** – The number of hours that are assigned on the day.

**Example**

This example uses a project calendar where the workday is from 9 AM to 5 PM in the UTC-8 time zone.

```json
[{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]
```

### Auto-scheduling and manual scheduling

If a task is auto-scheduled, the hours are front-loaded, and the task duration might be reduced.

**Example**

The following task is auto-scheduled for 18 hours over three days (December 3, 2018, to December 5, 2018).

```json
[{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]
```

If a task is manually scheduled, the hours are evenly distributed to all the dates.

**Example**

The following task is manually scheduled for 18 hours over three days (December 3, 2018, to December 5, 2018).

```json
[{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":6},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":6},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":6}]
```

### Assignment unit

The assignment unit has been deprecated in PSA 3.x. The task effort hours are now equally divided, per day, among all the assigned resources.

**Example**

In this example, the task is is assigned to two resources and is auto-scheduled for 36 hours over three days (December 3, 2018, to December 5, 2018).

- Assignment 1:

    ```json
    [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]
    ```

- Assignment 2:

    ```json
    [{"End":"\/Date(1543885200000)\/","Start":"\/Date(1543856400000)\/","Hours":8},{"End":"\/Date(1543971600000)\/","Start":"\/Date(1543942800000)\/","Hours":8},{"End":"\/Date(1544058000000)\/","Start":"\/Date(1544029200000)\/","Hours":2}]
    ```

## Pricing dimensions

In PSA 3.x, resource-specific pricing dimension fields (such as **Role** and **Organizational Unit**) have been removed from the **msdyn\_projecttask** entity. These fields can now be retrieved from the corresponding project team member (**msdyn\_projectteam**) of the resource assignment (**msdyn\_resourceassignment**) when project estimates are generated. A new field, **msdyn\_organizationalunit**, has been added to the **msdyn\_projectteam** entity.

| Deprecated field on msdyn\_projecttask (Project Task) | Field from msdyn\_projectteam (Project Team Member) that is used instead |
|---|---|
| msdyn\_resourcecategory | msdyn\_resourcecategory |
| msdyn\_organizationalunit | msdyn\_organizationalunit |

## Contours

The pricing and estimation contour fields have been deprecated on the **msdyn\_projecttask** entity. They have been moved to the **msdyn\_resourceassignment** entity.

| Deprecated field on msdyn\_projecttask (Project Task) | New field on msdyn\_resourceassignment (Resource Assignment) |
|---|---|
| msdyn\_costestimatecontour | msdyn\_plannedcostcontour |
| msdyn\_salesestimatecontour | msdyn\_plannedsalescontour |

The following fields have been added to the **msdyn\_resourceassignment** entity:

* msdyn\_plannedcost
* msdyn\_plannedsales

The following fields for planned, actual, and remaining cost and sales are unchanged on the **msdyn\_projecttask** entity:

* msdyn\_plannedcost
* msdyn\_plannedsales
* msdyn\_actualcost
* msdyn\_actualsales
* msdyn\_remainingcost
* msdyn\_remainingsales
