---
title: Sales estimates and projects
description: This topic provides information about leveraging the schedule and estimates in the sales process in Project Service (PSA).
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/04/2019
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

# Sales estimates and projects

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

During the sales process, Project Service (PSA) lets you create sales estimates by linking a project to a sales quote. This allows deterministic estimation to occur during the sales process to leverage project scheduling and estimation capabilities. If the sale goes through, the schedule used for sales estimation purposes can be used as the basis for any further refinement of the project plan.

## Linking a project to quote line

When you create a project-based quote line, you can create a new project or associate an existing project in the **Quote Line** page. 

> ![Quote Line form](media/project-8.png)
 
When you create a new project from the quote line detail, you can leverage project templates. Project templates are model projects that represent standard project plans and financial estimates that are common in an organization. They can also represent copies of project plans and estimates from past projects.

> ![Quote line details](media/project-9.png)
  
When you create the project from the quote, the project is automatically associated with the quote line.

## Components of estimates in a project

A schedule provides a way to divide work into tasks, maintain a hierarchy of tasks, determine what resources are required to complete a task, and assign an estimate of effort that is required to complete a task.

You can determine the work effort and schedule estimates by using the fields on the **Schedule** tab of the **Project** page. Because the project has a pricelist associated to it, financial estimates are determined using cost and sales prices defined in the pricelist.

## Importing estimates from project into quote

You can import project estimates into the quote line after you define them. In the **Quote Line Details** page, you can click **Import from estimates** to summarize project estimates by transaction type, role, or task level.
