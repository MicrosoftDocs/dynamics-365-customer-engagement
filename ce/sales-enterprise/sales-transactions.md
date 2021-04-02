---
title: "Sales transactions in Dynamics 365 Sales | MicrosoftDocs"
description: "Understand how quotes and invoices are used in a sales transaction."
ms.date: 08/03/2020
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-quote
  - D365-Entity-order
  - D365-Entity-invoice
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Sales transactions in Dynamics 365 Sales

In Dynamics 365 Sales, a sale typically starts with a draft quote. A quote undergoes several revisions between the salesperson and customer before it is accepted.
After the quote is accepted, an order is generated from the quote. The order is used to fulfill the agreement of goods or
services that were offered in the quote. Finally, after the order for the goods or services is shipped, an invoice is
generated.  

In Dynamics 365 Sales, quotes, orders, and invoices are considered to be the same item, but in different states of transition.

You can start a sales transaction, such as a quote or invoice, from within the opportunity record. The advantage of starting sales transactions in this manner is that much of the information is automatically entered based on the opportunity data. You can also view any sales transaction records from within the opportunity record to track the overall sales process and expected revenue.

## Understanding quote stages

When you create a new quote, it is automatically set to Draft, and the revision ID is set to 0.

Before a quote is sent to a customer, it must be set to Active. Activating a quote makes it read-only so your versions matches the customer's version. If you revise it, the revision ID will increase by one.

When you close a quote, you have three choices: Lost, Canceled, or Revised. If you revise it, a new quote is created, set to Draft status, and you can start over. If you do not revise it, the quote is closed.

## Differences between Current Pricing and Prices Locked in invoices

Dynamics 365 Sales has two kinds of pricing behavior on orders and invoices: **Use Current Pricing** and **Prices Locked**.

The **Use Current Pricing** price comes directly from the product catalog. If you change the price of a product there, then it changes in all open invoices that include the product.

**Prices Locked** locks the price for a product in an open order or invoice. Even if the price changes in the product catalog, that order or invoice remains at the agreed price.

### See also

[Create or edit quotes](create-edit-quote-sales.md)  
[Create or edit orders](create-edit-order-sales.md)  
[Create or edit invoices](create-edit-invoice-sales.md)  
[Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
