---
title: Understand summaries in Copilot in Dynamics 365 Sales
description: Learn about the default attributes used in the templates to generate summaries in Copilot in Dynamics 365 Sales. 
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: conceptual
ms.collection: 
ms.date: 08/14/2024
ms.custom: bap-template 
---

# Understand summaries in Copilot in Dynamics 365 Sales  

Let's understand the default attributes that are used in the templates to generate summaries in Copilot in Dynamics 365 Sales.

## Opportunity summary

To generate the opportunity summary, Copilot in Dynamics 365 Sales uses the following attributes in each section of the summary. Let's understand the attributes in detail:

### Key value pairs attributes

To generate the key value pairs in the opportunity summary, Copilot uses the following attributes:

| For open opportunity | For closed opportunity |
|----------------------|------------------------|
| `estimatedvalue` | `actualvalue` |
| `estimatedclosedate` | `actualclosedate` |
| `parentcontactid` | `parentcontactid` |
| `parentaccountid` | `parentaccountid` |

Example:

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

Relationship between quote and opportunity tables is established using the `opportunityid` attribute.  
Depending on the `parentcontactid` attribute in the opportunity table, Copilot generates the quote summary as follows:

- When the `parentcontactid` attribute is available, the summary statement is as follows:  
    So far we've shared `totalcount` (total number of quotes) with `parentcontactid` for this opportunity, with the latest one sent on `createdon` (date of the last created quote). This quote for `totalamount` (total amount of last quote) will be valid until `effectiveto` (effective date of last quote).

- When the `parentcontactid` attribute isn't available, the summary statement is as follows:  
    So far we've shared `totalcount` (total number of quotes) for this opportunity, with the latest one sent on `createdon` (date of the last created quote). This quote for `totalamount` (total amount of last quote) will be valid until `effectiveto` (effective date of last quote).

### Product information

Relationship between opportunity product and opportunity tables is established using the `opportunityid` attribute.  
Depending on the number of products associated to the opportunity, Copilot generates the product information summary as follows:

- When only one product is associated to the opportunity, the summary statement is as follows:  
    There is 1 product, `productname` (latest product in the opportunity) in this opportunity with a value of `totalamount` (total amount of the opportunity). The opportunity budget is `budgetamount` (budget amount of the opportunity) but the estimated revenue that can be potentially generated from opportunity is `estimatedvalue` (estimated value of the opportunity).

- When multiple products are associated to the opportunity, the summary statement is as follows:  
    There are `totalCount` (number of products in the opportunity) products in this opportunity with a combined value of `totalamount` (total amount of the opportunity) and the top 2 products by value are `productname` (name of the product with highest value) and `productname` (name of the product with second highest value product). The opportunity budget is `budgetamount` (budget amount of the opportunity) but the estimated revenue that can be potentially generated from opportunity is `estimatedvalue` (estimated value of the opportunity).

### Stakeholder information

Stakeholders information is generated based on the contacts associated to the opportunity. Copilot gets the contact information by getting stakeholders for the opportunity. Copilot checks which stakeholders are common in the other opportunities connected to the same parent account, and these stakeholders are contacts connected to the opportunity by the entity `connection` with role `stakeholder`.

Depending on the number of stakeholders associated to the opportunity, Copilot generates the stakeholders summary as follows:

- When only one stakeholder is associated to the opportunity, the summary statement is as follows:  
    `contact` (name of the contact) is a common stakeholder for `count` (number of opportunities) other opportunity associated with the account.

    Example: **Jim Glynn (sample)** is a common stakeholder for **1** other opportunity associated with the account.

- When two or more stakeholders are associated to the opportunity, the summary statement is as follows:  
    `contact1` and `contact2` (name of the contacts) are common stakeholders for `count` (number of opportunities) associated with the account.

    Example: **Jim Glynn (sample)** and **Paul Cannon (sample)** are common stakeholders for **1** other opportunity associated with the account.

### Account history information

Account history information is generated based on the closed opportunities associated with the account. Copilot gets the account history information by getting the parent account of the opportunity and then getting the closed opportunities associated with this account.

Depending on the closed opportunities associated with the account, Copilot generates the account history summary as follows:

- when an account has closed opportunities, the summary statement is as follows:  
    `parentaccountid`(name of the parent account) has been a customer that has spent over `actualvalue` (sum of all closed opportunities) with us since `createdon` (date of account creation). `parentaccountid`(name of the parent account) operates in the `industrycode` (account's primary industry) industry sector and provides a wide selection of products in its stores and online.

- When an account doesn't have closed opportunities, the summary statement is as follows:  
    `parentaccountid`(name of the parent account) has been a customer with us since `createdon` (date of account creation). `parentaccountid`(name of the parent account) operates in the `industrycode` (account's primary industry) industry sector and provides a wide selection of products in its stores and online.

## Purchase history information

Purchase history information is generated based on the closed opportunities associated with the parent account of the opportunity. Copilot gets the parent account of the opportunity and then gets the closed opportunities associated with this account.

The following statement is generated based on the opportunities associated with the account:  

Our last successful opportunity with `parentaccount` (name of the parent account) for `lastclosedopportunity` (name of the last closed opportunity in the parent account) was worth `actualvalue` (total value of the last closed opportunity). We have successfully closed `count` (number of closed opportunities for the account) with them so far from a total of `count` (number of all opportunities).

## Opportunity stage update

Opportunity stage is updated based on the audit history of the opportunity. Copilot gets the audit history within the last 2 months (top 200 records) for the opportunity.

`userid` (name of the user) updated the opportunity stage from `oldstepname` (name of the previous stage) to `newstepname` (name of the previous stage) on `createdon` (updated date).

## Related information

[Get information from Copilot](copilot-get-information.md)
