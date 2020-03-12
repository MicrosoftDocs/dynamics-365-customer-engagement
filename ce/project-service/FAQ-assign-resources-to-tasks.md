---
title: Assign a resource to a task
description: This topic provides information about how to assign resources to tasks.
author: ruhercul   
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 9/27/2019
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.technology: Dynamics 365 Project Service Automation 3.x
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




# Assign a resource to a task

There are three ways to assign a resource to a task in Microsoft Dynamics 365 Project Service Automation.

## Book a resource as a team member, and then assign the resource to a task

You can add a resource to the project team, and then assign the resource to tasks in the project schedule.

1. On the **Team Member** tab, add a new team member by selecting **New**. 

2. The **Team Member Quick Create** panel opens, where you can select the bookable resource name and set a role. 

    Select one of the following allocation methods for the resource’s booking:

    - **Full Capacity** books the resource’s full capacity for the specified from and to dates.
    - **Percentage Capacity** books the resource for a percentage of the resource's capacity for the specified from and to dates.
    - **By Hours Distribute Evenly** books the resource for a specified number of hours, distributing them evenly per day over the specified from and to dates.
    - **By Hours Front Load** books the resource for a specified number of hours, front-loading the per-day hours over the specified from and to dates.
    - **None** adds the resource to the team but doesn’t create any bookings that absorb their capacity.

3. On the **Schedule** grid for a task, select the **Resource** icon in the resource cell, and then under **Team Members**, select the team member you just added. 

> [!NOTE]
> On the **Team Member** and **Reconciliation** tabs, the resource shows booked and assigned hours. The hours should be the same, but it isn't required as bookings and assignments are not tightly coupled. The **Reconciliation** tab gives you details when they are different, such as when you assign a resource more hours than you have booked. If needed, you can correct the information by extending the resource's bookings or changing the assignment.

## Create a generic team member through task assignment

When you create a generic team member through task assignment, you create a placeholder or generic resource that describes the characteristics of the named resource you ultimately want to work on the tasks. You then generate a requirement (or submit a request using the requirement) that is used to search for and book the named resource.

1. On the **Schedule** grid for a task, select the **Resource** icon in the resource cell.

2. Type a name to serve as the placeholder resource’s name. For example, Program Manager.

3. Select **Create**, and in the **Quick Create Project Team Member** field, set the role for the generic resource.

4. You can continue to assign tasks to this placeholder resource by selecting the resource on the **Resource Selector** for the task. They’re listed under **Team Members**.

5. When you’re done assigning the generic resource, select the generic resource on the **Team** tab, and then select **Generate Requirement** to create a resource requirement for the generic resource.

6. Select **Book** for the generic resource. You can then use the Schedule board to find and book a real resource. You can also submit the requirement for fulfillment by a resource manager.

7. When the generic resource is fulfilled with a named resource, the generic resource is removed from the team and the task assignments for the generic resource are assigned to the named resource that fulfilled the generic resource’s resource requirement.

## Assign a named resource from the list of all bookable resources

You can use the search box in the **Resource Selector** to search all bookable resources and assign them to a task.

Resources assigned this way are added to the team without any bookings. This is similar to adding a team member and selecting None as the allocation method. The resource is displayed in the **Team** and **Reconciliation** tabs as resources with only assignments and a booking deficit. Book them if you want to use their availability.

1. On the **Schedule** grid for a task, select the **Resource** icon in the resource cell.

2. Start typing a name. The search results for the name are displayed in the **Resource Selector** under **Other Resources**.

3. Select the resource that you want to assign to the task.

