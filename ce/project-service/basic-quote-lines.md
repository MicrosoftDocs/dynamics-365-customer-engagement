---
title: Quotes and quote lines 
description: This topic provides information about quotes and quote lines in Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 02/13/2019
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

# Quotes and quote lines

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In Dynamics 365 for Project Service Automation (PSA), there are two types of quotes, project and sales. While key differences are provided in the following list, this topic will focus on the details of project quotes. The key differences between a sales quote and a project quote in PSA include:

- On a sales quote, there is only one grid for line items. On a project quote, you’ll see two grids for line items: project lines and product lines.
- A sales quote supports activation and revisions. A project quote doesn’t support those processes.
- You can attach multiple orders to a sales quote whereas you can only attach one project contract to a project quote.
- You can win a sales quote and keep the related opportunity open. After a project quote is won, the related opportunity is closed.
- A project quote has fields and concepts that are not on the sales quote. These include, **Contracting Unit**, **Account Manager** and **Bill to Contact Name**. 
- The project quote is also identified by an option-set based field called **Type** which has the value **Work-based** whereas the **Type** field on a sales quote has the value **Item-based**.


A project quote in PSA can have multiple line items or quote lines. In fact, a project quote has two grids for line items. One grid is for project-based lines that allow for detailed estimations and the other is for product-based lines that follow a simple unit price and quantity-based approach.

- **Project-based**: The amount (quoted value) is determined after you’ve estimated how much work is needed. You can estimate work at a high level, directly as line details below each quote line, or based on ground-up estimates using a project and project plan. These types of lines are only found in project-based quotes created using PSA. This type of quote line is a customized form of write-in quote lines which are available in Microsoft Dynamics 365 for Sales. 
- **Product-based**: The amount (quoted value) is determined based on the quantity of units sold and the unit sales price of the product. The product on these lines can come from a product catalog in Dynamics 365 for Sales or it can be a product you define. These quote lines are also available on project-based quotes that are created using PSA.

The amount on the quote is the total across the product-based lines and the project-based lines.

> [!NOTE]
> Quotes and quote lines are not required in PSA. You can start the project process with a project contract (sold project). However, whether you start with a quote or a project contract, an opportunity is required.

## Project-based quote line

A project-based quote line in PSA has the following billing methods:

- Time and material
- Fixed price

### Time and material

This billing method is based on consumption. When you select this, the customer is invoiced as the project incurs costs. Invoices are created on a date-based periodic frequency. During the sales process, the quoted value of a time and material component provides only an estimation of the final cost to the customer. There is no commitment from the vendor that the project is completed at exactly that quoted value. Time and material components increase the customer’s risk. Your customer may want to negotiate additional not-to-exceed clauses to minimize this risk. PSA does not support setting not-to-exceed clauses.

### Fixed price

In this billing method, a vendor commits to delivering the project at a fixed cost to the customer. The customer is billed the quoted value of the fixed price quote line, regardless of the costs incurred by the vendor for delivering this quote line. The fixed price quote line value is billed in one of the following ways: 

- A lump-sum amount at the start or finish of the project, or when a milestone on the project is reached. 
- A date-based frequency of equal installments of the fixed value on the quote line. These are called periodic milestones. 
- Installments that have a monetary value that aligns with the progress of work or specific milestones achieved on the project. In this case, the value of each installment can be different, but they must all add up to the fixed value on the quote line. 

Project Service supports all three types of invoice schedules for a fixed price quote line.

## Transaction classification

Professional service organizations typically quote and invoice their customers by classification of costs. These are represented in PSA as the following transaction classifications:

- **Time**: Represents the cost of labor or human resources’ time on a project. 
- **Expense**: Represents all other kinds of expenses on a project. Because expense can be broadly classified, most organizations create sub-categories, such as travel, car rental, hotel, office supplies, etc. 
- **Fee**: Represents miscellaneous overhead, penalties, and other items that are charged to the customer. 
- **Tax**: Records tax amounts that the user adds while entering expenses. 
- **Material transaction**: Records actuals from product lines on a confirmed project-invoice. 
- **Milestone**: Used by the fixed price billing logic in PSA.

One or more of these transaction classifications can be associated to a quote line. After a quote is won, the mapping between transaction class and quote line is transferred to the contract line. 
 
> ![Screenshot of mapping transaction types to quote and contract lines](media/basic-guide-5.png)
  
For example, a quote might contain the following two quote lines: 
- Consulting work that has a time and material billing method where time and fee transaction classifications are applicable. This means that all time and fee transactions for the example project **Dynamics AX Implementation** are invoiced to the customer based on time and materials used. 
- Related travel expenses that have a fixed price billing method. For example, this could mean that all travel expenses for the example project **Dynamics AX Implementation** are invoiced for a fixed monetary value.

> [!NOTE]
> The combination of the project and transaction classes of time, expense, and fee that are associated with a quote line or contract line must be unique. If the same association of project and transaction class is used on more than one contract line or quote line, PSA won’t work correctly.

## Billing types

The **Billing Type** field defines the concept of chargeability in Project Service and is an option set with the following possible values:

- **Chargeable**: The cost accrued by this role/category is a direct cost that drives project execution and indicates that the customer will pay for this work. The payment can be administered as a time and material or fixed price arrangement, however the employee that spends the time will receive the corresponding credit for their billable utilization.
- **Non-chargeable**: The cost accrued by this role/category is considered a direct cost that dirve project execution although the customer does not recognize this and will not pay for this work. The employee that spends this time isn't credited with billable utilization for this time.
- **Complimentary**: The cost accured by this role/category is considered a direct cost that drives project execution and the customer recognizes this. The employee that spends this time is credited for billable utilization for this time. However, this cost isn't charged to the customer. 
- **Not available**: The costs that are incurred on internal projects that don't need revenue tracking are tracked with this.

## Invoice schedule

An invoice schedule is a series of dates on which invoicing for a project occurs. Creating an invoice schedule is an optional step on a quote line in PSA. Each quote line can specify its own invoice schedule. To create an invoice schedule, you must provide the following attribute values:

- A billing start date 
- A delivery date that will represent the billing end date on the project
- An invoice frequency

PSA uses these three attribute values to generate a tentative set of dates on which to establish invoicing.

## Invoice frequency

**Invoice frequency** is an entity that stores the attribute values which help express the frequency of invoice creation. The following attributes express or define the **Invoice frequency** entity:

- **Period**: Supported values are monthly, biweekly, and weekly. 
- **Runs per period**: For weekly and biweekly periods, you may define only one run per period. For a monthly period, you may define between one and four runs per period. 
- **Days of run**: Days on which invoicing should run. You can configure this in two different ways: 
  - **Weekdays**: For example, every Monday or every second Monday. Customers required to set invoicing to run on a working day prefer this configuration. 
  - **Calendar days**: For example, the 7th and the 21st day of every month. Some organizations prefer this kind of configuration because it ensures that invoicing runs on a fixed schedule every month.
  
### Invoice schedule for a fixed price quote line

For a fixed price quote line, you can use the **Invoice Schedule** grid to create billing milestones that equal the value of the quote line. 

- To create billing milestones that are equally divided, select an invoice frequency, enter the billing start on the quote line, and choose **Requested Completion Date** for the quote in the **Summary** section of the quote header. Then choose **Generate Periodic Milestones** to create equally-split milestones based on the invoice frequency chosen. 
- To create a lump-sum billing milestone, create a milestone, and then enter the quote line value as the milestone amount. 
- To create billing milestones based on specific tasks in the project plan, create a milestone and map it to the project’s schedule element in the billing milestone UI.
