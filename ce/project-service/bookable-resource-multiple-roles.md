---
title: Estimate project sales and costs when a bookable resource fills mulitple roles on a project 
description: This topic provides information about how pricing dimensions can be used to support pricing and costing for a resource that fills mulitple roles on a project.
author: rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 10/01/2020
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
  - ProjectOperations
---

# Estimate project sales and costs when a bookable resource fills mulitple roles on a project 

Project-based companies often have the need for one resource to perform mulitple roles on a project. Each of these roles could be priced and costed differently which means the same resource's time on the project could get a different financial estimate depending on the bill and cost rates for each of the roles. Project Service Automation allows the setup of the values on the team member record for the named resource and allows for different overrides on each of the tasks that the team member is assigned to.

The following example  explains how the simple override of this value allows a resource to have multiple roles on a project with different cost and bill rates.

## Create tasks
Create two project tasks for 40 hours each, Task A and Task B. Select Task A as a predecessor to Task B.

## Set up Role and Organization Unit for a generic project team member

1. On the **Schedule** page, select the **Task** row for Task A. 
2. In the **Resources** field, select **Create** in the drop-down list.
3. On the **Team Member Quick Create** page, specify the attributes of the generic team member who can perform this task.
4. Select the appropriate role and organizational unit, and then select **Save and Close**. A generic team member is created and assigned to this task. 

Repeat these steps for Task B and make sure that the role and organizational unit on the generic team member created for Task B is different than Task A. 

## Set up role and organization unit for a project task

1. After you create Task A, select the task, and then select **Edit task**.
2. On the **Task Details** page, find the **Role** and **Organizational Unit** fields, add the values that are required of a resource that would perform this task. 

  > [!NOTE]
  > If you are completing this scenarios using Project Service Automation demo data, select **Consulting Lead** for the role, and **Fabrikam US** as the organizational unit.

3. Select Task B and then select **Edit task**.
4. On the **Task Details** page, find the **Role** and **Organizational Unit** fields, add the values that are required of a resource that would perform this task. Make sure that the values in the **Role** and **Organizational Unit** fields are different for Task B from those for Task A. 

  > [!NOTE]
  > If you are completing this scenarios using Project Service Automation demo data, select **Network Technician** for the role, and **Fabrikam US** as the organizational unit.

5. Save and close the **Task Details** page. 

## Team member and estimates behaviour 

1. On the **Task Details** page, on the**Team Member**, select the two generic team Members and then select **Generate Requirements**. This will generate resource requirements. 
2. Select the team member row for **Consulting Lead** and then select **Book**. The schedule board opens and books a resource to that requirement.
3. Select the team member row for **Network Technician** and the select **Book**. The schedule board opens and books the same resource on that requirement.

### Team Member grid 
On the **Team Member** grid, notice that the two generic team member records are deleted and have been replaced one resource. There is one set of values for that resource that shows a default set of values for **Role** and **Organizational Unit**.
When you expand the row of that Team Member record, you can see distinct assignments on the team member record for both of those tasks. Each assignment row has task specific values for **Role** and **Organizational Unit**. 

### Estimates grid 
When you navigate to the **Estimates** grid, you will notice that both assignments for the same resource are priced differently.
The assignment for the resource on Task A is priced using the **Role** attribute value of **Consulting Lead**. The assignment for the same resource on Task B is priced using the **Role** attribute value of **Network Technician**.





