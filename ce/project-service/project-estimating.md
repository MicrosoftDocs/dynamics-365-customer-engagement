---
title: Project costs and revenue
description: This topic provides information about estimating project costs and revenue in Project Service.
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

# Project costs and revenue

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Project estimates provide the financial view for work that is estimated and scheduled in the project schedule. The **Estimates** tab on the **Projects** page shows you the cost and revenue impact of the work that you’re planning. It also provides information about many pre-defined dimensions. 

> ![Estimates tab](media/project-5.png)

## Cost and sales value of the project

Pricelists define the cost and bill rates for roles in a project. You can determine cost and revenue impact of the work based on the roles associated with the position name and the named resource assigned to a task. If there are tasks without any assignments (generic or named), you can’t get cost or sales estimates. Cost and sales values consider the date defined in the pricelists.

### Cost price defaulting 

Every project belongs to an organization listed in the **Contracting Unit** field in the project. The pricelist associated with the Contracting Unit is used to determine the unit cost price. You can determine the cost prices on roles for the date defined on estimate lines by searching for the combination of **Role**, **Unit**, and **Organizational Unit** in the cost pricelist to get the correct cost price. 

So that their cost prices can be calculated, all tasks must be assigned to a resource. Any uwnassigned tasks will have a cost price of 0.00.

If the combination of role, unit, and organizational unit doesn’t result in a cost price from the contracting unit’s price list, the system ignores **Unit** and searches for the combination of **Role** and **Organizational Unit**. If it finds a cost price, this price is converted to the unit you picked on the estimate line using the conversion factor.
If the combination of role and organizational unit doesn’t result in a cost price, the system will ignore the **Organizational Unit** and search for the **Role** and **Unit** combination to set the default price after applying any conversion.

If the system does not find a price for the role, then cost price defaults to 0.00 on the estimate line. All cost amounts on the project cost estimate lines are recorded in the currency of the contracting unit. By default, Dynamics 365 stores cost amounts in your base currency, but the cost amounts shown on the **Estimates** tab are in the currency of the contracting unit. 

### Sales price defaulting

The sales pricelist is based on the sales entity the project is attached to or the project customer. When a sales entity, such as opportunity, quote, or contract is associated to the project, the sales entity’s sales price is determined by the pricelist associated to the quote or contract. If the quote or contract has a custom pricelist, this is the default sales pricelist for project estimates. If there is no association to the sales entities, the default sales pricelist from the parameters is the project’s default sales pricelist and it matched to the customer’s currency as defined on the project.

Each estimate line has a resourcing unit associated to it that indicates the organizational unit from which the resources are booked for completing the task. You can determine the sales price for the associated roles by searching for the combination of **Role**, **Unit**, and **Resourcing Unit** in the sales price list. If there are no assignments on the task, the sales price for the task is 0.00.

If the combination of role, unit, and resourcing unit doesn’t result in a sales price from the sales price list, the system ignores **Unit** and searches for the combination of **Role** and **Resourcing Unit**. If a sales price is found, it is converted to the unit picked by the user on the sales estimate line using the conversion factor. 
If the combination of role and resourcing unit doesn’t result in a sales price from the sales price list, the system drops **Resourcing Unit** and searches for the **Role** and **Unit** combination for the default price after applying any conversion.

If the system doesn’t find a price for the role, then sales price defaults to 0.00 in the estimate line.

The **Estimates** tab has a grid view that displays estimate lines with **Unit**, **Total Cost Price**, and **Total Sales Price** as shown in the following graphic. 

> ![Screenshot of Estimates tab grid view](media/project-6.png)

## Time-phased view of project estimates

In the Time-phased view for project estimates, the estimates data from the grid view is pivoted by default on the **Role** dimension and shows estimate data across the timeline in the chosen timescale.

> ![Time-phased view for project estimates](media/project-7.png)

## Effort estimate allocation based on task mode

In the Time-phased view, you distribute total effort estimated for the task by allocating effort hours per unit time period on the chosen timescale. The task mode determines how effort is allocated across the duration of the task. The two kinds of allocation are **Even** and **Work hours-based**.

### Work hours-based allocation
 
Auto-scheduling task mode sets the daily default hours for task resources at the full work-hours rate. This applies when effort is allocated by splitting it across the duration of task in the Time-phased view. For example, if you estimate that a task will be completed by one resource on a **Day** timescale, the effort allocated per day won’t exceed work hours per day as defined in the project’s calendar. Therefore, the effort allocation always ensures that the resources are estimated to be utilized for the full day.

## Even allocation

Manually scheduled task mode bases the task schedule on user input. The work hours from the project calendar are not honored. For these tasks, the effort allocation per unit time period of the chosen timescale does not have any limiting factor. The total effort on the task is equally split and allocated for each unit time period on the chosen timescale. Therefore, the task mode defined on the task determines the effort distribution or allocation of effort per unit time period in time-phased estimates.

## Grouping and time-phasing options

This view shows the distribution of the effort, cost, and sales estimates on a per day, week, month, or year basis. You can use the **Group By** option to pivot the estimates data on two other dimensions: **Category** and **Resource**. On the grid view and Time-phased view, you can choose which fields are displayed. Totals for each time block are displayed at the bottom of the project showing the total estimated effort, cost, and sales for the day, week, month, or year. The defaults for cost and sales price are date-effective, meaning they change for each resource based on the Time-phased view that you select.

## Expense estimates

The **Add Expense Estimate** in the grid view lets you record any expenses incurred in the project that aren’t directly related to labor. You can record the expense estimates for a specific task or for the entire project. Choose expense categories and a tentative date when the expense is expected to be incurred. If the associated cost and sales pricelist have default prices (or markup percentages are defined for expense categories), they default on the estimate line on association.
