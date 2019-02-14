---
title: Multi-currency scenarios (version 3.x)
description: This topic provides information about multi-currency scenarios.
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

# Multi-currency scenarios

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Microsoft Dynamics 365 has two concepts of currencies:

- **Transaction currency**: The currency in which a transaction occurs. 
- **Base currency**: The currency of the Dynamics 365 instance. This is set up when a Dynamics 365 instance is provisioned and can’t be changed.

For example:

Contoso US sold 100 t-shirts to customer in the UK for 15 GBP each. This is recorded in the **Order Product** entity as shown in the following table.

| Product | Quantity | Price per Unit | Currency | Amount | Exchange Rate | Price per Unit (Base)| Amount (Base)|
|---------|----------|----------------|----------|--------|---------------|----------------------|--------------|
| T-shirt | 100      | 15             | GBP      | 1500   | 0.94          | $17.25               | $1,725       |

The **Currency** column lists the transaction currency, which is the currency in which the sale happened. The **Exchange Rate** column is the exchange rate between the transaction currency and the base currency. USD is the base currency, which was decided when the Dynamics 365 instance was provisioned.
As shown in the table, every transaction is recorded in the transaction currency as well as the base currency. Dynamics 365 uses the currency exchange rate to calculate the base currency amounts.

## Project Service extensions

Project Service influences the transaction currency as business transactions usually have two aspects, cost and sales.

The following entities are considered business transactions:

- Quote line detail
- Project contract line detail
- Estimate line
- Journal line
- Invoice line detail
- Actual

In each of these entities, there is a record that represents the cost amount or the sales amount. As is the case with any Dynamics 365 entity with an amount field, each record includes amounts in the transaction currency and in the base currency. 

Project Service adds to the Transaction currency concept for cost and sales in the following ways:

- The cost transaction currency for time transactions always comes from the currency of the Organization Unit that owns or manages the project. This called the Contracting Unit.
- The sales transaction currency for time and expense transactions always comes from the currency of the Project Contract.
- The cost transaction currency for expenses comes from the currency that the expense entry was created in.

## Multiple currency scenarios

The following is an example of a project delivered by Contoso UK for the customer Fabrikam, Japan. The scenario has been set up as follows:

1. GBP and Japanese Yen are set up under **Settings88** > **Business Management** > **Currencies**. 
2. Next, the customer account is set up for **Fabrikam-Japan** with **Japanese Yen** selected as the currency on the account.
3. An organization unit called **Contoso UK** is set up with **GBP** as the currency.
4. Then a project contract is created with **Contoso UK** as the contracting unit and **Fabrikam – Japan** as the customer.
5. Project contract lines are created based on the billing arrangements for the various transaction classes on the project, such as billing for time vs. billing for expenses.
6. A project with **Contoso UK** as the contracting unit is created and mapped to the project contract lines.


During estimation using the quote line detail, the project contract line detail, or on the estimate line of the schedule, there are always two records created in the entity, one for cost and one for sales.

- The transaction currency on the cost record defaults to the project’s contracting unit currency, which in this case is GBP.
- The transaction currency on the sales record defaults to the project contract’s currency, which in this case is Japanese Yen.

When actuals are created for time using time entry or the journal line:

- The transaction currency on the cost record defaults to the project’s contracting unit currency.
- The transaction currency on the sales record defaults to the project contract’s currency.

When actuals are created for expenses using the expense entry or journal line:

- You can select to record the expense amount in any currency using the currency picker on the **Expense Entry** page or the **Journal Line** page. The transaction currency for the cost record defaults to the currency on the expense entry. 
- The transaction currency for sales record always defaults to the to the project contract’s currency. This is done by converting the transaction amount in the currency, entered by user into base currency, and then converting it into the project contract currency.

### Computing roll-ups when project actuals are recorded in multiple transaction currencies

Roll-ups of amounts in different currencies are automatically handled by Dynamics 365. For example:

| Transaction Class | Transaction Type| Date   | Resource | Transaction Category | Quantity | Unit   Price | Amount      | Exchange rate | Amount in Base |
|-------------------|-----------------|--------|----------|----------------------|----------|--------------|-------------|---------------|----------------|
| Time              | Unbilled sales  | 14-Jun | Prakash  |                      | 8 hrs    | 20000 JPY    | 160,000 JPY | 123           | 1300.81 USD    |
| Time              | Unbilled sales  | 15-Jun | Prakash  |                      | 8 hrs    | 20000 JPY    | 160,000 JPY | 123           | 1300.81 USD    |
| Expense           | Unbilled sales  | 16-Jun | Prakash  | Hotel                | 1 ea     | 250 EUR      | 250 EUR     | 0.94          | 265.95 USD     |
| Expense           | Unbilled sales  | 17-Jun | Prakash  | Car Rental           | 1 ea     | 150 EUR      | 150 EUR     | 0.94          | 159.57 USD     |

To calculate the total unbilled sales value on the project, you can create a roll-up field for the **Amount** field on all of the related unbilled sales actuals. The roll-up field is a Dynamics 365 construct that allows for quick formulas on related records.
