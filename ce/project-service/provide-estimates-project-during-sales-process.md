---
title: "Provide work estimates for a project during the sales process (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "project-service-automation"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: A655C53F-19E2-4E62-8863-99A6D4691769
caps.latest.revision: 13
ms.author: "mkaur"
manager: "brycho"
---
# Provide work estimates for a project during the sales process (Project Service Automation)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

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
