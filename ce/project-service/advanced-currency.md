---
title: Multiple-currency scenarios (version 3.x)
description: This topic provides information about multiple-currency scenarios.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 12/26/2018
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

# Multiple-currency scenarios

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Microsoft Dynamics 365 has two concepts of currencies:

- **Transaction currency** - The currency that a transaction occurs in. 
- **Base currency** - The currency of the Dynamics 365 instance. This currency is set up when a Dynamics 365 instance is provisioned. It can’t be changed.

For example, Contoso US sold 100 t-shirts to a customer in the UK for 15 ounds sterling (GBP) each. The following table shows how this transaction is recorded in the Order Product entity.

| Product | Quantity | Price per unit | Currency | Amount | Exchange rate | Price per unit (Base)| Amount (Base)|
|---------|----------|----------------|----------|--------|---------------|----------------------|--------------|
| T-shirt | 100      | 15             | GBP      | 1500   | 0.94          | $17.25               | $1,725       |

The **Currency** column shows the transaction currency, which is the currency that the sale occurred in. The **Exchange rate** column is the exchange rate between the transaction currency and the base currency. The base currency is US dollar (USD). This base currency was set up when the Dynamics 365 instance was provisioned.
As the table shows, every transaction is recorded in both the transaction currency and the base currency. Dynamics 365 uses the currency exchange rate to calculate the base currency amounts.

## Project Service Automation extensions

Dynamics 365 Project Service Automation influences the transaction currency, because business transactions usually have two aspects: cost and sales.

The following entities are considered business transactions:

- Quote line detail
- Project contract line detail
- Estimate line
- Journal line
- Invoice line detail
- Actual

In each of these entities, there is a record that represents the cost amount or the sales amount. As for any Dynamics 365 entity that has an **Amount** field, each record includes amounts in both the transaction currency and the base currency. 

PSA expands the concept of transaction currency for the cost and sales in the following ways:

- The cost transaction currency for time transactions always comes from the currency of the organization unit that owns or manages the project. This organization unit is known as the contracting unit.
- The sales transaction currency for time and expense transactions always comes from the currency of the project contract.
- The cost transaction currency for expenses comes from the currency that the expense entry was created in.

## Multiple-currency scenario

This section describes an example of a project that Contoso UK delivers for a customer that is named Fabrikam, Japan. Here is how the scenario has been set up:

1. GBP and Japanese yen (JPY) are set up under **Settings** \> **Business Management** \> **Currencies**. 
2. A customer account that is named **Fabrikam - Japan** is set up, and JPY is selected as the currency on the account.
3. An organization unit that is named **Contoso UK** is set up, and GBP is selected as the currency.
4. A project contract is created, where **Contoso UK** is specified as the contracting unit and **Fabrikam – Japan** is specified as the customer.
5. Project contract lines are created, based on the billing arrangements for the various transaction classes on the project, such as billing for time versus billing for expenses.
6. A project is created where **Contoso UK** is specified as the contracting unit. This project is created and mapped to the project contract lines.


During estimation that uses the quote line detail, the project contract line detail, or on the estimate line of the schedule, two records are always created in the entity. One record is for cost, and the other record is for sales.

- By default, the transaction currency on the cost record is set to the currency of the project’s contracting unit. In this example, the currency is GBP.
- By default, the transaction currency on the sales record is set to the currency of the project contract. In this example, the currency is JPY.

When actuals are created for time using time entry or the journal line, the following behavior occurs:

- By default, the transaction currency on the cost record is set to the currency of the project's contracting unit.
- By default, the transaction currency on the sales record is set to the currency of the project contract.

When actuals are created for expenses by the expense entry or journal line, the following behavior occurs:

- You can record the expense amount in any currency. Select the currency by using the currency picker on the **Expense Entry** page or the **Journal Line** page. By default, the transaction currency for the cost record is set to the currency on the expense entry. 
- By default, the transaction currency for sales record is the currency of the project contract. To set this currency, the system first converts the transaction amount in the currency that the user entered to the base currency. It then converts the amount to the currency of the project contract. 

### Computing roll-ups when project actuals are recorded in multiple transaction currencies

Dynamics 365 automatically handles roll-ups of amounts in different currencies. Here is an example.

| Transaction class | Transaction type| Date   | Resource | Transaction category | Quantity | Unit price | Amount      | Exchange rate | Amount in base |
|-------------------|------------------|--------|----------|----------------------|----------|--------------|-------------|---------------|----------------|
| Time              | Unbilled sales   | 14-Jun | Prakash  |                      | 8 hrs    | 20,000 JPY    | 160,000 JPY | 123           | 1,300.81 USD    |
| Time              | Unbilled sales   | 15-Jun | Prakash  |                      | 8 hrs    | 20,000 JPY    | 160,000 JPY | 123           | 1,300.81 USD    |
| Expense           | Unbilled sales   | 16-Jun | Prakash  | Hotel                | 1 ea     | 250 EUR      | 250 EUR     | 0.94          | 265.95 USD     |
| Expense           | Unbilled sales   | 17-Jun | Prakash  | Car Rental           | 1 ea     | 150 EUR      | 150 EUR     | 0.94          | 159.57 USD     |

To calculate the total unbilled sales value on the project, you can create a roll-up field for the **Amount** field on all the related unbilled sales actuals. The roll-up field is a construct of Dynamics 365 that allows for quick formulas on related records.
