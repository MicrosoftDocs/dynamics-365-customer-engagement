---
title: Upgrade considerations - PSA v2 or v1 to v3
description: This topic provides information about the considerations you must make when you upgrade from PSA v2 or v1 to v3.
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

# Upgrade considerations - PSA v2 or v1 to v3
[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

In v2 and v1 or PSA, task assignments were stored as child tasks (also called line tasks) in the **Task entity**, and indirectly related to the **Resource Assignment** entity. The line task was visible in the assignment popup on the WBS. In v3 of Project Service Automation (PSA), the underlying schema of assigning bookable resources to tasks has changed. The line task has been deprecated and there is a direct 1:1 relationship between the task in the **Task entity** and the team member in the **Resource Assignment** entity. Tasks that are assigned to a project team member are now stored directly in the Resource Assignment entity.  

These changes impact the upgrade of any existing projects that have resource assignments for named bookable resources and generic resources on a project team. This topic provides the considerations you will need to take into account for your projects when you upgrade v3. 

## Tasks assigned to named resources
Using the underlying task entity, tasks in v2 and v1 allowed team members to portray a role other than their default defined role. For example, Gracie George, who’s default assigned role is Program Manager, could be assigned to a task with the role of Developer. In v3, the role of a named team member is always thee default, so any task that Gracie George is assigned to uses her default role of Program Manager.  

If you have assigned a resource to a task outside of their default role in v2 and v1, when you upgrade, the names resource will be assigned the default role for all task assignments, regardless of role assignment in v2. This will result in differences in the calculated estimates from v2 or v1 to v3 because estimates are calculated based on the role of the resource and not the line task assignment. For example, in v2, two tasks have been assigned to Ashley Chinn.  The role on the line task for task 1 is Developer and for task 2, Program Manager.  Ashley Chinn has the default role of Program Manager.
 
When you upgrade to v3, line tasks are replaced with resource assignments on the task of the bookable resource team member. The assignment will use the default role of the bookable resource. Because the estimates are driven off of the resources default role, the sales and cost estimates may change.
 
After upgrade is complete, you can edit a team member's role to be something other than the assigned default. However, if you change a team members role, it will be changed on all of their assigned tasks as team members are no longer allowed to be assigned multiple roles in v3. 

This is also true for line tasks that were assigned to named resources when you change the resource’s organization unit from the default to another organization unit. After upgrade is complete, the assignment will use the resource’s default organization unit instead of the one set on the line task.

## Tasks assigned to generic resources
In v2 and v1, you can set the role and org unit on a task and then use the **Generate team** feature to generate generic resources based on the attributes set on the task. In v3, you create the generic team members with role and org unit, and then assign the team members to tasks.  
In v2 and v1, projects with generic resources can be in two states, or a mix of both at the task level: 

- Tasks with roles and org units set, but no affiliated resource assignment has been generated
- Tasks with generic team member resource assignments that were assigned by creating generic resource using the **Generate team** feature.

Before you begin your upgrade, we recommend that you regenerate the team for each project that has tasks assigned to generic resources or has yet to have generate team run on them.

For tasks that are assigned to generic team members that were generated with **Generate Team**, upgrade will leave the generic resource on the team and leave the assignment to that generic team member. We recommend that you generate the resource requirement for the generic team member after the upgrade but before you book or submit a resource request. This will preserve any org unit assignments on the generic team members that are different than the project’s contracting org unit.

For example, in the Project Z project, the contracting org unit is Contoso US. In the project plan, testing tasks within the Implementation phase have been assigned the role Technical Consultant and the assigned org unit is Contoso India. AFter the implementation phase, the integration test task is assigned to the role Technical consultant, but the org is set to Contoso US.  
When you generate a team for the project, two generic team members are created due to the different org units on the tasks. Technical consultant 1 will be assigned the Contoso India tasks and Technical consultant 2 will have the Contoso US tasks.  
 
> [!NOTE]
> In PSA v2 and v1, the team member does not hold the organization unit, that is maintained on the line task. 
 
When the upgrade is complete, the organization unit on the line task that corresponds to the generic team member is added to the generic team member and the line task is removed. Because of this, we recommend that before you upgrade, you generate or re-generate the team on each project that contains generic resources.

For tasks that are assigned to a role with an org unit that differs from the org unit of the contracting project, and a team has not been generated, upgrade will create a generic team member for the role, but will use the contracting unit of the project for the team member's org unit. Referring back to the example with Project Z, this means that the contracting org unit Contoso US, and the project plan testing tasks within the Implementation phase have been assigned the role Technical Consultant with org unit assigned to Contoso India. The Integration test task  which is completed after the Implementation phase has been assigned to the role Technical consultant. The org unit is Contoso US and a team has not been generated. Upgrade will create one generic team member, a Technical consultant, that has the assigned hours of all three tasks and an org unit of Contoso US, the project’s contracting org unit.   
 
This re-defaulting of the different resourcing org units on un-generated team members is the reason we recommend that you generate or re-generate the team on each project that contains generic resources prior to the upgrade so that the org unit assignments are not lost.

