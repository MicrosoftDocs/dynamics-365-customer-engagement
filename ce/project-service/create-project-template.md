---
title: Create a project template 
description: How to create a project template in Project Service
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
# Create a project template (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Project templates save you time if your company regularly bids on similar types of projects. They provide a standard set of roles and estimated hours for a type of project. Account managers and project managers can create projects based on a project template, or they can copy the template and make one of their own.  
  
## Components of project template
 A project template consists of three components:  
  
- **Work breakdown structure**: A work breakdown structure in a project template has the same set of elements as in the project. You can create a task hierarchy, associate roles to task, define schedule attributes, set dependencies and view all the data in the Gantt. The work breakdown structure in project templates also support task modes for each task. There is no difference between a project template and a project when creating work schedule.  
  
- **Project estimates**: Project estimates in templates work the same way as they do in projects, except the price lists for defaulting the cost and sales prices are always the default cost and sales price lists defined in [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] parameters. The rest of the functionality is the same as in a project.  
  
- **Project team formation**: When forming a project team for a project template, you can’t book a named resource in a template. You can use **Generate Project Team** in the work breakdown structure to generate a set of generic resources. You can also specify required skills and proficiencies for generic resources. You can’t substitute a generic resource with a bookable resource in project templates.  
  
## Create a project from a template  
 You can create a project from a template in these following ways:  
  
-   When creating a project from the quote, you can choose a project template in the project quick create form.  
  
-   When creating a project by clicking **New Project**, the project form displays before you save the record. From here, you can click **Pick a template** field to choose from the list of pre-defined project templates in your organization.  
  
-   Click **Create project from a template** on the **Project Template** page to create a project from the template.  
  
## Copying components of a template to a project  
 When you copy components of a template into a project, there are a few things you should know about.  
  
 **Copying a work breakdown structure**: When you copy the work breakdown structure from a project template, if the project has a different project calendar than the template, the work hours from the project’s calendar will be applied to the schedule of tasks. This adjusts the schedule to the backing project calendar. Similarly, the first task on the work breakdown structure takes the project’s start date, so the rest of the task hierarchy schedule is updated based on the duration and dependencies specified in the template’s work breakdown structure.  
  
 **Copying project estimates**: When you copy across project estimate lines, price lists are updated based on the owning unit of the project for the cost price list and customer for the sales price list. The unit cost and sales prices are determined from these price lists on projects that are associated to a sales entity.  
  
 **Copying a project team**: When you copy the project team from the template to a project, the generic resources are copied across, along with the skills and proficiencies defined in the template. Generic resource assignments are also maintained as in the project template.  
  
### See Also  
 [Project Manager Guide](../project-service/project-manager-guide.md)
