---
title: Identify your organization’s pricing dimension needs (Dynamics 365 for Project Service) | MicrosoftDocs
description: How to think about your pricing needs
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/06/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
    - D365PS
---

# Understand your Organization's strategy for pricing human resource time

Identify how your organization would like to setup bill rates and cost rates for human resource time. To do this, it helps to discuss with finance teams and practice heads. How project organizations price for human resource time is often an important strategic consideration that directly affects the profitability of the project organization. Also, given the importance of this decision, it also helps to revisit this once every 2-3 years to see if your pricing strategy is giving you adequate results.

A common example: Bill rates are setup based on the Role and the Resourcing Organizational Unit to which the resource belongs. Cost rates typically depend on the Salary band of the employee and the Org Unit that they belong to. In such a setup, your bill rate and cost rate tables will look like the below:

**Sample bill rates**

| Role        | Org Unit    |Unit      |Price      |Currency  |
| ------------|-------------|----------|----------:|----------|
| Developer   | Contoso US  |Hour | 200|USD     |
| Developer   | Contoso India |Hour|   112|USD     |


**Sample cost rates**

| Salary Band     | Org Unit    |Unit      |Price      |Currency  |
| ----------------|-------------|----------|----------:|----------|
| My company_Band1 | Contoso US  |Hour | 145|USD     |
| My company_Band2 | Contoso India |Hour|   67|USD     |



One important option to consider at this early stage is the re-use of a field or entity in the out-of-the-box Project Service app that is currently not a pricing dimension but applies as a pricing dimension for your organization. Fields like Transaction Category (msdyn_transactioncategory) Bookable Resource (bookableresource) are a couple of examples of candidate dimensions.

Another important consideration is whether your pricing dimension should be a table or an option set. If you foresee changes to the values of a dimension and they exceed 10 or 12 in number and you need additional attributes on these values, it is safe to consider creating an entity rather than an option set. Also to consider is the fact that Option set maintenance ie adding or removing values in an option set is an Admin/Developer Experience whereas adding new rows to a table can be done by end users easily.
