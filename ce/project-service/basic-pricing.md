---
title: Pricing 
description: This topic provides information about how pricing works in Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 02/14/2019
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

# Project Pricing 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Dynamics 365 for Project Service Automation (PSA) extends the **Price List** entity in Dynamics 365 for Sales. 

## Key entities

Price list is a rate card with information provided by four different entities:

- **Price List**: This entity stores information about context, currency, date effectivity, and time unit for pricing time. Context shows whether the Price list is expressing cost rates or sales rates. 
- **Currency**: The currency of prices on the price list. 
- **Date**: Used when the system tries to default a price on a transaction. PSA pricing will pick the price list that has date effectivity that includes the date of the transaction. If PSA pricing finds more than one price list that is effective for the transaction date is attached to the related quote, contract, or organizational unit, then no price is defaulted. 
- **Time**: The unit of time that prices are expressed for, such as daily or hourly rates. 

The **Price List** entity has three related tables that store prices. They are:

  - **Role Price**: Stores a rate for a combination of role and organizational unit values. This table is used to set up role-based prices for human resources.
  - **Transaction Category Price**: Stores price by transaction category. This table is used to set up expense category prices.
  - **Price List Items**: Stores prices for catalog products.

> ![Configuring prices with a price list](media/basic-guide-12.png)
 
A rate card is a combination of the **Price List** entity and related rows in the **Role Price**, **Transaction Category Price**, and **Price List Items** tables.

## Resource roles

Resource role refers to a set of skills, competencies, and certifications that a person needs to perform a specific set of tasks on a project.

Human resources time is usually quoted based on the role a resource fills on a specific project. PSA supports costing and billing for human resources time based on resource role. Time can be priced in any unit in the **Time** unit group.

The **Time** unit group, with a default unit of **Hour**, is created when PSA is installed. You can’t delete, rename, or modify the attributes of the **Time** unit group or the **Hour** unit. If you try to delete either, you might cause failures in the PSA business logic. However, you can add other units to the **Time** unit group.

> ![Configuring prices by role](media/basic-guide-13.png)
 
## Transaction categories and expense categories

Travel and other expenses incurred by project consultants are usually billed to the customer. PSA supports pricing expense categories by using price lists. Each price list line for expenses specifies pricing for a specific expense category. 
Airfare, hotel, and car rental are examples of expense categories. For pricing expense categories, PSA supports the following three types of pricing methods:

- **At cost**: The expense cost is billed to the customer without applying any markup.
- **Markup percentage**: The percentage over the actual cost billed to the customer. 
- **Price per unit**: A billing price is set per each unit of the expense category. The amount billed to the customer is calculated based on the number of expense units that the consultant reports. Mileage uses the Price per-unit pricing method. The mileage expense category, for example, can be configured for 30 USD per day or 2 USD per mile. When the consultant reports mileage on the project, the system calculates the amount to bill based on the number of miles reported by the consultant.

> ![Configuring pricing for expense categories](media/basic-guide-14.png)
 
## Project sales pricing and overrides

For project quotes and contracts, a project price list has a different price override pattern than a product price list. On a product catalog–based quote line, you can override the price to roles and categories directly on the quote line because each quote line points to exactly one catalog item. On a project-based quote line, you can't override the price to roles and categories directly on the quote line. To support the two distinct patterns of overriding, a new price list association, the project price list, is introduced with Project Service.

> [!NOTE]
> We recommend that you have a separate price list for your project resources and your catalog items because of the behavior differences between the two when you override pricing.

Each of the following entities may have one or more associated Sales price list for project pricing:

- Customer (account) 
- Opportunity 
- Quote 
- Project Contract

The entities’ association with a price list is indicated by the project price lists. You can associate one or more price lists to the sales entities **Customer**, **Opportunity**, **Quote**, and **Project Contract**.

On a customer record, the project price list is not defaulted. You can manually attach a project price list to the customer record. However, do this only when you have a custom pricing agreement with that customer. PSA validates the following items when a project price list is attached to a sales entity:

- Price list las a context of **Sales** 
- Price list currency matches the customer currency 

On a project contract, PSA uses the following order of precedence to automatically set related project price lists:

1.	Quote
2.	Opportunity
3.	Customer 
4.	Global settings for Project Service

When it defaults to a project price list, PSA ensures that the currency matches the customer’s currency and the sales context of the defaulted price lists.

You can associate multiple project price lists to the entities **Customer**, **Oppertunity**, **Quote**, and **Project contract**. This supports date-specific price defaults for a long-running project contract where you might need more than one price list to account for price updates due to inflation. However, associating price lists of overlapping date effectivity could result in incorrect price defaults. Verify that the project price lists with overlapping date effectivity are not associated with the **Customer**, **Oppertunity**, **Quote**, and **Project contract** entities.

### Deal-specific price overrides

In PSA, you can create deal-specific overrides for selected prices on project price lists that are defaulted on a quote or project contract.

By default, a project contract always gets a copy of the master sales price list instead of direct link to it. This is so that price agreements made with a customer for a Statement of Work (SOW) are not subject to change if the master price list is changed.

On a quote, however, you have the option of using a master price list or creating a copy and editing it to create a custom price list that only applies to this quote. To do this, on the **Quote** page, choose **Create custom pricing** to create a new price list that is specific to the quote. You can access the deal-specific project price list only from the quote. 

When you create a custom project price list, only the project components of the price list are copied. That is, a new price list created as a copy of the existing project price list attached on the quote, and this new price list only has related role prices and transaction category prices.

> ![View and configure custom pricing for a project contract](media/basic-guide-15.png)
  
## Tracking costs

PSA tracks costs for the use of human resource time on projects and other expenses such as travel that are incurred during the project.

As with bill rates, cost rates for human resources are also set up using price lists. The key differences between the cost price and sales price list behavior are:

- The cost rate of a resource can’t be overridden on a specific project, contract, or quote. Bill rates, however can be overridden on a per-deal basis in case of changes specific to the nature of the deal. 
- Cost price list resolution uses the following priority order for resolving a cost price list:
    - Cost price list that is attached to the organizational unit.
    - Cost price list that is attached to the PSA parameters. Since cost price lists in many different currencies can be attached to the parameters, PSA performs a currency match between the currency of the contracting organizational unit of the project, contract, or quote and the currency of the cost price list.
    - For expenses, the at-cost and markup-over-cost pricing methods don’t apply on cost price lists. Even when these pricing methods are used on cost price list lines to set up transaction category costs, the system ignores these, and no cost price is defaulted.
