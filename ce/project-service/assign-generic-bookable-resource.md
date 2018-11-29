---
title: Assign generic bookable resources to a task and project team
description: This topic provides information about booking generic resources to tasks and project teams.
author: JohnPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 11/29/2018
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
# Assign generic bookable resources to a task and project team 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In addition to booking and assigning named or real resources to your project, you can assign generic resources to project tasks. These resources can serve as placeholders for named resources until you are ready to staff your project with named resources. This manifests itself mainly in the generic resource assignment and fulfilment scenario.

To do this you can type the position name of the generic resource in the resource cell of the schedule or click the resource icon in the cell and open the resource picker and type the name of the generic resource you wish to create.

![Creating and assigning a generic team member](media/RM-how-to-9.png)

This will open a team member quick create panel that allows you to set the role and organization unit of the generic resource team member.

![Generic team member quick create](media/RM-how-to-10.png)

Once created, it is assigned to the task and you can continue to assign that generic resource to other tasks in the task schedule.

![Assigning existing generic team member to tasks](media/RM-how-to-11.png)

Once you have assigned the generic resource you can generate a resource requirement for it and fulfil it either by directly booking or submitting a resource request to a resource manager.

![Booking a generic team member using schedule assistant](media/RM-how-to-15.png) 

![Generating a requirement for a generic team member](media/RM-how-to-12.png)

Also, on the team member grid, generic resources can be added directly in addition to the resource picker experience as documented above. They are added with a resource requirement that is based on the start/end dates and allocation method specified in the quick create form.

You can see a difference if you add the generic team member directly and then assign more tasks to the generic resource than they have required hours to cover. You can click Generate Requirement to regenerate the requirement to true up the required hours 
against assignments.

You can also click the resource requirement link in the team grid to open the requirement and add skills, preferred resources, etc.

![Resource requirement](media/RM-how-to-13.png)

