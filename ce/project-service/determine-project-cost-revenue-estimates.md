---
title: Determine project cost and revenue estimates
description: How to determine project cost and revenue estimates in Project Service
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
# Determine project cost and revenue estimates 

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Project estimates provide the financial view for the work estimated and scheduled in the project’s work breakdown structure. The estimates view informs you of the cost and revenue impact of the planned work. The estimates view provides a tool to see the information on a number of pre-defined dimensions to best inform you of the financial impact of the project.  
  
## Cost and sales value of the project  
[!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] price lists define the cost and bill rates for roles projects use. Based on the roles associated with the tasks in the project’s work breakdown structure, you can determine the cost and revenue impact of the work involved.  
  
## Cost price defaulting  
Every project belongs to an organization (indicated in **Owning Unit** in the project). The price list associated with the owning organizational unit determines the unit cost price. The [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)] determine cost prices for roles by searching for the combination of role, unit, and organizational unit in the cost price list to get the correct cost price for the date effective on estimate lines.  
  
If the combination of role, unit. and organizational unit doesn’t result in a cost price from the owning unit’s price list, the unit is disregarded in favor of the combination of role and organizational unit. If there is a cost price, this price is converted to the unit you chose on the estimate line.  
  
If the combination of role and organizational unit doesn’t result in a cost price, the organizational unit is disregarded in favor of the role and unit combination, and the price is defaulted after applying any conversion, if required.  
  
 If there isn’t a price for the role, then the cost price defaults to 0.00 on the estimate line.  
  
 All cost amounts on project cost estimate lines are in the currency of the owning organizational unit.  
  
## Sales price defaulting  
The sales price list is based on the sales entity that the project is attached to. The sales price list associated with the quote or contract determines the unit sales price. If the quote or contract has a custom price list, this will be the default sales price list for project estimates. If there is no association to the sales entities, then the default sales price list configured in parameters settings will be the default sales price list for the project. Each estimate line has a resource organizational unit associated to indicate the organizational unit from which the resources will be booked for completing the task. The sales price for the associated roles is determined by searching for the combination of role, unit, and resource organizational unit in the sales price list to get the correct sales price for the date effective on the estimate lines.  
  
If the combination of role, unit, and resource organizational unit doesn’t result in a sales price from the sales price list, the system will disregard unit and search for the combination of role and resource organizational unit. If a sales price is found, this will be converted to the unit you chose on the sales estimate line.  
  
If the system doesn’t find a price for the role, then the sales price must default to 0.00 on the estimate line.  
  
The estimates view has a grid view that displays a flat grid of estimate lines with unit and total cost and sales price.  
  
## Time-phased view of project estimates  
In the time-phased view for project estimates, the estimates data from the grid view is pivoted by default by role, and shows a spread of estimate data across the timeline in the chosen timescale.  
  
## Effort estimate allocation based on task mode  
In the time-phased view, total effort estimated for the task is distributed by allocating a certain number of effort hours per unit time period of the chosen timescale. In project service, the task mode determines how effort is allocated across the duration of the task. The two kinds of allocation are even allocation and work hours based allocation  
  
## Work hours based allocation  
Auto scheduling task mode for a task governs that for the number of resources estimated on the task, they are estimated to be utilized for the full work hours per day. This applies when allocating the effort by splitting it across the duration of tasks in the time phased view as well. For instance, on a ‘Day’ timescale, for a task estimated to be completed by one resource, the effort allocated per day will not exceed work hours per day defined in the project’s calendar. Therefore, the effort allocation always ensures that the resources are estimated to be utilized for the full day.  
  
## Even distribution  
Manually scheduled task mode doesn't honor the work hours, project calendar, or number of resources defined on the task. The task schedule is based on user input. For such tasks, the effort allocation per unit time period of the chosen timescale doesn't have any limiting factors. The total effort on the task is equally split and allocated for each unit time period on the chosen timescale.  
  
In this way, the task mode defined on the task determines the effort distribution or allocation of effort per unit time period in time-phased estimates.  
  
## Grouping and time-phasing options  
This view helps you understand the distribution of the effort, cost, and sales estimates on a per day, week, month, or year basis. The Group By option allows pivoting the estimates data on two other dimensions: category and resource. On both the grid view and the time-phased view you can choose the fields to be displayed. Totals for each of the time blocks is displayed at the bottom indicating the total estimated effort, cost. and sales for the day, week, month, or year.  
  
The cost and sales price defaulting takes is date effective—when the rates for the roles change it will be more transparent in the time-phased view when viewing estimate data pivoted on ‘Resource’ and time-phased by week.  
  
## Expense estimates  
Any expense that will be incurred in the project that is notdirectly related to labor to be expended can be recorded in the project estimates in the grid view. Using the **Add expense estimate** option in the grid view, you can accomplish this. The expense estimates can be recorded for a specific task or for the entire project;you can choose expense categories on these lines and choose a tentative date when the expense is expected to be incurred. If the associated cost and sales price list have default prices, or markup percentages defined for expense categories, it will be defaulted on the estimate line on association.  
  
### See Also  
 [Project Manager Guide](../project-service/project-manager-guide.md)
