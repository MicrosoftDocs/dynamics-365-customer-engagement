---

title: Pricing and costing dimensions 
description: This topic provides an overview of pricing dimensions.
author: rumant
manager: eichimur
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
---

# Pricing and costing dimensions 

The dimensions that are used to price and cost human resources fall into two categories:

- People
- Planned work

Because of this, there are two types of pricing dimension values available in Project Service Automation (PSA): 

- **Option sets** - Dimensions that are fixed enumerations of a set of values.
- **Entity-based values** - Dimensions that can be a varied set of values.

## Default pricing dimensions

PSA ships with a default set of pricing dimensions. You can view these by going to **Project Service** > **Parameters**. In the parameter record, on the **Amount-based pricing dimensions** tab, verify that the role, **msdyn_resourcecategory** and resourcing organizational unit, **msdyn_organizationalunit** have the fields **Applicable to sales** and **Applicable to cost** set to **Yes**. 
This will allow you to set up the price and cost for each role and organizational unit combination.

![Screenshot of Project Service parameters with “Applicable to Sales” highlighted](media/PS-OOB-parameters.png)

> [!IMPORTANT]
> If you have been using out-of-the box fields of role and organizational unit as pricing dimensions prior to version 3 of PSA, there will not be any observable change. They can continue to use Project Service as usual. If, however, you see the need to price or cost for your resources using additional attributes, you can create customized dimensions. For more information, see [Create custom fields and entities](create-custom-fields-entities.md).


## Pricing human resource time
How an organization prices human resource time is often an important strategic consideration that directly affects the prganization's profitability. Work with the finance teams and practice heads when your organization is ready to identify how it wants to set up bill and cost rates for human resource time.

Other considerations for pricing include whether to re-use fields or entities that are not currently pricing dimensions but apply as a pricing dimension for your organization. Fields like **Transaction Category** (**msdyn_transactioncategory**) and **Bookable Resource** (**bookableresource**) are examples of candidate dimensions.

You should also consider whether your pricing dimension should be a table or an option set. If you foresee changes to the values of a dimension and they exceed 10 or 12 in number and you need additional attributes on these values, you could create an entity rather than an option set. Maintaining an option set, such as adding or removing values, requires an admin or developer whereas adding new rows to a table can be done by most users.

The following example shows bill rates that are set up based on the role and the resourcing org unit to which the resource belongs. Cost rates are typically based on the salary band of the employee and the org unit that they belong to. In this example, the bill rate and cost rate tables will look like the below:

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

