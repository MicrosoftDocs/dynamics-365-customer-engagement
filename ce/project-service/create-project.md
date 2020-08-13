---
title: Create a project
description: How to create a project in Project Service
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/13/2020
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
  - ProjectOperations
---
# Create a project (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Create a project using the [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] capabilities in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] when you want to create an opportunity, quote, or contract for project-based services. The [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] capabilities help you manage your project from opportunity through completion. When you create a project, you’ll also create a work breakdown structure, which affects your quotes, cost estimates, and resource management.  
  
1.  Go to **Project Service > Projects**.  
  
2.  Click **New Project**.  
  
3.  In the **Summary** area, enter a name for your project, and then fill in as many of the details as you can. Items marked with a red asterisk (*) are required.  
  
4.  Click **Save** to create your project so you can continue editing it.  
  
Next, you’ll create a work breakdown structure for your project to define the tasks, timing, and resource roles needed for the project.  

> [!NOTE]
> When scheduling, Project Service Automation respects the time zone of the applied **Work Hour** template. However, when viewing the schedule tasks, the start and end dates of a task will be displayed in the user's time zone. This applies to other time-phased views in the **Project** form. If the user's time zone does not match the time zone of the work hour template applied to the project, a warning which explains the difference will occur. 
  
### See Also  
 [Project Manager Guide](../project-service/project-manager-guide.md)
