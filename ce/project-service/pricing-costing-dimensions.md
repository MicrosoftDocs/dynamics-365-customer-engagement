---
title: Pricing and costing dimensions home page
description: This topic provides an overview of pricing dimensions.
author: rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 11/19/2018
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
  - ProjectOperations
---

# Pricing and costing dimensions home page

The dimensions used for setting labor pricing and costing in project-based organizations are influenced by the attributes of:

- People doing the work like thier experience, role, geography etc
- Work to be performed like its complexity, time of day, etc.

Given the typical nature of these attrubutes of the work and the people required to perform the work, there are two types of pricing dimension values available in Project Service Automation (PSA): 

- **Option sets** - Attributes that are fixed enumerations for a set of values.
- **Entity-based values** - Attributes that can have a varied set of values that are finite but can change over time.

## Pricing dimensions

PSA ships with a default set of pricing dimensions. You can view these by going to **Project Service** > **Parameters**. In the parameter record, on the **Amount-based pricing dimensions** tab, verify that the role, **msdyn_resourcecategory** and resourcing organizational unit, **msdyn_organizationalunit** have the fields **Applicable to sales** and **Applicable to cost** set to **Yes**. 
This will allow you to set up the price and cost for each role and organizational unit combination.

![Screenshot of Project Service parameters with “Applicable to Sales” highlighted](media/PS-OOB-parameters.png)

> [!IMPORTANT]
> If you have been the using out-of-the box fields of role and organizational unit as pricing dimensions prior to version 3 of PSA, there will not be any observable change. You can continue to use Project Service as usual. 

If you need to price or cost for your resources using additional attributes, you can create customized fields, entities, and dimensions. For more information, see the following topics, however note that you must complete the procedures in the order listed below:

- [Create custom fields and entities](create-custom-fields-entities.md)
- [Add custom fields to price setup and transactional entities](field-references.md)
- [Set up custom fields as pricing dimensions](set-up-pricing-dimensions.md)
- [Update plug-in attributes to include new pricing dimensions](update-plug-in-attributes.md)

## Pricing human resource time
How an organization prices human resource time is often an important strategic consideration that directly affects the organization's profitability. Work with the finance teams and practice heads when your organization is ready to identify how it wants to set up bill and cost rates for human resource time.

Other considerations for pricing include whether to re-use fields or entities that are not currently pricing dimensions but apply as a pricing dimension for your organization. Fields like **Transaction Category** (**msdyn_transactioncategory**) and **Bookable Resource** (**bookableresource**) are examples of candidate dimensions. 

You should also consider whether your pricing dimension should be a table or an option set. If you foresee changes to the values of a dimension which will exceed 10 or 12 and you need additional attributes on these values, you could create an entity rather than an option set. Maintaining an option set, such as adding or removing values, requires an admin or developer whereas adding new rows to a table can be done by most business users.

The following example shows bill rates that are set up based on the role and the resourcing org unit to which the resource belongs. Cost rates are typically based on the salary band of the employee and the org unit that they belong to. In this example, the bill rate and cost rate tables will look like the following.

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
