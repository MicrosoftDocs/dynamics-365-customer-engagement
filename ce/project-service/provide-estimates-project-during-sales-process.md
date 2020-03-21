---
title: Provide work estimates for a project during the sales process 
description: How to provide work estimates for a project during the sales process in Project Service
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
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
# Provide work estimates for a project during the sales process (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

During the sales process, you can work out sales estimates from the ground up with quote lines. [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] capabilities in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] provide a more scientific and deterministic way of coming up with sales estimates by breaking down work items and associating relevant attributes that contribute toward the estimates for the project in the work breakdown structure.  
  
 Once you win the sale, you can use the associated work breakdown structure in your project plan, refining it as necessary for successful completion of your project.  
  
## Link a project to a quote line  
 When creating a project-based quote line, you can create a new project from the quote line. You can then use project templates, which are either pre-configured standard project plans and financial estimates common to your organization, or a copy of a project plan and estimates from a past project. When you create a project, choosing a project template provides a basis to refine the project plan, estimates, and role requirements. By creating your project from the quote, the project is automatically associated with the quote line.  
  
## Project estimate components  
 The work breakdown structure in a project provides a way to break down work into tasks, maintain a hierarchy of tasks, and assign an estimate of effort required to complete each task. You can also associate roles to a task to indicate an estimate of the type of resource required to complete a task and a schedule.  
  
 The work breakdown structure helps you determine work effort and schedule estimates. By default, the project uses default price lists that you defined earlier. The cost and sales prices defined in the price lists help determine financial estimates for the project’s work breakdown.  
  
 If your project is associated with a quote, and the quote has a different price list from the default, the quote’s price list is used for financial estimates.  
  
## Import estimates from a project into a quote  
 Once you have project estimates in the project, you can import these estimates into the quote line:  
  
-   In **Quote Line Details**, click **Import from estimates**. 

-   Select whether to import project estimates summarized by transaction type, role, or work breakdown structure node level.  
  
### See Also  
 [Project Manager Guide](../project-service/project-manager-guide.md)
