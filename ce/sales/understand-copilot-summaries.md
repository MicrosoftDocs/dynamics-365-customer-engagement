---
title: Default attributes used in Copilot summaries
description: Learn about the default attributes used to generate summaries in Copilot in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: conceptual
ms.collection: 
ms.date: 09/06/2024
ms.custom: bap-template 
---

# Default attributes used in Copilot summaries  

This article helps you understand the default attributes used to generate summaries in Copilot in Dynamics 365 Sales.

## Opportunity summary

To generate the opportunity summary, Copilot in Dynamics 365 Sales uses the following attributes in each section of the summary. Let's learn about the attributes in detail.

### Key value pairs attributes

To generate the key value pairs in the opportunity summary, Copilot uses the following attributes:

| For open opportunity | For closed opportunity |
|----------------------|------------------------|
| `estimatedvalue` | `actualvalue` |
| `estimatedclosedate` | `actualclosedate` |
| `parentcontactid` | `parentcontactid` |
| `parentaccountid` | `parentaccountid` |

**Example**:

- **For open opportunity**:

    Est. revenue: $10,000.00  
    Est. close date: 9/10/2024  
    Contact: Maria Campbell (sample)  
    Account: Fabrikam, Inc. (sample)

- **For closed opportunity**:

    Actual revenue: $25,000.00  
    Actual close date: 10/11/2024  
    Contact: Jim Glynn (sample)  
    Account: Coho Winery (sample)

### Quote attributes

The relationship between quote and opportunity tables is established using the `opportunityid` attribute.  

Depending on the `parentcontactid` attribute in the opportunity table, Copilot generates the following quote summary:

- When the `parentcontactid` attribute is available, the summary statement is as follows:  

  So far we've shared `totalcount` (total number of quotes) with `parentcontactid` for this opportunity, with the latest one sent on `createdon` (date of the last created quote). This quote for `totalamount` (total amount of last quote) will be valid until `effectiveto` (effective date of last quote).
    
    **Example**: So far we've shared **1** quote with **Maria Campbell (sample)** for this opportunity, with the latest one sent on **8/22/2024 6:42 AM**.

- When the `parentcontactid` attribute isn't available, the summary statement is as follows:  

  So far we've shared `totalcount` (total number of quotes) for this opportunity, with the latest one sent on `createdon` (date of the last created quote). This quote for `totalamount` (total amount of last quote) will be valid until `effectiveto` (effective date of last quote).

    **Example**: So far we've shared **1** quote for this opportunity, with the latest one sent on **8/22/2024 6:42 AM**.

### Product information

The relationship between opportunity product and opportunity tables is established using the `opportunityid` attribute.  

Depending on the number of products associated with the opportunity, Copilot generates the following product information summary:

- When only one product is associated with the opportunity, the summary statement is as follows:  

    There is 1 product, `productname` (latest product in the opportunity), in this opportunity with a value of `totalamount` (total amount of the opportunity). The opportunity budget is `budgetamount` (budget amount of the opportunity) but the estimated revenue that potentially can be generated from the opportunity is `estimatedvalue` (estimated value of the opportunity).

    **Example**: There is 1 product, **Laser printers**, in this opportunity with a value of **$500.00**. The opportunity budget is **$30,000.00** but the estimated revenue that can be potentially generated from the opportunity is **$10,000.00**.

- When multiple products are associated with the opportunity, the summary statement is as follows:  

   There are `totalCount` (number of products in the opportunity) products in this opportunity with a combined value of `totalamount` (total amount of the opportunity) and the top 2 products by value are `productname` (name of the product with the highest value) and `productname` (name of the product with the second highest value). The opportunity budget is `budgetamount` (budget amount of the opportunity) but the estimated revenue that potentially can be generated from the opportunity is `estimatedvalue` (estimated value of the opportunity).

    **Example**: There are **3** products in this opportunity with a combined value of **$3,000.00** and the top 2 products by value are **3D printers** and **Laser printers**. The opportunity budget is **$30,000.00** but the estimated revenue that potentially can be generated from the opportunity is **$10,000.00**.

### Stakeholder information

Stakeholder information is generated based on the contacts associated with the opportunity. Copilot gets the contact information by getting stakeholders for the opportunity. Copilot checks which stakeholders are common in the other opportunities connected to the same parent account, and these stakeholders are contacts connected to the opportunity by the entity `connection` with the role `stakeholder`.

Depending on the number of stakeholders associated with the opportunity, Copilot generates the following stakeholder summary:

- When only one stakeholder is associated with the opportunity, the summary statement is as follows:  

  `contact` (name of the contact) is a common stakeholder for `count` (number of opportunities) other opportunity associated with the account.

    **Example**: **Jim Glynn (sample)** is a common stakeholder for **1** other opportunity associated with the account.

- When two or more stakeholders are associated with the opportunity, the summary statement is as follows:  

  `contact1` and `contact2` (name of the contacts) are common stakeholders for `count` (number of opportunities) other opportunity associated with the account.

    **Example**: **Jim Glynn (sample)** and **Paul Cannon (sample)** are common stakeholders for **1** other opportunity associated with the account.

### Account history information

Account history information is generated based on the closed opportunities associated with the account. Copilot gets the account history information by getting the parent account of the opportunity and then getting the closed opportunities associated with this account.

Depending on the closed opportunities associated with the account, Copilot generates the following account history summary:

- When an account has closed opportunities, the summary statement is as follows:  

    `parentaccountid` (name of the parent account) has been a customer that has spent over `actualvalue` (sum of all closed opportunities) with us since `createdon` (first opportunity closed date with parent account). `parentaccountid` (name of the parent account) operates in the `industrycode` (account's primary industry) industry sector and provides a wide selection of products in its stores and online.

    **Example**: **Fourth Coffee (sample)** has been a customer that has spent over **$22,469.39** with us since **7/20/2024**. **Fourth Coffee (sample)** operates in the **Food and Tobacco Processing** industry sector and provides a wide selection of products in its stores and online.

- When an account doesn't have closed opportunities, the summary statement is as follows:  

   `parentaccountid` (name of the parent account) has been a customer with us since `createdon` (date of account creation). `parentaccountid` (name of the parent account) operates in the `industrycode` (account's primary industry) industry sector and provides a wide selection of products in its stores and online.

    **Example**: **Blue Yonder Airlines (sample)** has been a customer with us since **8/9/2024 9:00 AM**. **Blue Yonder Airlines (sample)** operates in the **Consulting** industry sector and provides a wide selection of products in its stores and online.

### Purchase history information

Purchase history information is generated based on the closed opportunities associated with the parent account of the opportunity. Copilot gets the parent account of the opportunity and then gets the closed opportunities associated with this account.

The following statement is generated based on the opportunities associated with the account:  

Our last successful opportunity with `parentaccount` (name of the parent account) for `lastclosedopportunity` (name of the last closed opportunity in the parent account) was worth `actualvalue` (total value of the last closed opportunity). We have successfully closed `count` (number of closed opportunities for the account) opportunity with them so far from a total of `count` (number of all opportunities).

**Example**: Our last successful opportunity with **Fourth Coffee (sample)** for **10 orders of Product SKU JJ202 (sample)** was worth **88**. We have successfully closed **1** opportunity with them so far from a total of **2**.

### Opportunity stage update

Opportunity stage is updated based on the audit history of the opportunity. Copilot gets the audit history within the last two months (top 200 records) for the opportunity.

`userid` (name of the user) updated the opportunity stage from `oldstepname` (name of the previous stage) to `newstepname` (name of the new stage) on `createdon` (updated date).

**Example**: **Kenny Smith** updated the opportunity stage from **3-Propose** to **2-Develop** on **8/22/2024 6:57 AM**.

## Related information

[Get information from Copilot](copilot-get-information.md)
