---
title:  Project templates 
description: This topic provides information about using project templates for quick project setup in Project Service (PSA).
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 12/27/2018
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

# Project templates 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

A project template is a predefined framework that helps you start a project quickly and easily. In Project Service (PSA), you can use a pre-defined template to create a new project with a single click. As with a project, you need to define the prerequisites for a project template. You’ll need to define a project calendar for each project template, and roles and pricelists must be pre-defined in the organization so that the components of the template to have useful data. 

A project template consists of three components: a schedule, project estimates, and project team members.

## Schedule

A schedule in a project template has the same set of elements as it would in the project. You can create a task hierarchy, associate roles to task, define schedule attributes, and set dependencies. A schedule in the project templates also supports task modes for each task and therefore supports the scheduling engine. You must associate a project calendar to the project template. There is no difference between a project template and a project when creating a work schedule.

## Project estimates

Project estimates in templates work the same way as in projects, but the cost and sales prices are pulled from the default cost and sales pricelist defined in the parameters.

## Creating a project from a template
 
A project is created from a template in a number of ways:

- When you create a project from the quote, you can choose a project template in the **Quick Create: Project** page.

> ![Project quick create form](media/project-11.png)

- When you create a project by clicking **New Project**, the **Project** page is displayed prior to saving the record. Use the **Pick a Template** field to choose from the list of predefined project templates in the organization.
- When you use **Create Project from a Template** on the **Template Entity** page to create a project from a template.

## Copying components of template to project

When you copy the components of a template into a project, a few overrides can happen depending on the settings in the project.

### Copying the schedule

When you copy the schedule from the template, work hours from the project’s calendar are applied to the task schedule if the project has a different project calendar than the template. This adjusts the schedule to match the backing project calendar. Similarly, the first task on the schedule takes the project’s start date, and the schedule of the rest of the hierarchy is updated based on the duration and dependencies specified in the template. 

### Copying project estimates 

When you copy across project estimate lines, the pricelists are updated based on the owning unit of the project for the cost pricelist, and the customer for the sales pricelist. The unit cost and sales prices are determined from these pricelists on projects that are associated to a sales entity.

### Copying project team

When a project team is copied from the template to project, the generic resources are copied along with the skills and proficiencies defined in the template. Generic resource assignments are also maintained as in the project template. Named resources aren’t supported in project templates.
