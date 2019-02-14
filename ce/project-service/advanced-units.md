---
title: Unit groups and units 
description: This topic provides information about unit groups and units.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/14/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Unit groups and units

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Unit groups and units are basic entities in Microsoft Dynamics 365. A unit is a single unit of measure, and multiple units can be classified into unit groups. A unit group is sometimes called a unit schedule in the Dynamics 365 user interface. 

The following list includes examples of units and unit groups:
 
- **Unit group**: Distance 
	- **Units**: Miles, kilometers, etc.
- **Unit group**: Time
	- **Units**: Hour, day, week, etc. 

When you set up multiple units in a unit group, you must also set up a conversion factor between the units by designating the first unit you set up as the default or primary unit for the unit group.

For example, in a **Time** unit group, if you set **Hour** as the first unit, the system designates **Hour** as the default unit. If the next unit you set up is **Day**, you will need to set up a conversion factor for **Day** to **Hour**. If you then added a third unit of **Week**, you would set the conversion factor for **Week** in terms of **Day** or **Hour**.

The following graphic shows an example setup for **Day**, where the **Quantity** field represents how many hours are in a day and **Week** where the **Quantity** field show the number of days in week.

> [!div class="mx-imgBorder"] 
> ![Estimates tab](media/advanced-2.png)

## Using units and unit groups

Project Service uses units and unit groups for processing estimates and entries both time and expense. 

For Expenses, each expense category has a default unit group and unit. These values are defaulted on price list entries for expense categories.

For example, you might have an expense category called **Mileage** that is set up with a unit group called **Distance** and a default unit called **Mile**. If you set up the distance unit group with two units (mile and kilometer), you can set two prices for the **Mileage** category in one price list (miles and kilometers).

| Expense category  | Unit group  | Unit      | Pricing method  | Price per unit  |
|-------------------|---------------|-----------|-------------------|-------------------|
| Mileage           | Distance      | Mile      | Price per unit    | 10 USD            |
| Mileage           | Distance      | Kilometer | Price per unit    |  6 USD            |

When you enter an expense on a project, the system determines the price through the combination of category and unit on the expense. 

| Expense description        | Expense category  | Unit  | Quantity  | Unit price   |
|----------------------------|---------------------|-------|-----------|----------------|
| Drive to client location | Mileage             | Mile  | 10        | 10 USD         |

For Time, each price list header has a **Default Time Unit** field. The value is set when you create the **Price list** header. This unit is then used to set all role-based prices on that price list.
Estimate lines for the **Time on Quote** field can be expressed in any unit of time. However, estimate lines on projects and time entries for projects can only use the **Hour** unit of time. If the unit on the time entry/estimate line does not match the unit on the price list line for that role, the system converts the price into the units defined in the project estimate or the project actuals transaction. 
The following example explains how Project Service uses the unit group, units, and conversion factors.
- Units
	- **Unit group**: Time 
	- **Units**: Hour 
		- **Day** - Conversion factor: 8 hours       
		- **Week** - Conversion factor: 40 hours  
- Price list setup on Project A:
	- **Name**: UK sales prices 2016 
	- **Default time unit**: Day 
	- **Currency**: GBP

| Role      | Unit group | Unit | Organizational unit | Price   |
|-----------|------------|------|---------------------|---------|
| Developer | Time       | Day  | Contoso UK          | 800 GBP |

### Time entry

The following table shows the resulting sales side transaction created by PSA for a three hour project.


| Project   | Task    | Role      | Quantity | Unit  | Unit price | Unbilled sales amount |
|-----------|---------|-----------|----------|-------|------------|-----------------------|
| Project A | Design  | Developer | 3        | Hour  | 100 GBP    | 300 GBP               |

## Time unit FAQs

### Does Project Service convert to different units in the case of expenses?

No. Unit conversion only works for time. For expenses, when the system is not able to find a price for the expense category and unit combination, the price is defaulted to 0.00.

### Why does Project Service convert time units?

In some countries, setting up bill rates in days is legally required. Price negotiation and discounting during the quote cycle is done using day rates for each billable role. Schedule estimation and time entry are done in hours. To support this difference in time units, The Project Service app converts time units.

### Can time units be changed on project estimates?

No. Schedule estimation is currently restricted to hours and can’t be changed.

### Can units and unit groups be modified, deleted, and added?

Yes. With exception of the unit group **Time** and the unit **Hour**, all other units can be deleted or modified, and new units can be added. Deleting the unit group **Time** and unit **Hour** is not supported in Project Service. However, **Time** and **Hour** can be updated with a translated text for the **Name** field.
