---
title: What's new or changed in Project Service Automation version 3
description: This topic provides information about what is new and changed in PSA version 3.
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 11/13/2018
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Dynamics 365 for Project Service 3.x
ms.author: john.burrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  
---

# What's new or changed in Project Service Automation version 3
[!INCLUDE[cc-applies-to-psa-app-2-4x-9-0-platform](../includes/cc-applies-to-psa-app-2-4x-9-0-platform.md)]

This topic provides information about the changes to UI, functionality, and terminology in Project Service Automation (PSA) between v2 and v3.

## Project scheduling
The project schedule, which was known as the Work Breakdown Structure (WBS) in v2, has been renamed Schedule and is accessed by clicking the **Schedule** tab. 
The schedule now has a new surface for interaction that is both modern and accessible, however the underlying PSA scheduling engine has not changed. The control buttons in the schedule grid’s ribbon allow you to interact with the schedule similar to the previous version of PSA. Additional changes to the schedule include:

- **Gantt chart** - The Gantt chart is no longer present. A new Gannt visualization will be returning in a future update.
- **Column headers** - You can hide column headers in the grid by clicking the down indicator next to the column title. 
- **Columns** - You can un-hide hidden columns by clicking **Add column**. 
- **Transaction category** - A **Transaction category** lookup has been added to the schedule grid and is shown by default. 
 
## Project templates
The following changes have been made to project template functionality.

### Create a project template 
You can create a project template in v3 similar to previous version of PSA. The template can contain only a schedule and the schedule can include assignments, but they are not required. If the schedule does have assignments, they can only be for generic resources. You can generate resource requirements for generic resources, but they can't be booked with real resources in the template. You can't book a real resource to a team in a template. 

### Create template from existing template
When you create a new project template from an existing template in PSA v3, the following happens: 

- The source project’s schedule is copied into the template. 
- Generic resources are copied into the team and any generic resource assignments are copied over. Requirements for the generic resources are not copied over. 

### Create a template from an existing project
When you create a new project template from an existing project, the following happens: 

- The source project’s schedule is copied into the template. 
- Generic resources are copied into the team and any generic resource assignments are preserved. Requirements for the generic resources are not copied over.	
- Named resources, both assigned or unassigned are removed from the team and replaced with generic resources.
- If present, customer information is removed. 
- If present, references to quotes and contracts are removed. 

### Create a project from a template
In PSA v3, when you create a new project from a template, the following happens:

- The schedule, team, and assignments are copied to the new project.   
- The start date is either the copy date or date selected by the user.   
- For any generic team members with resource requirements in the template, the requirements are not copied or generated automatically. You will need to generate them. 

## Copy a project
In PSA v3, when you copy a project, the following happens: 

- The estimated start date is copied, but can be changed.  
- The project schedule and tasks are copied. 
- Generic resources and their assignments are copied. Resource requirements for the generic resources are not copied. You will need to re-generate them. 
- Real resources and their assignments are not copied. Instead, they are replaced by generic resources. 
- Actuals are not copied to the new project. 

## Move a scheduled project
When you move the schedule of existing project forward, the following happens: 

- Task dates are automatically moved to correspond with the movement period. 
- Assigned generic resources remain assigned.   
- If they are generated before the project is moved, requirements for the generic resource remain the same and are not automatically re-generated. You will need to generate them again to reflect the new assignments due to the task movement. 
- Assignments on real resources change to correspond with the task date movement. Bookings on real resources do not change. You will need to modify the bookings using the reconciliation view. 
- Team resources with bookings but no assignments do not change. 
- Actuals do not move. 

## Estimates
Estimates have been split into two tabs, **Resource assignment** and **Estimates**. The **Resource assignment** tab contains the effort estimates and shows the resource assignments for the tasks in a time-phased view. You can edit the estimates based on what the scheduling engine has generated.

The **Estimates** tab shows the cost and sales amounts for resource assignments. The amounts are read-only. The costing and sales pricing are now driven from the team member assignments on the schedule. This means that if you have a task without any assignment, the task will show under the unassigned bucket. This also means that without **role**, which is a default pricing dimension, there will be no estimated cost or sales if you have a customer or contract/quote associated with the project. 
  
Category is also supported on tasks in the schedule view. Grouping by category on the time-phased view of estimates will provide a better experience, especially when you also have expense estimates in your project. Expense estimates are entered using a grid on a separate tab. 

## Resource management
In PSA v3, staffing a project with generic or real resources has changed dramatically from the 2.x release With the new Unified Client UI and changes in the relationship between bookings and assignments, staffing a project iwth generic or real resources has changed dramatically in the PSA v3 release. However, the concepts of bookable resources, both **real** and **generic** remain the same, as do team members, requirements, assignments, and bookings.   

### Assign a "real" bookable resource 
Bookings and task assignments are not tightly coupled as in previous versions of PSA. You can use the team grid to book a **real** team member, similar to in-market.
Using the resource picker on the schedule, you can select the team member created in the team view and assign them to tasks. You can continue to assign tasks to them, even past their bookings. Use the **Reconciliation** tab to reconcile team members that have differences in bookings and assignments.
The resource picker will show the team members for the project. You can also use the recource picker search for and view other bookable resources that are not part of the project team. You can assign them to a task and they will become part of the project team. You will need to book them using the **Schedule board** or **Reconciliation** tab.

### Assign a generic bookable resource on a task and project team, then fulfill with a “real” resource via Schedule Board 
Generate team is no longer used for generic resources.  You now create and directly assign a generic resource from the schedule by typing the position name of the generic resource in the resource cell of the schedule or click the resource icon in the cell and open the resource picker and type the name of the generic you wish to create.   This will open a team member quick create panel that allows you to set the role and organization unit of the generic resource team member.  Once created, it is assigned to the task and you can continue to assign that generic resource to other tasks in the WBS schedule.    
 
Once you have assigned the generic to all of the tasks you wish, you generate a resource requirement for it and fulfil it either by directly booking with the Schedule Board or submitting a resource request to a resource manager.  On the team member grid, generics can be added directly as well. 

Generic resources are added to the project team in either way with no resource requirement and with the start/end dates of the project until the resource requirement is generated.  To generate a requirement, select the generic resource and click generate.  You will see that the requirement link now shows up and the required hours is populated with the assigned hours.   
 
•	You can click the link to open the requirement and add skills, preferred resources, etc.   
•	There is no change in behavior of the requirement from version 2.x.    
•	Directly booking with the schedule board has not changed from 2.x.   
•	When the booking is complete and totally fulfilled by a named resource, the generic is replaced with the named resource as it does in version 2.x.  The assignment on the schedule is updated with the named resource as well. 
•	Submitting a resource request for a generic resource has not changed substantially from version 2.x. 
•	Resource request processing has not changed from version 2.x. 
•	Requirements with proposed resources now have Proposed Resources on a tab vs. a section in version 2.x. 


## Time and expense


## Multi-dimensional pricing


## Quotes and contracts
